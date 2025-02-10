using System.ComponentModel.DataAnnotations;

namespace LINQ_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Before Diving into LINQ 
            #region Implicitly Typed Local Variable [var, dynamic]

            #region var keyword
            //var Data = "Ahmed"; //Implicit Type
            ////The Compiler will detect the datatype of the variable at compilation time 
            ////based on its initial value 

            ////var X = null; //Invalid 
            ////In this case the compiler will not be able to detect the datatype 
            ////var cannot be initialzed with null

            //Data = null; //Valid, as this is not the initial value 
            //             //Data = 5; // Invalid, You can't change the datattype after initialization

            ////var x;//Invalid, you must initilize it  
            #endregion

            #region dynamic keyword
            //dynamic data ="Ali";
            ////In this case it is not the compiler that will detect the datatype
            ////The CLR will detect the datatype of the variable and the CLR starts @ runtime
            ////based on its last assigned value

            //data = 5;
            //data = true;//in this case the data's datatpe will be bool

            //dynamic X;//valid
            ////You can declare a variable with the dynamic keyword without initilization 

            //dynamic Y = null;//Valid 
            ////a dynamic varible can be initilized with null

            //data = 2;
            ////You can change the datat type after initialization
            //data = true;
            //data = 3.3;
            //data = 'l';

            #endregion



            #endregion

            #region Extension Method
            //int X = 12345;
            ////int Y = intExtension.Reverse(X);
            //int Y = X.Reverse();//The reverse function is now an object member method 
            //Console.WriteLine(Y);

            //long M = 12345;
            ////int Z = intExtension.Reverse(X);
            //long Z = M.Reverse();//The reverse function is now an object member method 
            //Console.WriteLine(Y);




            #endregion

            #region Anonymous Type
            ////Employee employee = new Employee() { Id=10, Name= "Ahmed", Salary=5000};
            ////object Emp01 = new { Id = 10, Name = "Ahmed", Salary = 5000 };

            ////Console.WriteLine(Emp01.Salary);
            ////Invalid, cause the obj can have anything from anytype that does not have salary 

            ////Anonymous Object
            //var Emp02 = new { Id = 10, Name = "Ahmed", Salary = 5000 };

            //int X = 5;
            //Console.WriteLine(X.GetType().Name);//Int32

            //Console.WriteLine(Emp02.GetType().Name);//AnonymousType0`3
            //                                        //0 means that this is the first anonymous type
            //                                        //'3 The number of properties inside the object
            //                                        //The object that will be created from an anonymous type is an immutable object same as string
            //Console.WriteLine(Emp02.Salary);//5000
            ////Emp02.Salary = 2000; //Invalid

            ////but if you still need to change the value of a certain attribute 
            ////You can do it the same way the string do it as shown below
            ////We used to do this till C#9.0
            //var Emp03 = new { Id = Emp02.Salary, Name= Emp02.Name , Salary =2000};


            ////Starting from C#10.0 .NET 6
            //var Emp04 = Emp02 with { Salary = 1000 };

            ////Anonymous Type overrides the ToString to print the data in the object
            //Console.WriteLine($"Emp01 = {Emp02.GetType().Name}");//AnonymousType0`3
            //Console.WriteLine($"Emp01 = {Emp03.GetType().Name}");//AnonymousType0`3
            //Console.WriteLine($"Emp01 = {Emp04.GetType().Name}");//AnonymousType0`3

            ////The objects that will be created will be of the same anonymous type as long as 
            ////1. Same Properties Name (case sensitve)
            ////2. Same properties order


            #endregion
            #endregion

            #region What is LINQ
            ////LINQ Language-Integrated Query
            ////+40 Extension Methods
            ////Extension Methods for all collection that implement IEnumerable
            ////Categorized into 13 category


            //List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //List<int> oddNumbers = numbers.Where(num=> num%2 != 0).ToList();
            //foreach (int num in oddNumbers)
            //{
            //    Console.WriteLine(num);
            //}
            ////You can use LINQ operators against the data in condition that the data is stored in Sequence
            ////Regardless the data store [SQL Server, Oracle, MySQL]

            ////Sequence means an object from any class that implements the built-in interface IEnumerable and it has different types
            ////1. Local Sequence  -> Static data[LINQ against object OR LINQ to object L2Object] as numbers
            ////Or from an XML file [LINQ against XML OR LINQ to XML L2XML]
            ////2. Remote Sequence -> data stored in a server [to use LINQ operators agains EF or LINQ to EF L2EF]


            #endregion


            #region LINQ Syntax[ Fluent Syntax, Query Syntax ]

           
            List<int> numbers = new List<int>() { 1,2,3,4,5,6,7,8,9,10};
            //Fluent Syntax 



            



            #endregion


        }
    }
}
