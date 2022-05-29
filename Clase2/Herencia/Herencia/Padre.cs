using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    internal class Padre
    {
        // Creamos una función CalcularEdad para utilizarla desde la clase Hijo.
        public virtual int CalcularEdad(DateTime fechaNacimiento)
        {
            DateTime fechaActual = DateTime.Now;
            return fechaActual.Year - fechaNacimiento.Year;

        }
    }
}
