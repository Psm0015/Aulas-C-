using System;
using System.Collections.Generic;

class Aula59{
    static void Main(){

        

        // string[] vs={"Carro","Moto","Navio","Aviao"};
        // Queue<string>veiculos = new Queue<string>(vs);
        Queue<string>veiculos = new Queue<string>();

        veiculos.Enqueue("Carro");
        veiculos.Enqueue("Moto");
        veiculos.Enqueue("Navio");
        veiculos.Enqueue("Aviao");

        string v="Aviao";
        if(veiculos.Contains(v)){
            Console.WriteLine("Veiculo "+v+" encontrado");
        }else{
            Console.WriteLine("Veiculo "+v+" não está na fila");
        }

        Console.WriteLine("Tamanho fila: "+veiculos.Count);

    }
}