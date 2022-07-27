using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Cliente
    {
        private string nombreCliente;
        private string documentoCliente;
        private string fecha;
        private Servicios servicioElegido;

        public Cliente()
        {

        }
        public Cliente(string nombre, string dni, string fecha, Servicios servicio) : this()
        {
            this.nombreCliente = nombre;
            this.documentoCliente = dni;
            this.fecha = fecha;
            this.servicioElegido = servicio;
        }
        public Servicios ServicioElegido
        {
            set
            {
                this.servicioElegido = value;
            }
            get
            {
                return this.servicioElegido;
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

            sb.Append($"Nombre: {this.Nombre}, DNI: {this.Dni}, Fecha: {this.Fecha}, ");
            sb.Append(ServicioElegido.ToString());

            return sb.ToString();
        }
        
        
    }
}
