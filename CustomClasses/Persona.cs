using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Persona
    {
        #region fields
        private string direccion;
        #endregion

        #region Propiedades
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public DateTime FechaNacimiento { get; set; }
        #endregion

        #region Metodos
        public Persona()
        {
            //Constructor
        }
       
        private int ObtenerEdadEnAños(DateTime fecha)
        {
            // Save today's date.
            var today = DateTime.Today;
            // Calculate the age.
            var age = today.Year - FechaNacimiento.Year;
            // Go back to the year the person was born in case of a leap year
            if (FechaNacimiento > today.AddYears(-age))
                age--;

            return age;
        }
        #endregion
    }
}
