using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                double num1 = 0;
                double num2 = 0;
                double result = 0;

                Console.WriteLine("------------------");
                Console.WriteLine("Programa de cálculo");
                Console.WriteLine("------------------");

                Console.Write("Insira o primeiro número: ");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Insira o segundo número: ");
                num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Operadores: ");
                Console.WriteLine("\t+ : Soma");
                Console.WriteLine("\t- : Subtração");
                Console.WriteLine("\t* : Multiplição");
                Console.WriteLine("\t/ : Divisão");
                Console.Write("Escolha uma opção: ");


                switch (Console.ReadLine())
                {
                    case "+":
                        result = num1 + num2;
                        Console.WriteLine($"Seu resultado: {num1} + {num2} = " + result);
                        break;
                    case "-":
                        result = num1 - num2;
                        Console.WriteLine($"Seu resultado: {num1} - {num2} = " + result);
                        break;
                    case "*":
                        result = num1 * num2;
                        Console.WriteLine($"Seu resultado: {num1} * {num2} = " + result);
                        break;
                    case "/":
                        result = num1 / num2;
                        Console.WriteLine($"Seu resultado: {num1} / {num2} = " + result);
                        break;
                    default:
                        Console.WriteLine("That was not a valid option");
                        break;
                }
                Console.Write("Você gostaria de continuar? (S = sim, N = Não): ");
            } while (Console.ReadLine().ToUpper() == "S");

            Console.WriteLine("Até logo!");
            Console.ReadKey();
        }
    }
}