using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    internal class Asteroide
    {
        double posicaoX, posicaoY;
        int tamanho, velocidade, energia;

        public Asteroide() { }

        public Asteroide(int tamanho, int velocidade, int energia)
        {
            this.Tamanho = tamanho;
            this.Velocidade = velocidade;
            this.Energia = energia;
        }

        public Asteroide(double posicaoX, double posicaoY, Asteroide Tamanho, Asteroide Velocidade, Asteroide Energia)
        {
            this.PosicaoX = posicaoX;
            this.PosicaoY = posicaoY;
            this.Tamanho = Tamanho.Tamanho;
            this.Velocidade = Velocidade.Velocidade;
            this.Energia = Energia.Energia;
        }

        public double PosicaoX { get => posicaoX; set => posicaoX = value; }
        public double PosicaoY { get => posicaoY; set => posicaoY = value; }
        public int Tamanho { get => tamanho; set => tamanho = value; }
        public int Velocidade { get => velocidade; set => velocidade = value; }
        public int Energia { get => energia; set => energia = value; }

        public static void ExibirAsteroides(List<Asteroide> Lista)
        {
            foreach (Asteroide i in Lista)
            {
                Console.WriteLine("Asteroide " + (Lista.IndexOf(i) + 1) + " Coordenadas: (" + i.PosicaoX +
                "," + i.PosicaoY + ") Tamanho: " + i.Tamanho + " Velocidade: " + i.Velocidade + " Energia: " + i.Energia);
            }
        }

    }
}
