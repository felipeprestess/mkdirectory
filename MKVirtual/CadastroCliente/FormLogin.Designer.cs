﻿namespace CadastroCliente
{
    partial class FormLogin
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
            this.labelLoginUsuario = new System.Windows.Forms.Label();
            this.labelLoginSenhaUsuario = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.buttonLoginEntrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelLoginUsuario
            // 
            this.labelLoginUsuario.AutoSize = true;
            this.labelLoginUsuario.Location = new System.Drawing.Point(33, 65);
            this.labelLoginUsuario.Name = "labelLoginUsuario";
            this.labelLoginUsuario.Size = new System.Drawing.Size(43, 13);
            this.labelLoginUsuario.TabIndex = 0;
            this.labelLoginUsuario.Text = "Usuário";
            // 
            // labelLoginSenhaUsuario
            // 
            this.labelLoginSenhaUsuario.AutoSize = true;
            this.labelLoginSenhaUsuario.Location = new System.Drawing.Point(33, 104);
            this.labelLoginSenhaUsuario.Name = "labelLoginSenhaUsuario";
            this.labelLoginSenhaUsuario.Size = new System.Drawing.Size(38, 13);
            this.labelLoginSenhaUsuario.TabIndex = 1;
            this.labelLoginSenhaUsuario.Text = "Senha";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(83, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(83, 96);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // buttonLoginEntrar
            // 
            this.buttonLoginEntrar.Location = new System.Drawing.Point(83, 145);
            this.buttonLoginEntrar.Name = "buttonLoginEntrar";
            this.buttonLoginEntrar.Size = new System.Drawing.Size(75, 23);
            this.buttonLoginEntrar.TabIndex = 4;
            this.buttonLoginEntrar.Text = "Entrar";
            this.buttonLoginEntrar.UseVisualStyleBackColor = true;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 227);
            this.Controls.Add(this.buttonLoginEntrar);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelLoginSenhaUsuario);
            this.Controls.Add(this.labelLoginUsuario);
            this.Name = "FormLogin";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLoginUsuario;
        private System.Windows.Forms.Label labelLoginSenhaUsuario;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button buttonLoginEntrar;
    }
}