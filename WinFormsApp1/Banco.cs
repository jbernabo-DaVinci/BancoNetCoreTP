using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Banco
    {
        private List<Usuario> usuarios;

        public Banco()
        {
            usuarios = new List<Usuario>();

        }
        public bool agregarUsuario(string user, string pass)
        {
            try
            {
                if (pass.Length < 8)
                    return false;
                else
                {
                    usuarios.Add(new Usuario(user, pass));
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool agregarUsuario(Usuario user)
        {
            try
            {
                Usuario otro = new Usuario(user.nombre, user.pass);
                usuarios.Add(otro);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public void eliminarUsuario(int dni)
        {

        }
        public bool iniciarSesion(string usuario, string pass)
        {
            bool encontre = false;
            foreach (Usuario user in usuarios)
            {
                if (user.nombre.Equals(usuario) && user.pass.Equals(pass))
                    encontre = true;
            }
            return encontre;
        }
        public List<Usuario> obtenerUsuarios()
        {
            return usuarios.ToList();
        }
    }
}
