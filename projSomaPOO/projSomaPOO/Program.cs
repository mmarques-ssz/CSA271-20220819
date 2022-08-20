using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projSomaPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Soma soma1;
            soma1 = new Soma();

            Console.Write("Digite o 1º valor: ");
            soma1.setN1(int.Parse(Console.ReadLine()));

            Console.Write("Digite o 2º valor: ");
            soma1.setN2(int.Parse(Console.ReadLine()));

            soma1.somar();

            Console.WriteLine("A soma de {0} com {1} é {2}", 
                soma1.getN1(), soma1.getN2(), soma1.getResultado());

        }
    }
}
