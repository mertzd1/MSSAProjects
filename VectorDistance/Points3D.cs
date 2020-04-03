using System;
using System.Collections.Generic;
using System.Text;

namespace VectorDistance
{
    class Points3D
    {
        public double x;
        public double y;
        public double z;

        public Points3D()
        {
            Random rand = new Random();

            this.x = rand.NextDouble() * 1000;
            this.y = rand.NextDouble() * 1000;
            this.z = rand.NextDouble() * 1000;
        }

        public override string ToString()
        {
            return $"X {x.ToString("#.##")}, Y {y.ToString("#.##")}, Z {z.ToString("#.##")} ";
        }


    }
}
