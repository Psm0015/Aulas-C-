using System;

class Aula24
{
    static void Main()
    {
        PedroMota();
        int n1,n2;
        Console.WriteLine("Digite o 1º Valor:");
        n1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o 2º Valor:");
        n2 = int.Parse(Console.ReadLine());
        Console.WriteLine("A soma de {0} e {1} = {2}",n1,n2,soma(n1, n2));
    }

    static void PedroMota()
    {

        Console.WriteLine("=========================");
        Console.WriteLine("Pedro Mota");
        Console.WriteLine("20 Anos");
        Console.WriteLine("Programador");
        Console.WriteLine("=========================");
    }

    static int soma(int n1, int n2)
    {
        int res = n1 + n2;
        return res;
    }

}