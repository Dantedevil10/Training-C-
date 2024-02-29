using System;
 class Program
{
    public static void Main(string[] args)
    {
        //Params Keyword => um metodo que contem varios numeros de argumentos
        //                  o parametro type precisa ser unico - array dimensional

        double total = Math.Floor(check(3.99,5,14,1.50,1.01));

        Console.WriteLine(total);

    }
    static double check(params double[] prices)
    {
        double total = 0;
        foreach (double price in prices)
        {
            total += price;
        }
        return total;
    }
    

}