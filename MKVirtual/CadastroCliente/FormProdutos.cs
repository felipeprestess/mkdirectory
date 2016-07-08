using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CadastroCliente
{
    public partial class FormProdutos : Form
    {
        Produto produto;
        public FormProdutos()
        {
            InitializeComponent();
            produto = new Produto();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            produto.NomeProduto = textBoxNomeCadastroProduto.Text;
        }

        private void textBoxPrecoCadastroProduto_TextChanged(object sender, EventArgs e)
        {
            produto.PrecoProduto = Convert.ToDecimal(textBoxPrecoCadastroProduto.Text);
        }
    }
}
