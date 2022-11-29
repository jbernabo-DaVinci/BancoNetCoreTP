using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Properties;
using System.Data; 
using System.Data.SqlClient;
using System.Xml;
using System.Linq.Expressions;

namespace WinFormsApp1
{
    public class AccesoBD
    {
        private string connectionString;

        public AccesoBD() 
        { 
            //acá cargamos la cadea de conexión desde el archivo de properties
            connectionString = Properties.Resources.ConnectionStr; //accedemos en el archivo Properties.Resources.ConnectionStr
            //aunque podríamos colcoar el connectionString acá a la vista de todos (no aconsejable)
        }

        //<<<<<<<<<<<<<<<<<< USUARIO >>>>>>>>>>>>>>>>>>>>>
        public List<Usuario> inicializarUsuarios()
        {
            List<Usuario> usuarios = new List<Usuario>();

            //Definimos el string con la consulta que queremos ralizar
            string queryString = "SELECT * from dbo.Usuarios";

            //ya pegándole a la BD, podemos crear el 1er objeto que es e "connection"
            using (SqlConnection connection = new SqlConnection(connectionString))
            /*el "connection" está dentro de un "using" xq mientras viva dentro de las {}
            vamos a tener una conecction activa, luego de las llaves, se cerrará sola!
            no hace falta un Connection.close*/
            {
                //Definimos el comando con la consulta de qué quiero ejecutar
                SqlCommand command = new SqlCommand(queryString, connection);

                try
                {
                   //Abrimmos la conexión
                   connection.Open();
                   //el objeto DataReader obtendrá los resultados de la consulta
                   SqlDataReader reader = command.ExecuteReader();
                   Usuario aux;

                   //mientras hayan registros/filas en el DataReader, seguimos leyendo
                   while (reader.Read())
                   {
                        //acá debe ir un reader.GetInt32 o reader.GetString según coumnas tengamos en la tabla Usuarios
                        //    id                    dni                 nombre               pass        
                        aux = new Usuario(reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2), reader.GetString(3),
                                         //        mail        intentosFallidos            bloqueado             borrado
                                         reader.GetString(4), reader.GetInt32(5), reader.GetBoolean(6), reader.GetBoolean(7), reader.GetBoolean(8));
                   usuarios.Add(aux);
                   }
                   //ahora sí, ya habiendo recorrido todas las filas del resultado de la query, cerramos
                   reader.Close(); //usamos reader.Close() xq la tabla vive en memoria de mi pc, al hacer esto, liberamos la memoria.
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return usuarios;
        }

	public int agregarUsuario(int dni, string nombre, string mail, string pass, int intentosFallidos, bool bloqueado, bool borrado, bool isAdmin) {
		int queryResult;
		int idNewUser = -1;
		string conecctionString = Properties.Resources.ConnectionStr;
		string query = "INSERT INTO [dbo].[Usuario] ([dni], [nombre], [mail], [pass], [intentosFallidos], [bloqueado], [borrado], [isAdmin]) VALUES (@dni, @nombre, @mail, @pass, @intentosFallidos, @bloqueado, @borrado, @isAdmin);";
		using(SqlConnection connection = new SqlConnection(conecctionString)) {
			SqlCommand command = new SqlCommand(query, connection);
			command.Parameters.Add(new SqlParameter("@dni",SqlDbType.Int));
			command.Parameters.Add(new SqlParameter("@nombre",SqlDbType.NVarChar));
			command.Parameters.Add(new SqlParameter("@mail",SqlDbType.NVarChar));
			command.Parameters.Add(new SqlParameter("@pass",SqlDbType.NVarChar));
			command.Parameters.Add(new SqlParameter("@intentosFallidos",SqlDbType.Int));
			command.Parameters.Add(new SqlParameter("@bloqueado",SqlDbType.Bit));
			command.Parameters.Add(new SqlParameter("@borrado",SqlDbType.Bit));
			command.Parameters.Add(new SqlParameter("@isAdmin",SqlDbType.Bit));
			command.Parameters["@dni"].Value = dni;
			command.Parameters["@nombre"].Value = nombre;
			command.Parameters["@mail"].Value = mail;
			command.Parameters["@pass"].Value = pass;
			command.Parameters["@intentosFallidos"].Value = intentosFallidos;
			command.Parameters["@bloqueado"].Value = bloqueado;
			command.Parameters["@borrado"].Value = borrado;
			command.Parameters["@isAdmin"].Value = isAdmin;

			try {
				connection.Open();
				queryResult = command.ExeciteNonQuery();

				string getId = "SELECT MAX([ID]) FROM [dbo].[Usuario];";
				command = new SqlCommand(getId, connection);
				SqlDataReader reader = command.ExecuteReader();
				reader.Read();
				idNewUser = render.GetInt32(0);
				reader.Close();
			} catch (Exception ex) {
				Console.WriteLine(ex.Message);
				return -1;
			}

			return idNewUser;
		}
	}

        //<<<<<<<<<<<<<<<<<< CAJA AHORRO >>>>>>>>>>>>>>>>>>>>>
        public List<CajaAhorro> inicializarCajaAhorro()
        {
            List<CajaAhorro> cajaAhorro = new List<CajaAhorro>();

            String queryString = "SELECT * from dboCajaAhorro.";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    CajaAhorro aux;

                    while (reader.Read())
                    {
                        aux = new CajaAhorro(reader.GetInt32(0), reader.GetString(1), reader.GetFloat(2), reader.GetBoolean(3));
                        cajaAhorro.Add(aux);
                    }
                    reader.Close();
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return cajaAhorro;
        }


        //<<<<<<<<<<<<<<<<<< MOVIMIENTO >>>>>>>>>>>>>>>>>>>>>
        public List<Movimiento> inicializarMovimientos()
        {
            List<Movimiento> movimiento = new List<Movimiento>();

            String queryString = "SELECT * from dbo.Movimiento";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    Movimiento aux;


                    while (reader.Read())
                    {
                        aux = new Movimiento(reader.GetInt32(0), reader.GetString(1), reader.GetFloat(2), reader.GetDateTime(3), reader.GetInt32(4));
                        movimiento.Add(aux);
                    }
                    reader.Close();
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }return movimiento;

        }


        //<<<<<<<<<<<<<<<<<< PAGO >>>>>>>>>>>>>>>>>>>>>
        public List<Pago> inicializarPagos()
        {
            List<Pago> pago = new List<Pago>();

            string queryString = "SELECT * from dbo.Pago";

            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    Pago aux;

                    while (reader.Read())
                    {
                        aux = new Pago(reader.GetInt32(0), reader.GetString(1), reader.GetFloat(2), reader.GetBoolean(3), reader.GetBoolean(4), reader.GetInt32(5));
                        pago.Add(aux);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }return pago;
        }

        //<<<<<<<<<<<<<<<<<< PLAZO FIJO >>>>>>>>>>>>>>>>>>>>>
        public List<PlazoFijoManager> inicializarPlazoFijo()
        {
            List<PlazoFijoManager> plazoFijo = new List<PlazoFijoManager>();

            string queryString = "SELECT * from dbo.PlazoFijo";

            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    PlazoFijoManager aux;

                    while (reader.Read())
                    {
                        aux = new PlazoFijoManager(reader.GetInt32(0), reader.GetFloat(4), reader.GetFloat(1), reader.GetBoolean(5), reader.GetBoolean(6),
                                        reader.GetDateTime(3), reader.GetDateTime(4), reader.GetInt32(7));
                        plazoFijo.Add(aux);
                    }
                    reader.Close();
                }

                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
  
            }
            return plazoFijo;
        }

        //<<<<<<<<<<<<<<<<<< TARJETA CREDITO >>>>>>>>>>>>>>>>>>>>>
        public List<TarjetaCreditoManager> inicializarTarjetaCredito()
        {
            List<TarjetaCreditoManager> tarjetaCredito = new List<TarjetaCreditoManager>();

            string queryString = "SELECT * from dbo.TarjetaCredito";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    TarjetaCreditoManager aux;

                    while (reader.Read())
                    {
                        aux = new TarjetaCreditoManager(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2),
                                                 reader.GetFloat(3), reader.GetFloat(4), reader.GetBoolean(5), reader.GetInt32(6));

                        tarjetaCredito.Add(aux);
                    }
                    reader.Close();
                }

                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
            return tarjetaCredito;
        }
    }
}
