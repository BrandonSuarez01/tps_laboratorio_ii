using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Entidades
{
    public class BasesDatos
    {
        //abro la base de datos.
        //Open();
        //Cierro la base de datos.
        //Close();
        //SqlCommand comando;
        //le doy el tipo a leer.
        //comando.CommandType;
        //propiedad para setear la consulta con sql.
        //comando.CommandText;
        private static string cadenaConexion;

        static BasesDatos()
        {
            BasesDatos.cadenaConexion = "Server = .; Database = clientesGuardados; Trusted_Connection = True;";
        }
        /// <summary>
        /// Leo los datos de mi DATABASE.
        /// </summary>
        /// <returns>retorno una lista de los clientes en la base de datos</returns>
        public static List<Cliente> leerDatos()
        {
            List<Cliente> clientes = new List<Cliente>();

            string query = "select * from clientes";//de donde voy a leer
            using(SqlConnection connection = new SqlConnection(BasesDatos.cadenaConexion))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                connection.Open();//abro la conecxion antes del reader.
                SqlDataReader reader = cmd.ExecuteReader();
                //ExecuteNonQuery().Se usa para consulta de actualizacion, insercion o eliminacion.
                //ExecuteReader().Se usa para consultas de lectura y devuelve un objeto data reader.
                //reader, va leyendo de fila en fila mientras exista un registro.
                while(reader.Read())
                {
                    string documento = reader.GetInt32(0).ToString();//obtengo los datos de las columnas.
                    string nombre = reader.GetString(1);
                    string producto = reader.GetString(2);
                    string importe = reader.GetInt32(3).ToString();
                    string fecha = reader.GetDateTime(4).ToString();

                    Cliente cliente = new Cliente(nombre, documento, producto, fecha, importe);
                    clientes.Add(cliente);
                }
            }
            return clientes;
        }
        /// <summary>
        /// Añade un cliente a la base de datos a medida que se confirma su ingreso.
        /// </summary>
        /// <param name="c">cliente a subir a la base de datos</param>
        public static void subirCliente(Cliente c)
        {
            string query = "insert into clientes (dni, nombreApellido, producto, importe, fecha) values (@dni, @nombreApellido, @producto, @importe, @fecha)";
            using (SqlConnection connection = new SqlConnection(BasesDatos.cadenaConexion))
            {
                
                SqlCommand cmd = new SqlCommand(query, connection);
                connection.Open();
                cmd.Parameters.AddWithValue("dni", c.Dni);
                cmd.Parameters.AddWithValue("nombreApellido", c.Nombre);
                cmd.Parameters.AddWithValue("producto", c.Producto);
                cmd.Parameters.AddWithValue("importe", c.Importe);
                cmd.Parameters.AddWithValue("fecha", c.Fecha);
                cmd.ExecuteNonQuery();
            }
        }


            
         

          

    }
}
