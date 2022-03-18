using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Models
{
    class Car: MotoredVehicle
    {
        public int engineSize;

        public Car()
        {}

        public Car(string make, string model)
        {
            Console.WriteLine("2cu ctor isledi");

            this.make = make;
            this.model = model;
        }

        public Car(string make, string model, string year):this(make, model)
        {
            Console.WriteLine("3cu ctor isledi");

            this.year = year;
        }

        public Car(string make, string model, string year, string color, int engineSize):this(make, model, year)
        {
            Console.WriteLine("4cu ctor isledi");
            Console.WriteLine(this.color);
            Console.WriteLine(color);

            this.color = color;
            this.engineSize = engineSize;
            Console.WriteLine(this.color);
        }
    }
}
