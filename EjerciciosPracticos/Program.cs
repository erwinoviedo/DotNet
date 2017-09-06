using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPracticos
{
    class Program
    {
        static void Main(string[] args)
        {
            EjercicionNro1();
        }
        static void EjercicioNro1()
        {
            Console.Write("Ingrese el nombre del Alumno:");
            
            //Leer el nombre del alumno ingresado
            var nombreAlumno = Console.ReadLine();

            Console.Write("Nota 1: ");
            var valorNota1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nota 2: ");
            var valorNota2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nota 3: ");
            var valorNota3 = Convert.ToDouble(Console.ReadLine());

            var promedio = (valorNota1 + valorNota2 + valorNota3) / 3;
            Console.WriteLine($"Promedio: {promedio}");
            Console.Read();
        }
    }
}
