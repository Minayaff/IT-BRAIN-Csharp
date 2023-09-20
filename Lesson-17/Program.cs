using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    public delegate bool Checkers(int a);
    public delegate void CheckPerson( Person person);
    static void Main()
    {
        #region Method with name
        //Console.WriteLine(Sum(5, 9, 6, 3, 7, 8)); ;
        //Sum(IsEven, 2, 58, 3, 6, 9, 78, 11, 22, 36);
        //Sum(IsOdd, 2, 58, 3, 6, 9, 78, 11, 22, 36);
        //Sum(IsDivideByFive, 2, 58, 3, 6, 9, 78, 11, 22, 36,55,5,25);
        #endregion
        #region Lambda expression
        //Sum(x=>x%2==0, 8,9,3,15,63,22,117,11,7);
        //Sum(x=>x%3==0, 8,9,3,15,63,22,117,11,7);
        //Sum(x => x >5, 8, 9, 3, 15, 63, 22, 117, 11, 7);
        #endregion
        //Anonymous method 
        //Sum(delegate (int c) { return c % 2 == 0; }, 11, 13, 18, 20, 65);

        #region Delegate 
        //Checkers checkers = new Checkers(IsEven);
        //checkers += IsOdd;
        //checkers += IsDivideByFive;

        //checkers(24);
        //checkers(15);

        //IsEven(5);
        //IsOdd(5);
        //IsDivideByFive(5);

        //IsEven(15);
        //IsOdd(15);
        //IsDivideByFive(15);
        #endregion
        Person person = new Person();
        person.Name = "Nigar";
        person.Country = "Azerbaijan";

        CheckPerson checkPerson = new CheckPerson(CheckName);
        checkPerson += delegate (Person c) { Console.WriteLine(c.Country.ToLower() == "azerbaijan"? "Beli" : "Xeyr"); };
        checkPerson+= p=>p.Name.Contains("A");
        checkPerson(person);
    }
    #region Method with name send to parametr
    public static bool IsEven(int a)
    {
        if (a % 2 == 0)
        {
            Console.WriteLine("Cut ededdir");
            return true;
        }
        Console.WriteLine("Tek ededdir");
        return false;
    }
    public static bool IsOdd(int a)
    {
        if (a % 3 == 0)
        {
            Console.WriteLine("3 e bolunur");
            return true;
        }
        Console.WriteLine("3 e bolunmur");
        return false;
    }
    public static bool IsDivideByFive(int a)
    {
        if (a % 5 == 0)
        {
            Console.WriteLine("5 e bolunur");
            return true;

        }
        Console.WriteLine("5 e bolunmur");
        return false;
    }
    #endregion

    public static int Sum(Checkers check,params int[] numbers)
    {
        int sum = 0;
        foreach (var item in numbers)
        {
            if (check(item))
            {
                sum += item;
            }
        }
        Console.WriteLine(sum);
        return sum;
    }
    public static void CheckName(Person p)
    {
        if (p.Name.Length > 3)
        {
            Console.WriteLine("3herfden boyukdur");
        }
        else
        {
            Console.WriteLine("Yalnis addir");
        }
    }

}

class Person
{
    public string Name { get; set; }
    public string Country { get; set; }
}
