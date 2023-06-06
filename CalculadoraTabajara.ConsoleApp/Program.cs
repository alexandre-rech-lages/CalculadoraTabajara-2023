﻿namespace CalculadoraTabajara.ConsoleApp
{
    internal class Program
    {
        //1 - Implementar a funcionalidade de somar dois números
        //3 - Implementar a funcionalidade de multiplicar dois números

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

                Console.WriteLine("Digite 3 para Multiplicação\n");

                Console.WriteLine("Digite S para sair\n");

                Console.Write("Opção: ");
                opcao = Console.ReadLine();

                if (opcao.Equals("s", StringComparison.OrdinalIgnoreCase))
                    break;

                #endregion

                #region Realizar Calculo

                Console.Clear();

                Console.WriteLine("Calculadora Tabajara 1.0\n");

                string operacao = "";

                switch (opcao)
                {
                    case "1": operacao = "Adição"; break;

                    case "3": operacao = "Multiplicação"; break;

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

                    case "3": resultado = primeiroNumero * segundoNumero; break;

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