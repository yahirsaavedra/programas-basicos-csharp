using System;

namespace Practica6
{
    public class Persona
    {
        protected string nombre;
        protected double sueldo;
        protected string fechaNacimiento;

        public Persona(string nombre, double sueldo)
        {
            this.nombre = nombre;
            this.sueldo = sueldo;
        }

        public Persona() {
        }

        public String Imprimir() {
            return "NOMBRE  : " + nombre + "\n" + "SUELDO : " + sueldo;
        }
    }

}