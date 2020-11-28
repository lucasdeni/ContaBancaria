using System;
using System.Collections.Generic;
using System.Text;

namespace ContaBancaria
{
    abstract class Conta
    {
        //Declaração da variaveis e encapsulamento
        public int Numero { get; private set; }
        public string Titular { get; private set; }
        //Utilização do protected para alteração de valores entre classes
        public double Saldo { get; protected set; }
        public Conta()
        {
            //Construtor padrão
        }
        public Conta(int numero, string titular, double saldo) //Construtor com parâmetros
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
        }
        public virtual void Saque(double saldoTotal) //Realiza o Saque
        {
            Saldo -= saldoTotal;
        }
        public void Deposito(double saldoTotal) //Realiza o Depósito
        {
            Saldo += saldoTotal;
        }
    }
}
