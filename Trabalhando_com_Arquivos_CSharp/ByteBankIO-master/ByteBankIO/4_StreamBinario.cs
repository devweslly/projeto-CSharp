﻿using System.Text;

partial class Program
{
    static void EscritaBianaria()
    {
        using (var fs = new FileStream("contaCorrente.txt", FileMode.Create))
        using (var escritor = new BinaryWriter(fs))
        {
            escritor.Write(456);        // Numero Agencia
            escritor.Write(546544);     // Numero Conta
            escritor.Write(4000.50);    // Saldo
            escritor.Write("Gustavo Braga");
        }
    }

    static void LeituraBinaria()
    {
        using (var fs = new FileStream("contaCorrente.txt", FileMode.Open))
        using (var leitor = new BinaryReader(fs))
        {
            var agencia = leitor.ReadInt32();
            var numeroConta = leitor.ReadInt32();
            var saldo = leitor.ReadDouble();
            var titular = leitor.ReadString();

            Console.WriteLine($"{agencia}/{numeroConta} : {titular} : {saldo}");
        }
    }
}