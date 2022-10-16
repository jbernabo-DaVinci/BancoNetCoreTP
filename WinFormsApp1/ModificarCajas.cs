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
	public partial class ModificarCajas : Form {
		public object[] argumentos;
		List<List<string>> datos;
		public Banco banco;
		public string name;
		public string cbu;
		public int currentCajaAhorroId;
		public TransfDelegado TransfEventoBack;

		public ModificarCajas(string name, Banco banco, string cbu, int id) {
			this.banco = banco;
			this.name = name;
			this.cbu = cbu;
			this.currentCajaAhorroId = id;
		}

		public ModificarCajas(object[] args) {
			InitializeComponent();
			this.banco = (Banco)args[1];
			this.argumentos = args;
			label6.Text = (string)args[0]; //name
			label1.Text = (string)args[2]; //cbu
			this.currentCajaAhorroId = (int)args[3];
			this.datos = new List<List<string>>();
			this.refreshDataTitulares();
		}

		private void refreshDataTitulares() {
			dataGridView4.Rows.Clear();

			foreach (Usuario usuario in this.banco.getCajaAhorroTitulares(this.currentCajaAhorroId)) {
				dataGridView4.Rows.Add(usuario.toArray());
			}
		}

		public void onCellUser(object sender, DataGridViewCellEventArgs e) {
			if (this.dataGridView1.SelectedRows.Count != 1) {
				MessageBox.Show("Error al seleccionar");
				return;
			}

			this.textBox1.Text = dataGridView1[1, e.RowIndex].Value.ToString();
		}

		public void onClickAgregarTitular(object sender, EventArgs e) {
			int dni = Int32.Parse(this.textBox1.Text);
			if (!this.banco.modificarCajaAhorro(this.currentCajaAhorroId, dni, 1)){
				MessageBox.Show("Error al agregar titular");
				return;
			}
			this.refreshDataTitulares();
		}

		public void onClickRemoverTitular(object sender, EventArgs e) {
			int dni = Int32.Parse(this.textBox1.Text);
			if (!this.banco.modificarCajaAhorro(this.currentCajaAhorroId, dni, 2)){
				MessageBox.Show("Error al remover titular");
				return;
			}
			this.refreshDataTitulares();
		}

		public void onClickBack(object sender, EventArgs e) {
			this.TransfEventoBack();
		}

		public delegate void TransfDelegado();

	}
}
