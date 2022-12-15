using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos_CSharp.Cap4_Estruturas_Repeticao
{
    public class Algoritmo182
    {
        // Entrar com 10 números e imprimir a metade de cada número.

        public void Para9()
        {
            double numeroDigitado;
            double metadeNumero;
            for (int a = 0; a < 10; a++)
            {
                Console.Write($"Entre com um número {(a + 1)}: ");
                numeroDigitado = Convert.ToDouble(Console.ReadLine());

                metadeNumero = numeroDigitado/2;
                Console.WriteLine($"metade: {metadeNumero}");
            }


        }

    }
}
