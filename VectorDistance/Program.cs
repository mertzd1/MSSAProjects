using System;

namespace VectorDistance
{
    class Program
    {
        static void Main(string[] args)
        {
            Points2D[] points2D = new Points2D[100];
            for (int i = 0; i < points2D.Length; i++)
            {
                points2D[i] = new Points2D();
            }
            findClosest2D(points2D);

            Points3D[] points3D = new Points3D[1000];
            for (int i = 0; i < points3D.Length; i++)
            {
                points3D[i] = new Points3D();
            }
            findClosest3D(points3D);

           
        }

        public static void findClosest2D(Points2D[] points)
        {
            double shortest = 100;
            Points2D sp1 = null;
            Points2D sp2 = null;
            for (int x = 0; x < points.Length; x++)
            {
                for (int y = x+1; y < points.Length; y++)
                {
                    Points2D p1 = points[x];
                    Points2D p2 = points[y];

                    double distance = Math.Sqrt((p2.x - p1.x)* (p2.x - p1.x) + (p2.y - p1.y)* (p2.y - p1.y));
                    if(distance <shortest)
                    {
                        shortest = distance;
                        sp1 = p1;
                        sp2 = p2;
                    }

                }
               
            }
            Console.WriteLine($"The closest points in a 2D array are Point 1 at: {sp1}, and Point 2 at: {sp2}\nThe distance between them is: {shortest.ToString("#.###")}");
        }

        public static void findClosest3D(Points3D[] points)
        {
            double shortest = 100;
            Points3D sp1 = null;
            Points3D sp2 = null;

            for (int x = 0; x < points.Length; x++)
            {
                for (int y = x+1; y < points.Length; y++)
                {
                    
                    Points3D p1 = points[x];
                    Points3D p2 = points[y];

                    double distance = Math.Sqrt((p2.x - p1.x) * (p2.x - p1.x) + (p2.y - p1.y) * (p2.y - p1.y) + (p2.z - p1.z) * (p2.z - p1.z));

                    if(distance<shortest)
                    {
                        shortest = distance;
                            sp1 = p1;
                            sp2 = p2;
                    }
                }
            }
            Console.WriteLine($"\nThe closest points in a 3D array are Point 1 at: {sp1}\nand Point 2 at: {sp2};\nThe distance bewtween them is: {shortest.ToString("#.###")}");
        }
    }
}
