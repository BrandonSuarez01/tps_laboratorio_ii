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
        //Evento
        Evento cambiarColor = new Evento();
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
                Archivos.EscribirCliente(nuevoCliente);
                BasesDatos.SubirCliente(nuevoCliente);
                listaClientes.Add(nuevoCliente);
                lstServicios.DataSource = null;
                lstServicios.DataSource = listaClientes;
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
                notificador("Los datos se eliminaron correctamente");//delegado de mi notificacion.
            }
            catch(NameException ex)
            {
                MessageBox.Show(ex.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        /// <summary>
        /// Accede al formulario de xml.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnXml_Click(object sender, EventArgs e)
        {
            if(listaClientes.Count > 0)
            {
                FrmXml nuevoXml = new FrmXml(listaClientes);
                nuevoXml.Show();
            }
            else
            {
                MessageBox.Show("No puede acceder si la lista se encuentra vacia.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
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
            lstServicios.DataSource = null;
            lstServicios.DataSource = listaClientes;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                HardcodearClientes();
                this.cambiarColor.cambioColor += ActualizarColor;//evento de cambio de color en los botones.
                this.cambiarColor.Cambiar();
                MessageBox.Show(MetodoExtendido.Mensaje("clientes escrito correctamente"), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);//uso del metodo extendido.
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        /// <summary>
        /// Hardcodea 5 clientes con sus servicios en la lista(si ya hay 5 no hardcodea nada)
        /// </summary>
        private void HardcodearClientes()
        {

            if (listaClientes.Count < 5)
            {
                Servicios serv1 = new Servicios("3000", "Mantenimiento", "3", "PC");
                Servicios serv2 = new Servicios("4000", "Mantenimiento", "5", "PC");
                Servicios serv3 = new Servicios("1000", "Mantenimiento", "2", "PS3");
                Servicios serv4 = new Servicios("56000", "Venta", "7", "PS4");
                Servicios serv5 = new Servicios("9000", "Reparacion", "10", "XBOX360");

                Cliente cliente1 = new Cliente("Marcos Perez", "34678954", "11/04/2021", serv1);
                Cliente cliente2 = new Cliente("Jose Gonzales", "23678921", "13/04/2021", serv2);
                Cliente cliente3 = new Cliente("Gonzalo Ferrera", "43623954", "14/04/2021", serv3);
                Cliente cliente4 = new Cliente("Franco Suarez", "47803308", "14/04/2021", serv4);
                Cliente cliente5 = new Cliente("Mario Zarate", "40678123", "15/05/2021", serv5);

                listaClientes.Add(cliente1);
                listaClientes.Add(cliente2);
                listaClientes.Add(cliente3);
                listaClientes.Add(cliente4);
                listaClientes.Add(cliente5);

                lstServicios.DataSource = null;
                lstServicios.DataSource = listaClientes;

            }
            else
            {
                throw new Exception("La lista ya tiene mas de 5 clientes.");
            }
        }
        /// <summary>
        /// Abre el formulario de reclamos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReclamos_Click(object sender, EventArgs e)
        {
            FrmReclamos form1 = new FrmReclamos();
            form1.Show();
        }
        // <summary>
        /// cambia el color del boton hardcodear.
        /// </summary>
        public void ActualizarColor()
        {
            this.btnHardcode.BackColor = Color.Red;
        }
        /// <summary>
        /// Metodo relacionado al delegado notificar.
        /// </summary>
        /// <param name="texto">mensaje a notificar a traves de un messagebox</param>
        public static void Notificar(string texto)
        {
            MessageBox.Show(texto, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnBaseDatos_Click(object sender, EventArgs e)
        {
            try
            {
                listaClientes = BasesDatos.LeerDatos();
                lstServicios.DataSource = null;
                lstServicios.DataSource = listaClientes;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        }
    }
}
