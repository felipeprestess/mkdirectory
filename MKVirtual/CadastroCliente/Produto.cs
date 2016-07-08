using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CadastroCliente
{
    public class Produto
    {
        public string NomeProduto { get; set; }
        public string TipoProduto { get; set; }
        public decimal PrecoProduto { get; set; }

        public Produto(){}

        public void adicionaProduto(string nome, string tipo, decimal preco)
        {
            try
            {
                Produto produto = new Produto();
                nome = produto.NomeProduto;
                tipo = produto.TipoProduto;
                preco = produto.PrecoProduto;
                List<Produto> listaProduto = new List<Produto>();
                listaProduto.Add(produto);

                foreach (var item in listaProduto)
                {
                    MessageBox.Show("Cliente: " + item.NomeProduto + " adicionado com sucesso!", "Cadastro Produto");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Mensagem: " + e.Message);
            }
            



        }
    }
}
