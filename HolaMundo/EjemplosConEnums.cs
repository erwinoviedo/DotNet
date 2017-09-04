using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundo
{
    enum TipoDeDocumento {
        CarnetIdentidad,
        Pasaporte,
        LibretaServicioMilitar
    }
    class EjemplosConEnums
    {
        static void Ejemplo()
        {
            TipoDeDocumento documento;

            documento = TipoDeDocumento.CarnetIdentidad;

            if (documento == TipoDeDocumento.CarnetIdentidad)
            {
                //Codigo
            }
            else if(documento == TipoDeDocumento.LibretaServicioMilitar)
            {
                //Codigo
            }
            else if(documento == TipoDeDocumento.Pasaporte)
            {
                //Codigo
            }
        }

        static void UsandoSwitch()
        {
            TipoDeDocumento documento;

            documento = TipoDeDocumento.CarnetIdentidad;

            switch (documento)
            {
                case TipoDeDocumento.CarnetIdentidad:
                    //Codigo
                    break;
                case TipoDeDocumento.Pasaporte:
                    //Codigo
                    break;
                case TipoDeDocumento.LibretaServicioMilitar:
                    //Codigo
                    break;
                default:
                    break;
            }
        }
    }
}
