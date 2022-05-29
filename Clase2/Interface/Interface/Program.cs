using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instanciamos dos clases del tipo Ave pasando como parametro el nombre del ave.
            Ave canario = new Ave("Canario");
            Ave cuervo = new Ave("Cuervo");
            // Creamos una instancia de nuestra clase principal (Program) para llamar al método Imprimir().
            Program main = new Program();
            // Le pasamos al método Imprimir por atributo el objeto Canario.
            main.Imprimir(canario);
            // Le pasamos al método Imprimir por atributo el objeto Cuervo.
            main.Imprimir(cuervo);
            Console.ReadLine();
        }

        public void Imprimir(Ave ave)
        {
            // Mostramos, en la consola, los datos del ave que son llamados de la clase padre de ave.
            Console.WriteLine("Soy un {0} tengo {1} patas, {2} alas y {3} cola", ave.Nombre, ave.Patas, ave.Alas, ave.Cola);
            Console.WriteLine("Puedo ");
            // Usamos el método Comer() de la clase padre de Ave.
            ave.Comer();
            Console.WriteLine("y tambien puedo ");
            // Usamos el método Volar() de la clase padre de Ave.
            ave.Volar();
        }
    }
}
