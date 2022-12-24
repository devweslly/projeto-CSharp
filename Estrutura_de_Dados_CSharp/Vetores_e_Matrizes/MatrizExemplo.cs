namespace Estrutura_de_Dados_CSharp.Vetores_e_Matrizes
{
    public class MatrizExemplo
    {
        // Entrada de uma Matriz Bidimensional
        public void MatrizEx()
        {
            const int numLinhas = 3;
            const int numColunas = 4;

            double[,] matriz = new double[numLinhas, numColunas];

            for (int i = 0; i < numLinhas; i++)
            {
                for (int j = 0; j < numColunas; j++)
                {
                    Console.Write("Valor: ");
                    String s = Console.ReadLine();
                    matriz[i, j] = Convert.ToDouble(s);
                }
            }

            for (int w = 0; w < numLinhas; w++)
            {
                for (int z = 0; z < numColunas; z++)
                {
                    Console.WriteLine(w + " : " + z + " : " + matriz[w, z]);
                }
            }
        }
    }
}
