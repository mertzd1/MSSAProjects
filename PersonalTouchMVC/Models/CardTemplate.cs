using System;
using System.Collections.Generic;

namespace PersonalTouchMVC.Models
{
    public partial class CardTemplate
    {
        public int CardId { get; set; }
        public string CardName { get; set; }
        public string Url { get; set; }
        public int? TimesTemplateSelected { get; set; }
        public string CardCategory { get; set; }
    }
}
