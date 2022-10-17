﻿using System;

Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");

// Chamando métodos
TestaMediana(CriandoArrayAmostra());

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
    for(int i = 0; i < arrayDePalavras.Length; i++)
    {
        Console.Write($"Digite a {i+1}º Palavra: ");
        arrayDePalavras[i] = Console.ReadLine( );
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
    if ((array==null) || (array.Length==0))
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
    double mediana = (tamanho % 2 != 0) ? numerosOrdenados[meio] :
        (numerosOrdenados[meio] + numerosOrdenados[meio - 1]) / 2;

    Console.WriteLine($"Com base na amostra a mediana é {mediana}");
}