using System;

class Jogador{
    private int energia;
    private String nome;

    public Jogador(String nome){
        this.nome=nome;
        energia=100;
    }

    public int getEnergia() {
        return this.energia;
    }
    public string getNome() {
        return this.nome;
    }

    public void setEnergia(int energia){
        if (energia<0){
            if(this.energia+energia<0){
                this.energia=0;
            }else{
                this.energia+=energia;
        }}else if (energia>0){
            if(this.energia+energia>100){
                this.energia=100;
            }else{
                this.energia+=energia;
            }
        }
    }
}
class Aula33{
    static void Main(){
        Jogador j1=new Jogador("Pedro");

        j1.setEnergia(30);
        j1.setEnergia(-150);
        j1.setEnergia(100);
        j1.setEnergia(-30);
        j1.setEnergia(-30);
        j1.setEnergia(-30);
        j1.setEnergia(-30);

        Console.WriteLine("Nome...: {0}",j1.getNome());
        Console.WriteLine("Energia: {0}",j1.getEnergia());
    }
}