using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismC
{
    class Audi:Car
    {
        private string Brand = "Audi";
        public string Model { get; set; }
        public Audi()
        {

        }

        public Audi(int horsePower, string color, string model) : base(horsePower, color)
        {

            this.Model = model;
        }

        public void ShowDetails()
        {
            Console.WriteLine($"The {Model} {Brand}  color of the car is {Color} and it has {HorsePower} horsepower.");
        }

        public override void Repair()
        {
            Console.WriteLine($"The {Model} Audi was repaired");

        }
    }
}
