using System;
using System.Collections.Generic;

namespace PractiaTest.Database.Entities
{
    public partial class Product
    {
        public Product()
        {
            InvoiceDetail = new HashSet<InvoiceDetail>();
        }

        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }

        public virtual ICollection<InvoiceDetail> InvoiceDetail { get; set; }
    }
}
