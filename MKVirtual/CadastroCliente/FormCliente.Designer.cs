namespace CadastroCliente
{
    partial class FormCliente
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
            this.components = new System.ComponentModel.Container();
            this.btnMostrarTodosClientes = new System.Windows.Forms.Button();
            this.txtPesquisaNomeCliente = new System.Windows.Forms.TextBox();
            this.btnPesquisarCliente = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewClientes = new System.Windows.Forms.DataGridView();
            this.clienteCodigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteNomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteEnderecoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteNascimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteTelefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteSexoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteConsultoraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mKVIRTUALDataSet = new CadastroCliente.MKVIRTUALDataSet();
            this.labelTotalClientes = new System.Windows.Forms.Label();
            this.gpxCliente = new System.Windows.Forms.GroupBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.mskDataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.txtIDCliente = new System.Windows.Forms.TextBox();
            this.lblIDCliente = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.btnSalvarAlteracao = new System.Windows.Forms.Button();
            this.txtEnderecoCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtConsultora = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rdbtnSexoMasculinoCliente = new System.Windows.Forms.RadioButton();
            this.rdbtnSexoFemininoCliente = new System.Windows.Forms.RadioButton();
            this.labelSexoCadastroCliente = new System.Windows.Forms.Label();
            this.labelTelefoneCadastroCliente = new System.Windows.Forms.Label();
            this.btnLimpaCamposCliente = new System.Windows.Forms.Button();
            this.btnAdicionaCliente = new System.Windows.Forms.Button();
            this.txtEmailCliente = new System.Windows.Forms.TextBox();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.labelEmailCadastroCliente = new System.Windows.Forms.Label();
            this.labelIdadeCadastroCliente = new System.Windows.Forms.Label();
            this.labelNomeCadastroCliente = new System.Windows.Forms.Label();
            this.btnNovoCliente = new System.Windows.Forms.Button();
            this.btnRemoverCliente = new System.Windows.Forms.Button();
            this.labelLinhasSelecionadas = new System.Windows.Forms.Label();
            this.clientesTableAdapter = new CadastroCliente.MKVIRTUALDataSetTableAdapters.ClientesTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mKVIRTUALDataSet)).BeginInit();
            this.gpxCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMostrarTodosClientes
            // 
            this.btnMostrarTodosClientes.Location = new System.Drawing.Point(38, 297);
            this.btnMostrarTodosClientes.Name = "btnMostrarTodosClientes";
            this.btnMostrarTodosClientes.Size = new System.Drawing.Size(89, 23);
            this.btnMostrarTodosClientes.TabIndex = 14;
            this.btnMostrarTodosClientes.Text = "Mostrar Todos";
            this.btnMostrarTodosClientes.UseVisualStyleBackColor = true;
            this.btnMostrarTodosClientes.Click += new System.EventHandler(this.buttonMostrarTodosClientes_Click);
            // 
            // txtPesquisaNomeCliente
            // 
            this.txtPesquisaNomeCliente.Location = new System.Drawing.Point(27, 17);
            this.txtPesquisaNomeCliente.Name = "txtPesquisaNomeCliente";
            this.txtPesquisaNomeCliente.Size = new System.Drawing.Size(100, 20);
            this.txtPesquisaNomeCliente.TabIndex = 34;
            this.txtPesquisaNomeCliente.TextChanged += new System.EventHandler(this.textBoxPesquisaNomeCliente_TextChanged);
            // 
            // btnPesquisarCliente
            // 
            this.btnPesquisarCliente.Location = new System.Drawing.Point(147, 17);
            this.btnPesquisarCliente.Name = "btnPesquisarCliente";
            this.btnPesquisarCliente.Size = new System.Drawing.Size(75, 20);
            this.btnPesquisarCliente.TabIndex = 16;
            this.btnPesquisarCliente.Text = "Pesquisar";
            this.btnPesquisarCliente.UseVisualStyleBackColor = true;
            this.btnPesquisarCliente.Click += new System.EventHandler(this.buttonPesquisarCliente_Click);
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
            this.dataGridViewClientes.AllowUserToOrderColumns = true;
            this.dataGridViewClientes.AutoGenerateColumns = false;
            this.dataGridViewClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clienteCodigoDataGridViewTextBoxColumn,
            this.clienteNomeDataGridViewTextBoxColumn,
            this.clienteEnderecoDataGridViewTextBoxColumn,
            this.clienteNascimentoDataGridViewTextBoxColumn,
            this.clienteEmailDataGridViewTextBoxColumn,
            this.clienteTelefoneDataGridViewTextBoxColumn,
            this.clienteSexoDataGridViewTextBoxColumn,
            this.clienteConsultoraDataGridViewTextBoxColumn});
            this.dataGridViewClientes.DataSource = this.clientesBindingSource1;
            this.dataGridViewClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewClientes.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewClientes.Name = "dataGridViewClientes";
            this.dataGridViewClientes.Size = new System.Drawing.Size(338, 188);
            this.dataGridViewClientes.TabIndex = 0;
            this.dataGridViewClientes.Visible = false;
            this.dataGridViewClientes.Click += new System.EventHandler(this.dataGridViewClientes_Click);
            // 
            // clienteCodigoDataGridViewTextBoxColumn
            // 
            this.clienteCodigoDataGridViewTextBoxColumn.DataPropertyName = "ClienteCodigo";
            this.clienteCodigoDataGridViewTextBoxColumn.HeaderText = "Codigo";
            this.clienteCodigoDataGridViewTextBoxColumn.Name = "clienteCodigoDataGridViewTextBoxColumn";
            this.clienteCodigoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clienteNomeDataGridViewTextBoxColumn
            // 
            this.clienteNomeDataGridViewTextBoxColumn.DataPropertyName = "ClienteNome";
            this.clienteNomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.clienteNomeDataGridViewTextBoxColumn.Name = "clienteNomeDataGridViewTextBoxColumn";
            // 
            // clienteEnderecoDataGridViewTextBoxColumn
            // 
            this.clienteEnderecoDataGridViewTextBoxColumn.DataPropertyName = "ClienteEndereco";
            this.clienteEnderecoDataGridViewTextBoxColumn.HeaderText = "Endereço";
            this.clienteEnderecoDataGridViewTextBoxColumn.Name = "clienteEnderecoDataGridViewTextBoxColumn";
            // 
            // clienteNascimentoDataGridViewTextBoxColumn
            // 
            this.clienteNascimentoDataGridViewTextBoxColumn.DataPropertyName = "ClienteNascimento";
            this.clienteNascimentoDataGridViewTextBoxColumn.HeaderText = "Data de Nascimento";
            this.clienteNascimentoDataGridViewTextBoxColumn.Name = "clienteNascimentoDataGridViewTextBoxColumn";
            // 
            // clienteEmailDataGridViewTextBoxColumn
            // 
            this.clienteEmailDataGridViewTextBoxColumn.DataPropertyName = "ClienteEmail";
            this.clienteEmailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.clienteEmailDataGridViewTextBoxColumn.Name = "clienteEmailDataGridViewTextBoxColumn";
            // 
            // clienteTelefoneDataGridViewTextBoxColumn
            // 
            this.clienteTelefoneDataGridViewTextBoxColumn.DataPropertyName = "ClienteTelefone";
            this.clienteTelefoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.clienteTelefoneDataGridViewTextBoxColumn.Name = "clienteTelefoneDataGridViewTextBoxColumn";
            // 
            // clienteSexoDataGridViewTextBoxColumn
            // 
            this.clienteSexoDataGridViewTextBoxColumn.DataPropertyName = "ClienteSexo";
            this.clienteSexoDataGridViewTextBoxColumn.HeaderText = "Sexo";
            this.clienteSexoDataGridViewTextBoxColumn.Name = "clienteSexoDataGridViewTextBoxColumn";
            // 
            // clienteConsultoraDataGridViewTextBoxColumn
            // 
            this.clienteConsultoraDataGridViewTextBoxColumn.DataPropertyName = "ClienteConsultora";
            this.clienteConsultoraDataGridViewTextBoxColumn.HeaderText = "Consultora";
            this.clienteConsultoraDataGridViewTextBoxColumn.Name = "clienteConsultoraDataGridViewTextBoxColumn";
            // 
            // clientesBindingSource1
            // 
            this.clientesBindingSource1.DataMember = "Clientes";
            this.clientesBindingSource1.DataSource = this.bindingSource1;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.mKVIRTUALDataSet;
            this.bindingSource1.Position = 0;
            // 
            // mKVIRTUALDataSet
            // 
            this.mKVIRTUALDataSet.DataSetName = "MKVIRTUALDataSet";
            this.mKVIRTUALDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // gpxCliente
            // 
            this.gpxCliente.Controls.Add(this.txtTelefone);
            this.gpxCliente.Controls.Add(this.mskDataNascimento);
            this.gpxCliente.Controls.Add(this.txtIDCliente);
            this.gpxCliente.Controls.Add(this.lblIDCliente);
            this.gpxCliente.Controls.Add(this.lbID);
            this.gpxCliente.Controls.Add(this.btnSalvarAlteracao);
            this.gpxCliente.Controls.Add(this.txtEnderecoCliente);
            this.gpxCliente.Controls.Add(this.label2);
            this.gpxCliente.Controls.Add(this.txtConsultora);
            this.gpxCliente.Controls.Add(this.label1);
            this.gpxCliente.Controls.Add(this.rdbtnSexoMasculinoCliente);
            this.gpxCliente.Controls.Add(this.rdbtnSexoFemininoCliente);
            this.gpxCliente.Controls.Add(this.labelSexoCadastroCliente);
            this.gpxCliente.Controls.Add(this.labelTelefoneCadastroCliente);
            this.gpxCliente.Controls.Add(this.btnLimpaCamposCliente);
            this.gpxCliente.Controls.Add(this.btnAdicionaCliente);
            this.gpxCliente.Controls.Add(this.txtEmailCliente);
            this.gpxCliente.Controls.Add(this.txtNomeCliente);
            this.gpxCliente.Controls.Add(this.labelEmailCadastroCliente);
            this.gpxCliente.Controls.Add(this.labelIdadeCadastroCliente);
            this.gpxCliente.Controls.Add(this.labelNomeCadastroCliente);
            this.gpxCliente.Enabled = false;
            this.gpxCliente.Location = new System.Drawing.Point(408, 63);
            this.gpxCliente.Name = "gpxCliente";
            this.gpxCliente.Size = new System.Drawing.Size(303, 275);
            this.gpxCliente.TabIndex = 27;
            this.gpxCliente.TabStop = false;
            this.gpxCliente.Text = "Detalhes do Cliente";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(132, 146);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(140, 20);
            this.txtTelefone.TabIndex = 51;
            // 
            // mskDataNascimento
            // 
            this.mskDataNascimento.Location = new System.Drawing.Point(132, 91);
            this.mskDataNascimento.Mask = "00/00/0000";
            this.mskDataNascimento.Name = "mskDataNascimento";
            this.mskDataNascimento.Size = new System.Drawing.Size(67, 20);
            this.mskDataNascimento.TabIndex = 50;
            this.mskDataNascimento.ValidatingType = typeof(System.DateTime);
            // 
            // txtIDCliente
            // 
            this.txtIDCliente.Enabled = false;
            this.txtIDCliente.Location = new System.Drawing.Point(52, 18);
            this.txtIDCliente.Name = "txtIDCliente";
            this.txtIDCliente.Size = new System.Drawing.Size(28, 20);
            this.txtIDCliente.TabIndex = 49;
            // 
            // lblIDCliente
            // 
            this.lblIDCliente.AutoSize = true;
            this.lblIDCliente.Location = new System.Drawing.Point(29, 22);
            this.lblIDCliente.Name = "lblIDCliente";
            this.lblIDCliente.Size = new System.Drawing.Size(18, 13);
            this.lblIDCliente.TabIndex = 48;
            this.lblIDCliente.Text = "ID";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(29, 18);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(0, 13);
            this.lbID.TabIndex = 47;
            // 
            // btnSalvarAlteracao
            // 
            this.btnSalvarAlteracao.Location = new System.Drawing.Point(39, 233);
            this.btnSalvarAlteracao.Name = "btnSalvarAlteracao";
            this.btnSalvarAlteracao.Size = new System.Drawing.Size(81, 23);
            this.btnSalvarAlteracao.TabIndex = 46;
            this.btnSalvarAlteracao.Text = "Salvar";
            this.btnSalvarAlteracao.UseVisualStyleBackColor = true;
            this.btnSalvarAlteracao.Visible = false;
            this.btnSalvarAlteracao.Click += new System.EventHandler(this.buttonSalvarAlteracao_Click);
            // 
            // txtEnderecoCliente
            // 
            this.txtEnderecoCliente.Location = new System.Drawing.Point(131, 64);
            this.txtEnderecoCliente.Name = "txtEnderecoCliente";
            this.txtEnderecoCliente.Size = new System.Drawing.Size(141, 20);
            this.txtEnderecoCliente.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Endereço";
            // 
            // txtConsultora
            // 
            this.txtConsultora.Location = new System.Drawing.Point(132, 195);
            this.txtConsultora.Name = "txtConsultora";
            this.txtConsultora.Size = new System.Drawing.Size(107, 20);
            this.txtConsultora.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Nome Consultora";
            // 
            // rdbtnSexoMasculinoCliente
            // 
            this.rdbtnSexoMasculinoCliente.AutoSize = true;
            this.rdbtnSexoMasculinoCliente.Location = new System.Drawing.Point(205, 172);
            this.rdbtnSexoMasculinoCliente.Name = "rdbtnSexoMasculinoCliente";
            this.rdbtnSexoMasculinoCliente.Size = new System.Drawing.Size(73, 17);
            this.rdbtnSexoMasculinoCliente.TabIndex = 39;
            this.rdbtnSexoMasculinoCliente.TabStop = true;
            this.rdbtnSexoMasculinoCliente.Tag = "";
            this.rdbtnSexoMasculinoCliente.Text = "Masculino";
            this.rdbtnSexoMasculinoCliente.UseVisualStyleBackColor = true;
            // 
            // rdbtnSexoFemininoCliente
            // 
            this.rdbtnSexoFemininoCliente.AutoSize = true;
            this.rdbtnSexoFemininoCliente.Location = new System.Drawing.Point(132, 172);
            this.rdbtnSexoFemininoCliente.Name = "rdbtnSexoFemininoCliente";
            this.rdbtnSexoFemininoCliente.Size = new System.Drawing.Size(67, 17);
            this.rdbtnSexoFemininoCliente.TabIndex = 38;
            this.rdbtnSexoFemininoCliente.TabStop = true;
            this.rdbtnSexoFemininoCliente.Text = "Feminino";
            this.rdbtnSexoFemininoCliente.UseVisualStyleBackColor = true;
            // 
            // labelSexoCadastroCliente
            // 
            this.labelSexoCadastroCliente.AutoSize = true;
            this.labelSexoCadastroCliente.Location = new System.Drawing.Point(28, 174);
            this.labelSexoCadastroCliente.Name = "labelSexoCadastroCliente";
            this.labelSexoCadastroCliente.Size = new System.Drawing.Size(31, 13);
            this.labelSexoCadastroCliente.TabIndex = 37;
            this.labelSexoCadastroCliente.Text = "Sexo";
            // 
            // labelTelefoneCadastroCliente
            // 
            this.labelTelefoneCadastroCliente.AutoSize = true;
            this.labelTelefoneCadastroCliente.Location = new System.Drawing.Point(28, 150);
            this.labelTelefoneCadastroCliente.Name = "labelTelefoneCadastroCliente";
            this.labelTelefoneCadastroCliente.Size = new System.Drawing.Size(49, 13);
            this.labelTelefoneCadastroCliente.TabIndex = 35;
            this.labelTelefoneCadastroCliente.Text = "Telefone";
            // 
            // btnLimpaCamposCliente
            // 
            this.btnLimpaCamposCliente.Location = new System.Drawing.Point(153, 232);
            this.btnLimpaCamposCliente.Name = "btnLimpaCamposCliente";
            this.btnLimpaCamposCliente.Size = new System.Drawing.Size(75, 23);
            this.btnLimpaCamposCliente.TabIndex = 33;
            this.btnLimpaCamposCliente.Text = "Limpar";
            this.btnLimpaCamposCliente.UseVisualStyleBackColor = true;
            this.btnLimpaCamposCliente.Click += new System.EventHandler(this.buttonLimpaCamposCliente_Click_2);
            // 
            // btnAdicionaCliente
            // 
            this.btnAdicionaCliente.Location = new System.Drawing.Point(39, 232);
            this.btnAdicionaCliente.Name = "btnAdicionaCliente";
            this.btnAdicionaCliente.Size = new System.Drawing.Size(81, 23);
            this.btnAdicionaCliente.TabIndex = 32;
            this.btnAdicionaCliente.Text = "Cadastrar";
            this.btnAdicionaCliente.UseVisualStyleBackColor = true;
            this.btnAdicionaCliente.Click += new System.EventHandler(this.buttonAdicionaCliente_Click_2);
            // 
            // txtEmailCliente
            // 
            this.txtEmailCliente.Location = new System.Drawing.Point(131, 116);
            this.txtEmailCliente.Name = "txtEmailCliente";
            this.txtEmailCliente.Size = new System.Drawing.Size(141, 20);
            this.txtEmailCliente.TabIndex = 31;
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Location = new System.Drawing.Point(131, 38);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(141, 20);
            this.txtNomeCliente.TabIndex = 30;
            // 
            // labelEmailCadastroCliente
            // 
            this.labelEmailCadastroCliente.AutoSize = true;
            this.labelEmailCadastroCliente.Location = new System.Drawing.Point(28, 123);
            this.labelEmailCadastroCliente.Name = "labelEmailCadastroCliente";
            this.labelEmailCadastroCliente.Size = new System.Drawing.Size(32, 13);
            this.labelEmailCadastroCliente.TabIndex = 29;
            this.labelEmailCadastroCliente.Text = "Email";
            // 
            // labelIdadeCadastroCliente
            // 
            this.labelIdadeCadastroCliente.AutoSize = true;
            this.labelIdadeCadastroCliente.Location = new System.Drawing.Point(28, 95);
            this.labelIdadeCadastroCliente.Name = "labelIdadeCadastroCliente";
            this.labelIdadeCadastroCliente.Size = new System.Drawing.Size(104, 13);
            this.labelIdadeCadastroCliente.TabIndex = 28;
            this.labelIdadeCadastroCliente.Text = "Data de Nascimento";
            // 
            // labelNomeCadastroCliente
            // 
            this.labelNomeCadastroCliente.AutoSize = true;
            this.labelNomeCadastroCliente.Location = new System.Drawing.Point(28, 44);
            this.labelNomeCadastroCliente.Name = "labelNomeCadastroCliente";
            this.labelNomeCadastroCliente.Size = new System.Drawing.Size(35, 13);
            this.labelNomeCadastroCliente.TabIndex = 27;
            this.labelNomeCadastroCliente.Text = "Nome";
            // 
            // btnNovoCliente
            // 
            this.btnNovoCliente.Location = new System.Drawing.Point(337, 13);
            this.btnNovoCliente.Name = "btnNovoCliente";
            this.btnNovoCliente.Size = new System.Drawing.Size(82, 24);
            this.btnNovoCliente.TabIndex = 29;
            this.btnNovoCliente.Text = "Novo Cliente";
            this.btnNovoCliente.UseVisualStyleBackColor = true;
            this.btnNovoCliente.Click += new System.EventHandler(this.buttonNovoCliente_Click);
            // 
            // btnRemoverCliente
            // 
            this.btnRemoverCliente.Location = new System.Drawing.Point(133, 297);
            this.btnRemoverCliente.Name = "btnRemoverCliente";
            this.btnRemoverCliente.Size = new System.Drawing.Size(93, 23);
            this.btnRemoverCliente.TabIndex = 30;
            this.btnRemoverCliente.Text = "Remover Cliente";
            this.btnRemoverCliente.UseVisualStyleBackColor = true;
            this.btnRemoverCliente.Visible = false;
            this.btnRemoverCliente.Click += new System.EventHandler(this.buttonRemoverCliente_Click);
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
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // FormCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(754, 371);
            this.Controls.Add(this.labelLinhasSelecionadas);
            this.Controls.Add(this.btnRemoverCliente);
            this.Controls.Add(this.btnNovoCliente);
            this.Controls.Add(this.gpxCliente);
            this.Controls.Add(this.labelTotalClientes);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnPesquisarCliente);
            this.Controls.Add(this.txtPesquisaNomeCliente);
            this.Controls.Add(this.btnMostrarTodosClientes);
            this.Name = "FormCliente";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.FormClientes_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mKVIRTUALDataSet)).EndInit();
            this.gpxCliente.ResumeLayout(false);
            this.gpxCliente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMostrarTodosClientes;
        private System.Windows.Forms.TextBox txtPesquisaNomeCliente;
        private System.Windows.Forms.Button btnPesquisarCliente;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelTotalClientes;
        private System.Windows.Forms.DataGridView dataGridViewClientes;
        private System.Windows.Forms.GroupBox gpxCliente;
        private System.Windows.Forms.RadioButton rdbtnSexoMasculinoCliente;
        private System.Windows.Forms.RadioButton rdbtnSexoFemininoCliente;
        private System.Windows.Forms.Label labelSexoCadastroCliente;
        private System.Windows.Forms.Label labelTelefoneCadastroCliente;
        private System.Windows.Forms.Button btnLimpaCamposCliente;
        private System.Windows.Forms.Button btnAdicionaCliente;
        private System.Windows.Forms.TextBox txtEmailCliente;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.Label labelEmailCadastroCliente;
        private System.Windows.Forms.Label labelIdadeCadastroCliente;
        private System.Windows.Forms.Label labelNomeCadastroCliente;
        private System.Windows.Forms.TextBox txtConsultora;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEnderecoCliente;
        private System.Windows.Forms.Button btnNovoCliente;
        private System.Windows.Forms.Button btnRemoverCliente;
        private System.Windows.Forms.Label labelLinhasSelecionadas;
        private System.Windows.Forms.Button btnSalvarAlteracao;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lblIDCliente;
        private System.Windows.Forms.TextBox txtIDCliente;
        
        private System.Windows.Forms.MaskedTextBox mskDataNascimento;
        private System.Windows.Forms.TextBox txtTelefone;
        private MKVIRTUALDataSet mKVIRTUALDataSet;
        private MKVIRTUALDataSetTableAdapters.ClientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.BindingSource clientesBindingSource1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienteCodigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienteNomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienteEnderecoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienteNascimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienteEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienteTelefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienteSexoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienteConsultoraDataGridViewTextBoxColumn;
    }
}