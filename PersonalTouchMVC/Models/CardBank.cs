using System;
using System.Collections.Generic;

namespace PersonalTouchMVC.Models
{
    public partial class CardBank
    {
        public int CardId { get; set; }
        public int? EventId { get; set; }
        public string CardFrontImagePath { get; set; }
        public string CardBackImagePath { get; set; }

        public virtual EventDates Event { get; set; }
    }
}
