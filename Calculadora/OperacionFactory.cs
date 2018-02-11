using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class OperacionFactory
    {
        public IOperacion CrearOperacion(Operacion operacion)
        {
            IOperacion io = null;

            switch (operacion)
            {
                case Operacion.Suma:
                    io = new Suma();
                    break;
                case Operacion.Resta:
                    io = new Resta();
                    break;
                case Operacion.Multiplicacion:
                    io = new Multiplicacion();
                    break;
                case Operacion.Division:
                    io = new Division();
                    break;
                case Operacion.Potenciacion:
                    io = new Potenciacion();
                    break;
            }

            return io;
        }
    }
}
