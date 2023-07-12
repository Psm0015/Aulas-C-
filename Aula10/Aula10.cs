using System;

class Aula10{

    enum DiasSemana{Domingo,Segunda,Terça,Quarta,Quinta,Sexta,Sábado}
    static void Main(){
        
        DiasSemana ds = DiasSemana.Domingo;

        Console.WriteLine(ds);// Domingo

        ds = (DiasSemana)2;

        Console.WriteLine(ds);// Terça

        int ids = (int)DiasSemana.Sexta;

        Console.WriteLine(ids);// 5

    }
}