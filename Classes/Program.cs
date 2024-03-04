using ConsoleApp1;
using System;
using System.Timers;
 class Program
{
    public static void Main(string[] args)
    {
        //Classe
        System.Timers.Timer timer = new System.Timers.Timer(2000);  
        
        
        

        EXclasse.mensagem();
        EXclasse.espere();
        timer.Start();
        EXclasse.Final();


    }
   
    

}