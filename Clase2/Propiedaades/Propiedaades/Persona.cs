using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propiedades
{
    public class Persona
    {
        private string _nombre;
        private DateTime _fechaNacimiento;
        private int _edad;


        //Propiedades
        public int Edad
        {
            get //Encapsulamiento de tipo abierto, por defecto es público dado que la propiedad que tenemos es pública.
            {
                return _edad;
            }
            private set //Ecanpsulamiento de tipo cerrado, Privado.
            {
                _edad = value;
            }
        }

        public string Nombre
        {
            get
            {
                return _nombre;
            }
            set
            {
                _nombre = value;
            }
        }

        public DateTime FechaNacimiento
        {
            get
            {
                return _fechaNacimiento;
            }
            set
            {
                _fechaNacimiento = value;
            }
        }

        // Método público; queremos que se acceda a él desde otras clases.
        public void registrar()
        {
            Console.WriteLine(Nombre + " ha sido registrado correctamente.");
        }

        // Método privado; no queremos que se acceda a él desde otras clases. Sólo desde la clase Persona.
        private void CalcularEdad(DateTime fechaNacimientoPersona)
        {
            DateTime fechaActual = DateTime.Now;
            Edad = fechaActual.Year - fechaNacimientoPersona.Year;
        }

    }

 }
