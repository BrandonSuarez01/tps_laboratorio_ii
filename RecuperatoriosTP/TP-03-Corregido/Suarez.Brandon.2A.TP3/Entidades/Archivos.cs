using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace Entidades
{
    public class Archivos
    {
        /// <summary>
        /// Guarda el cliente en la lista que aparece en el escritorio.
        /// </summary>
        /// <param name="cliente">cliente que va a guardar</param>
        /// <returns></returns>
        public static bool EscribirCliente(Cliente cliente)
        {
            string escritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            StreamWriter sw = new StreamWriter(escritorio + @"\listaClientes.txt", true);

            if(cliente != null)
            {
                sw.WriteLine(cliente);

                sw.Close();

                return true;
            }
            else
            {
                return false;
                throw new Exception("No hay cliente que guardar.");
            }  
        }
        /// <summary>
        /// Lee la lista previamente creada, si no hay ninguna no hace nada.
        /// </summary>
        /// <returns>retorna la lista cargada</returns>
        public static List<string> LeerArchivo()
        {
            string escritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string texto;

            List<string> auxList = new List<string>();
            StreamReader sr = new StreamReader(escritorio + @"\listaClientes.txt");

            if(escritorio == null)
            {
                throw new Exception("El destino a leer aun esta vacio.");
            }
            while ((texto = sr.ReadLine()) != null)
            {
                auxList.Add(texto);
            }
            return auxList;
        }
        /// <summary>
        /// Escribe el reclamo en un documento de texto en la carpeta doocumentos del usuario
        /// </summary>
        /// <param name="r">reclamo que va a escribir</param>
        /// <returns></returns>
        public static bool EscribirReclamo(Reclamos r)
        {
            string escritorio = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string cliente = r.Dni;

            if (r == null)
            {
                throw new Exception("No hay nada que guardar.");
            }
            StreamWriter sw = new StreamWriter(escritorio + @$"\reclamoCliente{cliente}.txt", true);


            sw.WriteLine(r.ToString());


            sw.Close();

            return true;
        }
    }
}
