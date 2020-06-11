using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuizStudio
{
    public class Checkbox : MultipleChoice
    {

        public List<string> Answers;
        public Checkbox(string toAsk, string answer, string optA, string optB, string optC, string optD = "none of the above") : base(toAsk, answer, optA, optB, optC, optD)
        {
            Answers = answer.ToUpper().Split(' ').ToList<string>();
           
           // Answers.SequenceEqual()
        }
       
        public override Boolean Ask()
        {
            List<string> userArray;
            Console.WriteLine("Please select all applicable answers in order");           
            Console.WriteLine(ToAsk);
            foreach (KeyValuePair<string, string> choices in options)
            {
                Console.WriteLine(choices.Key + ") " + choices.Value);
            }
            string userInput = Console.ReadLine().ToUpper();
            userArray = userInput.Split(' ').ToList<string>();
            if (Answers.SequenceEqual(userArray))
            {
                return true;
            }
            else { return false; }

        }
    }
}
