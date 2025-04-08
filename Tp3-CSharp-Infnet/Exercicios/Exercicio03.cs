using System;

namespace Tp3_CSharp_Infnet.Exercicios
{
    public static class Exercicio03
    {
        public static void Executar()
        {
            Console.WriteLine("Exercício 03 - Métodos Básicos da Classe Ingresso\n");

            // Criando um ingresso
            Ingresso ingresso = new Ingresso("Rock in Rio", 250.00, 100);

            // Exibindo informações iniciais
            ingresso.ExibirInformacoes();

            // Atualizando o preço
            ingresso.AlterarPreco(300.00);

            // Atualizando a quantidade disponível
            ingresso.AlterarQuantidade(80);

            Console.WriteLine("\nInformações atualizadas:");
            ingresso.ExibirInformacoes();
        }

        class Ingresso
        {
            public string nomeDoShow;
            public double preco;
            public int quantidadeDisponivel;

            // Construtor
            public Ingresso(string nomeDoShow, double preco, int quantidadeDisponivel)
            {
                this.nomeDoShow = nomeDoShow;
                this.preco = preco;
                this.quantidadeDisponivel = quantidadeDisponivel;
            }

            // Método para alterar o preço do ingresso
            public void AlterarPreco(double novoPreco)
            {
                preco = novoPreco;
            }

            // Método para alterar a quantidade disponível
            public void AlterarQuantidade(int novaQuantidade)
            {
                quantidadeDisponivel = novaQuantidade;
            }

            // Método para exibir as informações do ingresso
            public void ExibirInformacoes()
            {
                Console.WriteLine($"Show: {nomeDoShow}");
                Console.WriteLine($"Preço: R${preco:F2}");
                Console.WriteLine($"Quantidade disponível: {quantidadeDisponivel}");
            }
        }
    }
}
