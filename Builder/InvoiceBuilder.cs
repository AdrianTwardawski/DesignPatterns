using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class InvoiceBuilder
    {
        private readonly Invoice _invoice = new Invoice();

        public Invoice Build()
        {
            return _invoice;
        }

        public InvoiceBuilder setVendor(string vendor)
        {
            _invoice.Vendor = vendor;
            return this;
        }

        public InvoiceBuilder setVendee(string vendee)
        {
            _invoice.Vendee = vendee;
            return this;
        }

        public InvoiceBuilder setNote(string note)
        {
            _invoice.Note = note;
            return this;
        }

        public InvoiceBuilder setLineItems(IEnumerable<string> lineItems)
        {
            _invoice.LineItems = lineItems;
            return this;
        }

        public InvoiceBuilder setInvoiceNumber(string number)
        {
            _invoice.Number = number;
            return this;
        }

        public InvoiceBuilder setDate(DateTime date)
        {
            _invoice.Date = date;
            return this;
        }
    }
}
