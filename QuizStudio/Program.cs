using System;
using System.Collections.Generic;

namespace QuizStudio
{
    class Program
    {
        static void Main(string[] args)
        {
            Question q1 = new Question("How many ducks live in a pond", "14");
           // Console.WriteLine(q1.Ask());
            MultipleChoice m = new MultipleChoice("WHo is the president?", "C", "Bush", "Your Mom", "Trump");
            //Console.WriteLine(m.Ask());
            // q1.ask   asks a question
            //readline the result
            //store the user answer
            //List<string> stringList = new List<string> { "Bush"};
            Checkbox c = new Checkbox("WHo is the president?", "BC", "Bush", "Your Mom", "Trump");
           // Console.WriteLine(c.Ask());

            List<Question> test1 = new List<Question>();
            test1.Add(q1);
            test1.Add(m);
            test1.Add(c);

            Quiz quiz1 = new Quiz(test1);

            Console.WriteLine(quiz1.TakeTest());

        }
    }
}
