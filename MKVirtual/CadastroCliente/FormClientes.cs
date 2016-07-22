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
        DataTable table;


        public FormClientes()
        {
            InitializeComponent();
            adm = new Administrador();
            table = new DataTable();
        }

        private void buttonAdicionaCliente_Click(object sender, EventArgs e)
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
            labelTotalClientes.Text = "Total clientes: " + adm.listaClientes.Count;
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
        }

        private void textBoxNomeCliente_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBoxIdadeCliente_TextChanged(object sender, EventArgs e)
        {
           
            
        }

        private void textBoxEmailCliente_TextChanged(object sender, EventArgs e)
        {
            
        }

       

        private void buttonMostrarTodosClientes_Click(object sender, EventArgs e)
        {
           
            
            dataGridViewClientes.DataSource = adm.listarTodosClientes();
            if (adm.listaClientes.Count > 0)
            {
                
                dataGridViewClientes.DataSource = table;
                List<Cliente> LsTemp = adm.listarTodosClientes();
                var columns = from t in LsTemp
                              orderby t.Nome
                              select new
                              {
                                  Nome = t.Nome,
                                  Email = t.Email,
                                  Telefone = t.Telefone,
                                  Endereco = t.Endereco,
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
            if(String.IsNullOrEmpty(textBoxPesquisaNomeCliente.Text))
                MessageBox.Show("Insira um nome!","Ops...");
            adm.pesquisarCliente(nomePesquisado);
            limpaCampoCadastroCliente();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listViewClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            adm.listarTodosClientes();
        }

        private void buttonLimpaCamposCliente_Click_1(object sender, EventArgs e)
        {
            limpaCampoCadastroCliente();
        }

        private void buttonAdicionaCliente_Click_1(object sender, EventArgs e)
        {
            string nome = textBoxNomeCliente.Text;
            string endereco = textBoxEnderecoCliente.Text;
            string dataNascimento = dataNascimentoCliente.Text;
            string email = textBoxEmailCliente.Text;
            string nomeConsultora = textBoxNomeConsultoraCliente.Text;
            string fone = textBoxTelefoneCliente.Text;
            string sexo = "";
            if (radioButtonSexoFemininoCliente.Checked)
                sexo = "Feminino";
            else
                sexo = "Masculino";

            adm.registrarCliente(nome, endereco, dataNascimento, email, fone, sexo, nomeConsultora);
            limpaCampoCadastroCliente();
            labelTotalClientes.Text = "Total clientes: " + adm.listaClientes.Count;
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
            labelTotalClientes.Text = "Total clientes: " + adm.listaClientes.Count;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void FormClientes_Load(object sender, EventArgs e)
        {

        }

        private void buttonNovoCliente_Click(object sender, EventArgs e)
        {
            groupBoxNovoCliente.Visible = true;
        }

        private void textBoxPesquisaNomeCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonRemoverCliente_Click(object sender, EventArgs e)
        {
            //adm.removeCliente();
        }

        private void dataGridViewClientes_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void dataGridViewClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            labelLinhasSelecionadas.Visible = true;
            Int32 linhasSelecionadas = dataGridViewClientes.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if(linhasSelecionadas > 0)
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < linhasSelecionadas; i++)
                {
                    sb.Append("Linha: ");
                    sb.Append(dataGridViewClientes.SelectedRows[i].Index.ToString());
                    sb.Append(Environment.NewLine);
                }
                sb.Append(labelLinhasSelecionadas.Text + ":" + linhasSelecionadas.ToString());
            }
        }

        private void dataGridViewClientes_Click(object sender, EventArgs e)
        {
            if (dataGridViewClientes.SelectedRows.Count > 0)
            {
                labelLinhasSelecionadas.Visible = true;
                labelLinhasSelecionadas.Text = "Linhas selecionadas: " + dataGridViewClientes.SelectedRows.Count;
            }
        }
    }
}
