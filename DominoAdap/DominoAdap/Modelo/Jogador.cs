using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominoAdap.Modelo
{
    public class Jogador
    {
        public List<Pedra> listaPedras = new List<Pedra>();


        public void carregarPedras(Domino domino)
        {
            for (int i = 0; i < 7; i++)
            {
                listaPedras.Add(domino.domino[0]);
                domino.domino.RemoveAt(0);
            }
        }

        public void comprarPedras(Domino domino)
        {
            if (domino.domino.Count > 0)
            {
                listaPedras.Add(domino.domino[0]);
                domino.domino.RemoveAt(0);
            }
        }

        public void limparPedras()
        {
            listaPedras = null;
        }

        public Pedra retornarPedra(int index)
        {
            return listaPedras[index];
        }

        public void removerPedra(int index)
        {
            listaPedras.RemoveAt(index);
        }

        public void jogarPedra(Domino domino, Jogada jogada, int pos, bool lado)
        {
            jogada.pedra.verificarLadoCerto(domino, lado);
            if (lado)
                domino.inserirTabuleiroLado2(jogada);
            else
                domino.inserirTabuleiroLado1(jogada);
            removerPedra(pos);
        }

        public List<int> jogadasPossiveis()
        {
            List<int> lstIndices = new List<int>();
            Pedra pedra = new Pedra();
            for (int i = 0; i < listaPedras.Count; i++)
            {
                pedra = retornarPedra(i);
                if (pedra.l1 == pedra.l2)
                {
                    lstIndices.Add(i);
                }
            }
            return lstIndices;
        }

        public List<int> jogadasPossiveis(Domino domino, char lado)
        {
            List<int> lstIndices = new List<int>();
            int pl;
            if (lado == 'E')
                pl = domino.tabuleiro[0].pedra.l1;  //Verifica o valor da ponta do tabuleiro
            else
                pl = domino.tabuleiro[domino.tabuleiro.Count - 1].pedra.l2;
            Pedra pedra = new Pedra();
            int dest;
            for (int i = 0; i < listaPedras.Count; i++)
            {
                pedra = retornarPedra(i);
                dest = domino.regras.First(r => r.l1 == pedra.l1).l2; //Verifica qual é a combinação do lado 1 da pedra
                if (dest == pl)
                    lstIndices.Add(i);
                else
                {
                    dest = domino.regras.First(r => r.l1 == pedra.l2).l2;//Verifica qual é a combinação do lado 2 da pedra
                    if (dest == pl)
                        lstIndices.Add(i);
                }
            }
            return lstIndices;
        }
    }
}
