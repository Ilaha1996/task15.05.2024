using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Metrics;

namespace Numerical_average
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var product1 = new { ID = 1, Name = "pen", Price = 35, StockCount = 13 };
            var product2 = new { ID = 2, Name = "pencil", Price = 25, StockCount = 10 };
            var product3 = new { ID = 3, Name = "book", Price = 20, StockCount = 15 };
            var product4 = new { ID = 4, Name = "bag", Price = 30, StockCount = 15 };
            var product5 = new { ID = 5, Name = "Notebook", Price = 10, StockCount = 17 };

            var products = new[] { product1, product2, product3, product4, product5 };

            int sum = 0;
            int counter = 0;

            foreach (var product in products)
                      
            {                
                if (product.ID % 2 == 1)
                {

                    sum += product.Price;
                    counter++;
                    
                }
             } Console.WriteLine(sum / counter);
        }
    }
}