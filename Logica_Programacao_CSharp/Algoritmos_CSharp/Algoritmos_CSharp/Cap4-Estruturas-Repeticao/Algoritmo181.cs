using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos_CSharp.Cap4_Estruturas_Repeticao
{
    public class Algoritmo181
    {
        // Criar um algoritmo que imprima todos os numeros de 1 ate 100 e a soma deles

        public void Para8()
        {
            int i;
            int soma = 0;
            for (i = 1; i <= 100; i++)
            {
                soma += i;
                Console.WriteLine(i);
            }
            Console.WriteLine(String.Format("A soma dos números 1 a 100 é {0}", soma));
        }
    }
}
