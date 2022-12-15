using bytebank.Modelos.Conta;
using bytebank_ATENDIMENTO.bytebank.Exception;
using bytebank_ATENDIMENTO.bytebank.Util;
using System;
using System.Collections;
using System.Xml;

Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");

#region Exemplos Array em C#
// criando um vetor e já inicializando o array
double[] amostra = new double[] { 3, 5, 7, 15, 20 };

// Chamando métodos
//TestaMediana(CriandoArrayAmostra());
//MediaAmostra(amostra);
//TestaArrayDeContasCorrentes();
//ListaDecontaCorrente();

// Métodos
void TestaArrayInt()
{
    int[] idades = new int[5];
    idades[0] = 30;
    idades[1] = 40;
    idades[2] = 17;
    idades[3] = 21;
    idades[4] = 18;

    int tamanhoArrayLength = idades.Length;
    int tamanhoArrayCount = idades.Count();

    Console.WriteLine("Tamnho total do array");
    Console.WriteLine(String.Format("Length: {0}", tamanhoArrayLength));
    Console.WriteLine(String.Format("Count: {0}", tamanhoArrayCount));

    int acumulador = 0;

    // Exibindo cada indice/posição do Array
    for (int i = 0; i < idades.Length; i++)
    {
        int idade = idades[i];
        Console.WriteLine($"indice: [{i}] = {idades[i]}");
        acumulador += idade;
    }

    double media = acumulador / idades.Length;

    Console.WriteLine($"A soma das idades é {acumulador}.");
    Console.WriteLine($"A média das idades é {media}.");
}

void TestaBuscarPalavra()
{
    string[] arrayDePalavras = new string[5];

    //Colocando elementos dentro do vetor/array
    for (int i = 0; i < arrayDePalavras.Length; i++)
    {
        Console.Write($"Digite a {i + 1}º Palavra: ");
        arrayDePalavras[i] = Console.ReadLine();
    }

    // Escolhendo uma palavra para buscar no vetor/array
    Console.Write("Digite a palavra para ser buscada: ");
    var busca = Console.ReadLine();

    // Percorrer/Iterar um vetor/array testando valor
    // Não é preciso trabalhar com indice
    // Na coleção arrayDePalavras será retornado um item/indice palavra
    foreach (string palavra in arrayDePalavras)
    {
        // Equals verifica se uma string é igual a outra
        if (palavra.Equals(busca))
        {
            Console.WriteLine($"Palavra encontrada = {palavra}");
            // usar o return vai sair do método
            // usar o break vai quebrar o laço
            break;
        }
        else
        {
            Console.WriteLine($"Palavra {busca} não encontrada.");
            break;
        }
    }
}

Array CriandoArrayAmostra()
{
    // Passamos dois paramentros: Tipo do array e o tamanho do array
    // equivale o mesmo que Array amostra = new double[5];
    Array amostra = Array.CreateInstance(typeof(double), 5);
    // O método SetValue recebe como parametro o valor e o indice do array
    amostra.SetValue(5.9, 0);
    amostra.SetValue(1.8, 1);
    amostra.SetValue(7.1, 2);
    amostra.SetValue(10, 3);
    amostra.SetValue(6.9, 4);

    return amostra;
}

// A mediana calcula o valor do meio
void TestaMediana(Array array)
{
    if ((array == null) || (array.Length == 0))
    {
        Console.WriteLine("Array para calcular a mediana está vazio ou nulo");
    }

    // Fazendo clone do array e usando o cash para fazer conversão
    double[] numerosOrdenados = (double[])array.Clone();
    // Ordenando elementos do array
    Array.Sort(numerosOrdenados);

    // Encontrando indice do meio
    int tamanho = numerosOrdenados.Length;
    int meio = tamanho / 2;

    // calculando mediana (é usado o operador ternario para fazer teste booleano)
    // usa ? para indicar verdadeiro e : para indicar falso
    // se caso (tamanho % 2 != 0) for true -> ? numerosOrdenados[meio]
    // se caso (tamanho % 2 != 0) for false -> : (numerosOrdenados[meio] + numerosOrdenados[meio - 1]) / 2
    double mediana = (tamanho % 2 != 0) ? numerosOrdenados[meio] :
        (numerosOrdenados[meio] + numerosOrdenados[meio - 1]) / 2;

    Console.WriteLine($"Com base na amostra a mediana é {mediana}");
}

double MediaAmostra(double[] amostra)
{
    double media;
    double acumulador = 0;

    if ((amostra == null) || (amostra.Length == 0))
    {
        Console.WriteLine("Amostra de dados nula ou vazia.");
        return 0;
    }
    else
    {
        for (int i = 0; i < amostra.Length; i++)
        {
            acumulador += amostra[i];
        }
        media = acumulador / amostra.Length;
    }

    Console.WriteLine(media);

    return media;
}

void TestaArrayDeContasCorrentes()
{
    // Criando um array do tipo ContaCorrente
    ContaCorrente[] listaDeContas = new ContaCorrente[]
    {
        new ContaCorrente(874, "5679787-A"),
        new ContaCorrente(874, "4456668-B"),
        new ContaCorrente(874, "7781438-C"),
    };

    // Iterando sobre o array para exibir os valores da conta
    for (int i = 0; i < listaDeContas.Length; i++)
    {
        ContaCorrente contaAtual = listaDeContas[i];
        Console.WriteLine($"Indice {i} - Agencia: {contaAtual.Numero_agencia} - Conta: {contaAtual.Conta}");
    }
}

void ListaDecontaCorrente()
{
    ListaDeContasCorrentes listaDeContas = new ListaDeContasCorrentes();
    listaDeContas.Adicionar(new ContaCorrente(874, "5679787-A"));
    listaDeContas.Adicionar(new ContaCorrente(874, "4456668-B"));
    listaDeContas.Adicionar(new ContaCorrente(874, "7781438-C"));
    listaDeContas.Adicionar(new ContaCorrente(874, "7781438-C"));
    listaDeContas.Adicionar(new ContaCorrente(874, "7781438-C"));
    listaDeContas.Adicionar(new ContaCorrente(874, "7781438-C"));
    var contaDoAndre = new ContaCorrente(963, "123456-X");
    listaDeContas.Adicionar(contaDoAndre);
    //listaDeContas.ExibeLista();
    //Console.WriteLine("--------------------");
    //listaDeContas.Remover(contaDoAndre);
    //listaDeContas.ExibeLista();

    for (int i = 0; i < listaDeContas.Tamanho; i++)
    {
        ContaCorrente conta = listaDeContas[i];
        Console.WriteLine($"Indice [{i}]: {conta.Conta}/{conta.Numero_agencia}");
    }
}
#endregion

// Uma classe genérica, como a List<>, significa que preciso passar o seu tipo
// Utilizamos aqui o recurso generics que é isso aqui <tipo>
// Agora a _listaDeContas só irá receber objetos do tipo 
List<ContaCorrente> _listaDeContas = new List<ContaCorrente>()
{
    new ContaCorrente(95, "123456-X"){Saldo = 100, Titular = new Cliente{Cpf = "111.111.111-11", Nome = "Junior" } },
    new ContaCorrente(95, "951258-X"){Saldo = 200, Titular = new Cliente{Cpf = "222.222.222-22", Nome = "Amanda" }},
    new ContaCorrente(94, "987321-X"){Saldo =  60, Titular = new Cliente{Cpf = "333.333.333-33", Nome = "Bruno" }}
};

AtendimentoCliente();

void AtendimentoCliente()
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
            Console.Write("Digite a opção desejada:");

            try
            {
                // O método Readline() retorna uma string, que é um array de caracteres
                // [0] indica que quero a primeira posição
                opcao = Console.ReadLine()[0];
            }
            catch (Exception excecao)
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

void PesquisarConta()
{
    Console.Clear();
    Console.WriteLine("=============================");
    Console.WriteLine("===    Pesquisar Conta    ===");
    Console.WriteLine("=============================");
    Console.WriteLine("\n");

    Console.Write("Pesquisar (1) Número da Conta ou (2) CPF Titular: ");

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
        default:
            Console.WriteLine("Opção inválida!");
            break;
    }
}

ContaCorrente ConsultaPorCPFTitular(string? cpf)
{
    ContaCorrente conta = null;
    for (int i = 0; i < _listaDeContas.Count; i++)
    {
        if (_listaDeContas[i].Titular.Cpf.Equals(cpf))
        {
            conta = _listaDeContas[i];
        }
    }

    return conta;
}

ContaCorrente ConsultaPorContaCorrente(string numeroConta)
{
    ContaCorrente conta = null;
    for (int i = 0; i < _listaDeContas.Count; i++)
    {
        if (_listaDeContas[i].Conta.Equals(numeroConta))
        {
            conta = _listaDeContas[i];
        }
    }

    return conta;
}

void OrdenarConta()
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

void RemoverConta()
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

void ListarConta()
{
    Console.Clear();
    Console.WriteLine("=============================");
    Console.WriteLine("===    Lista de Conta     ===");
    Console.WriteLine("=============================");
    Console.WriteLine("\n");

    if (_listaDeContas.Count<=0)
    {
        Console.WriteLine("Não há contas cadastradas!");
        Console.ReadKey();
        // Aqui o return vai sair do método ListarConta
        return;
    }
    foreach (ContaCorrente item in _listaDeContas)
    {
        Console.WriteLine("===    Dados da Conta     ===");
        Console.WriteLine($"Número da Conta: {item.Conta}");
        Console.WriteLine($"Saldo da Conta: {item.Saldo}");
        Console.WriteLine($"Titular da Conta: {item.Titular.Nome}");
        Console.WriteLine($"CPF do Titular: {item.Titular.Cpf}");
        Console.WriteLine($"Profissão do Titular: {item.Titular.Profissao}");
        Console.WriteLine($">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
        Console.ReadKey();
    }
}

void CadastrarConta()
{
    Console.Clear();
    Console.WriteLine("===============================");
    Console.WriteLine("===     Cadastrar Conta     ===");
    Console.WriteLine("===============================");
    Console.WriteLine("\n");
    Console.WriteLine("== Informe os dados da Conta ==");
   
    Console.Write("Número de Conta: ");
    string numeroConta = Console.ReadLine();

    Console.Write("Número Agência: ");
    int numeroAgencia = int.Parse(Console.ReadLine());

    ContaCorrente conta = new ContaCorrente(numeroAgencia, numeroConta);

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

#region Métodos da Coleção List
List<ContaCorrente> _listaDeContas2 = new List<ContaCorrente>()
{
    new ContaCorrente(874, "123456-A"),
    new ContaCorrente(874, "951258-B"),
    new ContaCorrente(874, "987321-C")
};

List<ContaCorrente> _listaDeContas3 = new List<ContaCorrente>()
{
    new ContaCorrente(951, "123456-D"),
    new ContaCorrente(321, "951258-E"),
    new ContaCorrente(719, "987321-F")
};

// Add uma lista no final de outra
_listaDeContas2.AddRange(_listaDeContas3);
// Invertendo ordem da lista
_listaDeContas2.Reverse();

//for (int i = 0; i < _listaDeContas2.Count; i++)
//{
//    Console.WriteLine($"Indice[{i}] : Conta[{_listaDeContas2[i].Conta}]");
//}

Console.WriteLine("\n\n");

// Selecionando elementos de uma lista e adicionando em outra
var range = _listaDeContas3.GetRange(0, 1);
//for (int i = 0; i < range.Count; i++)
//{
//    Console.WriteLine($"Indice[{i}] : Conta[{range[i].Conta}]");
//}

Console.WriteLine("\n\n");

// Limpando conteúdo da lista
range.Clear();
//for (int i = 0; i < range.Count; i++)
//{
//    Console.WriteLine($"Indice[{i}] : Conta[{range[i].Conta}]");
//}
#endregion

#region Classe Genérica
Generica<int> teste1 = new Generica<int>();
//teste1.MostrarMensagem(10);

Generica<string> teste2 = new Generica<string>();
//teste2.MostrarMensagem("Olá Mundo!");

public class Generica<T>
{
    public void MostrarMensagem(T t)
    {
        Console.WriteLine($"Exibindo {t}");
    }
}
#endregion