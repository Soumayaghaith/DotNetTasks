using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    //after the student ends the exam, the questions and answers will appear
    internal class PracticalExam : Exam
    {
        public override void ExamFunctionality()
        {
            Console.WriteLine("Setting up the practical exam:");
            Console.WriteLine("========================");
            Console.WriteLine("Please enter the duration of the exam in minutes");
            Time = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the number of the questions");
            NoOfQs = int.Parse(Console.ReadLine());

            for (int i = 0; i < NoOfQs; i++)
            {
                MCQs question = new MCQs();
                question.SetQuestion();
            }

        }

        //Practical Exam Shows the right answer after finishing the Exam
        public override void ExamResults()
        {
            for (int i = 0; i < NoOfQs; i++)
            {
                Console.WriteLine($"The Right answer for Q1: {Questions[i].CorrectAnswer.AnswerText}");
            }
        }
    }
}
