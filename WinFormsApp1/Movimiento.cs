using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1 {
	public class Movimiento {
		public int id { get; set; }
		public string detalle { get; set; }
		public float monto { get; set; }
		public DateTime fecha { get; set; }
		private CajaAhorro cajaAhorro;

		public Movimiento() { }

		public Movimiento(string detalle, float monto, CajaAhorro cajaAhorro) {
			this.detalle = detalle;
			this.monto = monto;
			this.fecha = DateTime.Now;
			this.cajaAhorro = cajaAhorro;
		}

		public Movimiento(int id, string detalle, float monto, CajaAhorro cajaAhorro) {
			this.id = id;
			this.detalle = detalle;
			this.monto = monto;
			this.fecha = DateTime.Now;
			this.cajaAhorro = cajaAhorro;
		}

		public string[] toArray() {
			return new string[] { this.detalle, this.monto, this.fecha };
		}
}
