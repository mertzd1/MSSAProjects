using System;
using System.Collections.Generic;

namespace PersonalTouchMVC.Models
{
    public partial class Pictures
    {
        public int PictureId { get; set; }
        public string Url { get; set; }
        public string PictureName { get; set; }
        public int? TimesPhotoSelected { get; set; }
    }
}
