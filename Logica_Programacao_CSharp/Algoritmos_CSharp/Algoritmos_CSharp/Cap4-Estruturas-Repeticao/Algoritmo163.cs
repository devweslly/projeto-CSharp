using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos_CSharp.Cap4_Estruturas_Repeticao
{
    public class Algoritmo163
    {

        /*
         * For dentro de For
         * Para cada iteração (primeiro For) e feito uma outra iteração (segunda For)
         * O segunda For realiza cinco repetições completas, antes de fazer a sexta repetição
         * ele sai do segundo For e faz a segunda iteração do primeiro For
        */

        public void Corredor()
        {
            int repeticaoForFora;
            int repeticaoForDentro;

            for (repeticaoForFora = 1; repeticaoForFora <= 3; repeticaoForFora++)
            {
                Console.WriteLine($"Repetição do primeiro For: {repeticaoForFora}.");

                for (repeticaoForDentro = 1; repeticaoForDentro <= 5; repeticaoForDentro++)
                {
                    Console.WriteLine($"* Repetição do segundo For: {repeticaoForDentro}.");
                }
            }
        }
    }
}
