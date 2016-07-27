using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominoAdap.Modelo
{
    public class Domino
    {
        public List<Pedra> domino { get; set; } = new List<Pedra>();
        public Jogador jogadorA { get; set; }
        public Jogador jogadorB { get; set; }
        public List<Jogada> tabuleiro { get; set; } = new List<Jogada>();
        public List<Regra> regras { get; set; } = new List<Regra>();

        public void gerarDomino()
        {

            for (int i = 0; i < 7; i++)
            {
                Regra regra = new Regra();
                regra.fAdpAnt = null;
                regra.fAdpPos = null;
                regra.id = i;
                regra.l1 = i;
                regra.l2 = i;
                regras.Add(regra);
                for (int j = i; j < 7; j++)
                {
                    Pedra pedra = new Pedra();
                    pedra.fAdapAnt = null;
                    pedra.fAdapPos = null;
                    pedra.adap = false;
                    pedra.id = domino.Count + 1;
                    pedra.l1 = i;
                    pedra.l2 = j;
                    domino.Add(pedra);
                }
            }
        }

        public void misturarDomino()
        {
            int seed = DateTime.Now.Millisecond * DateTime.Now.Year * DateTime.Now.Second;
            Random rand = new Random(seed);
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < domino.Count; j++)
                {
                    int iRand = rand.Next() % 28;
                    Pedra aux = domino[j];
                    domino[j] = domino[iRand];
                    domino[iRand] = aux;
                }
            }
            for (int i = 0; i < 4; i++)
            {
                int iRand = rand.Next() % 28;
                domino[iRand].adap = true;
            }
        }

        public int verficarQuantidadePedra()
        {
            return tabuleiro.Count;
        }

        public void iniciarTabuleior()
        {
            tabuleiro = null;
        }

        public void inserirTabuleiroLado1(Jogada jogada)
        {
            tabuleiro.Insert(0, jogada);
        }

        public void inserirTabuleiroLado2(Jogada jogada)
        {
            tabuleiro.Add(jogada);
        }

        public char definirOrdem(Jogador jogadorA, Jogador jogadorB)
        {
            bool possui = false;
            char escolhido = 'A';
            for (int i = 6; i > -1; i--)
            {
                if (jogadorA.listaPedras.Where(p => p.l1 == i && p.l2 == i).Count() > 0)
                {
                    i = -1;
                    possui = true;
                    escolhido = 'A';
                }
                else
                {
                    if (jogadorB.listaPedras.Where(p => p.l1 == i && p.l2 == i).Count() > 0)
                    {
                        i = -1;
                        possui = true;
                        escolhido = 'B';
                    }
                }
            }
            if (!possui)
            {
                int somaA = 0, somaB = 0;
                for (int i = 0; i < jogadorA.listaPedras.Count - 1; i++)
                {
                    somaA += jogadorA.listaPedras[i].l1 + jogadorA.listaPedras[i].l2;
                    somaB += jogadorB.listaPedras[i].l1 + jogadorB.listaPedras[i].l2;
                }
                if (somaA > somaB)
                    escolhido = 'A';
                else
                    escolhido = 'B';
            }
            return escolhido;
        }

        public void alterarRegra(Pedra pedra, bool lado) //True é no inicido do tabulero, False para o fim do tabuleiro
        {
            //if (lado)
            //{
            //    for (int i = 0; i < regras.Count; i++)
            //    {
            //        if (regras[i].l1 == pedra.l2)
            //        {
            //            regras[i].l2 = tabuleiro[0].pedra.l1;
            //            i = regras.Count;
            //        }
            //    }
            //    for (int i = 0; i < regras.Count; i++)
            //    {
            //        if (regras[i].l1 == tabuleiro[0].pedra.l1)
            //        {
            //            regras[i].l2 = pedra.l2;
            //        }
            //    }
            //}
            //else
            //{
            //    for (int i = 0; i < regras.Count; i++)
            //    {
            //        if (regras[i].l1 == pedra.l1)
            //        {
            //            regras[i].l2 = tabuleiro[tabuleiro.Count - 1].pedra.l2;
            //            i = regras.Count;
            //        }
            //    }
            //    for (int i = 0; i < regras.Count; i++)
            //    {
            //        if (regras[i].l1 == tabuleiro[tabuleiro.Count - 1].pedra.l2)
            //        {
            //            regras[i].l2 = pedra.l1;
            //        }
            //    }
            //}
        }
    }
}
