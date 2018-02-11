using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1º) Suma" + "\n" + "2º) Resta" + "\n" + "3º) Multiplicación" + "\n" + "4º) División" + "\n" + "5º) Potenciación" + "\n");
            Console.Write("Seleccione una opción: ");
            IOperacion io = null;
            OperacionFactory factory = new OperacionFactory();
            int c = 0;

            switch (Console.Read())
            {
                case '1':
                    Console.Write("Suma..");
                    io = factory.CrearOperacion(Operacion.Suma);
                    c = io.RealizarOperacion(1, 2);
                    // Continuar lógica y extraer métodos //
                    break;
                case '2':
                    Console.Write("Resta..");
                    io = factory.CrearOperacion(Operacion.Resta);
                    c = io.RealizarOperacion(1, 2);
                    // Continuar lógica y extraer métodos //
                    break;
                case '3':
                    Console.Write("Multiplicación..");
                    io = factory.CrearOperacion(Operacion.Multiplicacion);
                    c = io.RealizarOperacion(1, 2);
                    // Continuar lógica y extraer métodos //
                    break;
                case '4':
                    Console.Write("División..");
                    io = factory.CrearOperacion(Operacion.Division);
                    c = io.RealizarOperacion(1, 2);
                    // Continuar lógica y extraer métodos //
                    break;
                case '5':
                    Console.Write("Potenciación..");
                    io = factory.CrearOperacion(Operacion.Potenciacion);
                    c = io.RealizarOperacion(2, 2);
                    // Continuar lógica y extraer métodos //
                    break;
            }
            Console.WriteLine(c);
            Console.ReadKey();
        }
    }
}
