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

namespace WinFormsApp1 {
	public partial class Signup : Form {
		public string usuario;
		public string pass;
		public Banco elBanco;

		public TransfDelegado TransfEvento;

		public Signup(Banco b) {
			InitializeComponent();
			elBanco = b;
		}

		public delegate void TransfDelegado(string usuario, string pass);

		private void signupButton_Click(object sender, EventArgs e) {
			int dni = Int32.Parse(textBox1.Text);
			string name = signupUserBox.Text;
			string pass = signupPassBox.Text;
			if (!elBanco.agregarUsuario(dni, name, pass)) {
				MessageBox.Show("No se pudo agregar el usuario");
				return;
			}

			MessageBox.Show("Usuario Agregado con éxito");
			usuario = signupUserBox.Text;
			pass = signupPassBox.Text;
			this.TransfEvento(usuario, pass);
		}
	}
}
