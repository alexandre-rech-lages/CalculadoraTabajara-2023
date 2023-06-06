﻿namespace CalculadoraTabajara.ConsoleApp
{
    internal class Program
    {
        //1 - Implementar a funcionalidade de somar dois números
        //2 - Implementar a funcionalidade de subtrair dois números
        //3 - Implementar a funcionalidade de multiplicar dois números
        //4 - Implementar a funcionalidade de divisão de dois números

        static void Main(string[] args)
        {
            string opcao;

            while (true)
            {
                #region Menu Principal

                Console.Clear();

                Console.WriteLine("Calculadora Tabajara 1.0\n");

                Console.WriteLine("Tela Principal\n");

                Console.WriteLine("Digite 1 para Adição\n");

                Console.WriteLine("Digite 2 para Subtração\n");

                Console.WriteLine("Digite 3 para Multiplicação\n");

                Console.WriteLine("Digite 4 para Divisão\n");

                Console.WriteLine("Digite S para sair\n");

                Console.Write("Opção: ");
                opcao = Console.ReadLine();

                if (opcao.Equals("s", StringComparison.OrdinalIgnoreCase))
                    break;

                if (opcao != "1" && opcao != "2" && opcao != "3" && opcao != "4")
                {
                    Console.WriteLine("Você precisa digitar uma opção válida!");
                    Console.ReadLine();
                    continue;
                }

                #endregion

                #region Realizar Calculo

                Console.Clear();

                Console.WriteLine("Calculadora Tabajara 1.0\n");

                string operacao = "";

                switch (opcao)
                {
                    case "1": operacao = "Adição"; break;

                    case "2": operacao = "Subtração"; break;

                    case "3": operacao = "Multiplicação"; break;

                    case "4": operacao = "Divisão"; break;

                    default:
                        break;
                }

                string subtitulo = $"Novo calculo de {operacao}";

                Console.WriteLine(subtitulo + "\n");

                Console.Write($"Digite o primeiro número: ");
                double primeiroNumero = Convert.ToDouble(Console.ReadLine());

                Console.Write($"Digite o segundo número: ");
                double segundoNumero = Convert.ToDouble(Console.ReadLine());

                double resultado = 0;

                switch (opcao)
                {
                    case "1": resultado = primeiroNumero + segundoNumero; break;
                    
                    case "2": resultado = primeiroNumero - segundoNumero; break;

                    case "3": resultado = primeiroNumero * segundoNumero; break;

                    case "4": resultado = primeiroNumero / segundoNumero; break;

                    default: 
                        break;
                }
                #endregion

                #region Mostrar Resultado
                Console.Clear();

                Console.WriteLine("Calculadora Tabajara 1.0\n");

                Console.WriteLine("Tela de Resultados\n");

                Console.Write($"O resultado da operação de {operacao} é: {resultado}");

                Console.WriteLine();

                Console.ReadLine();

                Console.Clear();
                #endregion
            }
        }
    }
}