using System;

namespace Practica8
{
    public class Snake : Mascotas
    {
        private string name;

        public Snake() : base(0) { }
        public string getName() {
            return name;
        }
        public void setName(string n)  {
            this.name = n;
        }
        public void play() {
            Console.WriteLine("La serpiente " + name + " está jugando.");
        }

        public void walk() {
            base.walk();
            Console.WriteLine("Las serpientes no caminan.");
        }

        public override void eat() {
            Console.WriteLine("La serpiente " + name + " está comiendo.");
        }
    }
}