using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismC
{
    class M3: BMW
    {
        public M3(int horsePower, string color, string model) : base(horsePower, color, model)
        {

            this.Model = model;
        }
        /* when I sealed the BMW class it gave me an error here.
        public override void Repair()
        {
            base.Repair();
        }*/
    }
}
