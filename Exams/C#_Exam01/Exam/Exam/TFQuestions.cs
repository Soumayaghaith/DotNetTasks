using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    internal class TFQuestions :Question
    {
        public void SettingTFQuestions(int ID)
        {
            Console.WriteLine("Please enter the header of the question ");
            Header = Console.ReadLine();
            Console.WriteLine($"Please enter the body of the question ");
            Body = Console.ReadLine();
            Console.WriteLine($"Please enter the mark of the question ");
            Mark = int.Parse(Console.ReadLine());
            AnswerList = new Answers[]
                { 
                    new Answers(0,"true"),
                    new Answers(1,"false"),
                
                };
            Console.WriteLine($"Please enter the right answer for the question true|false");
            string correct = Console.ReadLine().ToLower();
            CorrectAnswer = correct == "true"?AnswerList[0]:AnswerList[1];
           

        }

    }
}
