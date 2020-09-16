using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();
            conta.Saldo = -10;

            Cliente cliente = new Cliente();
            cliente.Nome = "Guilherme";
            cliente.CPF = "434.564.879-20";
            cliente.Profissao = "Desenvolvedor";

            conta.Titular = cliente;

            Console.WriteLine(conta.Saldo);
            Console.WriteLine(conta.Titular.Nome);
            Console.ReadLine();
        }
    }
}
