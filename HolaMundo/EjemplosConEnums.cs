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
            TipoDeDocumento documento = TipoDeDocumento.CarnetIdentidad;

           // documento = TipoDeDocumento.CarnetIdentidad;

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
                    break;
                case TipoDeDocumento.Pasaporte:
                    break;
                case TipoDeDocumento.LibretaServicioMilitar:
                    break;
                default:
                    break;
            }

            for (int index = 0; index < 10; index++)
            {

            }

            if (1==1)
            {

            }
            
        }
    }
}
