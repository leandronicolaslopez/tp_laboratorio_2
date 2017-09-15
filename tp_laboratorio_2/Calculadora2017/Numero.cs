using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora2017
{
    class Numero
    {
        private double numero;

        public Numero()
        {
            numero = 0;
        }

        public Numero(double numero)
        {
            this.numero = numero;
        }

        public Numero(string numero)
        {
            this.numero = validarNumero(numero);
        }

        public double getNumero()
        {
            return numero;
        }
        public void setNumero(string val)
        {
            numero = validarNumero(val);
        }

		/// <summary>
		/// Valida un número.</summary>
		/// <param name="val"> Número a validar.</param>
        public double validarNumero(string val)
        {
            double d;
            if (double.TryParse(val, out d))
            {
                return d;
            }
            else
            {
                return 0;
            }
        }
    }
}
