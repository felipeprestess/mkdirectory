using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CadastroCliente
{
    class Venda
    {
        private int dataVenda;
        public int DataVenda {
            get { return dataVenda; }
            set { dataVenda = value; }
        }
        private int qtdProduto;
        public int QtdProduto {
            get { return qtdProduto;}
            set { qtdProduto = value; }
        }


        public decimal calcularTotalVenda(Produto prd)
        {
            decimal total = 0;
            total += prd.PrecoProduto * QtdProduto;
            return total;
        }
    }
}
