using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CadastroCliente
{
    public partial class FormPrincipal : Form
    {
        private string stringDeConexao = @"Data Source=WVJVEDEV01.FelipeCosta;Initial Catalog=FelipeCosta;Integrated Security=True";
        public FormPrincipal()
        {
            InitializeComponent();
            
            
            
        }

        public void SqlExecute(string pSql)
        {
            using (SqlConnection cn = new SqlConnection())
            {
                try
                {
                    cn.ConnectionString = stringDeConexao;
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = cn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = pSql;
                    cn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch(Exception e)
                {
                    MessageBox.Show("Message: "+e.Message);
                }
                finally{
                    cn.Close();
                }
            }
        }


        public DataTable OpenSQL(string pSql)
        {
            DataTable dt = new DataTable();
            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = stringDeConexao;
                SqlDataAdapter da = new SqlDataAdapter();

                try
                {
                    da.SelectCommand = new SqlCommand();
                    da.SelectCommand.Connection = cn;
                    da.SelectCommand.CommandType = CommandType.Text;
                    da.SelectCommand.CommandText = pSql;
                    cn.Open();
                    da.Fill(dt);
                }
                catch(Exception e){
                    MessageBox.Show("Message: " + e.Message);
                }
                finally
                {
                    cn.Close();
                }
            }
            return dt;
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

        private void btnCompras_Click(object sender, EventArgs e)
        {
            FormCompra formCompra = new FormCompra();
            formCompra.Show();
        }

        private void novaCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCompra formCompra = new FormCompra();
            formCompra.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            DataGridView dt = new DataGridView();
            dt.DataSource = OpenSQL(" select * from Clientes");
        }

       
    }
}
