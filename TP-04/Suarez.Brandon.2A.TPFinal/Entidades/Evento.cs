using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades
{
    public class Evento
    {
        public delegate void CambiarColorHandler();
        public event CambiarColorHandler cambioColor;

        public Evento()
        {

        }
        /// <summary>
        /// invoca mi evento.
        /// </summary>
        public void Cambiar()
        {
            if(this.cambioColor is not null)
            {
                this.cambioColor.Invoke();
            }
        }
    }
}
