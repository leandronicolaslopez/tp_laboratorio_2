using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora2017
{
    class Calculadora
    {
		/// <summary>
		/// Realiza el cálculo</summary>
		/// <param name="num1"> 1er número de la operación.</param>
		/// <param name="num2"> 2do número de la operación.</param>
		/// <param name="operador"> Operación.</param>
        public static double Operar(Numero num1, Numero num2, string operador)
        {
            operador = ValidarOperador(operador);

            switch (operador)
            {
                case "+":
                    return num1.getNumero() + num2.getNumero();
                case "-":
                    return num1.getNumero() - num2.getNumero();
                case "*":
                    return num1.getNumero() * num2.getNumero();
                case "/":
                    if (num2.getNumero() == 0)
                        return 0;
                    else
                        return num1.getNumero() / num2.getNumero();
                default:
                    return 0;
            }
        }

		/// <summary>
		/// Valida un operador</summary>
		/// <param name="op"> Operador a validar.</param>
        private static string ValidarOperador(string op) {
            string[] validops = new string[4] { "+", "-", "*", "/" };

            if (validops.Contains(op))
                return op;
            else
                return "+";
        }
    }
}
