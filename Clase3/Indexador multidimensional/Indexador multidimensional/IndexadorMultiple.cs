using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexador_multidimensional
{
    internal class IndexadorMultiple
    {
        // Instanciamos una matriz de tipo int con más de una columna.
        int[,] array = new int[5, 5];


        // Parámetro donde le pasamos la posición del array.
        public int this[int index0, int index1]
        {
            get
            {
                // Retornamos la variable "array" en la posición index.
                return array[index0, index1];
            }

            set
            {
                // Guardamos el valor del "array" en la posición index.
                array[index0, index1] = value;
            }
        }
    }
}
