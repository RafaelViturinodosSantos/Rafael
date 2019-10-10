using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ConversaoDeTempo {
    class NovoSaldo {

        public string Nome { get; private set; }
        public int Conta { get; private set; }
        public long CPF { get; private set; }
        public double Saldo { get; set; }

        public NovoSaldo(string nome, int conta, long cpf, double saldo) {
            Nome = nome;
            Conta = conta;
            CPF = cpf;
            Saldo = saldo;
        }

        public void ContaBancaria(int saldo_novo) {
             Saldo +=+ saldo_novo;
        }

        public override string ToString() {
            return Nome + ", " + Conta + ", " + CPF + ", " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }



    }

}
