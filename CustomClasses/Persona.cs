using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomClasses
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
        public DateTime FechaNacimiento { get; set; }
        #endregion

        #region Metodos
        public Persona(int id)
        {
            //Constructor
            this.Id = id;
        }
        public Persona()
        {

        }
        public int ObtenerEdadEnAños()
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
