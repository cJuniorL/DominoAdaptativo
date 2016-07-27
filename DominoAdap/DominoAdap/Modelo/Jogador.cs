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
      

        public void carregarPedras(Domino controle)
        {
            for (int i = 0; i < 7; i++)
            {
                listaPedras.Add(controle.domino[0]);
                controle.domino.RemoveAt(0);
            }
            //listaPedras = listaPedras.OrderBy(p => p.id).ToList();
        }

        public void comprarPedras(Domino controle)
        {
            listaPedras.Add(controle.domino[0]);
            controle.domino.RemoveAt(0);
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

        public void jogarPedra(Domino domino, Jogada jogada, int pos, bool ladoDireito)
        {
            jogada.pedra = jogada.pedra.verificarLadoCerto(domino, ladoDireito);
            if (ladoDireito)
                domino.inserirTabuleiroLado2(jogada);
            else
                domino.inserirTabuleiroLado1(jogada);
            removerPedra(pos);
        }

        public List<Pedra> selecionarPedras()
        {
            return listaPedras;
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
            if (domino.verficarQuantidadePedra() > 0)
            {
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
            else {
                return null;
            }
            
        }

        public bool vencedor()
        {
            return true;
        }
    }
}
