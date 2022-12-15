using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos_CSharp.Cap4_Estruturas_Repeticao
{
    public class Algoritmo167
    {
        public void Desafio3_2()
        {
            int linha, coluna, t;
            Console.WriteLine("ACIMA DA DIAGONAL PRINCIPAL");

            for (linha = 1; linha <= 9; linha++)
            {
                for (coluna = (linha + 1); coluna <= 10; coluna++)
                {
                    Console.Write($"L{linha} - C{coluna} ");
                }
                
                Console.WriteLine("");

                for (t = 1; t <= linha; t++)
                {
                    Console.Write("\t");
                }
            }
        }
    }
}
