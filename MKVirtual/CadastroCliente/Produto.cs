using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CadastroCliente
{
    public class Produto
    {
        private string nomeProduto {
            get { return nomeProduto; }
            set { nomeProduto = value; }
        }
        private string tipoProduto {
            get { return tipoProduto; }
            set { tipoProduto = value; }
        }
        private decimal precoProduto {
            get { return precoProduto; }
            set { precoProduto = value; }
        }
        private string linhaProduto;
        public string LinhaProduto {
            get { return linhaProduto; }
            set { linhaProduto = value; }
        }

        public Produto(){}

        
    }
}
