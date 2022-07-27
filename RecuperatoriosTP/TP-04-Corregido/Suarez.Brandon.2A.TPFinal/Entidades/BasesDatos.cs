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
            BasesDatos.cadenaConexion = "Server = .; Database = ListasdeServicios; Trusted_Connection = True;";
        }
        /// <summary>
        /// Leo los datos de mi DATABASE.
        /// </summary>
        /// <returns>retorno una lista de los clientes en la base de datos</returns>
        public static List<Cliente> LeerDatos()
        {
            List<Cliente> clientes = new List<Cliente>();
            List<Servicios> servicios = new List<Servicios>();

            string query = "select * from clientes";//de donde voy a leer
 
            using(SqlConnection connection = new SqlConnection(BasesDatos.cadenaConexion))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                connection.Open();//abro la conexion antes del reader.
                SqlDataReader reader = cmd.ExecuteReader();
                ///
                //ExecuteNonQuery().Se usa para consulta de actualizacion, insercion o eliminacion.
                //ExecuteReader().Se usa para consultas de lectura y devuelve un objeto data reader.
                //reader, va leyendo de fila en fila mientras exista un registro.
                servicios = BasesDatos.LeerServicios();
                while (reader.Read())
                {
                    int i = 0;

                    string nombre = reader.GetString(1);
                    string documento = reader.GetInt32(2).ToString();//obtengo los datos de las columnas.
                    string fecha = reader.GetDateTime(3).ToString();

                    Cliente cliente = new Cliente(nombre, documento, fecha, servicios[i]);
                    clientes.Add(cliente);
                    i++;
                }
            }
            return clientes;
        }
        public static List<Servicios> LeerServicios()
        {
            List<Servicios> lista = new List<Servicios>();
            string query2 = "select * from servicios";

            using (SqlConnection connection = new SqlConnection(BasesDatos.cadenaConexion))
            {
                SqlCommand cmd2 = new SqlCommand(query2, connection);
                connection.Open();
                SqlDataReader reader2 = cmd2.ExecuteReader();

                while(reader2.Read())
                {
                    string precio = reader2.GetInt32(1).ToString();
                    string servicio = reader2.GetString(2);
                    string dias = reader2.GetString(3);
                    string equipo = reader2.GetString(4);

                    Servicios servicios = new Servicios(precio, servicio, dias, equipo);
                    lista.Add(servicios);
                }
            }
            return lista;
        }
        /// <summary>
        /// Añade un cliente a la base de datos a medida que se confirma su ingreso.
        /// </summary>
        /// <param name="c">cliente a subir a la base de datos</param>
        public static void SubirCliente(Cliente c)
        {
            string query = "insert into clientes (nombreApellido, dni, fecha) values (@nombreApellido, @dni, @fecha)";
            string query2 = "insert into servicios (precio, servicio, dias, equipo) values (@precio, @servicio, @dias, @equipo)";


            using (SqlConnection connection = new SqlConnection(BasesDatos.cadenaConexion))
            {

                SqlCommand cmd = new SqlCommand(query, connection);
                connection.Open();
                cmd.Parameters.AddWithValue("dni", c.Dni);
                cmd.Parameters.AddWithValue("nombreApellido", c.Nombre);
                cmd.Parameters.AddWithValue("fecha", c.Fecha);
                cmd.ExecuteNonQuery();

                SqlCommand cmd2 = new SqlCommand(query2, connection);
                cmd2.Parameters.AddWithValue("precio", c.ServicioElegido.Precio);
                cmd2.Parameters.AddWithValue("servicio", c.ServicioElegido.Servicio);
                cmd2.Parameters.AddWithValue("dias", c.ServicioElegido.Dias);
                cmd2.Parameters.AddWithValue("equipo", c.ServicioElegido.Equipo);
                cmd2.ExecuteNonQuery();

            }
        }
    }
}
