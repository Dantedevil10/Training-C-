using System;
 class Program
{
    public static void Main(string[] args)
    {
        Random random = new Random();

        int a1 = random.Next(1,10);
        int a2 = random.Next(1, 10);
        int a3 = random.Next(1, 10);
        //double a = random.NextDouble(); 

        Console.WriteLine(a1);
        Console.WriteLine(a2);
        Console.WriteLine(a3);


    }
}