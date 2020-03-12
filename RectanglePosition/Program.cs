using System;
using System.Linq;

namespace RectanglePosition
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] rectnagleOneCoordinates = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            //int[] rectangleTwoCoordinates = Console.ReadLine().Split().Select(int.Parse).ToArray();

            //Rectangle rectangleOne = new Rectangle(rectnagleOneCoordinates[0], rectnagleOneCoordinates[1], rectnagleOneCoordinates[2], rectnagleOneCoordinates[3]);
            //Rectangle rectangletwo = new Rectangle(rectangleTwoCoordinates[0], rectangleTwoCoordinates[1], rectangleTwoCoordinates[2], rectangleTwoCoordinates[3]);
            var r1 = ReadRectangle();
            var r2 = ReadRectangle();
            bool isInside = IsInside(r1, r2);

            if (isInside)
            {
                Console.WriteLine("Inside");
            }
            else
            {
                Console.WriteLine("Not inside");
            }
        }

        public static Rectangle ReadRectangle()
        {
            double[] coordinates = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            Rectangle rectangle = new Rectangle
            {
                Top = coordinates[0],
                Left = coordinates[1],
                Width = coordinates[2],
                Height = coordinates[3]
            };
            return rectangle;
        }

        public static bool IsInside(Rectangle r1, Rectangle r2)
        {
            return r1.Left >= r2.Left && r1.Right <= r2.Right && r1.Top <= r2.Top && r1.Bottom <= r2.Bottom;
        }
    }
}
