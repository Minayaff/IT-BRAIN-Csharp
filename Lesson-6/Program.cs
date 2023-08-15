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
            #region boxing unboxing
            //ArrayList arrayList = new ArrayList();
            //ArrayList newArr=new ArrayList();
            //newArr.Add("dsfsdv");
            //newArr.Add(8);
            //newArr.Add(100);

            //arrayList.Add("salam");
            //arrayList.Add(5); //1
            //arrayList.Add(5.5);
            //arrayList.Add(newArr);
           
            //if(arrayList[1] is int)
            //{
            //    int num1 = (int)arrayList[1]; //unboxing
            //    Console.WriteLine(num1);

            //}

            //boxing;
            //int num1 = 8;
            //object data = num1; //value type to reference type (boxing)
            #endregion


            #region Casting (Implicit and explicit)
            //casting =value type lar arasinda olur
            byte age = 15;
            int c = age; //implicit

            int x = 58;
            byte y = (byte) x; //explicit casting
                               //Console.WriteLine(y);

            //float x1 = 3.75F;
            //byte x2 = (byte)x1;
            //Console.WriteLine(x2);
            #endregion

            #region Stack,Queue,Hashtable,SortedList
            //Stack myStack = new Stack(); //LIFO
            //myStack.Push(1);
            //myStack.Push(2);
            //myStack.Push(3);
            //myStack.Push("sdvdgsgvdg");
            //Console.WriteLine(myStack.Count +" count");
            //Console.WriteLine(myStack.Pop() +" silindi");
            //Console.WriteLine(myStack.Pop() +" silindi");

            //foreach (var item in myStack)
            //{
            //    Console.WriteLine(item);
            //}

            //Queue queue = new Queue(); //FIFO
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);
            //Console.WriteLine(queue.Dequeue() + " silindii");
            //foreach (var item in queue)
            //{
            //    Console.WriteLine(item + "elemetler");
            //}

            // SORTEDLIST- azdan cox 1....6
            //Hashtable ht = new Hashtable(); // coxdan aza cixarir 6...1
            //ht.Add(3, "Resad");
            //ht.Add(2, "Nasir");
            //ht.Add(1, "Ilkin");
            //ht.Add(4, "Ehliman");
            //ht.Add(6, "Elxan");
            //ht.Add(5, "Ilkin");
            //ht.Add("ilkinn_1", "Ilkin Aliyev");
            //Console.WriteLine(ht[5]); ;
            //foreach (var item in ht.Keys)
            //{
            //    Console.WriteLine(item);
            //}

            //ArrayList arrayList = new ArrayList(); //FIFO prinsip
            //arrayList.Add(1);
            //arrayList.Add(2);
            //arrayList.Add(3);
            //arrayList.Remove(2);
            //Console.WriteLine(arrayList.Count);
            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion




            //Calc(8, 5, "+");
            //Calc(18, 5, "-");
            //Calc(18, 5, "*");
            //Calc(3, 18, "/");

            //for (; ; )
            //{
            //    Console.WriteLine("dsvdsvsd");
            //}
            Console.WriteLine("Select an option\n" +
                "1. Add item\n" +
                "2. Display list\n" +
                "3. Check item\n" +
                "4. Exit");
            int j = Convert.ToInt32(Console.ReadLine());
            while (j<4)
            {
                Console.WriteLine("Birinci ededi daxil et");
                int x1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ikinci ededi daxil et");
                int x2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Operation daxil et");
                string ope = Console.ReadLine();

                Calc(x1, x2, ope);
            }
            

        }

        public static void Calc(int num1, int num2, string operation)
        {
            switch (operation)
            {
                case "+":
                    int result=num1+ num2;
                    Console.WriteLine($"{num1} + {num2} = {result}");
                    break;
                case "-":
                    if (num1 > num2)
                    {
                        Console.WriteLine(num2 - num1);
                    }
                    else
                    {
                        Console.WriteLine(num2 - num1);
                    }
                    break;
                case "/":
                    Console.WriteLine(num2 / num1);
                    break;
                case "*":
                    Console.WriteLine(num1 * num2);
                    break;
                default:
                    Console.WriteLine("Sehv operationdur");
                    break;

            }
        }
    }
}
