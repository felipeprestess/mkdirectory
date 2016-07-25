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
    public partial class FormVenda : Form
    {
        public FormVenda()
        {
            InitializeComponent();
        }

        private void buttonNovaVendaVendas_Click(object sender, EventArgs e)
        {
            FormNovaVenda formNovaVenda = new FormNovaVenda();
            formNovaVenda.Show();
        }
    }
}
