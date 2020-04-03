using System;
using System.Collections.Generic;

namespace PersonalTouchMVC.Models
{
    public partial class Customers
    {
        public Customers()
        {
            Contacts = new HashSet<Contacts>();
            Payments = new HashSet<Payments>();
        }

        public int CustomerId { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string Password { get; set; }
        public DateTime? DateAccountCreated { get; set; }
        public string Adress { get; set; }
        public string PhoneNumber { get; set; }

        public virtual ICollection<Contacts> Contacts { get; set; }
        public virtual ICollection<Payments> Payments { get; set; }
    }
}
