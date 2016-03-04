using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSHARP_Chapter_9_Exercise_9._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice[] Invoices = {new Invoice(83, "Electric sander", 7, (decimal)57.98),
                                  new Invoice(24, "Power saw", 18, (decimal)99.99),
                                  new Invoice(7, "Sledge hammer", 11, (decimal)21.50),
                                  new Invoice(77, "Hammer", 76, (decimal)11.99),
                                  new Invoice(39, "Lawn mower", 3, (decimal)79.50),
                                  new Invoice(68, "Screwdriver", 106, (decimal)6.99),
                                  new Invoice(56, "Jig saw", 21, (decimal)11.00),
                                  new Invoice(3, "Wrench", 34, (decimal)7.50)};

            var partdescription1 = from e in Invoices
                                  orderby e.PartDescription
                                  select e.PartDescription;
            Console.WriteLine("LINQ Query to sort Invoice objects by Part Description\n");
            foreach (string element in partdescription1)
                Console.WriteLine(element);

            var price = from e in Invoices
                        orderby e.Price
                        select e.Price;
            Console.WriteLine("\nLINQ Query to sort Invoice objects by Price\n");
            foreach (decimal element in price)
                Console.WriteLine("{0:C}", element);

            var quantity = from e in Invoices
                           orderby e.Quantity
                           select new {e.Quantity, e.PartDescription};
            Console.WriteLine("\nLING Query to sort Invoice objects by Quantity and Part Description\n");
            foreach (var element in quantity)
                Console.WriteLine(element);

            var invoicevalue = from e in Invoices
                               let value = (e.Price * e.Quantity)
                               orderby value
                               select new { value, e.PartDescription };
            Console.WriteLine("\nLINQ Query to sort Invoice objects by Invoice Value and Part Description\n");
            foreach (var element in invoicevalue)
                Console.WriteLine(element);

            var invoicevalue2 = from e in Invoices
                                let value = (e.Price * e.Quantity)
                                where value >= 200 && value <= 500
                                orderby value
                                select new { value, e.PartDescription };
            Console.WriteLine("\nLINQ Query to sort Invoice objects by Invoice Value and Part Description where Invoice Value ranges from $200 to $500\n");
            foreach (var element in invoicevalue2)
                Console.WriteLine(element);
        }
        
    }
}
