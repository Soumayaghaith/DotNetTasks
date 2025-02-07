using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    internal abstract class Question
    {
        public string Header { get; set; }
        public string Body { get; set; }
        public int Mark { get; set; }
        public Answers[] AnswerList { get; set; } = new Answers[100];//stores possible answers for MCQ

        public Answers CorrectAnswer { get; set; }
        public abstract void SetQuestion();
    }
}
