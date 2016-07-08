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
            int idade = Convert.ToInt32(textBoxIdadeCadastroCliente.Text);
            string email = textBoxEmailCliente.Text;
            int fone = Convert.ToInt32(textBoxTelefoneCliente.Text);
            char sexo = Convert.ToChar(radioButtonSexoCliente.Checked);
            cliente.adicionaCliente(nome, idade, email, fone, sexo);
            limpaCampoCadastroCliente();
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
        }

        private void textBoxNomeCliente_TextChanged(object sender, EventArgs e)
        {
            cliente.Nome = textBoxNomeCliente.Text;
        }

        private void textBoxIdadeCliente_TextChanged(object sender, EventArgs e)
        {
            cliente.Idade = Convert.ToInt32(textBoxIdadeCadastroCliente.Text);
            
        }

        private void textBoxEmailCliente_TextChanged(object sender, EventArgs e)
        {
            cliente.Email = textBoxEmailCliente.Text;
        }
    }
}
