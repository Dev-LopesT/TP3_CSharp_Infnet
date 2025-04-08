using System;

namespace Tp3_CSharp_Infnet.Exercicios
{
    public static class Exercicio05
    {
        public static void Executar()
        {
            Console.WriteLine("Exercício 05 - Métodos Get e Set\n");

            // Criando um ingresso com valores iniciais
            Ingresso ingresso = new Ingresso("Lollapalooza", 320.00, 500);

            // Mostrando valores iniciais com os métodos Get
            Console.WriteLine("Valores iniciais:");
            Console.WriteLine($"Show: {ingresso.GetNomeDoShow()}");
            Console.WriteLine($"Preço: R${ingresso.GetPreco():F2}");
            Console.WriteLine($"Quantidade: {ingresso.GetQuantidadeDisponivel()}");

            // Atualizando com os métodos Set
            ingresso.SetNomeDoShow("Lollapalooza Brasil 2025");
            ingresso.SetPreco(350.00);
            ingresso.SetQuantidadeDisponivel(450);

            // Confirmando alterações com os métodos Get
            Console.WriteLine("\nValores atualizados:");
            Console.WriteLine($"Show: {ingresso.GetNomeDoShow()}");
            Console.WriteLine($"Preço: R${ingresso.GetPreco():F2}");
            Console.WriteLine($"Quantidade: {ingresso.GetQuantidadeDisponivel()}");

            // Explicação:
            Console.WriteLine("\nOBS: Métodos Get/Set ajudam a controlar como os dados são acessados ou alterados. Mesmo sem usar 'private' ainda, é uma forma de centralizar o controle de leitura e escrita dos atributos.");
        }

        class Ingresso
        {
            string nomeDoShow;
            double preco;
            int quantidadeDisponivel;

            public Ingresso(string nomeDoShow, double preco, int quantidadeDisponivel)
            {
                this.nomeDoShow = nomeDoShow;
                this.preco = preco;
                this.quantidadeDisponivel = quantidadeDisponivel;
            }

            // Métodos GET
            public string GetNomeDoShow()
            {
                return nomeDoShow;
            }

            public double GetPreco()
            {
                return preco;
            }

            public int GetQuantidadeDisponivel()
            {
                return quantidadeDisponivel;
            }

            // Métodos SET
            public void SetNomeDoShow(string novoNome)
            {
                nomeDoShow = novoNome;
            }

            public void SetPreco(double novoPreco)
            {
                preco = novoPreco;
            }

            public void SetQuantidadeDisponivel(int novaQtd)
            {
                quantidadeDisponivel = novaQtd;
            }
        }
    }
}
