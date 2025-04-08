using System;

namespace Tp3_CSharp_Infnet.Exercicios
{
    public static class Exercicio10
    {
        public static void Executar()
        {
            Console.WriteLine("Exercício 10 - Definindo Classes de Formas Geométricas\n");

            // Criando objetos para demonstração (sem cálculos por enquanto)
            Circulo circulo = new Circulo();
            circulo.Raio = 5.0;

            Esfera esfera = new Esfera();
            esfera.Raio = 3.0;

            Console.WriteLine($"Raio do círculo: {circulo.Raio}");
            Console.WriteLine($"Raio da esfera: {esfera.Raio}");

            Console.WriteLine("\nOBS: O atributo 'Raio' é essencial pois todas as fórmulas para área e volume dessas figuras dependem dele.");
        }

        // Classe Circulo com atributo Raio
        class Circulo
        {
            // O raio é a distância do centro até a borda do círculo.
            // Ele é necessário para calcular a área (A = π * r²).
            public double Raio;
        }

        // Classe Esfera com atributo Raio
        class Esfera
        {
            // O raio da esfera é usado para calcular o volume (V = 4/3 * π * r³) e a área da superfície.
            public double Raio;
        }
    }
}
