using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClaseEstatica
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instanciamos la clase Persona.
            var persona = new Persona();
            // Le pasamos la fecha al parámetro.
            persona.fechaNaacimiento = Convert.ToDateTime("27/01/1997");
            // Mostramos la fecha calcuada.
            Console.WriteLine(persona.Edad);
            Console.ReadLine();
        }
    }
}
