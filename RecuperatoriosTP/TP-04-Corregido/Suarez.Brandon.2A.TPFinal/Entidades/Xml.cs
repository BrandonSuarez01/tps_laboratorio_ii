using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;

namespace Entidades
{
    public class XML<T>
    {
        public XML()
        {

        } 
        /// <summary>
        /// Serializa la lista en un dato xml.
        /// </summary>
        /// <param name="lista">lista a serializar</param>
        public bool Serializar(List<T> lista)
        {
            string escritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            if (lista is null)
            {
                throw new Exception("No hay nada que escribir.");
            }
            using (XmlTextWriter writer = new XmlTextWriter(escritorio + "Datos.xml", Encoding.UTF8))
            {
                XmlSerializer ser = new XmlSerializer(typeof(List<T>));

                ser.Serialize(writer, lista);

                return true;
            }
        }
        /// <summary>
        /// Deserializa un archivo xml.
        /// </summary>
        /// <returns>Retorna la lista deserializada</returns>
        public List<T> Deserializar()
        {
            string escritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            using (XmlTextReader reader = new XmlTextReader(escritorio + "Datos.xml"))
            {
                XmlSerializer ser = new XmlSerializer(typeof(List<T>));
                List<T> aux = (List<T>)ser.Deserialize(reader);

                if (aux is null)
                {
                    throw new Exception("No hay nada que leer.");
                }

                return aux;

            }
        }
    }
}
