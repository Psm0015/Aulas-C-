using System;

class Aula10{
    static void Main(){

        // int n1=10;
        // float n2=n1;

        // Console.WriteLine(n2); // Conversão Segura

        float n1=10.5f;
        int n2=(int)n1;//Conversão de TypeCast Resultado 10

        Console.WriteLine(n2);

        int vInt = 10;
        short vShort = (short)vInt;//Conversão de TypeCast Resultado 10

        Console.WriteLine(vShort);


    }
}