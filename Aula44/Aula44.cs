using System;

struct Carro {
    public string marca;
    public string modelo;
    public string cor;

    public Carro(string marca, string modelo, string cor) {
        this.modelo = modelo;
        this.marca = marca;
        this.cor = cor;
    }
    public void info(){
        Console.WriteLine("-=-=-=-=-=-=-=Carro=-=-=-=-=-=-=-");
        Console.WriteLine("Marca.: {0}", this.marca);
        Console.WriteLine("Modelo: {0}", this.modelo);
        Console.WriteLine("Cor...: {0}", this.cor);
    }
}

class Aula44 {
    static void Main() {

        Carro c1;

        c1.marca="VW";
        c1.modelo="Golf";
        c1.cor="Verde";

        Carro c2 = new Carro("VW", "Golf", "Azul");

        c1.info();
        c2.info();
        
    }
}