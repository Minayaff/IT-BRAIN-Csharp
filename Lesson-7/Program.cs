using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int x = Calc(4, 8, "*") + 10;
            //Console.WriteLine(x);


            //string welcome = Hello("Nicat") + " welcome";
            //Console.WriteLine(welcome);

            //ArrayList books = new ArrayList();
            //books.Add("C# Nutshell 110azn 15dene");
            //books.Add("C# Yellow book");
            //var book = new
            //{
            //    name = "C# nutshell",
            //    quantity = 15,
            //    price = 110
            //};
            //var book1 = new
            //{
            //    name = "C# yellow book",
            //    quantity = 20,
            //    price = 95
            //};
            //Console.WriteLine(book.name);
            //Console.WriteLine(book.price + " azn");
            //Console.WriteLine(book.quantity +" dene");

            #region Task
            //ArrayList studentList = new ArrayList();
            //while (true)
            //{
            //    Console.WriteLine("Welcome register form");
            //    Console.WriteLine("Name and Surname");
            //    string fullname = Console.ReadLine();
            //    Console.WriteLine("Age");
            //    //byte age = Console.ReadLine() == "" ? Convert.ToByte("0") : Convert.ToByte(Console.ReadLine());

            //    string testAge = Console.ReadLine(); //" " yada  "18"
            //    //if (testAge != "")
            //    //{
            //    //    age = Convert.ToByte(testAge); //"18"
            //    //}
            //    //else
            //    //{
            //    //    age = 0;
            //    //}
            //    byte age = testAge == "" ? Convert.ToByte("0") : Convert.ToByte(testAge);

            //    if (fullname != " " && age >= 17)
            //    {
            //        Console.WriteLine("Score");
            //        byte score = Convert.ToByte(Console.ReadLine());
            //        var student = new
            //        {
            //            fname = fullname,
            //            studentAge = age,
            //            studentScore = score
            //        };
                   
            //        studentList.Add(student);
            //        Console.WriteLine("New student added");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Student not added, Wrong information");
            //    }

               

               
               

            //    //if(age <5)
            //    //{
            //    //    Console.WriteLine("Usaq");
            //    //}
            //    //else
            //    //{
            //    //    Console.WriteLine("boyuk");

            //    //}
            //    //age < 5 ? Console.WriteLine("Usaq") : Console.WriteLine("boyuk");
            //}

            #endregion


            ArrayList carList=new ArrayList();
            var car1 = new
            {
                Type = "Fiat",
                Model = "500",
                Color = "white"
            };
            Console.WriteLine(car1.Type);
            var car2 = new
            {
                Type = "Kia",
                Model = "XXX",
                Color = "black"
            };
            var  car3 = new
            {
                Type = "Hyundai",
                Model = "YYY",
                Color = "red"
            };
            carList.Add(car1);
            carList.Add(car2);
            carList.Add(car3);

            foreach (dynamic item in carList)
            {
                Console.WriteLine(item.Model);
            }
        }

        //return type and void 
        public static int Calc(int num1, int num2, string operation)
        {
            int result=0;
            switch (operation)
            {
                case "+":
                    result = num1 + num2;
                    Console.WriteLine($"{num1} + {num2} = {result}");
                    break;
                case "-":
                    result = num1 - num2;
                    Console.WriteLine(result);
                    break;
                case "/":
                    result = num1 / num2;
                    Console.WriteLine(result);
                    break;
                case "*":
                    result = num1 * num2;
                    Console.WriteLine(result);
                    break;
                default:
                    Console.WriteLine("Sehv operationdur");
                    break;

            }

            return result;
        }

        public static string Hello(string name)
        {

            return $"Hello {name}";
        }
    }
}
