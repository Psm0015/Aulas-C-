using System;

class Veiculo{ //Classe Base
    public int velMax;
    private bool ligado;

    private int rodas;
    public void ligar(){
        ligado=true;
    }
    public void desligar(){
        ligado=false;
    }

    public Veiculo(int rodas){
        this.rodas=rodas;
    }

    public string Getligado(){
        return(ligado?"Ligado":"Desligado");
        // if(this.ligado){
        //     return "Ligado";
        // }else{
        //     return "Desligado";
        // }
    }

    public int getRodas(){
        return this.rodas;
    }
    public void setRodas(int rodas){
        if(rodas<0){
            this.rodas=0;
        }else if(rodas>40){
            this.rodas=40;
        }else{
            this.rodas=rodas;
        }
    }
}

class Carro:Veiculo{
    public string nome;
    public string cor;
    public Carro(string nome, string cor):base(4){
        desligar();
        velMax=120;
        this.nome = nome;
        this.cor = cor;
    }
}

class CarroCombate:Carro{
    public int municao;
    public  CarroCombate():base("Carro de Combate","Verde"){
        municao=100;
        setRodas(6);
    }
}

class Aula35{
    static void Main(){
        Carro c1 = new Carro("Rapidão", "Vermelho");
        CarroCombate cc1 = new CarroCombate();

        c1.ligar();

        Console.WriteLine("-=-=-=-=-=-=-=-= CARRO =-=-=-=-=-=-=-=-");
        Console.WriteLine("Nome......: {0}",c1.nome);
        Console.WriteLine("Cor.......: {0}",c1.cor);
        Console.WriteLine("Rodas.....: {0}",c1.getRodas());
        Console.WriteLine("Vel.Maxima: {0}",c1.velMax);
        Console.WriteLine("Ligado....: {0}",c1.Getligado());

        Console.WriteLine("-=-=-=-=-=-=-=-= CARRO DE COMBATE =-=-=-=-=-=-=-=-");
        Console.WriteLine("Nome......: {0}",cc1.nome);
        Console.WriteLine("Cor.......: {0}",cc1.cor);
        Console.WriteLine("Rodas.....: {0}",cc1.getRodas());
        Console.WriteLine("Vel.Maxima: {0}",cc1.velMax);
        Console.WriteLine("Ligado....: {0}",cc1.Getligado());
        Console.WriteLine("Munição....: {0}",cc1.municao);
    }
}