using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1 {
	public class Usuario {
		public int id { get; set; }
		public int dni { get; set; }
		public string nombre { get; set; }
		public string pass { get; set; }
		public string mail { get; set; }
		public int intentosFallidos { get; set; }
		public bool bloqueado { get; set; }
		private List<CajaAhorro> cajasAhorro;
		private List<PlazoFijo> plazosFijos;
		private List<TarjetaCredito> tarjetasCredito;
		private List<Pago> pagos;

		public Usuario() { }

		public Usuario(string nombre, string pass) {
			this.nombre = nombre;
			this.pass = pass;
		}

		public string[] toArray() {
			return new string[] { this.nombre, this.pass };
		}
	}
}
