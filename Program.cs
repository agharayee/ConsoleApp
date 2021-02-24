using System;
using SimpleAtmApp.classes;

namespace SimpleAtmApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var Transaction = new Transaction();
            decimal openingBalance = 5000;
            while (true)
            {
                Transaction.Display();
                
                var input = int.Parse(Console.ReadLine());
                //if console.readline is deposit run this method
                Transaction.Withdraw(openingBalance, input);
                
                //else if it is withdrawal run this methof
                Transaction.Deposit(openingBalance, input);

                //else if it is check balance run check balance method
                Transaction.CheckBalance(openingBalance, input);

                //else if it quit, quit the running console
                Transaction.Exit(input);
               
            }
        }
    }
}
