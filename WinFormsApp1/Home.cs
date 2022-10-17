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
	public partial class Home : Form {
		public object[] argumentos;
		List<List<string>> datos;
		public string name;
		public Banco banco;
		public int currentPagoSeleccionadoId;
		public TransfDelegado TransfEvento;
		public TransfDelegado TransfEventoLoggout;
		public TransfDelegado TransfEventoPagarPago;

		public Home(string name, Banco banco) {
			this.banco = banco;
			this.name = name;
		}

		public Home(object[] args) {
			InitializeComponent();
			this.banco = (Banco)args[1];
			this.argumentos = args;
			label2.Text = (string)args[0];
			this.datos = new List<List<string>>();
			this.refreshDataCajasAhorro();
			this.refreshDataPagosPagados();
			this.refreshDataPagosNoPagados();
		}

		//-----------Functions of CajaAhorro-----------

		private void onCreateNewCajaAhorro(object sender, EventArgs e) {
			if (!this.banco.crearCajaAhorro()) {
				MessageBox.Show("Error al crear nueva caja de ahorro");
				return;
			}

			this.refreshDataCajasAhorro();
		}

		private void refreshDataCajasAhorro() {
			dataGridView1.Rows.Clear();

			foreach (CajaAhorro cajaAhorro in this.banco.obtenerCajasAhorro()) {
				dataGridView1.Rows.Add(cajaAhorro.toArray());
			}
		}

		public void onDetalleCajaAhorro(object sender, DataGridViewCellEventArgs e) {
			if (this.dataGridView1.SelectedRows.Count != 1) {
				MessageBox.Show("Error al mostrar detalles");
				return;
			}

			int id = Int32.Parse(dataGridView1[0, e.RowIndex].Value.ToString());
			this.TransfEvento(id);
		}

		//-----------Functions of Pagos-----------

		private void refreshDataPagosNoPagados() {
			this.dataGridView3.Rows.Clear();

			foreach (Pago pago in this.banco.obtenerPagosNoPagados()) {
				this.dataGridView3.Rows.Add(pago.toArray());
			}
		}

		private void refreshDataPagosPagados() {
			this.dataGridView4.Rows.Clear();

			foreach (Pago pago in this.banco.obtenerPagosPagados()) {
				this.dataGridView4.Rows.Add(pago.toArray());
			}
		}

		public void onClickAgregarPago(object sender, EventArgs e) {
			string nombre = this.textBox1.Text;
			float monto = float.Parse(this.textBox2.Text, System.Globalization.CultureInfo.InvariantCulture);
			if (!this.banco.crearPago(nombre, monto)){
				MessageBox.Show("Error al agregar pago");
				return;
			}
			this.textBox1.Text = "";
			this.textBox2.Text = "";
			this.refreshDataPagosNoPagados();
		}

		public void onCellClickPagosPagados(object sender, DataGridViewCellEventArgs e) {
			if (this.dataGridView4.SelectedRows.Count != 1) {
				MessageBox.Show("Error al seleccionar pago");
				return;
			}

			this.currentPagoSeleccionadoId = Int32.Parse(dataGridView4[0, e.RowIndex].Value.ToString());
		}

		public void onCellClickPagosNoPagados(object sender, DataGridViewCellEventArgs e) {
			if (this.dataGridView3.SelectedRows.Count != 1) {
				MessageBox.Show("Error al seleccionar pago");
				return;
			}

			this.currentPagoSeleccionadoId = Int32.Parse(dataGridView3[0, e.RowIndex].Value.ToString());
		}

		public void onClickEliminarPago(object sender, EventArgs e) {
			if (!this.banco.bajaPago(this.currentPagoSeleccionadoId)){
				MessageBox.Show("Error al eliminar pago");
				return;
			}
			this.refreshDataPagosPagados();
		}

		public void onClickPagarPago(object sender, EventArgs e) {
			this.TransfEventoPagarPago(this.currentPagoSeleccionadoId);
		}


		//-----------Functions of Home-----------

		public void onClickLoggout(object sender, EventArgs e) {
			this.banco.cerrarSesion();
			this.TransfEventoLoggout(0); //@TODO: improve this later
		}

		public delegate void TransfDelegado(int id);
	}
}
