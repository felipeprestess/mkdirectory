namespace CadastroCliente
{
    partial class FormVendas
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
            this.buttonNovaVendaVendas = new System.Windows.Forms.Button();
            this.buttonMostrarTodasVendasVendas = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonNovaVendaVendas
            // 
            this.buttonNovaVendaVendas.Location = new System.Drawing.Point(12, 214);
            this.buttonNovaVendaVendas.Name = "buttonNovaVendaVendas";
            this.buttonNovaVendaVendas.Size = new System.Drawing.Size(75, 23);
            this.buttonNovaVendaVendas.TabIndex = 0;
            this.buttonNovaVendaVendas.Text = "Nova Venda";
            this.buttonNovaVendaVendas.UseVisualStyleBackColor = true;
            this.buttonNovaVendaVendas.Click += new System.EventHandler(this.buttonNovaVendaVendas_Click);
            // 
            // buttonMostrarTodasVendasVendas
            // 
            this.buttonMostrarTodasVendasVendas.Location = new System.Drawing.Point(94, 214);
            this.buttonMostrarTodasVendasVendas.Name = "buttonMostrarTodasVendasVendas";
            this.buttonMostrarTodasVendasVendas.Size = new System.Drawing.Size(89, 23);
            this.buttonMostrarTodasVendasVendas.TabIndex = 1;
            this.buttonMostrarTodasVendasVendas.Text = "Mostrar Todas";
            this.buttonMostrarTodasVendasVendas.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(43, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(343, 141);
            this.dataGridView1.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Cliente";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Produto";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Total";
            this.Column3.Name = "Column3";
            // 
            // FormVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 260);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonMostrarTodasVendasVendas);
            this.Controls.Add(this.buttonNovaVendaVendas);
            this.Name = "FormVendas";
            this.Text = "Vendas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonNovaVendaVendas;
        private System.Windows.Forms.Button buttonMostrarTodasVendasVendas;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}