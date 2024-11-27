using System;

namespace Practica8
{
    public class Dog : Mascotas, Info
    {

        private string name;

        public Dog(string n) : base(4) {
            this.name = n;
        }
        public string getName() {
            return name;
        }
        public void setName(string n) {
           this.name = n;
        }

        public void play() {
            Console.WriteLine("El perro " + name + " está jugando.");
        }

        public override void eat() {
            Console.WriteLine("El perro " + name + " está comiendo.");
        }

        public void walk()
        {
            Console.WriteLine(name + " tiene " + legs + " patas.");
        }
    }
}