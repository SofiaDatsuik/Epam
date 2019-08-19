using System;
using System.Collections.Generic;
using System.Text;

namespace EpamTraining2.Task2
{
    public abstract class Figure
    {
        public double X { get; }
        public double Y { get; }

        protected Figure(double x, double y)
        {
            X = x;
            Y = y;
        }
        public abstract void Draw();
    }
}
