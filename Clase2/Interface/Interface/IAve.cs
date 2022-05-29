using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    // Las interfaces se crean de la siguiente manera: public interface IAve, usando la primera letra una "I" para no prestar confusión del resto de las clases.
    public interface IAve
    {
        // Creamos dos métodos que se tienen que cumplir en la clase heredada.
        void Volar();
        void Comer();
    }
}
