using System;

namespace SimpleAtmApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var openingBalance = 5000;
            var flag = false;
            while (flag != true)
            {
                Console.WriteLine("Welcome to Simple bank Atm");
                System.Console.WriteLine($"Press 1 to withdraw");
                System.Console.WriteLine($"Press 2 to Deposit");
                System.Console.WriteLine($"Press 3 to check balance");
                System.Console.WriteLine($"Press 4 to remove your card");
                //System.Console.WriteLine($"Thanks for using Simple Bank Atm");

                var input = int.Parse(Console.ReadLine());
                if (input > 4 && input < 1)
                {
                    System.Console.WriteLine($"Please Enter a valid operation");
                    Console.WriteLine("Welcome to Simple bank Atm");
                    System.Console.WriteLine($"Press 1 to withdraw");
                    System.Console.WriteLine($"Press 2 to Deposit");
                    System.Console.WriteLine($"Press 3 to check balance");
                    System.Console.WriteLine($"Press 4 to remove your card");
                }
                else if (input == 1)
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
                    Console.WriteLine("Do you want to perform another task? Press 1 for YES and 2 for No");
                    var exit = int.Parse(Console.ReadLine());

                    if (exit >= 2 && exit < 0)
                    {
                        if (exit == 1)
                        {
                            continue;
                        }
                        if (exit == 2)
                        {
                            System.Console.WriteLine("Thanks for using Simple bank ATM");
                            break;
                        }
                    }
                }
                else if (input == 2)
                {
                    System.Console.WriteLine($"How much do you want to deposit into your account?");
                    try{
                        var deposit = int.Parse(Console.ReadLine());
                        openingBalance += deposit;
                    }
                    catch(Exception ex){
                        System.Console.WriteLine($"{ex.Message}");
                    } 
                    System.Console.WriteLine($"Your new balance is {openingBalance}");
                    Console.WriteLine("Do you want to perform another task? Press 1 for YES and 2 for No");
                    var exit = int.Parse(Console.ReadLine());
                    if (exit >= 2 && exit < 0)
                    {
                        if (exit == 1)
                        {
                            continue;
                        }
                        if (exit == 2)
                        {
                            System.Console.WriteLine("Thanks for using Simple bank ATM");
                            break;
                        }
                    }
                }
                else if (input == 3)
                {
                    System.Console.WriteLine($"Your Account balance is {openingBalance}");
                    Console.WriteLine("Do you want to perform another task? Press 1 for YES and 2 for No");
                    var exit = int.Parse(Console.ReadLine());
                   if (exit >= 2 && exit < 0)
                    {
                        if (exit == 1)
                        {
                            continue;
                        }
                        if (exit == 2)
                        {
                            System.Console.WriteLine("Thanks for using Simple bank ATM");
                            break;
                        }
                    }
                }

                else if (input == 4)
                {
                    Environment.Exit(-1);

                }
            }

        }
    }
}
