using System;
using System.Collections.Generic;

namespace PractiaTest.Database.Entities
{
    public partial class InvoiceDetail
    {
        public int InvoiceDetailId { get; set; }
        public int InvoiceId { get; set; }
        public int ProductId { get; set; }
        public int Amount { get; set; }
        public decimal SellPrice { get; set; }
        public decimal? Total { get; set; }

        public virtual Invoice Invoice { get; set; }
        public virtual Product Product { get; set; }
    }
}
