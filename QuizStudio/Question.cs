using System;
using System.Collections.Generic;
using System.Text;

namespace QuizStudio
{
    public class Question
    {
        public string ToAsk;
        public string Answer;


        public Question(string toAsk, string answer)
        {
            ToAsk = toAsk;
            Answer = answer;
        }

        public virtual Boolean Ask()
        {
            Console.WriteLine(ToAsk);
            string tempAnswer = Console.ReadLine();
            if (tempAnswer == Answer)
            {
                return true;
            } else
            {
                return false;
            }

        }

    }
}
