using System;
using System.Collections.Generic;
using System.Text;

namespace ContaBancaria
{
    class ContaP : Conta
    {
        public double TaxaJuros { get; set; } //Declaração das variáveis e encapsulamento
        public ContaP()
        {
            //Construtor padrão
        }
        public ContaP(int numero, string titular, double saldo, double taxaJuros) : base(numero, titular, saldo) //Construtor com parâmetros
        {
            TaxaJuros = taxaJuros;
        }
        public sealed override void Saque(double saldoTotal) //Realiza saque
        {
            base.Saque(saldoTotal);
            Saldo -= 2.0;
        }
        public void atualizacaoSaldo() //Atualiza o Saldo
        {
            Saldo += Saldo * TaxaJuros;

        }
    }
}
