using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WinFormsApp1 {
	public class Banco {
		public List<Usuario> usuarios;
		public List<CajaAhorro> cajasAhorro;
		public List<PlazoFijo> plazosFijos;
		public List<TarjetaCredito> tarjetasCredito;
		public List<Pago> pagos;
		public List<Movimiento> movimientos;
		public Usuario currentUser;
		public AccesoBD DB;

		public Banco() {
			this.usuarios = new List<Usuario>();
			this.cajasAhorro = new List<CajaAhorro>();
			this.plazosFijos = new List<PlazoFijo>();
			this.tarjetasCredito = new List<TarjetaCredito>();
			this.pagos = new List<Pago>();
			this.movimientos = new List<Movimiento>();
			this.DB = new AccesoBD();
			this.inicializarAtributos();
		} 

		private void inicializarAtributos() {
			this.usuarios = DB.inicializarUsuarios(); //acá encontraremos un SELECT * FROM Usuarios por ejem y se lo guardamos en la lsita usuarios
			this.cajasAhorro = DB.inicializarCajaAhorro();
			this.pagos = DB.inicializarPagos();
			this.movimientos = DB.inicializarMovimientos();
			this.plazosFijos = DB.inicializarPlazoFijo();
			this.tarjetasCredito = DB.inicializarTarjetaCredito();
		}


		public bool agregarUsuario(int dni, string name, string pass) {
			try {
				int userIndex = this.usuarios.FindIndex(usuario => usuario.dni == dni);
				if (userIndex != -1) return false;

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
					if (this.currentUser.id == currentUser.id) return false;
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
			string[] dataCurrentCajaAhorro = this.getCajaAhorro(id);
			return dataCurrentCajaAhorro[2];
		}

		public List<Usuario> getCajaAhorroTitulares(int id) {
			int cajaAhorroIndex = this.cajasAhorro.FindIndex(cajaAhorro => cajaAhorro.id == id);
			CajaAhorro currentCajaAhorro = this.cajasAhorro[cajaAhorroIndex];
			return currentCajaAhorro.getTitulares();
		}

		public bool altaMovimiento(Movimiento movimiento, CajaAhorro cajaAhorro) {//@TODO With the implementation of tp2 this function will become unnecessary
			try {
				int movimientoId = (this.movimientos.Count)+1;
				Movimiento newMovimiento = new Movimiento(movimientoId, movimiento.detalle, movimiento.monto, movimiento.cajaAhorro);
				cajaAhorro.addMovimiento(newMovimiento);
				this.movimientos.Add(newMovimiento);
				return true;
			} catch (Exception ex) {
				return false;
			}
		}

		public bool depositar(int cajaAhorroId, float monto, string detalle = "Deposito") {
			try {
				int cajaAhorroIndex = this.cajasAhorro.FindIndex(cajaAhorro => cajaAhorro.id == cajaAhorroId);
				if (cajaAhorroIndex == -1) return false;

				CajaAhorro currentCajaAhorro = this.cajasAhorro[cajaAhorroIndex];
				if (currentCajaAhorro.borrado) return false;

				if (!currentCajaAhorro.depositar(monto)) return false;

				Movimiento movimiento = new Movimiento(detalle, monto, currentCajaAhorro);

				if (!this.altaMovimiento(movimiento, currentCajaAhorro)) return false;

				return true;
			} catch (Exception ex) {
				return false;
			}
		}

		public bool retirar(int cajaAhorroId, float monto, string detalle = "Retiro") {
			try {
				int cajaAhorroIndex = this.cajasAhorro.FindIndex(cajaAhorro => cajaAhorro.id == cajaAhorroId);
				if (cajaAhorroIndex == -1) return false;

				CajaAhorro currentCajaAhorro = this.cajasAhorro[cajaAhorroIndex];
				if (currentCajaAhorro.borrado) return false;

				if (!currentCajaAhorro.retirar(monto)) return false;

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
				if (cajaAhorroDestinoIndex == -1) return false;

				int cajaAhorroDestinoId = this.cajasAhorro[cajaAhorroDestinoIndex].id;

				if (cajaAhorroOrigenId == cajaAhorroDestinoId) return false;

				if (!this.retirar(cajaAhorroOrigenId, monto, "Enviaste una Transferencia")) return false;

				if (!this.depositar(cajaAhorroDestinoId, monto, "Recibiste Transferencia")) return false;

				return true;
			} catch (Exception ex) {
				return false;
			}
		}

		public bool pagarPago(int cajaAhorroId, int pagoId) {
			try {
				int pagoIndex = this.pagos.FindIndex(pago => pago.id == pagoId);
				if (pagoIndex == -1) return false;

				Pago currentPago = this.pagos[pagoIndex];
				if (currentPago.borrado || currentPago.pagado) return false;

				if (!this.retirar(currentCajaAhorro.id, currentPago.monto, "Pago: "+currentPago.nombre)) return false;

				if (!this.modificarPago(currentPago.id)) return false;

				return true;

			} catch (Exception ex) {
				return false;
			}
		}

		public bool crearPago(string nombrePago, float monto) {
			try {
				return this.altaPago(new Pago(nombrePago, monto), this.currentUser.id);
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
				Pago newPago = new Pago(pagoId, pago.nombre, pago.monto, usuarioId);
				if (!currentUser.agregarPago(newPago)) return false;

				this.pagos.Add(newPago);
				return true;
			} catch (Exception ex) {
				return false;
			}
		}

		public bool modificarPago(int pagoId) {
			try {
				int pagoIndex = this.pagos.FindIndex(pago => pago.id == pagoId);
				if (pagoIndex == -1) return false;

				Pago currentPago = this.pagos[pagoIndex];
				if (currentPago.borrado) return false;

				currentPago.pagarPago();
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
				if (!currentPago.borrar()) return false;
				return true;
			} catch (Exception ex) {
				return false;
			}
		}

		public string obtenerPagoNombre(int pagoId) {
			return this.pagos[pagoId-1].nombre;
		}

		public string obtenerPagoMonto(int pagoId) {
			return this.pagos[pagoId-1].monto.ToString("C");
		}

		public string getNombreCurrentUser() {
			return this.currentUser.nombre.ToString();
		}

		public bool altaPlazoFijo(float monto, int usuarioId) {
			try {
				if (monto < 1000) return false;

				if (usuarioId != this.currentUser.id) {
					int userIndex = this.usuarios.FindIndex(usuario => usuario.id == usuarioId);
					if (userIndex == -1) return false;
					Usuario currentUser = this.usuarios[userIndex];
				} else {
					Usuario currentUser = this.currentUser;
				}

				if (currentUser.borrado) return false;

				int plazoFijoId = (this.plazosFijos.Count)+1;
				Plazofijo newPlazoFijo = new PlazoFijoManager(plazoFijoId, monto, usuarioId);
				if (!currentUser.agregarPlazoFijo(newPlazoFijo)) return false;

				if (!this.retirar(cajaAhorroId, monto, "Creaste Plazo Fijo")) return false;

				this.plazosFijos.Add(newPlazoFijo);
				return true;
			} catch (Exception ex) {
				return false;
			}
		}

		public bool bajaPlazoFijo(int id) {
			try {
				int plazoFijoIndex = this.plazosFijos.FindIndex(plazo => plazo.id == id);
				if (plazoFijoIndex == -1) return false;

				PlazoFijo plazoFijo = this.plazosFijos[plazoFijoIndex];
				if (!plazoFijo.pagado && DateTime.now.AddMonths(-1) < plazoFijo.fechaFin) return false;

				plazoFijo.borrado = true;
				return true;
			} catch (Exception ex) {
				return false;
			}
		}

		public bool altaTarjetaCredito(float limite , int usuarioId) {
			try {
				if (usuarioId != this.currentUser.id) {
					int userIndex = this.usuarios.FindIndex(usuario => usuario.id == usuarioId);
					if (userIndex == -1) return false;

					Usuario currentUser = this.usuarios[userIndex];
				} else {
					Usuario currentUser = this.currentUser;
				}

				if (currentUser.borrado) return false;

				int tarjetaCreditoId = (this.tarjetasCredito.Count)+1;
				TarjetaCredito newTarjetaCredito = new TarjetaCreditoManager(tarjetaCreditoId, limite, usuarioId);
				if (!currentUser.agregarTarjetaCredito(newTarjetaCredito)) return false;

				this.plazosFijos.Add(newTarjetaCredito);
				return true;
			} catch (Exception ex) {
				return false;
			}
		}

		public bool bajaTarjetaCredito(int id) {
			try {
				int tarjetaCreditoIndex = this.tarjetasCredito.FindIndex(tarjeta => tarjeta.id == id);
				if (tarjetaCreditoIndex == -1) return false;

				TarjetaCredito tarjetaCredito = this.tarjetasCredito[tarjetaCreditoIndex];
				if (tarjetasCredito.consumo != 0) return false;

				tarjetasCredito.borrado = true;
				return true;
			} catch (Exception ex) {
				return false;
			}
		}

		public bool modificarTarjetaCredito(int Id, float limite) {
			try {
				int tarjetaCreditoIndex = this.tarjetasCredito.FindIndex(tarjeta => tarjeta.id == id);
				if (tarjetaCreditoIndex == -1) return false;

				TarjetaCredito tarjetaCredito = this.tarjetasCredito[tarjetaCreditoIndex];
				if (tarjetasCredito.borrado) return false;

				tarjetaCredito.limite = limite;
				return true;
			} catch (Exception ex) {
				return false;
			}
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

		public List<Pago> obtenerPagosPagados() {
			return this.currentUser.obtenerPagosPagados();
		}

		public List<Pago> obtenerPagosNoPagados() {
			return this.currentUser.obtenerPagosNoPagados();
		}

		public List<Usuario> obtenerUsuarios() {
			return this.usuarios.ToList();
		}

		public List<CajaAhorro> obtenerCajasAhorro() {
			return this.currentUser.obtenerCajasAhorro();
		}

		public List<PlazoFijo> obtenerPlazosFijos() {
			return this.currentUser.obtenerPlazosFijos();
		}

		public List<TarjetaCredito> obtenerTarjetasCredito() {
			return this.currentUser.obtenerTarjetasCredito();
		}

		public List<Movimiento> detalleCajaAhorro(int id) {
			int cajaAhorroIndex = this.cajasAhorro.FindIndex(cajaAhorro => cajaAhorro.id == id);
			CajaAhorro currentCajaAhorro = this.cajasAhorro[cajaAhorroIndex];
			return currentCajaAhorro.getDetalle();
		}

	}
}
