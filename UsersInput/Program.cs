using System;
 class Program
{
    public static void Main(string[] args)
    {
            
        Console.WriteLine("Mano, Tu é Gay MANO ? ");
        string resposta = Console.ReadLine();

        if(resposta == "")
        {
            Console.WriteLine("Dexo Vaziu Né HAMMMMM");
        }

        if(resposta != "nao" && resposta != "não" )
        {
            Console.WriteLine("ANnnnn");
        }
        else
        {
            Console.WriteLine("um Sei");
        }

        Console.WriteLine("Tu Gosta Né?");
        resposta = Console.ReadLine();

        if (resposta == "")
        {
            Console.WriteLine(" Vaziu DINOVO To achando Que Tu é eim");
        }

        if (resposta != "nao" && resposta != "não")
        {
            Console.WriteLine("ELE GOOOOOSSSSTA");
        }
        else
        {
            Console.WriteLine("IIIIIIIIHHAAAAAAAAAA");
        }

        Console.WriteLine("Tu Tem quantos ANux? ");
        int idade = Convert.ToInt32(Console.ReadLine());
        

        Console.WriteLine("Esse Carinha teim: " + (idade));
    }
}