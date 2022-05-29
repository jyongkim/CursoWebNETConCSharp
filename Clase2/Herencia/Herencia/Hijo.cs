using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    // Heredando (:) los metodos y las funciones de la clase Padre a la clase Hijo.
    class Hijo : Padre
    {
        // Creamos una función para retornar el nombre.
        public string MiNombre(string nombre)
        {
            return nombre;
        }
    }
}
