using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeraciones
{
    internal class Program
    {
        // Creamos el enum. Al no tener un valor definido, tomará desde el 0.
        enum Switch { Apagado, Encendido}

        // Creamos el enum Color. Definimos la llave y el vvalor que tendrá.
        enum Color
        {
            Verde = 0,
            Rojo = 1,
            Azul = 2,
            Negro = 3,
            Blanco = Rojo | Verde | Azul
            
        }

        static void Main(string[] args)
        {
            // Almacenamos en la variable "c" de tipo Color el enum Negro.
            Color c = Color.Negro;
            Console.WriteLine((int)c); // Casteamos (int) el enum y nos muestra su value 0.
            Console.WriteLine(c.ToString()); // Mostramos su clave/llave/key usando ToString() (Negro).
            Console.WriteLine(c); // Mostramos su clave/llave/key (Negro).
            Console.ReadLine();

            Color x = Color.Blanco;
            Console.WriteLine((int)x); // 3.
            Console.WriteLine(x.ToString()); // Blanco.
            Console.ReadLine();

            Switch y = Switch.Encendido;
            Console.WriteLine((int)y); // 1
            Console.WriteLine(y.ToString()); // Encendido.
            Console.ReadLine();
        }
    }
}
