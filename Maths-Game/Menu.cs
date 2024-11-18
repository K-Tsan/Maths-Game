using System;

namespace Maths_Game
{
    public class Menu
    {
        public int runMainMenu()
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
                "6.  Display past games\n" +
                "7.  Exit\n");

                var operationInput = Console.ReadLine();
                int value;
                if (int.TryParse(operationInput, out value))
                {
                    if (value > 0 && value <= 7)
                    {
                        return value;
                    } 

                }
                Console.Clear();
                Console.WriteLine("Please enter a valid option.");
            } while (true);
        }

        public int runDifficultyMenu()
        {
            Console.Clear();
            do
            {
                Console.WriteLine("Please choose an option:\n" +
                 "1.  Easy\n" +
                 "2.  Medium\n" +
                 "3.  Hard\n" +
                 "4.  Back\n");

                var difficultyInput = Console.ReadLine();
                int value;
                if (int.TryParse(difficultyInput, out value))
                {
                    if (value > 0 && value <= 4)
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
