using System;
using System.Collections.Generic;

namespace PersonalTouchMVC.Models
{
    public partial class Contacts
    {
        public Contacts()
        {
            EventDates = new HashSet<EventDates>();
        }

        public int ContactId { get; set; }
        public int? CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string Adress { get; set; }

        public virtual Customers Customer { get; set; }
        public virtual ICollection<EventDates> EventDates { get; set; }
    }
}
