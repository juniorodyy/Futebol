using System;
using System.Collections.Generic;

namespace Futebol
{
    class Tabela
    {
        public List<Times> times;
        const int quantrebaixados = 2;
        
        public Tabela() {
            times = new List<Times>();
        }
        
        public void resultado() {
            for (int i = 0; i < this.times.Count; i++)
                time.Scort((a, b) => b.pont.CompareTo(a.pont));
                System.Console.WriteLine($"Time: {times[i].time} - Pontuação: {times[i].pont}");
        }

        
    }
}