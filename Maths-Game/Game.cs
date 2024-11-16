using System;

namespace Maths_Game
{
    public class Game
    {
        public void runGame(string[] questionSet, int[] answerSet)
        {
            string input = "";
            foreach (string question in questionSet)
            {
                Console.Clear();
                Console.WriteLine(question);
                input = Console.ReadLine();
            }
        } 
    }
}