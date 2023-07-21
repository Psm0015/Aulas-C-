using System;
using System.Collections.Generic;

class Aula57{
    static void Main(){
        List<string> carros= new List<string>();
        List<string> carros2= new List<string>();

        carros.Add("Golf");
        carros.Add("HRV");
        carros.Add("Focus");
        carros.Add("Argo");

        carros2.AddRange(carros);

        carros.Clear();

        foreach (string c in carros2)
        {
            Console.WriteLine(c);
        }
    }
}