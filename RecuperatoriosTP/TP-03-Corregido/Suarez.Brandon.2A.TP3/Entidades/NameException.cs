using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class NameException : Exception
    {
        public NameException(string mensaje) : base(mensaje)
        {

        }
    }
}
