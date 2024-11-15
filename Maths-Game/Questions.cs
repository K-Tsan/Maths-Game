using System;

namespace Maths_Game
{
    public class Questions
    {
        Random rand = new Random();

        public (string[] questionSet, int[] answerSet) generateQuestions(Operation op, Difficulty diff)
        {
            var qSet = new string[10];
            var aSet = new int[10];
            
            switch(op)
            {
                case (Operation.Add):
                    for (int i = 0; i<10; i++)
                    {
                        (string newQuestion, int newAnswer) = generateAdd(diff);
                        qSet[i] = newQuestion;
                        aSet[i] = newAnswer;
                    }
                    break;
                case (Operation.Sub):
                    break;
                case (Operation.Mult):
                    break;
                case (Operation.Div):
                    break;
                case (Operation.All):
                    break;
            }
            return (questionSet: qSet, answerSet: aSet);
        }

        private (string addQuestion, int addAnswer) generateAdd(Difficulty adddiff)
        {
            int v1 = 0;
            int v2 = 0;
            switch(adddiff)
            {
                case (Difficulty.Easy):
                    v1 = rand.Next(1,11);
                    v2 = rand.Next(1,11);
                    break;
                case (Difficulty.Medium):
                    v1 = rand.Next(1, 51);
                    v2 = rand.Next(1, 51);
                    break;
                case (Difficulty.Hard):
                    v1 = rand.Next(20, 101);
                    v2 = rand.Next(20, 101);
                    break;
            }
            string newQuestion = $"{v1} + {v2}";
            int newAnswer = v1+v2;
            return (addQuestion: newQuestion, addAnswer: newAnswer);
        }
    }
}