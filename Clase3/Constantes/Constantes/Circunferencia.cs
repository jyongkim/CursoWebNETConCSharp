using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constantes
{
    class Circunferencia
    {
        // Constructor estático.
        static Circunferencia()
        {
            Descripcion = "Probando";
            Descripcion = "Asdf";
        }

        // Constructor sobrecargado no-estático.
        public Circunferencia(double radio)
        {
            this.Radio = radio;
            this.Perimetro = 2 * PI * this.Radio;
            this.Area = PI * Math.Pow(this.Radio, 2);
        }

        // Campos similares a los parámetros.
        public double Radio;
        public double Perimetro;
        public double Area;

        // A una constante nunca se le puede cambiar el valor que se le asigna.
        public const double PI = 3.1415926;

        // Una variable readonly puede ser modificada mientras el constructor de la clase no termine de ser ejecutado.
        public static readonly string Descripcion;
    }
}
