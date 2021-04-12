using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioRobo
{
    class Robo
    {

        string grid = "", faceAtual = "", posInicial = "";
        int posX, posY;
        string[] gridDados;
        string[] posInicialDados;

        public Robo(string grid, string posInicial)
        {
            this.posInicial = posInicial;
            this.grid = grid;

        }

        public void Mover(string movimento)
        {

            gridDados = grid.Split(' ');
            posInicialDados = posInicial.Split(' ');
            this.posX = Int16.Parse(posInicialDados[0]);
            this.posY = Int16.Parse(posInicialDados[1]);
            this.faceAtual = posInicialDados[2];


            for (int i = 0; i < movimento.Length; i++)
            {
                if (movimento[i].Equals('e') || movimento[i].Equals('E'))
                {

                    if (this.faceAtual.Equals("n", StringComparison.OrdinalIgnoreCase))
                    {
                        this.faceAtual = "O";

                    }
                    else if (this.faceAtual.Equals("o", StringComparison.OrdinalIgnoreCase))
                    {
                        this.faceAtual = "S";

                    }
                    else if (this.faceAtual.Equals("s", StringComparison.OrdinalIgnoreCase))
                    {
                        this.faceAtual = "L";

                    }
                    else if (this.faceAtual.Equals("l", StringComparison.OrdinalIgnoreCase))
                    {
                        this.faceAtual = "N";

                    }
                }

                else if (movimento[i].Equals('d') || movimento[i].Equals('D'))
                {

                    if (this.faceAtual.Equals("n", StringComparison.OrdinalIgnoreCase)) 
                    {
                        this.faceAtual = "L";

                    }
                    else if (this.faceAtual.Equals("o", StringComparison.OrdinalIgnoreCase))
                    {
                        this.faceAtual = "N";

                    }
                    else if (this.faceAtual.Equals("s", StringComparison.OrdinalIgnoreCase))
                    {
                        this.faceAtual = "O";

                    }
                    else if (this.faceAtual.Equals("l", StringComparison.OrdinalIgnoreCase))
                    {
                        this.faceAtual = "S";

                    }
                }

                else if (movimento[i].Equals('m') || movimento[i].Equals('M')) 
                {

                    if (this.faceAtual.Equals("n", StringComparison.OrdinalIgnoreCase))
                    {
                        this.posY++;

                    }
                    if (this.faceAtual.Equals("s", StringComparison.OrdinalIgnoreCase))
                    {
                        this.posY--;

                    }
                    if (this.faceAtual.Equals("l", StringComparison.OrdinalIgnoreCase))
                    {
                        this.posX++;

                    }
                    if (this.faceAtual.Equals("o", StringComparison.OrdinalIgnoreCase))
                    {
                        this.posX--;

                    }
                }
            }
        }

        public void MostrarResultado()
        {
            Console.Write("\n" +this.posX.ToString() + " " + this.posY.ToString() + " " + this.faceAtual + "\n");

        }

    }





}
