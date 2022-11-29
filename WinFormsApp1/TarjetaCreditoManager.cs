using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1 {
	public class TarjetaCreditoManager {
		public int id { get; set; }
		public int codigoV { get; set; }
		public string numero { get; set; }
		public float limite { get; set; }
		public float consumo { get; set; }
		public bool borrado { get; set; }
		public int titularId { get; set; }

		public TarjetaCreditoManager() { }

		public TarjetaCreditoManager(int id, float limite, int titularId) {
			this.id = id;
			Random rd = new Random();
			this.numero = rd.Next(1000, 9999) + " " + rd.Next(1000, 9999) + " " + rd.Next(1000, 9999) + " " + rd.Next(1000, 9999);
			this.codigoV = rd.Next(100, 999);
			this.limite = limite;
			this.consumo = 0;
			this.titularId = titularId;
		}

		public TarjetaCreditoManager(int id, string numero, int codigoV, float limite, float consumo, bool borrado, int titularId) {
			this.id = id;
			this.numero = numero;
			this.codigoV = codigoV;
			this.limite = limite;
			this.consumo = consumo;
			this.borrado = borrado; 
			this.titularId = titularId;
		}

		public string[] toArray() {
			return new string[] {
				this.numero,
				this.codigoV.ToString(),
				this.limite.ToString("C"),
				this.consumo.ToString("C")
			};
		}
	}
}
