using System;

namespace Grade_Calculator
{
    internal class GradeCalculator
    {
        static void Main(string[] args)
        {
            bool runAgain = true;
            while (runAgain)
            {
                byte grade = 0;
                bool validInput = false;
                while (!validInput)
                {
                    Console.Write("Enter a numerical grade (0-100): ");
                    string userResponse = Console.ReadLine();
                    try
                    {
                        grade = Convert.ToByte(userResponse);

                        if (grade > 100)
                        {
                            Console.WriteLine("Grade must be between 0 and 100. Please try again.");
                        }
                        else
                        {
                            validInput = true;
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Invalid input. Please enter a numeric value (0-100).");
                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine("The number you entered is out of range. Please enter a number between 0 and 100.");
                    }
                }

                if (grade >= 90)
                    Console.WriteLine("Grade: A");
                else if (grade >= 80)
                    Console.WriteLine("Grade: B");
                else if (grade >= 70)
                    Console.WriteLine("Grade: C");
                else if (grade >= 60)
                    Console.WriteLine("Grade: D");
                else
                    Console.WriteLine("Grade: F");

                Console.Write("\nWould you like to enter another grade? (y/n): ");
                string choice = Console.ReadLine();

                if (choice.ToLower() != "y")
                {
                    runAgain = false;
                    Console.WriteLine("Exiting Application......");
                }

                Console.WriteLine();
            }
        }
    }
}
