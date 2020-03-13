using System;
using System.Linq;

namespace IntersectionOfCircles
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] circleOneData = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            double[] circleTwoData = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            double circleOneX = circleOneData[0];
            double circleOneY = circleOneData[1];
            double circleOneRadius = circleOneData[2];
            double circleTwoX = circleTwoData[0];
            double circleTwoY = circleTwoData[1];
            double circleTwoRadius = circleTwoData[2];

            var centerPointOne = new Point(circleOneX, circleOneY);
            var centerPointTwo = new Point(circleTwoX, circleTwoY);
            Circle circleOne = new Circle(centerPointOne, circleOneRadius);
            Circle circleTwo = new Circle(new Point(circleTwoX, circleTwoY), circleTwoRadius);

            if(Intersect(circleOne, circleTwo))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }

        public static double CalculateDistance(Point p1, Point p2)
        {
            double a = Math.Abs(p1.X - p2.X);
            double b = Math.Abs(p1.Y - p2.Y);
            double c = Math.Sqrt(a * a + b * b);
            return c;
        }

        public static bool Intersect(Circle c1, Circle c2)
        {
            double distance = CalculateDistance(c1.Center, c2.Center);

            if (distance > c1.Radius + c2.Radius)
            {
                return false;
            }
            return true;
        }
    }
}
