using System;
using System.Collections.Generic;
using System.Text;

namespace ContaBancaria
{

    class ContaJ : Conta
    {
        public double EmprestimoLimite { get; set; } // Declaração das variáveis e encapsulamento

        public ContaJ()
        {
            //Construtor padrão
        }
        public ContaJ(int numero, string titular, double saldo, double emprestimoLimite) : base(numero, titular, saldo) //Construtor com parâmetros
        {
            EmprestimoLimite = emprestimoLimite;
        }
        public void Emprestimo(double saldoTotal) //Realiza Empréstimo
        {
            if (saldoTotal <= EmprestimoLimite)
            {
                Saldo += saldoTotal;
            }
        }
    }
}
