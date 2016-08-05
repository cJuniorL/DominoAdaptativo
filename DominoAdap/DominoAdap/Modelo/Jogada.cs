using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominoAdap.Modelo
{
    public class Jogada
    {
        public Pedra pedra { get; set; }    
        public Jogador jogador { get; set; }
        Domino domino;

        public Jogada(Domino domino, Pedra pedra, Jogador jogador)
        {
            this.domino = domino;
            this.pedra = pedra;
            this.jogador = jogador;
        }

        public Jogada(Pedra pedra, Jogador jogador)
        { 
            this.pedra = pedra;
            this.jogador = jogador;
        }

        public void alterarRegra(bool lado)
        {
            if (lado)
            {
                for (int i = 0; i < domino.regras.Count; i++)
                {
                    if (domino.regras[i].l1 == pedra.l2)
                    {
                        domino.regras[i].l2 = domino.tabuleiro[0].pedra.l1;
                        i = domino.regras.Count;
                    }
                }
                for (int i = 0; i < domino.regras.Count; i++)
                {
                    if (domino.regras[i].l1 == domino.tabuleiro[0].pedra.l1)
                    {
                        domino.regras[i].l2 = pedra.l2;
                        i = domino.regras.Count;
                    }
                }
            }
            else
            {
                for (int i = 0; i < domino.regras.Count; i++)
                {
                    if (domino.regras[i].l1 == pedra.l1)
                    {
                        domino.regras[i].l2 = domino.tabuleiro[domino.tabuleiro.Count - 1].pedra.l2;
                        i = domino.regras.Count;
                    }
                }
                for (int i = 0; i < domino.regras.Count; i++)
                {
                    if (domino.regras[i].l1 == domino.tabuleiro[domino.tabuleiro.Count - 1].pedra.l2)
                    {
                        domino.regras[i].l2 = pedra.l1;
                        i = domino.regras.Count;
                    }
                }
            }
        }

        virtual public string visualizarJogada { get { return " [" + pedra.l1 + " - " + pedra.l2 + " ]"; } }
    }
}
