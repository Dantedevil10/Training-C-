using System;

class Program
{
    public static void Main(string[] args)
    {
        //Classe
         outra outra1 = new outra();

        outra1.name = "Jonh";
        outra1.age = 21;

         outra1.Ola();
        
        EXclasse.mensagem();
        EXclasse.espere();
        timer.Start();
        EXclasse.Final();

        
    }
}
class outra{
  public String name;
  public int age;

  public void Ola(){
  Console.WriteLine($"Oi {name} Tu Tem {age} Anux!");
 }
}
