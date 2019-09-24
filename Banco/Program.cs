using Banco.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();
            Conta conta = new Conta();
            string Deposito = "";
            string Saque = "";

            while (true)
            {
                Console.WriteLine("Escolha uma das operações abaixo:");
                Console.WriteLine("1 - Depositar");
                Console.WriteLine("2 - Sacar");
                Console.WriteLine("3 - Extrato");
                Console.WriteLine("4 - Sair");

                String op = Console.ReadLine();
                switch (op)
                {
                    case "1":
                        Console.WriteLine("Valor do depósito:");
                        Deposito = Console.ReadLine();
                        conta.DepositarValor = Convert.ToDouble(Deposito);
                        Console.WriteLine($"Depósito: {conta.DepositarValor}") ;
                        Console.WriteLine($"Saldo: {conta.Deposita()}");
                        Console.WriteLine("...............................");
                        break;

                    case "2":
                        Console.WriteLine("Valor do saque:");
                        Saque = Console.ReadLine();
                        conta.SacarValor = Convert.ToDouble(Saque);
                        Console.WriteLine($" Saque: {conta.SacarValor}");
                        Console.WriteLine($"Saldo: {conta.Saca()}");
                        Console.WriteLine("...............................");
                        break;

                    case "3":
                        Console.WriteLine("Extrato:");
                        Console.WriteLine(conta.extrato.ToString());
                        Console.WriteLine("...............................");

                        break;

                    case "4":
                        Environment.Exit(0);
                        break;
                }
            }

        }
    }
}
//Função Sair do Programa ""