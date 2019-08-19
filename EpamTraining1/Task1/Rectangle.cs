using System;
using System.Collections.Generic;
using System.Text;

namespace EpamTraining1.Task1
{
    public class Rectangle : IRunnable
    {
        #region
        public Point LeftUpper { get; private set; }
        public Point RightLower { get; private set; }
        #endregion

        #region
        public Rectangle(Point leftUpper, Point rightLower)
        {
            LeftUpper = leftUpper;
            RightLower = rightLower;
        }
        #endregion
        #region
        private double GetHeight()
        {
            return LeftUpper.Y - RightLower.Y;
        }

        private double GetWidth()
        {
            return RightLower.X - LeftUpper.X;
        }

        public double GetArea()
        {
            return GetHeight() * GetWidth();
        }
        public double GetPerimeter()
        {
            return 2 * (GetHeight() + GetWidth());
        }

        public void Run()
        {
            System.Console.WriteLine("The perimeter of rectangle " + GetPerimeter() + " and area of this rectangle " + GetArea());
        }
        #endregion
    } }
   /* public static bool IsValidCoordinates(Point leftUpper, Point rightLower)
    {
        bool value = false;
        while (true)
        {
            try
            {
                if (((leftUpper.Y > rightLower.Y) && (leftUpper.X < rightLower.X))) { value = true; }
                

                else if ((leftUpper.Y > 0 && rightLower.Y == 0) && (leftUpper.X == 0 && rightLower.X > 0)) { value = true; }
              
                else if ((leftUpper.Y == 0 && rightLower.Y < 0) && (leftUpper.X == 0 && rightLower.X > 0)) { value = true; }
                return value; 
            }
            catch
            {
                return value;
  */
