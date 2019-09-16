using System;

namespace ConversaoDeTempo {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Informe a quantidade de segundos");
            int n = int.Parse(Console.ReadLine());

            int horas = n / 3600;
            int resto = n % 3600;
            int minutos = resto / 60;
            int segundos = resto % 60;

            Console.WriteLine("Os segundos convertidos para horas:minutos:segundos é: " + horas + ":" + minutos + ":" + segundos);
            Console.ReadLine();

        }
    }
}
