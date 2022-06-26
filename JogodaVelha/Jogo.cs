using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogodaVelha
{
    internal class Jogo
    {
        private int X;
        private int O;
        public int JogadorAtual;

        public Jogo()
        {
            X = 1;
            O = 1;
            JogadorAtual = 0;
        }
        public string Marcar()
        {
            if (JogadorAtual == 0)
            {
                JogadorAtual = 1;
                return "X";
            }
            else
            {
                JogadorAtual = 0;
                return "O";
            }
        }

        public int pontoX()
        {
            return X++;
        }
        public int pontoO()
        {
            return O++;
        }

    }
}
