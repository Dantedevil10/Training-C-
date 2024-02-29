using System;
 class Program
{
    public static void Main(string[] args)
    {
        //Method overloading => metodos que tem o mesmo nome mas tem parametros diferentes

       int a = 10;
        int b = 12;
        int c = 13;
       
       
        Console.WriteLine(multi(a, b ));

        Console.ReadKey();
    }
    static int multi(int a, int b)
    {
        int z = a * b;
       return z ; 
        
    }
    static int multi(int a, int b, int c)
    {
       
        return a * b * c;

    }

}