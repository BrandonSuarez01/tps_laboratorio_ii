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
    public partial class FrmXml : Form
    {
        List<Cliente> lista;
        public FrmXml()
        {
            InitializeComponent();
        }
        public FrmXml(List<Cliente> list) : this()
        {
            this.lista = list;
        }
        /// <summary>
        /// Ecribe un archivo xml.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEscribir_Click(object sender, EventArgs e)
        {
            XML<Cliente> escribir = new XML<Cliente>();
            if(escribir.Serializar(lista) == true)
            {
                MessageBox.Show("Se ha escrito el archivo correctamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se puede escribir una lista vacia.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        /// <summary>
        /// lee un archivo xml.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLeer_Click(object sender, EventArgs e)
        {
            XML<Cliente> leer = new XML<Cliente>();
            List<Cliente> listaXml = new List<Cliente>();

            listaXml = leer.Deserializar();

            lstDatos.DataSource = null;
            lstDatos.DataSource = listaXml;
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
