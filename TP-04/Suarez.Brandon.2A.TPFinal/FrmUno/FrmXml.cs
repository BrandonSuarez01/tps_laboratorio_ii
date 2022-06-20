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
                //metodo de extencion aplicado.
                MessageBox.Show(MetodoExtendido.Mensaje("ah sido realizada con exito."), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {   //metodo de extencion aplicado.
                MessageBox.Show(MetodoExtendido.Mensaje("no pudo ser realizada(No hay que escribir)."), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
