using A6.Project1;
using A6.Project2;
using A6.Project3;

namespace A6
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            #region Project01 Test
            //Point3D P = new Point3D(10, 10, 10);
            //Console.WriteLine(P.ToString());


            //Point3D P1 = new Point3D();
            //Console.WriteLine("Please enter the coordinates of P1");
            //int temp;

            //Console.Write("D1:");
            //while (!int.TryParse(Console.ReadLine(), out temp))
            //{
            //    Console.WriteLine("Olease enter a valid input");
            //}
            //P1.D1 = temp;

            //Console.Write("D2:");
            //while (!int.TryParse(Console.ReadLine(), out temp))
            //{
            //    Console.WriteLine("Olease enter a valid input");
            //}
            //P1.D2 = temp;

            //Console.Write("D3:");
            //while (!int.TryParse(Console.ReadLine(), out temp))
            //{
            //    Console.WriteLine("Olease enter a valid input");
            //}
            //P1.D3 = temp;
            ////*********************** Point 2**************************//

            //Point3D P2 = new Point3D();
            //Console.WriteLine("Please enter the coordinates of P2");


            //Console.Write("D1:");
            //while (!int.TryParse(Console.ReadLine(), out temp))
            //{
            //    Console.WriteLine("Olease enter a valid input");
            //}
            //P2.D1 = temp;

            //Console.Write("D2:");
            //while (!int.TryParse(Console.ReadLine(), out temp))
            //{
            //    Console.WriteLine("Olease enter a valid input");
            //}
            //P2.D2 = temp;

            //Console.Write("D3:");
            //while (!int.TryParse(Console.ReadLine(), out temp))
            //{
            //    Console.WriteLine("Olease enter a valid input");
            //}
            //P2.D3 = temp;

            //if (P1 == P2)
            //{
            //    Console.WriteLine("The 2 points are equal");
            //}
            //else
            //{
            //    Console.WriteLine("The 2 points are NOT equal");
            //}

            //Point3D[] points = { new Point3D(5, 2, 1), new Point3D(12, 23, 13), new Point3D(1, 6, 4), P1, P2 };
            //Console.WriteLine("Points Array Before Sorting");
            //foreach (Point3D point in points)
            //{
            //    Console.WriteLine(point);
            //}

            //Array.Sort(points, new SortBasedOnX());
            //Console.WriteLine("Points Array after Sorting based on X");
            //foreach (Point3D point in points)
            //{
            //    Console.WriteLine(point);
            //}

            //Array.Sort(points, new SortBasedOnY());
            //Console.WriteLine("Points Array after Sorting based on Y");
            //foreach (Point3D point in points)
            //{
            //    Console.WriteLine(point);
            //}
            #endregion

            #region Project02 Test

            //Console.WriteLine($"5 + 3 = {Maths.Add(5, 3)}");
            //Console.WriteLine($"5 - 3 = {Maths.Subtract(5, 3)}");
            //Console.WriteLine($"5 * 3 = {Maths.Multiply(5, 3)}");
            //Console.WriteLine($"5 / 3 = {Maths.Divide(5, 3)}");

            #endregion

            #region Project03 Test

            Console.WriteLine("Please enter the user type (Regular, Premium, or Guest)");
            string userType = Console.ReadLine();

            Console.Write("Please enter the product's price: ");
            decimal.TryParse(Console.ReadLine(), out decimal price);

            Console.Write("Please enter the product's quantity: ");
            int.TryParse(Console.ReadLine(), out int quantity);

            User user = new GuestUser();
            if (userType == "Regular")
            {
                user= new RegularUser();
                
            }
            else if (userType == "Premium")
            {
                user = new PremiumUser();
              
            }
            else if (userType == "Guest")
            {
                user = new GuestUser();
                
            }
            Discount discount = user.GetDiscount();
            decimal discountAmount = discount.CalculateDiscount(price, quantity);
            decimal totalPrice = (price * quantity) - discountAmount;

            Console.WriteLine($"Discount Amount is {discountAmount}");
            Console.WriteLine($"Final Price is {totalPrice}");


            #endregion

        }
    }
}
