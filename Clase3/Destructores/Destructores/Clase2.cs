using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destructores
{
    class Clase2
    {
        ~Clase2()
        {
            System.Diagnostics.Trace.WriteLine("El destructor de la Clase 2 es llamado.");
        }
    }
}
