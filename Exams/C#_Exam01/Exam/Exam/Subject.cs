using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    internal class Subject
    {

        private int subjID { get; set; }
        private string  subjName { get; set; }
        private Exam subjExam { get; set; }
        private int examType;

        public Subject(int subjID, string subjName)
        {
            this.subjID = subjID;
            this.subjName = subjName;
        }

        public void CreateAnExam()
        {
            
            Console.WriteLine("Please enter the exam type 1 for Practical, 2 for Final");
            int examType = int.Parse(Console.ReadLine());
            if ( examType== 1)//Practical
            { 
                subjExam = new PracticalExam();
                subjExam.ExamFunctionality();
            }
            else if (examType == 2)//Final
            {
                subjExam = new FinalExam();
                subjExam.ExamFunctionality();
            }

        }
        //This will show the exam and take the answers
        public void ShowTheExam()
        {
            Console.Clear();
            Answers[] StudentAnswer = new Answers[100];
            Console.WriteLine("The exam has started");
            for (int i = 0; i < subjExam.NoOfQs; i++)
            {
                if (examType == 1)//Practical
                {
                    Console.WriteLine($"Question No {i + 1}");
                    Console.WriteLine($"Question {i + 1}'s header: {subjExam.Questions[i].Header} ");
                    Console.WriteLine($"Question {i + 1}'s body: {subjExam.Questions[i].Body}");
                    Console.WriteLine($"Question {i + 1}'s Mark: {subjExam.Questions[i].Mark}");
                    Console.WriteLine("Please enter your answer");
                    StudentAnswer[i] = new Answers(i, Console.ReadLine());
                }
                else if (examType == 2)//Final
                {
                    Console.WriteLine($"Question No {i + 1}");
                    Console.WriteLine($"Question {i + 1}'s header: {subjExam.Questions[i].Header} ");
                    Console.WriteLine($"Question {i + 1}'s body: {subjExam.Questions[i].Body}");
                    Console.WriteLine($"Question {i + 1}'s Mark: {subjExam.Questions[i].Mark}");
                    Console.WriteLine("Chocies: ");
                    for (int j = 0; j < 3; j++)
                    {
                        Console.WriteLine($"{subjExam.Questions[i].Choices[j]}");
                    }
                    StudentAnswer[i] = new Answers(i, Console.ReadLine());
                    

                }

            }
            int result = 0;
            for (int i = 0; i < subjExam.NoOfQs; i++)
            {
                if (StudentAnswer[i].AnswerText == subjExam.Questions[i].AnswerList[i].AnswerText)
                {
                    result += subjExam.Questions[i].Mark;
                }
            
            }
            subjExam.ExamResults();




            }
    }
}
