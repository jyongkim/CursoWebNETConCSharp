using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    // Heredamos la clase AvePropiedades.
    internal class Ave : AvePropiedades
    {
        // La herencia nos obliga a crear un constructor, usando base (Es la forma de pasarle un valor al parámetro heredado) con los mismos atributos que tiene el constructor heredado, pudiendo agregar más parámetros en el constructor de la clase hija.

        public Ave(string Nombre) : base(Nombre)
        {

        }
    }
}
