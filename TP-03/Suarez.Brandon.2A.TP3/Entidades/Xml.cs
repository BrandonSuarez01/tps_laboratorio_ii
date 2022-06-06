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
            if(lista != null)
            {
                using (XmlTextWriter writer = new XmlTextWriter("Datos.xml", System.Text.Encoding.UTF8))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(List<T>));

                    ser.Serialize(writer, lista);

                    return true;
                }
            }
            else
            {
                return false;
            } 
        }
        /// <summary>
        /// Deserializa un archivo xml.
        /// </summary>
        /// <returns>Retorna la lista deserializada</returns>
        public List<T> Deserializar()
        {
            using (XmlTextReader reader = new XmlTextReader("Datos.xml"))
            {
                XmlSerializer ser = new XmlSerializer(typeof(List<T>));

                List<T> aux = (List<T>)ser.Deserialize(reader);

                return aux;
            }
        }
    }
}
