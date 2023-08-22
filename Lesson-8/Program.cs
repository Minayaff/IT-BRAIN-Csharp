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
            #region String vs StringBuilder
            //string testString = "Hello!";
            //testString = testString + " This";
            //testString = testString + " is";
            //testString = testString + " c#";
            //testString = testString + " tutorial";
            //Console.WriteLine(testString);

            //StringBuilder stringBuilder = new StringBuilder();
            //stringBuilder.Append("Hello!");
            //stringBuilder.Append(" This");
            //stringBuilder.Remove(2,5);
            //Console.WriteLine(stringBuilder);
            #endregion

            #region Try catch
            //try
            //{
            //    int data = int.Parse("5");
            //    Console.WriteLine("Parse edildi");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Errorunuz cixdi yeniden cehd edin");
            //}
            //finally
            //{
            //    Console.WriteLine("Finally block");
            //}
            #endregion

            //Calc(1, 8, 9, 33, 55, 77, 12, 59); //Params
            #region Ref out
            string person = "dsvdsv";
            Console.WriteLine(person + " orginal data");
            Back(ref person);
            Console.WriteLine(person + " method isledikden sonra num1");
            #endregion
            //Console.WriteLine("Modeli yaz");
            //string model=Console.ReadLine();
            //Console.WriteLine("Color yaz");
            //string color =Console.ReadLine();
            //Console.WriteLine("Type yaz");
            //string type =Console.ReadLine();
            //Console.WriteLine("Price yaz");
            //int price =Convert.ToInt32(Console.ReadLine());
            //Car car = new Car(model, color, type, price);


            Car car1 = new Car("kia", "black", "sedan", 25000);
            Car car2 = new Car("hyundai", "red", "cip", 30000);
            Car car3 = new Car("hyundai ix35", "blue", "cip", 35000);

            List<Car> carList =new  List<Car>();
            carList.Add(car2);
            carList.Add(car1);
            carList.Add(car3);
            //foreach (var item in carList)
            //{
            //    Console.WriteLine(item.Model);
            //}
            Console.WriteLine(carList[0].Model + " " + carList[0].Price);

            //List<int> numbers = new List<int>();
            //numbers.Add(5);
            //numbers.Add(15);
            //numbers.Add(52);
            //numbers.Add(59);
            //foreach (var item in numbers)
            //{
            //    Console.WriteLine(item);
            //}
            //int data3 = numbers[0];

            //car1.Price = 23000;
            //car1.Model = "Kia rio";
            //car1.Type = "sedan";
            //car1.Color = "red";
            //Console.WriteLine(car1.Model);
        }

        #region ref out
        public static void Front(out string data)
        {
            data = "Front";
        }
        public static void Back(ref string data)
        {
            data = "Backend";
        }
        #endregion

        //Params
        public static void Calc(params int[] arr)
        {
            //    int result = 0;
            //    foreach (var item in arr)
            //    {
            //        result += item;
            //    }
            Console.WriteLine(arr.Sum());

         
        }

    }

    class Car
    {
        public Car(string model, string color, string type, int price)
        {
            Model = model;
            Color = color;
            Type = type;
            Price = price;
        }
        public string Model { get; set; }
        public string Color { get; set; }
        public string Type { get; set; }
        public int Price { get; set; }

    }
}
