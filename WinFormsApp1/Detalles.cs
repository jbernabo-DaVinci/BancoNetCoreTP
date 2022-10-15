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
		public Banco banco;
		public string saldo;
		public string name;
		public string cbu;
		public int id;

		public Detalles(string name, Banco banco, int id, string saldo, string cbu) {
			this.banco = banco;
			this.saldo = saldo;
			this.name = name;
			this.cbu = cbu;
			this.id = id;
		}

		public Detalles(object[] args) {
			InitializeComponent();
			this.banco = (Banco)args[1];
			this.argumentos = args;
			label5.Text = (string)args[0]; //name
			label7.Text = (string)args[3]; //saldo
			label1.Text = (string)args[4]; //cbu
			this.id = (int)args[2]; //id
			this.datos = new List<List<string>>();
		}
	}
}
