using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos_CSharp.Cap4_Estruturas_Repeticao
{
    public class Algoritmo184
    {
        // Entrar com 8 números e, para cada número, imprimir o logaritmo desse número na base 10. 

        public void Para11()
        {
            double numeroDigitado;
            double logBase10;
            for (int a = 0; a <= 7; a++)
            {
                Console.Write($"Entre com um número {(a + 1)}: ");
                numeroDigitado = Convert.ToDouble(Console.ReadLine());

                if (numeroDigitado > 0)
                {
                    logBase10 = Math.Log10(numeroDigitado);
                    Console.WriteLine($"logaritmo na base 10: {logBase10}");
                }
                else
                {
                    Console.WriteLine("Não existe logaritmo de número negativo no campo dos reais");
                }
                
            }


        }

    }
}
