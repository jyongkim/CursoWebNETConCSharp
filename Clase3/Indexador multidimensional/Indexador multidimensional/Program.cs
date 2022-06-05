using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexador_multidimensional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instanciamos la clase indexador múltiple.
            var index = new IndexadorMultiple();


            // Primera fila.
            index[0, 0] = 1;
            index[0, 1] = 2;
            index[0, 2] = 3;

            // Segunda fila.
            index[1, 0] = 4;
            index[1, 1] = 5;
            index[1, 2] = 6;

            // Tercera fila.
            index[2, 0] = 7;
            index[2, 1] = 8;
            index[2, 2] = 9;

            // Mostramos los valores con \t se tabula y con \n hacemos un salto de línea, el método WriteLine() tiene una sobrecarga;
            // donde nos deja llenar un dato con una variable se pone entre {} y se le asigna adentro la posicion de la variable.
            Console.WriteLine("{0}\t{1}\t{2}\n{3}\t{4}\t{5}\n{6}\t{7}\t{8}",
                                                index[0, 0], index[0, 1], index[0, 2],
                                                index[1, 0], index[1, 1], index[1, 2],
                                                index[2, 0], index[2, 1], index[2, 2]);

            Console.ReadLine();
        }
    }
}
