using System;

class Aula49{
    static void Main(){
        double vpi=Mat.pi;

        int num=10;

        Console.WriteLine(Mat.dobro(num));
        Console.WriteLine(vpi);

        // Mat m1= new Mat();

        // Console.WriteLine(m1.dobro(num));
        // Console.WriteLine(m1.pi);
    }
}

class Mat{
    public static double pi=3.14;

    public static int dobro(int n){
        return n*2;
    }
}