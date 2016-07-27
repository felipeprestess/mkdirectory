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

        }

        private void buttonLimpaCamposCliente_Click(object sender, EventArgs e)
        {
            limpaCampoCadastroCliente();
        }

        private void limpaCampoCadastroCliente()
        {
            txtNomeCliente.Clear();
            txtEnderecoCliente.Clear();
            dataNascimentoCliente.ResetText();
            txtEmailCliente.Clear();
            mskTelefoneCliente.Clear();
            txtNomeConsultoraCliente.Clear();
            rdbtnSexoFemininoCliente.Checked = false;
            rdbtnSexoMasculinoCliente.Checked = false;
            txtPesquisaNomeCliente.Clear();
            txtIDCliente.Clear();
        }




        private void buttonMostrarTodosClientes_Click(object sender, EventArgs e)
        {
            populaGrid();
        }

        private void populaGrid()
        {
            
            //dataGridViewClientes.DataSource = adm.listarTodosClientes();
            //if (adm.ListaClientes.Any())
            //{
            //    var dataTable = from t in felipeCostaDataSet.Clientes
            //                  orderby t.ClienteCodigo
            //                  select new
            //                  {
            //                      Codigo = t.ClienteCodigo,
            //                      Nome = t.ClienteNome,
            //                      Email = t.ClienteEmail,
            //                      Endereco = t.ClienteEndereco,
            //                      DataNascimento = t.ClienteNascimento,
            //                      Sexo = t.ClienteSexo,
                                  
            //                  };
            //    dataGridViewClientes.DataSource = dataTable.ToList();
            //    dataGridViewClientes.Visible = true;
            //    dataGridViewClientes.Show();
            //}




            dataGridViewClientes.DataSource = felipeCostaDataSet.Clientes;
            if (felipeCostaDataSet.Clientes.Any())
            {
                DataTable dataTable = new DataTable();
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
            string dataNascimento = dataNascimentoCliente.Text;
            string email = txtEmailCliente.Text;
            string fone = mskTelefoneCliente.Text;
            string nomeConsultora = txtNomeConsultoraCliente.Text;
            string sexo = "";
            if (rdbtnSexoFemininoCliente.Checked)
                sexo = "Feminino";
            else
                sexo = "Masculino";

            adm.registrarCliente(nome, endereco, dataNascimento, email, fone, sexo, nomeConsultora);
            limpaCampoCadastroCliente();
            labelTotalClientes.Text = "Total clientes: " + adm.ListaClientes.Count();

        }

        private void FormClientes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'felipeCostaDataSet.Clientes' table. You can move, or remove it, as needed.
            this.clientesTableAdapter.Fill(this.felipeCostaDataSet.Clientes);
            // TODO: This line of code loads data into the 'felipeCostaDataSet.Clientes' table. You can move, or remove it, as needed.
            

        }

        private void buttonNovoCliente_Click(object sender, EventArgs e)
        {
            gpxCliente.Enabled = true;
        }

  
        private void buttonRemoverCliente_Click(object sender, EventArgs e)
        {
            var cliente = new Cliente();
            cliente.Id = int.Parse(txtIDCliente.Text);
            cliente.Nome = txtNomeCliente.Text; ;
            cliente.Email = txtEmailCliente.Text;
            cliente.Telefone = mskTelefoneCliente.Text;
            cliente.Endereco = txtEnderecoCliente.Text;
            cliente.DataNascimento = dataNascimentoCliente.Text;
            cliente.NomeConsultora = txtNomeConsultoraCliente.Text;
            
            adm.removeCliente(cliente);
            limpaCampoCadastroCliente();
            populaGrid();
            btnAdicionaCliente.Visible = true;
            btnSalvarAlteracao.Visible = false;
            labelTotalClientes.Text = "Total clientes: " + adm.ListaClientes.Count();
            
            
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
                txtEmailCliente.Text = dataGridViewClientes.CurrentRow.Cells[2].Value.ToString();
                mskTelefoneCliente.Text = dataGridViewClientes.CurrentRow.Cells[3].Value.ToString();
                txtEnderecoCliente.Text = dataGridViewClientes.CurrentRow.Cells[4].Value.ToString();
                dataNascimentoCliente.Text = dataGridViewClientes.CurrentRow.Cells[5].Value.ToString();
                txtNomeConsultoraCliente.Text = dataGridViewClientes.CurrentRow.Cells[6].Value.ToString();
                btnAdicionaCliente.Visible = false;
                btnSalvarAlteracao.Visible = true;

            }
        }

        private void buttonSalvarAlteracao_Click(object sender, EventArgs e)
        {
            var cliente = new Cliente();
            cliente.Id = int.Parse(txtIDCliente.Text);
            cliente.Nome = txtNomeCliente.Text;;
            cliente.Email = txtEmailCliente.Text;
            cliente.Telefone = mskTelefoneCliente.Text;
            cliente.Endereco = txtEnderecoCliente.Text;
            cliente.DataNascimento = dataNascimentoCliente.Text;
            cliente.NomeConsultora = txtNomeConsultoraCliente.Text;

            adm.editarCliente(cliente);
            populaGrid();
            btnSalvarAlteracao.Visible = false;
            btnAdicionaCliente.Visible = true;
            limpaCampoCadastroCliente();
        }

        

        private void textBoxPesquisaNomeCliente_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}
