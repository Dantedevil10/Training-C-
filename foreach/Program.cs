using System;
 class Program
{
    public static void Main(string[] args)
    {

        //arrays 

        // (String[] cars = new string[4]; isso define um valor fixo de arrays)


        String[] cars = { "Mustang", "Camaro", "Ferrari", "Corvette" };

        //Console.WriteLine(cars);  //isso não vai fazer o app mostrar todos os arrays
        //isso vai dar um System.String[] ;ou seja é um array de String


        // usando Este mesmo problema o Foreach tambem pode ser usado
        foreach (String car in cars)
        {
            Console.WriteLine(car);
        }
    }
}