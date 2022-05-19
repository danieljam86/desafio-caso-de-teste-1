using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio_caso_de_teste_1.Model
{
    public class Vendas : Produto
    {

        public int QtdeVendida { get; set; }

        public int SituacaoVenda { get; set; }

        public int CanalVenda { get; set; }
    }
}
