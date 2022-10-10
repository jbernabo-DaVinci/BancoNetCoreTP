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

namespace WinFormsApp1
{
    public partial class Signup : Form
    {
        public string usuario;
        public string pass;
        public Banco elBanco;

        public TransfDelegado TransfEvento;

        public Signup(Banco b)
        {
            InitializeComponent();
            elBanco = b;
        }

        public delegate void TransfDelegado(string usuario, string pass);

        private void signupButton_Click(object sender, EventArgs e)
        {
            if (elBanco.agregarUsuario(signupUserBox.Text, signupPassBox.Text))
            {
                MessageBox.Show("Usuario Agregado con éxito");
                usuario = signupUserBox.Text;
                pass = signupPassBox.Text;
                this.TransfEvento(usuario, pass);
            }
            else
                MessageBox.Show("No se pudo agregar el usuario");
        }

        private void signupPassBoxConfirm_TextChanged(object sender, EventArgs e)
        {

        }

        private void signupUserBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
