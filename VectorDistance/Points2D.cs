using System;
using System.Collections.Generic;
using System.Text;

namespace VectorDistance
{
    class Points2D
    {
        public double x;
        public double y;

        public Points2D()
        {
            Random rnd = new Random();
            //next double gives us a random number between 0.0 and 1.0 for example .7482893429384
            // when we muliply it by 100 we would get 74.86 this greatly decreases our odds of getting a 
            // randomly duplicate number
            this.x = rnd.NextDouble() *100; 
            this.y = rnd.NextDouble()*100;
        }

        public override string ToString()
        {
            return $"X {x.ToString("#.##")} , Y {y.ToString("#.##")}"; //the ToString(#.##) sets the decimal places
        }
    }
}
