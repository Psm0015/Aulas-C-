using System;

class Aula23
{
    static void Main(){
        int[] vetor1=new int[5];
        int[] vetor2=new int[5];
        int[] vetor3=new int[5];
        int[,] matriz=new int[2,5]{{11,22,00,44,55},{66,77,88,99,00}};

        Random random = new Random();
        for (int i = 0; i < vetor1.Length; i++)
        {
            vetor1[i]=random.Next(50);
        }
        Console.Clear();
        Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
        Console.WriteLine("Elementos do vetor1");
        foreach(int n in vetor1){
            Console.WriteLine(n);
        }

        Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
        Console.WriteLine("BinarySearch");
        int procurado=33;

        int pos=Array.BinarySearch(vetor1,procurado); //Vetor, valor que vai ser procurado
        if(pos >=0){
            Console.WriteLine("Valor {0} está na posição {1}",procurado,pos);
        }else{
            Console.WriteLine("Valor não Encontrado");
        }

        Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");

        Console.WriteLine("Copy");
        Array.Copy(vetor1,vetor2,vetor1.Length);//Vetor a ser copiado, vetor destino, tamanho do vetor
        foreach(int n in vetor2){
            Console.WriteLine(n);
        }
        Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
        Console.WriteLine("CopyTo");
        vetor1.CopyTo(vetor3,0);//(destino,a partir dessa posição);
        foreach(int n in vetor3){
            Console.WriteLine(n);
        }

    }
}