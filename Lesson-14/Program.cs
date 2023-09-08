using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main()
    {
        string action = "program basladi";
        ConsoleLog consoleLog = new ConsoleLog();
        consoleLog.WriteMethod(action);

        FileLog fileLog = new FileLog();
        fileLog.WriteMethod(action);

    }
}

#region Ders izah
interface Mother
{
    string Name { get; set; }
    int Test();
}
interface Father
{
    int Test2();
}
class Child : Mother, Father
{
    public string Name { get; set; }

    public int Test()
    {
        throw new NotImplementedException();
    }
    public int Test2()
    {
        throw new NotImplementedException();
    }
}

#endregion

interface ILog
{
    void WriteMethod(string data);
}
class ConsoleLog : ILog
{
    public void WriteMethod(string data)
    {
       string date= DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss") + data;
        Console.WriteLine(date);
    }
}

class FileLog : ILog
{
    public void WriteMethod(string data)
    {
        string date = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss") + data;

        using (var file = File.AppendText(@"C:\Users\Minaye.Ferzeliyeva\source\repos\FirstApp\bin\Debug\log.txt"))
        {
            file.WriteLine(date);
        }

    }
}