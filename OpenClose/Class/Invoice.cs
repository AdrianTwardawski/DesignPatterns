using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClose.Class
{
    public class Invoice
    {
        public IEnumerable<Lineitem> LineItems { get; set; }
        public string Vendor { get; set; }
        public string Vendee { get; set; }
        public float Total { get; set; }

        public Invoice(IEnumerable<Lineitem> lineitems, string vendor, string vendee)
        {
            LineItems = lineitems;
            Vendor = vendor;
            Vendee = vendee;
            Total = this.CalculateTotal();
        }

        public float CalculateTotal()
        {
            float total = 0;
            foreach (var lineItem in LineItems)
            {
                total += lineItem.Price * lineItem.Count * (1 + lineItem.TaxRate);
            }
        return total;
        }


    }
}
