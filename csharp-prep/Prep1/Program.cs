using System;

class Program
{
    static void Main(string[] args)
    {
        //pedir ao usuario pelo seu primeiro nome
        Console.Write("Qual é o seu primeiro nome? ");
        string primeiroNome = Console.ReadLine();

        Console.Write("Qual é o seu sobrenome? ");
        string sobrenome = Console.ReadLine();

        Console.WriteLine($"Seu nome é {sobrenome}, {primeiroNome} {sobrenome}.");
    }
}