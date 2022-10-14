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
		public Banco banco;

		public TransfDelegado TransfEvento;

		public Signup(Banco banco) {
			InitializeComponent();
			this.banco = banco;
		}

		public delegate void TransfDelegado();

		private void signupButton_Click(object sender, EventArgs e) {
			int dni;
			bool isParsable = Int32.TryParse(textBox1.Text, out dni);
			string name = signupUserBox.Text;
			string pass = signupPassBox.Text;
			if (!isParsable || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(pass)) {
				MessageBox.Show("Error en el signUp");
				return;
			}

			if (!this.banco.agregarUsuario(dni, name, pass)) {
				MessageBox.Show("No se pudo agregar el usuario");
				return;
			}

			MessageBox.Show("Usuario Agregado con éxito");
			this.TransfEvento();
		}
	}
}
