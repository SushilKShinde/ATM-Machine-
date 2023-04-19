using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double availableBalance = 40000;
            Console.WriteLine("***** WELCOME TO THE BANK OF BRIDGELABZ ATM *****\n");
            Console.WriteLine("Choose the option from the below:\n ");
            Console.WriteLine(" 1. Balance Enquiry\n 2. Cash Withdrawal\n 3. Cash Deposite\n 4. Green Pin Generation\n 5. Exit");
            int option = Convert.ToInt32(Console.ReadLine());   

            switch (option)
            {
                case 1:
                    Console.WriteLine("Your available balance is: {0}\n", availableBalance);
                    break;
                case 2:
                    Console.WriteLine("Enter the amount you want to withdraw");
                    double withdrawalAmount = Convert.ToDouble(Console.ReadLine());
                    availableBalance = availableBalance - withdrawalAmount;
                    Console.WriteLine("Your available balance is: {0}\n", availableBalance);
                    break;
                case 3:
                    Console.WriteLine("Enter the amount you want to deposite");
                    double depositeAmount = Convert.ToDouble(Console.ReadLine());
                    availableBalance = availableBalance + depositeAmount;
                    Console.WriteLine("Your available balance is: {0}\n", availableBalance);
                    break;
                case 4:
                    Random random = new Random();
                    int pin = random.Next(1000, 9999);
                    Console.WriteLine("Your green pin is: {0}\n", pin);
                    break;
                default:
                    Console.WriteLine("Please choose the valid option from the above options.");
                    break;
            }
            Console.WriteLine("***** THANK YOU FOR USING OUR ATM SERVICE ***** \n         ***** DO VISIT AGAIN ***** ");
        }
    }
}
