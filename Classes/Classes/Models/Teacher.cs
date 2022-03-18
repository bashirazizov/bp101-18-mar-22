using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Models
{
    class Teacher : Person
    {
        public string[] subjects;

        public Teacher()
        {
            Console.WriteLine("teacher created");
        }
        public Teacher(string name, string surname) : this()
        {
            Console.WriteLine("teacher data set");
            this.name = name;
            this.surname = surname;
        }
        public Teacher(string name, string surname, int age) : base(name, surname, age)
        { }

    }
}
