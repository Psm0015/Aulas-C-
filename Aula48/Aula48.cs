using System;

class Aula48{
    static void Main(){
        Calc calc = new Calc();

        var res=calc.fat(10);

        Console.WriteLine(res);
    }
}

class Calc{

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

    public int fat(int n){
        int res;
        if(n<=1){
            res=1;
        }else{
            res=n*fat(n-1);
        }
        return res;
    }

}