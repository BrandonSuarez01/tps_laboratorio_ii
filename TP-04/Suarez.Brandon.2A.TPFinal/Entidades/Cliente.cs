using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Cliente
    {
        private string nombreCliente;
        private string documentoCliente;
        private string producto;
        private string importe;
        private string fecha;

        public Cliente()
        {

        }
        public Cliente(string nombre, string dni, string producto, string fecha, string precio) : this()
        {
            this.nombreCliente = nombre;
            this.documentoCliente = dni;
            this.producto = producto;
            this.fecha = fecha;
            this.importe = precio;
        }
        public string Importe
        {
            set
            {
                this.importe = value;
            }
            get
            {
                return this.importe;
            }
        }
        public string Nombre
        {
            set
            {
                this.nombreCliente = value;
            }
            get
            {
                return this.nombreCliente;
            }
        }
        public string Producto
        {
            set
            {
                this.producto = value;
            }
            get
            {
                return this.producto;
            }
        }
        public string Dni
        {
            set
            {
                this.documentoCliente = value;
            }
            get
            {
                return this.documentoCliente;
            }
        }
        public string Fecha
        {
            set
            {
                this.fecha = value;
            }
            get
            {
                return this.fecha;
            }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"Nombre: {this.Nombre}, DNI: {this.Dni}, Producto: {this.Producto}, Fecha: {this.Fecha}, Precio abonado: {this.Importe}");

            return sb.ToString();
        }
        /// <summary>
        /// Da el formato de escritura del ticket del cliente.
        /// </summary>
        /// <param name="c">cliente al que se le imprimira el ticket</param>
        /// <returns></returns>
        public static string MostrarTicket(Cliente c)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("--------------------------------------------------");
            sb.AppendLine("");
            sb.AppendLine("HIGH ELO ELECTRONICS");
            sb.AppendLine("");
            sb.AppendLine($"Nombre del cliente: {c.Nombre}");
            sb.AppendLine("");
            sb.AppendLine($"Numero de documento del cliente: {c.Dni}");
            sb.AppendLine("");
            sb.AppendLine($"Fecha de la compra: {c.Fecha}");
            sb.AppendLine("");
            sb.AppendLine($"Importe pagado: {c.Importe}");
            sb.AppendLine("");
            sb.AppendLine("Gracias por comprar en 'High Elo Electronics'");
            sb.AppendLine("");
            sb.AppendLine("--------------------------------------------------");

            return sb.ToString();
        }
    }
}

