using System;

public class InvoiceTest
{
        public static void Main(string[] args)
        {
            string number; //declares the number variable
            string description; //declares the description variable
            int quantity; //declares the quantity variable
            decimal price; //declares the price variable

            Console.Write("Enter the part number: "); //writes message asking for user input for part number
            number = Console.ReadLine(); //stores user input for part number in the number variable
            Console.Write("Enter description of part: "); //write message asking for user input for part description
            description = Console.ReadLine(); //stores user input for part description in description variable
            Console.Write("Enter quantity being purchased: "); //writes message asking for user input for quantity purchased
            quantity = Convert.ToInt32(Console.ReadLine()); //stores user input for quantity purchased in quantity variable
            Console.Write("Enter price per item: $"); //write message asking for user input for cost per item
            price = Convert.ToDecimal(Console.ReadLine()); //stores user input for cost per item in the price variable

            Invoice invoice1 = new Invoice(number, description, quantity, price); //creates new invoice

            Console.WriteLine(); //writes blank line
            Console.WriteLine("Part Number: {0}", invoice1.PartNumber); //writes part number
            Console.WriteLine("Part Description: {0}", invoice1.PartDescription); //writes part description
            Console.WriteLine("Quantity: {0}", invoice1.QuantityPurchased); //writes quantity
            Console.WriteLine("Cost Per Item: {0:C}", invoice1.PricePerItem); //writes price per item
            Console.WriteLine("Total Cost: {0:C}", invoice1.TotalCost); //writes total cost of the invoice
        }
    }

