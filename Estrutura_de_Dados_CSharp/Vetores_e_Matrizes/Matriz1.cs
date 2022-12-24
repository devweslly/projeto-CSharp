using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estrutura_de_Dados_CSharp.Vetores_e_Matrizes
{
    public class Matriz1
    {
        /*
         * Escreva um programa em C# que lê uma matriz A (3 x 4) e
         * cria 2 vetores SL e SC de 3 e 4 elementos que contenham
         * respectivamente a soma das linhas (SL) e a soma das colunas
         * (SC). Imprimir os vetores SL e SC.
         */

        public void Matriz01()
        {
            const int numeroLinhas  = 3;
            const int numeroColunas = 4;

            // Matriz
            int[,] a = new int[numeroLinhas, numeroColunas];

            // Vetor
            int[] sl = new int[numeroLinhas];
            int[] sc = new int[numeroColunas];

            for (int l = 0; l < numeroLinhas; l++)
            {
                for (int c = 0; c < numeroColunas; c++)
                {
                    Console.Write("a [" + (l + 1) + "," + (c + 1) + "]: ");
                    String s = Console.ReadLine();
                    a[l, c] = Convert.ToInt32(s);
                }
            }

            int k = 0;
            for (int l = 0; l < numeroLinhas; l++)
            {
                for (int c = 0; c < numeroColunas; c++)
                {
                    sl[k] = sl[k] + a[l, c];
                }
                k++;
            }

            Console.WriteLine();
            for (k = 0; k < numeroLinhas; k++)
            {
                Console.WriteLine("sl[" + (k + 1) + "]: " + sl[k]);
            }

            k = 0;
            for (int c = 0; c < numeroColunas; c++)
            {
                for (int l = 0; l < numeroLinhas; l++)
                {
                    sc[k] = sc[k] + a[l, c];
                }
                k++;
            }

            Console.WriteLine();
            for (k = 0; k < numeroColunas; k++)
            {
                Console.WriteLine("sc[" + (k + 1) + "]: " + sc[k]);
            }
            Console.WriteLine();
        }
    }
}
