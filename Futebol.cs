using System;
using System.Collections.Generic;

namespace Futebol
{
    class Tabela
    {
        public List<Times> times = new List<Times>();
        public void tabela()
        {
            System.Console.WriteLine("Tabela");
            System.Console.WriteLine("Enter - Adiciona time e pontuação \n0 - exibe a tabela");

             while (Console.ReadKey().Key == ConsoleKey.Enter) {
                System.Console.WriteLine("Diga o nome do time: ");
                string time = Console.ReadLine();

                 System.Console.WriteLine("Diga a pontuação do time: ");
                 int pont = Convert.ToInt32(Console.ReadLine());

                 this.times.Add(new Times(time, pont));
            }

            for (int i = 0; 1 < times.Count; i++){
                times[i].dados();
            }
        }
    }
}