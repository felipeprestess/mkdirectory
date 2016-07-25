namespace CadastroCliente
{
    partial class FormCompra
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
            this.gpxCompra = new System.Windows.Forms.GroupBox();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnAdicionaProduto = new System.Windows.Forms.Button();
            this.btnFinalizarCompra = new System.Windows.Forms.Button();
            this.txtTotalCompra = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtPrecoProduto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudQtdProduto = new System.Windows.Forms.NumericUpDown();
            this.txtPesquisaProduto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNovaCompra = new System.Windows.Forms.Button();
            this.btnExibirTodos = new System.Windows.Forms.Button();
            this.gpxCompra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtdProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // gpxCompra
            // 
            this.gpxCompra.Controls.Add(this.btnRemover);
            this.gpxCompra.Controls.Add(this.btnAdicionaProduto);
            this.gpxCompra.Controls.Add(this.btnFinalizarCompra);
            this.gpxCompra.Controls.Add(this.txtTotalCompra);
            this.gpxCompra.Controls.Add(this.lblTotal);
            this.gpxCompra.Controls.Add(this.txtPrecoProduto);
            this.gpxCompra.Controls.Add(this.label3);
            this.gpxCompra.Controls.Add(this.label2);
            this.gpxCompra.Controls.Add(this.nudQtdProduto);
            this.gpxCompra.Controls.Add(this.txtPesquisaProduto);
            this.gpxCompra.Controls.Add(this.label1);
            this.gpxCompra.Enabled = false;
            this.gpxCompra.Location = new System.Drawing.Point(12, 12);
            this.gpxCompra.Name = "gpxCompra";
            this.gpxCompra.Size = new System.Drawing.Size(474, 163);
            this.gpxCompra.TabIndex = 0;
            this.gpxCompra.TabStop = false;
            this.gpxCompra.Text = "Detalhes da Compra";
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(150, 125);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(75, 23);
            this.btnRemover.TabIndex = 21;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            // 
            // btnAdicionaProduto
            // 
            this.btnAdicionaProduto.Location = new System.Drawing.Point(69, 125);
            this.btnAdicionaProduto.Name = "btnAdicionaProduto";
            this.btnAdicionaProduto.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionaProduto.TabIndex = 20;
            this.btnAdicionaProduto.Text = "+ Produto";
            this.btnAdicionaProduto.UseVisualStyleBackColor = true;
            // 
            // btnFinalizarCompra
            // 
            this.btnFinalizarCompra.Location = new System.Drawing.Point(333, 125);
            this.btnFinalizarCompra.Name = "btnFinalizarCompra";
            this.btnFinalizarCompra.Size = new System.Drawing.Size(95, 23);
            this.btnFinalizarCompra.TabIndex = 19;
            this.btnFinalizarCompra.Text = "Finalizar";
            this.btnFinalizarCompra.UseVisualStyleBackColor = true;
            // 
            // txtTotalCompra
            // 
            this.txtTotalCompra.Enabled = false;
            this.txtTotalCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalCompra.Location = new System.Drawing.Point(333, 84);
            this.txtTotalCompra.Name = "txtTotalCompra";
            this.txtTotalCompra.Size = new System.Drawing.Size(95, 30);
            this.txtTotalCompra.TabIndex = 18;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(254, 91);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(73, 13);
            this.lblTotal.TabIndex = 17;
            this.lblTotal.Text = "Total Compra:";
            // 
            // txtPrecoProduto
            // 
            this.txtPrecoProduto.Location = new System.Drawing.Point(209, 20);
            this.txtPrecoProduto.Name = "txtPrecoProduto";
            this.txtPrecoProduto.Size = new System.Drawing.Size(69, 20);
            this.txtPrecoProduto.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(176, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Preço";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(295, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Quantidade";
            // 
            // nudQtdProduto
            // 
            this.nudQtdProduto.Location = new System.Drawing.Point(363, 21);
            this.nudQtdProduto.Name = "nudQtdProduto";
            this.nudQtdProduto.Size = new System.Drawing.Size(56, 20);
            this.nudQtdProduto.TabIndex = 13;
            // 
            // txtPesquisaProduto
            // 
            this.txtPesquisaProduto.Location = new System.Drawing.Point(69, 21);
            this.txtPesquisaProduto.Name = "txtPesquisaProduto";
            this.txtPesquisaProduto.Size = new System.Drawing.Size(100, 20);
            this.txtPesquisaProduto.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Produto";
            // 
            // btnNovaCompra
            // 
            this.btnNovaCompra.Location = new System.Drawing.Point(12, 194);
            this.btnNovaCompra.Name = "btnNovaCompra";
            this.btnNovaCompra.Size = new System.Drawing.Size(82, 23);
            this.btnNovaCompra.TabIndex = 1;
            this.btnNovaCompra.Text = "Nova Compra";
            this.btnNovaCompra.UseVisualStyleBackColor = true;
            this.btnNovaCompra.Click += new System.EventHandler(this.btnNovaCompra_Click);
            // 
            // btnExibirTodos
            // 
            this.btnExibirTodos.Location = new System.Drawing.Point(111, 194);
            this.btnExibirTodos.Name = "btnExibirTodos";
            this.btnExibirTodos.Size = new System.Drawing.Size(89, 23);
            this.btnExibirTodos.TabIndex = 2;
            this.btnExibirTodos.Text = "Exibir Compras";
            this.btnExibirTodos.UseVisualStyleBackColor = true;
            // 
            // FormCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 229);
            this.Controls.Add(this.btnExibirTodos);
            this.Controls.Add(this.btnNovaCompra);
            this.Controls.Add(this.gpxCompra);
            this.Name = "FormCompra";
            this.Text = "Compras";
            this.gpxCompra.ResumeLayout(false);
            this.gpxCompra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtdProduto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpxCompra;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnAdicionaProduto;
        private System.Windows.Forms.Button btnFinalizarCompra;
        private System.Windows.Forms.TextBox txtTotalCompra;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtPrecoProduto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudQtdProduto;
        private System.Windows.Forms.TextBox txtPesquisaProduto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNovaCompra;
        private System.Windows.Forms.Button btnExibirTodos;

    }
}