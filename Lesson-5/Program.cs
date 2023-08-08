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

            #region Task 
            //string[] bookTitles = { "Book 1", "Book 2", "Book 3", "Book 4", "Book 5" };
            //string[] bookAuthors = { "Author 1", "Author 2", "Author 3", "Author 4", "Author 5" };
            //string[] bookGenres = { "Fiction", "Mystery", "Romance", "Fantasy", "Sci-Fi" };
            //int[] bookCopiesAvailable = { 5, 3, 7, 0, 2 };
            //Console.WriteLine("Kitablari goruntilemek ucun : all");


            ////for(int i = 0; i < bookTitles.Length; i++)
            ////{
            ////    Console.WriteLine($"{bookTitles[i]}:{bookAuthors[i]}:{bookGenres[i]}:{bookCopiesAvailable[i]}");
            ////}
            //Console.WriteLine("Enter book title:");
            //// string input=Console.ReadLine().ToUpper();
            ////for (int i = 0; i < bookTitles.Length; i++)
            ////{
            ////    if (input==bookTitles[i].ToUpper())
            ////    {
            ////        Console.WriteLine($"{bookTitles[i]}:{bookAuthors[i]}:{bookGenres[i]}:{bookCopiesAvailable[i]}");
            ////    }
            ////}
            //string book = Console.ReadLine();

            //for (int i = 0; i < bookTitles.Length; i++)
            //{
            //    if (book == bookTitles[i])
            //    {
            //        if (bookCopiesAvailable[i] > 0)
            //        {
            //            Console.WriteLine("Book is available to borrow");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Book is not available");
            //        }
            //    }
            //}

            #endregion

            #region Stack and  value type
            //Value type -stack yaddasda 
            //int x = 5;
            //int y =x;
            //x = 8;
            //y?
            //Console.WriteLine(x); //5
            //Console.WriteLine(y); //5

            #endregion

            #region Heap and reference type /Arraylist

            //ArrayList
            //int[] dataa = { 54, 8, 4, 3 };
            //ArrayList array2 = new ArrayList();

            //ArrayList array = new ArrayList();
            //array.Add("dvdfvf");
            //array.Add(5);
            //array.Add("dsvdfvds");
            //array.Add(55);
            //array.Remove(4);
            //ArrayList newArray = array;

            //foreach (var item in array)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("new Array");
            //foreach (var item in newArray)
            //{
            //    Console.WriteLine(item);
            //}
            //array.Add(88);
            //array.Add(90);
            //Console.WriteLine("Changed ////////////");
            //foreach (var item in array)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("new Array changed ////////");
            //foreach (var item in newArray)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            //ArrayList data = new ArrayList();
            //data.Add(5);
            //data.Add(6);
            //data.Add(7);  
            //data.Add(18);

            //int c =(int) data[0];
            //Console.WriteLine(c);

            //int[] x = { 5, 8, 9, 11 };
            //int number = x[0]; //5

            ArrayList studentList = new ArrayList();
            Console.WriteLine("Siyahiya elave etmek istediyin telebe sayini yaz");
            int count=Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= count; i++)
            {
                Console.WriteLine("Yeni telebe siyahiya elave et");
                string nameStudent = Console.ReadLine(); 
                studentList.Add(nameStudent);

            }

            Console.WriteLine("////////TELEBLERIN SIYAHISI //////////");
            foreach (var item in studentList)
            {
                Console.WriteLine(item);
            }


        }
    }
}
