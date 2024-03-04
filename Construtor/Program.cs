
using System;
 class Program
{
    public static void Main(string[] args)
    {
        //Construtor = um metodo especial na classe com o mesmp nome da classe
        //  que pode ser usado para assinar argumentos em campo quando um objeto é criado

        Games game1 = new Games("God of War",2005,"Playstation2");
        game1.texto();
    }
}
class Games
{
    String nome;
    int ano;
    String plataforma;

    public Games(String nome, int ano, String plataforma)
    {
        this.nome = nome;
        this.ano = ano;
        this.plataforma = plataforma;
    }
    public void texto()
    {
        Console.WriteLine($"{nome} É Um Game De {ano} Lançado Para {plataforma}");
    }
}