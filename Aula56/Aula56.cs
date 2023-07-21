using System;
using System.Collections.Generic;

class Aula56{
    static void Main(){
        LinkedList<string> transp = new LinkedList<string>();

        transp.AddFirst("Carro");
        transp.AddFirst("Avião");
        transp.AddFirst("Navio");
        transp.AddFirst("Motocicleta");//Adiciona no ínicio

        transp.AddLast("Bicicleta");//Adiciona no Final

        LinkedListNode<string>no;//é necessário criar um no para adicionar depois
        no=transp.FindLast("Navio");
        no=transp.FindLast("Navio").Next;//Pega o proximo depois do Elemento
        no=transp.FindLast("Navio").Before;//Pega o proximo antes do Elemento
        no=transp.FindLast("Navio").Value;//Retorna o Valor
        transp.AddAfter(no,"Patinete");//Adiciona depois
        no=transp.FindLast("Carro");
        transp.AddBefore(no,"Patins");//Adiciona antes

        transp.Clear();//Remove tudo
        // transp.Remove("Navio");//Remove o elemento
        transp.RemoveFirst();//Remove o Primeiro Elemento
        transp.RemoveLast();//Remove o ultimo Elemento

        // if(transp.Find("Carro") == null){//Encontra elemento ou retorna null
        //     Console.WriteLine("Elemento Não Encontrado");
        // }else{
        //     Console.WriteLine("Elemento Encontrado");
        // };
        
        foreach(string t in transp){
            Console.WriteLine("Transporte: {0}",t);
        }
    }
}