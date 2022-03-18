using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Models
{
    class Student : Person
    {
        //field

        public int[] marks;

        public Student()
        {
            name = "Bashir";
            surname = "Azizov";
            age = 22;
        }

        public Student(string name)
        {
            this.name = name;
        }
        public Student(string name, string surname, int age)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
        }


        public void PrintInfo()
        {
            Console.WriteLine($"{name} - {surname} - {age}");
        }

        public int GetBirthYear()
        {
            return 2022 - age;
        }
        public int GetAverageMark()
        {
            int sum = 0;

            for (int i = 0; i < marks.Length; i++)
            {
                sum += marks[i];
            }

            return sum / marks.Length;
        }
    }
}
