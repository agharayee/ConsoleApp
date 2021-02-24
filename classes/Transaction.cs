using System;

namespace SimpleAtmApp.classes
{
    public class Transaction
    {
        decimal openingBalance { get; set; } = 5000;
        public void Display()
        {
            Console.WriteLine("Welcome to Simple bank Atm");
            System.Console.WriteLine($"Press 1 to withdraw");
            System.Console.WriteLine($"Press 2 to Deposit");
            System.Console.WriteLine($"Press 3 to check balance");
            System.Console.WriteLine($"Press 4 to remove your card");
            //System.Console.WriteLine($"Thanks for using Simple Bank Atm");
        }
        public void Withdraw(decimal openingBalance, int input)
        {
            if (input == 1)
            {
                System.Console.WriteLine($"Please enter the amount you want to withdraw");
                    var amountToWithdraw = int.Parse(Console.ReadLine());
                    while (amountToWithdraw > openingBalance)
                    {
                        try
                        {
                            System.Console.WriteLine($"Insufficent fund please try again");
                            System.Console.WriteLine($"Please enter the amount you want to withdraw");
                            amountToWithdraw = int.Parse(Console.ReadLine());
                        }
                        catch (Exception ex)
                        {
                            System.Console.WriteLine($"{ex.Message}");
                        }

                    }
                    System.Console.WriteLine("Please take your cash");
                    openingBalance -= amountToWithdraw;
                    System.Console.WriteLine($"Your balance is {openingBalance}");
            }
            // 
            // 

            // if (exit == 1)
            // {
            //     continue;
            // }
            // if (exit == 2)
            // {
            //     System.Console.WriteLine("Thanks for using Simple bank ATM");
            //     break;
            // }
        }

        public void Deposit(decimal openingBalance, int input)
        {
            if (input == 2)
            {
                System.Console.WriteLine($"How much do you want to deposit into your account?");
                try
                {
                    var deposit = decimal.Parse(Console.ReadLine());
                    openingBalance += deposit;
                }
                catch (Exception ex)
                {
                    System.Console.WriteLine($"{ex.Message}");
                }
                System.Console.WriteLine($"Your new balance is {openingBalance}");
            }

        }

        public void CheckBalance(decimal openingBalance, int input)
        {
            if (input == 3)
            {
                System.Console.WriteLine($"Your Account balance is {openingBalance}");
            }
        }
        public void Exit(int input)
        {
            Environment.Exit(-1);
        }

    }
}
