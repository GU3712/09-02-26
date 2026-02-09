using System;

class Program
{
    static void Main(string[] args)
    {
        Banco meuBanco = new Banco();
        meuBanco.Nome = "Banco do Brasil";
        meuBanco.CodigoBACEN = "001";

        ContaBancaria conta1 = new ContaBancaria { Agencia = "1234", NumeroConta = "55667-8" };
        ContaBancaria conta2 = new ContaBancaria { Agencia = "4321", NumeroConta = "11223-4" };

        Transacao minhaTransacao = new Transacao();
        minhaTransacao.Valor = 250.00m;
        minhaTransacao.Data = DateTime.Now;
        minhaTransacao.Tipo = "PIX";
        minhaTransacao.Origem = conta1;
        minhaTransacao.Destino = conta2;

        Console.WriteLine("--- REGISTRO BACEN--");
        Console.WriteLine("Banco: " + meuBanco.Nome);
        Console.WriteLine("Código: " + meuBanco.CodigoBACEN);
        Console.WriteLine("--------------------");
        Console.WriteLine("Tipo: " + minhaTransacao.Tipo);
        Console.WriteLine("Valor: R$ " + minhaTransacao.Valor);
        Console.WriteLine("Data: " + minhaTransacao.Data);
        Console.WriteLine("Origem: " + minhaTransacao.Origem.NumeroConta);
        Console.WriteLine("Destino: " + minhaTransacao.Destino.NumeroConta);
    }
}