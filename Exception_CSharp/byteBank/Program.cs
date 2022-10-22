using byteBank;
using byteBank.Titular;
using System.Numerics;

namespace byteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Boas Vindas ao seu banco, ByteBank!");

            CarregaContas();

            // O console fica aguardando teclar uma tecla para sair do programa
            Console.ReadKey();
        }

        // Métodos

        private static void CarregaContas()
        {
            using(LeitorDeArquivos leitor = new LeitorDeArquivos("contas.txt"))
            {
                leitor.LerProximaLinha();
                leitor.LerProximaLinha();
                leitor.LerProximaLinha();
            }
            /*
            catch (IOException e)
            {
                Console.WriteLine("Exceção do tipo IOException capturada e tratada.");
            }
            // O finally será um bloco que sempre será executado independente
            // se será encontrado uma exceção tratada ou não
            finally
            {
                if (leitor != null)
                {
                    leitor.Fechar();
                }
            }
            */
        }

        private static void TestaException()
        {
            try
            {
                ContaCorrente conta = new ContaCorrente(5265, 52665);
                ContaCorrente conta2 = new ContaCorrente(5245, 52425);
                conta.Depositar(50);
                Console.WriteLine($"Saldo: {conta.Saldo}");
                //conta.Sacar(500);
                conta.Transferir(500, conta2);
                Console.WriteLine($"Saldo: {conta.Saldo}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Erro no parâmetro: {ex.ParamName}");
                Console.WriteLine("Ocorreu um erro do tipo ArgumentException");
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.Message);
            }
            catch (OperacaoFinanceiraException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);

                Console.WriteLine("Informações do INNER EXCEPTION (exceção interna):");

                // O InnerException deixa claro o que causou uma determinada exceção
                // E mostra até onde o método foi tratado
                // Sem mostrar para o usuário infos sensíveis, apenas para o desenvolvedor

                Console.WriteLine(ex.InnerException.Message);
                Console.WriteLine(ex.InnerException.StackTrace);
            }

            //Metodo();

            /*
            try
            {
                Metodo();
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            */
        }

        static void Metodo()
        {
            TestaDivisao(2);
        }

        static void TestaDivisao(int divisor)
        {
            int resultado = Dividir(10, divisor);
            Console.WriteLine($"Resultado de 10 dividido por {divisor} é igual a {resultado}");
        }

        public static int Dividir(int numero, int divisor)
        {
            try
            {
                return numero / divisor;
            }
            catch
            {
                // O throw obriga a lançar uma exceção continuando a execução do programa
                // e prucura a exceção e como ela quer ser tratada
                Console.WriteLine(String.Format("Exceção com número = {0} e divisor = {1}", numero, divisor));
                throw;
            }
        }


        void CodeProjetoAnterior()
        {
            /*

        // Criando nova instancia do objeto do tipo ContaCorrente
        ContaCorrente conta1 = new ContaCorrente();

        // Acessando propriedades/atributos da class ContaCorrente
        conta1.titular_nome = "André Silva";
        conta1.conta = "10123-x";
        conta1.numero_agencia = 23;
        conta1.nome_agencia = "Angência Central";
        conta1.saldo = 100;

        ContaCorrente conta2 = new ContaCorrente();
        conta2.titular_nome = "Amanda Xavier";
        conta2.conta = "111999-x";
        conta2.numero_agencia = 58;
        conta2.nome_agencia = "Agência Central";
        conta2.saldo = 100;

        Console.WriteLine($"Saldo Amanda pré-saque: {conta2.saldo}");

        // Chamando o método Sacar
        bool saque = conta2.Sacar(50);
        Console.WriteLine($"Saque executado com sucesso {saque}");
        Console.WriteLine($"Saldo Amanda pós-saque: {conta2.saldo}");

        // Chamando o método Depositar
        conta2.Depositar(60);
        Console.WriteLine($"Saldo Amanda pós-depósito: {conta2.saldo}");

        // Chamando o método Transferir
        bool transferencia = conta1.Transferir(50, conta2);
        Console.WriteLine($"Transferência executada com sucesso {transferencia}");
        Console.WriteLine($"Saldo Andre pós-transferência: {conta1.saldo}");
        Console.WriteLine($"Saldo Amanda pós-transferência: {conta2.saldo}");



        Cliente cliente = new Cliente();
        cliente.nome = "Andre Silva";
        cliente.cpf = "111.111.111-11";
        cliente.profissao = "Desenvolvedor de Software";

        ContaCorrente conta3 = new ContaCorrente();
        conta3.titular = new Cliente();
        conta3.titular.nome = "Andre Silva";
        conta3.titular.cpf = "111.111.111-11";
        conta3.titular.profissao = "Desenvolvedor de Software";
        conta3.conta = "2513252-X";
        conta3.numero_agencia = 35;
        conta3.nome_agencia = "Agência Central";

        Console.WriteLine(conta3.titular.nome);
        Cliente sarah = new Cliente();
        sarah.Nome = "Sarah Silva";

        ContaCorrente conta4 = new ContaCorrente(235, "125358-X");
        conta4.Saldo = 150;
        conta4.Titular = sarah;
        Console.WriteLine($"Saldo: {conta4.Titular.Nome}");
        Console.WriteLine($"Saldo: {conta4.Saldo}");
        Console.WriteLine($"Saldo: {conta4.Numero_agencia}");
        Console.WriteLine($"Saldo: {conta4.Conta}");

        ContaCorrente conta5 = new ContaCorrente(235, "125358-X");
        ContaCorrente conta6 = new ContaCorrente(365, "957256-X");

        Console.WriteLine(ContaCorrente.TotalDeContasCriadas);
        */
        }
    }
}