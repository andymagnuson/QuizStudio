using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks.Sources;

namespace QuizStudio
{
    public class Quiz
    {
        public List<Question> Test; 

        public Quiz(List<Question> test)
        {
            Test = test;
        }


        public double TakeTest()
        {
            double result = 0;
            double score = 0;
            foreach (Question q in Test)
            {
                if (q.Ask())
                {
                    score++;
                    Console.WriteLine("Correct!");
                    Console.WriteLine("************");
                } else
                {
                    Console.WriteLine("Sorry, incorrect :(");
                }
            }
            result = ((score/Test.Count)*100);
            return result;
        }
    }
}
