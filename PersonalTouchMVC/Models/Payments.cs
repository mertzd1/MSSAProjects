using System;
using System.Collections.Generic;

namespace PersonalTouchMVC.Models
{
    public partial class Payments
    {
        public int PaymentId { get; set; }
        public int? CustomerId { get; set; }
        public string CreditCardName { get; set; }
        public int? CreditCardNumber { get; set; }
        public DateTime? CardExperationDate { get; set; }
        public int? CvcCode { get; set; }
        public string NameOnCard { get; set; }
        public string BillingAddress { get; set; }

        public virtual Customers Customer { get; set; }
    }
}
