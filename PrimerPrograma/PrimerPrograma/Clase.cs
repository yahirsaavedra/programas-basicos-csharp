using System;

namespace PrimerPrograma
{
    public class Clase
    {
        public string nombre = "Juan";
        public string carrera = "Sistemas";
        public int edad = 19;
        public long telefono = 6861234567;

        public void cantar()
        {
            Console.WriteLine(nombre + " canta muy bonito");
        }

        public void bailar()
        {
            Console.WriteLine(nombre + " baila reguetón");
        }
    }
}