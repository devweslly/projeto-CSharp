using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos_CSharp.Cap3_Estruturas_Selecao
{
    public class Desafio0301
    {
        /*
         * Neste algortimo será passado via parâmetro do método três números inteiros
         * de forma aleatória. E na saída terá a variável num1, ficará o menor;
         * na variável num2, o do meio; e, na variável num3, o maior.
         * É possível executar este algoritmo para ordenar palavras em ordem alfabética,
         * uma vez que também é uma ordem crescente.
        */

        public void Desaf0301(int num1, int num2, int num3)
        {
            int aux;

            if (num1 > num2)
            {
                aux = num1;
                num1 = num2;
                num2 = aux;
            }
            if (num1 > num3)
            {
                aux = num1;
                num1 = num3;
                num3 = aux;
            }
            if (num2 > num3)
            {
                aux = num2;
                num2 = num3;
                num3 = aux;
            }

            Console.WriteLine("A ordem crescente dos números é:");
            Console.WriteLine($"{num1}, {num2}, {num3}.");
        }
    }
}
