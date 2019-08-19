using System;
using System.Collections.Generic;
using System.Text;

namespace EpamTraining2.Task3
{
    public class Square : Figure
    {
        public override void Draw()
        {
            Console.WriteLine("This is a inherited class" + GetType().Name);
        }
    }
}
