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
            linkLabelMaryKayPortal.Links.Add(0, linkLabelMaryKayPortal.Text.Length, "http://www.marykay.com.br/");
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormCliente form = new FormCliente();
            form.Show();
        }

        private void buttonProdutos_Click(object sender, EventArgs e)
        {
            FormProduto form = new FormProduto();
            form.Show();
        }

        private void buttonPrincipalFinanceiro_Click(object sender, EventArgs e)
        {
            FormFinanceiro form = new FormFinanceiro();
            form.Show();
        }

        private void subMenuCriarNovoCliente_Click(object sender, EventArgs e)
        {
            FormCliente formClientes = new FormCliente();
            formClientes.Show();
        }

        private void subMenuCriarNovoProduto_Click(object sender, EventArgs e)
        {
            FormProduto formProduto = new FormProduto();
            formProduto.Show();
        }

        private void linkLabelMaryKayPortal_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutMK formsAbout = new AboutMK();
            formsAbout.Text = "MK Virtual";
            formsAbout.Show();
        }

        private void buttonPrincipalVendas_Click_1(object sender, EventArgs e)
        {
            FormVenda formVendas = new FormVenda();
            formVendas.Show();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProduto formProdutos = new FormProduto();
            formProdutos.Show();
        }

        private void buttonPrincipalParceiras_Click(object sender, EventArgs e)
        {
            FormParceira formParceiras = new FormParceira();
            formParceiras.Show();
        }

        private void meuPerfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAdm formAdm = new FormAdm();
            formAdm.Show();
        }

        private void novoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCliente formCliente = new FormCliente();
            formCliente.Show();
        }

        private void novaVendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNovaVenda formNovaVenda = new FormNovaVenda();
            formNovaVenda.Show();
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConfiguracao formConfiguracao = new FormConfiguracao();
            formConfiguracao.Show();
        }

        private void novoProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProduto formProduto = new FormProduto();
            formProduto.Show();
        }
    }
}
