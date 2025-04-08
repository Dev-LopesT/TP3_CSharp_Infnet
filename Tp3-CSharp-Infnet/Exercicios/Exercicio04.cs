using System;

namespace Tp3_CSharp_Infnet.Exercicios
{
    public static class Exercicio04
    {
        public static void Executar()
        {
            Console.WriteLine("Exercício 04 - Testando a Classe Ingresso\n");

            // Instanciando um ingresso
            Ingresso ingresso = new Ingresso("Festival de Inverno", 150.00, 200);

            // Exibindo informações iniciais
            Console.WriteLine("Informações iniciais:");
            ingresso.ExibirInformacoes();

            // Alterando o preço e a quantidade
            ingresso.AlterarPreco(180.00);
            ingresso.AlterarQuantidade(150);

            // Exibindo informações atualizadas
            Console.WriteLine("\nInformações após alterações:");
            ingresso.ExibirInformacoes();
        }

        class Ingresso
        {
            public string nomeDoShow;
            public double preco;
            public int quantidadeDisponivel;

            public Ingresso(string nomeDoShow, double preco, int quantidadeDisponivel)
            {
                this.nomeDoShow = nomeDoShow;
                this.preco = preco;
                this.quantidadeDisponivel = quantidadeDisponivel;
            }

            public void AlterarPreco(double novoPreco)
            {
                preco = novoPreco;
            }

            public void AlterarQuantidade(int novaQuantidade)
            {
                quantidadeDisponivel = novaQuantidade;
            }

            public void ExibirInformacoes()
            {
                Console.WriteLine($"Show: {nomeDoShow}");
                Console.WriteLine($"Preço: R${preco:F2}");
                Console.WriteLine($"Quantidade disponível: {quantidadeDisponivel}");
            }
        }
    }
}
