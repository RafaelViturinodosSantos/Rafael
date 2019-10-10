using System;
using System.Globalization;

namespace ConversaoDeTempo {
    class Program {
        static void Main(string[] args) {

            NovoSaldo c;

            Console.WriteLine("Informe seu nome");
             string nome = Console.ReadLine();

            Console.WriteLine("Informe a conta");
            int conta = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o cpf");
            long cpf = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe seu saldo");
            double saldo = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            c = new NovoSaldo(nome,conta,cpf,saldo);
            Console.WriteLine("Informe o valor acrescentado de saldo");
            int saldo_novo = int.Parse(Console.ReadLine());
            c.ContaBancaria(saldo_novo);

            Console.WriteLine(c);
            Console.ReadLine();
        }
    }
}
