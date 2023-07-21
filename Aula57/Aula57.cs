using System;
using System.Collections.Generic;

class Aula57{
    static void Main(){
        List<string> carros= new List<string>();
        string[] carros2= new string[10];

        carros.Add("Golf");
        carros.Add("HRV");
        carros.Add("Focus");
        carros.Add("Argo");

        // carros2.AddRange(carros);

        // carros.Clear();

        carros.CopyTo(carros2,2);
        if(carros.Contains("Golf")){
            Console.WriteLine("Está na lista");
        }else{
            Console.WriteLine("Não encontrado!");
        }

        foreach (string c in carros2)
        {
            Console.WriteLine("Carro: {0}",c);
        }

        string car="Golf";
        int pos=0;
        pos=carros.IndexOf(car);
        Console.WriteLine("Carro {0} esta na posição {1}",car,pos);
    }
}