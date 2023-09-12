using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main()
    {
        //FileStream file = new FileStream("C:\\test.txt", FileMode.Append, FileAccess.Write);
        //using (StreamWriter streamWriter=new StreamWriter(file))
        //{
        //    string data = "sagol";
        //    streamWriter.WriteLine(data);
        //}

        FileStream file = new FileStream("C:\\test.txt", FileMode.Open, FileAccess.Read);
        StreamReader streamReader = new StreamReader(file);
        streamReader.BaseStream.Seek(0, SeekOrigin.Begin);
         string data=streamReader.ReadToEnd();
        Console.WriteLine(data);

    }

}

