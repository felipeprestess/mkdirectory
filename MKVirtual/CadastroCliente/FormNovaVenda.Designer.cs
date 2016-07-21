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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSimularVenda_RealizarVenda = new System.Windows.Forms.Button();
            this.buttonFinalizarVenda_RealizarVenda = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(63, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quantidade";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(247, 5);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(48, 20);
            this.numericUpDown1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cliente";
            // 
            // buttonSimularVenda_RealizarVenda
            // 
            this.buttonSimularVenda_RealizarVenda.Location = new System.Drawing.Point(253, 121);
            this.buttonSimularVenda_RealizarVenda.Name = "buttonSimularVenda_RealizarVenda";
            this.buttonSimularVenda_RealizarVenda.Size = new System.Drawing.Size(94, 23);
            this.buttonSimularVenda_RealizarVenda.TabIndex = 5;
            this.buttonSimularVenda_RealizarVenda.Text = "Simular Venda";
            this.buttonSimularVenda_RealizarVenda.UseVisualStyleBackColor = true;
            // 
            // buttonFinalizarVenda_RealizarVenda
            // 
            this.buttonFinalizarVenda_RealizarVenda.Location = new System.Drawing.Point(253, 165);
            this.buttonFinalizarVenda_RealizarVenda.Name = "buttonFinalizarVenda_RealizarVenda";
            this.buttonFinalizarVenda_RealizarVenda.Size = new System.Drawing.Size(94, 23);
            this.buttonFinalizarVenda_RealizarVenda.TabIndex = 6;
            this.buttonFinalizarVenda_RealizarVenda.Text = "Finalizar Venda";
            this.buttonFinalizarVenda_RealizarVenda.UseVisualStyleBackColor = true;
            // 
            // FormNovaVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 203);
            this.Controls.Add(this.buttonFinalizarVenda_RealizarVenda);
            this.Controls.Add(this.buttonSimularVenda_RealizarVenda);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "FormNovaVenda";
            this.Text = "Realizar Venda";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonSimularVenda_RealizarVenda;
        private System.Windows.Forms.Button buttonFinalizarVenda_RealizarVenda;
    }
}