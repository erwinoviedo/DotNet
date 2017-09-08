using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diccionario
{
    class Program
    {
        static void Main(string[] args)
        {
            var diccionarioPersonas = new Dictionary<string, string>();

            diccionarioPersonas.Add("6945852", "Jose Ernesto Justiniano");
            diccionarioPersonas.Add("8597485", "Eliana Alvarez");
            diccionarioPersonas.Add("6266220", "Milenca Mundaca");
            diccionarioPersonas.Add("5884160", "Maria Espinoza");
            diccionarioPersonas.Add("5824820", "Tatiana Alvarez");
            diccionarioPersonas.Add("4858960", "Elena Blanca Lopez");
            diccionarioPersonas.Add("2663966", "Mario Vaca");

            //Obtener Persona con CI 5824820
            var nombre = diccionarioPersonas["5824820"];

            Console.WriteLine(nombre);

            //listar personas 

            foreach (var item in diccionarioPersonas)
            {
                Console.WriteLine($"CI: {item.Key}, Nombre: {item.Value}");
            }

            //Cambiar nombre de 5824820

            diccionarioPersonas["5824820"] = "Elsa Rodriguez";

            Console.Read();
        }
    }
}
