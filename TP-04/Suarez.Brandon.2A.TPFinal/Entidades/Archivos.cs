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
        private List<Cliente> lista;
        public Archivos()
        {
            this.lista = new List<Cliente>();
        }
        public Archivos(List<Cliente> list) : this()
        {
            this.lista = list;
        }
        /// <summary>
        /// recibe una lista de clientes y la imprime en el escritorio.
        /// </summary>
        /// <param name="lista">lista a guardar</param>
        /// <returns>retorna true si la lista no es null y pudo escribirla</returns>
        public bool EscribirArchivo(List<Cliente> lista)
        {
            string escritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            if (lista.Count != 0)
            {
                StreamWriter sw = new StreamWriter(escritorio + @"\listaClientes.txt", true);
                
                for(int i = 0; i<lista.Count;i++)
                {
                    sw.WriteLine(lista[i]);
                }

                sw.Close();
             
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Lee la lista previamente creada, si no hay ninguna no hace nada.
        /// </summary>
        /// <returns>retorna la lista cargada</returns>
        public List<string> LeerArchivo()
        {
            string escritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string texto;

            List<string> auxList = new List<string>();
            StreamReader sr = new StreamReader(escritorio + @"\listaClientes.txt");

            if(escritorio == null)
            {
                throw new Exception("El destino a leer aun esta vacio,");
            }
            while ((texto = sr.ReadLine()) != null)
            {
                auxList.Add(texto);
            }
            return auxList;
        }
        /// <summary>
        /// Imprime el ticket del cliente deseado.
        /// </summary>
        /// <param name="c">cliente a imprimir</param>
        /// <returns>retorna true si se pudo imprimir, en caso contrario retornara false</returns>
        public static bool EscribirTicket(Cliente c)
        {
            string escritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string cliente = c.Dni;

            Thread.Sleep(1000);

            if (c != null)
            {
                StreamWriter sw = new StreamWriter(escritorio + @$"\ticketCliente{cliente}.txt", true);

                
                sw.WriteLine(Cliente.MostrarTicket(c));
                

                sw.Close();

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
