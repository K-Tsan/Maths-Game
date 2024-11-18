using System;

namespace Maths_Game
{
    public class Game
    {
        private List<string[]> pastGames = new List<string[]>();
        public void runGame(string[] questionSet, int[] answerSet)
        {
            int score = 0;
            var record = new string[questionSet.Length];
            for (int i = 0; i < questionSet.Length; i++)
            {
                Console.Clear();
                var userAnswer = getUserAnswer(questionSet[i]);
                bool isCorrect = (userAnswer == answerSet[i]);
                if (isCorrect)
                {
                    score++;
                }
                var result = isCorrect ? "Correct" : "Incorrect";
                record[i] = $"Question: {questionSet[i],-10}| Answer: {answerSet[i], -4}| Given Answer: {userAnswer, -4}| {result}";
            }
            pastGames.Add(record);
            Console.Clear();
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
                if (int.TryParse(input, out value) && value<10000 && value>=0)
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

        public void displayPastGames()
        {
            var counter = 1;
            if (pastGames.Count == 0)
            {
                Console.WriteLine("No records found.");
                return;
            }
            foreach(string[] game in pastGames)
            {
                Console.WriteLine($"Game{counter++}:");
                foreach(string record in game)
                {
                    Console.WriteLine(record);
                }
            }
        }
    }
}