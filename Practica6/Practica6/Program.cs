using System;

namespace Practica6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona("Pablo", 2500);
            Trabajador trabajador = new Trabajador("Juan", 3000);

            Console.WriteLine("Datos de la persona:");
            Console.WriteLine(persona.Imprimir());
            Console.WriteLine("Datos del trabajador:");
            Console.WriteLine(trabajador.Imprimir());
            Console.ReadKey();

        }
    }
}
