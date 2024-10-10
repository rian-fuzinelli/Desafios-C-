using System;

namespace SomaNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int soma = 0;

            // Loop para somar números de 1 a 10
            for (int i = 1; i <= 10; i++)
            {
                soma += i;
            }

            // Exibindo o resultado no console
            Console.WriteLine("A soma dos números de 1 a 10 é: " + soma);
        }
    }
}
