using System;

class Aula15
{
    static void Main()
    {

        int tempo;
        char escolha;
        Console.WriteLine("Belo Horizonte/MG a Vitória/ES");
        Console.WriteLine("Escolha o transporte:\n[a]Avião\n[b]Carro\n[c]Ônibus");

        escolha = char.Parse(Console.ReadLine());

        switch (escolha)
        {
            case 'a':
            case 'A':
                tempo=50;
                break;
            case 'b':
            case 'B':
                tempo=480;//8 horas
                break;
            case 'c':
            case 'C':
                tempo=660;//11 horas
                break;
            default:
                tempo=-1;
                break;
        }

        if(tempo<0){
            Console.WriteLine("Transporte Indisponível");
        }else{
            Console.WriteLine("Para o transporte ecolhido o tempo é: {0} minutos", tempo);
        }
    }
}