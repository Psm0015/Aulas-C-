
using System;

namespace Aula02{

    class Program{

        static void Main(string[] args){
            Console.WriteLine("Pedro Mota");

            if(args.GetLength(0)>0){
                Console.Write(args.GetValue(0));
            }
            
        }

    }
}
