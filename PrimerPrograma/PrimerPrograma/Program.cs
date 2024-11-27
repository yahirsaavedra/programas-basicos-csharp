using System;
using System.Threading;

namespace PrimerPrograma
{
    class Program
    {
        static void Main(string[] args)
        {
            Clase clase = new Clase();
            Console.WriteLine("Nombre: " + clase.nombre);
            Console.WriteLine("Edad: " + clase.edad);
            Console.WriteLine("Carrera: " + clase.carrera);
            Console.WriteLine("Teléfono: " + clase.telefono);
            clase.cantar();
            clase.bailar();
            Console.WriteLine("YAHIR ALEJANDRO SAAVEDRA GALLARDO, 21490577");
            Console.ReadKey();
        }
    }
}
