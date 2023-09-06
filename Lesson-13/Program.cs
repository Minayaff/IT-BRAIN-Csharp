using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        //Pharmacy pharmacy = new Pharmacy();

        //Medicine medicine1 = new Medicine("Parol", 10.0m, 100);
        //Medicine medicine2 = new Medicine("Aspirin", 5.0m, 50);

        //pharmacy.AddMedicine(medicine1);
        //pharmacy.AddMedicine(medicine2);

        //pharmacy.Sell("Parol", 20);
        //pharmacy.Sell("Aspirin", 10);
        //Console.WriteLine("Toplam Gelir: " + pharmacy.TotalIncome);
        //int x = 5;



        //string a = "salam";
        //string b = a;
        //a = "sagol";
        //a.ToUpper();


        //Console.WriteLine(a);
        //Console.WriteLine(b);

        //List<int> array = new List<int>();
        //array.Add(1);
        //array.Add(12);
        //array.Add(13);
        //array.Add(16);

        //List<int> array2 = new List<int>();
        //array2 = array;
        //array[0] = 18;
        //Console.WriteLine(array2[0]);

        TestStruct a = new TestStruct(50, 50);
        TestStruct b = a;
        a.x = 100;
        Console.WriteLine("Value of a.x = " + a.x);  //100
        Console.WriteLine("Value of b.x = " + b.x);  //50

        TestClass d = new TestClass(50, 50);
        TestClass c = d;
        d.x = 100;
        Console.WriteLine("Value of a.x = " + d.x);   //100
        Console.WriteLine("Value of b.x = " + c.x);   //100
    }
}




#region Aptek app
class Medicine
{
    public string Name { get; }
    public decimal Price { get; }
    public int Count { get; private set; }

    public Medicine(string name, decimal price, int count)
    {
        if (string.IsNullOrWhiteSpace(name) || price <= 0 || count < 0)
            throw new ArgumentException("Duzgun deyil melumatlar.");

        Name = name;
        Price = price;
        Count = count;
    }

    public void Sell(int quantity)
    {
        if (quantity <= 0)
            throw new ArgumentException("Satış miqdari 0'dan nboyuk olmalıdır.");
        if (quantity > Count)
            throw new InvalidOperationException("Stokta yeterli derman yox.");

        Count -= quantity;
    }
}
class Pharmacy
{
    private List<Medicine> Medicines { get; }
    public decimal TotalIncome { get; set; }

    public Pharmacy()
    {
        Medicines = new List<Medicine>();
    }

    public Medicine FindMedicineByName(string name)
    {

        //foreach (var item in Medicines)
        //{
        //    if (item.Name == name)
        //    {
        //        return item;
        //    }
        //}

        return Medicines.Find(x => x.Name == name);

    }

    public void AddMedicine(Medicine medicine)
    {
        if (FindMedicineByName(medicine.Name) != null)
            throw new InvalidOperationException("Eyni adda derman var.");

        Medicines.Add(medicine);
    }

    public void Sell(string name, int quantity)
    {
        Medicine medicine = FindMedicineByName(name);

        if (medicine == null)
            throw new ArgumentException("bu adda derman tapilmadi");

        medicine.Sell(quantity);
        TotalIncome += medicine.Price * quantity;
    }
}
#endregion

public struct TestStruct
{
    public int x ;
    public int y;
    public TestStruct(int X,int Y)
    {
        x = X;
        y = Y;
    }
 
}

class TestClass
{
    public int x;
    public int y;
    public TestClass(int X, int Y)
    {
        x = X;
        y = Y;
    }
    public TestClass()
    {

    }
}
