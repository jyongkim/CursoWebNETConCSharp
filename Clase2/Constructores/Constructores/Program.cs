using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creamaos un objeto de la clase EjConstructor y le pasamos los parámetros al Constructor
            EjConstructor obj = new EjConstructor(10, 20);

            Console.WriteLine("La suma es: " + obj.Suma());
            Console.WriteLine("La resta es: " + obj.Resta());
            Console.ReadKey();
        }
    }
}
