using System;
using System.Collections.Generic;
using System.Text;

namespace EpamTraining2.Task4
{
    public class Figure : IDrawable
    {
        public void Draw()
        {
            Console.WriteLine("This is a class" + GetType().Name);
        }
    }
}
