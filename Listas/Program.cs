using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    class Program
    {
        private static readonly string[] coloresPrimarios = { "Rojo", "Verde", "Azul" };
        private static readonly string[] coloresSecundarios = { "Celeste", "Violeta", "Amarillo" };
        

        static void Main(string[] args)
        {
            var listaColores = new List<string>();

            foreach (var colorPrimario in coloresPrimarios)
            {
                listaColores.Add(colorPrimario);
            }

            foreach (var colorSecundario in coloresSecundarios)
            {
                listaColores.Add(colorSecundario);
            }

            MostrarLista(listaColores);

        }
        

        static void MostrarLista(List<string> lista)
        {
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }
        }
    }
}
