using System;
using System.Collections.Generic;
using System.Globalization;

namespace ContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Conta> list = new List<Conta>(); //Criação da Lista
            //Lista com contas
            list.Add(new ContaP(1001, "Terry", 500.0, 0.01));
            list.Add(new ContaJ(1002, "Andy", 500.0, 400.0));
            list.Add(new ContaP(1003, "Joe", 500.0, 0.01));
            list.Add(new ContaJ(1004, "Mae", 500.0, 400.0));
            double soma = 0.0;
            foreach (Conta acc in list) //Soma os saldos
            {
                soma += acc.Saldo;
            }
            Console.WriteLine("Total do saldo de todas as contas: " + soma.ToString("F2", CultureInfo.InvariantCulture)); //Imprime o saldo total
            foreach (Conta acc in list) //Chama o saque pra cada conta
            {
                acc.Saque(10.0);
            }
            foreach (Conta acc in list) //Imprime o numero da conta e saldo
            {
                Console.WriteLine("Total do saldo de todas as contas:"
                    + acc.Numero + ": "
                    + acc.Saldo.ToString("F2", CultureInfo.InvariantCulture));
            }
            Console.ReadKey();
        }
    }
}
