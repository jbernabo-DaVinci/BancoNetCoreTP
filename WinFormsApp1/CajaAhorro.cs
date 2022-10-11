using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1 {
	public class CajaAhorro {
		public int id { get; set; }
		public string cbu { get; set; }
		public float saldo { get; set; }
		public bool borrado { get; set; }
		private List<Usuario> titulares;
		private List<Movimiento> movimiento;

		public CajaAhorro() { }

		public CajaAhorro(int id, Usuario titular) {
			this.id = id;
			this.cbu = this.createCBU();
			this.saldo = 0;
			this.titulares.Add(titular);
		}

		private string createCBU() {
			string cbu = "0";
			Random rd = new Random();
			for(int i = 0; i < 5; i++) {
				cbu += rd.Next(0,9999);
			}
			while(cbu.Length < 22) {
				cbu = "0"+cbu;
			}
			return cbu;
		}

		public int[] getTitularesIds() {
			int cantTitulares = this.titulares.Count;
			int[] titularesIds = new int[cantTitulares];
			for(int i = 0; i < cantTitulares; i++) {
				titularesIds[i] = this.titulares[i].id;
			}
			return titularesIds;
		}

		public bool addTitular(Usuario usuario) {
			int userIndex = this.titulares.FindIndex(titular => titular.dni == usuario.dni);
			if(userIndex != -1) return false;

			this.titulares.Add(usuario);
			return true;
		}

		public bool removeTitular(Usuario usuario) {
			int userIndex = this.titulares.FindIndex(titular => titular.dni == usuario.dni);
			if (userIndex == -1) return false;

			if (this.titulares.Count <= 1) return false;

			this.titulares.RemoveAt(userIndex);
			return true;
		}

		public bool borrar() {
			if(this.saldo != 0) return false;
			this.borrado = true;
			return true;
		}

		public string[] toArray() {
			return new string[] { this.cbu, this.saldo };
		}
	}
}
