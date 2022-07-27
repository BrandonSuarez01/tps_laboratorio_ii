using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// La clase Vehiculo no deberá permitir que se instancien elementos de este tipo.
    /// </summary>
    public abstract class Vehiculo
    {
        EMarca marca;
        protected string chasis;
        protected ConsoleColor color;

        /// <summary>
        /// Enumera las marcas.
        /// </summary>
        public enum EMarca
        {
            Chevrolet, Ford, Renault, Toyota, BMW, Honda, HarleyDavidson
        }
        /// <summary>
        /// Enumera los tamaños.
        /// </summary>
        public enum ETamanio
        {
            Chico, Mediano, Grande
        }
        /// <summary>
        /// ReadOnly: Retornará el tamaño
        /// </summary>
        protected virtual ETamanio Tamanio
        {
            get
            { 
                return this.Tamanio; 
            } 
        }
        /// <summary>
        /// Constructor: da valor a los atributos de la clase.
        /// </summary>
        /// <param name="chasis">recibe el chasis</param>
        /// <param name="marca">recibe la marca</param>
        /// <param name="color">recibe el color</param>
        public Vehiculo (string chasis, EMarca marca, ConsoleColor color)
        {
            this.chasis = chasis;
            this.color = color;
            this.marca = marca;
        }
        /// <summary>
        /// Publica todos los datos del Vehiculo.
        /// </summary>
        /// <returns></returns>
        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("CHASIS: {0}\r\n", this.chasis.ToString());
            sb.AppendFormat("MARCA : {0}\r\n", this.marca.ToString());
            sb.AppendFormat("COLOR : {0}\r\n", this.color.ToString());
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
        public static explicit operator string(Vehiculo p)
        {
            return p.Mostrar();
        }
        /// <summary>
        /// Dos vehiculos son iguales si comparten el mismo chasis
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            return (v1.chasis == v2.chasis);
        }
        /// <summary>
        /// Dos vehiculos son distintos si su chasis es distinto
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }


    }
}
