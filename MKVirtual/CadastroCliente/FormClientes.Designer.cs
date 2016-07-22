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
            this.buttonMostrarTodosClientes = new System.Windows.Forms.Button();
            this.textBoxPesquisaNomeCliente = new System.Windows.Forms.TextBox();
            this.buttonPesquisarCliente = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewClientes = new System.Windows.Forms.DataGridView();
            this.labelTotalClientes = new System.Windows.Forms.Label();
            this.groupBoxNovoCliente = new System.Windows.Forms.GroupBox();
            this.textBoxEnderecoCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNomeConsultoraCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTelefoneCliente = new System.Windows.Forms.MaskedTextBox();
            this.radioButtonSexoMasculinoCliente = new System.Windows.Forms.RadioButton();
            this.radioButtonSexoFemininoCliente = new System.Windows.Forms.RadioButton();
            this.labelSexoCadastroCliente = new System.Windows.Forms.Label();
            this.labelTelefoneCadastroCliente = new System.Windows.Forms.Label();
            this.buttonLimpaCamposCliente = new System.Windows.Forms.Button();
            this.buttonAdicionaCliente = new System.Windows.Forms.Button();
            this.textBoxEmailCliente = new System.Windows.Forms.TextBox();
            this.textBoxNomeCliente = new System.Windows.Forms.TextBox();
            this.labelEmailCadastroCliente = new System.Windows.Forms.Label();
            this.labelIdadeCadastroCliente = new System.Windows.Forms.Label();
            this.labelNomeCadastroCliente = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonNovoCliente = new System.Windows.Forms.Button();
            this.buttonRemoverCliente = new System.Windows.Forms.Button();
            this.buttonAtualizarDados = new System.Windows.Forms.Button();
            this.dataNascimentoCliente = new System.Windows.Forms.DateTimePicker();
            this.labelLinhasSelecionadas = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).BeginInit();
            this.groupBoxNovoCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonMostrarTodosClientes
            // 
            this.buttonMostrarTodosClientes.Location = new System.Drawing.Point(38, 297);
            this.buttonMostrarTodosClientes.Name = "buttonMostrarTodosClientes";
            this.buttonMostrarTodosClientes.Size = new System.Drawing.Size(89, 23);
            this.buttonMostrarTodosClientes.TabIndex = 14;
            this.buttonMostrarTodosClientes.Text = "Mostrar Todos";
            this.buttonMostrarTodosClientes.UseVisualStyleBackColor = true;
            this.buttonMostrarTodosClientes.Click += new System.EventHandler(this.buttonMostrarTodosClientes_Click);
            // 
            // textBoxPesquisaNomeCliente
            // 
            this.textBoxPesquisaNomeCliente.Location = new System.Drawing.Point(38, 14);
            this.textBoxPesquisaNomeCliente.Name = "textBoxPesquisaNomeCliente";
            this.textBoxPesquisaNomeCliente.Size = new System.Drawing.Size(100, 20);
            this.textBoxPesquisaNomeCliente.TabIndex = 15;
            this.textBoxPesquisaNomeCliente.TextChanged += new System.EventHandler(this.textBoxPesquisaNomeCliente_TextChanged);
            // 
            // buttonPesquisarCliente
            // 
            this.buttonPesquisarCliente.Location = new System.Drawing.Point(144, 14);
            this.buttonPesquisarCliente.Name = "buttonPesquisarCliente";
            this.buttonPesquisarCliente.Size = new System.Drawing.Size(75, 23);
            this.buttonPesquisarCliente.TabIndex = 16;
            this.buttonPesquisarCliente.Text = "Pesquisar";
            this.buttonPesquisarCliente.UseVisualStyleBackColor = true;
            this.buttonPesquisarCliente.Click += new System.EventHandler(this.buttonPesquisarCliente_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridViewClientes);
            this.panel1.Location = new System.Drawing.Point(38, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(338, 188);
            this.panel1.TabIndex = 17;
            // 
            // dataGridViewClientes
            // 
            this.dataGridViewClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewClientes.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewClientes.Name = "dataGridViewClientes";
            this.dataGridViewClientes.Size = new System.Drawing.Size(338, 188);
            this.dataGridViewClientes.TabIndex = 0;
            this.dataGridViewClientes.Visible = false;
            this.dataGridViewClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewClientes_CellContentClick);
            this.dataGridViewClientes.Click += new System.EventHandler(this.dataGridViewClientes_Click);
            // 
            // labelTotalClientes
            // 
            this.labelTotalClientes.AutoSize = true;
            this.labelTotalClientes.Location = new System.Drawing.Point(35, 281);
            this.labelTotalClientes.Name = "labelTotalClientes";
            this.labelTotalClientes.Size = new System.Drawing.Size(83, 13);
            this.labelTotalClientes.TabIndex = 18;
            this.labelTotalClientes.Text = "Total Clientes: 0";
            // 
            // groupBoxNovoCliente
            // 
            this.groupBoxNovoCliente.Controls.Add(this.dataNascimentoCliente);
            this.groupBoxNovoCliente.Controls.Add(this.textBoxEnderecoCliente);
            this.groupBoxNovoCliente.Controls.Add(this.label2);
            this.groupBoxNovoCliente.Controls.Add(this.textBoxNomeConsultoraCliente);
            this.groupBoxNovoCliente.Controls.Add(this.label1);
            this.groupBoxNovoCliente.Controls.Add(this.textBoxTelefoneCliente);
            this.groupBoxNovoCliente.Controls.Add(this.radioButtonSexoMasculinoCliente);
            this.groupBoxNovoCliente.Controls.Add(this.radioButtonSexoFemininoCliente);
            this.groupBoxNovoCliente.Controls.Add(this.labelSexoCadastroCliente);
            this.groupBoxNovoCliente.Controls.Add(this.labelTelefoneCadastroCliente);
            this.groupBoxNovoCliente.Controls.Add(this.buttonLimpaCamposCliente);
            this.groupBoxNovoCliente.Controls.Add(this.buttonAdicionaCliente);
            this.groupBoxNovoCliente.Controls.Add(this.textBoxEmailCliente);
            this.groupBoxNovoCliente.Controls.Add(this.textBoxNomeCliente);
            this.groupBoxNovoCliente.Controls.Add(this.labelEmailCadastroCliente);
            this.groupBoxNovoCliente.Controls.Add(this.labelIdadeCadastroCliente);
            this.groupBoxNovoCliente.Controls.Add(this.labelNomeCadastroCliente);
            this.groupBoxNovoCliente.Location = new System.Drawing.Point(408, 63);
            this.groupBoxNovoCliente.Name = "groupBoxNovoCliente";
            this.groupBoxNovoCliente.Size = new System.Drawing.Size(303, 275);
            this.groupBoxNovoCliente.TabIndex = 27;
            this.groupBoxNovoCliente.TabStop = false;
            this.groupBoxNovoCliente.Text = "Detalhes do Cliente";
            this.groupBoxNovoCliente.Visible = false;
            // 
            // textBoxEnderecoCliente
            // 
            this.textBoxEnderecoCliente.Location = new System.Drawing.Point(131, 55);
            this.textBoxEnderecoCliente.Name = "textBoxEnderecoCliente";
            this.textBoxEnderecoCliente.Size = new System.Drawing.Size(141, 20);
            this.textBoxEnderecoCliente.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Endereço";
            // 
            // textBoxNomeConsultoraCliente
            // 
            this.textBoxNomeConsultoraCliente.Location = new System.Drawing.Point(132, 186);
            this.textBoxNomeConsultoraCliente.Name = "textBoxNomeConsultoraCliente";
            this.textBoxNomeConsultoraCliente.Size = new System.Drawing.Size(107, 20);
            this.textBoxNomeConsultoraCliente.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Nome Consultora";
            // 
            // textBoxTelefoneCliente
            // 
            this.textBoxTelefoneCliente.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.textBoxTelefoneCliente.Location = new System.Drawing.Point(131, 134);
            this.textBoxTelefoneCliente.Mask = "(999) 0000-0000";
            this.textBoxTelefoneCliente.Name = "textBoxTelefoneCliente";
            this.textBoxTelefoneCliente.Size = new System.Drawing.Size(100, 20);
            this.textBoxTelefoneCliente.TabIndex = 40;
            // 
            // radioButtonSexoMasculinoCliente
            // 
            this.radioButtonSexoMasculinoCliente.AutoSize = true;
            this.radioButtonSexoMasculinoCliente.Location = new System.Drawing.Point(205, 163);
            this.radioButtonSexoMasculinoCliente.Name = "radioButtonSexoMasculinoCliente";
            this.radioButtonSexoMasculinoCliente.Size = new System.Drawing.Size(73, 17);
            this.radioButtonSexoMasculinoCliente.TabIndex = 39;
            this.radioButtonSexoMasculinoCliente.TabStop = true;
            this.radioButtonSexoMasculinoCliente.Tag = "";
            this.radioButtonSexoMasculinoCliente.Text = "Masculino";
            this.radioButtonSexoMasculinoCliente.UseVisualStyleBackColor = true;
            // 
            // radioButtonSexoFemininoCliente
            // 
            this.radioButtonSexoFemininoCliente.AutoSize = true;
            this.radioButtonSexoFemininoCliente.Location = new System.Drawing.Point(132, 163);
            this.radioButtonSexoFemininoCliente.Name = "radioButtonSexoFemininoCliente";
            this.radioButtonSexoFemininoCliente.Size = new System.Drawing.Size(67, 17);
            this.radioButtonSexoFemininoCliente.TabIndex = 38;
            this.radioButtonSexoFemininoCliente.TabStop = true;
            this.radioButtonSexoFemininoCliente.Text = "Feminino";
            this.radioButtonSexoFemininoCliente.UseVisualStyleBackColor = true;
            // 
            // labelSexoCadastroCliente
            // 
            this.labelSexoCadastroCliente.AutoSize = true;
            this.labelSexoCadastroCliente.Location = new System.Drawing.Point(28, 165);
            this.labelSexoCadastroCliente.Name = "labelSexoCadastroCliente";
            this.labelSexoCadastroCliente.Size = new System.Drawing.Size(31, 13);
            this.labelSexoCadastroCliente.TabIndex = 37;
            this.labelSexoCadastroCliente.Text = "Sexo";
            // 
            // labelTelefoneCadastroCliente
            // 
            this.labelTelefoneCadastroCliente.AutoSize = true;
            this.labelTelefoneCadastroCliente.Location = new System.Drawing.Point(28, 141);
            this.labelTelefoneCadastroCliente.Name = "labelTelefoneCadastroCliente";
            this.labelTelefoneCadastroCliente.Size = new System.Drawing.Size(49, 13);
            this.labelTelefoneCadastroCliente.TabIndex = 35;
            this.labelTelefoneCadastroCliente.Text = "Telefone";
            // 
            // buttonLimpaCamposCliente
            // 
            this.buttonLimpaCamposCliente.Location = new System.Drawing.Point(153, 223);
            this.buttonLimpaCamposCliente.Name = "buttonLimpaCamposCliente";
            this.buttonLimpaCamposCliente.Size = new System.Drawing.Size(75, 23);
            this.buttonLimpaCamposCliente.TabIndex = 33;
            this.buttonLimpaCamposCliente.Text = "Limpar";
            this.buttonLimpaCamposCliente.UseVisualStyleBackColor = true;
            this.buttonLimpaCamposCliente.Click += new System.EventHandler(this.buttonLimpaCamposCliente_Click_2);
            // 
            // buttonAdicionaCliente
            // 
            this.buttonAdicionaCliente.Location = new System.Drawing.Point(39, 223);
            this.buttonAdicionaCliente.Name = "buttonAdicionaCliente";
            this.buttonAdicionaCliente.Size = new System.Drawing.Size(81, 23);
            this.buttonAdicionaCliente.TabIndex = 32;
            this.buttonAdicionaCliente.Text = "Cadastrar";
            this.buttonAdicionaCliente.UseVisualStyleBackColor = true;
            this.buttonAdicionaCliente.Click += new System.EventHandler(this.buttonAdicionaCliente_Click_2);
            // 
            // textBoxEmailCliente
            // 
            this.textBoxEmailCliente.Location = new System.Drawing.Point(131, 107);
            this.textBoxEmailCliente.Name = "textBoxEmailCliente";
            this.textBoxEmailCliente.Size = new System.Drawing.Size(141, 20);
            this.textBoxEmailCliente.TabIndex = 31;
            // 
            // textBoxNomeCliente
            // 
            this.textBoxNomeCliente.Location = new System.Drawing.Point(131, 28);
            this.textBoxNomeCliente.Name = "textBoxNomeCliente";
            this.textBoxNomeCliente.Size = new System.Drawing.Size(141, 20);
            this.textBoxNomeCliente.TabIndex = 30;
            // 
            // labelEmailCadastroCliente
            // 
            this.labelEmailCadastroCliente.AutoSize = true;
            this.labelEmailCadastroCliente.Location = new System.Drawing.Point(28, 114);
            this.labelEmailCadastroCliente.Name = "labelEmailCadastroCliente";
            this.labelEmailCadastroCliente.Size = new System.Drawing.Size(32, 13);
            this.labelEmailCadastroCliente.TabIndex = 29;
            this.labelEmailCadastroCliente.Text = "Email";
            // 
            // labelIdadeCadastroCliente
            // 
            this.labelIdadeCadastroCliente.AutoSize = true;
            this.labelIdadeCadastroCliente.Location = new System.Drawing.Point(28, 88);
            this.labelIdadeCadastroCliente.Name = "labelIdadeCadastroCliente";
            this.labelIdadeCadastroCliente.Size = new System.Drawing.Size(104, 13);
            this.labelIdadeCadastroCliente.TabIndex = 28;
            this.labelIdadeCadastroCliente.Text = "Data de Nascimento";
            // 
            // labelNomeCadastroCliente
            // 
            this.labelNomeCadastroCliente.AutoSize = true;
            this.labelNomeCadastroCliente.Location = new System.Drawing.Point(28, 35);
            this.labelNomeCadastroCliente.Name = "labelNomeCadastroCliente";
            this.labelNomeCadastroCliente.Size = new System.Drawing.Size(35, 13);
            this.labelNomeCadastroCliente.TabIndex = 27;
            this.labelNomeCadastroCliente.Text = "Nome";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(241, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 28;
            this.button1.Text = "Emails";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonNovoCliente
            // 
            this.buttonNovoCliente.Location = new System.Drawing.Point(337, 13);
            this.buttonNovoCliente.Name = "buttonNovoCliente";
            this.buttonNovoCliente.Size = new System.Drawing.Size(82, 24);
            this.buttonNovoCliente.TabIndex = 29;
            this.buttonNovoCliente.Text = "Novo Cliente";
            this.buttonNovoCliente.UseVisualStyleBackColor = true;
            this.buttonNovoCliente.Click += new System.EventHandler(this.buttonNovoCliente_Click);
            // 
            // buttonRemoverCliente
            // 
            this.buttonRemoverCliente.Location = new System.Drawing.Point(133, 297);
            this.buttonRemoverCliente.Name = "buttonRemoverCliente";
            this.buttonRemoverCliente.Size = new System.Drawing.Size(93, 23);
            this.buttonRemoverCliente.TabIndex = 30;
            this.buttonRemoverCliente.Text = "Remover Cliente";
            this.buttonRemoverCliente.UseVisualStyleBackColor = true;
            this.buttonRemoverCliente.Click += new System.EventHandler(this.buttonRemoverCliente_Click);
            // 
            // buttonAtualizarDados
            // 
            this.buttonAtualizarDados.Location = new System.Drawing.Point(232, 297);
            this.buttonAtualizarDados.Name = "buttonAtualizarDados";
            this.buttonAtualizarDados.Size = new System.Drawing.Size(89, 23);
            this.buttonAtualizarDados.TabIndex = 31;
            this.buttonAtualizarDados.Text = "Atualizar Dados";
            this.buttonAtualizarDados.UseVisualStyleBackColor = true;
            // 
            // dataNascimentoCliente
            // 
            this.dataNascimentoCliente.Location = new System.Drawing.Point(132, 80);
            this.dataNascimentoCliente.Name = "dataNascimentoCliente";
            this.dataNascimentoCliente.Size = new System.Drawing.Size(146, 20);
            this.dataNascimentoCliente.TabIndex = 45;
            // 
            // labelLinhasSelecionadas
            // 
            this.labelLinhasSelecionadas.AutoSize = true;
            this.labelLinhasSelecionadas.Location = new System.Drawing.Point(144, 280);
            this.labelLinhasSelecionadas.Name = "labelLinhasSelecionadas";
            this.labelLinhasSelecionadas.Size = new System.Drawing.Size(117, 13);
            this.labelLinhasSelecionadas.TabIndex = 32;
            this.labelLinhasSelecionadas.Text = "Linhas Selecionadas: 0";
            this.labelLinhasSelecionadas.Visible = false;
            // 
            // FormClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(754, 371);
            this.Controls.Add(this.labelLinhasSelecionadas);
            this.Controls.Add(this.buttonAtualizarDados);
            this.Controls.Add(this.buttonRemoverCliente);
            this.Controls.Add(this.buttonNovoCliente);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBoxNovoCliente);
            this.Controls.Add(this.labelTotalClientes);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonPesquisarCliente);
            this.Controls.Add(this.textBoxPesquisaNomeCliente);
            this.Controls.Add(this.buttonMostrarTodosClientes);
            this.Name = "FormClientes";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.FormClientes_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).EndInit();
            this.groupBoxNovoCliente.ResumeLayout(false);
            this.groupBoxNovoCliente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonMostrarTodosClientes;
        private System.Windows.Forms.TextBox textBoxPesquisaNomeCliente;
        private System.Windows.Forms.Button buttonPesquisarCliente;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelTotalClientes;
        private System.Windows.Forms.DataGridView dataGridViewClientes;
        private System.Windows.Forms.GroupBox groupBoxNovoCliente;
        private System.Windows.Forms.RadioButton radioButtonSexoMasculinoCliente;
        private System.Windows.Forms.RadioButton radioButtonSexoFemininoCliente;
        private System.Windows.Forms.Label labelSexoCadastroCliente;
        private System.Windows.Forms.Label labelTelefoneCadastroCliente;
        private System.Windows.Forms.Button buttonLimpaCamposCliente;
        private System.Windows.Forms.Button buttonAdicionaCliente;
        private System.Windows.Forms.TextBox textBoxEmailCliente;
        private System.Windows.Forms.TextBox textBoxNomeCliente;
        private System.Windows.Forms.Label labelEmailCadastroCliente;
        private System.Windows.Forms.Label labelIdadeCadastroCliente;
        private System.Windows.Forms.Label labelNomeCadastroCliente;
        private System.Windows.Forms.MaskedTextBox textBoxTelefoneCliente;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxNomeConsultoraCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxEnderecoCliente;
        private System.Windows.Forms.Button buttonNovoCliente;
        private System.Windows.Forms.Button buttonRemoverCliente;
        private System.Windows.Forms.Button buttonAtualizarDados;
        private System.Windows.Forms.DateTimePicker dataNascimentoCliente;
        private System.Windows.Forms.Label labelLinhasSelecionadas;
    }
}