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
    public partial class FormPrincipal : Form
    {
        
        public FormPrincipal()
        {
            InitializeComponent();
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormClientes form = new FormClientes();
            form.Show();
        }

        private void buttonProdutos_Click(object sender, EventArgs e)
        {
            FormProdutos form = new FormProdutos();
            form.Show();
        }

        private void buttonPrincipalFinanceiro_Click(object sender, EventArgs e)
        {
            FormFinanceiro form = new FormFinanceiro();
            form.Show();
        }

        private void subMenuCriarNovoCliente_Click(object sender, EventArgs e)
        {
            FormClientes formClientes = new FormClientes();
            formClientes.Show();
        }

        private void subMenuCriarNovoProduto_Click(object sender, EventArgs e)
        {
            FormProdutos formProduto = new FormProdutos();
            formProduto.Show();
        }
    }
}
