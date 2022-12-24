using bytebank.Modelos.Conta;
using bytebank_ATENDIMENTO.bytebank.Exception;
using bytebank_ATENDIMENTO.bytebank.Util;

namespace bytebank_ATENDIMENTO.bytebank.Atendimento
{
    public class ByteBankAtendimento
    {
        
        // Uma classe genérica, como a List<>, significa que preciso passar o seu tipo
        // Utilizamos aqui o recurso generics que é isso aqui <tipo>
        // Agora a _listaDeContas só irá receber objetos do tipo 
        private List<ContaCorrente> _listaDeContas = new List<ContaCorrente>()
        {
            new ContaCorrente(95, "123456-X"){Saldo = 100, Titular = new Cliente{Cpf = "111.111.111-11", Nome = "Junior" } },
            new ContaCorrente(95, "951258-X"){Saldo = 200, Titular = new Cliente{Cpf = "222.222.222-22", Nome = "Amanda" }},
            new ContaCorrente(94, "987321-X"){Saldo =  60, Titular = new Cliente{Cpf = "333.333.333-33", Nome = "Bruno" }}
        };

        public void AtendimentoCliente()
        {
            try
            {
                char opcao = '0';
                while (opcao != '6')
                {
                    Console.Clear();
                    Console.WriteLine("============================");
                    Console.WriteLine("===      Atendiemnto     ===");
                    Console.WriteLine("=== 1 - Cadastrar Conta  ===");
                    Console.WriteLine("=== 2 - Listar Contas    ===");
                    Console.WriteLine("=== 3 - Remover Conta    ===");
                    Console.WriteLine("=== 4 - Ordenar Contas   ===");
                    Console.WriteLine("=== 5 - Pesquisar Conta  ===");
                    Console.WriteLine("=== 6 - Sair do Sitema   ===");
                    Console.WriteLine("============================");
                    Console.WriteLine("\n\n");
                    Console.Write("Digite a opção desejada: ");

                    try
                    {
                        // O método Readline() retorna uma string, que é um array de caracteres
                        // [0] indica que quero a primeira posição
                        opcao = Console.ReadLine()[0];
                    }
                    catch (ByteBankException excecao)
                    {
                        throw new ByteBankException(excecao.Message);
                    }

                    switch (opcao)
                    {
                        case '1':
                            CadastrarConta();
                            break;
                        case '2':
                            ListarConta();
                            break;
                        case '3':
                            RemoverConta();
                            break;
                        case '4':
                            OrdenarConta();
                            break;
                        case '5':
                            PesquisarConta();
                            break;
                        case '6':
                            EncerrarAplicacao();
                            break;
                        default:
                            Console.WriteLine("Opção não implementada.");
                            break;
                    }
                }
            }
            catch (ByteBankException excecao)
            {

                Console.WriteLine($"{excecao.Message}");
            }
        }

        private void EncerrarAplicacao()
        {
            Console.WriteLine("Encerrando aplicação!");
            Console.ReadKey();
        }

        private void PesquisarConta()
        {
            Console.Clear();
            Console.WriteLine("=============================");
            Console.WriteLine("===    Pesquisar Conta    ===");
            Console.WriteLine("=============================");
            Console.WriteLine("\n");

            Console.Write("Pesquisar (1) Nº da Conta ou (2) CPF Titular ou (3) Nº da Agência: ");

            switch (int.Parse(Console.ReadLine()))
            {
                case 1:
                    {
                        Console.Write("Informe o Número da Conta: ");
                        string _numeroConta = Console.ReadLine();
                        ContaCorrente consultaConta = ConsultaPorContaCorrente(_numeroConta);
                        Console.WriteLine(consultaConta.ToString());
                        Console.ReadKey();
                        break;
                    }
                case 2:
                    {
                        Console.Write("Informe o CPF do Titular: ");
                        string _cpf = Console.ReadLine();
                        ContaCorrente consultaCpf = ConsultaPorCPFTitular(_cpf);
                        Console.WriteLine(consultaCpf.ToString());
                        Console.ReadKey();
                        break;
                    }
                case 3:
                    {
                        Console.Write("Informe o Nº da Agência: ");
                        int _numeroAgencia = int.Parse(Console.ReadLine());
                        var contasPorAgencia = ConsultaPorAgencia(_numeroAgencia);

                        ExibirListaDeContas(contasPorAgencia);

                        Console.ReadKey();
                        break;
                    }
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }

        private void ExibirListaDeContas(List<ContaCorrente> contasPorAgencia)
        {
            if (contasPorAgencia == null)
            {
                Console.WriteLine("A consulta não retornou dados!");
            }

            foreach (var item in contasPorAgencia)
            {
                Console.WriteLine(item.ToString());
            }
        }

        private List<ContaCorrente> ConsultaPorAgencia(int numeroAgencia)
        {
            var consulta =
                (
                    // O from define a origem dos dados
                    from conta in _listaDeContas
                        // O where define o filtro para consulta
                    where conta.Numero_agencia == numeroAgencia
                    // O select seleciona o objeto da coleção (os dados)
                    select conta
                // o método ToList() transforma o resultado em uma lista
                ).ToList();

            return consulta;
        }

        private ContaCorrente ConsultaPorCPFTitular(string? cpf)
        {
            /* Substituido pelo método Where
            ContaCorrente conta = null;
            for (int i = 0; i < _listaDeContas.Count; i++)
            {
                if (_listaDeContas[i].Titular.Cpf.Equals(cpf))
                {
                    conta = _listaDeContas[i];
                }
            }

            return conta;*/

            /* Temos um método genérico LINQ. O LINQ é uma forma de recuperar um
            objeto de uma coleção de dados

            O método Where (método de extensão) retorna um objeto. O where aplica
            a filtragem dos dados diretamente na coleção usando uma expressão lambda.

            O método where é passada uma expressão conhecida como Lambda que vai conter o modo
            de filtragem.No C# toda expressão lambda usa o operador =>.

            Poderiamos traduzir este código como: “ Lista retorne qual ´Qual a conta que possui o
            CPF do titular igual ao passado como parâmetro?
            E me retorne a primeira ocorrência ou o valor padrão.*/

            return _listaDeContas.Where(conta => conta.Titular.Cpf == cpf).FirstOrDefault();
        }

        private ContaCorrente ConsultaPorContaCorrente(string numeroConta)
        {
            /* Substituido pelo método Where
            ContaCorrente conta = null;
            for (int i = 0; i < _listaDeContas.Count; i++)
            {
                if (_listaDeContas[i].Conta.Equals(numeroConta))
                {
                    conta = _listaDeContas[i];
                }
            }

            return conta;*/

            return _listaDeContas.Where(conta => conta.Conta == numeroConta).FirstOrDefault();
        }

        private void OrdenarConta()
        {
            Console.Clear();
            Console.WriteLine("=============================");
            Console.WriteLine("===     Ordenar Conta     ===");
            Console.WriteLine("=============================");
            Console.WriteLine("\n");

            _listaDeContas.Sort();
            Console.WriteLine("Lista ordenada com sucesso!");
            Console.ReadKey();
        }

        private void RemoverConta()
        {
            Console.Clear();
            Console.WriteLine("=============================");
            Console.WriteLine("===     Remover Conta     ===");
            Console.WriteLine("=============================");
            Console.WriteLine("\n");

            Console.Write("Informe o número da Conta: ");
            string numeroConta = Console.ReadLine();
            ContaCorrente conta = null;
            foreach (var item in _listaDeContas)
            {
                if (item.Conta.Equals(numeroConta))
                {
                    conta = item;
                }
            }
            if (conta != null)
            {
                _listaDeContas.Remove(conta);
                Console.WriteLine($"Conta - {conta.Conta} - removida com sucesso!");
            }
            else
            {
                Console.WriteLine($"Conta - {numeroConta} - não encontrada!");
            }
            Console.ReadKey();
        }

        private void ListarConta()
        {
            Console.Clear();
            Console.WriteLine("=============================");
            Console.WriteLine("===    Lista de Conta     ===");
            Console.WriteLine("=============================");
            Console.WriteLine("\n");

            if (_listaDeContas.Count <= 0)
            {
                Console.WriteLine("Não há contas cadastradas!");
                Console.ReadKey();
                // Aqui o return vai sair do método ListarConta
                return;
            }
            foreach (ContaCorrente item in _listaDeContas)
            {
                /* Substituido pelo item.ToString()
                Console.WriteLine("===    Dados da Conta     ===");
                Console.WriteLine($"Número da Conta: {item.Conta}");
                Console.WriteLine($"Saldo da Conta: {item.Saldo}");
                Console.WriteLine($"Titular da Conta: {item.Titular.Nome}");
                Console.WriteLine($"CPF do Titular: {item.Titular.Cpf}");
                Console.WriteLine($"Profissão do Titular: {item.Titular.Profissao}");*/

                Console.WriteLine(item.ToString());

                Console.WriteLine($">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
                Console.ReadKey();
            }
        }

        private void CadastrarConta()
        {
            Console.Clear();
            Console.WriteLine("===============================");
            Console.WriteLine("===     Cadastrar Conta     ===");
            Console.WriteLine("===============================");
            Console.WriteLine("\n");
            Console.WriteLine("== Informe os dados da Conta ==");

            Console.Write("Número Agência: ");
            int numeroAgencia = int.Parse(Console.ReadLine());

            ContaCorrente conta = new ContaCorrente(numeroAgencia);

            Console.WriteLine($"Número da conta [NOVA] : {conta.Conta}");

            Console.Write("Informe o saldo inicial: ");
            conta.Saldo = double.Parse(Console.ReadLine());

            Console.Write("Informe nome do Titular: ");
            conta.Titular.Nome = Console.ReadLine();

            Console.Write("Informe CPF do Titular: ");
            conta.Titular.Cpf = Console.ReadLine();

            Console.Write("Informe Profissão do Titular: ");
            conta.Titular.Profissao = Console.ReadLine();

            _listaDeContas.Add(conta);
            Console.WriteLine("... Conta cadastrada com sucesso! ...");
            Console.ReadKey();
        }
    }
}
