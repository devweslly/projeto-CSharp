using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos_CSharp.Cap4_Estruturas_Repeticao
{
    public class Algoritmo176
    {
        // Imprimir os 100 primeiros pares.

        public void Para3()
        {
            for (int i = 2; i <= 100; i+=2)
            {
                // O operador % traz o resto da divisão
                int verificaPar = i % 2;
                if (verificaPar == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
