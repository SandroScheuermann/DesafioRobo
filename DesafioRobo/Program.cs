using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboEncapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            string posInicial = "";
            string movimento = "";

            Console.WriteLine("Digite a dimensão(X,Y) do grid :");
            string grid = Console.ReadLine();

            while (true)
            {
                Console.WriteLine("\nDigite a posição inicial do robô :");

                posInicial = Console.ReadLine();

                Robo robo = new Robo(grid, posInicial);

                Console.WriteLine("\nDigite o movimento do robô :");

                movimento = Console.ReadLine();

                robo.Mover(movimento);

            }
        }
    }
}
