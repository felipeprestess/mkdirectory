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
            : base(1)
        {
            listaClientes = new List<Cliente>();
            proximoIdDisponivel = 1;
        }

        private int proximoIdDisponivel;

        private List<Cliente> listaClientes;
        public IEnumerable<Cliente> ListaClientes { get { return listaClientes; } }

        public List<Parceira> listaParceiras = new List<Parceira>();
        public List<Produto> listaProduto = new List<Produto>();
        public List<Usuario> listaUsuarios = new List<Usuario>();
        public AutoCompleteStringCollection listaNovaClientes = new AutoCompleteStringCollection();


        //Pesquisar por cliente
        public void pesquisarCliente(string NomeAPesquisar)
        {
            IEnumerator<Cliente> clientes = new List<Cliente>().GetEnumerator();


            Cliente ClientePesquisado = new Cliente() { Nome = NomeAPesquisar };
            foreach (Cliente clienteDaLista in ListaClientes)
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
        public void registrarCliente(string nome, string endereco, string dataNascimento, string email, string fone, string sexo, string nomeConsultora)
        {
            Cliente person = new Cliente() { Nome = nome, Endereco = endereco, DataNascimento = dataNascimento, Email = email, Telefone = fone, Sexo = sexo, NomeConsultora = nomeConsultora };
            person.Id = proximoIdDisponivel;
            listaClientes.Add(person);

            proximoIdDisponivel++;
            MessageBox.Show("Cliente adicionado com sucesso!", "Cadastro Cliente");
        }
        /*Método de excluir cliente*/
        public void removeCliente(Cliente cliente)
        {
            listaClientes.Remove(cliente);
            MessageBox.Show("Cliente removido!");
        }
        /*Método de editar cliente*/
        public void editarCliente(Cliente cliente)
        {
            Cliente atualizar = listaClientes.Where(t => t.Id == cliente.Id).FirstOrDefault();

            if (atualizar == null)
                throw new Exception("Cliente não encontrado.");

            atualizar.Nome = cliente.Nome;
            atualizar.Endereco = cliente.Endereco;
            atualizar.Email = cliente.Email;
            atualizar.Telefone = cliente.Telefone;
            atualizar.DataNascimento = cliente.DataNascimento;
            atualizar.NomeConsultora = cliente.NomeConsultora;

        }

        public void registrarParceira(string nome, string produto, string email)
        {
            Parceira usr = new Parceira() { NomeParceira = nome, ProdutoVendaParceira = produto, EmailParceira = email };
            listaParceiras.Add(usr);
            MessageBox.Show("Registro realizado com sucesso!");
        }

        public void registrarProduto(string nome, string tipo, decimal preco, string linha)
        {
            Produto prd = new Produto() { NomeProduto = nome, TipoProduto = tipo, PrecoProduto = preco, LinhaProduto = linha };
            listaProduto.Add(prd);
            MessageBox.Show("Registro realizado com sucesso!");
        }
    }
}
