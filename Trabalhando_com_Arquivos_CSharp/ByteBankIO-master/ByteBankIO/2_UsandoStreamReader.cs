using ByteBankIO;
using System.Text;

partial class Program
{
    static void UsandoStreamReader()
    {
        string endrecoDoArquivo = "contas.txt";

        using (var fluxoDeArquivo = new FileStream(endrecoDoArquivo, FileMode.Open))
        {
            var leitor = new StreamReader(fluxoDeArquivo);

            // Ler uma linha do arquivo
            //var linha = leitor.ReadLine();

            // Ler todo o arquivo
            //var texto = leitor.ReadToEnd();

            // Traz o primeiro byte do arquivo (primeiro caractere)
            //var numero = leitor.Read();

            while (!leitor.EndOfStream)
            {
                var linha = leitor.ReadLine();
                var contaCorrente = ConverterStringParaContaCorrente(linha);

                var msg = String.Format("Titular: {0} - Número Conta: {1} - Agência: {2} - Saldo: {3}", contaCorrente.Titular.Nome, contaCorrente.Numero, contaCorrente.Agencia, contaCorrente.Saldo);
                Console.WriteLine(msg);
            }
        }
    }

    static ContaCorrente ConverterStringParaContaCorrente(string linha)
    {
        // 375 4644 2483.13 Jonathan

        var campos = linha.Split(',');

        var agencia = campos[0];
        var numero = campos[1];
        var saldo = campos[2].Replace('.', ',');
        var nomeTitular = campos[3];

        var agenciaComInt = int.Parse(agencia);
        var numeroComInt = int.Parse(numero);
        var saldoComDouble = double.Parse(saldo);

        var titular = new Cliente();
        titular.Nome = nomeTitular;

        var resultado = new ContaCorrente(agenciaComInt, numeroComInt);
        resultado.Depositar(saldoComDouble);
        resultado.Titular = titular;

        return resultado;
    }
}
