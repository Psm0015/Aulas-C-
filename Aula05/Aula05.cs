using System;

class Aula05{
    static void Main(){

        // int res = (10+5)*2;//30
        // int res = (10+5)*2;//20
        // int res = 10+5;//15

        // bool res=10<5;//False
        // Console.WriteLine(res);
        // res=10>5;//True
        // Console.WriteLine(res);
        // res=10<=5;//False
        // Console.WriteLine(res);
        // res=10>=5;//True
        // Console.WriteLine(res);
        // res=10==5;//False
        // Console.WriteLine(res);
        // res=10!=5;//True
        // Console.WriteLine(res);

        // int num =10;

        // num++; //Incrementa 1
        // num = num+2; //Incrementa 2
        // num +=3; //Incrementa 3

        // Console.WriteLine(num);

        // & = AND / E
        // | = OR / OU
        bool res=(5>3)|(10<5);//True
        res=(5>7)|(10<5);//False
        res=(5>7)&(10<5);//False
        res=(5>3)&(10<5);//False
        res=(5>3)&(10>5);//True

        Console.WriteLine(res);

    }
}