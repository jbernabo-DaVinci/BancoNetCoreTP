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

		public Pago(int id, string nombre, float monto, Usuario usuario) {
			this.id = id;
			this.nombre = nombre;
			this.monto = monto;
			this.pagado = false;
			this.usuario = usuario;
		}

		public updateInfo(string nombre, float monto, bool pagado) {
			this.nombre = nombre;
			this.monto = monto;
			this.pagado = pagado;
		}

		public void borrar() {
			this.borrado = true;
		}

		public string[] toArray() {
			return new string[] { this.nombre, this.monto, this.pagado };
		}
	}
}
