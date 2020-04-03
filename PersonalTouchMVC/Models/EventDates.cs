using System;
using System.Collections.Generic;

namespace PersonalTouchMVC.Models
{
    public partial class EventDates
    {
        public EventDates()
        {
            CardBank = new HashSet<CardBank>();
        }

        public int EventId { get; set; }
        public string EventName { get; set; }
        public DateTime? EventDate { get; set; }
        public int? ContactId { get; set; }

        public virtual Contacts Contact { get; set; }
        public virtual ICollection<CardBank> CardBank { get; set; }
    }
}
