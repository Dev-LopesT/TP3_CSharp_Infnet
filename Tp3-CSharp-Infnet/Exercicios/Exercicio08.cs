using System;

namespace Tp3_CSharp_Infnet.Exercicios
{
    public static class Exercicio08
    {
        public static void Executar()
        {
            Console.WriteLine("Exercício 08 - Criando Métodos na Classe de Matrícula\n");

            // Criando uma matrícula
            Matricula matricula = new Matricula();
            matricula.NomeDoAluno = "Carlos Souza";
            matricula.Curso = "Ciência da Computação";
            matricula.NumeroMatricula = 20232045;
            matricula.Situacao = "Ativa";
            matricula.DataInicial = "15/02/2025";

            // Exibindo dados iniciais
            Console.WriteLine("Matrícula Inicial:");
            matricula.ExibirInformacoes();

            // Trancando a matrícula
            Console.WriteLine("\nMatrícula Trancada:");
            matricula.Trancar();
            matricula.ExibirInformacoes();

            // Reativando a matrícula
            Console.WriteLine("\nMatrícula Reativada:");
            matricula.Reativar();
            matricula.ExibirInformacoes();
        }

        class Matricula
        {
            public string NomeDoAluno;
            public string Curso;
            public int NumeroMatricula;
            public string Situacao;
            public string DataInicial;

            // Método que altera a situação para "Trancada"
            public void Trancar()
            {
                Situacao = "Trancada";
            }

            // Método que altera a situação para "Ativa"
            public void Reativar()
            {
                Situacao = "Ativa";
            }

            // Método que exibe as informações da matrícula
            public void ExibirInformacoes()
            {
                Console.WriteLine($"Aluno: {NomeDoAluno}");
                Console.WriteLine($"Curso: {Curso}");
                Console.WriteLine($"Situação: {Situacao}");
                Console.WriteLine($"Data Inicial: {DataInicial}");
            }
        }
    }
}
