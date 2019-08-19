using EpamTraining1.Task1;
using System;
using System.Collections.Generic;
using System.Text;

namespace EpamTraining1.Task2
{
    public class Rectangle2 : IRunnable
    {

        public Point LeftUpper { get; set; }

        public Point RightLower { get; set; }

        public double Area
        {
            get
            {
                return (LeftUpper.Y - RightLower.Y) * (RightLower.X - LeftUpper.X);
            }
            set
            {
                _area = value;

            }
        }

        public double Perimetr
        {
            get
            {
                return 2 * ((LeftUpper.Y - RightLower.Y) + (RightLower.X - LeftUpper.X));
            }
            set
            {
                _perimetr = value;
            }
        }

        private double _perimetr;

        private double _area;

        public void Run()
        {
            System.Console.WriteLine($"The perimeter of rectangle {Perimetr} and area of this rectangle {Area}");
        }
    }
}
