using System;
using System.Xml.Schema;
class Program
{
    public static void Main(string[] args)
    {
      //Interface

        Dante dante = new Dante();
        Leon leon = new Leon();
        Kratos kratos = new Kratos();

        dante.Kill();
        leon.Run();
        kratos.Run();
        kratos.Kill();


    }
}
interface Kill
{
    void Kill();
}
interface Run { 
    void Run();
}
class Dante : Kill{
    public void Kill()
    {
        Console.WriteLine("Dante Has Killed All The Demons");
    }
}
class Leon : Run
{
    public void Run()
    {
        Console.WriteLine("Leon Has Runned Away From Bitores Mendes");
    }
}
class Kratos : Run , Kill
{
    public void Run()
    {
        Console.WriteLine("Kratos Run To Kill All The Gods Of Olympus");
    }
    public void Kill()
    {
        Console.WriteLine("Kratos Has Killed Zeus The God Of Olympus");
    }
}

