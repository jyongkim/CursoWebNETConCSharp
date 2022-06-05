using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexador_unidimensional
{
    internal class Indexador
    {
        private string[] val = new string[4];

        // Declaración del indexador.
        public string this[int index]
        {
            get
            {
                // Retonamos el array con la posición que le asignamos.
                return val[index];
            }

            set
            {
                // Tomamos la posición del index y guardamos en la variable array el valor que le asignamos.
                val[index] = value;
            }
        }
    }
}
