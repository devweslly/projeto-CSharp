using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos_CSharp.Cap4_Estruturas_Repeticao
{
    public class Algoritmo178
    {
        // Imprimir o quadrado dos numeros de 1 ate 20

        public void Para5()
        {
            for (int c = 1; c <= 20; c++)
            {
                int quadradoDeC = c*c;
                Console.WriteLine(quadradoDeC);
            }
        }
    }
}
