using System;
using System.Xml.Schema;
class Program
{
    public static void Main(string[] args)
    {
        car[] cars = { new car("Mustang"),new car("Chevette")};

        foreach (car car in cars)
        {
            Console.WriteLine(car.model);
        }
    }
}
class car {
    public String model;
    public car(String model) {
        this.model = model;
    }
}

