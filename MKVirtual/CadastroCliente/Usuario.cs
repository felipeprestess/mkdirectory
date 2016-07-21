using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CadastroCliente
{
    public class Usuario
    {
        private int nivelAcesso;

        public Usuario(int nivelAcesso)
        {
            this.nivelAcesso = nivelAcesso;
        }

        private string nome;
        public virtual string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        private string endereco;
        public virtual string Endereco {
            get { return endereco; }
            set { endereco = value; }
        }

        private string email;
        public virtual string Email
        {
            get { return email; }
            set { email = value; }
        }

        private string telefone;
        public virtual string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

        private string sexo;
        public virtual string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        private string login;
        public virtual string Login {
            get { return login; }
            set { login = value; }
        }

        private string pass;
        public virtual string Pass {
            get { return pass; }
            set { pass = value; }
        }

        public void alterarDados()
        {
            
        }

        public void sad()
        {

        }
    }
}
