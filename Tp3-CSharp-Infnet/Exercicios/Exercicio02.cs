using System;

namespace Tp3_CSharp_Infnet.Exercicios
{
    public static class Exercicio02
    {
        public static void Executar()
        {
            Console.WriteLine("Exercício 02 - Criando a Classe Ingresso\n");

            // A classe Ingresso representa um ingresso de show com suas principais informações:
            Ingresso ingressoExemplo = new Ingresso();

            ingressoExemplo.nomeDoShow = "Rock in Rio";
            ingressoExemplo.preco = 250.00;
            ingressoExemplo.quantidadeDisponivel = 100;

            Console.WriteLine($"Show: {ingressoExemplo.nomeDoShow}");
            Console.WriteLine($"Preço: R${ingressoExemplo.preco}");
            Console.WriteLine($"Quantidade disponível: {ingressoExemplo.quantidadeDisponivel}");
        }

        // Classe Ingresso com seus atributos
        class Ingresso
        {
            // nomeDoShow: Identifica o evento associado ao ingresso.
            // Importante para o cliente saber para qual show está comprando.
            public string nomeDoShow;

            // preco: Valor em reais do ingresso.
            // Essencial para que o sistema calcule a receita e informe o valor ao cliente.
            public double preco;

            // quantidadeDisponivel: Quantos ingressos ainda estão disponíveis para venda.
            // Importante para controle de estoque e para impedir vendas acima do limite.
            public int quantidadeDisponivel;
        }
    }
}
