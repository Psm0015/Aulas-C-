using System;

class Veiculo{ //Classe Base
    public int velMax;
    private bool ligado;

    public int rodas;
    public void ligar(){
        ligado=true;
    }
    public void desligar(){
        ligado=false;
    }

    public string Getligado(){
        if(this.ligado){
            return "Ligado";
        }else{
            return "Desligado";
        }
    }
}

class Carro:Veiculo{
    public string nome;
    public string cor;
    public Carro(string nome, string cor){
        desligar();
        rodas=4;
        velMax=120;
        this.nome = nome;
        this.cor = cor;
    }
}

class Aula34{
    static void Main(){
        Carro c1 = new Carro("Rapidão", "Vermelho");

        Console.WriteLine("-=-=-=-=-=-=-=-= CARRO =-=-=-=-=-=-=-=-");
        Console.WriteLine("Nome......: {0}",c1.nome);
        Console.WriteLine("Cor.......: {0}",c1.cor);
        Console.WriteLine("Rodas.....: {0}",c1.rodas);
        Console.WriteLine("Vel.Maxima: {0}",c1.velMax);
        Console.WriteLine("Ligado....: {0}",c1.Getligado());
    }
}