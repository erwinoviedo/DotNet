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
            EjercicioNro4();
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
        static void EjercicioNro2()
        {
            const int notaMinimaAprobacion = 51;
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

            if (promedio >= notaMinimaAprobacion)
            {
                Console.WriteLine("Aprobado");
            }
            else
            {
                Console.WriteLine("Reprobado");
            }
          
            Console.Read();
        }

        static void EjercicioNro3()
        {
            const int notaMinimaAprobacion = 51;
            Console.Write("Ingrese un texto:");

            //Leer el nombre del alumno ingresado
            var textoIngresado = Console.ReadLine();

            foreach (var caracter in textoIngresado)
            {
                Console.WriteLine(caracter);
            }

            Console.Read();
        }

        static void EjercicioNro4()
        {
            const int notaMinimaAprobacion = 51;
            Console.Write("Ingrese un numero del 1 al 7:");

            //Leer el nombre del alumno ingresado
            var numeroIngresado = Convert.ToInt32( Console.ReadLine());

            //Todos los valores en el enum DayOfWeek coinciden expeto el 7 que representa al dia Domingo
            //Si el valor ingresado es 7 transformarlo a 0
            if (numeroIngresado == 7)
                numeroIngresado = 0;

            var diaDeLaSemana = (DayOfWeek)numeroIngresado;
            switch (diaDeLaSemana)
            {
                case DayOfWeek.Sunday:
                    Console.WriteLine("Domingo");
                    break;
                case DayOfWeek.Monday:
                    Console.WriteLine("Lunes");
                    break;
                case DayOfWeek.Tuesday:
                    Console.WriteLine("Martes");
                    break;
                case DayOfWeek.Wednesday:
                    Console.WriteLine("Miercoles");
                    break;
                case DayOfWeek.Thursday:
                    Console.WriteLine("Jueves");
                    break;
                case DayOfWeek.Friday:
                    Console.WriteLine("Viernes");
                    break;
                case DayOfWeek.Saturday:
                    Console.WriteLine("Sabado");
                    break;
                default:
                    break;
            }
            

            Console.Read();
        }
    }
}
