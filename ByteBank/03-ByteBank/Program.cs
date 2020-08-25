using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tipo de Referência
            ContaCorrente contaDoGabriel = new ContaCorrente();
            //Variável de Referência
            contaDoGabriel.titular = "Gabriel";
            contaDoGabriel.agencia = 863;
            contaDoGabriel.numero = 863452;

            ContaCorrente contaDaGabriela = new ContaCorrente();
            contaDaGabriela.titular = "Gabriela";
            contaDaGabriela.agencia = 863;
            contaDaGabriela.numero = 863452;

            Console.WriteLine("Igualdade de tipo de referência: "+ (contaDoGabriel == contaDaGabriela));

            int idade = 23;
            int idadeMaisUmaVez = 23;

            Console.WriteLine("Igualdade de tipo de referência: " + (idade == idadeMaisUmaVez));

            contaDoGabriel = contaDaGabriela;
            Console.WriteLine("Igualdade de tipo de referência: " + (contaDoGabriel == contaDaGabriela));

            contaDaGabriela.saldo = 300;
            Console.WriteLine(contaDaGabriela.saldo);
            Console.WriteLine(contaDoGabriel.saldo);

            Console.ReadLine();
        }
    }
}
