
using System;

namespace Entidades
{
    public static class Calculadora
    {
        /// <summary>
        /// Valida que el operador a usar en las operaciones.
        /// </summary>
        /// <param name="operador">operador a usar</param>
        /// <returns>retorna el operador, y si esta vacio retorna +</returns>
        private static char ValidarOperador (char operador)
        {
            char retorno;

            if(operador != '+'|| operador != '-' || operador != '*' || operador != '/')
            {
                retorno = '+';
            }
            else
            {
                retorno = operador;
            }

            return retorno;
        }
        /// <summary>
        /// recibe los objetos para realizar las operaciones aritmeticas correspondientes al operador.
        /// </summary>
        /// <param name="num1">primer objeto a operar</param>
        /// <param name="num2">segundo objeto a operar</param>
        /// <param name="operador">operador a ultilizar</param>
        /// <returns>retorna el resultado de la operacion realizada</returns>
        public static double Operar (Operando num1, Operando num2, char operador)
        {
            double resultado = 0;

            if(operador == '+')
            {
                resultado = num1 + num2;
            }
            else
            {
                if (operador == '-')
                {
                    resultado = num1 - num2;
                }
                else
                {
                    if (operador == '*')
                    {
                        resultado = num1 * num2;
                    }
                    else
                    {
                        if (operador == '/')
                        {
                            resultado = num1 / num2;
                        }
                    }

                }
            }
            return resultado;
        }
    }
}
