using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos_CSharp.Cap3_Estruturas_Selecao
{
    public class Algoritmo84
    {
        public void ParImpar()
        {
            Console.WriteLine("Digite um número: ");
            string numeroString = Console.ReadLine();
            int numero = Convert.ToInt32(numeroString);

            if (numero % 2 == 0)
            {
                Console.WriteLine($"{numero} é PAR");
            }
            else
            {
                Console.WriteLine($"{numero} é IMPAR");
            }
        }
    }
}
