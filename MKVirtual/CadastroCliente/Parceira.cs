using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CadastroCliente
{
    class Parceira
    {//Classe responsável pela atividades da parceira
        private string nomeParceira;
        public string NomeParceira {
            get { return nomeParceira; }
            set { nomeParceira = value; }
        }

        private string produtoVendaParceira;
        public string ProdutoVendaParceira {
            get { return produtoVendaParceira; }
            set { produtoVendaParceira = value;}
        }

        private string emailParceira;
        public string EmailParceira{
            get { return emailParceira; }
            set { emailParceira = value; }
        }

    }
}
