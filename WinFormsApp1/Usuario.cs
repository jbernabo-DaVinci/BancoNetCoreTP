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
		public bool borrado { get; set; }
		private List<CajaAhorro> cajasAhorro;
		private List<PlazoFijo> plazosFijos;
		private List<TarjetaCredito> tarjetasCredito;
		private List<Pago> pagos;

		public Usuario() { }

		//TODO: for sing up, use this constructor.
		public Usuario(int id, int dni, string nombre, string pass) {
			this.id = id;
			this.dni = dni;
			this.nombre = nombre;
			this.pass = pass;
			this.bloqueado = false;
			this.borrado = false;
			this.cajasAhorro = new List<CajaAhorro>();
			this.plazosFijos = new List<PlazoFijo>();
			this.tarjetasCredito = new List<TarjetaCredito>();
			this.pagos = new List<Pago>();
		}

		public Usuario(int id, string nombre, string pass) {
			this.id = id;
			this.nombre = nombre;
			this.pass = pass;
			this.bloqueado = false;
			this.borrado = false;
			this.cajasAhorro = new List<CajaAhorro>();
			this.plazosFijos = new List<PlazoFijo>();
			this.tarjetasCredito = new List<TarjetaCredito>();
			this.pagos = new List<Pago>();
		}

		public void updateInfo(string nombre, string pass, string mail) {
			this.nombre = nombre;
			this.pass = pass;
			this.mail = mail;
		}

		public void borrar() {
			this.borrado = true;
		}

		public void deleteCajaAhorro(int cajaAhorroId) {
			int cajaIndex = this.cajasAhorro.FindIndex(caja => caja.id == cajaAhorroId);
			CajaAhorro currentCajaAhorro = this.cajasAhorro[cajaIndex];
			currentCajaAhorro.borrar();
			this.cajasAhorro[cajaIndex] = currentCajaAhorro;
		}

		public bool agregarCajaAhorro(CajaAhorro cajaAhorro) {
			int cajaIndex = this.cajasAhorro.FindIndex(caja => caja.id == cajaAhorro.id);
			if (cajaIndex != -1) return false;
			this.cajasAhorro.Add(cajaAhorro);
			return true;
		}

		public List<CajaAhorro> obtenerCajasAhorro() {
			List<CajaAhorro> cajasAhorroFiltered = new List<CajaAhorro>();
			foreach(CajaAhorro currentCajaAhorro in this.cajasAhorro) {
				if (currentCajaAhorro.borrado) continue;
				cajasAhorroFiltered.Add(currentCajaAhorro);
			}
			return cajasAhorroFiltered.ToList();
		}

		public string[] toArray() {
			return new string[] { this.nombre, this.pass };
		}
	}
}
