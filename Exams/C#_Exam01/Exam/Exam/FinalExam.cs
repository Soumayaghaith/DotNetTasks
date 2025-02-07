using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    //after the student ends the exam, the questions, answers and garde will appear


    //she said it should ask the user about exam type 1 for prac 2 for final  and number of questions and also
    //the questions type
    //and the body of the question in string
    //mark
    //Model answer
    //if it was MCQ you need to enter the choices

    //then the entered exam will be shown and will wait for the students 
    internal class FinalExam : Exam
    {
        
        public override void ExamFunctionality()
        {
            Console.WriteLine("Setting up the final exam:");
            Console.WriteLine("========================");

            Console.WriteLine("Please enter the duration of the exam in minutes");
            Time = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Please enter the number of the questions");
            NoOfQs = int.Parse(Console.ReadLine());
            Questions = new Question[NoOfQs];   

            for (int i = 0; i < NoOfQs; i++)
            {
                

                Console.WriteLine($"Please enter the type of question {i+1}");
                Console.WriteLine("1 for T|F question or 2 for MCQs");
                int questionType = int.Parse(Console.ReadLine());
                if (questionType==1)
                {
                    TFQuestions question = new TFQuestions();
                    Questions[i] = question;
                    question.SettingTFQuestions(i);

                }
                else if (questionType == 2)
                {
                    MCQs question = new MCQs();
                    question.SettingMCQs(i);
                    Questions[i] = question;

                }


            }

        }

        //Final Exam Shows the Questions, Answers and Grade.
        public override void ExamResults()
        {
            for (int i = 0; i < NoOfQs; i++)
            {
                Console.WriteLine($"The Right answer for Q1: {Questions[i].CorrectAnswer.AnswerText}");
            }
        }
    }
}
