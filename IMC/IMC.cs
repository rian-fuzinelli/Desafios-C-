using System;

namespace CalculoIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            // Solicita ao usuário o peso e altura
            Console.Write("Por favor, insira o seu peso em kg: ");
            double peso = double.Parse(Console.ReadLine());

            Console.Write("Agora, insira a sua altura em metros: ");
            double altura = double.Parse(Console.ReadLine());

            // Calcula o IMC
            double imc = CalcularIMC(peso, altura);

            // Exibe o IMC
            Console.WriteLine($"\nSeu IMC é: {imc}");

            // Exibe a classificação correspondente
            Console.WriteLine("Classificação: " + ClassificarIMC(imc));
        }

        // Função para calcular o IMC
        static double CalcularIMC(double peso, double altura)
        {
            return peso / (altura * altura);
        }

        // Função para classificar o IMC
        static string ClassificarIMC(double imc)
        {
            if (imc < 18.5)
            {
                return "Abaixo do peso";
            }
            else if (imc >= 18.5 && imc < 24.9)
            {
                return "Peso normal";
            }
            else if (imc >= 25 && imc < 29.9)
            {
                return "Sobrepeso";
            }
            else if (imc >= 30 && imc < 34.9)
            {
                return "Obesidade grau I";
            }
            else if (imc >= 35 && imc < 39.9)
            {
                return "Obesidade grau II";
            }
            else
            {
                return "Obesidade grau III (mórbida)";
            }
        }
    }
}
