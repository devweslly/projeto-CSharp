using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos_CSharp.Cap3_Estruturas_Selecao
{
    public class Algoritmo86
    {
        // Ler um número e imprimir se ele é positivo, negativo ou nulo.

        public void Pnn(int numero)
        {
            if (numero > 0)
            {
                Console.WriteLine(numero + " é positivo.");
            }
            else if (numero < 0)
            {
                Console.WriteLine(numero + " é negativo.");
            }
            else
            {
                Console.WriteLine(numero + " é nulo.");
            }

            /*
             * Por que não se perguntou se o numero era igual a zero?
             * Quando temos a possibilidade de três respostas, só precisamos fazer
             * duas perguntas, pois a segunda pergunta nos dá as duas últimas respostas.
             * Veja bem: se descartarmos a possibilidade de o número ser maior do que O,
             * ficamos com duas possibilidades:
             * o número ser iguala O ou menor do que O; dessa forma, uma pergunta é satisfatória.
            */
        }
    }
}
