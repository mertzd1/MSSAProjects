using System;
using System.Collections.Generic;

namespace PolymorphismC
{
    class Program
    {
        static void Main(string[] args)
        {
            //Polymorphism at work #1: An Audi, BMW
            //can all be use whereever Car is expected. No cast
            //is required becuse an implicit conversion exists from a
            //derived class to its base class.
            var cars = new List<Car>
           {
               new Audi(200, "Blue", "A4"),
               new BMW(250, "Orange", "Z5")
           };
            //Polymorphism at work #2: the virtual method Repair
            // is invoded on each of the derived classes, not the base class
            //this is because we used a virtual Repair in the base class
            //and override the repairs in BMW and Audi
            foreach(var car in cars)
            {
                car.Repair();      
                
            }
            //this show details is from the Car class
            Car bmwZ3 = new BMW(200, "black", "Z3");
            Car audieA3 = new Audi(125, "green", "A3");

            bmwZ3.ShowDetails();
            audieA3.ShowDetails();

            bmwZ3.SetCarIDInfo(1234, "Donald Mertz");
            audieA3.SetCarIDInfo(1235, "Larry Davis");
            bmwZ3.GerCarIDInfo();
            audieA3.GerCarIDInfo();

            //this show details is from the BMW class becuase we called a new BMW not Car
            BMW bmwM5 = new BMW(330, "white", "M5");
            bmwM5.ShowDetails();

            //this tells the compiler to use the Base Car showdetails 
            Car carb = (Car)bmwM5;
            carb.ShowDetails();

            M3 myM3 = new M3(276, "red", "M3");
            myM3.Repair();


               
        }
    }
}
