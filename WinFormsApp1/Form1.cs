using System.Drawing.Text;
using static WinFormsApp1.Signup;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private Banco banco;
        Signup signup;
        Login login;
        string usuario;
        string pass;

        public Form1()
        {
            InitializeComponent();
            banco = new Banco();
            signup = new Signup(banco);
            signup.MdiParent = this;
            signup.TransfEvento += TransfDelegado;
            signup.Show();

        }

        public void TransfDelegado(string usuario, string pass) {
            signup.Close();
            login = new Login(banco);
            login.MdiParent = this;
            login.TransfEvento += TransfDelegado2;
            MessageBox.Show(usuario, pass);
            login.Show();
        }

        public void TransfDelegado2(string usuario, string pass) {
            MessageBox.Show(usuario, pass);
            this.usuario = usuario;
            this.pass = pass;
            if (banco.iniciarSesion(usuario,pass))
            {
                MessageBox.Show("Log In Correcto!!");

            }
            else
            {
                MessageBox.Show("Error en el log In");
            }
        }

    }
}