using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class Potenciacion : IOperacion
    {
        public int RealizarOperacion(int a, int b)
        {
            double aDouble = Convert.ToDouble(a);
            double bDouble = Convert.ToDouble(b);
            return (int)Math.Pow(aDouble, bDouble);
        }
    }
}
