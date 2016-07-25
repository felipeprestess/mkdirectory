namespace CadastroCliente
{
    partial class FormVenda
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
            this.btnNovaVendaVendas = new System.Windows.Forms.Button();
            this.btnMostrarTodasVendasVendas = new System.Windows.Forms.Button();
            this.dataGridVendas = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVendas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNovaVendaVendas
            // 
            this.btnNovaVendaVendas.Location = new System.Drawing.Point(12, 214);
            this.btnNovaVendaVendas.Name = "btnNovaVendaVendas";
            this.btnNovaVendaVendas.Size = new System.Drawing.Size(75, 23);
            this.btnNovaVendaVendas.TabIndex = 0;
            this.btnNovaVendaVendas.Text = "Nova Venda";
            this.btnNovaVendaVendas.UseVisualStyleBackColor = true;
            this.btnNovaVendaVendas.Click += new System.EventHandler(this.buttonNovaVendaVendas_Click);
            // 
            // btnMostrarTodasVendasVendas
            // 
            this.btnMostrarTodasVendasVendas.Location = new System.Drawing.Point(94, 214);
            this.btnMostrarTodasVendasVendas.Name = "btnMostrarTodasVendasVendas";
            this.btnMostrarTodasVendasVendas.Size = new System.Drawing.Size(89, 23);
            this.btnMostrarTodasVendasVendas.TabIndex = 1;
            this.btnMostrarTodasVendasVendas.Text = "Mostrar Todas";
            this.btnMostrarTodasVendasVendas.UseVisualStyleBackColor = true;
            // 
            // dataGridVendas
            // 
            this.dataGridVendas.BackgroundColor = System.Drawing.Color.YellowGreen;
            this.dataGridVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridVendas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridVendas.Location = new System.Drawing.Point(43, 27);
            this.dataGridVendas.Name = "dataGridVendas";
            this.dataGridVendas.Size = new System.Drawing.Size(343, 141);
            this.dataGridVendas.TabIndex = 2;
            this.dataGridVendas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridVendas_CellContentClick);
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
            this.Column3.Width = 80;
            // 
            // FormVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 260);
            this.Controls.Add(this.dataGridVendas);
            this.Controls.Add(this.btnMostrarTodasVendasVendas);
            this.Controls.Add(this.btnNovaVendaVendas);
            this.Name = "FormVenda";
            this.Text = "Vendas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVendas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNovaVendaVendas;
        private System.Windows.Forms.Button btnMostrarTodasVendasVendas;
        private System.Windows.Forms.DataGridView dataGridVendas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}