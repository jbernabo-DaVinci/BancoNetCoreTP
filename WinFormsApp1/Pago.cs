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
		public int usuarioId { get; set; }

		public Pago() { }

		public Pago(string nombre, float monto) {
			this.nombre = nombre;
			this.monto = monto;
		}

		public Pago(int id, string nombre, float monto, int usuarioId) {
			this.id = id;
			this.nombre = nombre;
			this.monto = monto;
			this.pagado = false;
			this.borrado = false;
			this.usuarioId = usuarioId;
		}

		public Pago(int id, string nombre, float monto, bool pagado, bool borrado, int usuarioId) {
			this.id = id;
			this.nombre = nombre;
			this.monto = monto;
			this.pagado = pagado;
			this.borrado = borrado;
			this.usuarioId = usuarioId;
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
			return new string[] { this.id.ToString(), this.nombre, this.monto.ToString("C") };
		}
	}
}
