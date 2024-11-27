using System;

namespace Practica6
{
    public class Trabajador : Persona
    {
        protected string puesto;

        public Trabajador(string nombre, double sueldo)
        { //: base(nombre,salario)
            this.nombre = nombre;
            this.sueldo = sueldo;
        }

        public Trabajador(string fechaNacimiento, string puesto)
        {
            this.fechaNacimiento = fechaNacimiento;
            this.puesto = puesto;
        }
    }
}