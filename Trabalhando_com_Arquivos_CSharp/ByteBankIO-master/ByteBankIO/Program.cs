using ByteBankIO;
using System.Runtime.CompilerServices;
using System.Text;

partial class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Digite o seu Nome:");
        //var nome = Console.ReadLine();

        var linhas = File.ReadAllLines("contas.txt");
        Console.WriteLine(linhas.Length);

        /*
        foreach (var linha in linhas)
        {
            Console.WriteLine(linha);
        }
        */

        var bytesArquivo = File.ReadAllBytes("contas.txt");
        Console.WriteLine($"Arquivo contas.txt possui {bytesArquivo.Length} bytes");

        File.WriteAllText("EscrevendoComAClasseFile.txt", "Testando File.WriteAllText");

        Console.WriteLine("Aplicação Finaliada!");

        Console.ReadLine();
    }
}