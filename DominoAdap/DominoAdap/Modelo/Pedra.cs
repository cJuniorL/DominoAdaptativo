using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominoAdap.Modelo
{
    public class Pedra
    {
        public int id { get; set; }
        public int l1 { get; set; }
        public int l2 { get; set; }
        public bool adap { get; set; }
        virtual public string visualizarPeca
        {
            get
            {
                if (!adap)
                    return l1 + " | " + l2 + " ";
                else
                    return l1 + " | " + l2 + "* ";
            }
        }
        public string fAdapAnt { get; set; }
        public string fAdapPos { get; set; }

        public Pedra invertePedra()
        {
            int aux = this.l1;
            this.l1 = this.l2;
            this.l2 = aux;
            return this;
        }

        public Pedra verificarLadoCerto(Domino domino, bool lado)
        {
            int tamanho = domino.verficarQuantidadePedra();
            if (tamanho > 0)
            {
                if (lado)
                {
                    ////if (l1 != domino.tabuleiro[tamanho - 1].pedra.l2)
                    if (domino.regras.Count(l => l.l1 == l2 && l.l2 == domino.tabuleiro[tamanho - 1].pedra.l2) > 0)
                        return invertePedra();
                    else
                        return this;
                }
                else
                {
                    //if (l2 != domino.tabuleiro[0].pedra.l1)
                    if (domino.regras.Count(l => l.l1 == l1 && l.l2 == domino.tabuleiro[0].pedra.l1) > 0)
                        return invertePedra();
                    else
                        return this;
                }
            }
            else
                return this;
        }
    }
}
