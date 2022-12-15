using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos_CSharp.Cap3_Estruturas_Selecao
{
    public class Algoritmo83
    {
        /*
         * Ler um número e, se ele for positivo, imprimir seu inverso;
         * caso contrário, imprimir o valor absoluto do número.
        */

        public void InversoAbsoluto()
        {
            // Usando o mesmo tipo para diferentes variáveis
            double numero, inverso, absoluto;

            Console.Write("Digite um número: ");

            // O método ReadLine() da classe Console irá interromper a execução de uma
            // aplicação console, até que o usuário insira um valor.
            // O ReadLine recebe uma string
            string numeroString = Console.ReadLine();

            // double.Parse é o casting (conversão) do valor numeroString para double
            // O método Trim() retira os espaços em branco do início e fim da variável
            numero = double.Parse(numeroString.Trim());

            if (numero > 0)
            {
                inverso = 1 / numero;
                // O $ no antes da abertura de string e {variavel}
                // para interpolar a string com o valor da variavel.
                Console.WriteLine($"O inverso de {numero} é {inverso}");
            }
            else
            {
                absoluto = numero * (-1);
                Console.WriteLine($" O absoluto de {numero} é {absoluto}");
            }
        }
    }
}
