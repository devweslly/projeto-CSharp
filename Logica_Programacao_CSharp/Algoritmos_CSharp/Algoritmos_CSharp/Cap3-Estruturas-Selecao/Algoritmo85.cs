using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos_CSharp.Cap3_Estruturas_Selecao
{
    public class Algoritmo85
    {
        // Armazena na variável max/aux o maior entre 3, imprimindo-o

        public void Descubra(int num1, int num2, int num3)
        {
            int max;

            if (num1 > num2 && num1 > num3)
            {
                max = num1;
            }
            else if (num2 > num1 && num2 > num3)
            {
                max = num2;
            }
            else
            {
                max = num3;
            }

            Console.WriteLine(String.Format("O número máximo é {0}", max));
        }

        public void Descubra2(int num1, int num2, int num3)
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

            Console.WriteLine(String.Format($"O número máximo é {num3}"));
        }
    }
}
