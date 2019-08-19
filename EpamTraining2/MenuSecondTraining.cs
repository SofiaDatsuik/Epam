using EpamTraining2.Task4;
using System;
using System.Collections.Generic;
using System.Text;

namespace EpamTraining2
{
    public class MenuSecondTraining
    {
        public void PrintTrainings()
        {
            var menuTrainings = new Dictionary<string, string>();
            menuTrainings.Add("1", "Inheritance from abstract method");
            menuTrainings.Add("2", "Readonly properties");
            menuTrainings.Add("3", "Inheritance virtual method");
            menuTrainings.Add("4", "Implemented Interfaces");
            foreach (KeyValuePair<string, string> entry in menuTrainings)
            {
                Console.WriteLine("****" + entry + "*****");
            }
        }
            public void DrawAll(params IDrawable[] array)
            {
            int i = 1;
                foreach (var item in array)
                {
                Console.WriteLine($"{i}");
                item.Draw();
                i++;
                }
            }
        
    }
}
