using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    internal abstract class Exam
    {
        public int Time { get; set; }
        public int NoOfQs { get; set; }

        public Question[] Questions { get; set; }

        //Delegate for the functionality?
        //Show Exam Functionality that its implementations will be 
        //different for each exam based on its type.

        public abstract void ExamFunctionality();

        public abstract void ExamResults();




    }
}
