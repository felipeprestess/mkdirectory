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

        public decimal calcularTotalCompra(Produto prd)
        {
            decimal total = 0;
            total += prd.PrecoProduto;
            return total;
        }
    }
}
