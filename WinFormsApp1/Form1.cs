using System.Drawing.Text;
using static WinFormsApp1.Signup;

namespace WinFormsApp1 {
	public partial class Form1 : Form {
		private Banco banco;
		Signup signup;
		Login login;
		Home home;
		Detalles detalle;
		string name;

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
			this.login.Show();
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
			this.home.Show();
		}

		public void TransfDelegadoHomeToDetallesCajaAhorro(int id) {
			this.home.Close();
			CajaAhorro currentCajaAhorro = this.banco.getCajaAhorro(id);
			this.detalle = new Detalles(new object[] {this.name, this.banco, id, currentCajaAhorro[1], currentCajaAhorro[2]});
			this.detalle.name = this.name;
			this.detalle.MdiParent = this;
			this.detalle.Show();
		}
	}
}
