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

		public bool agregarUsuario(int dni, string name, string pass) {
			try {
				if (pass.Length < 8) {
					return false;
				}

				int usuarioId = (this.usuarios.Count)+1;
				this.usuarios.Add(new Usuario(usuarioId, dni, name, pass));
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
			try {
				int userIndex = this.usuarios.FindIndex(usuario => usuario.id == id);
				if (userIndex == -1) return false;

				Usuario currentUser = this.usuarios[userIndex];
				currentUser.updateInfo(nombre, pass, mail);
				return true;
			} catch (Exception ex) {
				return false;
			}
		}

		public bool eliminarUsuario(int usuarioId) {
			try {
				int userIndex = this.usuarios.FindIndex(usuario => usuario.id == usuarioId);
				if (userIndex == -1) return false;
				Usuario currentUser = this.usuarios[userIndex];
				currentUser.borrar();
				//TODO: We will remove the rest of products of user before remove user.
				return true;
			} catch (Exception ex) {
				return false;
			}
		}

		public bool crearCajaAhorro() {
			try {
				return this.altaCajaAhorro(this.currentUser.id);
			} catch (Exception ex) {
				return false;
			}
		}


		public bool altaCajaAhorro(int usuarioId) {
			try {
				int userIndex = this.usuarios.FindIndex(usuario => usuario.id == usuarioId);
				if (userIndex == -1) return false;

				Usuario currentUser = this.usuarios[userIndex];
				if (currentUser.borrado) return false;

				int cajaAhorroId = (this.cajasAhorro.Count)+1;
				CajaAhorro cajaAhorro = new CajaAhorro(cajaAhorroId);
				if(!cajaAhorro.addTitular(currentUser)) return false;
				if (!currentUser.agregarCajaAhorro(cajaAhorro)) return false;

				this.cajasAhorro.Add(cajaAhorro);
				return true;
			} catch (Exception ex) {
				return false;
			}
		}

		public bool bajaCajaAhorro(int id) {
			try {
				int cajaIndex = this.cajasAhorro.FindIndex(caja => caja.id == id);
				if (cajaIndex == -1) return false;

				CajaAhorro currentCajaAhorro = this.cajasAhorro[cajaIndex];
				if (!currentCajaAhorro.borrar()) return false;

				return true;
			} catch (Exception ex) {
				return false;
			}
		}

		//Accion 1 = Agregar titular; Accion 2 = Eliminar titular.
		public bool modificarCajaAhorro(int id, int titularDni, int accion) {
			try {
				if (accion != 1 && accion != 2) return false;

				int cajaIndex = this.cajasAhorro.FindIndex(caja => caja.id == id);
				if (cajaIndex == -1) return false;

				CajaAhorro currentCajaAhorro = this.cajasAhorro[cajaIndex];
				int userIndex = this.usuarios.FindIndex(usuario => usuario.dni == titularDni);
				Usuario currentUser = this.usuarios[userIndex];
				if (currentUser.borrado) return false;

				if (accion == 1) {
					if (!currentCajaAhorro.addTitular(currentUser)) return false;
					if (!currentUser.agregarCajaAhorro(currentCajaAhorro)) return false;
				} else if (accion == 2) {
					if (!currentCajaAhorro.removeTitular(currentUser)) return false;
					if (!currentUser.removerCajaAhorro(currentCajaAhorro)) return false;
				}

				return true;
			} catch (Exception ex) {
				return false;
			}
		}

		public string[] getCajaAhorro(int id) {
			return this.cajasAhorro[(id-1)].toArray(); // this its workign while we dont remove element in the cajasAhorro array
		}

		public string getCajaAhorroSaldo(int id) {
			string[] dataCurrentCajaAhorro = this.getCajaAhorro();
			return dataCurrentCajaAhorro[2];
		}

		public bool altaMovimiento(Movimiento movimiento, CajaAhorro cajaAhorro) {
			try {
				int cajaAhorroIndex = this.cajasAhorro.FindIndex(caja => caja.id == cajaAhorro.id);
				if (cajaAhorroIndex == -1) return false;

				int movimientoId = (this.movimientos.Count)+1;
				Movimiento newMovimiento = new Movimiento(movimientoId, movimiento.detalle, movimiento.monto, movimiento.cajaAhorro);
				cajaAhorro.addMovimiento(newMovimiento);
				this.movimientos.Add(newMovimiento);
				return true;
			} catch (Exception ex) {
				return false;
			}
		}

		public bool depositar(int cajaAhorroId, float monto, bool isTransferencia = false) {
			try {
				int cajaAhorroIndex = this.cajasAhorro.FindIndex(cajaAhorro => cajaAhorro.id == cajaAhorroId);
				if (cajaAhorroIndex == -1) return false;

				CajaAhorro currentCajaAhorro = this.cajasAhorro[cajaAhorroIndex];
				if (currentCajaAhorro.borrado) return false;

				currentCajaAhorro.depositar(monto);

				string detalle = isTransferencia? "transferencia" : "deposito";

				Movimiento movimiento = new Movimiento(detalle, monto, currentCajaAhorro);

				if (!this.altaMovimiento(movimiento, currentCajaAhorro)) return false;

				return true;
			} catch (Exception ex) {
				return false;
			}
		}

		public bool retirar(int cajaAhorroId, float monto, bool isTransferencia = false) {
			try {
				int cajaAhorroIndex = this.cajasAhorro.FindIndex(cajaAhorro => cajaAhorro.id == cajaAhorroId);
				if (cajaAhorroIndex == -1) return false;

				CajaAhorro currentCajaAhorro = this.cajasAhorro[cajaAhorroIndex];
				if (currentCajaAhorro.borrado) return false;

				if (!currentCajaAhorro.retirar(monto)) return false;

				string detalle = isTransferencia? "transferencia" : "retiro";

				Movimiento movimiento = new Movimiento(detalle, monto, currentCajaAhorro);

				if (!this.altaMovimiento(movimiento, currentCajaAhorro)) return false;

				return true;
			} catch (Exception ex) {
				return false;
			}
		}

		public bool transferir(int cajaAhorroOrigenId, string cajaAhorroDestinoCbu, float monto) {
			try {
				int cajaAhorroDestinoIndex = this.cajasAhorro.FindIndex(cajaAhorro => cajaAhorro.cbu == cajaAhorroDestinoCbu);
				if (cajaAhorroIndex == -1) return false;

				int cajaAhorroDestinoId = this.cajasAhorro[cajaAhorroDestinoIndex].id;

				if (!this.retirar(cajaAhorroOrigenId, monto, true)) return false;

				if (!this.depositar(cajaAhorroDestinoId, monto, true)) return false;

				return true;
			} catch (Exception ex) {
				return false;
			}
		}

		public bool altaPago(Pago pago, int usuarioId) {
			try {
				int userIndex = this.usuarios.FindIndex(usuario => usuario.id == usuarioId);
				if (userIndex == -1) return false;

				Usuario currentUser = this.usuarios[userIndex];
				if (currentUser.borrado) return false;

				int pagoId = (this.pagos.Count)+1;
				Pago newPago = new Pago(pagoId, pago.nombre, pago.monto, currentUser);
				if (!currentUser.agregarPago(newPago)) return false;

				this.pagos.Add(newPago);
				return true;
			} catch (Exception ex) {
				return false;
			}
		}

		public bool modificarPago(int pagoId, string nombre, float monto, bool pagado) {
			try {
				int pagoIndex = this.pagos.FindIndex(pago => pago.id == pagoId);
				if (pagoIndex == -1) return false;

				Pago currentPago = this.pagos[pagoIndex];
				if (currentPago.borrado) return false;

				currentPago.updateInfo(nombre, monto, pagado);
				return true;
			} catch (Exception ex) {
				return false;
			}
		}

		public bool bajaPago(int pagoId) {
			try {
				int pagoIndex = this.pagos.FindIndex(pago => pago.id == pagoId);
				if (pagoIndex == -1) return false;

				Pago currentPago = this.pagos[pagoIndex];
				currentPago.borrar();
				return true;
			} catch (Exception ex) {
				return false;
			}
		}

		public string getNombreCurrentUser() {
			return this.currentUser.nombre.ToString();
		}

		public bool iniciarSesion(int dni, string pass) {
			try {
				int userIndex = this.usuarios.FindIndex(usuario => usuario.dni == dni);
				if (userIndex == -1) return false;

				Usuario currentUser = this.usuarios[userIndex];
				if (currentUser.borrado || currentUser.bloqueado) return false;

				if (currentUser.pass != pass) {
					currentUser.failLogin();
					return false;
				}

				this.currentUser = currentUser;
				return true;
			} catch (Exception ex) {
				return false;
			}
		}

		public bool cerrarSesion() {
			try {
				this.currentUser = null;
				return true;
			} catch (Exception ex) {
				return false;
			}
		}

		public List<Pago> obtenerPagos() {
			return this.currentUser.obtenerPagos();
		}

		public List<Usuario> obtenerUsuarios() {
			return this.usuarios.ToList();
		}

		public List<CajaAhorro> obtenerCajasAhorro() {
			return this.currentUser.obtenerCajasAhorro();
		}

		public List<Movimiento> detalleCajaAhorro(int id) {
			int cajaAhorroIndex = this.cajasAhorro.FindIndex(cajaAhorro => cajaAhorro.id == id);
			CajaAhorro currentCajaAhorro = this.cajasAhorro[cajaAhorroIndex];
			return currentCajaAhorro.getDetalle();
		}

	}
}
