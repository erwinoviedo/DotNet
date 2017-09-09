using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            // Single-dimensional array
            int[] numbers = new int[5];

            
            // Multidimensional array
            string[,] names = new string[5, 4];

            // Array-of-arrays (jagged array)
            byte[][] scores = new byte[5][];

            // Create the jagged array
            for (int i = 0; i < scores.Length; i++)
            {
                scores[i] = new byte[i + 3];
            }

            // Print length of each row
            for (int i = 0; i < scores.Length; i++)
            {
                Console.WriteLine($"Length of row {i} is {scores[i].Length}");
            }

            //Inicializando Arrays
            int[] numbersArray = new int[5] { 1, 2, 3, 4, 5 };
            string[] namesArray = new string[3] { "Matt", "Joanne", "Robert" };

            Console.ReadLine();
        }
    }
}
