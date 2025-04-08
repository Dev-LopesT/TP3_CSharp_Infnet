namespace Tp3_CSharp_Infnet.Exercicios
{
    public static class Exercicio01
    {
        public static void Executar()
        {
            Console.WriteLine("Exercício 01 - Conceitos de Classe, Objeto, Campos e Métodos\n");

            // Classe: é um molde ou modelo que define como um objeto será.
            // No exemplo abaixo, criamos a classe "Carro".

            // Objeto: é uma instância concreta de uma classe.
            // Criamos um objeto "meuCarro" baseado na classe "Carro".

            // Campos (ou Atributos): são as variáveis que armazenam o estado do objeto.
            // Ex: marca e velocidade.

            // Métodos: são as ações que o objeto pode realizar ou que manipulam seus dados.
            // Ex: Acelerar.

            // Criando e usando um objeto:
            Carro meuCarro = new Carro();
            meuCarro.Marca = "Toyota";
            meuCarro.Velocidade = 0;

            Console.WriteLine($"Marca do carro: {meuCarro.Marca}");
            Console.WriteLine($"Velocidade atual: {meuCarro.Velocidade} km/h");

            // Chamando o método Acelerar
            meuCarro.Acelerar(30);
            Console.WriteLine($"Velocidade após acelerar: {meuCarro.Velocidade} km/h");
        }

        // Classe "Carro" definida dentro do mesmo arquivo para fins de exemplo
        class Carro
        {
            // Campos (ou Atributos)
            public string Marca;
            public int Velocidade;

            // Método
            public void Acelerar(int incremento)
            {
                Velocidade += incremento;
            }
        }
    }
}
