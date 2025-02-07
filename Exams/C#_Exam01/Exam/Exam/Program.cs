using ExaminationSystem;

namespace Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject Sub01 = new Subject(10, "C#");
            Sub01.CreateAnExam();
            Console.Clear();
            Console.WriteLine("Do you want to start your exam? (Y | N)");

            if (char.Parse(Console.ReadLine()) == 'Y')
            {
                Sub01.ShowTheExam();
            }
        }
    }
}
