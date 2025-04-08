using System;

namespace Tp3_CSharp_Infnet.Exercicios
{
    public static class Exercicio09
    {
        public static void Executar()
        {
            Console.WriteLine("Exercício 09 - Testando a Classe de Matrícula\n");

            // Instanciando um objeto da classe Matricula
            Matricula matricula = new Matricula();
            matricula.NomeDoAluno = "Fernanda Oliveira";
            matricula.Curso = "Administração";
            matricula.NumeroMatricula = 20231234;
            matricula.Situacao = "Ativa";
            matricula.DataInicial = "01/04/2025";

            // Exibindo informações iniciais
            Console.WriteLine("Situação inicial:");
            matricula.ExibirInformacoes();

            // Trancando a matrícula
            Console.WriteLine("\nApós trancar a matrícula:");
            matricula.Trancar();
            matricula.ExibirInformacoes();

            // Reativando a matrícula
            Console.WriteLine("\nApós reativar a matrícula:");
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

            public void Trancar()
            {
                Situacao = "Trancada";
            }

            public void Reativar()
            {
                Situacao = "Ativa";
            }

            public void ExibirInformacoes()
            {
                Console.WriteLine($"Aluno: {NomeDoAluno}");
                Console.WriteLine($"Curso: {Curso}");
                Console.WriteLine($"Número da Matrícula: {NumeroMatricula}");
                Console.WriteLine($"Situação: {Situacao}");
                Console.WriteLine($"Data Inicial: {DataInicial}");
            }
        }
    }
}
