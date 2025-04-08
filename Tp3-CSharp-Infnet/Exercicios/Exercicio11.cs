using System;

namespace Tp3_CSharp_Infnet.Exercicios
{
    public static class Exercicio11
    {
        public static void Executar()
        {
            Console.WriteLine("Exercício 11 - Criando Métodos de Cálculo\n");

            // Criando um círculo com raio 5
            Circulo circulo = new Circulo();
            circulo.Raio = 5.0;
            double area = circulo.CalcularArea();
            Console.WriteLine($"Área do círculo (raio {circulo.Raio}): {area:F2}");

            // Criando uma esfera com raio 3
            Esfera esfera = new Esfera();
            esfera.Raio = 3.0;
            double volume = esfera.CalcularVolume();
            Console.WriteLine($"Volume da esfera (raio {esfera.Raio}): {volume:F2}");
        }

        class Circulo
        {
            public double Raio;

            // Fórmula da área do círculo: π * r²
            public double CalcularArea()
            {
                return Math.PI * (Raio * Raio);
            }
        }

        class Esfera
        {
            public double Raio;

            // Fórmula do volume da esfera: (4/3) * π * r³
            public double CalcularVolume()
            {
                return (4.0 / 3.0) * Math.PI * (Raio * Raio * Raio);
            }
        }
    }
}
