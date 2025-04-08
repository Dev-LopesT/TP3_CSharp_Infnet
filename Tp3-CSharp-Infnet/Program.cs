using System;
using Tp3_CSharp_Infnet.Exercicios;


namespace Tp3_CSharp_Infnet
{
    class Program
    {
        static void Main()
        {
            int opcao;
            do
            {
                Console.WriteLine("\n=== Menu de Exercícios ===");
                Console.WriteLine("1 a 12 - Executar exercício individual");
                Console.WriteLine("13 - Executar todos os exercícios");
                Console.WriteLine("0 - Sair");
                Console.Write("Escolha uma opção: ");

                if (!int.TryParse(Console.ReadLine(), out opcao))
                {
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    continue;
                }

                switch (opcao)
                {
                    case 1:
                        Exercicio01.Executar();
                        break;
                    case 2:
                        Exercicio02.Executar();
                        break;
                    case 3:
                        Exercicio03.Executar();
                        break;
                    case 4:
                        Exercicio04.Executar();
                        break;
                    case 5:
                        Exercicio05.Executar();
                        break;
                    case 6:
                        Exercicio06.Executar();
                        break;
                    case 7:
                        Exercicio07.Executar();
                        break;
                    case 8:
                        Exercicio08.Executar();
                        break;
                    case 9:
                        Exercicio09.Executar();
                        break;
                    case 10:
                        Exercicio10.Executar();
                        break;
                    case 11:
                        Exercicio11.Executar();
                        break;
                    case 12:
                        Exercicio12.Executar();
                        break;
                    case 13:
                        Exercicio01.Executar();
                        Exercicio02.Executar();
                        Exercicio03.Executar();
                        Exercicio04.Executar();
                        Exercicio05.Executar();
                        Exercicio06.Executar();
                        Exercicio07.Executar();
                        Exercicio08.Executar();
                        Exercicio09.Executar();
                        Exercicio10.Executar();
                        Exercicio11.Executar();
                        Exercicio12.Executar();
                        break;
                    case 0:
                        Console.WriteLine("Encerrando o programa...");
                        return;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            } while (true);
        }
    }
}
