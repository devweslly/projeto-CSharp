using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

partial class Program
{
    static void CriarArquivo()
    {
        var caminhoNovoArquivo = "contasExportadas.csv";

        using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
        {
            var contaComoString = "456,7895,4785.40, Gustavo Santos";

            var enconding = Encoding.UTF8;

            // Guardando os Bytes da String (Aposto do GetString)
            var bytes = enconding.GetBytes(contaComoString);

            // O terceiro parametro informa que queremos toda a informação, o tamanho de bytes
            fluxoDeArquivo.Write(bytes, 0, bytes.Length);
        }
    }

    // Abstração de como criar um arquivo
    static void CriarArquivoComWriter()
    {
        var caminhoNovoArquivo = "contasExportadas.csv";

        // Creat - cria um arquivo e substitui | CreateNew - ´cria um novo arquivo se ele ainda não existe
        // StreamWriter para gravar caracteres em um fluxo com uma codificação específica
        using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
        using (var escritor = new StreamWriter(fluxoDeArquivo, Encoding.UTF8))
        {
            escritor.Write("456,65465,456.0,Pedro");
        }
    }

    static void TestaEscrita()
    {
        var caminhoNovoArquivo = "teste.txt";

        using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
        using (var escritor = new StreamWriter(fluxoDeArquivo))
        {
            for (int i = 0; i < 1000000; i++)
            {
                escritor.WriteLine($"Linha {i}");
                escritor.Flush(); // Despeja o buffer para o Stream

                Console.WriteLine($"Linha {i} foi escrita no arquivo. Tecle enter...");
                Console.ReadLine();
            }
        }
    }
}
