using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket_Price_Calculator
{
    internal class TicketPriceCalculator
    {
        static void Main(string[] args)
        {
            bool runAgain = true;
            while (runAgain)
            {
                byte userAge = 0;
                bool validInput = false;
                while (!validInput)
                {
                    try
                    {
                        Console.Write("Please enter your age. Whole Numbers only. ");
                        string userResponse = Console.ReadLine();
                        userAge = Convert.ToByte(userResponse);
                        if (userAge > 255)
                        {
                            continue;
                        }
                        else
                        {
                            validInput = true;
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Invalid Input. Please enter a numerical value representing age. Example 18,27,etc.");
                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine("The value you entered is too large to be an age. Please enter a value between 0 and 255. ");
                    }
                }

                if (userAge >= 65 || userAge <= 12)
                    Console.WriteLine("Ticket price: GHC 7");
                else
                    Console.WriteLine("Ticket price: GHC 10");

                Console.Write("Do you want to enter another age. ");
                string choice = Console.ReadLine();
                if (choice.ToLower() != "y")
                {
                    Console.Write("Exiting Application....");
                    runAgain = false;
                }
            }
        }
    }
}
