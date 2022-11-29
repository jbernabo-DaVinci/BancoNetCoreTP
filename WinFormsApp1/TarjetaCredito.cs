using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1 {
	public class TarjetaCredito
	{
		public int id { get; set; }
		public int codigoV { get; set; }
		public string numero { get; set; }
		public float limite { get; set; }
		public float consumo { get; set; }
		public bool borrado { get; set; }

		public Usuario titular;


		public TarjetaCredito() { }

		public TarjetaCredito(int id, float limite, Usuario titular)
		{
			this.id = id;
			Random rd = new Random();
			this.numero = rd.Next(1000, 9999) + " " + rd.Next(1000, 9999) + " " + rd.Next(1000, 9999) + " " + rd.Next(1000, 9999);
			this.codigoV = rd.Next(100, 999);
			this.limite = limite;
			this.consumo = 0;
			this.titular = titular;
		}

		public string[] toArray()
		{
			return new string[] {
				this.numero,
				this.codigoV.ToString(),
				this.limite.ToString("C"),
				this.consumo.ToString("C")
			};
		}
	}
}
