using ByteBank.Funcionarios;
using ByteBank.Sistema;
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
            //CalcularBonificacao();
            UsarSistema();
            Console.ReadLine();
        }
        public static void UsarSistema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();

            Diretor roberta = new Diretor("554.797.127-12");
            roberta.Nome = "Roberta";
            roberta.Senha = "123";

            GerenteDeConta camila = new GerenteDeConta("135.547.010-41");
            camila.Nome = "Camila";
            camila.Senha = "abc";

            sistemaInterno.Logar(camila, "123");
            sistemaInterno.Logar(camila, "321");

            ParceiroComercial parceiro = new ParceiroComercial();
            parceiro.Senha = "123456";
            sistemaInterno.Logar(parceiro, "123456");

        }
        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Designer pedro = new Designer("841.415.125-52");
            pedro.Nome = "Pedro";

            Diretor roberta = new Diretor("554.797.127-12");
            roberta.Nome = "Roberta";

            Auxiliar igor = new Auxiliar("456.771.452-27");
            igor.Nome = "Igor";

            GerenteDeConta camila = new GerenteDeConta("135.547.010-41");
            camila.Nome = "Camila";

            gerenciador.Registrar(pedro);
            gerenciador.Registrar(roberta);
            gerenciador.Registrar(igor);
            gerenciador.Registrar(camila);

            Console.WriteLine("Total de bonificações do mês " +gerenciador.GetTotalBonificacao());
        }
    }
}
