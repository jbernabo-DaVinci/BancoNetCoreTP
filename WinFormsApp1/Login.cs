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

namespace WinFormsApp1
{
    public partial class Login : Form
    {
        public string usuario;
        public string pass;
        public Banco elBanco;

        public TransfDelegado TransfEvento;
        public Login(Banco b)
        {
            InitializeComponent();
            elBanco = b;
            
        }

        //showEye_Click.Visible = false;
        private void loginButton_Click(object sender, EventArgs e)
        {
            usuario = loginUserBox.Text;
            pass = loginPassBox.Text;
            if (usuario != null && usuario != "")
            {
                this.TransfEvento(usuario, pass);
            }
            else
                MessageBox.Show("Debe ingresar un usuario!");
        }

        public delegate void TransfDelegado(string usuario, string pass);

        private void hideEye_Click(object sender, EventArgs e)
        {
            
        }

        private void showEye_Click(object sender, EventArgs e)
        {

        }
    }
}
