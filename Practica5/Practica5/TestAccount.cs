using System;

namespace Practica5
{
    internal class TestAccount
    {
        static void Main(string[] args)
        {
            Account cajero = new Account(50.0);
            Console.WriteLine("Tu saldo inicial es de $" + cajero.getBalance());
            Console.ReadKey();
            cajero.deposit(100.0);
            Console.ReadKey();
            cajero.withdraw(147.0);
            Console.ReadKey();
            Console.WriteLine("Tu saldo final es de $" + cajero.getBalance());
            Console.ReadKey();
        }
    }
}
