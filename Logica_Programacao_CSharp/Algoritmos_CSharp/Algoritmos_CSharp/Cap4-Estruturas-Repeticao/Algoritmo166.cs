using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos_CSharp.Cap4_Estruturas_Repeticao
{
    public class Algoritmo166
    {
        public void Desafio3_1()
        {
            int linha, coluna;
            Console.WriteLine("TODOS");

            for (linha = 1; linha <= 10; linha++)
            {
                for (coluna = 1; coluna <= 10; coluna++)
                {
                    Console.Write($"L{linha}-C{coluna}\t");
                }
                Console.WriteLine("");
            }
        }
    }
}
