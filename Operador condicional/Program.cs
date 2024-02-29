using System;
 class Program
{
    public static void Main(string[] args)
    {
        //Operador Condicional => é parecido com o JS

        double temperature = 14;
        string message = (temperature >= 15)  ? "Ta Quente la fora" : "Ta Frio pa !!!!";

        Console.WriteLine(message);
        //Console.WriteLine((temperature >= 15) ? "Ta Quente la fora" : "Ta Frio pa !!!!");
        //dessa maneira tbm funciona
    }
   
    

}