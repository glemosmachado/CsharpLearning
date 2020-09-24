using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Funcionario funcionario = new Funcionario();
            funcionario.Nome = "Carlos";
            funcionario.CPF = "546.879.125-20";
            funcionario.Salario = 2000;

            gerenciador.Registrar(funcionario);

            Console.WriteLine(funcionario.Nome);
            Console.WriteLine(funcionario.GetBonificacao());
            
            Diretor roberta = new Diretor();
            roberta.Nome = "Roberta";
            roberta.CPF = "994.221.334-28";
            roberta.Salario = 5000;

            gerenciador.Registrar(roberta);

            Console.WriteLine(roberta.Nome);
            Console.WriteLine(roberta.GetBonificacao());

            Console.WriteLine("Total de bonificação" +gerenciador.GetTotalBonificacao());

            Console.ReadLine();
        }
    }
}
