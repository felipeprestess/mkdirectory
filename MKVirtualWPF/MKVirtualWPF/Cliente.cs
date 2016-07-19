using System;
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
            set{ nome = value; }
        }
        int idade;
        public int Idade 
        { 
            get{return idade;}
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
        private List<Cliente> listaClientes = new List<Cliente>();

      
        


        /*Método de adicionar cliente*/
        public void adicionaCliente(string nome, int idade, string email, int fone, string sexo)
        {
            Cliente person = new Cliente() { Nome = nome, Idade = idade, Email = email, Telefone = fone, Sexo = sexo};
            
            listaClientes.Add(person);

            MessageBox.Show(string.Format("Cliente adicionado com sucesso!" , "Cadastro Cliente"));

            
                
        }

      

        public void pesquisaCliente(Cliente p)
        {
            Cliente pes = new Cliente() { Nome = p.Nome };
             foreach (Cliente cliente in listaClientes)
                {
                    if (pes.Nome == cliente.Nome)
                    {
                        MessageBox.Show(string.Format("Nome: {0}\nEmail: {1}\nTelefone: {2}", cliente.nome, cliente.email,cliente.telefone));
                        break;
                    }
                   
                    
                   
                }
                 
            
        }


        public void listarTodosClientes()
        {
            foreach (Cliente cliente in listaClientes)
            {
                MessageBox.Show(string.Format("Nome: {0}\n Idade: {1}\n Email: {2}\n Fone: {3}\n Sexo: {4}",cliente.nome, cliente.idade, cliente.email, cliente.telefone, cliente.sexo));
            }
        }



        
    }
}
