using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismC
{
    class Car
    {
        public int HorsePower { get; set; }
        public string Color { get; set; }
        //has a 'is a relationship' 
        protected CarIDInfo carIDInfo = new CarIDInfo();

        public void SetCarIDInfo(int idNum, string owner)
        {
            carIDInfo.IDNum = idNum;
            carIDInfo.Owner = owner;
        }
         
        public void GerCarIDInfo()
        {
            Console.WriteLine($"The car has the ID of {carIDInfo.IDNum} and is owned by {carIDInfo.Owner}");
        }

        public Car()
        {
            
        }

        public Car(int horsePower, string color)
        {
            this.HorsePower = horsePower;
            this.Color = color;
        }

        public void ShowDetails()
        {
            Console.WriteLine($"The color of the car is {Color} and it has {HorsePower} horsepower.");
        }

        public virtual void Repair()
        {
            Console.WriteLine("Car was repaired!");
        }
    }

   
}
