using System;
using System.Linq;

namespace Triangle_Type_Identifier
{
    internal class TriangleTypeIdentifier
    {
        static void Main(string[] args)
        {
            bool runAgain = true;
            while (runAgain)
            {
                float side1 = 0;
                float side2 = 0;
                float side3 = 0;
                string resp1 = "";
                string resp2 = "";
                string resp3 = "";
                bool validInput = false;
                while (!validInput)
                {
                    try
                    {
                        Console.Write("Enter the length of the first side: ");
                        resp1 = Console.ReadLine();
                        side1 = float.Parse(resp1);

                        Console.Write("Enter the length of the second side: ");
                        resp2 = Console.ReadLine();
                        side2 = float.Parse(resp2);

                        Console.Write("Enter the length of the third side: ");
                        resp3 = Console.ReadLine();
                        side3 = float.Parse(resp3);

                        validInput = true;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Please enter a numerical value, e.g 12, 15.5 etc");
                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine("The value you entered is too high.");
                    }
                }
                float[] sides = { side1, side2, side3 };
                byte numUnique = Convert.ToByte(sides.Distinct().Count());

                switch (numUnique)
                {
                    case 1:
                        Console.WriteLine("The triangle is Equilateral");
                        break;
                    case 2:
                        Console.WriteLine("The triangle is Isosceles");
                        break;
                    case 3:
                        Console.WriteLine("The triangle is Scalene");
                        break;
                    default:
                        Console.WriteLine("Invalid triangle.");
                        break;
                }
                Console.Write("Would you like to enter another triangle? (y/n): ");
                string choice = Console.ReadLine();

                if (choice.ToLower() != "y")
                {
                    runAgain = false;
                    Console.WriteLine("Exiting Application.....");
                }

            }
        }
    }
}
