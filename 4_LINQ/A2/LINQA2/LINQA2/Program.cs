namespace LINQA2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = ListGenerator.ProductsList;
            List<Customer> customers = ListGenerator.CustomersList;

            // LINQ - Aggregate Operators
            var totalStockByCategory = products.GroupBy(p => p.Category)
                                               .Select(g => new { Category = g.Key, TotalStock = g.Sum(p => p.UnitsInStock) });

            var cheapestPriceByCategory = products.GroupBy(p => p.Category)
                                                  .Select(g => new { Category = g.Key, CheapestPrice = g.Min(p => p.UnitPrice) });

            var cheapestProductsByCategory = products.GroupBy(p => p.Category)
                                                     .Select(g => new {
                                                         Category = g.Key,
                                                         Products = g.Where(p => p.UnitPrice == g.Min(p2 => p2.UnitPrice)).ToList()
                                                     });

            var mostExpensivePriceByCategory = products.GroupBy(p => p.Category)
                                                       .Select(g => new { Category = g.Key, MaxPrice = g.Max(p => p.UnitPrice) });

            var mostExpensiveProductsByCategory = products.GroupBy(p => p.Category)
                                                          .Select(g => new {
                                                              Category = g.Key,
                                                              Products = g.Where(p => p.UnitPrice == g.Max(p2 => p2.UnitPrice)).ToList()
                                                          });

            var averagePriceByCategory = products.GroupBy(p => p.Category)
                                                 .Select(g => new { Category = g.Key, AvgPrice = g.Average(p => p.UnitPrice) });

            // LINQ - Set Operators
            var uniqueCategories = products.Select(p => p.Category).Distinct();
            var uniqueFirstLetters = products.Select(p => p.ProductName[0])
                                             .Union(customers.Select(c => c.CustomerName[0]))
                                             .Distinct();

            var commonFirstLetters = products.Select(p => p.ProductName[0])
                                             .Intersect(customers.Select(c => c.CustomerName[0]));

            var productFirstLettersNotInCustomers = products.Select(p => p.ProductName[0])
                                                             .Except(customers.Select(c => c.CustomerName[0]));

            var lastThreeChars = products.Select(p => p.ProductName.Substring(Math.Max(0, p.ProductName.Length - 3)))
                                         .Union(customers.Select(c => c.CustomerName.Substring(Math.Max(0, c.CustomerName.Length - 3))));

        }
    }
}
