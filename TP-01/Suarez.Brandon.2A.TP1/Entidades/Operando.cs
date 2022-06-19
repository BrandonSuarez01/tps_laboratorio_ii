using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Entidades
{
    public class Operando
    {
        private double numero;
        /// <summary>
        /// constructor por defecto
        /// </summary>
        public Operando()
        {
            this.numero = 0;
        }
        /// <summary>
        /// constructor por double
        /// </summary>
        /// <param name="numero">numero para dar valor</param>
        public Operando(double numero)
        {
            this.numero = numero;
        }
        /// <summary>
        /// constructor por string(parsea el string para asignarlo al atributo)
        /// </summary>
        /// <param name="strNumero">string para dar valor</param>
        public Operando(string strNumero)
        {
            bool retorno;
            int numeroParseado;

            retorno = int.TryParse(strNumero, out numeroParseado);

            if (retorno == true)
            {
                this.numero = numeroParseado;
            }
        }
        /// <summary>
        /// valida que el string recibido sea un numero y lo retorna.
        /// </summary>
        /// <param name="strNumero">Es el numero que recibe como parametro.</param> 
        /// <returns>retorna cero si no se pudo parsear el numero.</returns> 
        private double ValidarOperando(string strNumero)
        {
            double retorno = 0;
            bool numero;

            numero = double.TryParse(strNumero, out retorno);

            if (numero == false)
            {
                retorno = 0;
            }

            return retorno;
        }
        /// <summary>
        /// Le da valor al atributo numero.
        /// </summary>
        public string Numero
        {
            set
            {
                double retorno = ValidarOperando(value);

                if(retorno != 0)
                {
                    this.numero = retorno;
                }
            }
        }
        /// <summary>
        /// Verifica que el string recibido sea una combinacion de 0 y 1.
        /// </summary>
        /// <param name="binario">el string que recibe para validar</param>
        /// <returns>retorna el binario si es valido, sino retorna false</returns>
        private string EsBinario(string binario)
        {
            string retorno;
            int tamanio = binario.Length;

            bool respuesta;
            respuesta = Regex.IsMatch(binario, "^[01]+$");

            if(respuesta == true)
            {
                retorno = binario;
            }
            else
            {
                retorno = "false";
            }
            return retorno;
        }
        /// <summary>
        /// Convierte el string recibido en binario a un numero decimal.
        /// </summary>
        /// <param name="binario">binario que se va a transformar</param>
        /// <returns>retorna el decimal trasformado como string</returns>
        public string BinarioDecimal(string binario)
        {
            string retorno;
            int binarioDecimal = 0;
            int tamanio = 0;

            char[] array = binario.ToCharArray();
            Array.Reverse(array);
            
            retorno = EsBinario(binario);

            if (retorno != "false")
            {
                tamanio = binario.Length;

                for (int i = 0; i < tamanio; i++)
                {
                    if (array[i] == '1')
                    {
                        binarioDecimal += (int)Math.Pow(2, i);
                    }
                }
                retorno = binarioDecimal.ToString();
            }

            return retorno;
        }
        /// <summary>
        /// Transforma el string decimal recibido a un string binario.
        /// </summary>
        /// <param name="numero">numero decimal a ser transformado</param>
        /// <returns>retorna el string en binario</returns>
        public string DecimalBinario(string numero)
        {
            int entero;
            bool pudoConvertir;
            string binarioConvertido = "";
            string retorno;

            pudoConvertir = int.TryParse(numero, out entero);
            entero = Math.Abs(entero);

            if (pudoConvertir == true)
            {
                while (entero > 0)
                {
                    binarioConvertido = entero % 2 + binarioConvertido;

                    entero = entero / 2;
                }

                retorno = binarioConvertido;
            }
            else
            {
                retorno = "Valor Invalido";
            }
            return retorno;
        }
        /// <summary>
        /// Transforma el double decimal recibido a un string binario.
        /// </summary>
        /// <param name="numero">decimal double a ser transformado</param>
        /// <returns>retorna el string del binario transformado</returns>
        public string DecimalBinario(double numero)
        {
            string binario;
            string retorno;

            binario = numero.ToString();
            retorno = DecimalBinario(binario);

            return retorno;
        }
        /// <summary>
        /// Sobrecarga el operador -
        /// </summary>
        /// <param name="n1"></param>Recibe el primer objeto a operar.
        /// <param name="n2"></param>Recibe el segundo objeto a operar.
        /// <returns>retorna el resultado de la operacion</returns>
        public static double operator - (Operando n1, Operando n2)
        {
            return n1.numero - n2.numero;
        }
        /// <summary>
        /// Sobrecarga el operador +
        /// </summary>
        /// <param name="n1"></param>Recibe el primer objeto a operar.
        /// <param name="n2"></param>Recibe el segundo objeto a operar.
        /// <returns>retorna el resultado de la operacion</returns>
        public static double operator + (Operando n1, Operando n2)
        {
            return n1.numero + n2.numero;
        }
        /// <summary>
        /// Sobrecarga el operador /
        /// </summary>
        /// <param name="n1"></param>Recibe el primer objeto a operar.
        /// <param name="n2"></param>Recibe el segundo objeto a operar.
        /// <returns>retorna el resultado de la divicion si el segundo operando no es 0, en caso de ser 0 retorna MinValue</returns>
        public static double operator / (Operando n1, Operando n2)
        {
            double retorno;

            if(n2.numero == 0)
            {
                retorno = double.MinValue;
            }
            else
            {
                retorno = n1.numero / n2.numero;
            }
            return retorno;
        }
        /// <summary>
        /// Sobrecarga el operador *
        /// </summary>
        /// <param name="n1"></param>Recibe el primer objeto a operar.
        /// <param name="n2"></param>Recibe el segundo objeto a operar.
        /// <returns>retorna el resultado de la operacion</returns>
        public static double operator * (Operando n1, Operando n2)
        {
            return n1.numero * n2.numero;
        }
    }
}
