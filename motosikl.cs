using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Task4
{
    internal class motosikl
    {
        public string Brend;
        public string Model;
        public short Year;
        public short Maxspeed;
        public string HasSidecar;
        public motosikl(string brend, string model, short year, short maxspeed, string hasSidecar)
        {
            Brend = brend;
            Model = model;
            Year = year;
            Maxspeed = maxspeed;
            HasSidecar = hasSidecar;
        }
        public void PrintSpeed()
        {
            if (Maxspeed > 110) 
            { Console.WriteLine("Suret oldurur"); }
            else { Console.WriteLine("Bele davam edin"); }
        }
        public void PrintModel()
        {
            Console.WriteLine($"{ Brend}, {Model}, {Year},{Maxspeed},{HasSidecar}");
        }
    }
}

