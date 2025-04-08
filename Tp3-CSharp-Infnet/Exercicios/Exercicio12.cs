using System;

namespace Tp3_CSharp_Infnet.Exercicios
{
    public static class Exercicio12
    {
        public static void Executar()
        {
            Console.WriteLine("Exercício 12 - Testando as Classes de Figuras\n");

            // Instanciando e testando o círculo
            Circulo circulo = new Circulo();
            circulo.Raio = 3.0;
            double area = circulo.CalcularArea();
            Console.WriteLine($"Círculo - Raio: {circulo.Raio}, Área: {area:F2}");

            // Instanciando e testando a esfera
            Esfera esfera = new Esfera();
            esfera.Raio = 5.0;
            double volume = esfera.CalcularVolume();
            Console.WriteLine($"Esfera - Raio: {esfera.Raio}, Volume: {volume:F2}");
        }

        class Circulo
        {
            public double Raio;

            public double CalcularArea()
            {
                return Math.PI * (Raio * Raio);
            }
        }

        class Esfera
        {
            public double Raio;

            public double CalcularVolume()
            {
                return (4.0 / 3.0) * Math.PI * (Raio * Raio * Raio);
            }
        }
    }
}
