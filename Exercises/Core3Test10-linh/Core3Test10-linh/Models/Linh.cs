using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Linq;
using System.Web;

namespace Core3Test10_linh.Models
{
    public class Linh
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Car { get; set; }
        public int CarYear { get; set; }

        static void Main(string[] args)
        {
            foreach (string Name in Linh)
            {
                Console.WriteLine(value: $"{Linh.Name} {Linh.Age} : {Linh.Car} {Linh.CarYear}");
            }
            Console.ReadLine();
        }
    }
}