using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboEncapsulamento
{
    class Robo
    {
        private string grid = "", faceAtual = "", posInicial = "";
        private int posX, posY;
        private string[] posInicialDados, gridSplit;
        public Robo(string grid, string posInicial)
        {
            this.posInicial = posInicial;
            this.grid = grid;

        }
        public void Mover(string movimento)
        {
            posInicialDados = posInicial.Split(' ');
            posX = Int16.Parse(posInicialDados[0]);
            posY = Int16.Parse(posInicialDados[1]);
            faceAtual = posInicialDados[2];
            gridSplit = grid.Split(' ');

            if (Int16.Parse(gridSplit[0]) < posX || Int16.Parse(gridSplit[1]) < posY)
            {
                Console.WriteLine("\nPosição inicial fora dos limites do grid ! ");
            }
            else
            {
                for (int i = 0; i < movimento.Length; i++)
                {
                    if (movimento[i].Equals('e') || movimento[i].Equals('E'))
                    {
                        if (faceAtual.Equals("n", StringComparison.OrdinalIgnoreCase))
                        {
                            faceAtual = "O";

                        }
                        else if (faceAtual.Equals("o", StringComparison.OrdinalIgnoreCase))
                        {
                            faceAtual = "S";

                        }
                        else if (faceAtual.Equals("s", StringComparison.OrdinalIgnoreCase))
                        {
                            faceAtual = "L";

                        }
                        else if (this.faceAtual.Equals("l", StringComparison.OrdinalIgnoreCase))
                        {
                            faceAtual = "N";

                        }
                    }
                    else if (movimento[i].Equals('d') || movimento[i].Equals('D'))
                    {

                        if (faceAtual.Equals("n", StringComparison.OrdinalIgnoreCase))
                        {
                            faceAtual = "L";

                        }
                        else if (faceAtual.Equals("o", StringComparison.OrdinalIgnoreCase))
                        {
                            faceAtual = "N";

                        }
                        else if (faceAtual.Equals("s", StringComparison.OrdinalIgnoreCase))
                        {
                            faceAtual = "O";

                        }
                        else if (faceAtual.Equals("l", StringComparison.OrdinalIgnoreCase))
                        {
                            faceAtual = "S";

                        }
                    }
                    else if (movimento[i].Equals('m') || movimento[i].Equals('M'))
                    {

                        if (faceAtual.Equals("n", StringComparison.OrdinalIgnoreCase))
                        {
                            posY++;

                        }
                        if (faceAtual.Equals("s", StringComparison.OrdinalIgnoreCase))
                        {
                            posY--;

                        }
                        if (faceAtual.Equals("l", StringComparison.OrdinalIgnoreCase))
                        {
                            posX++;

                        }
                        if (faceAtual.Equals("o", StringComparison.OrdinalIgnoreCase))
                        {
                            posX--;

                        }
                    }
                }

                if (ValidaMovimento() == true)
                {
                    MostrarResultado();
                }
                else
                {
                    Console.WriteLine("Posição final do movimento fora dos limites do grid!");
                }

            }

        }
        private void MostrarResultado()
        {
            Console.Write("\n" + posX.ToString() + " " + posY.ToString() + " " + faceAtual + "\n");

        }
        private bool ValidaMovimento()
        {
            if (Int16.Parse(gridSplit[0]) < posX || posX<0 || Int16.Parse(gridSplit[1]) < posY || posY<0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
