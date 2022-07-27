using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace FrmPrincipal
{
    public partial class FrmReclamos : Form, IValidar
    {
        public FrmReclamos()
        {
            InitializeComponent();
        }
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if(VerificarNumero(txtDni.Text) == true && VerificarLetra(txtNombre.Text) == false && string.IsNullOrWhiteSpace(richTxtBox.Text) == false)
            {
                Reclamos reclamo = new Reclamos(txtNombre.Text, txtDni.Text, richTxtBox.Text);

                try
                {

                    Task.Run(() => Archivos.EscribirReclamo(reclamo));//funcion lambda y hilos.
                    MessageBox.Show("Reclamo generado y guardado con exito.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Por favor complete todos los campos correctamente.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        /// <summary>
        /// Utiliza el metodo declarado en IValidar y verifica si la cadena es un numero
        /// </summary>
        /// <param name="texto">cadena a verificar</param>
        /// <returns>retorna true si es un numero</returns>
        public bool VerificarNumero(string texto)
        {
            bool retorno;
            int numero;

            retorno = int.TryParse(texto, out numero);

            return retorno;
        }
        /// <summary>
        /// Utiliza el metodo declarado en IValidar y verifica si la cadena de texto tiene numeros.
        /// </summary>
        /// <param name="texto">recibe la cadena a verificar</param>
        /// <returns>retorna true si contiene numeros</returns>
        public bool VerificarLetra(string texto)
        {
            return texto.All(char.IsDigit);
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
