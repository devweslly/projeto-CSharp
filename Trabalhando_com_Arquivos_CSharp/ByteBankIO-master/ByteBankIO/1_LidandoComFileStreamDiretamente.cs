using ByteBankIO;
using System.Text;

partial class Program
{
    static void LidandoComFileStreamDiretamente()
    {
        var endercoDoArquivo = "contas.txt";

        // O FileStream trabalha com o fluxo de dados do arquivo (não com o arq inteiro, mas em partes)
        // Primeiro argumento informa o endereço do arquivo
        // Segundo argumento informa qual modo de operação usaremos no arquivo
        // O using verifica se o fluxo não é nulo
        using (var fluxoDoArquivo = new FileStream(endercoDoArquivo, FileMode.Open))
        {

            // este valor é -1 para não interferir na sequencia de bytes
            // este valor nunca será retornado pelo Read (pois o byte só pode ser >= 0)
            var numerosDeBytesLidos = -1;




            // Recuperando os bytes que tem dentro do arquivo
            // A var buffer é um array de bytes
            // Bytes lido pelo método Read
            // O array vai armazenar os trechos/bytes (cada uma das partes) que foram lido pelo método
            // O byte varia de 0 a 255 (entao é possível 256 possibilidade)
            var buffer = new byte[1024]; // 1024 posições, e é o tamanho de um 1KB


            while (numerosDeBytesLidos != 0)
            {
                // Aqui vai trabalhar com o buffer da posição 0 à 1024
                // queremos que o Stream use nosso buffer a partir do índice 0 e guarde 1024 bytes nele
                // O método Read() retorna um int indicando quantos bytes foram guardados no buffer.
                // Este número está sempre no intervalo de 0 até o número de bytes que pedimos para
                // o stream ler(1024 nesta chamada).
                numerosDeBytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024);

                Console.WriteLine($"Bytes lidos: {numerosDeBytesLidos}");

                // Devoluções
                // O número total de bytes lidos do buffer (Read). Isso poderá ser menor que o número de
                // bytes solicitado se esse número de bytes não estiver disponível no momeno, ou
                // zero, se o final do fluxo for atingido
                EscreverBuffer(buffer, numerosDeBytesLidos);
            }

            fluxoDoArquivo.Close(); // Fechando o arquivo

            Console.ReadLine();
        }
    }

    private static void EscreverBuffer(byte[] buffer, int bytesLidos)
    {
        // O processo de transformação de uma cadeia de bytes para algo com
        // outro significado é a decodificação.
        // Para realizar a decodificação e a codificação temos a classe Encoding.
        // utilizando o encoding UTF-8

        var encoding = new UTF8Encoding();

        // decodifica desde 0 e a quantidade de bytes Lidos
        var texto = encoding.GetString(buffer, 0, bytesLidos);

        Console.Write(texto);
    }
}