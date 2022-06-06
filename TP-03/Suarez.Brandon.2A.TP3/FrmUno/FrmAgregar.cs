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

namespace FrmUno
{
    public partial class FrmAgregar : Form, IValidar 
    {
        Cliente clienteNuevo;
        public FrmAgregar()
        {
            InitializeComponent();
        }
        public FrmAgregar(Cliente cliente) : this()
        {
             this.clienteNuevo = cliente;
        }
        /// <summary>
        /// llama a agregar cliente y verifica la excepcion de este.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                AgregarCLiente();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
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
        /// <summary>
        /// Agrega clientes a la lista.
        /// </summary>
        public void AgregarCLiente()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtDni.Text) || string.IsNullOrWhiteSpace(cmbProductos.Text) || string.IsNullOrWhiteSpace(datFeha.Text))
            {
                throw new NameException("Por favor complete todos los campos.");
            }
            if(VerificarNumero(txtDni.Text) == true && VerificarLetra(txtNombre.Text) == false)
            {
                clienteNuevo.Nombre = txtNombre.Text;
                clienteNuevo.Dni = txtDni.Text;
                clienteNuevo.Producto = cmbProductos.Text;
                clienteNuevo.Fecha = datFeha.Text;
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Complete el campo DNI con numeros y El campo nombre solo con letras.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
