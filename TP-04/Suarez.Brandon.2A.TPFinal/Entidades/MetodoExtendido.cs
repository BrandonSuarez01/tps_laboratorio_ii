using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class MetodoExtendido
    {
        /// <summary>
        /// Agrega mas cosas a un string.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string Mensaje(this String s)
        {
            return "La accion " + s;
        }
    }
}
