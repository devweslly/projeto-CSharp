using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estrutura_de_Dados_CSharp.Vetores_e_Matrizes
{
    public class VetorExemplo
    {
        // Entrada de um Vetor Unidimensional
        public void VetorEx()
        {
            const int numElementos = 7;

            int[] vetor = new int[numElementos];

            for (int i = 0; i < numElementos; i++)
            {
                Console.Write("Valor: ");
                String s = Console.ReadLine();
                vetor[i] = Convert.ToInt32(s);
            }

            Console.Write("Vetor Entrada: ");
            for (int j = 0; j < vetor.Length; j++)
            {
                Console.Write(vetor[j] + " ");
            }
        }
    }
}
