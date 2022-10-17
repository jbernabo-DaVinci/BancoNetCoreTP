using System.Drawing.Text;
using static WinFormsApp1.Signup;

namespace WinFormsApp1 {
	public partial class Form1 : Form {
		private Banco banco;
		Signup signup;
		Login login;
		Home home;
		Detalles detalle;
		ModificarCajas modificarCajas;
		PagarPagos pagarPagos;
		string name;
		int currentCajaAhorroId; //@TODO: improve this later

		public Form1() {
			InitializeComponent();
			this.banco = new Banco();
			this.signup = new Signup(this.banco);
			this.signup.MdiParent = this;
			this.signup.TransfEvento += this.TransfDelegadoSignup;
			this.signup.Show();
		}

		public void TransfDelegadoSignup() {
			this.signup.Close();
			this.login = new Login(this.banco);
			this.login.MdiParent = this;
			this.login.TransfEvento += this.TransfDelegadoLogin;
			this.login.TransfEventoToSingUp += this.TransfDelegadoSignup;
			this.login.Show();
		}

		public void TransfDelegadoSignup(int dni, string pass) {
			this.login.Close();
			this.signup = new Signup(this.banco);
			this.signup.MdiParent = this;
			this.signup.TransfEvento += this.TransfDelegadoSignup;
			this.signup.Show();
		}

		public void TransfDelegadoLogin(int dni, string pass) {
			if (!this.banco.iniciarSesion(dni, pass)) {
				MessageBox.Show("Error en el log In");
				return;
			}

			this.name = this.banco.getNombreCurrentUser();
			MessageBox.Show("Log In Correcto!!");

			this.login.Close();
			this.home = new Home(new object[] {this.name, this.banco});
			this.home.name = this.name;
			this.home.MdiParent = this;
			this.home.TransfEvento += this.TransfDelegadoHomeToDetallesCajaAhorro;
			this.home.TransfEventoLoggout += this.TransfDelegadoLoggout;
			this.home.TransfEventoLoggout += this.TransfDelegadoPagarPago;
			this.home.Show();
		}

		public void TransfDelegadoHomeToDetallesCajaAhorro(int id) {
			this.home.Close();
			this.currentCajaAhorroId = id;
			string[] currentCajaAhorroData = this.banco.getCajaAhorro(id);
			this.detalle = new Detalles(new object[] {this.name, this.banco, id, currentCajaAhorroData[1], currentCajaAhorroData[2]});
			this.detalle.name = this.name;
			this.detalle.MdiParent = this;
			this.detalle.TransfEventoBack += this.TransfDelegadoDetallesCajaAhorroToHome;
			this.detalle.TransfEventoEdit += this.TransfDelegadoDetallesCajaAhorroToModificar;
			this.detalle.Show();
		}

		public void TransfDelegadoLoggout(int id) {
			this.home.Close();
			this.login = new Login(this.banco);
			this.login.MdiParent = this;
			this.login.TransfEvento += this.TransfDelegadoLogin;
			this.login.TransfEventoToSingUp += this.TransfDelegadoSignup;
			this.login.Show();
		}

		public void TransfDelegadoPagarPago(int id) {
			this.home.Close();
			this.pagarPagos = new PagarPagos(this.banco);
			this.pagarPagos.MdiParent = this;
			this.pagarPagos.Show();
		}

		public void TransfDelegadoDetallesCajaAhorroToHome() {
			this.detalle.Close();
			this.home = new Home(new object[] {this.name, this.banco});
			this.home.name = this.name;
			this.home.MdiParent = this;
			this.home.TransfEvento += this.TransfDelegadoHomeToDetallesCajaAhorro;
			this.home.TransfEventoLoggout += this.TransfDelegadoLoggout;
			this.home.TransfEventoLoggout += this.TransfDelegadoPagarPago;
			this.home.Show();
		}

		public void TransfDelegadoModificarCajaAhorroToHome() {
			this.modificarCajas.Close();
			this.home = new Home(new object[] {this.name, this.banco});
			this.home.name = this.name;
			this.home.MdiParent = this;
			this.home.TransfEvento += this.TransfDelegadoHomeToDetallesCajaAhorro;
			this.home.TransfEventoLoggout += this.TransfDelegadoLoggout;
			this.home.TransfEventoLoggout += this.TransfDelegadoPagarPago;
			this.home.Show();
		}

		public void TransfDelegadoDetallesCajaAhorroToModificar() {
			this.detalle.Close();
			string[] currentCajaAhorroData = this.banco.getCajaAhorro(this.currentCajaAhorroId);
			this.modificarCajas = new ModificarCajas(new object[] {this.name, this.banco, currentCajaAhorroData[1], this.currentCajaAhorroId});
			this.modificarCajas.TransfEventoBack += this.TransfDelegadoModificarCajaAhorroToHome;
			this.modificarCajas.MdiParent = this;
			this.modificarCajas.Show();
		}
	}
}
