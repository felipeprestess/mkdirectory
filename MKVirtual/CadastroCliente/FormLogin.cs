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
    public partial class FormLogin : Form
    {
        Administrador adm;
        public FormLogin()
        {
            InitializeComponent();
            adm = new Administrador();
        }

        private void buttonLoginEntrar_Click(object sender, EventArgs e)
        {
            string loginUsuario = textBoxLogin.Text;
            string passUsuario = textBoxPass.Text;

            for (int i = 0; i < adm.listaUsuarios.Count; i++)
            {
                if(adm.listaUsuarios[i].Login == loginUsuario && adm.listaUsuarios[i].Pass == passUsuario )
                {
                    FormPrincipal formPrincipal = new FormPrincipal();
                    formPrincipal.Show();
                }
                    
            }
        }
    }
}
