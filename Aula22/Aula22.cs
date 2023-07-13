using System;

class Aula22
{
    static void Main(){

        int[] num = new int[5]{11,22,33,44,55};

        Console.WriteLine("FOR");
        for(int i =0;i<num.Length;i++){
            Console.WriteLine(num[i]);
        }
        Console.WriteLine("FOREACH");
        foreach (var i in num)
        {
            Console.WriteLine(i);
        }

    }
}