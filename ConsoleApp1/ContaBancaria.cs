using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio2
{
    public class ContaBancaria
    {
        public string titular;
        public double saldo;

        public void SetTitular(string nome)
        {
            this.titular = nome;
        }
        public string GetTitular()
        {
            return titular;
        }
        public void Depositar(double dinheiro)
        {
            this.saldo += dinheiro;
        }
        public void Sacar(double dinheiro)
        {
            this.saldo -= dinheiro;
        }
        public string ExibirSaldo()
        {
            return "R$" + this.saldo.ToString("F2");
        }
        public override string ToString()
        {
            return "Nome do titular: " + titular + "\nSaldo: R$" + saldo.ToString("F2");
        }

    }
}
