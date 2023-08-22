using System;
using System.Text;

namespace FirstApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Student student = new Student("   ", "P315", 18);
            //student.GetBirthYear();

            Account st1 = new Account("ElxandsDeveloper", "elxaAn123!");
            Console.WriteLine(st1.Nomre);
            //Console.WriteLine(st1.Nomre);
            //Account st2 = new Account("Nigar XXX", "nigar123!");
            //Console.WriteLine(st2.Nomre);
            //Validation.IsNullOrEmpty(student.FullName);


            //string data = "salam";
            //Console.WriteLine(data[0]); //s
            //foreach (var item in data)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine(Validation.IsPasswordValid("SALAM555!!")); ;


        }
    }
    class Student
    {
        public Student(string fname, string group, byte age)
        {
            FullName = fname;
            GroupNo = group;
            Age = age;

        }
        public string FullName { get; set; }
        public string GroupNo { get; set; }
        public byte Age { get; set; }

        public void GetBirthYear()

        {
            int currentDate = DateTime.Now.Year;
            int sBirthYear = currentDate - Age;
            Console.WriteLine(sBirthYear);

        }


    }


    class Account
    {
        public string Username { get; set; }
        public string Password { get; set; }
        private static int No { get; set; } = 1000;
        public int Nomre { get; set; }
        public Account(string username, string password)
        {
           if (Validation.IsPasswordValid(password) && Validation.IsUserNameValid(username))
            {
                No++;
                Nomre = No;
                Password = password;
                Username = username;
            }
            else
            {
                Console.WriteLine("Melumatlar duzgun deyil");
            }
        }
    }

    static class Validation
    {

        public static void IsNullOrEmpty(string data)
        {
            if ( data.Trim()=="")  // !(data != "")
            {
                Console.WriteLine("Sehv yazmisiz bos olmaz");
            }

        }

        public static bool IsUserNameValid(string usrname)
        {
            bool isDigit = false;
            bool isLetter = false;

            foreach (char item in usrname)
            {
                //(int)item sadece ascii table-da yerini gosterir
                if((int)item >=65 && (int)item <=90 || (int)item>=97 && (int)item <= 122)
                {
                    isLetter=true;
                }
                if ((int)item >= 48 && (int)item <= 57)
                {
                    isDigit = true;
                }
                if((int)item>=32 && (int)item <= 47)
                {
                    return false;
                }
            }
            if(isDigit ==true && isLetter==true)
            {
                return true;
            }
            return false;
        }

        public static bool IsPasswordValid(string pass)
        {
            bool isDigit = false;
            bool isLetter = false;
            bool isSymbol = false;
            if(pass.Length>=8 && pass.Length <= 25)
            {
                foreach (char item in pass)
                {
                    //(int)item sadece ascii table-da yerini gosterir
                    if ((int)item >= 65 && (int)item <= 90)
                    {
                        isLetter = true;
                    }
                    if ((int)item >= 48 && (int)item <= 57)
                    {
                        isDigit = true;
                    }
                    if ((int)item >= 32 && (int)item <= 47)
                    {
                        isSymbol = true;
                    }
                }
            }
           
            if (isDigit == true && isLetter == true && isSymbol==true)
            {
                return true;
            }
            return false;
        }

    }

}
