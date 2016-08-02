using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CadastroCliente
{
    public class Cliente : Usuario
    {
        public Cliente() :
            base(3) { }

        private string enderecoCliente;
        public override string Endereco
        {
            get { return enderecoCliente; }
            set { enderecoCliente = value; }
        }

        private string nomeConsultora;
        public string NomeConsultora
        {
            get { return nomeConsultora; }
            set { nomeConsultora = value; }
        }

        private string produtoInteresse;
        public string ProdutoInteresse
        {
            get { return produtoInteresse; }
            set { produtoInteresse = value; }
        }
    }
}
