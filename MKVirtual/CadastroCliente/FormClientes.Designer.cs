namespace CadastroCliente
{
    partial class FormClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelNomeCadastroCliente = new System.Windows.Forms.Label();
            this.labelIdadeCadastroCliente = new System.Windows.Forms.Label();
            this.labelEmailCadastroCliente = new System.Windows.Forms.Label();
            this.textBoxNomeCliente = new System.Windows.Forms.TextBox();
            this.textBoxEmailCliente = new System.Windows.Forms.TextBox();
            this.buttonAdicionaCliente = new System.Windows.Forms.Button();
            this.buttonLimpaCamposCliente = new System.Windows.Forms.Button();
            this.textBoxIdadeCadastroCliente = new System.Windows.Forms.TextBox();
            this.labelTelefoneCadastroCliente = new System.Windows.Forms.Label();
            this.textBoxTelefoneCliente = new System.Windows.Forms.TextBox();
            this.labelSexoCadastroCliente = new System.Windows.Forms.Label();
            this.radioButtonSexoFemininoCliente = new System.Windows.Forms.RadioButton();
            this.radioButtonSexoMasculinoCliente = new System.Windows.Forms.RadioButton();
            this.buttonMostrarTodosClientes = new System.Windows.Forms.Button();
            this.textBoxPesquisaNomeCliente = new System.Windows.Forms.TextBox();
            this.buttonPesquisarCliente = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelTotalClientes = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNomeCadastroCliente
            // 
            this.labelNomeCadastroCliente.AutoSize = true;
            this.labelNomeCadastroCliente.Location = new System.Drawing.Point(452, 71);
            this.labelNomeCadastroCliente.Name = "labelNomeCadastroCliente";
            this.labelNomeCadastroCliente.Size = new System.Drawing.Size(35, 13);
            this.labelNomeCadastroCliente.TabIndex = 0;
            this.labelNomeCadastroCliente.Text = "Nome";
            // 
            // labelIdadeCadastroCliente
            // 
            this.labelIdadeCadastroCliente.AutoSize = true;
            this.labelIdadeCadastroCliente.Location = new System.Drawing.Point(451, 99);
            this.labelIdadeCadastroCliente.Name = "labelIdadeCadastroCliente";
            this.labelIdadeCadastroCliente.Size = new System.Drawing.Size(34, 13);
            this.labelIdadeCadastroCliente.TabIndex = 1;
            this.labelIdadeCadastroCliente.Text = "Idade";
            // 
            // labelEmailCadastroCliente
            // 
            this.labelEmailCadastroCliente.AutoSize = true;
            this.labelEmailCadastroCliente.Location = new System.Drawing.Point(452, 124);
            this.labelEmailCadastroCliente.Name = "labelEmailCadastroCliente";
            this.labelEmailCadastroCliente.Size = new System.Drawing.Size(32, 13);
            this.labelEmailCadastroCliente.TabIndex = 2;
            this.labelEmailCadastroCliente.Text = "Email";
            // 
            // textBoxNomeCliente
            // 
            this.textBoxNomeCliente.Location = new System.Drawing.Point(504, 64);
            this.textBoxNomeCliente.Name = "textBoxNomeCliente";
            this.textBoxNomeCliente.Size = new System.Drawing.Size(141, 20);
            this.textBoxNomeCliente.TabIndex = 3;
            this.textBoxNomeCliente.TextChanged += new System.EventHandler(this.textBoxNomeCliente_TextChanged);
            // 
            // textBoxEmailCliente
            // 
            this.textBoxEmailCliente.Location = new System.Drawing.Point(504, 117);
            this.textBoxEmailCliente.Name = "textBoxEmailCliente";
            this.textBoxEmailCliente.Size = new System.Drawing.Size(141, 20);
            this.textBoxEmailCliente.TabIndex = 5;
            this.textBoxEmailCliente.TextChanged += new System.EventHandler(this.textBoxEmailCliente_TextChanged);
            // 
            // buttonAdicionaCliente
            // 
            this.buttonAdicionaCliente.Location = new System.Drawing.Point(458, 221);
            this.buttonAdicionaCliente.Name = "buttonAdicionaCliente";
            this.buttonAdicionaCliente.Size = new System.Drawing.Size(81, 23);
            this.buttonAdicionaCliente.TabIndex = 6;
            this.buttonAdicionaCliente.Text = "Cadastrar";
            this.buttonAdicionaCliente.UseVisualStyleBackColor = true;
            this.buttonAdicionaCliente.Click += new System.EventHandler(this.buttonAdicionaCliente_Click);
            // 
            // buttonLimpaCamposCliente
            // 
            this.buttonLimpaCamposCliente.Location = new System.Drawing.Point(570, 221);
            this.buttonLimpaCamposCliente.Name = "buttonLimpaCamposCliente";
            this.buttonLimpaCamposCliente.Size = new System.Drawing.Size(75, 23);
            this.buttonLimpaCamposCliente.TabIndex = 7;
            this.buttonLimpaCamposCliente.Text = "Limpar";
            this.buttonLimpaCamposCliente.UseVisualStyleBackColor = true;
            this.buttonLimpaCamposCliente.Click += new System.EventHandler(this.buttonLimpaCamposCliente_Click);
            // 
            // textBoxIdadeCadastroCliente
            // 
            this.textBoxIdadeCadastroCliente.Location = new System.Drawing.Point(504, 91);
            this.textBoxIdadeCadastroCliente.Name = "textBoxIdadeCadastroCliente";
            this.textBoxIdadeCadastroCliente.Size = new System.Drawing.Size(141, 20);
            this.textBoxIdadeCadastroCliente.TabIndex = 8;
            // 
            // labelTelefoneCadastroCliente
            // 
            this.labelTelefoneCadastroCliente.AutoSize = true;
            this.labelTelefoneCadastroCliente.Location = new System.Drawing.Point(452, 152);
            this.labelTelefoneCadastroCliente.Name = "labelTelefoneCadastroCliente";
            this.labelTelefoneCadastroCliente.Size = new System.Drawing.Size(49, 13);
            this.labelTelefoneCadastroCliente.TabIndex = 9;
            this.labelTelefoneCadastroCliente.Text = "Telefone";
            // 
            // textBoxTelefoneCliente
            // 
            this.textBoxTelefoneCliente.Location = new System.Drawing.Point(504, 144);
            this.textBoxTelefoneCliente.Name = "textBoxTelefoneCliente";
            this.textBoxTelefoneCliente.Size = new System.Drawing.Size(141, 20);
            this.textBoxTelefoneCliente.TabIndex = 10;
            // 
            // labelSexoCadastroCliente
            // 
            this.labelSexoCadastroCliente.AutoSize = true;
            this.labelSexoCadastroCliente.Location = new System.Drawing.Point(455, 175);
            this.labelSexoCadastroCliente.Name = "labelSexoCadastroCliente";
            this.labelSexoCadastroCliente.Size = new System.Drawing.Size(31, 13);
            this.labelSexoCadastroCliente.TabIndex = 11;
            this.labelSexoCadastroCliente.Text = "Sexo";
            // 
            // radioButtonSexoFemininoCliente
            // 
            this.radioButtonSexoFemininoCliente.AutoSize = true;
            this.radioButtonSexoFemininoCliente.Location = new System.Drawing.Point(504, 173);
            this.radioButtonSexoFemininoCliente.Name = "radioButtonSexoFemininoCliente";
            this.radioButtonSexoFemininoCliente.Size = new System.Drawing.Size(67, 17);
            this.radioButtonSexoFemininoCliente.TabIndex = 12;
            this.radioButtonSexoFemininoCliente.TabStop = true;
            this.radioButtonSexoFemininoCliente.Text = "Feminino";
            this.radioButtonSexoFemininoCliente.UseVisualStyleBackColor = true;
            // 
            // radioButtonSexoMasculinoCliente
            // 
            this.radioButtonSexoMasculinoCliente.AutoSize = true;
            this.radioButtonSexoMasculinoCliente.Location = new System.Drawing.Point(577, 173);
            this.radioButtonSexoMasculinoCliente.Name = "radioButtonSexoMasculinoCliente";
            this.radioButtonSexoMasculinoCliente.Size = new System.Drawing.Size(73, 17);
            this.radioButtonSexoMasculinoCliente.TabIndex = 13;
            this.radioButtonSexoMasculinoCliente.TabStop = true;
            this.radioButtonSexoMasculinoCliente.Tag = "";
            this.radioButtonSexoMasculinoCliente.Text = "Masculino";
            this.radioButtonSexoMasculinoCliente.UseVisualStyleBackColor = true;
            // 
            // buttonMostrarTodosClientes
            // 
            this.buttonMostrarTodosClientes.Location = new System.Drawing.Point(439, 5);
            this.buttonMostrarTodosClientes.Name = "buttonMostrarTodosClientes";
            this.buttonMostrarTodosClientes.Size = new System.Drawing.Size(89, 23);
            this.buttonMostrarTodosClientes.TabIndex = 14;
            this.buttonMostrarTodosClientes.Text = "Mostrar Todos";
            this.buttonMostrarTodosClientes.UseVisualStyleBackColor = true;
            this.buttonMostrarTodosClientes.Click += new System.EventHandler(this.buttonMostrarTodosClientes_Click);
            // 
            // textBoxPesquisaNomeCliente
            // 
            this.textBoxPesquisaNomeCliente.Location = new System.Drawing.Point(19, 5);
            this.textBoxPesquisaNomeCliente.Name = "textBoxPesquisaNomeCliente";
            this.textBoxPesquisaNomeCliente.Size = new System.Drawing.Size(100, 20);
            this.textBoxPesquisaNomeCliente.TabIndex = 15;
            // 
            // buttonPesquisarCliente
            // 
            this.buttonPesquisarCliente.Location = new System.Drawing.Point(125, 5);
            this.buttonPesquisarCliente.Name = "buttonPesquisarCliente";
            this.buttonPesquisarCliente.Size = new System.Drawing.Size(75, 23);
            this.buttonPesquisarCliente.TabIndex = 16;
            this.buttonPesquisarCliente.Text = "Pesquisar";
            this.buttonPesquisarCliente.UseVisualStyleBackColor = true;
            this.buttonPesquisarCliente.Click += new System.EventHandler(this.buttonPesquisarCliente_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(38, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(266, 188);
            this.panel1.TabIndex = 17;
            // 
            // labelTotalClientes
            // 
            this.labelTotalClientes.AutoSize = true;
            this.labelTotalClientes.Location = new System.Drawing.Point(535, 14);
            this.labelTotalClientes.Name = "labelTotalClientes";
            this.labelTotalClientes.Size = new System.Drawing.Size(83, 13);
            this.labelTotalClientes.TabIndex = 18;
            this.labelTotalClientes.Text = "Total Clientes: 0";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(266, 188);
            this.dataGridView1.TabIndex = 0;
            // 
            // FormClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 358);
            this.Controls.Add(this.labelTotalClientes);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonPesquisarCliente);
            this.Controls.Add(this.textBoxPesquisaNomeCliente);
            this.Controls.Add(this.buttonMostrarTodosClientes);
            this.Controls.Add(this.radioButtonSexoMasculinoCliente);
            this.Controls.Add(this.radioButtonSexoFemininoCliente);
            this.Controls.Add(this.labelSexoCadastroCliente);
            this.Controls.Add(this.textBoxTelefoneCliente);
            this.Controls.Add(this.labelTelefoneCadastroCliente);
            this.Controls.Add(this.textBoxIdadeCadastroCliente);
            this.Controls.Add(this.buttonLimpaCamposCliente);
            this.Controls.Add(this.buttonAdicionaCliente);
            this.Controls.Add(this.textBoxEmailCliente);
            this.Controls.Add(this.textBoxNomeCliente);
            this.Controls.Add(this.labelEmailCadastroCliente);
            this.Controls.Add(this.labelIdadeCadastroCliente);
            this.Controls.Add(this.labelNomeCadastroCliente);
            this.Name = "FormClientes";
            this.Text = "Clientes";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNomeCadastroCliente;
        private System.Windows.Forms.Label labelIdadeCadastroCliente;
        private System.Windows.Forms.Label labelEmailCadastroCliente;
        private System.Windows.Forms.TextBox textBoxNomeCliente;
        private System.Windows.Forms.TextBox textBoxEmailCliente;
        private System.Windows.Forms.Button buttonAdicionaCliente;
        private System.Windows.Forms.Button buttonLimpaCamposCliente;
        private System.Windows.Forms.TextBox textBoxIdadeCadastroCliente;
        private System.Windows.Forms.Label labelTelefoneCadastroCliente;
        private System.Windows.Forms.TextBox textBoxTelefoneCliente;
        private System.Windows.Forms.Label labelSexoCadastroCliente;
        private System.Windows.Forms.RadioButton radioButtonSexoFemininoCliente;
        private System.Windows.Forms.RadioButton radioButtonSexoMasculinoCliente;
        private System.Windows.Forms.Button buttonMostrarTodosClientes;
        private System.Windows.Forms.TextBox textBoxPesquisaNomeCliente;
        private System.Windows.Forms.Button buttonPesquisarCliente;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelTotalClientes;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}