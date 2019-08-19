using EpamTraining1;
using EpamTraining1.Task1;
using EpamTraining1.Task2;
using System;
using System.Collections.Generic;

namespace EpamTasks
{
    public class MenuFirstTraining
    {
        public void PrintTrainings()
        {
            var menuTrainings = new Dictionary<string, string>();
            menuTrainings.Add("1", "Rectangle");
            menuTrainings.Add("2", "Generated Rectangle using Auto-Implemented Properties");
            menuTrainings.Add("3", "Circle");
            menuTrainings.Add("4", "Static Circle and Rectangle");
            menuTrainings.Add("5", "Complex Numbers");
            foreach (KeyValuePair<string, string> entry in menuTrainings)
            {
                Console.WriteLine("****" + entry + "*****");
            }

        }
            public void PrintAll(params IRunnable[] array)
            {
            int i = 1;
            foreach (var item in array)
            {
                Console.WriteLine($"{i}");
                item.Run();
                i++;
            }
            
        }
    }
}
