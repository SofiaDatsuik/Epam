using System;
using System.Collections.Generic;
using System.Text;

namespace EpamTraining1.Task3
{
    public class Circle : IRunnable
    {
        private const double PI = 3.14;
        public double Length { get; private set; }
        public double Area { get; private set; }

        public void GetArea(int radius)
        {
            Area = radius * radius * PI;
        }

        public void GetLength(int radius)
        {
            Length = 2 * radius * PI;
        }

        public void Run()
        {
            System.Console.WriteLine($"The length of circle: {Length} and area of this circle {Area}");
        }
    }
}
