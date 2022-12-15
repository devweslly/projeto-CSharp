
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos_CSharp.Cap4_Estruturas_Repeticao
{
    public class Algoritmo185
    {
        // Entrar com 15 números e imprimir a raiz quadrada de cada número. 

        public void Para12()
        {
            double numeroDigitado;
            double raizQuadrada;
            for (int a = 0; a <= 14; a++)
            {
                Console.Write($"Entre com um número {(a + 1)}: ");
                numeroDigitado = Convert.ToDouble(Console.ReadLine());

                if (numeroDigitado >= 0)
                {
                    raizQuadrada = Math.Sqrt(numeroDigitado);
                    Console.WriteLine($"raiz quadrada: {raizQuadrada}");
                }
                else
                {
                    Console.WriteLine("Não existe raiz de número negativo no campo dos reais");
                }
                
            }


        }

    }
}
