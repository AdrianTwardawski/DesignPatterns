using System;
using System.Collections.Generic;

namespace Builder
{
    public class Program
    {
        static void Main(string[] args)
        {
            var builder = new InvoiceBuilder();

            Invoice invoice = builder.setDate(new DateTime(2022, 1, 12))
                .setInvoiceNumber("A1")
                .setVendor("Amazon")
                .setVendee("Vendee")
                .setLineItems(new List<string>() { "Line item1", "Line item2" })
                .Build();

            Console.WriteLine(invoice.Vendee);
            Console.WriteLine(invoice.Vendor);
        }
    }
}
