using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    // Heredamos la interface en avePropiedades obligándola a que tenga que crear los métodos de la interface.
    public class AvePropiedades : IAve
    {
        // Creamos 3 variables.
        public int Patas = 2;
        public int Alas = 2;
        public int Cola = 1;

        // Creamos un parámetro llamado Nombre;
        public string Nombre { get; private set; }

        // Creamos el constructor con el atributo Nombre.
        public AvePropiedades(string Nombre)
        {
            // En caso de que el atributo se llame igual a la variable o propiedad podemos diferenciarlo con la palabra "this" seguido de un punto this.Nombre.
            this.Nombre = Nombre;
        }

        // Creamos el método Volar().
        public void Volar()
        {
            Console.WriteLine("Volar");
        }

        // Creamos el metodo Comer().
        public void Comer()
        {
            Console.WriteLine("Comer");
        }
    }
}
