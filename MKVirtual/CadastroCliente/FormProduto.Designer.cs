namespace CadastroCliente
{
    partial class FormProduto
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
            this.gbxProduto = new System.Windows.Forms.GroupBox();
            this.txtIDProduto = new System.Windows.Forms.TextBox();
            this.lblIdProduto = new System.Windows.Forms.Label();
            this.btnSalvarProduto = new System.Windows.Forms.Button();
            this.cbxLinhaProduto = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrecoProduto = new System.Windows.Forms.TextBox();
            this.btnLimpaFormularioProduto = new System.Windows.Forms.Button();
            this.btnRegistraProduto = new System.Windows.Forms.Button();
            this.cbxTipoProduto = new System.Windows.Forms.ComboBox();
            this.txtBoxNomeProduto = new System.Windows.Forms.TextBox();
            this.labelPrecoCadastroProduto = new System.Windows.Forms.Label();
            this.labelTipoCadastroProduto = new System.Windows.Forms.Label();
            this.labelNomeCadastroProduto = new System.Windows.Forms.Label();
            this.btnNovoProduto = new System.Windows.Forms.Button();
            this.btnRemoverProduto = new System.Windows.Forms.Button();
            this.btnExibirTodos = new System.Windows.Forms.Button();
            this.lblTotalProdutos = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtGridProdutos = new System.Windows.Forms.DataGridView();
            this.lblLinhasSelecionadas = new System.Windows.Forms.Label();
            this.gbxProduto.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxProduto
            // 
            this.gbxProduto.Controls.Add(this.txtIDProduto);
            this.gbxProduto.Controls.Add(this.lblIdProduto);
            this.gbxProduto.Controls.Add(this.btnSalvarProduto);
            this.gbxProduto.Controls.Add(this.cbxLinhaProduto);
            this.gbxProduto.Controls.Add(this.label1);
            this.gbxProduto.Controls.Add(this.txtPrecoProduto);
            this.gbxProduto.Controls.Add(this.btnLimpaFormularioProduto);
            this.gbxProduto.Controls.Add(this.btnRegistraProduto);
            this.gbxProduto.Controls.Add(this.cbxTipoProduto);
            this.gbxProduto.Controls.Add(this.txtBoxNomeProduto);
            this.gbxProduto.Controls.Add(this.labelPrecoCadastroProduto);
            this.gbxProduto.Controls.Add(this.labelTipoCadastroProduto);
            this.gbxProduto.Controls.Add(this.labelNomeCadastroProduto);
            this.gbxProduto.Enabled = false;
            this.gbxProduto.Location = new System.Drawing.Point(12, 36);
            this.gbxProduto.Name = "gbxProduto";
            this.gbxProduto.Size = new System.Drawing.Size(246, 218);
            this.gbxProduto.TabIndex = 9;
            this.gbxProduto.TabStop = false;
            this.gbxProduto.Text = "Detalhes do Produto";
            // 
            // txtIDProduto
            // 
            this.txtIDProduto.Enabled = false;
            this.txtIDProduto.Location = new System.Drawing.Point(112, 25);
            this.txtIDProduto.Name = "txtIDProduto";
            this.txtIDProduto.Size = new System.Drawing.Size(46, 20);
            this.txtIDProduto.TabIndex = 20;
            // 
            // lblIdProduto
            // 
            this.lblIdProduto.AutoSize = true;
            this.lblIdProduto.Location = new System.Drawing.Point(17, 33);
            this.lblIdProduto.Name = "lblIdProduto";
            this.lblIdProduto.Size = new System.Drawing.Size(16, 13);
            this.lblIdProduto.TabIndex = 19;
            this.lblIdProduto.Text = "Id";
            // 
            // btnSalvarProduto
            // 
            this.btnSalvarProduto.Location = new System.Drawing.Point(30, 171);
            this.btnSalvarProduto.Name = "btnSalvarProduto";
            this.btnSalvarProduto.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarProduto.TabIndex = 12;
            this.btnSalvarProduto.Text = "Salvar";
            this.btnSalvarProduto.UseVisualStyleBackColor = true;
            this.btnSalvarProduto.Visible = false;
            this.btnSalvarProduto.Click += new System.EventHandler(this.btnSalvarProduto_Click);
            // 
            // cbxLinhaProduto
            // 
            this.cbxLinhaProduto.FormattingEnabled = true;
            this.cbxLinhaProduto.Items.AddRange(new object[] {
            "Feminino",
            "Masculino"});
            this.cbxLinhaProduto.Location = new System.Drawing.Point(112, 133);
            this.cbxLinhaProduto.Name = "cbxLinhaProduto";
            this.cbxLinhaProduto.Size = new System.Drawing.Size(100, 21);
            this.cbxLinhaProduto.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Linha Produto";
            // 
            // txtPrecoProduto
            // 
            this.txtPrecoProduto.Location = new System.Drawing.Point(112, 107);
            this.txtPrecoProduto.Name = "txtPrecoProduto";
            this.txtPrecoProduto.Size = new System.Drawing.Size(100, 20);
            this.txtPrecoProduto.TabIndex = 16;
            // 
            // btnLimpaFormularioProduto
            // 
            this.btnLimpaFormularioProduto.Location = new System.Drawing.Point(137, 171);
            this.btnLimpaFormularioProduto.Name = "btnLimpaFormularioProduto";
            this.btnLimpaFormularioProduto.Size = new System.Drawing.Size(75, 23);
            this.btnLimpaFormularioProduto.TabIndex = 15;
            this.btnLimpaFormularioProduto.Text = "Limpar";
            this.btnLimpaFormularioProduto.UseVisualStyleBackColor = true;
            this.btnLimpaFormularioProduto.Click += new System.EventHandler(this.buttonLimpaFormularioProduto_Click);
            // 
            // btnRegistraProduto
            // 
            this.btnRegistraProduto.Location = new System.Drawing.Point(30, 171);
            this.btnRegistraProduto.Name = "btnRegistraProduto";
            this.btnRegistraProduto.Size = new System.Drawing.Size(75, 23);
            this.btnRegistraProduto.TabIndex = 14;
            this.btnRegistraProduto.Text = "Registrar";
            this.btnRegistraProduto.UseVisualStyleBackColor = true;
            this.btnRegistraProduto.Click += new System.EventHandler(this.buttonRegistraProduto_Click);
            // 
            // cbxTipoProduto
            // 
            this.cbxTipoProduto.FormattingEnabled = true;
            this.cbxTipoProduto.Items.AddRange(new object[] {
            "Maquiagem",
            "Perfume",
            "Creme"});
            this.cbxTipoProduto.Location = new System.Drawing.Point(112, 80);
            this.cbxTipoProduto.Name = "cbxTipoProduto";
            this.cbxTipoProduto.Size = new System.Drawing.Size(100, 21);
            this.cbxTipoProduto.TabIndex = 13;
            // 
            // txtBoxNomeProduto
            // 
            this.txtBoxNomeProduto.Location = new System.Drawing.Point(112, 54);
            this.txtBoxNomeProduto.Name = "txtBoxNomeProduto";
            this.txtBoxNomeProduto.Size = new System.Drawing.Size(100, 20);
            this.txtBoxNomeProduto.TabIndex = 12;
            // 
            // labelPrecoCadastroProduto
            // 
            this.labelPrecoCadastroProduto.AutoSize = true;
            this.labelPrecoCadastroProduto.Location = new System.Drawing.Point(14, 114);
            this.labelPrecoCadastroProduto.Name = "labelPrecoCadastroProduto";
            this.labelPrecoCadastroProduto.Size = new System.Drawing.Size(35, 13);
            this.labelPrecoCadastroProduto.TabIndex = 11;
            this.labelPrecoCadastroProduto.Text = "Preço";
            // 
            // labelTipoCadastroProduto
            // 
            this.labelTipoCadastroProduto.AutoSize = true;
            this.labelTipoCadastroProduto.Location = new System.Drawing.Point(14, 88);
            this.labelTipoCadastroProduto.Name = "labelTipoCadastroProduto";
            this.labelTipoCadastroProduto.Size = new System.Drawing.Size(82, 13);
            this.labelTipoCadastroProduto.TabIndex = 10;
            this.labelTipoCadastroProduto.Text = "Tipo de produto";
            // 
            // labelNomeCadastroProduto
            // 
            this.labelNomeCadastroProduto.AutoSize = true;
            this.labelNomeCadastroProduto.Location = new System.Drawing.Point(14, 61);
            this.labelNomeCadastroProduto.Name = "labelNomeCadastroProduto";
            this.labelNomeCadastroProduto.Size = new System.Drawing.Size(90, 13);
            this.labelNomeCadastroProduto.TabIndex = 9;
            this.labelNomeCadastroProduto.Text = "Nome do Produto";
            // 
            // btnNovoProduto
            // 
            this.btnNovoProduto.Location = new System.Drawing.Point(264, 44);
            this.btnNovoProduto.Name = "btnNovoProduto";
            this.btnNovoProduto.Size = new System.Drawing.Size(84, 23);
            this.btnNovoProduto.TabIndex = 10;
            this.btnNovoProduto.Text = "Novo Produto";
            this.btnNovoProduto.UseVisualStyleBackColor = true;
            this.btnNovoProduto.Click += new System.EventHandler(this.btnNovoProduto_Click);
            // 
            // btnRemoverProduto
            // 
            this.btnRemoverProduto.Location = new System.Drawing.Point(264, 73);
            this.btnRemoverProduto.Name = "btnRemoverProduto";
            this.btnRemoverProduto.Size = new System.Drawing.Size(84, 23);
            this.btnRemoverProduto.TabIndex = 11;
            this.btnRemoverProduto.Text = "Remover";
            this.btnRemoverProduto.UseVisualStyleBackColor = true;
            this.btnRemoverProduto.Visible = false;
            this.btnRemoverProduto.Click += new System.EventHandler(this.btnRemoverProduto_Click);
            // 
            // btnExibirTodos
            // 
            this.btnExibirTodos.Location = new System.Drawing.Point(264, 102);
            this.btnExibirTodos.Name = "btnExibirTodos";
            this.btnExibirTodos.Size = new System.Drawing.Size(84, 23);
            this.btnExibirTodos.TabIndex = 13;
            this.btnExibirTodos.Text = "Exibir todos";
            this.btnExibirTodos.UseVisualStyleBackColor = true;
            this.btnExibirTodos.Click += new System.EventHandler(this.btnExibirTodos_Click);
            // 
            // lblTotalProdutos
            // 
            this.lblTotalProdutos.AutoSize = true;
            this.lblTotalProdutos.Location = new System.Drawing.Point(305, 241);
            this.lblTotalProdutos.Name = "lblTotalProdutos";
            this.lblTotalProdutos.Size = new System.Drawing.Size(43, 13);
            this.lblTotalProdutos.TabIndex = 14;
            this.lblTotalProdutos.Text = "Total: 0";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtGridProdutos);
            this.panel1.Location = new System.Drawing.Point(355, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(397, 218);
            this.panel1.TabIndex = 15;
            // 
            // dtGridProdutos
            // 
            this.dtGridProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridProdutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtGridProdutos.Location = new System.Drawing.Point(0, 0);
            this.dtGridProdutos.Name = "dtGridProdutos";
            this.dtGridProdutos.Size = new System.Drawing.Size(397, 218);
            this.dtGridProdutos.TabIndex = 0;
            this.dtGridProdutos.Click += new System.EventHandler(this.dtGridProdutos_Click);
            // 
            // lblLinhasSelecionadas
            // 
            this.lblLinhasSelecionadas.AutoSize = true;
            this.lblLinhasSelecionadas.Location = new System.Drawing.Point(352, 257);
            this.lblLinhasSelecionadas.Name = "lblLinhasSelecionadas";
            this.lblLinhasSelecionadas.Size = new System.Drawing.Size(130, 13);
            this.lblLinhasSelecionadas.TabIndex = 16;
            this.lblLinhasSelecionadas.Text = "Linha(s) selecionada(s) : 0";
            this.lblLinhasSelecionadas.Visible = false;
            // 
            // FormProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 279);
            this.Controls.Add(this.lblLinhasSelecionadas);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTotalProdutos);
            this.Controls.Add(this.btnExibirTodos);
            this.Controls.Add(this.btnRemoverProduto);
            this.Controls.Add(this.btnNovoProduto);
            this.Controls.Add(this.gbxProduto);
            this.Name = "FormProdutos";
            this.Text = "Produtos";
            this.Load += new System.EventHandler(this.FormProdutos_Load);
            this.gbxProduto.ResumeLayout(false);
            this.gbxProduto.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxProduto;
        private System.Windows.Forms.Button btnLimpaFormularioProduto;
        private System.Windows.Forms.Button btnRegistraProduto;
        private System.Windows.Forms.ComboBox cbxTipoProduto;
        private System.Windows.Forms.TextBox txtBoxNomeProduto;
        private System.Windows.Forms.Label labelPrecoCadastroProduto;
        private System.Windows.Forms.Label labelTipoCadastroProduto;
        private System.Windows.Forms.Label labelNomeCadastroProduto;
        private System.Windows.Forms.TextBox txtPrecoProduto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNovoProduto;
        private System.Windows.Forms.Button btnRemoverProduto;
        private System.Windows.Forms.Button btnSalvarProduto;
        private System.Windows.Forms.Button btnExibirTodos;
        private System.Windows.Forms.Label lblTotalProdutos;
        private System.Windows.Forms.ComboBox cbxLinhaProduto;
        private System.Windows.Forms.Label lblIdProduto;
        private System.Windows.Forms.TextBox txtIDProduto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtGridProdutos;
        private System.Windows.Forms.Label lblLinhasSelecionadas;

    }
}