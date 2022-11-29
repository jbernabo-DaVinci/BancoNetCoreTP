using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Properties;
using System.Data; 
using System.Data.SqlClient; 

namespace WinFormsApp1
{
    class AccesoBD
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
            no hace falta un .close*/
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
                                         reader.GetString(4), reader.GetInt32(5), reader.GetBoolean(6), reader.GetBoolean(7));
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
            SqlConnection connection = new SqlConnection(connectionString);
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
        }

        //<<<<<<<<<<<<<<<<<< PLAZO FIJO >>>>>>>>>>>>>>>>>>>>>


        //<<<<<<<<<<<<<<<<<< TARJETA CREDITO >>>>>>>>>>>>>>>>>>>>>

    }
}
