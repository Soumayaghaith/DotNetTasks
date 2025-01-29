namespace ADVA2
{
    internal class Program
    {
        static bool IsBalanced(string input)
        {
            Stack<char> stack = new Stack<char>();
            foreach (char c in input)
            {
                if (c == '(' || c == '{' || c == '[')
                {
                    stack.Push(c);
                }
                else if (c == ')' || c == '}' || c == ']')
                {
                    if (stack.Count == 0)
                    { return false; }

                    char top = stack.Pop();
                    if (!CheckMatching(top, c))
                    {
                        return false;
                    }
                }


            }
            return stack.Count == 0;
        }
        static bool CheckMatching(char open, char close)
        {
            return (open == '{' && close == '}') ||
                   (open == '(' && close == ')') ||
                   (open == '[' && close == ']');
        }

        static int[] RemoveDuplicates(int[] nums)
        {
            List<int> result = new List<int>();
            foreach (int num in nums) 
            {
                if (!result.Contains(num))
                {
                    result.Add(num);
                }
                    
            }
            return result.ToArray();

        }
        static void Main(string[] args)
        {
            #region Q1
            //1. Given an array consists of numbers with size N and number of
            //queries, in each query you will be given an integer X, and you
            //should print how many numbers in array that is greater than X.
            //Console.WriteLine("Please enter the size of the array");
            //int.TryParse(Console.ReadLine(), out int size);
            //Console.WriteLine("Please enter the number of queries");
            //int.TryParse(Console.ReadLine(), out int Qs);

            //int[] arr = new int[size];

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    int.TryParse(Console.ReadLine(), out arr[i]);
            //}
            //int count = 0, temp;
            //for (int i = 0; i < Qs; i++)
            //{
            //    int.TryParse(Console.ReadLine(), out temp);
            //    count = 0;
            //    for (int j = 0; j < Qs; j++)
            //    {
            //        if (arr[j] > temp)
            //        {
            //            count++;
            //        }
            //    }
            //    Console.WriteLine(count);
            //}



            #endregion

            #region Q2
            //Remeber to use the split function
            //Given a number N and an array of N numbers. Determine if it's palindrome or not.
            //Console.WriteLine("Please enter the size of the array");
            //int.TryParse(Console.ReadLine(), out int size);

            //int[] arr = new int[size];

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    int.TryParse(Console.ReadLine(), out arr[i]);
            //}
            //int flag = 1;
            //for (int i = 0, j=arr.Length -1; i < arr.Length/2; i++,j--)
            //{
            //    if (arr[i] != arr[j])
            //    {
            //        flag = 0;
            //        break;
            //    }
            //}
            //if (flag == 0)
            //{
            //    Console.WriteLine("NO");
            //}
            //else
            //{
            //    Console.WriteLine("YES");
            //}
            #endregion

            #region Q3
            Queue<int> queue = new Queue<int>();
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);
            //queue.Enqueue(4);
            //queue.Enqueue(5);

            //Console.WriteLine("Original Queue: ");
            //foreach (int i in queue)
            //{
            //    Console.WriteLine(i);
            //}

            //Stack<int> stack = new Stack<int>();
            //while (queue.Count > 0)
            //{
            //    stack.Push(queue.Dequeue());
            //}

            //while (stack.Count > 0)
            //{
            //    queue.Enqueue(stack.Pop());
            //}
            //Console.WriteLine("After Reverse: ");
            //foreach (int i in queue)
            //{
            //    Console.WriteLine(i);
            //}


            #endregion

            #region Q4 
            //Given a Stack, implement a function to check if a string of
            //parentheses is balanced using a stack.
            //Ex:
            //Input:
            //[()] { }
            //Output:Balanced

            //string input = "[()]{}";
            //Console.WriteLine($"Input: {input}");

            //if (IsBalanced(input)== true)
            //{
            //    Console.WriteLine("Balanced");
            //}
            //else
            //{
            //    Console.WriteLine("Not Balanced");
            //}

            #endregion

            #region Q5 
            //int[] numbers = { 1, 2, 3, 4, 5, 6,6,6,6, 7, 8, 9, 10, 11 };
            //int[]uniqueNumbers = RemoveDuplicates(numbers);
            //Console.WriteLine("Array without duplication");
            //foreach (int num in uniqueNumbers)
            //{
            //    Console.WriteLine(num);
            //}

            #endregion


        }

        
    }
}
