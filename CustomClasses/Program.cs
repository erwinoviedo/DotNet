using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            var docenteIng = new Docente { Id = 5, Nombre = "Francisco", Apellido = "Guevara" };
            var docenteEmpleado = new Empleado { Id = 5, Nombre = "Jose", Apellido = "Vaca" };

            /*AsignarContrato(docenteIng, new DateTime(2017, 5, 14), "UB-051701");
            AsignarContrato(docenteEmpleado, new DateTime(2014, 7, 14), "UB-071101");*/
        }

        /*static void AsignarContrato(Docente docente, DateTime fechaContrato, string codigoContrato)
        {
            docente.FechaContrato = fechaContrato;
            docente.CodigoContrato = codigoContrato;
        }*/

        
    }
}
