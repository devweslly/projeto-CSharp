using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos_CSharp.Cap4_Estruturas_Repeticao
{
    public class Algoritmo161
    {
        public void ExemploFor()
        {
            double num;
            for (int c = 1; c <= 5; c++)
            {
                Console.Write("Número: ");
                num = Convert.ToDouble(Console.ReadLine());
                double quadrado = num * num;
                Console.WriteLine("Quadrado: " + (quadrado));
            }
        }
    }
}
