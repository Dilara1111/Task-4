using Microsoft.VisualBasic.FileIO;
using System;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Xml.Linq;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  1) Person classı olsun
            //  Name, Surname, Age, İsAdult propertyləri olsun. Və name, surname, age parametrlərini qəbul edən Constructoru olsun.
            //  Obyekt yarananda əgər yaşı 18dən böyükdürsə İsAdult - ı true əks halda false olsun.
            //  2) Brend,Model,İl,FuelType və Rəng property-ləri olan Car klasınız olsun
            //Object yarananda Brend,Model,FuelType,İl və Rəng attributlarını ötürün.
            //Objectdə PrintInfo Metodunuz olsun onu call edən zaman
            //bütün məlumatları ekrana çap etsin
            //  3) Car və Motorcycle adlı klasınız olsun və Model, Brend, Year, MaxSpeed propertyləri olsun
            //bundan əlavə Car klasının NumSeats,Motorcycle klasının isə HasSidecar propertyisi olsun

            //Obyekt yarandıqdan sonra Əgər sürət 110 - dan böyükdürsə ekrana "Suret oldurur" əks halda "Bele davam edin"
            //yazısı çap olunsun

            //  4) User classı olsun, içində fantaziyanıza görə propertylər və əsas string Name;
            //string Password Propertyləri olsun. Və
            //public bool IsPasswordValid() methodu olsun. Bu method, əgər passvordun uzunluğu 6dan qısadırsa, və ya passwordun daxilində rəqəm
            //yoxdursa və ya əgər Passvordun daxilində Name vardırsa false, əks halda true return eləsin.Valid password uzunluğu 6dan uzun, içində
            //rəqəm olan və userin adının passvordun içində keçmədiyi passvorddur.
            Console.WriteLine("Task #1");
            
            Person person = new Person("Dilara", "Huseynova", 35);
            Console.WriteLine(person.Name + " " + person.Surname + " " + person.Age + " " + person.IsAdult);
            mashin mercedes = new mashin("Mercedes", "C class",2015, "oil","white");
            mashin kia = new mashin("KIA", "cerato", 2020, "oil", "white");
            mercedes.PrintInfo();
            kia.PrintInfo();
            Car1 bmw = new Car1("BMW", "dhjs", 2011, 109,"jhgdf");
            bmw.PrintSpeed();
            motosikl moto = new motosikl("APILIA", "MoTo", 2021, 215, "kjhedh");
            moto.PrintSpeed();
            bmw.PrintModel();
            moto.PrintModel();
            User dilara = new User("Dilara", "kjhsd@lkjds.com", "Dilara");
            dilara.IspassWordValid();
            
           


        }
    }
   

}