using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class Suma : IOperacion
    {
        public int RealizarOperacion(int a, int b)
        {
            return a + b;
        }
    }
}
