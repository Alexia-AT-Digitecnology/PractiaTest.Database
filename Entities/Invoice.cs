using System;
using System.Collections.Generic;

namespace PractiaTest.Database.Entities
{
    public partial class Invoice
    {
        public Invoice()
        {
            InvoiceDetail = new HashSet<InvoiceDetail>();
        }

        public int InvoiceId { get; set; }
        public int ClientId { get; set; }
        public DateTime IssueDate { get; set; }
        public bool Paid { get; set; }

        public virtual Client Client { get; set; }
        public virtual ICollection<InvoiceDetail> InvoiceDetail { get; set; }
    }
}
