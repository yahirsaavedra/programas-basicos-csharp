using System;

namespace Practica8
{
    public abstract class Mascotas
    {
        protected int legs;

        protected Mascotas(int legs) {
            this.legs = legs;
        }

        public void walk() {
            Console.WriteLine("La mascota tiene " + legs + " patas.");
        }

        public abstract void eat();
    }
}