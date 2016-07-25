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
    public partial class FormProduto : Form
    {
        Administrador adm;
        public FormProduto()
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
            string nomeProduto = txtBoxNomeProduto.Text;
            string tipoProduto = cbxTipoProduto.Text;
            decimal precoProduto = decimal.Parse(txtPrecoProduto.Text);
            string linhaProduto = cbxLinhaProduto.Text;
            adm.registrarProduto(nomeProduto, tipoProduto, precoProduto, linhaProduto);
            lblTotalProdutos.Text = "Total: " + adm.ListaProdutos.Count();
            limpaCampos();
        }

        private void populaGrid()
        {
            dtGridProdutos.DataSource = adm.listaProdutos;
            if (adm.ListaProdutos.Any())
            {
                var dataTable = from t in adm.ListaProdutos
                                orderby t.Id
                                select new
                                {
                                    ID = t.Id,
                                    Produto = t.NomeProduto,
                                    Preço = t.PrecoProduto,
                                    Tipo = t.TipoProduto,
                                    Linha = t.LinhaProduto
                                };
                dtGridProdutos.DataSource = dataTable.ToList();
                dtGridProdutos.Visible = true;
                dtGridProdutos.Show();
            }
        }

        private void buttonLimpaFormularioProduto_Click(object sender, EventArgs e)
        {
            limpaCampos();
        }

        private void limpaCampos()
        {
            txtBoxNomeProduto.Clear();
            txtPrecoProduto.Clear();
            cbxLinhaProduto.ResetText();
            cbxTipoProduto.ResetText();
            txtIDProduto.Clear();
        }

        private void FormProdutos_Load(object sender, EventArgs e)
        {

        }

        private void btnNovoProduto_Click(object sender, EventArgs e)
        {
            gbxProduto.Enabled = true;
        }

        private void btnExibirTodos_Click(object sender, EventArgs e)
        {
            populaGrid();
        }

        private void dtGridProdutos_Click(object sender, EventArgs e)
        {
            if (dtGridProdutos.Rows.Count > 0)
            {
                lblLinhasSelecionadas.Visible = true;
                btnRemoverProduto.Visible = true;
                txtIDProduto.Text = dtGridProdutos.CurrentRow.Cells[0].Value.ToString();
                txtBoxNomeProduto.Text = dtGridProdutos.CurrentRow.Cells[1].Value.ToString();
                txtPrecoProduto.Text = dtGridProdutos.CurrentRow.Cells[2].Value.ToString();
                cbxTipoProduto.Text = dtGridProdutos.CurrentRow.Cells[3].Value.ToString();
                cbxLinhaProduto.Text = dtGridProdutos.CurrentRow.Cells[4].Value.ToString();
                lblLinhasSelecionadas.Text = "Linha(s) selecionada(s): " + dtGridProdutos.SelectedRows.Count;
                btnRegistraProduto.Visible = false;
                btnSalvarProduto.Visible = true;
            }
        }

        private void btnSalvarProduto_Click(object sender, EventArgs e)
        {
            var produto = new Produto();
            produto.Id = int.Parse(txtIDProduto.Text);
            produto.NomeProduto = txtBoxNomeProduto.Text;
            produto.TipoProduto = cbxTipoProduto.Text;
            produto.PrecoProduto = decimal.Parse(txtPrecoProduto.Text);
            produto.LinhaProduto = cbxLinhaProduto.Text;

            adm.editarProduto(produto);
            limpaCampos();
            btnSalvarProduto.Visible = false;
            btnRegistraProduto.Visible = true;
            populaGrid();
        }

        private void btnRemoverProduto_Click(object sender, EventArgs e)
        {
            var produto = new Produto();
            produto.Id = int.Parse(txtIDProduto.Text);
            produto.NomeProduto = txtBoxNomeProduto.Text;
            produto.TipoProduto = cbxTipoProduto.Text;
            produto.PrecoProduto = decimal.Parse(txtPrecoProduto.Text);
            produto.LinhaProduto = cbxLinhaProduto.Text;
            adm.removerProduto(produto);
            limpaCampos();
            populaGrid();
            btnSalvarProduto.Visible = false;
            lblTotalProdutos.Text = "Total: " + adm.ListaProdutos.Count();

        }
    }
}
