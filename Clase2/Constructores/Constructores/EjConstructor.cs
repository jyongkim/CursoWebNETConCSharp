using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructores
{
    internal class EjConstructor
    {
        int a;
        int b;
        int c;

        public EjConstructor()
        {

        }

        public EjConstructor(int x, int y)
        {
            a = x;
            b = y; 
        }

        public EjConstructor(int x, int y, int d)
        {
            a = x;
            b = y;
            c = d;
        }

        public int Suma()
        {
            return a + b;
        }

        public int Resta()
        {
            return a - b;
        }

    }
}
