using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Home : Form
    {
        public object[] argumentos;
        List<List<string>> datos;
        public string usuario;
        public Banco miBanco;
        public Home(string usuario, Banco b)
        {
            this.miBanco = b;
            this.usuario = usuario;
        }
        public Home(object[] args)
        {
            InitializeComponent();
            miBanco = (Banco)args[1];
            argumentos = args;
            label2.Text = (string)args[0];
            datos = new List<List<string>>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            refreshData();
        }

        private void refreshData()
        {
            //borro los datos
            dataGridView1.Rows.Clear();
            //agrego lo nuevo
            foreach (Usuario user in miBanco.obtenerUsuarios())
                dataGridView1.Rows.Add(user.toArray());
        }
    }
}


