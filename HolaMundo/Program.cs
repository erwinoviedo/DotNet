﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola Mundo");
            InicializandoVariables();
            UsandoFor();
            UsandoWhile();
            UsandoDoWhile();
            Console.Read();
        }
        /// <summary>
        /// El proposito del siguiente codigo es demostrar diferentes formas que existen para inicializar una variable
        /// </summary>
        static void InicializandoVariables()
        {
            string nombre = "Daniel";
            var apellido = "Perez";
            var fechaNacimiento = new DateTime(1997, 8, 30);
            var edad = 20;
            var employee = new CustomClasses.Empleado
            {
                Id = 1,
                Nombre = "Maria",
                Apellido = "Jose",
                FechaNacimiento = new DateTime(1987, 8, 30)                
            };
            Console.WriteLine($"{nombre} {apellido} tiene {edad} años y su fecha de nacimiento es {fechaNacimiento.ToShortDateString()}");
        }

       

        static void UsandoFor()
        {
            for (int i = 0; i < 300; i++)
            {
                Console.WriteLine($"Hola {i}");
            }
        }

        static void UsandoWhile()
        {
            var totalPersonas = 0;
            while (totalPersonas < 20)
            {
                Console.WriteLine($"Total personas = {totalPersonas}");
                totalPersonas++;
            }
        }
        static void UsandoDoWhile()
        {
            var totalPersonas = 0;
            do
            {
                Console.WriteLine($"Total personas = {totalPersonas}");
                totalPersonas++;
            }
            while (totalPersonas < 20);
        }
        static void UsandoConstantes()
        {
            const double piValue = 3.141592653589;
            const int mayoriaDeEdad = 18;            

        }
        
    }
}
