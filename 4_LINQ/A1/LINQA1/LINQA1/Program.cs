using Day_01_G03;
namespace LINQA1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var products = ListGenerator.ProductsList;
            var customers = ListGenerator.CustomersList;

            #region Restriction Operators
            Console.WriteLine("These are the products that are out of stock");
            var outOfStoucProducts = products.Where(p=> p.UnitsInStock==0).ToList();
            foreach(var product in outOfStoucProducts) { Console.WriteLine(product); }

            Console.WriteLine();
            Console.WriteLine("Products in the stock and cost more than 3$");
            var moreThan3Dollars = products.Where(p=>p.UnitsInStock > 0 && p.UnitPrice > 3);
            foreach(var product in moreThan3Dollars) { Console.WriteLine(product); }

            Console.WriteLine("Digits whose names are shorter than their values");
            string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten" };
            var shortNamedDigits = digits.Where((name, index) => name.Length < index);
            foreach(var name in shortNamedDigits) { Console.WriteLine(name); }


            #endregion

            #region Element Operators
            Console.WriteLine("First out of stock product");
            var firstOutOfStock = products.FirstOrDefault(p => p.UnitsInStock == 0);
            Console.WriteLine(firstOutOfStock?.ProductName??"None");

            Console.WriteLine("First out of stock product");
            var firstExpensive = products.FirstOrDefault(p => p.UnitPrice > 1000);
            Console.WriteLine(firstOutOfStock?.ProductName ?? "None");

            Console.Write("Second number greater than 5 is :");
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 0 };
            var secondNumberGreaterThan5 = numbers.Where(x=> x > 5).Skip(1).FirstOrDefault();
            Console.WriteLine(secondNumberGreaterThan5);
            #endregion

        }
    }
}
