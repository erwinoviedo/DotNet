using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Docente : Persona
    {
        public string CodigoContrato { get; set; }
        public DateTime FechaContrato { get; set; }
        public string Profesion { get; set; }
        public Docente()
        {
            //Constructor
        }
    }
}
