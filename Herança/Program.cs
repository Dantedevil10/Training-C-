using System;
 class Program
{
    public static void Main(string[] args)
    {
        //  Herança
        car Car = new car();
        bicicleta bici = new bicicleta();
        Boat bo = new Boat();

        Console.WriteLine(Car.wheels);
        Console.WriteLine(bici.wheels);
        Console.WriteLine(bo.wheels);
    }
}
class Veiculo
{
    public int speed = 0;
    
    public void go()
    {
        Console.WriteLine("esta se movendo");
    }
}
class car : Veiculo {
    public int wheels = 4;
}
class bicicleta : Veiculo {
    public int wheels = 2;
}
class Boat : Veiculo {
    public int wheels = 0;
}