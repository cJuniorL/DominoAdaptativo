﻿using System;
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

        private void atualizarTabuleiro()
        {
            //PictureBox[,] mPic = { {p1l1, p2l1, p3l1, p4l1, p5l1, p6l1, p7l1, p8l1, p9l1, p10l1, p11l1, p12l1, p13l1, p14l1, p15l1, p16l1, p17l1, p18l1, p19l1, p20l1, p21l1, p22l1, p22l1, p23l1, p24l1, p25l1},
            //{p1l2, p2l2, p3l2, p4l2, p5l2, p6l2, p7l2, p8l2, p9l2, p10l2, p11l2, p12l2, p13l2, p14l2, p15l2, p16l2, p17l2, p18l2, p19l2, p20l2, p21l2, p22l2, p22l2, p23l2, p24l2, p25l2 } };
            PictureBox[] mPic1 = { p1l1, p2l1, p3l1, p4l1, p5l1, p6l1, p7l1, p8l1, p9l1, p10l1, p11l1, p12l1, p13l1, p14l1, p15l1, p16l1, p17l1, p18l1, p19l1, p20l1, p21l1, p22l1, p22l1, p23l1, p24l1, p25l1 };
            PictureBox[] mPic2 = { p1l2, p2l2, p3l2, p4l2, p5l2, p6l2, p7l2, p8l2, p9l2, p10l2, p11l2, p12l2, p13l2, p14l2, p15l2, p16l2, p17l2, p18l2, p19l2, p20l2, p21l2, p22l2, p22l2, p23l2, p24l2, p25l2 };

            for (int i = 0; i < controle.tabuleiro.Count; i++)
            {
                if (i == 12)
                {
                    if (controle.tabuleiro[i].pedra.adap)
                    {
                        mPic2[i].Image = ilsVertL2.Images[controle.tabuleiro[i].pedra.l2];
                        mPic1[i].Image = ilsVertL1.Images[controle.tabuleiro[i].pedra.l1];
                    }
                    else
                    {
                        mPic2[i].Image = ilsVertL2.Images[controle.tabuleiro[i].pedra.l1];
                        mPic1[i].Image = ilsVertL1.Images[controle.tabuleiro[i].pedra.l2];
                    }
                }
                else
                {
                    if (i > 12)
                    {
                        if (controle.tabuleiro[i].pedra.adap)
                        {
                            mPic2[i].Image = ilsAdapL1.Images[controle.tabuleiro[i].pedra.l1];
                            mPic1[i].Image = ilsAdapL2.Images[controle.tabuleiro[i].pedra.l2];
                        }
                        else
                        {
                            mPic2[i].Image = ilsPedrasL1.Images[controle.tabuleiro[i].pedra.l1];
                            mPic1[i].Image = ilsPedral2.Images[controle.tabuleiro[i].pedra.l2];
                        }
                    }
                    else
                    {
                        if (controle.tabuleiro[i].pedra.adap)
                        {
                            mPic1[i].Image = ilsAdapL1.Images[controle.tabuleiro[i].pedra.l1];
                            mPic2[i].Image = ilsAdapL2.Images[controle.tabuleiro[i].pedra.l2];
                        }
                        else
                        {
                            mPic1[i].Image = ilsPedrasL1.Images[controle.tabuleiro[i].pedra.l1];
                            mPic2[i].Image = ilsPedral2.Images[controle.tabuleiro[i].pedra.l2];
                        }
                    }
                }
            }
        }


        private void frmJogoDomino_Load(object sender, EventArgs e)
        {
            lsbJogador1.SelectedValue = "id";
            lsbJogador2.SelectedValue = "id";
            lsbJogador1.DisplayMember = "visualizarPeca";
            lsbJogador2.DisplayMember = "visualizarPeca";
            lsbRegras.DisplayMember = "visualizarRegra";

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
            pos = lstIndices[pos];
            Pedra pedra = jogadorB.retornarPedra(pos);

            if (pedra.adap && controle.verficarQuantidadePedra() > 0)
            {
                Jogada jogada = new Jogada(controle, pedra, jogadorB);
                if (direito)
                    jogada.alterarRegra(false);
                else
                    jogada.alterarRegra(true);
                jogadorB.jogarPedra(controle, jogada, pos, direito);
            }
            else
            {
                Jogada jogada = new Jogada(jogadorB.retornarPedra(pos), jogadorB);
                jogadorB.jogarPedra(controle, jogada, pos, direito);
            }
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
            //lsbDomino.DataSource = controle.domino.ToList();
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
            //lsbDomino.DataSource = controle.domino.ToList();
            lsbJogador1.DataSource = jogadorA.listaPedras.ToList();
            lsbJogador2.DataSource = jogadorB.listaPedras.ToList();
            lsbRegras.DataSource = controle.regras.ToList();
            atualizarTabuleiro();
            if (controle.verficarQuantidadePedra() > 0)
            {
                char ganhador = controle.verficarGanhador(jogadorA, jogadorB);
                if (ganhador != 'D')
                {
                    if (ganhador == 'A')
                    {
                        MessageBox.Show("O jogador 1 ganhou!", "Jogo Finalizado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        if (ganhador == 'B')
                        {
                            MessageBox.Show("O computador ganhou! Pratique mais.", "Jogo Finalizado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                        else
                        {
                            if (ganhador == 'C')
                            {
                                MessageBox.Show("Houve um empate!", "Jogo Finalizado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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
