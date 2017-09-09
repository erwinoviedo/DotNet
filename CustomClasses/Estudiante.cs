using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Estudiante: Persona
    {
        public string NombrePapa { get; set; }
        public string NombreMama { get; set; }
        public string TelefonoContacto { get; set; }
        public Estudiante()
        {
            //Constructor
        }
    }
}
