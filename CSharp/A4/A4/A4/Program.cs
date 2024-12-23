namespace A4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //- Write a program that takes a number from the user then print yes if
            //that number can be divided by 3 and 4 otherwise print no.
            //Console.Write("Please enter a number: ");
            //int.TryParse(Console.ReadLine(), out int num);
            //if ((num % 3 == 0) && (num % 4 == 0))
            //{
            //    Console.WriteLine("Yes");
            //}
            //else
            //{
            //    Console.WriteLine("No");
            //}
            #endregion

            #region Q2
            //- Write a program that allows the user to insert an integer then print
            //negative if it is negative number otherwise print positive.
            Console.Write("Please enter a number: ");
            int.TryParse(Console.ReadLine(), out int num);
            if (num < 0)
            {
                Console.WriteLine("Negative");
            }
            else
            {
                Console.WriteLine("Positive");
            }
            #endregion
        }
    }
}
