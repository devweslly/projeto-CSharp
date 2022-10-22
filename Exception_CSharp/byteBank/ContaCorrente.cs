using byteBank.Titular;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;

namespace byteBank
{
    public class ContaCorrente
    {
        // Os campos de uma classe possuem valores padrão
        public Cliente Titular { get; set; }

        public static double TaxaOperacao { get; private set; }

        public static int TotalDeContasCriadas { get; private set; }

        public int ContadorSaquesNaoPermitidos { get; private set; }
        
        public int ContadorTransferenciasNaoPermitidos { get; private set; }

        private int _conta;

        // Ao remover o campo set o compilador cria um campo privado de somente leitura (ReadOnly)
        // que é devolvido no get. No construtor é possível atribuir um valor, mas ao longo do código
        public int Numero { get; }

        private int _agencia;
        public int Agencia { get; }

        private double _saldo = 100;

        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }

                _saldo = value;
            }
        }
        public string Nome_agencia { get; set; }
        private double saldo;

        // Método - Comportamento

        // Construtor da classe. Exige que seja criado parametros quando for criar um objeto
        public ContaCorrente(int agencia, int numero)
        {
            Agencia = agencia;
            Numero = numero;

            /*
             * O try catch nos auxilia a tratar exceções.
             * Não é correto propagar erros com retorno de métodos;
             * Podemos usar as exceções do .NET e para tratá-las,
             * basta usar os blocos try/catch;
             * As exceções são representadas por objetos e duas propriedades
             * importantes são a Message e StackTrace.
            */

            /*
            // Tente executar este escopo de código
            try
            {
                TaxaOperacao = 30 / TotalDeContasCriadas;
            }
            // Se for encontrado alguma Exception, execute este bloco de cógido
            catch (DivideByZeroException)
            {
                Console.WriteLine("Ocorreu um erro! Não é possível dividir por zero.");
            }
            */


            // ArgumentException é uma classe para representar uma exceção de argumento inválido
            if (agencia <= 0)
            {
                throw new ArgumentException("O argumento Agencia deve ser maior que zero!", nameof(agencia));
            }
            if (numero <= 0)
            {
                throw new ArgumentException("O argumento Numero deve ser maior que zero!", nameof(numero));
            }

            TotalDeContasCriadas += 1;
        }

        // Retorna um valor, pois o método tem um tipo (neste caso, TRUE)
        public void Sacar(double valor)
        {
            if (_saldo < valor)
            {
                ContadorSaquesNaoPermitidos++;
                throw new SaldoInsuficienteException($"Saldo insuficiente para saque no valor de {valor}");
            }
            _saldo -= valor;
            
        }

        // Este método void não retorna um valor
        public void Depositar(double valor)
        {
            if (valor > 0)
            {
                saldo += valor;
            }
        }

        // O método Transferir possui mais de um parametro
        public void Transferir(double valor, ContaCorrente contaDestino)
        {

            try
            {
                Sacar(valor);
            }
            catch (SaldoInsuficienteException ex)
            {
                ContadorTransferenciasNaoPermitidos++;
                throw new OperacaoFinanceiraException("Operação não realizada.", ex);
            }

            _saldo -= valor;
            contaDestino.Depositar(valor);
        }

        // métodos de acesso
        //public void SetSaldo(double valor)
        //{
        //    if (valor < 0)
        //    {
        //        return;
        //    }
        //    else
        //    {
        //        saldo += valor;
        //    }
        //}

        //public double GetSaldo()
        //{
        //    return saldo;
        //}

    }
}