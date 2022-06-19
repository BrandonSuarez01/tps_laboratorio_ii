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


namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        List<string> listaOperaciones = new List<string>();
        public FormCalculadora()
        {
            InitializeComponent();
        }
        private void btnOperar_Click(object sender, MouseEventArgs e)
        {
            string num1;
            string num2;
            string operador;
            double retorno;
            string retornoConvertido;

            num1 = txtNumero1.Text;
            num2 = txtNumero2.Text;
            operador = cmbOperador.SelectedItem.ToString();

            retorno = Operar(num1, num2, operador);
            retornoConvertido = retorno.ToString();

            lblResultado.Text = retornoConvertido;
            listaOperaciones.Add(num1 + operador + num2 + "=" + retornoConvertido);
            lstOperaciones.DataSource = null;
            lstOperaciones.DataSource = listaOperaciones;
            
        }
        /// <summary>
        /// recibe los numeros y el operador para realizar las operaciones aritmeticas necesarias.
        /// </summary>
        /// <param name="numero1">string del primer numero</param>
        /// <param name="numero2">string del segundo numero</param>
        /// <param name="operador">string del operdor a utilizar</param>
        /// <returns>retorna el double del resultado</returns>
        private static double Operar (string numero1, string numero2, string operador)
        {
            double retorno = 0;
            char operadorConvertido;
            
            Operando num1 = new Operando(numero1);
            Operando num2 = new Operando(numero2);
            operadorConvertido = char.Parse(operador);

            retorno = Calculadora.Operar(num1, num2, operadorConvertido);

            return retorno;
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        /// <summary>
        /// Limpia los espacios de texto del combo box, texbox1, texbox2 y el label.
        /// </summary>
        private void Limpiar()
        {
            txtNumero1.Text = null;
            txtNumero2.Text = null;
            cmbOperador.Text = null;
            lblResultado.Text = null;    
        }
        private void btnConvertirBinario_Click(object sender, EventArgs e)
        {
            Operando num = new Operando();
            string numero;
            string numeroTransformado;

            numero = lblResultado.Text;
            numeroTransformado = num.DecimalBinario(numero);
            lblResultado.Text = numeroTransformado;
        }
        private void btnConvertirDecimal_Click(object sender, EventArgs e)
        {
            Operando num = new Operando();
            string numero;
            string numeroTransformado;

            numero = lblResultado.Text;
            numeroTransformado = num.BinarioDecimal(numero);
            lblResultado.Text = numeroTransformado;
        }
        private void FormCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult respuesta;
       
            if (e.CloseReason == CloseReason.UserClosing)
            {
                respuesta = MessageBox.Show("¿Seguro de querer salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta != DialogResult.Yes)
                {
                    e.Cancel = true;
                }
            }
        }
        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
