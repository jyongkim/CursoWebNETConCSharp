using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseEstatica
{
    // Se crea una clase Static para que no pueda ser instanciada.
    public static class UtilidadesDeFechas
    {
        // Al tener una clase Static no podemos crear métodos y funciones que no sean estáticos.
        public static int CalcularEdad(DateTime fechaNacimiento)
        {
            var edad = DateTime.Today.Year - fechaNacimiento.Year;
            var temp = new DateTime(DateTime.Today.Year, fechaNacimiento.Month, fechaNacimiento.Day);

            if (temp > DateTime.Today)
            {
                edad++;
            }

            return edad;
        }
    }
}
