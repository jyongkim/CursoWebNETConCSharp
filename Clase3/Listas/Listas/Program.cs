using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Lista con parametros.

            var listaParametros = new List<Personas>();

            listaParametros.Add(new Personas { Nombre = "Marcio", Edad = 25, EmpleadoDelMes = "Sí" });

            foreach (var x in listaParametros)
            {
                Console.WriteLine(x.Edad);
                Console.WriteLine(x.Nombre);
                Console.WriteLine(x.EmpleadoDelMes);
            }
            Console.WriteLine("-------------------TERMINA LA LISTA CON PARAMETROS-------------------");
            #endregion

            #region Lista simple.

            // Instanciamos la lista.
            var persona = new List<string>();

            // Agregamos elementos a la lista.
            persona.Add("Pepe");
            persona.Add("Alejandro");
            persona.Add("Marcio");
            persona.Add("Luján");


            // Recorremos la lista con un "for".
            for (int i = 0; i < persona.Count; i++)
            {
                // Mostramos en pantalla a la persona de la posicion [i].
                Console.WriteLine(persona[i]);
            }

            // Recorremos la lista con un "foreach" (es mejor que con el for ya que ahorramos código).
            foreach (var x in persona)
            {
                Console.WriteLine(x);
            }

            #endregion

            Console.ReadLine();
        }
    }
}
