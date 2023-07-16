
using System;
public class Jogador
{
    public int energia;
    public bool vivo;

    public string nome;

    public Jogador(string n){
        energia=100;
        vivo=true;
        nome=n;
    }

    ~Jogador(){
        Console.WriteLine("Jogador {0} foi destruido",nome);
    }
}

class Aula29
{
    static void Main()
    {

        string nome1;
        Console.Write("Digite o Nome do Jogador: ");
        nome1=Console.ReadLine();
        Jogador j1=new Jogador(nome1);
        Jogador j2=new Jogador("Théo");

        // j1.energia = 50;
        Console.WriteLine("Nome do Jogador 1: {0}",j1.nome);
        Console.WriteLine("Nome do Jogador 2: {0}",j2.nome);
        // Console.WriteLine("Energia do Jogador 1: {0}",j1.energia);
        // Console.WriteLine("Energia do Jogador 2: {0}",j2.energia);

    }
}