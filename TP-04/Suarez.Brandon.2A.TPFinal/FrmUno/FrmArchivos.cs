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
    public partial class FrmArchivos : Form
    {
        List<string> listaLeer;
        List<Cliente> listaEscribir;
        public FrmArchivos()
        {
            InitializeComponent();
        }
        public FrmArchivos(List<Cliente> list) : this()
        {
            this.listaEscribir = list;
            this.listaLeer = new List<string>();
        }
        /// <summary>
        /// Lee el archivo creado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLeer_Click(object sender, EventArgs e)
        {

            List<string> lista = new List<string>();
            Archivos leerArchivo = new Archivos();

            try
            {
                lista = leerArchivo.LeerArchivo();
                
                lstMostrar.DataSource = null;
                lstMostrar.DataSource = lista;

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// escribe un archivo en el escritorio si la lista que recibe no esta vacia.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEscribir_Click(object sender, EventArgs e)
        {
            Archivos escribirArchivos = new Archivos();
            if(escribirArchivos.EscribirArchivo(listaEscribir) == true)
            {
                MessageBox.Show("Se ha escrito el archivo correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("ERROR no hay nada que escribir.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
