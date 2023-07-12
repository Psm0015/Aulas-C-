using System;

class Aula17
{
    static void Main()
    {

        int n1, n2, n3, n4, n5;
        int[] n = new int[5];
        // int[] num = new int[3] { 55, 77, 99 };
        int[] num ={ 55, 77, 99 };

        n[0] = int.Parse(Console.ReadLine());
        n[1] = int.Parse(Console.ReadLine());
        n[2] = int.Parse(Console.ReadLine());
        n[3] = int.Parse(Console.ReadLine());
        n[4] = int.Parse(Console.ReadLine());

        Console.Clear();

        foreach (var item in n)
        {
            Console.Write(item+"\n");
        }
        foreach (var item in num)
        {
            Console.WriteLine(item);
        }

    }
}