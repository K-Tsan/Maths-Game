using System;

namespace Maths_Game
{
    public class Game
    {
        public void runGame(string[] questionSet, int[] answerSet)
        {
            int score = 0;
            for (int i = 0; i < questionSet.Length; i++)
            {
                Console.Clear();
                var userAnswer = getUserAnswer(questionSet[i]);
                bool isCorrect = (userAnswer == answerSet[i]);
                if (isCorrect)
                {
                    score++;
                }
            }
            Console.WriteLine($"Your score is {score}.");
        }

        private int getUserAnswer(string question)
        {
            var validInput = false;
            int value = 0;
            do
            {
                Console.WriteLine(question);
                var input = Console.ReadLine();
                if (int.TryParse(input, out value))
                {
                    validInput = true;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Please enter a valid number.");
                }
            } while (validInput == false);
            return value;
        }
    }
}