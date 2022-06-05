using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propiedades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona alumno = new Persona();
            alumno.Nombre = "Marcio";
            alumno.FechaNacimiento = Convert.ToDateTime("27/01/1997");
            alumno.Registrar();
            alumno.CalcularEdad();
            Console.WriteLine("La edad del alumno {0}", alumno.Nombre);
            Console.ReadLine();
        }
    }
}
