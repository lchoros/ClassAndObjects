using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceBetweenTwoPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] points1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            //int[] points2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            //double p1X = points1[0];
            //double p1Y = points1[1];

            //double p2X = points2[0];
            //double p2Y = points2[1];

            //Point point1 = new Point(p1X, p1Y);
            //Point point2 = new Point(p2X, p2Y);
            //Console.WriteLine("{0:f3}", CalculateDistance(point1, point2));

            int numberOfCoordinates = int.Parse(Console.ReadLine());
            Point[] points = new Point[numberOfCoordinates];
            for (int i = 0; i < numberOfCoordinates; i++)
            {
                int[] coordinates = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                int x = coordinates[0];
                int y = coordinates[1];
                points[i] = new Point(x, y);
            }
            var pointsResult = FindClosestPoints(points);

            Console.WriteLine("{0:f3}", CalculateDistance(pointsResult[0], pointsResult[1]));
            foreach (var point in pointsResult)
            {
                Console.WriteLine(point);
            }

        }


        public static Point[] FindClosestPoints(Point[] points)
        {
            double shortestDistance = double.MaxValue;
            Point[] result = new Point[2];
            for (int i = 0; i < points.Length; i++)
            {
                for (int j = i + 1; j < points.Length; j++)
                {
                    double currentDistance = CalculateDistance(points[i], points[j]);
                    if(currentDistance < shortestDistance)
                    {
                        result[0] = points[i];
                        result[1] = points[j];
                        shortestDistance = currentDistance;
                    }
                }
            }
            return result;
        }

        public static double CalculateDistance(Point p1, Point p2)
        {
            double a = Math.Abs(p1.X - p2.X);
            double b = Math.Abs(p1.Y - p2.Y);
            double c = Math.Sqrt(a * a + b * b);
            return c;
        }
    }
}
