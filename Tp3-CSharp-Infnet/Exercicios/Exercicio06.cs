using System;

namespace Tp3_CSharp_Infnet.Exercicios
{
    public static class Exercicio06
    {
        public static void Executar()
        {
            Console.WriteLine("Exercício 06 - Adicionando Construtores à Classe Ingresso\n");

            // Criando um ingresso com o novo construtor
            Ingresso ingresso = new Ingresso("Planeta Atlântida", 180.00, 300);

            // Exibindo as informações usando os métodos Get
            Console.WriteLine("Ingresso criado com o construtor:");
            Console.WriteLine($"Show: {ingresso.GetNomeDoShow()}");
            Console.WriteLine($"Preço: R${ingresso.GetPreco():F2}");
            Console.WriteLine($"Quantidade: {ingresso.GetQuantidadeDisponivel()}");

            Console.WriteLine("\nOBS: O uso de construtores facilita a criação do objeto porque já define os valores iniciais obrigatórios, evitando esquecimento ou erros ao configurar os dados manualmente.");
        }

        class Ingresso
        {
            string nomeDoShow;
            double preco;
            int quantidadeDisponivel;

            // Construtor com parâmetros
            public Ingresso(string nomeDoShow, double preco, int quantidadeDisponivel)
            {
                this.nomeDoShow = nomeDoShow;
                this.preco = preco;
                this.quantidadeDisponivel = quantidadeDisponivel;
            }

            // Getters
            public string GetNomeDoShow() => nomeDoShow;
            public double GetPreco() => preco;
            public int GetQuantidadeDisponivel() => quantidadeDisponivel;
        }
    }
}
