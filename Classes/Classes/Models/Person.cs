using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Models
{
    class Person
    {
        public string name;
        public string surname;
        public int age;
        public Person()
        {
            Console.WriteLine("Person Yaradildi");
        }
        public Person(string name, string surname, int age)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
        }
    }
}
