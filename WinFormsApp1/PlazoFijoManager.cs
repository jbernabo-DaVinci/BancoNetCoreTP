using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1 {
	public class PlazoFijoManager
	{
		public int id { get; set; }
		public float tasa { get; set; }
		public float monto { get; set; }
		public bool pagado { get; set; }
		public bool borrado { get; set; }
		public DateTime fechaInicio { get; set; }
		public DateTime fechaFin { get; set; }
		public int titularId { get; set; }


		public PlazoFijoManager() { }

		public PlazoFijoManager(int id, float monto, int titularId)
		{
			this.id = id;
			this.tasa = 0.2f;
			this.monto = monto;
			this.titularId = titularId;
			this.fechaInicio = DateTime.Now;
			this.fechaInicio = DateTime.Now.AddMonths(1);
			this.pagado = false;
			this.borrado = false;
		}

		public PlazoFijoManager(
				int id,
				float tasa,
				float monto,
				bool pagado,
				bool borrado,
				DateTime fechaInicio,
				DateTime fechaFin,
				int titularId)
		{
			this.id = id;
			this.tasa = tasa;
			this.monto = monto;
			this.titularId = titularId;
			this.fechaInicio = fechaInicio;
			this.fechaInicio = fechaFin;
			this.pagado = pagado;
			this.borrado = borrado;
		}

		public string[] toArray()
		{
			return new string[] {
				this.tasa.ToString("C"),
				this.monto.ToString("C"),
				this.fechaInicio.ToString("G"),
				this.fechaFin.ToString("G")
			};
		}

	}
}
