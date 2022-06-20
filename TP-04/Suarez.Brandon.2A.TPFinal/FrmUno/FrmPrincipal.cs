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
        //Delegados.
        public delegate void DelegadoNotificacionHandler(string texto);
        DelegadoNotificacionHandler notificador = new DelegadoNotificacionHandler(Notificar);
        //Lista Clientes.
        List<Cliente> listaClientes = new List<Cliente>();
        //Evento.
        Evento cambiarColor = new Evento();


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
                BasesDatos.subirCliente(nuevoCliente);
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
                throw new NameException("El espacio esta vacio o contiene letras.");
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
           
            if(listaClientes.Count == 0)
            {
                HardcodearClientes();
                this.cambiarColor.cambioColor += ActualizarColor;//evento de cambio de color en los botones.
                this.cambiarColor.Cambiar();
                MessageBox.Show("Lista cargada correctamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
            }
            else
            {
                
                MessageBox.Show("Ya cargo una lista de clientes.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } 
        }
        /// <summary>
        /// Harcodea 5 clientes a la lista.
        /// </summary>
        public void HardcodearClientes()
        {
            Cliente nuevo1 = new Cliente("Jorge Newberry", "38987456", "TECLADO", "11/07/2022", "$5000");
            Cliente nuevo2 = new Cliente("Mario Zarate", "36783123", "PANTALLA", "20/08/2022", "$25000");
            Cliente nuevo3 = new Cliente("Jose Gonzales", "27567432", "MOUSE", "25/08/2022", "$1500");
            Cliente nuevo4 = new Cliente("Franco Suarez", "47803308", "AURICULARES", "27/08/2022", "$3500");
            Cliente nuevo5 = new Cliente("Manuel Oviedo", "43823302", "MOUSE", "29/08/2022", "$800");

            listaClientes.Add(nuevo1);
            listaClientes.Add(nuevo2);
            listaClientes.Add(nuevo3);
            listaClientes.Add(nuevo4);
            listaClientes.Add(nuevo5);

            lstCompras.DataSource = null;
            lstCompras.DataSource = listaClientes;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            
            string dni = txtImprimir.Text;

            if (!string.IsNullOrWhiteSpace(dni) || !dni.All(char.IsLetter) == true)
            {
                foreach (Cliente c in listaClientes)
                {
                    if (c.Dni == dni)
                    {
                        Task.Run(() => Archivos.EscribirTicket(c));//funcion lambda y hilos.
                        MessageBox.Show("Ticket impreso correctamente en el escritorio.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }                
                }
            }
            else
            {
                MessageBox.Show("Por favor complete el campo con un DNI valido.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        /// <summary>
        /// Metodo relacionado al delegado notificar.
        /// </summary>
        /// <param name="texto">mensaje a notificar a traves de un messagebox</param>
        public static void Notificar(string texto)
        {
            MessageBox.Show(texto, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        /// <summary>
        /// cambia el color de los botones hardcodear y base de datos.
        /// </summary>
        public void ActualizarColor()
        {
            this.btnHarcode.BackColor = Color.Red;
            this.btnCargaBaseDatos.BackColor = Color.Red;
        }
        /// <summary>
        /// Agrega a la lista los clientes guardados en la base de datos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCargaBaseDatos_Click(object sender, EventArgs e)
        {
            if (listaClientes.Count == 0)
            {
                TraerDeBaseDatos();
            }
            else
            {
                MessageBox.Show("Ya cargo una lista de clientes.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        /// <summary>
        /// accede a las base de datos para traer los datos.
        /// </summary>
        public void TraerDeBaseDatos()
        {
            try
            {
                listaClientes = BasesDatos.leerDatos();
                this.cambiarColor.cambioColor += ActualizarColor;//evento de cambio de color en los botones.
                this.cambiarColor.Cambiar();
                lstCompras.DataSource = null;
                lstCompras.DataSource = listaClientes;
                notificador("Los datos se han descargado correctamente");//delegado de mi notificacion.
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
