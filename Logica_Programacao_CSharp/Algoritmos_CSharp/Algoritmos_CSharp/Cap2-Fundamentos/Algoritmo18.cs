using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos_CSharp.Cap2_Fundamentos
{
    public class Algoritmo18
    {
        /*
         * O conteúdo da variável x é copiado da memória e acrescido de um,
         * sendo impresso, após a string, sem alterar o valor de x na Memória Principal (MP).
        */


        public void Prog18()
        {
            int x;
            x = 10;

            Console.WriteLine("O valor de x = " + (x + 1));
        }
    }
}
