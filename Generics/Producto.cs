using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    /// <summary>
    /// Manages products carried in inventory.
    /// </summary>
    public class Producto
    {
        #region Constructors
        public Producto()
        {
            var colorOptions = new List<string>()
                                  { "Red", "Espresso", "White", "Navy" };

            Console.WriteLine(colorOptions);

        }

        public Producto(int productId,
                        string productName,
                        string description) : this()
        {
            this.ProductId = productId;
            this.ProductName = productName;
            this.Description = description;
        }
        #endregion

        #region Properties
        public DateTime? AvailabilityDate { get; set; }

        public decimal Cost { get; set; }

        public string Description { get; set; }

        public int ProductId { get; set; }

        private string productName;
        public string ProductName { get; set; }
        
        public Vendedor ProductVendor { get; set; }       

        public string ValidationMessage { get; private set; }

        #endregion

        /// <summary>
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
            var value = this.Cost + (this.Cost * porcentajeASubir / 100);

            var operationResult = new ResultadoDeOperacion(value, message);
            return operationResult;
        }

        public override string ToString()
        {
            return this.ProductName + " (" + this.ProductId + ")";
        }
    }
}
