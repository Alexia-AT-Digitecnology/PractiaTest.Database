using System;
using System.Collections.Generic;

namespace PractiaTest.Database.Entities
{
    public partial class Client
    {
        public Client()
        {
            Invoice = new HashSet<Invoice>();
        }

        public int ClientId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public DateTime BornDate { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Invoice> Invoice { get; set; }
    }
}
