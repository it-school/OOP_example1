using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_example1
{
    class Student
    {
        private String fio;
        private String email;
        private String phone;
        private Byte age;
        private DateTime registrationDate;

        public string Fio { get => fio; set => fio = value; }
        public string Email { get => email; set => email = (value.Contains("@") ? value : ""); }
        public string Phone { get => phone; set => phone = value; }
        public byte Age { get => age; set => age = (value > 80 ? (byte)80 : value); }
        public DateTime RegistrationDate { get => registrationDate; set => registrationDate = value; }

        public Student()
        {
            Fio = "NoName";
            RegistrationDate = DateTime.Now;
        }

        public Student(String FIO, String email, String phone, Byte age, DateTime regDate)
        {
            this.Fio = FIO;
            this.Email = email;
            this.Phone = phone;
            this.Age = age;
            this.RegistrationDate = regDate;
        }

        public Student(String FIO, String email, String phone, Byte age)
    {
        this.Fio = FIO;
        this.Email = email;
        this.Phone = phone;
        this.Age = age;
        this.RegistrationDate = DateTime.Now;
    }


        //public void Print()
        //{
        //    Console.WriteLine(this.Fio);
        //    Console.WriteLine(this.Email);
        //    Console.WriteLine(this.Phone);
        //    Console.WriteLine(this.Age);
        //    Console.WriteLine(this.RegistrationDate);
        //}

        override public String ToString()
        {
            return "\nStudent info:" +
                "\nFIO: " + this.fio +
                "\ne-mail: " + this.email +
                "\nphone: " + this.phone +
                "\nage: " + this.age +
                "\nregistration date: " + this.registrationDate;
        }


    }
}
