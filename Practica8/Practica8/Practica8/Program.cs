using System;

namespace Practica8 {
    internal class Program {
        public static void Main(string[] args) {
            Bird pajaro = new Bird();
            Dog perro = new Dog("Firulais");
            Snake serpiente = new Snake();

            Console.WriteLine("\nMETODOS CLASE BIRD");
            pajaro.walk();
            pajaro.eat();

            Console.WriteLine("\nMETODOS CLASE DOG");
            perro.walk();
            perro.setName("Perrito");
            Console.WriteLine("El perro ahora se llama " + perro.getName());
            perro.play();
            perro.eat();

            Console.WriteLine("\nMETODOS CLASE SNAKE");
            serpiente.walk();
            serpiente.setName("Juan");
            Console.WriteLine("La serpiente ahora se llama " + serpiente.getName());
            serpiente.play();
            serpiente.eat();

            Console.ReadKey();
        }
    }
}
