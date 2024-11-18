using System;
using System.ComponentModel.Design;
using Maths_Game;

namespace Maths_Game
{
    public enum Operation { Add = 1, Sub = 2, Mult = 3, Div = 4, All = 5 }
    public enum Difficulty { Easy = 1, Medium = 2, Hard = 3 }

    public class Program
    {
        public static void Main(string[] args)
        {
            var mathsGame = new Game();
            var menu = new Menu();
            do
            {
                var operationOutput = menu.runMainMenu();
                if (operationOutput == 6)
                {
                    Console.Clear();
                    mathsGame.displayPastGames();
                    Console.WriteLine("Press any key to return.");
                    Console.ReadKey();
                    continue;
                }
                if (operationOutput == 7) 
                {
                    Console.WriteLine("Exiting, press any key.");
                    Console.ReadKey();
                    break;
                }
                var difficultyOutput = menu.runDifficultyMenu();
                if (difficultyOutput == 4)
                {
                    continue;
                }

                Operation operation = (Operation)operationOutput;
                Difficulty difficulty = (Difficulty)difficultyOutput;

                var questionGenerator = new Questions();

                (string[] questionSet, int[] answerSet) = questionGenerator.generateQuestions(operation, difficulty);

                mathsGame.runGame(questionSet, answerSet);

                Console.WriteLine("Returning to menu, press any key to continue");
                Console.ReadKey();
            } while (true);
        }
    }
}
