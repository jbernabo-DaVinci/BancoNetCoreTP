using System.Drawing.Text;
using static WinFormsApp1.Signup;

namespace WinFormsApp1 {
	public partial class Form1 : Form {
		private Banco banco;
		Signup signup;
		Login login;
		string usuario;

		public Form1() {
			InitializeComponent();
			this.banco = new Banco();
			this.signup = new Signup(banco);
			this.signup.MdiParent = this;
			this.signup.TransfEvento += this.TransfDelegadoSignup;
			this.signup.Show();
		}

		public void TransfDelegadoSignup() {
			this.signup.Close();
			this.login = new Login(banco);
			this.login.MdiParent = this;
			this.login.TransfEvento += this.TransfDelegadoLogin;
			this.login.Show();
		}

		public void TransfDelegadoLogin(int dni, string pass) {
			if (!this.banco.iniciarSesion(dni, pass)) {
				MessageBox.Show("Error en el log In");
				return;
			}

			this.usuario = this.banco.getNombreCurrentUser();
			MessageBox.Show("Log In Correcto!!");
		}
	}
}
