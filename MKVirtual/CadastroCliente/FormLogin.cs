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
        FormPrincipal formPrincipal;
        public FormLogin()
        {
            InitializeComponent();
            adm = new Administrador();
        }

        private void buttonLoginEntrar_Click(object sender, EventArgs e)
        {
            formPrincipal = new FormPrincipal();
            string loginTemp = "adm";
            string passTemp = "adm";
            string loginUsuario = txtLogin.Text;
            string passUsuario = txtPass.Text;

            //for (int i = 0; i < adm.listaUsuarios.Count; i++)
            //{
            //    if(adm.listaUsuarios[i].Login == loginUsuario && adm.listaUsuarios[i].Pass == passUsuario )
            //    {
            //        FormPrincipal formPrincipal = new FormPrincipal();
            //        formPrincipal.Show();
            //    }
                    
            //}
            if (loginTemp == "adm" && passTemp == "adm")
                    formPrincipal.Show();
            else
                MessageBox.Show("Usuario nao encontrado!");
        }

        private void cbxOpcaoLogin_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnEntrar.Visible = true;
            lblLogin.Visible = true;
            lblPass.Visible = true;
            txtLogin.Visible = true;
            txtPass.Visible = true;
            lblOpcao.Visible = false;
            cbxOpcaoLogin.Visible = false;
        }
    }
}
