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
        public string dni;
        public string pass;
        public Banco elBanco;

        public TransfDelegado TransfEvento;
        public Login(Banco b)
        {
            InitializeComponent();
            elBanco = b;
            
        }

        
        private void loginButton_Click(object sender, EventArgs e)
        {
            dni = loginDNIBox.Text;
            pass = loginPassBox.Text;
            if (dni != null && dni != "")
            {
                this.TransfEvento(dni, pass);
            }
            else
                MessageBox.Show("Debe ingresar un dni!");
        }

        public delegate void TransfDelegado(string dni, string pass);

        private void hideEye_Click(object sender, EventArgs e)
        {
            this.hideEye.Visible = false;
            this.showEye.Visible = true;
        }

        private void showEye_Click(object sender, EventArgs e)
        {
            this.showEye.Visible = false;
            this.hideEye.Visible = true;
        }

        
    }
}
