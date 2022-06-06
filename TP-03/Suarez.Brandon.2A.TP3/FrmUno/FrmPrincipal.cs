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
using FrmPrincipal;

namespace FrmUno
{
    public partial class FrmPrincipal : Form
    {
        List<Cliente> listaClientes = new List<Cliente>();
        public FrmPrincipal()
        {
            InitializeComponent();
        }
        /// <summary>
        /// llama al formulario de agregar cliente y le envia un cliente vacio
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
            Cliente nuevoCliente = new Cliente();

            FrmAgregar agregar = new FrmAgregar(nuevoCliente);
            DialogResult resultado = agregar.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                listaClientes.Add(nuevoCliente);
                lstCompras.DataSource = null;
                lstCompras.DataSource = listaClientes;
            }  
        }
        /// <summary>
        /// llama a la funcion eliminar cliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                EliminarCliente();
            }
            catch(NameException ex)
            {
                MessageBox.Show(ex.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnArchivo_Click(object sender, EventArgs e)
        {
            FrmArchivos frmArchivo = new FrmArchivos(listaClientes);
            frmArchivo.Show();
        }
        /// <summary>
        /// Accede al formulario de xml.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnXml_Click(object sender, EventArgs e)
        {
            FrmXml nuevoXml = new FrmXml(listaClientes);
            nuevoXml.Show();
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtDniEliminar.Text = null;
        }
        /// <summary>
        /// Elimina un cliente de la lista.
        /// </summary>
        public void EliminarCliente()
        {
            string dni = txtDniEliminar.Text;

            if(string.IsNullOrWhiteSpace(dni) || dni.All(char.IsLetter) == true)
            {
                throw new NameException("El espacio esta vacio o contiene letras");
            }
            foreach (Cliente c in listaClientes)
            {
                if (c.Dni == dni)
                {
                    listaClientes.Remove(c);
                    break;
                }
            }
            lstCompras.DataSource = null;
            lstCompras.DataSource = listaClientes;
        }
        private void btnHarcode_Click(object sender, EventArgs e)
        {
            HardcodearClientes();
        }
        /// <summary>
        /// Harcodea 5 clientes a la lista.
        /// </summary>
        public void HardcodearClientes()
        {
            Cliente nuevo1 = new Cliente("Jorge Newberry", "38987456", "TECLADO", "11/07/2022");
            Cliente nuevo2 = new Cliente("Mario Zarate", "36783123", "PANTALLA", "20/08/2022");
            Cliente nuevo3 = new Cliente("Jose Gonzales", "27567432", "MOUSE", "25/08/2022");
            Cliente nuevo4 = new Cliente("Franco Suarez", "47803308", "AURICULARES", "27/08/2022");
            Cliente nuevo5 = new Cliente("Manuel Oviedo", "43823302", "MOUSE", "29/08/2022");

            listaClientes.Add(nuevo1);
            listaClientes.Add(nuevo2);
            listaClientes.Add(nuevo3);
            listaClientes.Add(nuevo4);
            listaClientes.Add(nuevo5);

            lstCompras.DataSource = null;
            lstCompras.DataSource = listaClientes;
        }
    }
}
