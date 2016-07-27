using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DominoAdap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Modelo.Domino jogoDomino = new Modelo.Domino();
            jogoDomino.gerarDomino();
            dataGridView1.DataSource = jogoDomino.domino.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Modelo.Domino controle = new Modelo.Domino();
            controle.gerarDomino();
            controle.misturarDomino();
            Modelo.Jogador jogador = new Modelo.Jogador();
            jogador.carregarPedras(controle);
            dataGridView1.DataSource = jogador.listaPedras;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
