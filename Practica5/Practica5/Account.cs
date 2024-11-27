using System;

namespace Practica5
{
    public class Account
    {
        private double balance;

        public Account(double initBalance)
        {
            balance = initBalance;
        }

        public double getBalance()
        {
            return balance;
        }

        public void deposit(double atm)
        {
            balance += atm;
            Console.WriteLine("Se han depositado $" + atm);
        }

        public void withdraw(double atm)
        {
            balance -= atm;
            Console.WriteLine("Se han retirado $" + atm);
        }
    }
}