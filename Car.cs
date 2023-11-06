using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task4
{
    internal class Car
    {
        public string Brend;
        public string Model;
        public byte Year;
        public string Fueltype;
        public string Color;
        public Car(string brend, string model, byte year, string fueltype, string color )
        {
            Brend = brend;
            Model = model;
            Year = year;
            Fueltype = fueltype;
            Color = color;
  
        }
        public void PrintInfo(string Brend, string Model, byte Year)
        {
            Console.WriteLine($"{Brend}, {Model}, {Year}");
        }
    }
}
