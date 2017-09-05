using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomClasses
{
    public class Empleado : Persona
    {
        public double Salario { get;  set; }
        public Empleado()
        {
           
        }

        public void IncrementarSalario(double porcentaje)
        {
            this.Salario = this.Salario * porcentaje / 100;
        }
    }
}
