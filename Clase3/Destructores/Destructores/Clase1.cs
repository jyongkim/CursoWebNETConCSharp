using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destructores
{
    class Clase1
    {
        ~Clase1()
        {
            System.Diagnostics.Trace.WriteLine("El destructor de la Clase 1 es llamado.");
        }
    }
}
