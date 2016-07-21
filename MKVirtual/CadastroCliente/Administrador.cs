using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CadastroCliente
{
    class Administrador : Usuario
    {//Classe responsável pela administração do sistema
        public Administrador()
            :base(1)
        {

        }
        public List<Cliente> listaClientes = new List<Cliente>();
        public List<Parceira> listaParceiras = new List<Parceira>();
        public List<Produto> listaProduto = new List<Produto>();
        public List<Usuario> listaUsuarios = new List<Usuario>();


        //Pesquisar por cliente
        public void pesquisarCliente(Cliente cliente)
        {
            Cliente ClientePesquisado = new Cliente() { Nome = cliente.Nome };
            foreach (Cliente clienteDaLista in listaClientes)
            {
                if (ClientePesquisado.Nome == clienteDaLista.Nome)
                {
                    MessageBox.Show(string.Format("Nome: {0}\nEmail: {1}\nTelefone: {2}", clienteDaLista.Nome, clienteDaLista.Email, clienteDaLista.Telefone));
                    break;
                }
            }
        }
        //Listar todos clientes
        public List<Cliente> listarTodosClientes()
        {
            return listaClientes;
        }
        /*Método de adicionar cliente*/
        public void registrarCliente(string nome,string endereco ,int idade, string email, string fone, string sexo, string nomeConsultora)
        {
            Cliente person = new Cliente() { Nome = nome, Endereco = endereco,  Idade = idade, Email = email, Telefone = fone, Sexo = sexo, NomeConsultora = nomeConsultora};
            listaClientes.Add(person);
            MessageBox.Show("Cliente adicionado com sucesso!", "Cadastro Cliente");
        }
        /*Método de excluir cliente*/
        public void removeCliente(Cliente cliente)
        {
            listaClientes.Remove(cliente);
            MessageBox.Show("Cliente removido!");
        }
        /*Método de editar cliente*/
        public void editarCliente()
        {

        }

        public void registrarParceira(string nome, string produto, string email)
        {
            Parceira usr = new Parceira() { NomeParceira = nome, ProdutoVendaParceira = produto, EmailParceira = email };
            listaParceiras.Add(usr);
            MessageBox.Show("Registro realizado com sucesso!");
        }

        public void registrarProduto(string nome, string tipo, decimal preco, string linha )
        {
            Produto prd = new Produto() { NomeProduto = nome, TipoProduto = tipo, PrecoProduto = preco, LinhaProduto = linha };
            listaProduto.Add(prd);
            MessageBox.Show("Registro realizado com sucesso!");
        }
    }
}
