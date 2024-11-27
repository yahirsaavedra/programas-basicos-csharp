using System;

namespace Practica7
{
    public class Triangulo : Figuras
    {
        private int anchura, altura;
        public Triangulo(int b, int h) {
            this.anchura = b;
            this.altura = h;
        }

        public override void Area() {
            double area = anchura * altura / 2;
            Console.WriteLine("El área del triángulo es de " + area);
        }

        public override void Dibujar() {
            for (int i = 0; i <= altura; i++)
            {
                for (int k = 0; k <= (altura - i); k++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j <= i - 1; j++)
                {
                    Console.Write("* ");
                }
                Console.Write("\n");
            }
        }
    }
}