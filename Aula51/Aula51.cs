using System;

class Aula51{
    static void Main(string[] args){//Argumentos são separados por espaços

        Console.WriteLine("Pedro Mota");

        if(args.Length > 0){
            Console.WriteLine("Quantidade de argumentos {0}", args.Length);
            for(int i=0; i <args.Length; i++){
                Console.WriteLine("Argumento {0}:{1}",i+1,args[i]);
            }
        }else{
            Console.WriteLine("Não foram passados argumentos de entrada");
        }

    }
}