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
        private List<string> lista;
        public Archivos()
        {
            this.lista = new List<string>();
        }
        public Archivos(List<string> list) : this()
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
        /// <returns></returns>
        public List<string> LeerArchivo()
        {
            string escritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string texto;

            List<string> auxList = new List<string>();
            StreamReader sr = new StreamReader(escritorio + @"\listaClientes.txt");

            while((texto = sr.ReadLine()) != null)
            {
                auxList.Add(texto);
            }

            return auxList;
        }
    }
}
