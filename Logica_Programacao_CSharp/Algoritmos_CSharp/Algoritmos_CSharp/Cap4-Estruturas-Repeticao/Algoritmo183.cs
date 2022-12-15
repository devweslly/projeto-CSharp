using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos_CSharp.Cap4_Estruturas_Repeticao
{
    public class Algoritmo183
    {
        // Entrar com 10 números e imprimir o quadrado de cada número. 

        public void Para10()
        {
            double numeroDigitado;
            double quadrado;
            for (int a = 0; a < 10; a++)
            {
                Console.Write($"Entre com um número {(a + 1)}: ");
                numeroDigitado = Convert.ToDouble(Console.ReadLine());

                quadrado = Math.Pow(numeroDigitado, 2);
                Console.WriteLine($"quadrado: {quadrado}");
            }


        }

    }
}
