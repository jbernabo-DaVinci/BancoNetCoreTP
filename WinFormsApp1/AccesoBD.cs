using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Properties;
using System.Data; //no sé si es necesaria
using System.Data.SqlClient; //no sé si es necesaria

namespace WinFormsApp1
{
    class AccesoBD
    {
        private string connectionString;

        public AccesoBD() 
        { 
            //acá cargamos la cadea de conexión desde el archivo de properties
            connectionString = Properties.Resources.ConnectionStr; 
        }

        public List<Usuario> inicializarAtributos()
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
                   aux = new Usuario(reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2), reader.GetString(3);
                   usuarios.Add(aux);
                   }
                   //ahora sí, ya habiendo recorrido todas las filas del resultado de la query, cerramos
                   reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return usuarios;
        }


    }
}
