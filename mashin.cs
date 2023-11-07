using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class mashin
    {
        public string Brend;
        public string Model;
        public short Year;
        public string Fueltype;
        public string Color;
        public mashin(string brend, string model, short year, string fueltype, string color)
        {
            Brend = brend;
            Model = model;
            Year = year;
            Fueltype = fueltype;
            Color = color;

        }
        public void PrintInfo()
        {
            Console.WriteLine($"{Brend}, {Model}, {Year}, {Fueltype}, {Color}");
        }
    }
}
