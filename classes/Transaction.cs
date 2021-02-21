using System;

namespace SimpleAtmApp.classes
{
    public class Transaction
    {
        decimal openingBalance {get; set;} = 5000;
        public void Display()
        {

        }
        public void Withdraw(){
                {
                    System.Console.WriteLine($"Please enter the amount you want to withdraw");
                    var amountToWithdraw = decimal.Parse(Console.ReadLine());
                    while (amountToWithdraw > openingBalance)
                    {
                        System.Console.WriteLine($"Insufficent fund please try again");
                        System.Console.WriteLine($"Please enter the amount you want to withdraw");
                        amountToWithdraw = decimal.Parse(Console.ReadLine());
                    }
                    System.Console.WriteLine("Please take your cash");
                    openingBalance -= amountToWithdraw;
                    System.Console.WriteLine($"Your balance is {openingBalance}");
                    // Console.WriteLine("Do you want to perform another task? Press 1 for YES and 2 for No");
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
                
        }
    }
}