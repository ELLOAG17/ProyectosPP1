using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class operacionest
    {
        public bool Isnumeric(string num)
        {
            try
            {
                double x = Convert.ToInt32(num);
                return true;
            } catch (Exception)
            {
                return false;
            }
        } public int Suma(int a, int b)
        {
            return a + b;

        }
        public int resta(int a , int b)
        {
            return a - b;
        }
        public int multiplicar(int a , int b)
        {
            return a * b;
        }
        public int division(int a , int b)
        {
            return a / b;
        }

    }
    


}
