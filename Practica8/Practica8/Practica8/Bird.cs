using System;

namespace Practica8 {
    public class Bird : Mascotas {
        public Bird() : base(2) { }

        public override void eat() {
            Console.WriteLine("El pájaro está comiendo.");
        }

    }
}