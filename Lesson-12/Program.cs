using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;

namespace FirstApp
{
    internal class Program
    {
        public static void Main()
        {
            //Square square = new Square();
            //square.a = 5;
            //square.b = 15;
            //square.CalculateSquare();
            ////square.sahe = 78;
            //Console.WriteLine(square.sahe);

            //Student student = new Student();
            //student.Fullname = "Elxan";
            //student.Email = "elxan@gmail.com";
            //Console.WriteLine(student.Email);

            string name = " ";
            decimal price = 0;
            
            
            if(Validation.NullOrEmpty(name) && Validation.NullOrEmpty(price))
            {
                Medicine me=new Medicine(name, price);

            }
            

        }
      
        
    }
    public class Square
    {
        public int a { get; set; }
        public int b { get; set; }
        public int sahe {
            get
            {
                return _sahe;
            }
        }
        private int _sahe;
        public void CalculateSquare()
        {
            _sahe = a * b;
        }
    }

    public class Student
    {
        public string Fullname { get; set; }
        private string _email { get; set; }
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                try
                {
                    MailAddress mailAddress = new MailAddress(value);
                    _email = value;

                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex);
                }
            }
        }
    }


    public class Medicine
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Count { get; set; }

        public Medicine(string aName, decimal aPrice)
        {
            Name = aName;
            Price = aPrice;
        }

    }
    static class Validation
    {
        public static bool NullOrEmpty(string value)
        {
            if (value.Trim() == null || value.Trim() == "")
            {
                Console.WriteLine("Zehmet olmasa yeniden daxil edin");
                return false;
            }
            return true;
        }
        public static bool NullOrEmpty(decimal price)
        {
            if (price <= 0)
            {
                Console.WriteLine("Qiymet 0-dan kicikdir");
                return false;
            }
            return true;
        }
        public static void NullOrEmpty(int count)
        {
            if (count <= 0)
            {
                Console.WriteLine("Say 0-dan kicik ve ya beraber ola bilmez");
            }
        }


    }

}
