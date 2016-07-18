namespace CadastroCliente
{
    partial class FormProdutos
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboTipoProduto = new System.Windows.Forms.ComboBox();
            this.textBoxNomeCadastroProduto = new System.Windows.Forms.TextBox();
            this.labelPrecoCadastroProduto = new System.Windows.Forms.Label();
            this.labelTipoCadastroProduto = new System.Windows.Forms.Label();
            this.labelNomeCadastroProduto = new System.Windows.Forms.Label();
            this.textBoxPrecoCadastroProduto = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxPrecoCadastroProduto);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.comboTipoProduto);
            this.groupBox1.Controls.Add(this.textBoxNomeCadastroProduto);
            this.groupBox1.Controls.Add(this.labelPrecoCadastroProduto);
            this.groupBox1.Controls.Add(this.labelTipoCadastroProduto);
            this.groupBox1.Controls.Add(this.labelNomeCadastroProduto);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 197);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalhes do Produto";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(112, 147);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Limpar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboTipoProduto
            // 
            this.comboTipoProduto.FormattingEnabled = true;
            this.comboTipoProduto.Items.AddRange(new object[] {
            "Maquiagem",
            "Perfume",
            "Creme"});
            this.comboTipoProduto.Location = new System.Drawing.Point(112, 53);
            this.comboTipoProduto.Name = "comboTipoProduto";
            this.comboTipoProduto.Size = new System.Drawing.Size(121, 21);
            this.comboTipoProduto.TabIndex = 13;
            // 
            // textBoxNomeCadastroProduto
            // 
            this.textBoxNomeCadastroProduto.Location = new System.Drawing.Point(112, 26);
            this.textBoxNomeCadastroProduto.Name = "textBoxNomeCadastroProduto";
            this.textBoxNomeCadastroProduto.Size = new System.Drawing.Size(100, 20);
            this.textBoxNomeCadastroProduto.TabIndex = 12;
            // 
            // labelPrecoCadastroProduto
            // 
            this.labelPrecoCadastroProduto.AutoSize = true;
            this.labelPrecoCadastroProduto.Location = new System.Drawing.Point(15, 86);
            this.labelPrecoCadastroProduto.Name = "labelPrecoCadastroProduto";
            this.labelPrecoCadastroProduto.Size = new System.Drawing.Size(35, 13);
            this.labelPrecoCadastroProduto.TabIndex = 11;
            this.labelPrecoCadastroProduto.Text = "Preço";
            // 
            // labelTipoCadastroProduto
            // 
            this.labelTipoCadastroProduto.AutoSize = true;
            this.labelTipoCadastroProduto.Location = new System.Drawing.Point(14, 61);
            this.labelTipoCadastroProduto.Name = "labelTipoCadastroProduto";
            this.labelTipoCadastroProduto.Size = new System.Drawing.Size(82, 13);
            this.labelTipoCadastroProduto.TabIndex = 10;
            this.labelTipoCadastroProduto.Text = "Tipo de produto";
            // 
            // labelNomeCadastroProduto
            // 
            this.labelNomeCadastroProduto.AutoSize = true;
            this.labelNomeCadastroProduto.Location = new System.Drawing.Point(15, 33);
            this.labelNomeCadastroProduto.Name = "labelNomeCadastroProduto";
            this.labelNomeCadastroProduto.Size = new System.Drawing.Size(90, 13);
            this.labelNomeCadastroProduto.TabIndex = 9;
            this.labelNomeCadastroProduto.Text = "Nome do Produto";
            // 
            // textBoxPrecoCadastroProduto
            // 
            this.textBoxPrecoCadastroProduto.Location = new System.Drawing.Point(56, 83);
            this.textBoxPrecoCadastroProduto.Name = "textBoxPrecoCadastroProduto";
            this.textBoxPrecoCadastroProduto.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrecoCadastroProduto.TabIndex = 16;
            // 
            // FormProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 300);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormProdutos";
            this.Text = "Produtos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboTipoProduto;
        private System.Windows.Forms.TextBox textBoxNomeCadastroProduto;
        private System.Windows.Forms.Label labelPrecoCadastroProduto;
        private System.Windows.Forms.Label labelTipoCadastroProduto;
        private System.Windows.Forms.Label labelNomeCadastroProduto;
        private System.Windows.Forms.TextBox textBoxPrecoCadastroProduto;

    }
}