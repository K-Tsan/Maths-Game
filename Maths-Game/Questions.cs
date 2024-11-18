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
                    for (int i = 0; i < 10; i++)
                    {
                        (string newQuestion, int newAnswer) = generateSub(diff);
                        qSet[i] = newQuestion;
                        aSet[i] = newAnswer;
                    }
                    break;
                case (Operation.Mult):
                    for (int i = 0; i < 10; i++)
                    {
                        (string newQuestion, int newAnswer) = generateMult(diff);
                        qSet[i] = newQuestion;
                        aSet[i] = newAnswer;
                    }
                    break;
                case (Operation.Div):
                    for (int i = 0; i < 10; i++)
                    {
                        (string newQuestion, int newAnswer) = generateDiv(diff);
                        qSet[i] = newQuestion;
                        aSet[i] = newAnswer;
                    }
                    break;
                case (Operation.All):
                    for (int i = 0; i < 10; i++)
                    {
                        int randVal = rand.Next(0, 4);
                        string newQuestion = "";
                        int newAnswer = 0;
                        switch(randVal)
                        {
                            case 0:
                                (newQuestion, newAnswer) = generateAdd(diff);
                                break;
                            case 1:
                                (newQuestion, newAnswer) = generateSub(diff);
                                break;
                            case 2:
                                (newQuestion, newAnswer) = generateMult(diff);
                                break;
                            case 3:
                                (newQuestion, newAnswer) = generateDiv(diff);
                                break;
                        }
                        qSet[i] = newQuestion;
                        aSet[i] = newAnswer;
                    }
                    break;
            }
            return (questionSet: qSet, answerSet: aSet);
        }

        private (string addQuestion, int addAnswer) generateAdd(Difficulty addDiff)
        {
            int v1 = 0;
            int v2 = 0;
            switch(addDiff)
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

        private (string subQuestion, int subAnswer) generateSub(Difficulty subDiff)
        {
            int v1 = 0;
            int v2 = 0;
            switch (subDiff)
            {
                case (Difficulty.Easy):
                    v1 = rand.Next(1, 11);
                    v2 = rand.Next(1, 11);
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

            string newQuestion = $"{v2} - {v1}";
            int newAnswer = v2 - v1;
            if (v1 > v2)
            {
                newQuestion = $"{v1} - {v2}";
                newAnswer = v1 - v2;
            }
          
            return (subQuestion: newQuestion, subAnswer: newAnswer);
        }

        private (string multQuestion, int multAnswer) generateMult(Difficulty multDiff)
        {
            int v1 = 0;
            int v2 = 0;
            switch (multDiff)
            {
                case (Difficulty.Easy):
                    v1 = rand.Next(1, 11);
                    v2 = rand.Next(1, 11);
                    break;
                case (Difficulty.Medium):
                    v1 = rand.Next(1, 51);
                    v2 = rand.Next(1, 11);
                    break;
                case (Difficulty.Hard):
                    v1 = rand.Next(20, 51);
                    v2 = rand.Next(1, 51);
                    break;
            }
            
            string newQuestion = $"{v1} * {v2}";
            int newAnswer = v1 * v2;
            return (multQuestion: newQuestion, multAnswer: newAnswer);
        }

        private (string divQuestion, int divAnswer) generateDiv(Difficulty divDiff)
        {
            int v1 = 0;
            int v2 = 0;
            int newAnswer = 0;
            switch (divDiff)
            {
                case (Difficulty.Easy):
                    int[] numberSet = {2,3,5,10};
                    v1 = numberSet[rand.Next(0, 4)];
                    newAnswer = rand.Next(1, 11);
                    v2 = newAnswer * v1;
                    break;
                case (Difficulty.Medium):
                    v1 = rand.Next(1, 11);
                    newAnswer = rand.Next(1, 11);
                    v2 = newAnswer * v1;
                    break;
                case (Difficulty.Hard):
                    v1 = rand.Next(1, 21);
                    newAnswer = rand.Next(11, 21);
                    v2 = newAnswer * v1;
                    break;
            }

            string newQuestion = $"{v2} / {v1}";
            return (divQuestion: newQuestion, divAnswer: newAnswer);
        }
    }
}