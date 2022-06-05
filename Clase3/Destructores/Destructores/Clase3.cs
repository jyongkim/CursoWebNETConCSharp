using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destructores
{
    class Clase3
    {
       ~Clase3()
        {
            System.Diagnostics.Trace.WriteLine("El destructor de la Clase 3 es llamado.");
        }
    }
}
