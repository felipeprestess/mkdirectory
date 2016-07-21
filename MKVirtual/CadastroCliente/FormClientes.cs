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

        private void buttonAdicionaCliente_Click(object sender, EventArgs e)
        {
            string nome = textBoxNomeCliente.Text;
            string endereco = textBoxEnderecoCliente.Text;
            string email = textBoxEmailCliente.Text;
            string fone = textBoxTelefoneCliente.Text;
            string nomeConsultora = textBoxNomeConsultoraCliente.Text;
            string sexo = "";
            if (radioButtonSexoFemininoCliente.Checked)
                sexo = "Feminino";
            else
                sexo = "Masculino";

            adm.registrarCliente(nome, endereco, email, fone, sexo, nomeConsultora);
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
            textBoxIdadeCadastroCliente.Clear();
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
                DataTable table = new DataTable();
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
            Cliente clientePesquisadoUser = new Cliente() { Nome = textBoxPesquisaNomeCliente.Text };
            adm.pesquisarCliente(clientePesquisadoUser);
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
            adm.listarTodosClientes();
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
            string endereco = textBoxEnderecoCliente.Text;
           
            string email = textBoxEmailCliente.Text;
            string nomeConsultora = textBoxNomeConsultoraCliente.Text;
            string fone = textBoxTelefoneCliente.Text;
            string sexo = "";
            if (radioButtonSexoFemininoCliente.Checked)
                sexo = "Feminino";
            else
                sexo = "Masculino";

            adm.registrarCliente(nome, endereco, email, fone, sexo, nomeConsultora);
            limpaCampoCadastroCliente();
            labelTotalClientes.Text = "Total clientes: " + adm.listaClientes.Count;
        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {
            //DataGridView
        }

        private void buttonLimpaCamposCliente_Click_2(object sender, EventArgs e)
        {
            limpaCampoCadastroCliente();
        }

        private void buttonAdicionaCliente_Click_2(object sender, EventArgs e)
        {
            string nome = textBoxNomeCliente.Text;
            string endereco = textBoxEnderecoCliente.Text;
            int idade = int.Parse(textBoxIdadeCadastroCliente.Text);
            string email = textBoxEmailCliente.Text;
            string fone = textBoxTelefoneCliente.Text;
            string nomeConsultora = textBoxNomeConsultoraCliente.Text;
            string sexo = "";
            if (radioButtonSexoFemininoCliente.Checked)
                sexo = "Feminino";
            else
                sexo = "Masculino";

            adm.registrarCliente(nome, endereco, email, fone, sexo, nomeConsultora);
            limpaCampoCadastroCliente();
            labelTotalClientes.Text = "Total clientes: " + adm.listaClientes.Count;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void FormClientes_Load(object sender, EventArgs e)
        {

        }
    }
}
