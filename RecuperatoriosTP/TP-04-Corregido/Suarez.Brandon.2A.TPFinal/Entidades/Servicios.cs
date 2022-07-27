using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Servicios
    {
        protected string precio;
        protected string servicio;
        protected string dias;
        protected string equipo;

        public Servicios()
        {

        }
        public Servicios(string precio, string servicio, string dias, string equipo)
        {
            this.precio = precio;
            this.servicio = servicio;
            this.dias = dias;
            this.equipo = equipo;
        }
        public string Servicio
        {
            set
            {
                this.servicio = value;
            }
            get
            {
                return this.servicio;
            }
        }
        public string Precio
        {
            set
            {
                this.precio = value;
            }
            get
            {
                return this.precio;
            }
        }
        public string Dias
        {
            set
            {
                this.dias = value;
            }
            get
            {
                return this.dias;
            }
        }
        public string Equipo
        {
            set
            {
                this.equipo = value;
            }
            get
            {
                return this.equipo;
            }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"Servicio: {this.Servicio}, Equipo: {this.Equipo}, Precio: ${this.Precio}, Dias para completar: {this.Dias}.");

            return sb.ToString();
        }
        /// <summary>
        /// Muestra los precios de los distintos servicios que se dan.
        /// </summary>
        /// <returns>retorna un string con la informacion</returns>
        public static string MostrarPrecios()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("");
            sb.AppendLine("PC: Manatenimiento desde $3000 hasta $4000");
            sb.AppendLine("PC: Reparaciones desde $5000 hasta $40000");
            sb.AppendLine("PC: Ventas desde $55000 hasta $120000");
            sb.Append("\n");
            sb.Append("\n");
            sb.AppendLine("PS4: Mantenimiento desde $2000 hasta $5000.");
            sb.AppendLine("PS4: Reparaciones desde $6000 hasta $15000.");
            sb.AppendLine("PS4: Ventas desde $35000 hasta $50000.");
            sb.Append("\n");
            sb.Append("\n");
            sb.AppendLine("PS3: Mantenimiento desde $1000 hasta $4000");
            sb.AppendLine("PS3: Reparaciones desde $5000 hasta $10000");
            sb.AppendLine("PS3: Ventas desde $15000 hasta $20000");
            sb.Append("\n");
            sb.Append("\n");
            sb.AppendLine("XBOX360: Mantenimiento desde $1000 hasta $4000");
            sb.AppendLine("XBOX360: Reparaciones desde $4000 hasta $9000");
            sb.AppendLine("XBOX360: Ventas desde $14000 hasta $19000");
            sb.Append("\n");
            sb.Append("\n");
            sb.AppendLine("XBOXONE: Mantenimiento desde $2500 hasta $5000");
            sb.AppendLine("XBOXONE: Reparaciones desde $7000 hasta $12000");
            sb.AppendLine("XBOXONE: Ventas desde $30000 hasta $45000");
            sb.Append("\n");
            sb.Append("\n");
            sb.AppendLine("MONITOR: Mantenimiento desde $1000 hasta $1500");
            sb.AppendLine("MONITOR: Reparaciones desde $4000 hasta $15000");
            sb.AppendLine("MONITOR: Ventas desde $35000 hasta $75000");

            return sb.ToString();
        }

    }
}
