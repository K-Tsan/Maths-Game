using System;
using System.ComponentModel.Design;
using Maths_Game;

namespace Maths_Game
{
    public enum Operation { Add = 1, Subtract = 2, Multiply = 3, Divide = 4, All = 5 }
    public enum Difficulty { Easy = 1, Medium = 2, Hard = 3 }

    public class Program
    {
        public static void Main(string[] args)
        {
            do
            {
                var menu = new Menu();
                var operationOutput = menu.runMainMenu();
                var difficultyOutput = menu.runDifficultyMenu();
                if (difficultyOutput == 4)
                {
                    continue;
                }
                Operation operation = (Operation)operationOutput;
                Difficulty difficulty = (Difficulty)difficultyOutput;

                Console.WriteLine($"{operation} {difficulty} has been picked.");
                Console.WriteLine("Press any button to close");
                Console.ReadKey();
            } while (true);
        }
    }
}
