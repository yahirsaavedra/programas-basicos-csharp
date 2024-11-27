using System;

namespace Practica7
{
    public class Rectangulo : Figuras
    {
        private int anchura, altura;

        public Rectangulo(int b, int h) {
            this.anchura = b;
            this.altura = h;
        }

        public override void Area() {
            double area = anchura * altura;
            Console.WriteLine("El área del rectángulo es de " + area);
        }

        public override void Dibujar() {
            for (int i = 0; i <= altura; i++)
            {
                for (int j = 0; j <= anchura; j++)
                {
                    if ((i == 0) || (i == altura))
                        Console.Write("* ");
                    else {
                        if ((j == 0) || (j == anchura))
                            Console.Write("* ");
                        else Console.Write("  ");
                    }
                }
                Console.Write("\n");
            }
        }
    }
}