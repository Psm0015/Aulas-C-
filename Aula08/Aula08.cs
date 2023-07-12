using System;

class Aula08
{
    static void Main()
    {

        int v1,v2,soma;
        string nome;

        // Console.Write("Digite seu nome: ");
        // nome = Console.ReadLine();
        // Console.WriteLine("Olá, {0}!", nome);

        Console.Write("Digite o 1º Valor: ");
        v1 = int.Parse(Console.ReadLine());
        Console.Write("Digite o 2º Valor: ");
        v2 = int.Parse(Console.ReadLine());
        soma = v1 + v2;
        Console.WriteLine("A soma de {0} e {1} é igual a: {2}", v1, v2, soma);

    }
}