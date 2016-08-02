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
    public partial class FormCliente : Form
    {
        Administrador adm;
        
        public FormCliente()
        {
            InitializeComponent();
            adm = new Administrador();
            // TODO: esta linha de código carrega dados na tabela 'mKVIRTUALDataSet.Clientes'. Você pode movê-la ou removê-la conforme necessário.
            //this.clientesTableAdapter.Fill(this.mKVIRTUALDataSet.Clientes);
            labelTotalClientes.Text = "Total clientes: " + mKVIRTUALDataSet.Clientes.Count;

        }

        private void buttonLimpaCamposCliente_Click(object sender, EventArgs e)
        {
            limpaCampoCadastroCliente();
        }

        private void limpaCampoCadastroCliente()
        {
            txtNomeCliente.Clear();
            txtEnderecoCliente.Clear();
            mskDataNascimento.Clear();
            txtEmailCliente.Clear();
            txtTelefone.Clear();
            txtConsultora.Clear();
            rdbtnSexoFemininoCliente.Checked = false;
            rdbtnSexoMasculinoCliente.Checked = false;
            txtPesquisaNomeCliente.Clear();
            txtIDCliente.Clear();
        }




        private void buttonMostrarTodosClientes_Click(object sender, EventArgs e)
        {
            //populaGrid();
            try
            {
                DataTable dt = new DataTable();
                string strConn = @"Server = NOTEBOOKFPRESTE; Database = MKVIRTUAL; Integrated Security = SSPI;";
                SqlConnection conn = new SqlConnection(strConn); 
                SqlDataAdapter da = new SqlDataAdapter("SELECT ClienteCodigo, ClienteNome, ClienteEndereco, ClienteNascimento, ClienteEmail, ClienteTelefone, ClienteSexo, ClienteConsultora FROM Clientes", conn);
                da.Fill(dt);
                dataGridViewClientes.DataSource = dt.DefaultView;
                dataGridViewClientes.Visible = true;
                dataGridViewClientes.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Message: " + ex.Message);
            }
        }

        private void populaGrid()
        {
            dataGridViewClientes.DataSource = mKVIRTUALDataSet;
            if (mKVIRTUALDataSet.Clientes.Count  > 0)
            {
                var dataTable = from t in mKVIRTUALDataSet.Clientes
                                orderby t.ClienteCodigo
                                select new
                                {
                                    Id = t.ClienteCodigo.ToString(),
                                    Nome = t.ClienteNome.ToString(),
                                    Endereco = t.ClienteEndereco.ToString(),
                                    DataNascimento = t.ClienteNascimento.ToString(),
                                    Email = t.ClienteEmail.ToString(),
                                    Telefone = t.ClienteTelefone.ToString(),
                                    Sexo = t.ClienteSexo.ToString(),
                                    Consultora = t.ClienteConsultora.ToString()
                                  
                              };
                dataGridViewClientes.DataSource = dataTable.ToList();
                dataGridViewClientes.Visible = true;
                dataGridViewClientes.Show();
            }
        }

        private void buttonPesquisarCliente_Click(object sender, EventArgs e)
        {
            string nomePesquisado = txtPesquisaNomeCliente.Text;
            if (String.IsNullOrEmpty(txtPesquisaNomeCliente.Text))
                MessageBox.Show("Insira um nome!", "Ops...");
            adm.pesquisarCliente(nomePesquisado);
            limpaCampoCadastroCliente();
        }

        private void listViewClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            adm.listarTodosClientes();
        }

        private void buttonLimpaCamposCliente_Click_1(object sender, EventArgs e)
        {
            limpaCampoCadastroCliente();
        }



        private void buttonLimpaCamposCliente_Click_2(object sender, EventArgs e)
        {
            limpaCampoCadastroCliente();
        }

        private void buttonAdicionaCliente_Click_2(object sender, EventArgs e)
        {
            string nome = txtNomeCliente.Text;
            string endereco = txtEnderecoCliente.Text;
            var dataNascimento = mskDataNascimento.Text;
            string email = txtEmailCliente.Text;
            string fone = txtTelefone.Text;
            string nomeConsultora = txtConsultora.Text;
            string sexo = "";
            if (rdbtnSexoFemininoCliente.Checked)
                sexo = "Feminino";
            else
                sexo = "Masculino";

            adm.registrarCliente(nome, endereco, dataNascimento, email, fone, sexo, nomeConsultora);
            limpaCampoCadastroCliente();
            labelTotalClientes.Text = "Total clientes: " + mKVIRTUALDataSet.Clientes.Count;

        }

        private void FormClientes_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'mKVIRTUALDataSet.Clientes'. Você pode movê-la ou removê-la conforme necessário.
            this.clientesTableAdapter.Fill(this.mKVIRTUALDataSet.Clientes);
            labelTotalClientes.Text = "Total clientes: " + mKVIRTUALDataSet.Clientes.Count;

        }

        private void buttonNovoCliente_Click(object sender, EventArgs e)
        {
            gpxCliente.Enabled = true;
        }

  
        private void buttonRemoverCliente_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Deseja Remover o Cliente selecionado?", "Sim", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (confirm.ToString().ToUpper() == "YES")
            {
                var cliente = new Cliente();
                cliente.Id = int.Parse(txtIDCliente.Text);
                cliente.Nome = txtNomeCliente.Text; ;
                cliente.Email = txtEmailCliente.Text;
                cliente.Telefone = txtTelefone.Text;
                cliente.Endereco = txtEnderecoCliente.Text;
                cliente.DataNascimento = mskDataNascimento.Text;
                cliente.NomeConsultora = txtConsultora.Text;

                adm.removeCliente(cliente);
                limpaCampoCadastroCliente();
                populaGrid();
                btnAdicionaCliente.Visible = true;
                btnSalvarAlteracao.Visible = false;
                labelTotalClientes.Text = "Total clientes: " + adm.ListaClientes.Count();
            }
            else
            {

            }
               
            
            
        }

        private void dataGridViewClientes_Click(object sender, EventArgs e)
        {
            if (dataGridViewClientes.SelectedRows.Count > 0)
            {
                labelLinhasSelecionadas.Visible = true;
                btnRemoverCliente.Visible = true;
                labelLinhasSelecionadas.Text = "Linhas selecionadas: " + dataGridViewClientes.SelectedRows.Count;
                //Linha atual selecionada do DataGridView
                txtIDCliente.Text = dataGridViewClientes.CurrentRow.Cells[0].Value.ToString();
                txtNomeCliente.Text = dataGridViewClientes.CurrentRow.Cells[1].Value.ToString();
                txtEnderecoCliente.Text = dataGridViewClientes.CurrentRow.Cells[2].Value.ToString();
                mskDataNascimento.Text = dataGridViewClientes.CurrentRow.Cells[3].Value.ToString();
                txtEmailCliente.Text = dataGridViewClientes.CurrentRow.Cells[4].Value.ToString();
                txtTelefone.Text = dataGridViewClientes.CurrentRow.Cells[5].Value.ToString();

                if (dataGridViewClientes.CurrentRow.Cells[6].Value.ToString() == "Masculino")
                    rdbtnSexoMasculinoCliente.Checked = true;
                else
                    rdbtnSexoFemininoCliente.Checked = true;

                txtConsultora.Text = dataGridViewClientes.CurrentRow.Cells[7].Value.ToString();
                btnAdicionaCliente.Visible = false;
                btnSalvarAlteracao.Visible = true;
                gpxCliente.Enabled = true;

            }
        }

        private void buttonSalvarAlteracao_Click(object sender, EventArgs e)
        {
            var cliente = new Cliente();
            cliente.Id = int.Parse(txtIDCliente.Text);
            cliente.Nome = txtNomeCliente.Text;;
            cliente.Email = txtEmailCliente.Text;
            cliente.Telefone = txtTelefone.Text;
            cliente.Endereco = txtEnderecoCliente.Text;
            cliente.DataNascimento = mskDataNascimento.Text;

            if (rdbtnSexoFemininoCliente.Checked)
                cliente.Sexo = "Feminino";
            else
                cliente.Sexo = "Masculino";

            cliente.NomeConsultora = txtConsultora.Text;

            adm.editarCliente(cliente);
            populaGrid();
            btnSalvarAlteracao.Visible = false;
            btnAdicionaCliente.Visible = true;
            limpaCampoCadastroCliente();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPesquisaNomeCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }
    }
}
