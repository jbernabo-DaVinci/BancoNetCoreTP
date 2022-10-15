using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1 {
	public partial class Detalles : Form {
		public object[] argumentos;
		List<List<string>> datos;
		public string name;
		public Banco banco;
		public int id;

		public Detalles(string name, Banco banco, int id) {
			this.banco = banco;
			this.name = name;
			this.id = id;
		}

		public Detalles(object[] args) {
			InitializeComponent();
			this.banco = (Banco)args[1];
			this.argumentos = args;
			label5.Text = (string)args[0];
			this.datos = new List<List<string>>();
		}
	}
}
