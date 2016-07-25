namespace CadastroCliente
{
    partial class FormNovaVenda
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCampoProduto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.qtdProduto = new System.Windows.Forms.NumericUpDown();
            this.lblPreco = new System.Windows.Forms.Label();
            this.buttonSimularVenda_RealizarVenda = new System.Windows.Forms.Button();
            this.buttonFinalizarVenda_RealizarVenda = new System.Windows.Forms.Button();
            this.txtPrecoProduto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.qtdProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Produto";
            // 
            // txtCampoProduto
            // 
            this.txtCampoProduto.Location = new System.Drawing.Point(63, 6);
            this.txtCampoProduto.Name = "txtCampoProduto";
            this.txtCampoProduto.Size = new System.Drawing.Size(100, 20);
            this.txtCampoProduto.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quantidade";
            // 
            // qtdProduto
            // 
            this.qtdProduto.Location = new System.Drawing.Point(246, 6);
            this.qtdProduto.Name = "qtdProduto";
            this.qtdProduto.Size = new System.Drawing.Size(48, 20);
            this.qtdProduto.TabIndex = 3;
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(300, 13);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(35, 13);
            this.lblPreco.TabIndex = 4;
            this.lblPreco.Text = "Preço";
            // 
            // buttonSimularVenda_RealizarVenda
            // 
            this.buttonSimularVenda_RealizarVenda.Location = new System.Drawing.Point(319, 48);
            this.buttonSimularVenda_RealizarVenda.Name = "buttonSimularVenda_RealizarVenda";
            this.buttonSimularVenda_RealizarVenda.Size = new System.Drawing.Size(94, 23);
            this.buttonSimularVenda_RealizarVenda.TabIndex = 5;
            this.buttonSimularVenda_RealizarVenda.Text = "Simular Venda";
            this.buttonSimularVenda_RealizarVenda.UseVisualStyleBackColor = true;
            // 
            // buttonFinalizarVenda_RealizarVenda
            // 
            this.buttonFinalizarVenda_RealizarVenda.Location = new System.Drawing.Point(319, 93);
            this.buttonFinalizarVenda_RealizarVenda.Name = "buttonFinalizarVenda_RealizarVenda";
            this.buttonFinalizarVenda_RealizarVenda.Size = new System.Drawing.Size(94, 23);
            this.buttonFinalizarVenda_RealizarVenda.TabIndex = 6;
            this.buttonFinalizarVenda_RealizarVenda.Text = "Finalizar Venda";
            this.buttonFinalizarVenda_RealizarVenda.UseVisualStyleBackColor = true;
            // 
            // txtPrecoProduto
            // 
            this.txtPrecoProduto.Enabled = false;
            this.txtPrecoProduto.Location = new System.Drawing.Point(341, 6);
            this.txtPrecoProduto.Name = "txtPrecoProduto";
            this.txtPrecoProduto.Size = new System.Drawing.Size(72, 20);
            this.txtPrecoProduto.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Escolher cliente";
            // 
            // txtCliente
            // 
            this.txtCliente.Enabled = false;
            this.txtCliente.Location = new System.Drawing.Point(101, 41);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(100, 20);
            this.txtCliente.TabIndex = 9;
            // 
            // FormNovaVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 140);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPrecoProduto);
            this.Controls.Add(this.buttonFinalizarVenda_RealizarVenda);
            this.Controls.Add(this.buttonSimularVenda_RealizarVenda);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.qtdProduto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCampoProduto);
            this.Controls.Add(this.label1);
            this.Name = "FormNovaVenda";
            this.Text = "Realizar Venda";
            ((System.ComponentModel.ISupportInitialize)(this.qtdProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCampoProduto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown qtdProduto;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Button buttonSimularVenda_RealizarVenda;
        private System.Windows.Forms.Button buttonFinalizarVenda_RealizarVenda;
        private System.Windows.Forms.TextBox txtPrecoProduto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCliente;
    }
}