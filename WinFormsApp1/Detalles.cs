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
		public TransfDelegado TransfEventoBack;
		public TransfDelegado TransfEventoEdit;

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
			label1.Text = (string)args[4]; //saldo
			label7.Text = (string)args[3]; //cbu
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
			this.label1.Text = this.banco.getCajaAhorroSaldo(this.id);
			this.textBox1.Text = "";
			this.textBox2.Text = "";
			this.refreshDataMovimiento();
		}

		public void onClickDepositar(object sender, EventArgs e) {
			float monto = float.Parse(this.textBox1.Text, System.Globalization.CultureInfo.InvariantCulture);
			if (!this.banco.depositar(this.id, monto)){
				MessageBox.Show("Error al depositar");
				return;
			}
			this.refreshData();
		}

		public void onClickRetirar(object sender, EventArgs e) {
			float monto = float.Parse(this.textBox1.Text, System.Globalization.CultureInfo.InvariantCulture);
			if (!this.banco.retirar(this.id, monto)){
				MessageBox.Show("Error al retirar");
				return;
			}
			this.refreshData();
		}

		public void onClickTransferir(object sender, EventArgs e) {
			float monto = float.Parse(this.textBox1.Text, System.Globalization.CultureInfo.InvariantCulture);
			if (!this.banco.transferir(this.id, textBox2.Text, monto)){
				MessageBox.Show("Error al transferir");
				return;
			}
			this.refreshData();
		}

		public void onClickBack(object sender, EventArgs e) {
			this.TransfEventoBack();
		}

		public void onClickDeleteCajaAhorro(object sender, EventArgs e) {
			if (!this.banco.bajaCajaAhorro(this.id)){
				MessageBox.Show("Error al eliminar caja de ahorro");
				return;
			}
			this.TransfEventoBack();
		}

		public void onClickEditarTitulares(object sender, EventArgs e) {
			this.TransfEventoEdit();
		}

		public delegate void TransfDelegado();

	}
}
