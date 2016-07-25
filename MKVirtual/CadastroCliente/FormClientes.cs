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
    public partial class FormClientes : Form
    {
        Administrador adm;
                

        public FormClientes()
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
            textBoxNomeCliente.Clear();
            textBoxEnderecoCliente.Clear();
            dataNascimentoCliente.ResetText();
            textBoxEmailCliente.Clear();
            textBoxTelefoneCliente.Clear();
            textBoxNomeConsultoraCliente.Clear();
            radioButtonSexoFemininoCliente.Checked = false;
            radioButtonSexoMasculinoCliente.Checked = false;
            textBoxPesquisaNomeCliente.Clear();
            txtIDCliente.Clear();
        }




        private void buttonMostrarTodosClientes_Click(object sender, EventArgs e)
        {
            populaGrid();
        }

        private void populaGrid()
        {
            dataGridViewClientes.DataSource = adm.listarTodosClientes();
            if (adm.ListaClientes.Any())
            {
                var columns = from t in adm.ListaClientes
                              orderby t.Id
                              select new
                              {
                                  Id = t.Id,
                                  Nome = t.Nome,
                                  Email = t.Email,
                                  Telefone = t.Telefone,
                                  Endereco = t.Endereco,
                                  DataNascimento = t.DataNascimento,
                                  Sexo = t.Sexo,
                                  Consultora = t.NomeConsultora
                              };
                dataGridViewClientes.DataSource = columns.ToList();
                dataGridViewClientes.Visible = true;
                dataGridViewClientes.Show();
            }
        }

        private void buttonPesquisarCliente_Click(object sender, EventArgs e)
        {
            string nomePesquisado = textBoxPesquisaNomeCliente.Text;
            if (String.IsNullOrEmpty(textBoxPesquisaNomeCliente.Text))
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
            string nome = textBoxNomeCliente.Text;
            string endereco = textBoxEnderecoCliente.Text;
            string dataNascimento = dataNascimentoCliente.Text;
            string email = textBoxEmailCliente.Text;
            string fone = textBoxTelefoneCliente.Text;
            string nomeConsultora = textBoxNomeConsultoraCliente.Text;
            string sexo = "";
            if (radioButtonSexoFemininoCliente.Checked)
                sexo = "Feminino";
            else
                sexo = "Masculino";

            adm.registrarCliente(nome, endereco, dataNascimento, email, fone, sexo, nomeConsultora);
            limpaCampoCadastroCliente();
            labelTotalClientes.Text = "Total clientes: " + adm.ListaClientes.Count();

        }

        private void FormClientes_Load(object sender, EventArgs e)
        {

        }

        private void buttonNovoCliente_Click(object sender, EventArgs e)
        {
            groupBoxNovoCliente.Visible = true;
        }

  
        private void buttonRemoverCliente_Click(object sender, EventArgs e)
        {
            var cliente = new Cliente();
            cliente.Id = int.Parse(txtIDCliente.Text);
            cliente.Nome = textBoxNomeCliente.Text; ;
            cliente.Email = textBoxEmailCliente.Text;
            cliente.Telefone = textBoxTelefoneCliente.Text;
            cliente.Endereco = textBoxEnderecoCliente.Text;
            cliente.DataNascimento = dataNascimentoCliente.Text;
            cliente.NomeConsultora = textBoxNomeConsultoraCliente.Text;
            
            adm.removeCliente(cliente);
            limpaCampoCadastroCliente();
            populaGrid();
            buttonAdicionaCliente.Visible = true;
            buttonSalvarAlteracao.Visible = false;
            labelTotalClientes.Text = "Total clientes: " + adm.ListaClientes.Count();
            
            
        }

        private void dataGridViewClientes_Click(object sender, EventArgs e)
        {
            if (dataGridViewClientes.SelectedRows.Count > 0)
            {
                labelLinhasSelecionadas.Visible = true;
                buttonRemoverCliente.Visible = true;
                labelLinhasSelecionadas.Text = "Linhas selecionadas: " + dataGridViewClientes.SelectedRows.Count;
                //Linha atual selecionada do DataGridView
                txtIDCliente.Text = dataGridViewClientes.CurrentRow.Cells[0].Value.ToString();
                textBoxNomeCliente.Text = dataGridViewClientes.CurrentRow.Cells[1].Value.ToString();
                textBoxEmailCliente.Text = dataGridViewClientes.CurrentRow.Cells[2].Value.ToString();
                textBoxTelefoneCliente.Text = dataGridViewClientes.CurrentRow.Cells[3].Value.ToString();
                textBoxEnderecoCliente.Text = dataGridViewClientes.CurrentRow.Cells[4].Value.ToString();
                dataNascimentoCliente.Text = dataGridViewClientes.CurrentRow.Cells[5].Value.ToString();
                textBoxNomeConsultoraCliente.Text = dataGridViewClientes.CurrentRow.Cells[6].Value.ToString();
                buttonAdicionaCliente.Visible = false;
                buttonSalvarAlteracao.Visible = true;

            }
        }

        private void buttonSalvarAlteracao_Click(object sender, EventArgs e)
        {
            var cliente = new Cliente();
            cliente.Id = int.Parse(txtIDCliente.Text);
            cliente.Nome = textBoxNomeCliente.Text;;
            cliente.Email = textBoxEmailCliente.Text;
            cliente.Telefone = textBoxTelefoneCliente.Text;
            cliente.Endereco = textBoxEnderecoCliente.Text;
            cliente.DataNascimento = dataNascimentoCliente.Text;
            cliente.NomeConsultora = textBoxNomeConsultoraCliente.Text;

            adm.editarCliente(cliente);
            populaGrid();
            buttonSalvarAlteracao.Visible = false;
            buttonAdicionaCliente.Visible = true;
            limpaCampoCadastroCliente();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPesquisaNomeCliente_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
