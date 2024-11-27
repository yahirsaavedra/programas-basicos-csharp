using System;

namespace Practica7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int temp1, temp2;
            Triangulo t;
            Rectangulo r;
            Console.WriteLine("Ingresa los datos para el triángulo.");
            Console.WriteLine("Base: ");
            temp1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Altura: ");
            temp2 = int.Parse(Console.ReadLine());
            t = new Triangulo(temp1, temp2);
            t.Area();
            t.Dibujar();
            Console.WriteLine("\nIngresa los datos para el rectángulo.");
            Console.WriteLine("Base: ");
            temp1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Altura: ");
            temp2 = int.Parse(Console.ReadLine());
            r = new Rectangulo(temp1, temp2);
            r.Area();
            r.Dibujar();
            Console.ReadKey();
        }
    }
}
