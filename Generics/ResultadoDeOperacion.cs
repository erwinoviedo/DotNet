using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class ResultadoDeOperacion
    {
        public ResultadoDeOperacion(bool resultado, string mensaje)
        {
            this.Exitosa = resultado;
            this.Mensaje = mensaje;
        }
        public bool Exitosa { get; set; }
        public string Mensaje { get; set; }
    }
}
