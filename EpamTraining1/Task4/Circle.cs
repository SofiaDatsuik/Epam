using System;
using System.Collections.Generic;
using System.Text;

namespace EpamTraining1.Task4
{
    public static class Circle1
    {
        public static double Radius { get; set; }

        private static double GetArea() => Radius * Radius * Math.PI;

        private static double GetLength() => 2 * Radius * Math.PI;

        public static void PrintData()
        {
            System.Console.WriteLine("In the length of circle " + GetLength() + " and area of this circle " + GetArea());
        }
    }
}
