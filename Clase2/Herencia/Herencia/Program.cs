using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instanciamos la clase Hijo. Dentro de ésta vamos a poder utilizar las funciones y metodos de la clase Padre ya que Hijo hereda de Padre.
            Hijo hijo = new Hijo();
            string nombre = hijo.MiNombre("pepito");

            // CalcularEdad; ésta heredada de la clase Padre.
            int edad = hijo.CalcularEdad(Convert.ToDateTime("27/01/1997"));
            Console.WriteLine("Mi nombre es {0} y mi edad es {1}", nombre, edad);
            Console.ReadKey();
        }
    }
}
