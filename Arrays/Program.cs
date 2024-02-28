using System;
 class Program
{
    public static void Main(string[] args)
    {

        //arrays 

        // (String[] cars = new string[4]; isso define um valor fixo de arrays)


        String[] cars = { "Mustang", "Camaro", "Ferrari" ,"Corvette"};

        //Console.WriteLine(cars);  //isso não vai fazer o app mostrar todos os arrays
                                    //isso vai dar um System.String[] ;ou seja é um array de String
                                

        //pra resolver esse problema de mostrar todos os arrays Pode-se criar um loop for

        for (int i = 0;i < cars.Length; i++)
        {
            Console.WriteLine(cars[i]);
        }
        //dessa maneira todos os objetos do array serão mostrados
    }
}