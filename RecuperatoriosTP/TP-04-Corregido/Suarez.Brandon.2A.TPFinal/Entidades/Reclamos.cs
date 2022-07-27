using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Reclamos
    {
        protected string nombreApellido;
        protected string dni;
        protected string reclamo;

        public Reclamos(string nombre, string documento, string texto)
        {
            this.nombreApellido = nombre;
            this.dni = documento;
            this.reclamo = texto;
        }
        public string NombreApellido
        {
            set
            {
                this.nombreApellido = value;
            }
            get
            {
                return this.nombreApellido;
            }
        }
        public string Dni
        {
            set
            {
                this.dni = value;
            }
            get
            {
                return this.dni;
            }
        }
        public string Reclamo
        {
            set
            {
                this.reclamo = value;
            }
            get
            {
                return this.reclamo;
            }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"Nombre del reclamante: {this.NombreApellido}, DNI del reclamante: {this.Dni}.");
            sb.Append("\n");
            sb.Append("\n");
            sb.AppendLine("Reclamo: ");
            sb.Append(this.Reclamo);

            return sb.ToString();
        }
    }
}
