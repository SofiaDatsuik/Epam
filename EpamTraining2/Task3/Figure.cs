using System;
using System.Collections.Generic;
using System.Text;

namespace EpamTraining2.Task3
{
    public class Figure
    {
        public virtual void Draw()
        {
            Console.WriteLine("This is parent class" + GetType().Name);
        }
    }
}
