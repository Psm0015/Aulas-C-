using System;

struct Carro {
    public string modelo;
    public string cor;

    public void info(){
        Console.WriteLine("-=-=-=-=-=-=-=Carro=-=-=-=-=-=-=-");
        Console.WriteLine("Modelo: {0}", this.modelo);
        Console.WriteLine("Cor...: {0}", this.cor);
    }
}

class Aula45 {
    static void Main() {

        Carro[] carros = new Carro[4];

        carros[0].modelo="HRV";
        carros[0].cor="Prata";

        carros[1].modelo="Golf";
        carros[1].cor="Azul";

        carros[2].modelo="Jetta";
        carros[2].cor="Branco";

        carros[3].modelo="Argo";
        carros[3].cor="Preto";

        foreach(Carro c in carros){
            c.info();
        }
    }
}