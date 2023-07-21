using System;
using System.Collections.Generic;

class Aula58
{
    static void Main()
    {
        List<string> carros = new List<string>();
        string[] carros2 = new string[10];

        carros.Add("Golf");
        carros.Add("HRV");
        carros.Add("Focus");
        carros.Add("Argo");
        carros.Add("HRV");

        // carros2.AddRange(carros);

        // carros.Clear();

        carros.Insert(1,"Cruze");
        int pos2 = carros.LastIndexOf("HRV");

        carros.CopyTo(carros2, 2);
        if (carros.Contains("Golf"))
        {
            Console.WriteLine("Está na lista");
        }
        else
        {
            Console.WriteLine("Não encontrado!");
        }

        // carros.Remove("Argo");
        // carros.RemoveAt(0);//Remove carro do index 0
        // carros.Reverse();//Reverte
        carros.Sort();//Orgarniza por Ordem Alfabética

        int tamanho = carros.Count;
        carros.Capacity=15;
        int cap = carros.Capacity;
        Console.WriteLine("Tamanho: {0}",tamanho);
        Console.WriteLine("Capacidade: {0}",cap);

        foreach (string c in carros)
        {
            Console.WriteLine("Carro: {0}", c);
        }


        string car = "HRV";
        int pos = 0;
        pos = carros.IndexOf(car);
        Console.WriteLine("O primeiro carro {0} esta na posição {1}", car, pos);
        Console.WriteLine("O último carro {0} esta na posição {1}", car, pos2);
    }
}