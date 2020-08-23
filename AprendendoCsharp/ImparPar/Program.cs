using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImparPar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciação da variável inicializadora
            int numero = 0;

            //Enquanto o numero for menor ou igual a 100
            while (numero <= 100)
            {
                //Se o mod do número for igual a zero, printa que é par 
                if (numero % 2 == 0)
                {
                    Console.WriteLine(numero + " O número é par");
                    numero++;
                }
                //Se o mod do número for diferente a zero, printa que é impar
                else
                {
                    Console.WriteLine(numero + " O número é impar");
                    numero++;
                }
            }
            Console.ReadLine();
        }
    }
}
