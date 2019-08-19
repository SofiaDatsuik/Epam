using System;
using System.Collections.Generic;
using System.Text;

namespace EpamTraining1.Task5
{
    public class ComplexNumber
    {
        public double Real { get; private set; }
        public double Imagine { get; private set; }

        public ComplexNumber()
        {
        }

        public ComplexNumber(double real, double img)
        {
            Real = real;
            Imagine = img;
        }

        public static ComplexNumber operator *(ComplexNumber left, ComplexNumber right)
        {
            return new ComplexNumber(left.Real * right.Real - left.Imagine * right.Imagine, left.Real * right.Imagine + left.Imagine * right.Real);
        }
        public static ComplexNumber operator /(ComplexNumber left, ComplexNumber right)
        {
            if ((right.Real == 0.0f) && (right.Imagine == 0.0f))
                throw new DivideByZeroException("Can't divide by zero Complex number");

            return new ComplexNumber((left.Real * right.Real + left.Imagine * right.Imagine) 
                / (Math.Pow(right.Real, 2) + Math.Pow(right.Imagine, 2)),
                (left.Imagine * right.Real - left.Real * right.Imagine) 
                / (Math.Pow(right.Real, 2) + Math.Pow(right.Imagine, 2)));
        }
        public void Display()
        {
            Console.WriteLine("{0} " + " {0}i", Real, Imagine);
        }
    }
}
