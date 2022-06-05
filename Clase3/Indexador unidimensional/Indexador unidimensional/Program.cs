using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexador_unidimensional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creamos un objeto de la clase Indexador.
            var io = new Indexador();

            // Guardamos en los objetos un array de tipo string.
            io[0] = "Hola";
            io[1] = "soy";
            io[2] = "Indexador.";
            io[3] = "Prueba.";

            Console.Write("Mostramos los valores almacenados en el objeto utilizando un array:\n");

            // Mostramos el array.
            Console.WriteLine(" value = {0}", io[0]);
            Console.WriteLine(" value = {0}", io[1]);
            Console.WriteLine(" value = {0}", io[2]);

            Console.ReadLine();
        }
    }
}
