using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace QuizStudio
{
   public class MultipleChoice : Question
    {
        public string OptA, OptB, OptC, OptD;
        public Dictionary<string, string> options = new Dictionary<string,string>();
        public MultipleChoice(string toAsk, string answer, string optA, string optB, string optC, string optD = "none of the above") :base(toAsk, answer)
        {

            options.Add("A", optA);
            options.Add("B",optB);
            options.Add("C", optC);
            options.Add("D", optD);
        }

        public override Boolean Ask()
        {
            Console.WriteLine(ToAsk);
            foreach (KeyValuePair<string, string> choices in options)
            { 
              Console.WriteLine(choices.Key + ") " + choices.Value);
            }
            string userInput = Console.ReadLine();
            if(userInput.ToUpper() == Answer.ToUpper())
            {
                return true;
            } else { return false; }
           
        }
    }
}
