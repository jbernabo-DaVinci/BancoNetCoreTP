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
	public partial class PagarPago : Form {
		public object[] argumentos;
		List<List<string>> datos;
		public string name;
		public Banco banco;
		public int pagoId;
		public int cajaAhorroSelectedId;
		public TransfDelegado TransfEventoBack;

		public PagarPago(string name, Banco banco, int id) {
			this.banco = banco;
			this.name = name;
			this.pagoId = id;
		}

		public PagarPago(object[] args) {
			InitializeComponent();
			this.banco = (Banco)args[1];
			this.argumentos = args;
			this.label6.Text = (string)args[0];
			this.pagoId = (int)args[2];
			this.label1.Text = this.banco.obtenerPagoNombre(this.pagoId);
			this.label3.Text = this.banco.obtenerPagoMonto(this.pagoId);
			this.datos = new List<List<string>>();
			this.refreshDataCajasAhorro();
		}

		private void refreshDataCajasAhorro() {
			this.dataGridView2.Rows.Clear();

			foreach (CajaAhorro cajaAhorro in this.banco.obtenerCajasAhorro()) {
				this.dataGridView2.Rows.Add(cajaAhorro.toArray());
			}
		}

		public void onCellClickSelectCajaAhorro(object sender, DataGridViewCellEventArgs e) {
			if (this.dataGridView2.SelectedRows.Count != 1) {
				MessageBox.Show("Error al seleccionar caja de ahorro");
				return;
			}

			this.cajaAhorroSelectedId = Int32.Parse(dataGridView2[0, e.RowIndex].Value.ToString());
		}

		public void onClickPagarPago(object sender, EventArgs e) {
			if (!this.banco.pagarPago(this.cajaAhorroSelectedId, this.pagoId)){
				MessageBox.Show("Error al pagar pago");
				return;
			}
			MessageBox.Show("Pago realizado");
			this.TransfEventoBack();
		}

		public void onClickBack(object sender, EventArgs e) {
			this.TransfEventoBack();
		}

		public delegate void TransfDelegado();
	}
}
