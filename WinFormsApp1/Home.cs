﻿using System;
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
		}

		private void button1_Click(object sender, EventArgs e) {
			this.refreshDataCajasAhorro();
		}

		private void refreshDataCajasAhorro() {
			dataGridView1.Rows.Clear();

			foreach (CajaAhorro cajaAhorro in this.banco.obtenerCajasAhorro()) {
				dataGridView1.Rows.Add(cajaAhorro.toArray());
			}
		}
	}
}
