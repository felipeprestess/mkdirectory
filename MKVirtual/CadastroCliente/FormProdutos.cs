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
        Administrador adm;
        public FormProdutos()
        {
            InitializeComponent();
            adm = new Administrador();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBoxPrecoCadastroProduto_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonRegistraProduto_Click(object sender, EventArgs e)
        {
            string nomeProduto = textBoxNomeCadastroProduto.Text;
            string tipoProduto = comboTipoProduto.Text;
            decimal precoProduto = decimal.Parse(textBoxPrecoCadastroProduto.Text);
            string linhaProduto = textBoxLinhaProduto.Text;
            adm.registrarProduto(nomeProduto, tipoProduto, precoProduto, linhaProduto);
        }

        private void buttonLimpaFormularioProduto_Click(object sender, EventArgs e)
        {
            limpaCampos();
        }

        private void limpaCampos()
        {
            textBoxNomeCadastroProduto.Clear();
            textBoxPrecoCadastroProduto.Clear();
            textBoxLinhaProduto.Clear();
        }
    }
}
