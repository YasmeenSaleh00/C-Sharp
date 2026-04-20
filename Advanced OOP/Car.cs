using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_OOP
{
    public class Car
    {
        public string Make { get; set; }
        public int Year { get; set; }
        public string Type { get; set; }
        public double Price { get; set; }
        public string Model { get; set; }
        public string PlateNo { get; set; }
        public string Color { get; set; }

        public  Car(string Make , int Year , string Type ,double Price , string Model , string PlateNo, string Color)
        {
            this.Make = Make;
            this.Year = Year;
            this.Type = Type;
            this.Price = Price;
            this.Model = Model;
            this.PlateNo = PlateNo;
            this.Color = Color;


        }

        public void StartEngine()
        {
            Console.WriteLine("Engine Started");
        }

        public void StopEngine()
        {
            Console.WriteLine("Engine Stopped");
        }
        public void GetCarInfo()
        {
            Console.WriteLine($"Make: {Make}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Year: {Year}");
            Console.WriteLine($"Type: {Type}");
            Console.WriteLine($"Price: {Price}");
            Console.WriteLine($"Plate No: {PlateNo}");
            Console.WriteLine($"Color: {Color}");
        }
    }
}
