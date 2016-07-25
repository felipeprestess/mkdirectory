using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CadastroCliente
{
    public class Produto
    {
        public Produto() { }

        public int Id { get; set; }

        private string nomeProduto;
        public string NomeProduto {
            get { return nomeProduto; }
            set { nomeProduto = value; }
        }
        private string tipoProduto;
        public string TipoProduto {
            get { return tipoProduto; }
            set { tipoProduto = value; }
        }
        private decimal precoProduto;
        public decimal PrecoProduto {
            get { return precoProduto; }
            set { precoProduto = value; }
        }
        private string linhaProduto;
        public string LinhaProduto {
            get { return linhaProduto; }
            set { linhaProduto = value; }
        }

        

        
    }
}
