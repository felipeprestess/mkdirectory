﻿using System;
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
            linkLabelMaryKayPortal.Links.Add(0, linkLabelMaryKayPortal.Text.Length, "http://www.google.com");
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
            FormVendas formVendas = new FormVendas();
            formVendas.Show();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProdutos formProdutos = new FormProdutos();
            formProdutos.Show();
        }

        private void buttonPrincipalParceiras_Click(object sender, EventArgs e)
        {
            FormParceiras formParceiras = new FormParceiras();
            formParceiras.Show();
        }
    }
}
