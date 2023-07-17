using System;

class Aula36{

    static void Main(){
        Carro carro = new Carro("Bonitão", 120);
        Console.WriteLine("-=-=-=-=-= Carro =-=-=-=-=-",carro.nome);
        Console.WriteLine("Nome...: {0}",carro.nome);
        Console.WriteLine("Vel.Max: {0}",carro.GetVelMax());
        Console.WriteLine("Ligado.: {0}",carro.GetLigado());
    }

}

class Veiculo{
    public int velAtual;
    private int velMax; // Restringe o acesso somente a classe(Pode ser acessado por apenas metodos)
    protected bool ligado; //Permite o acesso pelas classes derivadas(Não acessado pelo Objeto)

    public Veiculo(int velMax){
        velAtual=0;
        this.velMax=velMax;
        ligado=false;
    }
    public bool GetLigado(){
        return this.ligado;
    }
    public int GetVelMax(){
        return this.velMax;
    }

}

class Carro:Veiculo{//Derivada de Veiculo
    public string nome;

    public Carro(string nome, int vm):base(vm){
        this.nome=nome;
        ligado=true;
    }

}