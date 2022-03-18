using Classes.Models;
using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {

            //Teacher t1 = new Teacher("Elnur", "Huseynov",45);

            ////t1.name = "Mahir";
            ////t1.surname = "Ahmedov";
            ////t1.age = 57;
            ////t1.subjects = new string[] { "history", "english" };

            //Console.WriteLine(t1.name);
            //Console.WriteLine(t1.surname);
            //Console.WriteLine(t1.age);

            //Student st1 = new Student();
            //st1.name = "Mamed";
            //st1.marks = new int[] { 67, 91, 45 };

            //Student st2 = new Student();
            //st2.name = "Isa";
            //st2.surname = "Quliyev";
            //st2.age = 53;
            //st2.marks = new int[] { 100, 83, 71 };

            ////Console.WriteLine(st2.name);

            //Student st3 = new Student("Rasim");

            //Student stu4 = new Student();
            ////stu4.name = "Bagir";
            ////Console.WriteLine(st3.name);
            ////Console.WriteLine(st3.surname);
            ////Console.WriteLine(st3.age);

            //Car c1 = new Car("mercedes","s500","1998","black",5000);

            //Employee emp1 = new Employee();

            //emp1.name = "Isabala";
            //emp1.surname = "Usman";
            //emp1.salary = 1000;

            //Student stu1 = new Student();
            //stu1.name = "Kimbo";
            //stu1.surname = "Slice";

            //Person p1 = new Person();

            //Console.WriteLine(emp1.name);

            //Bike b1 = new Bike();

            //Teacher t1 = new Teacher("Colby", "Covington", 41);


            BankAccount ba = new BankAccount();
            ba.Balance = 50000;
            ba.Code = "1234-5234-1231-5311";
            ba.Swift = "DBIUQWBYDIUWNDUIQDQWD";
            ba.Bank = "Kapital";

            User user1 = new User();
            user1.Email = "bashir@code.edu.az";
            user1.Fullname = "Bashir Azizov";
            user1.FinCode = "231u23u1iy";
            user1.account = ba;

            Console.WriteLine(user1.account.Balance);

            Console.WriteLine(user1.account.Withdraw(2000));
            Console.WriteLine(user1.account.Deposit(1000));

            Console.WriteLine(user1.account.Balance);

        }
    }
}
