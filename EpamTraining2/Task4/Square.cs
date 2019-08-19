using System;
using System.Collections.Generic;
using System.Text;

namespace EpamTraining2.Task4
{
    public class Square : Figure, IDrawable
    {
        public new void Draw()
        {
            Console.WriteLine("This is a class" + GetType().Name);
        }
    }
}
