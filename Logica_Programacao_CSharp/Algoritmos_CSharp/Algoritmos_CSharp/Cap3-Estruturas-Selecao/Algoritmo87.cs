using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos_CSharp.Cap3_Estruturas_Selecao
{
    public class Algoritmo87
    {
        /*
         * Criar um algoritmo que permita ao aluno responder qual a capital do Brasil.
         * Todas as possibilidades deverão ser pensadas.
        */

        public void Geo()
        {
            Console.WriteLine("Qual a capital do Brasil?");
            string respostaEntrada = Console.ReadLine();
            string respostaCorreta = "Brasília";
            string respostaParcial = "Brazília";

            if(respostaEntrada.Trim() == respostaCorreta || respostaEntrada.Trim() == respostaCorreta.ToUpper())
            {
                Console.WriteLine("Acertou mizerável!");
            }
            else if (respostaEntrada.Trim() == respostaParcial || respostaEntrada.Trim() == respostaParcial.ToUpper() || respostaEntrada.Trim() == respostaParcial.ToLower() || respostaEntrada.Trim() == respostaCorreta.ToLower())
            {
                Console.WriteLine("Mizerável, mais atenção na gráfia! Brasília ou BRASÍLIA");
            }
            else
            {
                Console.WriteLine("ERROOOOOOU!");
            }
        }
    }
}
