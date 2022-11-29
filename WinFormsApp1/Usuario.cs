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
		public int intentosFallidos { get; set; } //Francisco: no sé si este dato deba ir en la BD como autoincremental o no ir del todo
		public bool bloqueado { get; set; }
		public bool borrado { get; set; }
		public bool isAdmin { get; set; }

		public List<CajaAhorro> cajasAhorro;
		public List<PlazoFijoManager> plazosFijos;
		public List<TarjetaCreditoManager> tarjetasCredito;
		public List<Pago> pagos;

		public Usuario() { }

		public Usuario(int id, int dni, string nombre, string pass) {
			this.id = id;
			this.dni = dni;
			this.nombre = nombre;
			this.pass = pass;
			this.bloqueado = false;
			this.borrado = false;
			this.isAdmin = false;
			this.cajasAhorro = new List<CajaAhorro>();
			this.plazosFijos = new List<PlazoFijoManager>();
			this.tarjetasCredito = new List<TarjetaCreditoManager>();
			this.pagos = new List<Pago>();
		}

		public Usuario(int id, string nombre, string pass) {
			this.id = id;
			this.nombre = nombre;
			this.pass = pass;
			this.bloqueado = false;
			this.borrado = false;
			this.isAdmin = false;
			this.cajasAhorro = new List<CajaAhorro>();
			this.plazosFijos = new List<PlazoFijoManager>();
			this.tarjetasCredito = new List<TarjetaCreditoManager>();
			this.pagos = new List<Pago>();
		}
		
		//este es el constructor que usaremos para la conexión a la BD
		public Usuario(int id, int dni, string nombre, string pass, string mail, int intentosFallidos, bool bloqueado, bool borrado, bool isAdmin) {
			this.id = id;
			this.dni = dni;
			this.nombre = nombre;
			this.pass = pass;
			this.mail = mail;
			this.intentosFallidos = intentosFallidos;
			this.bloqueado = bloqueado;
			this.borrado = borrado;
			this.isAdmin = isAdmin;
			this.cajasAhorro = new List<CajaAhorro>();
			this.plazosFijos = new List<PlazoFijoManager>();
			this.tarjetasCredito = new List<TarjetaCreditoManager>();
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

		public bool agregarCajaAhorro(CajaAhorro cajaAhorro) {
			int cajaIndex = this.cajasAhorro.FindIndex(caja => caja.id == cajaAhorro.id);
			if (cajaIndex != -1) return false;
			this.cajasAhorro.Add(cajaAhorro);
			return true;
		}

		public bool removerCajaAhorro(CajaAhorro cajaAhorro) {
			int cajaIndex = this.cajasAhorro.FindIndex(caja => caja.id == cajaAhorro.id);
			if (cajaIndex == -1) return false;
			this.cajasAhorro.RemoveAt(cajaIndex);
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

		public bool agregarPago(Pago pago) {
			int pagoIndex = this.pagos.FindIndex(currentPago => currentPago.id == pago.id);
			if (pagoIndex != -1) return false;
			this.pagos.Add(pago);
			return true;
		}

		public bool agregarPlazoFijo(PlazoFijoManager plazoFijo) {
			int plazoFijoIndex = this.plazosFijos.FindIndex(currentPlazoFijo => currentPlazoFijo.id == plazoFijo.id);
			if (plazoFijoIndex != -1) return false;
			this.plazosFijos.Add(plazoFijo);
			return true;
		}

		public bool agregarTarjetaCredito(TarjetaCreditoManager tarjetaCredito) {
			int Index = this.tarjetasCredito.FindIndex(currentTarjetaCredito => currentTarjetaCredito.id == pago.id);
			if (Index != -1) return false;
			this.tarjetasCredito.Add(tarjetaCredito);
			return true;
		}

		public void failLogin() {
			this.intentosFallidos++;
			if(this.intentosFallidos >= 3) {
				this.bloqueado = true;
			}
		}

		public List<Pago> obtenerPagosPagados() {
			return this.obtenerPagos(true);
		}

		public List<Pago> obtenerPagosNoPagados() {
			return this.obtenerPagos(false);
		}

		public List<Pago> obtenerPagos(bool pagadoCondition) {
			List<Pago> pagosFiltered = new List<Pago>();
			foreach(Pago currentPago in this.pagos) {
				if (currentPago.borrado) continue;
				if (currentPago.pagado != pagadoCondition) continue;
				pagosFiltered.Add(currentPago);
			}
			return pagosFiltered.ToList();
		}

		public List<PlazoFijoManager> obtenerPlazosFijos() {
			List<PlazoFijoManager> plazosFijosFiltered = new List<PlazoFijoManager>();
			foreach(PlazoFijoManager currentPlazoFijo in this.plazosFijos) {
				if (currentPlazoFijo.borrado) continue;
				plazosFijosFiltered.Add(currentPlazoFijo);
			}
			return plazosFijosFiltered.ToList();
		}

		public List<TarjetaCreditoManager> obtenerTarjetasCredito() {
			List<TarjetaCreditoManager> tarjetasCreditoFiltered = new List<TarjetaCreditoManager>();
			foreach(TarjetaCreditoManager currentTarjetaCredito in this.tarjetasCredito) {
				if (currentTarjetaCredito.Pago) continue;
				tarjetasCreditoFiltered.Add(currentTarjetaCredito);
			}
			return tarjetasCreditoFiltered.ToList();
		}

		public string[] toArray() {
			return new string[] { this.id.ToString(), this.dni.ToString(), this.nombre };
		}
	}
}
