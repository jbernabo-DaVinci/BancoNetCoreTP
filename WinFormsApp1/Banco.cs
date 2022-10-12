using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1 {
	public class Banco {
		private List<Usuario> usuarios;
		private List<CajaAhorro> cajasAhorro;
		//private List<PlazoFijo> plazosFijos;
		//private List<TarjetaCredito> tarjetasCredito;
		private List<Pago> pagos;
		private List<Movimiento> movimientos;
		private Usuario currentUser;

		public Banco() {
			this.usuarios = new List<Usuario>();
			this.cajasAhorro = new List<CajaAhorro>();
			//this.plazosFijos = new List<PlazoFijo>();
			//this.tarjetasCredito = new List<TarjetaCredito>();
			this.pagos = new List<Pago>();
			this.movimientos = new List<Movimiento>();
		} 

		public bool agregarUsuario(string name, string pass) {
			try {
				if (pass.Length < 8) {
					return false;
				}

				int usuarioId = (this.usuarios.Count)+1;
				this.usuarios.Add(new Usuario(id, name, pass));
				return true;

			} catch (Exception ex) {
				return false;
			}
		}

		public bool agregarUsuario(Usuario user) {
			try {
				int usuarioId = (this.usuarios.Count)+1;
				Usuario newUser = new Usuario(usuarioId, user.nombre, user.pass);
				this.usuarios.Add(newUser);
				return true;
			} catch (Exception ex) {
				return false;
			}
		}

		public bool modificarUsuario(int id, string nombre, string pass, string mail) {
			int userIndex = this.usuarios.FindIndex(usuario => usuario.id == id);
			if (userIndex == -1) return false;

			Usuario currentUser = this.usuarios[userIndex];
			currentUser.updateInfo(nombre, pass, mail);
			this.usuarios[userIndex] = currentUser;
			return true;
		}

		public void eliminarUsuario(int usuarioId) {
			int userIndex = this.usuarios.FindIndex(usuario => usuario.id == usuarioId);
			if (userIndex == -1) return false;
			Usuario currentUser = this.usuarios[userIndex];
			currentUser.borrar();
			//TODO: We will remove the rest of products of user before remove user.
			this.usuarios[userIndex] = currentUser;
			return true;
		}

		public bool crearCajaAhorro() {
			int cajaAhorroId = (this.cajasAhorro.Count)+1;
			CajaAhorro cajaAhorro = new CajaAhorro(cajaAhorroId, this.currentUser);
			this.cajasAhorro.Add(cajasAhorro);
			return true;
		}

		public List<CajaAhorro> obtenerCajasAhorro() {
			return this.currentUser.obtenerCajasAhorro();
		}

		public bool altaCajaAhorro(int usuarioId) {
			int userIndex = this.usuarios.FindIndex(usuario => usuario.id == usuarioId);
			if (userIndex == -1) return false;

			Usuario currentUser = this.usuarios[userIndex];
			if (currentUser.borrado) return false;

			int cajaAhorroId = (this.cajasAhorro.Count)+1;
			CajaAhorro cajaAhorro = new CajaAhorro(cajaAhorroId, currentUser);
			if (!currentUser.agregarCajaAhorro()) return false;

			this.cajasAhorro.Add(cajaAhorro);
			return true;
		}

		public bool bajaCajaAhorro(int id) {
			int cajaIndex = this.cajasAhorro.FindIndex(caja => caja.id == id);
			if (cajaIndex == -1) return false;

			CajaAhorro currentCajaAhorro = this.cajasAhorro[cajaIndex];
			if (!currentCajaAhorro.borrar()) return false;

			int[] titularesIds = currentCajaAhorro.getTitularesIds();
			foreach(int titularId in titularesIds) {
				int userIndex = this.usuarios.FindIndex(usuario => usuario.id == titularId);
				Usuario currentUser = this.usuarios[userIndex];
				currentUser.deleteCajaAhorro(currentCajaAhorro.id);
			}

			this.currentCajaAhorro[cajaIndex] = currentCajaAhorro;
			return true;
		}

		//Accion 1 = Agregar titular; Accion 2 = Eliminar titular.
		public bool modificarCajaAhorro(int id, int titularDni, int accion) {
			if (accion != 1 && accion != 2) return false;

			int cajaIndex = this.cajasAhorro.FindIndex(caja => caja.id == id);
			if (cajaIndex == -1) return false;

			CajaAhorro currentCajaAhorro = this.cajasAhorro[cajaIndex];
			int userIndex = this.usuarios.FindIndex(usuario => usuario.dni == titularDni);
			Usuario currentUser = this.usuarios[userIndex];
			if (currentUser.borrado) return false;

			int[] titularesIds = currentCajaAhorro.getTitularesIds();

			if (accion == 1) {
				if (!currentCajaAhorro.addTitular(currentUser)) return false;

				foreach(int titularId in titularesIds) {
					int currentUserIndex = this.usuarios.FindIndex(usuario => usuario.id == titularId);
					Usuario userToUpdate = this.usuarios[currentUserIndex];
					userToUpdate.agregarCajaAhorro(currentCajaAhorro);
				}
			} else if (accion == 2) {
				if (!currentCajaAhorro.removeTitular(currentUser)) return false;

				foreach(int titularId in titularesIds) {
					int currentUserIndex = this.usuarios.FindIndex(usuario => usuario.id == titularId);
					Usuario userToUpdate = this.usuarios[currentUserIndex];
					userToUpdate.deleteCajaAhorro(currentCajaAhorro.id);
				}
			}

			this.cajasAhorro[cajaIndex] = currentCajaAhorro;
			return true;
		}

		public bool iniciarSesion(string dni, string pass) {
			int userIndex = this.usuarios.FindIndex(usuario => usuario.dni == dni);
			if (userIndex == -1) return false;

			Usuario currentUser = this.usuarios[userIndex];
			if (currentUser.borrado || currentUser.bloqueado) return false;

			if (currentUser.pass != pass) {
				currentUser.intentosFallidos++;
				if(currentUser.intentosFallidos >= 3) {
					currentUser.bloqueado = true;
				}
				this.usuarios[userIndex] = currentUser;
				return false;
			}

			this.currentUser = currentUser;
			return true;
		}

		public List<Movimiento> detalleCajaAhorro(int id) {
			int cajaAhorroIndex = this.cajasAhorro.FindIndex(cajaAhorro => cajaAhorro.id == id);
			if (cajaAhorroIndex == -1) return false;

			CajaAhorro currentCajaAhorro = this.cajasAhorro[cajaAhorroIndex];
			if (currentCajaAhorro.borrado) return false;

			return currentCajaAhorro.getDetalle();
		}

		public bool altaMovimiento(Movimiento movimiento, CajaAhorro cajaAhorro) {
			int cajaAhorroIndex = this.cajasAhorro.FindIndex(caja => caja.id == cajaAhorro.id);
			if (cajaAhorroIndex == -1) return false;

			int movimientoId = (this.movimientos.Count)+1;
			Movimiento newMovimiento = new Movimiento(movimientoId, movimiento.detalle, movimiento.monto, movimiento.cajaAhorro);
			this.movimientos.Add(newMovimiento);

			cajaAhorro.addMovimiento(newMovimiento);
			this.cajasAhorro[cajaAhorroIndex] = cajaAhorro;
	
			int[] titularesIds = cajaAhorro.getTitularesIds();

			foreach(int titularId in titularesIds) {
				int currentUserIndex = this.usuarios.FindIndex(usuario => usuario.id == titularId);
				Usuario userToUpdate = this.usuarios[currentUserIndex];
				userToUpdate.updateInfoCajaAhorro(cajaAhorro);
			}

			return true;
		}

		public bool depositar(int cajaAhorroId, float monto) {
			int cajaAhorroIndex = this.cajasAhorro.FindIndex(cajaAhorro => cajaAhorro.id == cajaAhorroId);
			if (cajaAhorroIndex == -1) return false;

			CajaAhorro currentCajaAhorro = this.cajasAhorro[cajaAhorroIndex];
			if (currentCajaAhorro.borrado) return false;

			currentCajaAhorro.depositar(monto);

			Movimiento movimiento = new Movimiento("deposito", monto, currentCajaAhorro);

			if (!this.altaMovimiento(movimiento, currentCajaAhorro)) return false;

			return true;
		}

		public bool retirar(int cajaAhorroId, float monto) {
			int cajaAhorroIndex = this.cajasAhorro.FindIndex(cajaAhorro => cajaAhorro.id == cajaAhorroId);
			if (cajaAhorroIndex == -1) return false;

			CajaAhorro currentCajaAhorro = this.cajasAhorro[cajaAhorroIndex];
			if (currentCajaAhorro.borrado) return false;

			if (!currentCajaAhorro.retirar(monto)) return false;

			Movimiento movimiento = new Movimiento("retiro", monto, currentCajaAhorro);

			if (!this.altaMovimiento(movimiento, currentCajaAhorro)) return false;

			return true;
		}

		public bool transferir(int cajaAhorroOrigenId, int cajaAhorroDestinoId, float monto) {
			if (!this.retirar(cajaAhorroOrigenId, monto)) return false;

			if (!this.depositar(cajaAhorroDestinoId, monto)) return false;

			return true;
		}

		public bool altaPago(Pago pago, int usuarioId) {
			int userIndex = this.usuarios.FindIndex(usuario => usuario.id == usuarioId);
			if (userIndex == -1) return false;

			Usuario currentUser = this.usuarios[userIndex];
			if (currentUser.borrado) return false;

			int pagoId = (this.pagos.Count)+1;
			Pago pago = new Pago(pagoId, pago.nombre, pago.monto, currentUser);
			if (!currentUser.agregarPago()) return false;

			this.Pagos.Add(pago);
			return true;
		}

		public bool modificarPago(int pagoId, string nombre, float monto, bool pagado) {
			int pagoIndex = this.pagos.FindIndex(pago => pago.id == pagoId);
			if (pagoIndex == -1) return false;

			Pago currentPago = this.pagos[pagoIndex];
			if (currentPago.borrado) return false;

			currentPago.updateInfo(nombre, monto, pagado);
			this.pagos[pagoIndex] = currentPago;
			return true;
		}

		public bool bajaPago(int pagoId) {
			int pagoIndex = this.pagos.FindIndex(pago => pago.id == pagoId);
			if (pagoIndex == -1) return false;

			Pago currentPago = this.pagos[pagoIndex];
			currentPago.borrar();
			this.pagos[pagoIndex] = currentPago;
			return true;
		}

		public List<Pago> obtenerPagos() {
			return this.currentUser.obtenerPagos();
		}

		public bool cerrarSesion() {
			this.currentUser = null;
			return true;
		}

		public List<Usuario> obtenerUsuarios() {
			return this.usuarios.ToList();
		}
	}
}
