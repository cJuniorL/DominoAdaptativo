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
    public partial class frmDomino : Form
    {
        Domino domino = new Domino();
        Jogador jogadorA = new Jogador();
        Jogador jogadorB = new Jogador();

        public frmDomino()
        {
            InitializeComponent();
        }

        private void frmDomino_Load(object sender, EventArgs e)
        {
            lsbJogadorA.SelectedValue = "id";
            lsbJogadorB.SelectedValue = "id";
            lsbJogadorA.DisplayMember = "visualizarPeca";
            lsbJogadorB.DisplayMember = "visualizarPeca";
            lsbTabuleiro.DisplayMember = "visualizarJogada";
            lsbRegras.DisplayMember = "visualizarRegra";
        }

        private void tsmInciar_Click(object sender, EventArgs e)
        {
            domino.gerarDomino();
            domino.misturarDomino();
            jogadorA.carregarPedras(domino);
            lsbJogadorA.DataSource = jogadorA.listaPedras.ToList();
            jogadorB.carregarPedras(domino);
            lsbJogadorA.DataSource = jogadorB.listaPedras.ToList();
            lsbRegras.DataSource = domino.regras.ToList();

            if (domino.definirOrdem(jogadorA, jogadorB) == 'A')
            {
                jogadaA();
            }
            else
            {
                jogadaB();
            }
        }

        private void jogadaA()
        {
            String[] opcoes = { "Inserir", "Inserir no Lado Esquerdo", "Inserir no Lado Direito", "Comprar Peça", "Passar a Vez" };
            if (domino.verficarQuantidadePedra() == 0)
            {
                cmbAcao.Items.Clear();
                cmbAcao.Items.Add(opcoes[0]);
                cmbAcao.Items.Add(opcoes[3]);
                cmbAcao.DataSource = opcoes.ToList();
            }
        }

        private void jogadaB()
        {

        }

        private void btnRealizar_Click(object sender, EventArgs e)
        {
            if (cmbAcao.SelectedText == "Inserir")
            {
                inserirPeca(lsbJogadorA, jogadorA);
            }
            else
            {
                if (cmbAcao.SelectedText == "Inserir no Lado Esquerdo")
                {

                }
                else
                {
                    if (cmbAcao.SelectedText == "Inserir no Lado Direito")
                    {

                    }
                    else
                    {
                        if (cmbAcao.SelectedText == "Comprar Peça")
                        {

                        }
                        else
                        {

                        }
                    }
                }
            }
        }

        private void inserirPeca(ListBox lsbJogador, Jogador jogador)
        {
            int pos = lsbJogador.SelectedIndex; //Posição da pedra na mão do jogador
            Pedra pedra = jogador.retornarPedra(pos);
            if (pedra.l1 == pedra.l2)
            {
                Jogada jogada = new Jogada(domino, pedra, jogador);

            }
        }
    }
}
