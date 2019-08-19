using System;
using System.Collections.Generic;
using System.Text;

namespace EpamTraining2.Task2
{
    public class Square : Figure
    {
        public Square(double x, double y) : base(x, y)
        {
        }
        public override void Draw()
        {
            Console.WriteLine("This is a class" + GetType().Name);
        }
    }
}
