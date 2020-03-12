using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceBetweenTwoPoints
{
    public class Point
    {
        public double X { get; set; }
        public double Y { get; set; }


        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }
        public override string ToString()
        {
            return string.Format("({0}, {1})", this.X, this.Y);
        }

        public static double CalculateDistance(Point p1, Point p2)
        {
            return 0;
        }
    }
}
