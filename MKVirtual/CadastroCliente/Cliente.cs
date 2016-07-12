﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CadastroCliente
{
    public class Cliente
    {
        string nome;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        int idade;
        public int Idade
        {
            get { return idade; }
            set { idade = value; }
        }
        string email;
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        int telefone;
        public int Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

        string sexo;
        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }
        public List<Cliente> listaClientes = new List<Cliente>();

        //Pesquisar por cliente
        public void pesquisarCliente(Cliente cliente)
        {
            Cliente ClientePesquisado = new Cliente() { Nome = cliente.nome };
            foreach (Cliente clienteDaLista in listaClientes)
            {
                if (ClientePesquisado.Nome == clienteDaLista.nome)
                {
                    MessageBox.Show(string.Format("Nome: {0}\nEmail: {1}\n Telefone: {2}", clienteDaLista.nome, clienteDaLista.email, clienteDaLista.telefone));
                    break;
                }
            }
        }
        
        //Listar todos clientes
        public void listarTodosClientes()
        {
            foreach (Cliente ClienteDaLista in listaClientes)
            {
                MessageBox.Show(string.Format("Nome: {0}\nIdade: {1}\nEmail: {2}\nTelefone: {3}", ClienteDaLista.nome, ClienteDaLista.idade, ClienteDaLista.email, ClienteDaLista.telefone));
            }
        }
      
        


        /*Método de adicionar cliente*/
        public void adicionaCliente(string nome, int idade, string email, int fone, string sexo)
        {
            Cliente person = new Cliente() { Nome = nome, Idade = idade, Email = email, Telefone = fone, Sexo = sexo };
            listaClientes.Add(person);
            MessageBox.Show("Cliente adicionado com sucesso!", "Cadastro Cliente");   
        }




        

    }
}