﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConversoesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");

            double salario = 1200.50;

            // O int é um tipo de variável de 32 bits
            int salarioEmInteiro = (int)salario;
            Console.WriteLine("Salario em inteiro:" +salarioEmInteiro);

            // O long é um tipo de variável de 64 bits
            long idadeDoUniverso = 13000000000000;
            Console.WriteLine("Salario em inteiro:" +idadeDoUniverso);

            // O short é um tipo de variável de 16 bits
            short quantidadeProdutos = 15000;
            Console.WriteLine("Quantidade de produtos:" +quantidadeProdutos);

            // O float é um tipo de variável de 64 bits
            float altura = 1.80f;
            Console.WriteLine("altura:" +altura);

            Console.ReadLine();
            
        }
    }
}
