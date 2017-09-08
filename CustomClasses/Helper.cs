using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public static class Helper
    {

        public static List<Persona> ObtenerListaDePersonas()
        {
            var listaPersonas = new List<Persona>()
            {
                new Persona { Id = 1, Nombre="Ariel", Apellido="Guzman", },
                new Persona { Id = 2, Nombre="Vanesa", Apellido="Alavardo" },
                new Persona { Id = 3, Nombre="Martin", Apellido="Calderon" },
                new Persona { Id = 4, Nombre="Cegmina", Apellido="Delgadillo" },
                new Persona { Id = 5, Nombre="Patricia", Apellido="Klaus" },
                new Persona { Id = 6, Nombre="Oscar", Apellido="Miranda" },
                new Persona { Id = 7, Nombre="Miguel", Apellido="Arredondo" },
                new Persona { Id = 8, Nombre="Juan Jose", Apellido="Guzman" },
                new Persona { Id = 9, Nombre="Elias", Apellido="Aguirre" },
                new Persona { Id = 10, Nombre="Marcela", Apellido="Mundaca" },
                new Persona { Id = 11, Nombre="Eliana", Apellido="Aguilera" },
                new Persona { Id = 12, Nombre="Ernesto", Apellido="Arredondo" },
                new Persona { Id = 13, Nombre="Maria", Apellido="Cuevas" },
                new Persona { Id = 14, Nombre="Alfredo", Apellido="Fred" },
                new Persona { Id = 15, Nombre="Genaro", Apellido="Apaza" },
                new Persona { Id = 16, Nombre="Diego", Apellido="Rodrgiuez" },
                new Persona { Id = 17, Nombre="Javier", Apellido="Canavaro" },
                new Persona { Id = 18, Nombre="Carla", Apellido="Perez" },
                new Persona { Id = 19, Nombre="Evy", Apellido="Cuevas" },

            };
            return listaPersonas;
        }
    }
}
