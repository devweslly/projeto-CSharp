using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos_CSharp.Cap4_Estruturas_Repeticao
{
    public class Algoritmo169
    {
        public void Desafio3_4()
        {
            int linha, coluna, t;
            Console.WriteLine("ABAIXO DA DIAGONAL PRINCIPAL");

            for (linha = 2; linha <= 10; linha++)
            {
                Console.WriteLine("");
                for (coluna = 1; coluna < linha; coluna++)
                {
                    Console.Write($"{linha}-{coluna}\t");
                }

                Console.WriteLine("");

                //for (t = 1; t <= linha; t++)
                //{
                //    Console.Write("\t");
                //}
            }
        }
    }
}
