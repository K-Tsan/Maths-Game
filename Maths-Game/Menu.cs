using System;

namespace Maths_Game
{
    public class Menu
    {
        public int runMenu()
        {
            Console.Clear();
            do
            {
                Console.WriteLine("Please choose an option:\n" +
                "1.  Addition\n" +
                "2.  Subtraction\n" +
                "3.  Multiplication\n" +
                "4.  Division\n" +
                "5.  All\n" +
                "6.  Exit\n");

                var input = Console.ReadLine();
                int value;
                if (int.TryParse(input, out value))
                {
                    if (value > 0 && value <= 6)
                    {
                        return value;
                    }

                }
                Console.Clear();
                Console.WriteLine("Please enter a valid option.");
            } while (true);
        }
    }
}
