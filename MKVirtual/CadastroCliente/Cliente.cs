using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CadastroCliente
{
    public class Cliente
    {
        public string Nome{get; set;}
        public int Idade { get; set; }
        public string Email { get; set; }
        public int Telefone { get; set; }
        public char Sexo { get; set; }

        public void listaCliente() { }
        
      
        


        /*Método de adicionar cliente*/
        public void adicionaCliente(string nome, int idade, string email, int fone, char sexo)
        {
            Cliente person = new Cliente();
            person.Nome = nome;
            person.Idade = idade;
            person.Email = email;
            person.Telefone = fone;
            person.Sexo = sexo;
            List<Cliente> mCliente = new List<Cliente>();
            mCliente.Add(person);

            foreach (var cliente in mCliente)
            {
                MessageBox.Show("Cliente " + cliente.Nome + "adicionado com sucesso!", "Cadastro Cliente");
            }
                
        }




        

    }
}
