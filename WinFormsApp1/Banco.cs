using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1 {
	public class Banco {
		private List<Usuario> usuarios;
		private List<CajaAhorro> cajasAhorro;
		private List<PlazoFijo> plazosFijos;
		private List<TarjetaCredito> tarjetasCredito;
		private List<Pago> pagos;
		private List<Movimientos> movimientos;

		public Banco() {
			this.usuarios = new List<Usuario>();
		} 
	    
		public bool agregarUsuario(string user, string pass) {
			try {
				if (pass.Length < 8) {
					return false;
				}

				this.usuarios.Add(new Usuario(user, pass));
				return true;

			} catch (Exception ex) {
				return false;
			}
		}

		public bool agregarUsuario(Usuario user) {
			try {
				Usuario newUser = new Usuario(user.nombre, user.pass);
				this.usuarios.Add(newUser);
				return true;
			} catch (Exception ex) {
				return false;
			}
		}

		public void eliminarUsuario(int dni) { }

		public bool iniciarSesion(string name, string pass) {
			return this.usuarios.Contains(new Usuario(name, pass));
		}

		public List<Usuario> obtenerUsuarios() {
			return usuarios.ToList();
		}
	}
}
