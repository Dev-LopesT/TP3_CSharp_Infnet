using System;

namespace Tp3_CSharp_Infnet.Exercicios
{
    public static class Exercicio07
    {
        public static void Executar()
        {
            Console.WriteLine("Exercício 07 - Modelando uma Matrícula\n");

            // Criando uma matrícula exemplo (valores diretos para demonstração)
            Matricula matricula = new Matricula();

            // Atribuindo dados diretamente
            matricula.NomeDoAluno = "Ana Silva";
            matricula.Curso = "Engenharia de Software";
            matricula.NumeroMatricula = 20231001;
            matricula.Situacao = "Ativa";
            matricula.DataInicial = "01/03/2025";

            // Exibindo os dados
            Console.WriteLine($"Nome do Aluno: {matricula.NomeDoAluno}");
            Console.WriteLine($"Curso: {matricula.Curso}");
            Console.WriteLine($"Número da Matrícula: {matricula.NumeroMatricula}");
            Console.WriteLine($"Situação: {matricula.Situacao}");
            Console.WriteLine($"Data de Início: {matricula.DataInicial}");
        }

        class Matricula
        {
            // Nome do aluno matriculado
            public string NomeDoAluno;

            // Nome do curso em que está matriculado
            public string Curso;

            // Número identificador único da matrícula
            public int NumeroMatricula;

            // Situação atual da matrícula (ex: Ativa, Trancada, Concluída)
            public string Situacao;

            // Data de início da matrícula
            public string DataInicial;
        }
    }
}
