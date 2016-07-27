using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominoAdap.Modelo
{
    public class Regra
    {
        public int id { get; set; }
        public int l1 { get; set; }
        public int l2 { get; set; }
        public string fAdpAnt { get; set; }
        public string fAdpPos { get; set; }
        virtual public string visualizarRegra { get { return  l1 + " -> " + l2 ; } }
    }
}
