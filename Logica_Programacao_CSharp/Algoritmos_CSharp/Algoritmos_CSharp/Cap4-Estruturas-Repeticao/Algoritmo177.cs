using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos_CSharp.Cap4_Estruturas_Repeticao
{
    public class Algoritmo177
    {
        // Imprimir os múltiplos de 5, no intervalo de 1 até 500.

        public void Para4()
        {
            for (int i = 5; i <= 500; i++)
            {
                // O operador % traz o resto da divisão
                int verificaPar = i % 5;
                if (verificaPar == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
