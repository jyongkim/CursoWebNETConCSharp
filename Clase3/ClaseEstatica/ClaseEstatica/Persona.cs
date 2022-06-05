using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseEstatica
{
    public class Persona
    {
        // Creamos propiedades.
        public string Nombre { get; set; } 
        public DateTime fechaNaacimiento { get; set; } 
        public int Edad {
            get
            {
                // Retornamos el valor de CalcularEdad.
                return UtilidadesDeFechas.CalcularEdad(fechaNaacimiento);
            }
                } 
    }
}
