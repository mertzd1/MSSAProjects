using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismC
{
    //a BMW is a Car this is inheritance
    class BMW : Car
    {
        private string Brand =  "BMW";
        public string Model { get; set; }
        public BMW()
        {

        }

        public BMW(int horsePower, string color, string model):base(horsePower, color)
        {
            
            this.Model = model;
        }

        //using the new keyword hides the base class
        public new void ShowDetails()
        {
            Console.WriteLine($"The {Model} {Brand} is {Color} and it has {HorsePower} horsepower.");
        }
         //sealed must be done before override this will not work with virtual
        public sealed override void Repair()
        {
            Console.WriteLine($"The {Model} BMW was repaired");
           
        }

    }
}
