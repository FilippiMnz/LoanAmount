using System;
namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Hey Master! How can I be of use to you today?");
            Console.WriteLine("1- simulate loan");
            Console.WriteLine("0- exit");
            short options = short.Parse(Console.ReadLine());

            switch (options)
            {
                case 1: aplicacao(); break;
                case 0: System.Environment.Exit(0); break;
            }
        }
        static void aplicacao()
        {
            Console.Clear();
            Console.WriteLine("Qual o valor do emprestimo? ");
            double montante = int.Parse(Console.ReadLine());
            Console.WriteLine("quantos meses você quer ver o total do pagamento? ");
            double meses = double.Parse(Console.ReadLine());
            Console.Clear();
            double i = 1;
            double LoanAmonth = montante;
            while (i <= meses)
            {
                Console.WriteLine("O valor atual de pagamento é de " + LoanAmonth);
                LoanAmonth -= LoanAmonth / (100.0 * 0.10);
                i++;

            }
        }

    }

}


