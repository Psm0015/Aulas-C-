using System;
using System.Collections.Generic;

class Aula55{
    static void Main(){
        Dictionary<int,string> veiculos = new Dictionary<int, string>();//Construtor Dictionary

        veiculos.Add(10,"Carro");
        veiculos.Add(5,"Avião");
        veiculos.Add(0,"Navio");
        veiculos.Add(20,"Moto");
        veiculos.Add(15,"Patinete");

        // veiculos.Clear();//Limpa o Dictionary

        Console.WriteLine("Tamanho do Dictionary: {0}",veiculos.Count);//Retorna Tamanho

        // veiculos.Remove(20);//Remove valor a partir da chave

        veiculos[15] = "Bicicleta";

        string chave = "Bicicleta";
        if(veiculos.ContainsValue(chave)){ // Procura Valor
            Console.WriteLine("O valor {0} está na coleção",chave);
        }else{
            Console.WriteLine("O valor {0} Não está na coleção",chave);
        }
        // int chave = 20;
        // if(veiculos.ContainsKey(chave)){ // Procura chave
        //     Console.WriteLine("A chave {0} está na coleção",chave);
        // }else{
        //     Console.WriteLine("A chave {0} Não está na coleção",chave);
        // }

        foreach (KeyValuePair<int,string> v in veiculos)
        {
            Console.WriteLine("{0}:{1}",v.Key,v.Value);
        }

    }
}