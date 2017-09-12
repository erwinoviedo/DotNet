using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPracticps
{
    class Program
    {
        static void Main(string[] args)
        {
            EjercicionConListas();




        }

        static void EjercicionConArray()
        {
            //Declare un Array de numeros enteros de 100 ítems de capacidad
            int[] miArray = new int[100];
            Random rand = new Random();
            for (int i = 0; i < 100; i++)
            {
                //Asigne valores randomicos del 1 al 1000, en cada ítem del array
                var valorRandomico = rand.Next(1, 1000);

                //Valide que los valores randomicos no se repitan
                if (miArray.Contains(valorRandomico))
                {
                    //Obtener otro numero
                }
                else
                {
                    miArray[i] = valorRandomico;
                }

            }
        }

        static void EjercicionConListas()
        {
            //Declare un Array de numeros enteros de 100 ítems de capacidad
            List<int> miLista = new List<int>();
            Random rand = new Random();
            for (int i = 0; i < 100; i++)
            {
                //Asigne valores randomicos del 1 al 1000, en cada ítem del array
                var valorRandomico = rand.Next(1, 1000);

                //Valide que los valores randomicos no se repitan
                if (miLista.Contains(valorRandomico))
                {
                    //Obtener otro numero
                }
                else
                {
                    miLista.Add(valorRandomico);
                }

            }
        }
    }
}
