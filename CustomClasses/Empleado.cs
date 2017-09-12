using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Empleado : Persona, IContrato
    {
        public string CodigoContrato { get; set; }
        public DateTime FechaContrato { get; set; }
        public DateTime FechaIngreso { get; set; }
        public DateTime FechaSalida { get; set; }
        public Empleado()
        {
        }

        
    }
}
