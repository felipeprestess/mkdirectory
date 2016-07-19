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
        Cliente cliente;
        
        
        public FormClientes()
        {
            InitializeComponent();
            cliente = new Cliente();
            //cliente.adicionaCliente(textBoxNomeCliente.Text, Convert.ToInt32(textBoxIdadeCadastroCliente.Text), textBoxEmailCliente.Text);
            
        }

        private void buttonAdicionaCliente_Click(object sender, EventArgs e)
        {
            string nome = textBoxNomeCliente.Text;
            int idade = int.Parse(textBoxIdadeCadastroCliente.Text);
            string email = textBoxEmailCliente.Text;
            string fone = textBoxTelefoneCliente.Text;
            string sexo = "";
            if (radioButtonSexoFemininoCliente.Checked)
                sexo = "Feminino";
            else
                sexo = "Masculino";

            cliente.adicionaCliente(nome, idade, email, fone, sexo);
            limpaCampoCadastroCliente();
            labelTotalClientes.Text = "Total clientes: " + cliente.listaClientes.Count;
        }

        private void buttonLimpaCamposCliente_Click(object sender, EventArgs e)
        {
            limpaCampoCadastroCliente();
        }

        private void limpaCampoCadastroCliente()
        {
            textBoxNomeCliente.Clear();
            textBoxIdadeCadastroCliente.Clear();
            textBoxEmailCliente.Clear();
            textBoxTelefoneCliente.Clear();
            radioButtonSexoFemininoCliente.Checked = false;
            radioButtonSexoMasculinoCliente.Checked = false;
            textBoxPesquisaNomeCliente.Clear();
        }

        private void textBoxNomeCliente_TextChanged(object sender, EventArgs e)
        {
            cliente.Nome = textBoxNomeCliente.Text;
        }

        private void textBoxIdadeCliente_TextChanged(object sender, EventArgs e)
        {
            cliente.Idade = int.Parse(textBoxIdadeCadastroCliente.Text);
            
        }

        private void textBoxEmailCliente_TextChanged(object sender, EventArgs e)
        {
            cliente.Email = textBoxEmailCliente.Text;
        }

        private void buttonMostrarTodosClientes_Click(object sender, EventArgs e)
        {
           
            
            dataGridViewClientes.DataSource = cliente.listarTodosClientes();
            if (cliente.listaClientes.Count > 0)
            {
                DataTable table = new DataTable();
                dataGridViewClientes.DataSource = table;
                List<Cliente> LsTemp = cliente.listarTodosClientes();
                var columns = from t in LsTemp
                              orderby t.Nome
                              select new
                              {
                                  Nome = t.Nome,
                                  Email = t.Email,
                                  Telefone = t.Telefone,

                              };
                dataGridViewClientes.DataSource = columns.ToList();
                dataGridViewClientes.Visible = true;
                dataGridViewClientes.Show();
            }
            
            
            
        }

        private void buttonPesquisarCliente_Click(object sender, EventArgs e)
        { 
            Cliente clientePesquisadoUser = new Cliente() { Nome = textBoxPesquisaNomeCliente.Text };
            cliente.pesquisarCliente(clientePesquisadoUser);
            limpaCampoCadastroCliente();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listViewClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            cliente.listarTodosClientes();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonLimpaCamposCliente_Click_1(object sender, EventArgs e)
        {
            limpaCampoCadastroCliente();
        }

        private void buttonAdicionaCliente_Click_1(object sender, EventArgs e)
        {
            string nome = textBoxNomeCliente.Text;
            int idade = int.Parse(textBoxIdadeCadastroCliente.Text);
            string email = textBoxEmailCliente.Text;
            string fone = textBoxTelefoneCliente.Text;
            string sexo = "";
            if (radioButtonSexoFemininoCliente.Checked)
                sexo = "Feminino";
            else
                sexo = "Masculino";

            cliente.adicionaCliente(nome, idade, email, fone, sexo);
            limpaCampoCadastroCliente();
            labelTotalClientes.Text = "Total clientes: " + cliente.listaClientes.Count;
        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonLimpaCamposCliente_Click_2(object sender, EventArgs e)
        {
            limpaCampoCadastroCliente();
        }

        private void buttonAdicionaCliente_Click_2(object sender, EventArgs e)
        {
            string nome = textBoxNomeCliente.Text;
            int idade = int.Parse(textBoxIdadeCadastroCliente.Text);
            string email = textBoxEmailCliente.Text;
            string fone = textBoxTelefoneCliente.Text;
            string sexo = "";
            if (radioButtonSexoFemininoCliente.Checked)
                sexo = "Feminino";
            else
                sexo = "Masculino";

            cliente.adicionaCliente(nome, idade, email, fone, sexo);
            limpaCampoCadastroCliente();
            labelTotalClientes.Text = "Total clientes: " + cliente.listaClientes.Count;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
