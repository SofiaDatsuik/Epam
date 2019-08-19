using System;
using System.Collections.Generic;
using System.Text;

namespace EpamTraining1.Task1
{
    public class Point
    {
        public double X { get; private set; }
        public double Y { get; private set; }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }
    }
}
