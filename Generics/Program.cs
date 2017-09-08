using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes;
namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crear una Pila con una clase generica, de personas:

            var listaPersonas = Helper.ObtenerListaDePersonas();

            var pilaPersonas = new Stack<Persona>();

            foreach (var persona in listaPersonas)
            {
                pilaPersonas.Push(persona);
            }

            while (pilaPersonas.Count>0)
            {
                var persona = pilaPersonas.Pop();
                MostrarPersona(persona);
            }

            Console.Read();
        }

        static void MostrarPersona(Persona persona)
        {
            Console.WriteLine($" Persona Id:{persona.Id}, Nombre:{persona.Nombre}, Apellido:{persona.Apellido}");
        }
    }
}
