using System;

class Aula21
{
    static void Main(){
        // O do While é executado pelomenos uma vez

        string senha = "123", senhauser;
        int tentativas=0;

        do{
            Console.Clear();
            Console.WriteLine("Digite uma senha");
            senhauser = Console.ReadLine();
            tentativas++;
        }while(senha != senhauser);
        Console.Clear();
        Console.WriteLine("Senha Correta, tentativas:{0}",tentativas);
    }
}