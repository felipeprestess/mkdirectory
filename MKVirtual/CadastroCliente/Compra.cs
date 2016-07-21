using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CadastroCliente
{
    class Compra
    {
        private int dataCompra;
        public int DataCompra {
            get { return dataCompra; }
            set { dataCompra = value; }
        }

        private int qtdProdutoCompra;
        public int QtdProdutoCompra {
            get { return qtdProdutoCompra; }
            set { qtdProdutoCompra = value; }
        }

        public decimal calcularTotalCompra(Produto prd)
        {
            decimal total = 0;
            total += prd.PrecoProduto * qtdProdutoCompra;
            return total;
        }
    }
}
