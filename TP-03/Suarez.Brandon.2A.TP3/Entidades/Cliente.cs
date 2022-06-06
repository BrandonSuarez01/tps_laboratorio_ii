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
        private string fecha;

        public Cliente()
        {

        }
        public Cliente(string nombre, string dni, string producto, string fecha) : this()
        {
            this.nombreCliente = nombre;
            this.documentoCliente = dni;
            this.producto = producto;
            this.fecha = fecha;
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

            sb.Append($"Nombre: {this.Nombre}, DNI: {this.Dni}, Producto: {this.Producto}, Fecha: {this.Fecha}");

            return sb.ToString();
        }
    }
}

