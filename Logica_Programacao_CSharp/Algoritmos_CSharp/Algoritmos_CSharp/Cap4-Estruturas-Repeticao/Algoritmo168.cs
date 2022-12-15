using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos_CSharp.Cap4_Estruturas_Repeticao
{
    public class Algoritmo168
    {
        public void Desafio3_3()
        {
            Console.WriteLine("Diagonal Princial");
            for (int linha = 1; linha <= 10; linha++)
            {
                Console.WriteLine($"{linha} - {linha}");
                for (int t = 1; t <= linha; t++)
                {
                    Console.Write("\t");
                }
            }
            Console.WriteLine("");
        }
    }
}
