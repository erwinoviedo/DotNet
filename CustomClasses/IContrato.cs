using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    interface IContrato
    {
        string CodigoContrato { get; set; }
        DateTime FechaContrato { get; set; }
    }
}
