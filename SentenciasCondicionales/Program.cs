using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SentenciasCondicionales
{
    class Program
    {
        static void Main(string[] args)
        {
            var Maria = 20;

            if (Maria > 18)
            {
                Console.WriteLine("Maria es mayor de edad");
            }
            else if (Maria > 11 && Maria < 18)
            {
                Console.WriteLine("Maria es adolescente");
            }
            else
            {
                Console.WriteLine("Maria es niña");
            }

            // Switch
            // Funciona con cadenas o enteros
            string codigo = "A1";
            switch (codigo)
            {
                case "A1":
                    Console.WriteLine("Código A1");
                    break;
                case "B2":
                    Console.WriteLine("Código B2");
                    break;
                case "C8":
                    Console.WriteLine("Código C8");
                    break;
                default:
                    Console.WriteLine("Código no soportado");
                    break;
            }
        }
    }
}
