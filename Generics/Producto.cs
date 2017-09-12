using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Producto
    {
        #region Constructors
        public Producto()
        {

        }       
        #endregion

        #region Properties

        public decimal Costo { get; set; }

        public string Description { get; set; }

        public int ProductoId { get; set; }

        public string NombreProducto { get; set; }
        
        public Vendedor Vendedor { get; set; }       

        public string ValidationMessage { get; private set; }

        #endregion

      /*/// <summary>
        /// Calcula el precio sugerido del producto
        /// </summary>
        /// <param name="porcentajeASubir">Percent used to mark up the cost.</param>
        /// <returns></returns>
        public ResultadoDeOperacion CalcularPrecioSugerido(decimal porcentajeASubir)
        {
            var message = "";
            if (porcentajeASubir <= 0m)
            {
                message = "Invalido valor para subir porcentaje";
            }
            else if (porcentajeASubir < 10)
            {
                message = "Porcentaje a subir menor que el recomendado";
            }
            var value = this.Costo + (this.Costo * porcentajeASubir / 100);

            var operationResult = new ResultadoDeOperacion(value, message);
            return operationResult;
        }*/
        
    }
}
