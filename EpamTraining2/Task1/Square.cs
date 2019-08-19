using System;
using System.Collections.Generic;
using System.Text;

namespace EpamTraining2.Task1
{
    public class Square : Figure
    {
        public override void Draw()
        {
            Console.WriteLine("This is a class" + GetType().Name);
        }
    }
}
