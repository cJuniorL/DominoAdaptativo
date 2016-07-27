using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DominoAdap.Modelo;

namespace DominoAdap.Forms
{
    public partial class frmJogoDomino : Form
    {
        Domino controle = new Domino();
        Jogador jogadorA = new Jogador();
        Jogador jogadorB = new Jogador();


        public frmJogoDomino()
        {
            InitializeComponent();

        }

        private void frmJogoDomino_Load(object sender, EventArgs e)
        {
            lsbJogador1.SelectedValue = "id";
            lsbJogador2.SelectedValue = "id";
            lsbJogador1.DisplayMember = "visualizarPeca";
            lsbJogador2.DisplayMember = "visualizarPeca";
            lsbDomino.DisplayMember = "visualizarPeca";
            lsbTabuleiro.DisplayMember = "visualizarJogada";
            lsbRegras.DisplayMember = "visualizarRegra";
            lsbDomino.ColumnWidth = 40;
        }

        private List<int> verificarPedrasAdap()
        {
            List<int> lstAdap = new List<int>();
            foreach (Pedra pedra in jogadorB.listaPedras)
            {
                if (pedra.adap)
                    lstAdap.Add(jogadorB.listaPedras.IndexOf(pedra));
            }
            return lstAdap;
        }

        private void jogadaB()
        {

            if (controle.verficarQuantidadePedra() > 0)
            {
                List<int> lstAdap = verificarPedrasAdap();
                List<int> lstJogadasEsquerda = jogadorB.jogadasPossiveis(controle, 'E');
                lstJogadasEsquerda.AddRange(lstAdap);
                List<int> lstJogadasDireita = jogadorB.jogadasPossiveis(controle, 'D');
                lstJogadasDireita.AddRange(lstAdap);
                if (lstJogadasEsquerda.Count > lstJogadasDireita.Count)
                    jogadaComputador(lstJogadasEsquerda, false);
                else
                {
                    if (lstJogadasDireita.Count != 0)
                        jogadaComputador(lstJogadasDireita, true);
                    else
                    {
                        jogadorB.comprarPedras(controle);
                        if (lstJogadasEsquerda.Count > 0)
                            jogadaComputador(lstJogadasEsquerda, false);
                        else
                        {
                            if (lstJogadasDireita.Count > 0)
                                jogadaComputador(lstJogadasDireita, true);
                            else
                            {
                                atualizarTudo();
                                habilitarJogadaA(true);
                            }
                        }
                    }
                }
            }
            else
            {
                List<int> lstIndices = jogadorB.jogadasPossiveis();
                if (lstIndices.Count > 0)
                {
                    jogadaComputador(lstIndices, false);
                }
                else
                {
                    jogadorB.comprarPedras(controle);
                    atualizarTudo();
                    habilitarJogadaA(true);
                }
            }
        }

        private void jogadaComputador(List<int> lstIndices, bool direito)
        {
            int pos = selecionarIndiceAleatorio(lstIndices.Count);
            Pedra pedra = jogadorB.retornarPedra(pos);
            if (pedra.adap && controle.verficarQuantidadePedra() > 0)
            {
                controle.alterarRegra(pedra, direito);
                lsbRegras.DataSource = controle.regras.ToList();
            }
            pos = lstIndices[pos]; //Indetifica a posição da pedra na mão do Jogador
            Jogada jogada = new Jogada(controle, jogadorB.retornarPedra(pos), jogadorB);
            jogadorB.jogarPedra(controle, jogada, pos, direito);
            habilitarJogadaA(true);
            atualizarTudo();

        }

        private int selecionarIndiceAleatorio(int tamanhoLista)
        {
            Random rand = new Random();
            int indice = rand.Next(0, tamanhoLista - 1);
            return indice;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            controle.gerarDomino();
            controle.misturarDomino();
            jogadorA.carregarPedras(controle);
            lsbJogador1.DataSource = jogadorA.listaPedras.ToList();
            jogadorB.carregarPedras(controle);
            lsbJogador2.DataSource = jogadorB.listaPedras.ToList();
            lsbDomino.DataSource = controle.domino.ToList();
            lsbRegras.DataSource = controle.regras.ToList();
            habilitarJogadaA(false);
            if (controle.definirOrdem(jogadorA, jogadorB) == 'A')
            {
                habilitarJogadaA(true);
            }
            else
            {
                jogadaB();
            }
        }

        private void habilitarJogadaA(bool status)
        {
            btnPassar.Enabled = false;
            btnEsquerda.Enabled = status;
            btnDireita.Enabled = status;
            btnComprar.Enabled = status;
        }

        private void atualizarTudo()
        {
            lsbDomino.DataSource = controle.domino.ToList();
            lsbJogador1.DataSource = jogadorA.listaPedras.ToList();
            lsbJogador2.DataSource = jogadorB.listaPedras.ToList();
            lsbTabuleiro.DataSource = controle.tabuleiro.ToList();
            if (jogadorA.listaPedras.Count == 0)
            {
                MessageBox.Show("O jogador 1 ganhou!", "Jogo Finalizado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                if (jogadorB.listaPedras.Count == 0)
                {
                    MessageBox.Show("O jogador 2 ganhou!", "Jogo Finalizado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    if (controle.domino.Count == 0)
                    {
                        if (jogadorA.jogadasPossiveis(controle, 'E').Count == 0 && jogadorA.jogadasPossiveis(controle, 'D').Count == 0 &&
                            jogadorB.jogadasPossiveis(controle, 'E').Count == 0 && jogadorB.jogadasPossiveis(controle, 'D').Count == 0 && 
                            jogadorA.listaPedras.Count(p => p.adap) == 0 && jogadorB.listaPedras.Count(p => p.adap) == 0)
                        {
                            int somaA = 0, somaB = 0;
                            foreach (Pedra pedra in jogadorA.listaPedras)
                            {
                                somaA += pedra.l1 + pedra.l2;
                            }
                            foreach (Pedra pedra in jogadorB.listaPedras)
                            {
                                somaB += pedra.l1 + pedra.l2;
                            }
                            if (somaA == somaB)
                            {
                                MessageBox.Show("Houve um empate no jogo !", "Jogo Finalizado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            }
                            else
                            {
                                if (somaA > somaB)
                                {
                                    MessageBox.Show("O jogador 1 ganhou!", "Jogo Finalizado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                }
                                else
                                {
                                    MessageBox.Show("O jogador 2 ganhou!", "Jogo Finalizado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                }
                            }
                        }
                    }
                }
            }
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            jogadorA.comprarPedras(controle);
            btnComprar.Enabled = false;
            btnPassar.Enabled = true;
            atualizarTudo();
        }

        private void btnEsquerda_Click(object sender, EventArgs e)
        {
            int pos = lsbJogador1.SelectedIndex;
            Pedra pedra = jogadorA.retornarPedra(pos);
            if (jogadorA.retornarPedra(pos).adap == true && controle.verficarQuantidadePedra() > 0)
            {
                Jogada jogada = new Jogada(controle, pedra, jogadorA);
                jogada.alterarRegra(true);
                lsbRegras.DataSource = controle.regras.ToList();
                jogadorA.jogarPedra(controle, jogada, pos, false);
                atualizarTudo();
                habilitarJogadaA(false);
                jogadaB();
            }
            else
            {
                Jogada jogada = new Jogada(pedra, jogadorA);
                List<int> jogadasPossiveis = new List<int>();
                if (controle.verficarQuantidadePedra() > 0)
                    jogadasPossiveis = jogadorA.jogadasPossiveis(controle, 'E');
                else
                    jogadasPossiveis = jogadorA.jogadasPossiveis();
                if (jogadasPossiveis.Contains(pos))
                {
                    jogadorA.jogarPedra(controle, jogada, pos, false);
                    atualizarTudo();
                    habilitarJogadaA(false);
                    jogadaB();
                }
                else
                    MessageBox.Show("Combinação Inválida", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDireita_Click(object sender, EventArgs e)
        {
            int pos = lsbJogador1.SelectedIndex;
            Pedra pedra = jogadorA.retornarPedra(pos);
            if (pedra.adap)
            {
                Jogada jogada = new Jogada(controle, pedra, jogadorA);
                jogada.alterarRegra(false);
                lsbRegras.DataSource = controle.regras.ToList();
                jogadorA.jogarPedra(controle, jogada, pos, true);
                atualizarTudo();
                habilitarJogadaA(true);
                jogadaB();
            }
            else
            {
                Jogada jogada = new Jogada(pedra, jogadorA);
                List<int> jogadasPossiveis = new List<int>();
                if (controle.verficarQuantidadePedra() > 0)
                {
                    jogadasPossiveis = jogadorA.jogadasPossiveis(controle, 'D');
                    if (jogadasPossiveis.Contains(pos))
                    {
                        jogadorA.jogarPedra(controle, jogada, pos, true);
                        atualizarTudo();
                        habilitarJogadaA(false);
                        jogadaB();
                    }
                    else
                        MessageBox.Show("Combinação Inválida", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    jogadasPossiveis = jogadorA.jogadasPossiveis();
                    if (jogadasPossiveis.Contains(pos))
                    {
                        jogadorA.jogarPedra(controle, jogada, pos, false);
                        atualizarTudo();
                        habilitarJogadaA(false);
                        jogadaB();
                    }
                }
            }
        }

        private void lsbJogador1_DrawItem(object sender, DrawItemEventArgs e)
        {

        }

        private void btnPassar_Click(object sender, EventArgs e)
        {
            jogadaB();
        }

        private void btnAdaptar_Click(object sender, EventArgs e)
        {

        }

        private void btnAdaptarDireita_Click(object sender, EventArgs e)
        {

        }
    }
}
