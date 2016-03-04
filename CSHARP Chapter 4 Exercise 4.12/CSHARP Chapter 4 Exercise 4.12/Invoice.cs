using System;

public class Invoice
{
    private int quantitypurchased; //declares quantitypurchased variable
    private decimal priceperitem; //declares priceperitem variable

    public Invoice(string partnumber, string partdescription, int quantitypurchased, decimal priceperitem) //constructor
    {
        PartNumber = partnumber; //following code sets up info for constructor
        PartDescription = partdescription;
        QuantityPurchased = quantitypurchased;
        PricePerItem = priceperitem;
        TotalCost = GetInvoiceAmount(quantitypurchased, priceperitem);

    } //end constructor
    public decimal TotalCost { get; set; } //sets total cost for invoice

    public string PartNumber { get; set; } //sets part number for invoice

    public string PartDescription { get; set; } //sets part description for invoice

    public int QuantityPurchased //sets quantity purchased for invoice
    {
        get
        { return quantitypurchased; }
        set
        { if (value >= 0)
            quantitypurchased = value; }
    }

    public decimal PricePerItem //sets price per item for invoice
    {
        get
        { return priceperitem; }
        set
        { if (value >= 0)
            priceperitem = value; }
    }

    public decimal GetInvoiceAmount(int quantity, decimal price) //method to calculate total cost of invoice
    {
        decimal total;
        total = quantity * price;
        return total;
    }
}
    

    
