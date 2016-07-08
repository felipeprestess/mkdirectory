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
            this.labelNomeCadastroProduto = new System.Windows.Forms.Label();
            this.labelTipoCadastroProduto = new System.Windows.Forms.Label();
            this.labelPrecoCadastroProduto = new System.Windows.Forms.Label();
            this.textBoxNomeCadastroProduto = new System.Windows.Forms.TextBox();
            this.comboTipoProduto = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxPrecoCadastroProduto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelNomeCadastroProduto
            // 
            this.labelNomeCadastroProduto.AutoSize = true;
            this.labelNomeCadastroProduto.Location = new System.Drawing.Point(13, 36);
            this.labelNomeCadastroProduto.Name = "labelNomeCadastroProduto";
            this.labelNomeCadastroProduto.Size = new System.Drawing.Size(90, 13);
            this.labelNomeCadastroProduto.TabIndex = 0;
            this.labelNomeCadastroProduto.Text = "Nome do Produto";
            // 
            // labelTipoCadastroProduto
            // 
            this.labelTipoCadastroProduto.AutoSize = true;
            this.labelTipoCadastroProduto.Location = new System.Drawing.Point(12, 64);
            this.labelTipoCadastroProduto.Name = "labelTipoCadastroProduto";
            this.labelTipoCadastroProduto.Size = new System.Drawing.Size(82, 13);
            this.labelTipoCadastroProduto.TabIndex = 1;
            this.labelTipoCadastroProduto.Text = "Tipo de produto";
            // 
            // labelPrecoCadastroProduto
            // 
            this.labelPrecoCadastroProduto.AutoSize = true;
            this.labelPrecoCadastroProduto.Location = new System.Drawing.Point(13, 89);
            this.labelPrecoCadastroProduto.Name = "labelPrecoCadastroProduto";
            this.labelPrecoCadastroProduto.Size = new System.Drawing.Size(35, 13);
            this.labelPrecoCadastroProduto.TabIndex = 2;
            this.labelPrecoCadastroProduto.Text = "Preço";
            // 
            // textBoxNomeCadastroProduto
            // 
            this.textBoxNomeCadastroProduto.Location = new System.Drawing.Point(110, 29);
            this.textBoxNomeCadastroProduto.Name = "textBoxNomeCadastroProduto";
            this.textBoxNomeCadastroProduto.Size = new System.Drawing.Size(100, 20);
            this.textBoxNomeCadastroProduto.TabIndex = 4;
            this.textBoxNomeCadastroProduto.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // comboTipoProduto
            // 
            this.comboTipoProduto.FormattingEnabled = true;
            this.comboTipoProduto.Items.AddRange(new object[] {
            "Maquiagem",
            "Perfume",
            "Creme"});
            this.comboTipoProduto.Location = new System.Drawing.Point(110, 56);
            this.comboTipoProduto.Name = "comboTipoProduto";
            this.comboTipoProduto.Size = new System.Drawing.Size(121, 21);
            this.comboTipoProduto.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(110, 150);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Limpar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxPrecoCadastroProduto
            // 
            this.textBoxPrecoCadastroProduto.Location = new System.Drawing.Point(54, 86);
            this.textBoxPrecoCadastroProduto.Name = "textBoxPrecoCadastroProduto";
            this.textBoxPrecoCadastroProduto.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrecoCadastroProduto.TabIndex = 8;
            this.textBoxPrecoCadastroProduto.TextChanged += new System.EventHandler(this.textBoxPrecoCadastroProduto_TextChanged);
            // 
            // FormProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 193);
            this.Controls.Add(this.textBoxPrecoCadastroProduto);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboTipoProduto);
            this.Controls.Add(this.textBoxNomeCadastroProduto);
            this.Controls.Add(this.labelPrecoCadastroProduto);
            this.Controls.Add(this.labelTipoCadastroProduto);
            this.Controls.Add(this.labelNomeCadastroProduto);
            this.Name = "FormProdutos";
            this.Text = "Produtos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNomeCadastroProduto;
        private System.Windows.Forms.Label labelTipoCadastroProduto;
        private System.Windows.Forms.Label labelPrecoCadastroProduto;
        private System.Windows.Forms.TextBox textBoxNomeCadastroProduto;
        private System.Windows.Forms.ComboBox comboTipoProduto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBoxPrecoCadastroProduto;
    }
}