using System;

class Aula47{
    static void Main(){

        int res;
        double resd;

        Calc calc = new Calc();

        res=calc.soma(10,5);
        Console.WriteLine(res);
        res=calc.soma(10,5,3);
        Console.WriteLine(res);
        res=calc.soma(10,5,3,2);
        Console.WriteLine(res);

    // COM VALORES DOUBLE

        resd=calc.soma(10.2,5.3);
        Console.WriteLine(resd);
        resd=calc.soma(10.4,5.5,3.6);
        Console.WriteLine(resd);
        resd=calc.soma(10.7,5.8,3.9,2.1);
        Console.WriteLine(resd);
    }
}

class Calc{
    // public int soma(int n1, int n2){
    //     return n1+n2;
    // }
    // public int soma(int n1, int n2, int n3){
    //     return n1+n2+n3;
    // }
    // public int soma(int n1, int n2, int n3, int n4){
    //     return n1+n2+n3+n4;
    // }


    // public double soma(double n1, double n2){
    //     return n1+n2;
    // }
    // public double soma(double n1, double n2, double n3){
    //     return n1+n2+n3;
    // }
    // public double soma(double n1, double n2, double n3, double n4){
    //     return n1+n2+n3+n4;
    // }

    public int soma(params int[]n){
        int s=0;
        for (int i =0;i<n.Length;i++){
            s+=n[i];
        }
        return s;
    }
    public double soma(params double[]n){
        double s=0;
        for (int i =0;i<n.Length;i++){
            s+=n[i];
        }
        return s;
    }
}