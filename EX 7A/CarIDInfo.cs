using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismC
{
    //this class has a 'is a relationship'
    class CarIDInfo
    {
        public int IDNum { get; set; } = 0; //this gives each car a unique id
        public string Owner { get; set; } = "No Owner";
    }
}
