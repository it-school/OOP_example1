using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_example1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            /*
            student1.FIO = "User";
            student1.email = "bill@gmail.com";
            student1.phone = "+380 48 777-55-33";
            student1.age = 16;
            student1.registrationDate = DateTime.Now;
                        
                        Console.WriteLine(student1.FIO);
                        Console.WriteLine(student1.email);
                        Console.WriteLine(student1.phone);
                        Console.WriteLine(student1.age);
                        Console.WriteLine(student1.registrationDate);
                       
            student1.Print();
             */

            Student student2 = new Student("Name Surname", "gates@gmail.com", "+678098765434", 150, DateTime.Now);
            Console.WriteLine(student2.ToString());

            Student student3 = new Student("Name1", "mail@mail.com", "8-800-500-5-500", 25);
            Console.WriteLine(student3.ToString());
            student3.Age = 120;
            Console.WriteLine(student3);


            Fraction drob1 = new Fraction();
            Console.WriteLine(drob1);

            Fraction drob2 = new Fraction(2);
            Console.WriteLine(drob2);

            Fraction drob3 = new Fraction(3, 5);
            Console.WriteLine(drob3);
            drob3.Reverse();
            Console.WriteLine(drob3);

            drob2.Reverse();
            drob3.Reverse();

            Console.WriteLine("\n---------------------\n");
            Console.WriteLine(drob2);
            Console.WriteLine(drob3);
            drob3.Add(drob2);
            Console.WriteLine(drob3);

            drob3.Mult(drob2);
            Console.WriteLine(drob3);
            drob3.Mult(3);
            Console.WriteLine(drob3);

            Fraction drob4 = new Fraction(3,6);
            drob3.Mult(drob4);
            Console.WriteLine(drob3);


            drob3.Simplify();
            Console.WriteLine(drob3);

            Fraction drob5 = new Fraction(45, 75);
            drob5.Simplify();
            Console.WriteLine(drob5);

        }

    }
}
