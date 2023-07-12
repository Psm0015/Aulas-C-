using System;

class Aula13{

    static void Main(){

        int res = 0, n1 = 0,n2 = 0,n3 = 0,n4 = 0;
        string resultado = "Reprovado",nome;
        Console.WriteLine("Digite o nome do Aluno:");
        nome = Console.ReadLine();

        Console.WriteLine("1º nota:");
        n1 = int.Parse(Console.ReadLine());

        Console.WriteLine("2º nota:");
        n2 = int.Parse(Console.ReadLine());

        Console.WriteLine("3º nota:");
        n3 = int.Parse(Console.ReadLine());

        Console.WriteLine("4º nota:");
        n4 = int.Parse(Console.ReadLine());

        res = (n1+n2+n3+n4)/4;

        if(res>=60){
            if(res>=80){
                resultado = "Aprovado com alto desempenho!";
            }else{
                resultado = "Aprovado";
            }
        }else if(res>=40 & res<60){
            resultado = "Recuperação";
        }else{
            resultado = "Reprovado";
        }

        Console.WriteLine("NOME: {0}\nMédia: {2}\nStatus: {1}",nome,resultado,res);

    }

}