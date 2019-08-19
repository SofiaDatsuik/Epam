using EpamTasks;
using EpamTraining1.Task1;
using EpamTraining1.Task3;
using EpamTraining1.Task4;
using EpamTraining1.Task5;
using EpamTraining2;
using EpamTraining2.Task1;
using EpamTraining2.Task2;
using System;
using System.Collections.Generic;
using System.Text;
using Rectangle = EpamTraining2.Task1.Rectangle;

namespace MyRunner
{
    public class Menu
    {
        private int choice;
        MenuFirstTraining menuFirst = new MenuFirstTraining();
        MenuSecondTraining menuSecond = new MenuSecondTraining();
        public void PrintTrainings()
        {
            var menuTrainings = new Dictionary<string, string>();
            menuTrainings.Add("1", "First Training");
            menuTrainings.Add("2", "Second Training");
            foreach (KeyValuePair<string, string> entry in menuTrainings)
            {
                Console.WriteLine("****" + entry + "*****");
            }
            Console.WriteLine("Enter number");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    menuFirst.PrintTrainings();
                    CreateDataFirstTraining();
                    break;
                case 2:
                    Console.WriteLine("Case 2");
                    menuSecond.PrintTrainings();
                    CreateDataSecondTraining();
                    break;
                default:
                    Console.WriteLine("Incorrect input");
                    break;
            }

        }
        public void CreateDataFirstTraining()
        {
            var leftPoint = new Point(1, 9);
            var rightPoint = new Point(9, 4);
            var rectangle1 = new EpamTraining1.Task1.Rectangle(leftPoint, rightPoint);
            var rectangle2 = new EpamTraining1.Task2.Rectangle2();
            rectangle2.LeftUpper = leftPoint;
            rectangle2.RightLower = rightPoint;
            var circle = new Circle();
            circle.GetArea(3);
            circle.GetLength(3);
            menuFirst.PrintAll(rectangle1, rectangle2, circle);
            Console.WriteLine("4");
            Circle1.Radius = 15;
            Circle1.PrintData();
            EpamTraining1.Task4.Rectangle.GetArea(leftPoint, rightPoint);
            EpamTraining1.Task4.Rectangle.GetPerimeter(leftPoint, rightPoint);
            EpamTraining1.Task4.Rectangle.PrintData();
            var complexNumber = new ComplexNumber();
            var complexNumbers1 = new ComplexNumber(2, 4);
            var complexnumbers2 = new ComplexNumber(1, 9);
            complexNumber = complexNumbers1 * complexnumbers2;
            complexNumber.Display();
            complexNumber = complexNumbers1 / complexnumbers2;
            complexNumber.Display();

        }
        public void CreateDataSecondTraining()
        {
            var rectangle = new Rectangle();
            Console.WriteLine("1");
            rectangle.Draw();
            var square = new EpamTraining2.Task1.Square();
            square.Draw();
            Console.WriteLine("2");
            var rectangle1 = new EpamTraining2.Task2.Rectangle(3, 5);
            rectangle1.Draw();
            var square1 = new EpamTraining2.Task2.Square(3, 7);
            square1.Draw();
            Console.WriteLine("3");
            var figure = new EpamTraining2.Task3.Figure();
            figure.Draw();
            var rectangle3 = new EpamTraining2.Task3.Rectangle();
            rectangle3.Draw();
            var square3 = new EpamTraining2.Task3.Square();
            square3.Draw();

            var figure4 = new EpamTraining2.Task4.Figure();         
            var rectangle4 = new EpamTraining2.Task4.Rectangle();
            var square4 = new EpamTraining2.Task4.Square();
            Console.WriteLine("4");
            menuSecond.DrawAll(figure4, rectangle4, square4);
        }
    }
}
