using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static WinFormsApp1.Signup;

namespace WinFormsApp1 {
	public partial class Login : Form {
		public Banco banco;
		public TransfDelegado TransfEvento;

		public Login(Banco banco) {
			InitializeComponent();
			this.banco = banco;
		}

		private void loginButton_Click(object sender, EventArgs e) {
			int dni;
			bool isParsable = Int32.TryParse(loginDNIBox.Text, out dni);
			string pass = loginPassBox.Text;
			if (!isParsable || string.IsNullOrEmpty(pass)) {
				MessageBox.Show("Error en el login");
				return;
			}
			this.TransfEvento(dni, pass);
		}

		public delegate void TransfDelegado(int dni, string pass);

		private void hideEye_Click(object sender, EventArgs e) {
			this.hideEye.Visible = false;
			this.showEye.Visible = true;
		}

		private void showEye_Click(object sender, EventArgs e) {
			this.showEye.Visible = false;
			this.hideEye.Visible = true;
		}
	}
}
