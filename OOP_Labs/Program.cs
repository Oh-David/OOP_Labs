using System;

namespace OOP_Labs
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BankAccount bankAccount = new BankAccount();
            bankAccount.Id = 10;
            bankAccount.Balance = 150;

            Console.WriteLine($"Account {bankAccount.Id}, balance {bankAccount.Balance}");
        }
    }
}