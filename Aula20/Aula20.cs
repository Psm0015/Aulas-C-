using System;

class Aula20
{
    static void Main(){

        int[] num = new int[10];

        int x=0;

        while (x<num.Length)
        {   
            num[x] = 0;
            Console.WriteLine("{0} - Pedro Mota",x);
            x++;
        }
        x = 0;
        Console.WriteLine("Fim!");
    }
}