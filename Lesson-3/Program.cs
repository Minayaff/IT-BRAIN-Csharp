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
            var hello = "Salam insan ";
            Console.WriteLine(hello);
            Console.WriteLine(hello);
            Console.WriteLine(hello);
            Console.WriteLine(hello);
            Console.WriteLine(hello);
            Console.WriteLine(hello);
            Console.WriteLine(hello);





            Console.WriteLine("Zehmet olmasa birinci ededi daxil edin");
            int num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Zehmet olmasa ikinci ededi daxil edin");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Zehmet olmasa simvolu daxil edin");
            string symb = Console.ReadLine();

            int result=0;
            if (symb == "+")
            {
                result = num1 + num2;
            }
            Console.WriteLine(result);

            //else if (symb == "-")
            //{
            //    Console.WriteLine(num1 - num2);
            //}
            //else if (symb == "*")
            //{
            //    Console.WriteLine(num1 * num2);
            //}
            //else if (symb == "/")
            //{
            //    Console.WriteLine(num1 / num2);
            //}
            //else
            //{
            //    Console.WriteLine("Daxil etdiyiniz isare sistemde yoxdur");
            //}

            //if (num1 > 18)
            //{
            //    Console.WriteLine("Salam genc");
            //}
            //else
            //{
            //    Console.WriteLine("18 yasdan asagisiz");
            //}

            //const int x = 30;

        }
    }
}
