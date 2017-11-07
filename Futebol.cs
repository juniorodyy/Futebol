using System;

namespace Futebol
{
    class Tabela
    {
        public List Times times = new List Time();
        public void tabela()
        {
            System.Console.WriteLine("Menu");
            System.Console.WriteLine("Enter - Adiciona time e pontuação \n0 - FInaliza e exibe a tabela");

            While (Console.ReadKey().Key == ConsoleKey.Enter) {
                System.Console.WriteLine("Diga o nome do time: ");
                string time = Console.ReadLine();

                 System.Console.WriteLine("Diga a pontuação do time: ");
                 int pont = convert.ToInt32(Console.ReadLine());
            }

        }
    }
}