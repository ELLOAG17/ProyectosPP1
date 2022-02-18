using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectosPP.Clases
{
    internal class OperacionesSc
    {
        private double valor1;
        private double valor2;

        public OperacionesSc(double valor1, double valor2)
        {
            this.valor1 = valor1;
            this.valor2 = valor2;
        }
        public double suma()
        {
            return (valor1 + valor2);
        }
        public double resta()
        {
            return (valor1 - valor2);
        }
        public double multiplicacion()
        {
            return (valor1 * valor2);
        }
        public double division()
        {
            return (valor1 / valor2);
        }
        public double raiz()
        {
            return (Math.Sqrt (valor1));
        }
        public double porcentaje()
        {
            return  (valor1*(valor2)/ 100 );
        }

    }
}
