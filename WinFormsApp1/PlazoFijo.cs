using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1 {
	public class PlazoFijo {
		public int id { get; set; }
		public float tasa { get; set; }
		public float monto { get; set; }
		public bool pagado { get; set; }
		public bool borrado { get; set; }
		public DateTime fechaInicio { get; set; }
		public DateTime fechaFin { get; set; }

		public Usuario titular;


		public PlazoFijo() { }

		public PlazoFijo(int id, float monto, Usuario titular) {
			this.id = id;
			this.tasa = 0.2;
			this.monto = monto;
			this.titular = titular;
			this.fechaInicio = DateTime.Now;
			this.fechaInicio = DateTime.Now.AddMonths(1);
			this.pagado = false;
			this.borrado = false;
		}

		public string[] toArray() {
			return new string[] {
				this.tasa.ToString("C"),
				this.monto.ToString("C"),
				this.fechaInicio.ToString("G"),
				this.fechaFin.ToString("G")
			};
		}
}
