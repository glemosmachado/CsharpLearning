using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            ContaCorrente conta = new ContaCorrente();
            //conta.titular = new Cliente();
            //conta.titular.nome = "Gabriela Costa";
            //conta.titular.profissao = "Desenvolvedora C#";
            //conta.titular.cpf = "434.532.878-20";
            conta.saldo = 500;
            conta.agencia = 563;
            conta.numero = 5634257;

            if (conta.titular == null) 
            {
                Console.WriteLine("A Referência é nula");
            }


            Console.WriteLine();
            Console.WriteLine(conta.titular.nome);


            Console.ReadLine();
        }
    }
}
