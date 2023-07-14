using System;

public class Jogador// Se não colocar nenhum modificador a classe é publica automaticamente
{
    public int energia =100;
    public bool vivo=true;
}

class Aula28
{
    static void Main()
    {
        /*
        [ModificadorClasse] class NOME_DA_CLASSE{
            //Variáveis / propriedades

            //Métodos
            [EspecificadorAcesso] retorno NOME_MÉTODO([arg1,...]){
                //Corpo do método
            }

        }
        //[ModificadorClasse]: Define a visibilidade da classe
            public: Pública, sem restrição de visualização
            abstract: Classe-Base para outras classes, não podem ser instanciados objetos desta classe
            sealed: Classe não pode ser herdada
            static: Classe não permite a instanciação de objetos e seus membros devem ser static
        //EspecificadorAcesso: Onde um membro da classe pode ser acessado
            public: Sem restrição de acesso
            private: Só podem ser acessado pela própria classe
            protected: Podem ser acessados na própria classe e nas classes derivadas
            abstract: Os métodos não tem implementação somente os cabeçalhos
            sealed: O método não pode ser redefinido
            virtual: O método pode ser redefinido em uma classe derivada
            static: O método pode ser chamado mesmo sem a instaciação de um objeto
        */

        Jogador j1=new Jogador();
        Jogador j2=new Jogador();
        Jogador j3=new Jogador();

        j1.energia = 50;
        Console.WriteLine("Energia do Jogador 1: {0}",j1.energia);
        Console.WriteLine("Energia do Jogador 2: {0}",j2.energia);

    }
}