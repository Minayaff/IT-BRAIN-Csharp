using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace FirstApp
{
    internal class Program
    {
        public static void Main()
        {
            //Test test1 = new Test("dsvsdv",12);
            //Test test2 = new Test("fdvdfvdf",18);
            //Test test3 = new Test("dfbdfb dfbdfbdf",20);
            //Test test4 = new Test("vdsvdfbvdfbvdfbvdf",30);
            //Console.WriteLine(test.Name);
            Developer developer = new Developer("sdvsdv", "dfvgdfv");
            developer.Age = 18;
            developer.Salary = 2000;
            developer.Position = "Senior";
            developer.CalculateBonus();
            developer.Gender = true;
            developer.DeveloperCoding();
            developer.ProgrammingLang = "C#";
            Console.WriteLine(developer.TotalSalary); ;

            //Employee employee = new Employee("rgrdgvdr","dfbgvrdfbgdf");

            Accounter accounter = new Accounter("dscsdc", "sdcvds");
            accounter.Age = 20;
            accounter.Salary = 1000;
            accounter.Position = "Muhasib";
            accounter.CalculateBonus();
            accounter.Gender = false;
            Console.WriteLine(accounter.TotalSalary);
        }
        #region Static ctor
        class Test
        {
            public byte Age { get; set; }
            public string Name { get; set; }
            public string MiddleName { get; set; }
            public string HomeAdress { get; set; }
            public Test(string name, byte age)
            {
                Age = age;
                Name = name;
                Console.WriteLine("Adi constuctor");
            }
            static Test()
            {
                Console.WriteLine("Static constuctor");
            }

            //overload -method signature esaslanan. nedir? parametr sayi ve tipine gore ferqli
            public void Calculate(int x, int y)
            {
                Console.WriteLine(x + y);
            }
            public void Calculate(int x, int y, int z)
            {
                Console.WriteLine(x + y + z);
            }
            public void Calculate(long x, long y)
            {
                Console.WriteLine(x + y);
            }

        }
        #endregion

        public sealed class Test22
        {
            public int dhbhrbdvd { get; set; }
        }

        public abstract class Employee //base class
        {
            public string Name { get; set; }
            public string Surname { get; set; }
            public byte Age { get; set; }
            public string Position { get; set; }
            public int Salary { get; set; }
            public decimal TotalSalary { get; set; }
            public bool Gender { get; set; }
            public Employee(string name, string surname)
            {
                Name = name;
                Surname = surname;
            }

            public virtual decimal CalculateBonus()
            {
                decimal bonus = 0;
                if (Position == "Junior")
                {
                    bonus = Convert.ToDecimal(Salary * 0.5);
                }
                else if (Position == "Middle")
                {
                    bonus = Convert.ToDecimal(Salary * 1.5);
                }
                else if (Position == "Senior")
                {
                    bonus = Convert.ToDecimal(Salary * 2.5);
                }
                else
                {
                    bonus = 0;
                }
                TotalSalary = bonus + Salary;
                return bonus;
            }

            public abstract decimal CalculateBonus2();



        }
        public class Developer : Employee   //derived class
        {
            public string ProgrammingLang { get; set; }
            public void DeveloperCoding()
            {
                Console.WriteLine("Codinggggg");
            }

            public override decimal CalculateBonus2()
            {
                throw new NotImplementedException();
            }

            public Developer(string nm, string srname) : base(nm, srname) { }

        }

        public class Accounter : Employee
        {
            public Accounter(string nm, string srname) : base(nm, srname) { }

            public override decimal CalculateBonus()
            {
                decimal bonus = 0;
                if (Position == "Muhasib")
                {
                    bonus = Convert.ToDecimal(Salary * 0.01);
                }
                else if (Position == "Aparici muhasib")
                {
                    bonus = Convert.ToDecimal(Salary * 0.05);
                }
                TotalSalary = bonus + Salary;
                return bonus;
            }

            public override decimal CalculateBonus2()
            {
                throw new NotImplementedException();
            }
        }

       
    }
}
