using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1 {
	public class Pago {
		public int id { get; set; }
		public string nombre { get; set; }
		public float monto { get; set; }
		public bool pagado { get; set; }
		public bool borrado { get; set; }
		private Usuario usuario;

		public Pago() { }

		public Pago(string nombre, float monto) {
			this.nombre = nombre;
			this.monto = monto;
		}

		public Pago(int id, string nombre, float monto, Usuario usuario) {
			this.id = id;
			this.nombre = nombre;
			this.monto = monto;
			this.pagado = false;
			this.usuario = usuario;
		}

		public void pagarPago() {
			this.pagado = true;
		}

		public bool borrar() {
			if (!this.pagado) return false;
			this.borrado = true;
			return true;
		}

		public string[] toArray() {
			return new string[] { this.id, this.nombre, this.monto.ToString("C") };
		}
	}
}
