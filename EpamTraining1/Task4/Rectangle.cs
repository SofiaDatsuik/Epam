using EpamTraining1.Task1;
using System;
using System.Collections.Generic;
using System.Text;

namespace EpamTraining1.Task4
{
    public static class Rectangle
    {
        public static double Perimeter { get; private set; }
        public static double Area { get; private set; }

        public static double GetArea(Point left, Point right)
        {
            return Area = (left.Y - right.Y) * (right.X - left.X);
        }

        public static double GetPerimeter(Point left, Point right)
        {
            return Perimeter = 2 * ((left.Y - right.Y) + (right.X - left.X));
        }

        public static void PrintData()
        {
            System.Console.WriteLine($"In the static class the perimeter of rectangle {Perimeter} and area of this rectangle {Area}");
        }
    }
}
