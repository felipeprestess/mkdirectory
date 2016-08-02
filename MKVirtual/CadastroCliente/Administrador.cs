using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace CadastroCliente
{

    class Administrador : Usuario
    {//Classe responsável pela administração do sistema
        public Administrador()
            : base(1)
        {
            listaClientes = new List<Cliente>();
            listaProdutos = new List<Produto>();
            proximoIdDisponivel = 1;
        }

        private int proximoIdDisponivel;

        private List<Cliente> listaClientes;
        public IEnumerable<Cliente> ListaClientes { get { return listaClientes; } }
        public List<Produto> listaProdutos;
        public IEnumerable<Produto> ListaProdutos { get { return listaProdutos; } }

        public List<Parceira> listaParceiras = new List<Parceira>();
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
            try
            {
                using (SqlConnection conn = new SqlConnection(@"Server = NOTEBOOKFPRESTE; Database = MKVIRTUAL; Integrated Security = SSPI;"))
                {
                    Cliente person = new Cliente() { Nome = nome, Endereco = endereco, DataNascimento = dataNascimento, Email = email, Telefone = fone, Sexo = sexo, NomeConsultora = nomeConsultora };
                    SqlCommand command = new SqlCommand("SET DATEFORMAT dmy; INSERT INTO Clientes (ClienteNome, ClienteEndereco, ClienteNascimento, ClienteEmail,  ClienteTelefone, ClienteSexo, ClienteConsultora) VALUES (@nome, @endereco, @dataNascimento, @email , @fone, @sexo, @nomeConsultora )", conn);
                    command.Parameters.Add("@nome", SqlDbType.VarChar, 50).Value = person.Nome;
                    command.Parameters.Add("@endereco", SqlDbType.VarChar, 100).Value = person.Endereco;
                    command.Parameters.Add("@dataNascimento", SqlDbType.VarChar, 90).Value = person.DataNascimento;
                    command.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = person.Email;
                    command.Parameters.Add("@fone", SqlDbType.VarChar, 15).Value = person.Telefone;
                    command.Parameters.Add("@sexo", SqlDbType.VarChar, 15).Value = person.Sexo;
                    command.Parameters.Add("@nomeConsultora", SqlDbType.VarChar, 50).Value = person.NomeConsultora;

                    conn.Open();
                    command.ExecuteNonQuery();
                    person.Id = proximoIdDisponivel;
                    listaClientes.Add(person);


                    proximoIdDisponivel++;//Id do cliente
                    MessageBox.Show("Cliente adicionado com sucesso!", "Cadastro Cliente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não possível cadastrar o cliente. Motivo: " +ex.Message);
            }
           
            
        }
        /*Método de excluir cliente*/
        public void removeCliente(Cliente cliente)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(@"Server = NOTEBOOKFPRESTE; Database = MKVIRTUAL; Integrated Security = SSPI;"))
                {
                    //Cliente remover = listaClientes.Where(t => t.Id == cliente.Id).FirstOrDefault();
                    var remover = new Cliente();
                    remover.Id = cliente.Id;
                    SqlCommand command = new SqlCommand("DELETE FROM Clientes WHERE ClienteCodigo = @id",conn);
                    command.Parameters.AddWithValue("@id", remover.Id);
                    conn.Open();
                    command.ExecuteNonQuery();
                    listaClientes.Remove(remover);

                    MessageBox.Show("Cliente removido!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível. Motivo: " + ex.Message);
            }
        }
        /*Método de editar cliente*/
        public void editarCliente(Cliente cliente)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(@"Server = NOTEBOOKFPRESTE; Database = MKVIRTUAL; Integrated Security = SSPI;"))
                {
                    Cliente atualizar = new Cliente();
                    atualizar.Id = cliente.Id;
                    atualizar.Nome = cliente.Nome;
                    atualizar.Endereco = cliente.Endereco;
                    atualizar.DataNascimento = cliente.DataNascimento;
                    atualizar.Email = cliente.Email;
                    atualizar.Telefone = cliente.Telefone;
                    atualizar.Sexo = cliente.Sexo;
                    atualizar.NomeConsultora = cliente.NomeConsultora;
                    SqlCommand command = new SqlCommand("SET DATEFORMAT dmy; UPDATE Clientes SET ClienteNome = @nome, ClienteEndereco = @endereco, ClienteNascimento = @nascimento, ClienteEmail = @email, ClienteTelefone = @fone, ClienteSexo = @sexo, ClienteConsultora = @consultora WHERE ClienteCodigo = @id ", conn);
                    //Cliente atualizar = listaClientes.Where(t => t.Id == cliente.Id).FirstOrDefault();
                    
                    if (atualizar == null)
                        throw new Exception("Cliente não encontrado.");

                    command.Parameters.AddWithValue("@id", cliente.Id);
                    command.Parameters.AddWithValue("@nome", cliente.Nome);
                    command.Parameters.AddWithValue("@endereco", cliente.Endereco);
                    command.Parameters.AddWithValue("@nascimento", cliente.DataNascimento);
                    command.Parameters.AddWithValue("@email", cliente.Email);
                    command.Parameters.AddWithValue("@fone", cliente.Telefone);
                    command.Parameters.AddWithValue("@sexo", cliente.Sexo);
                    command.Parameters.AddWithValue("@consultora", cliente.NomeConsultora);
                    //command.Parameters.AddWithValue("@nome",atualizar.Nome);

                    conn.Open();
                    command.ExecuteNonQuery();


                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show("Não foi possível atualizar. Motivo: " + ex.Message);
            }

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
            prd.Id = proximoIdDisponivel;
            listaProdutos.Add(prd);
            proximoIdDisponivel++;
            MessageBox.Show("Registro realizado com sucesso!");
        }

        public void editarProduto(Produto produto)
        {
            Produto atualizar = listaProdutos.Where(t => t.Id == produto.Id).FirstOrDefault();

            if (atualizar == null)
                throw new Exception("Produto não encontrado.");

            atualizar.NomeProduto = produto.NomeProduto;
            atualizar.TipoProduto = produto.TipoProduto;
            atualizar.PrecoProduto = produto.PrecoProduto;
            atualizar.LinhaProduto = produto.LinhaProduto;
        }

        public void removerProduto(Produto produto)
        {
            Produto remover = listaProdutos.Where(t => t.Id == produto.Id).FirstOrDefault();
            listaProdutos.Remove(remover);
            MessageBox.Show("Produto removido!");
        }
    }
}
