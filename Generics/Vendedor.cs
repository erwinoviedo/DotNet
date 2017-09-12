using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Vendedor
    {
        public int VendorId { get; set; }
        public string CompanyName { get; set; }
        public string Email { get; set; }

        public ResultadoDeOperacion RegistrarOrden(Producto producto, int cantidad,
                                            DateTimeOffset? fechaEntrega = null,
                                            string instrucciones = "standard delivery")
        {
            //Codigo
            #region Validar parametros
            if (producto == null)
                throw new ArgumentNullException(nameof(producto));
            if (cantidad <= 0)
                throw new ArgumentOutOfRangeException(nameof(cantidad));
            if (fechaEntrega <= DateTimeOffset.Now)
                throw new ArgumentOutOfRangeException(nameof(fechaEntrega));
            #endregion
            var success = false;

            var orderTextBuilder = new StringBuilder("Order from Acme, Inc" +
                            System.Environment.NewLine +
                            "Product: " + producto.ProductName +
                            System.Environment.NewLine +
                            "Quantity: " + cantidad);
            if (fechaEntrega.HasValue)
            {
                orderTextBuilder.Append(System.Environment.NewLine +
                            "Deliver By: " + fechaEntrega.Value.ToString("d"));
            }
            if (!String.IsNullOrWhiteSpace(instrucciones))
            {
                orderTextBuilder.Append(System.Environment.NewLine +
                            "Instructions: " + instrucciones);
            }
            var orderText = orderTextBuilder.ToString();

            var emailService = new EmailService();
            var confirmation = emailService.SendMessage("Nueva Orden", orderText,
                                                                     this.Email);
            if (confirmation.StartsWith("Mensaje enviado:"))
            {
                success = true;
            }

            var resultado = new ResultadoDeOperacion(true, orderText);
            return resultado;
        }
    }
}
