using bytebank.Modelos.Conta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ATENDIMENTO.bytebank.Util
{
    public class ListaDeContasCorrentes
    {
        private ContaCorrente[] _itens = null;
        private int _proximaPosicao = 0;

        // O construtor aqui tem um valor padrão caso nenhum valor seja passado
        public ListaDeContasCorrentes(int tamanhoIncial = 5)
        {
            _itens = new ContaCorrente[tamanhoIncial];
        }

        public void Adicionar(ContaCorrente item)
        {
            Console.WriteLine($"Adicionando item na posição {_proximaPosicao}.");
            // verificando capacidade antes de adicionar um item na posição
            // o tamnho necessário é a posição atual + 1
            // _proximaPosicao é o tamanho atual do array
            verificaCapacidade(_proximaPosicao + 1);
            _itens[_proximaPosicao] = item;
            _proximaPosicao++;
        }

        // Este método é necessário pq o construtor da classe recebe um valor padrao de 5
        private void verificaCapacidade(int tamanhoNecessario)
        {
            if (_itens.Length >= tamanhoNecessario)
            {
                // Aqui o return faz sair do método e não executa o restante do código
                return;
            }
            Console.WriteLine("Aumentando a capacidade da lista");
            ContaCorrente[] novoArray = new ContaCorrente[tamanhoNecessario];

            // Percorrer as posições do array antigo e inserir no novo array
            for (int i = 0; i < _itens.Length; i++)
            {
                // Fazendo clonagem do array antigo no array novo
                novoArray[i] = _itens[i];
            }

            // o array _itens vai apontar para novoArray
            _itens = novoArray;
        }
    }
}
