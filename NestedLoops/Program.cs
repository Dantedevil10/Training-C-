using System;
 class Program
{
    public static void Main(string[] args)
    {

        //nested Loops  => Loops dentro de outros Loops
        //   Uso Variado .mas é bastante usado No sorteamento de algoritmos

        Console.WriteLine("HOw many rows?");
        int row = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("How many columns?");
        int columns = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Whats Symbol?");
        string symbol = Console.ReadLine();

        for (int i = 0; i < row; i++)
        {
            for (int j = 0;j < columns;j++)
            {
                Console.Write(symbol);
            }
            Console.WriteLine();
        }

    }
}