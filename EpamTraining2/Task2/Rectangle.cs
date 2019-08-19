using System;
using System.Collections.Generic;
using System.Text;

namespace EpamTraining2.Task2
{
   public class Rectangle : Figure
    {
        public Rectangle(double x, double y) : base(x, y)
        {
        }

        public override void Draw()
        {
            Console.WriteLine("This is a class" + GetType().Name);
        }
    }
}
