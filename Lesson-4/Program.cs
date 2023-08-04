using System;
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
            #region Cinema App
            //Console.WriteLine("Yasinizi daxil edin");
            //byte age =Convert.ToByte(Console.ReadLine());
            //Console.WriteLine("Heftenin gunun daxil edin ");
            //string weekOfDay=Console.ReadLine();
            //int senior = 7;
            //int adult = 10;
            //int child = 5;
            //int ticketPrice = 0;

            //if(age <0 || age == 0)
            //{
            //    Console.WriteLine("Yasinizi duzgun daxil edin");

            //}
            //else
            //{
            //    if (weekOfDay == "Wednesday")
            //    {
            //        if (age >= 65)
            //        {
            //            ticketPrice = senior - 2;
            //            Console.WriteLine("Your ticket price is" + ticketPrice+ "$");
            //        }
            //        else if (age >= 13)
            //        {
            //            ticketPrice = adult - 2;
            //            Console.WriteLine($"Your ticket price is {ticketPrice}");
            //        }
            //        else if (age >= 0)
            //        {
            //            ticketPrice = child - 2;
            //            Console.WriteLine($"Your ticket price is {ticketPrice}");
            //        }
            //    }
            //    else
            //    {
            //        if (age >= 65)
            //        {
            //            ticketPrice = senior;
            //            Console.WriteLine($"Your ticket price is {ticketPrice}");
            //        }
            //        else if (age >= 13)
            //        {
            //            ticketPrice = adult;
            //            Console.WriteLine($"Your ticket price is {ticketPrice}");
            //        }
            //        else if (age >= 0)
            //        {
            //            ticketPrice = child;
            //            Console.WriteLine($"Your ticket price is {ticketPrice}");
            //        }
            //    }

            //}
            #endregion

            #region Lesson start

            #region For dovru , break,continue
            //int cem = 0;
            //for (int i = 1; i <= 10; i++)
            //{
            //    cem += i;

            //cem += i;  ===   //cem=cem+i
            //cem=0+1   1
            //cem=1+2   3
            //cem=3+3   6
            //cem=6+4   10
            //cem=10+5  15
            //}
            //Console.WriteLine(cem);

            //for (int i = 1; i < 10; i++)
            //{
            //    if (i == 5)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(i);

            //}

            #endregion

            #region Switch case
            //Console.WriteLine("Heftenin gununu daxil et");
            //byte day = Convert.ToByte(Console.ReadLine());
            //switch (day)
            //{
            //    case 1:
            //        Console.WriteLine("Monday");
            //        break;
            //    case 2:
            //        Console.WriteLine("Tuesday");
            //        break;
            //    case 3:
            //        Console.WriteLine("Wednesday");
            //        break;
            //    case 4:
            //        Console.WriteLine("Thursday");
            //        break;
            //    case 5:
            //        Console.WriteLine("Friday");
            //        break;
            //    case 6:
            //        Console.WriteLine("Saturday");
            //        break;
            //    case 7:
            //        Console.WriteLine("Sunday");
            //        break;
            //    default:
            //        Console.WriteLine("Bele bir gun yoxdur");
            //        break;
            //}

            //if (day == 1)
            //{
            //    Console.WriteLine("Monday");
            //}
            //else if (day == 2)
            //{
            //    Console.WriteLine("Tuesday");
            //}
            //else if (day == 3)
            //{
            //    Console.WriteLine("Wednesday");
            //}
            //else
            //{
            //    Console.WriteLine("Bele bir heftenin gunu yoxdur");
            //}
            #endregion


            //int x = 5;

            string[] qrup114 = { "Nigar", "Emil", "Diana", "ilkin","Elxan","Resad","Nasir","Ehliman"};

            //Console.WriteLine(qrup114[0]); //Nigar 
            //foreach (var item in qrup114)
            //{
            //    if (item.ToUpper() == "ilkin".ToUpper())
            //    {
            //    Console.WriteLine($"{item} bu telebe qrupda movcuddur");
            //    }
            //}

            for (var i = 0; i < qrup114.Length; i++)
            {
                int index = i;
                string student = qrup114[i];

                //Console.WriteLine(qrup114[i]);
                //qrup114[0] //Nigar
                //qrup114[1] //Emil
                //qrup114[2] //Diana
            }

            int[] numbers = { 5, 8, 12, 3, 5, 9, 6, 1 ,5,9,3,5};
            int count = 0;
            foreach (var item in numbers)
            {
                if (item == 5)
                {
                    count++;
                }
            }
            Console.WriteLine(count + " defe tekrar olunub");





            #endregion
        }
    }
}
