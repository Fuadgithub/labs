using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConstructr
{
    class Program
    {
        static void Main(string[] args)
        {
            var prod1 = new Product("Swith", 8m, 7);
            Console.WriteLine(prod1.Name);
            Console.WriteLine(prod1.Price);
            Console.WriteLine(prod1.UnitsInStock);
        }

    }

    public class Product
    {
        public string Name { get; set; }
        public int UnitsInStock { get; set; }
        public decimal Price { get; set; }
        public string ProductDescription { get; set; }

        public Product(string name, decimal price, int unitsInStock)
        {
            this.Name = name;
            this.Price = price;
            this.UnitsInStock = unitsInStock;
        }
    }
}
