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
			this.refreshDataMovimiento();
		}

		private void refreshDataMovimiento() {
			dataGridView1.Rows.Clear();

			foreach (Movimiento movimiento in this.banco.detalleCajaAhorro(this.id)) {
				dataGridView1.Rows.Add(movimiento.toArray());
			}
		}

		private void refreshData() {
			this.label7.Text = this.banco.getCajaAhorroSaldo(this.id);
			this.refreshDataMovimiento();
		}

		public void onClickDepositar(object sender, EventArgs e) {
			float monto = float.Parse(this.textBox1.Text, System.Globalization.CultureInfo.InvariantCulture);
			this.banco.depositar(this.id, monto);
			this.refreshData();
		}

		public void onClickRetirar(object sender, EventArgs e) {
			float monto = float.Parse(this.textBox1.Text, System.Globalization.CultureInfo.InvariantCulture);
			this.banco.retirar(this.id, monto);
			this.refreshData();
		}

		public void onClickTransferir(object sender, EventArgs e) {
			float monto = float.Parse(this.textBox1.Text, System.Globalization.CultureInfo.InvariantCulture);
			this.banco.transferir(this.id, textBox2.Text, monto);
			this.refreshData();
		}

	}
}
