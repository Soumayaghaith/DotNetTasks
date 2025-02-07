using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    internal class MCQs :Question
    {
        
        public override void SetQuestion()
        {
            Console.WriteLine("Please enter the header of the question ");
            Header = Console.ReadLine();
            Console.WriteLine($"Please enter the body of the question ");
            Body = Console.ReadLine();
            Console.WriteLine($"Please enter the mark of the question ");
            Mark = int.Parse(Console.ReadLine());
            Console.WriteLine("Choices for the question: ");
            AnswerList = new Answers[3];
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Please enter choice{i+1}: ");
                string Choice = Console.ReadLine();
                AnswerList[i] = new Answers(i, Choice); 
                Console.WriteLine();
            }
            

            Console.WriteLine($"Please enter the right answer's number");
            int correctIndex = int.Parse(Console.ReadLine())-1;
            CorrectAnswer = AnswerList[correctIndex];

        }

     
        
    }
}
