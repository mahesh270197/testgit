using System;
public delegate void sidelegate(int x, int y, int z);
class program1
{
    public void si(int a, int b, int c)
    {
        double result = (a * b * c) / 100;
        Console.WriteLine($"sinple intrest is{result}");

    }
    public void Ci(int a, int b, int c)
    {
        double amount = a * Math.Pow((1 + b / 100), c);
        Console.WriteLine($"sinple intrest is{amount}");
    }
        public static void Main(String[] args)
         {
        program1 obj = new program1();
        sidelegate del = obj.si;
        del += obj.Ci;
        del.Invoke(1000, 5, 3);
     
        
       }

}