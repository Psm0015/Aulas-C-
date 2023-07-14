using System;
using System.Collections.Generic;

class Aula29
{
    static void Main()
    {
        int qtd = inicio();
        int Boss = 1000;
        List<Jogador> jogadores = new List<Jogador>();
        jogadores = Jogadores(qtd);
        Console.Write(imprime(jogadores));

    }

    static string imprime(List<Jogador> jogadores)
    {
        int x=1;
        string st="";
        foreach (Jogador j in jogadores)
        {
            st += "===========JOGADOR "+x+"===========";
            st += "\nNome:" + j.nome;
            st += "\nEnergia:" + j.energia;
            st += "\nVida:"+j.vida;
            x++;
        }
        return st;
    }

    static int inicio()
    {
        int totJogadores = 0;
        do
        {
            Console.WriteLine("Quantos jogadores vão jogar(MAX 4):");
            totJogadores = int.Parse(Console.ReadLine());
        } while (totJogadores < 1 | totJogadores > 4);

        return totJogadores;
    }

    static List<Jogador> Jogadores(int n)
    {
        List<Jogador> jogadores = new List<Jogador>();

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("\n============================");
            Console.WriteLine("Nome do Jogador {0}:", i + 1);
            Jogador j = new Jogador(Console.ReadLine());
            jogadores.Add(j);

        }
        return jogadores;
    }
    static List<Jogador> atacar(List<Jogador> jogadores,ref int Boss){

        Random random = new Random();
        atackpower= random.Next(40,60);
        atackpower *= jogadores.Length;
        Boss -= atackpower;
        foreach(Jogador j in jogadores){
            j.energia -= atackpower*0.5;
        }

        return jogadores;
    }
}

class Jogador
{
    public int energia;
    public int vida;
    public string nome;

    public Jogador(String nm)
    {
        energia = 100;
        vida = 100;
        nome = nm;
    }
}