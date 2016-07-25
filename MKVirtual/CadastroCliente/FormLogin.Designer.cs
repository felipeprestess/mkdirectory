namespace CadastroCliente
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
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.lblOpcao = new System.Windows.Forms.Label();
            this.cbxOpcaoLogin = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(59, 68);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(43, 13);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Usuário";
            this.lblLogin.Visible = false;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(59, 107);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(38, 13);
            this.lblPass.TabIndex = 1;
            this.lblPass.Text = "Senha";
            this.lblPass.Visible = false;
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(109, 60);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(100, 20);
            this.txtLogin.TabIndex = 2;
            this.txtLogin.Visible = false;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(109, 100);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(100, 20);
            this.txtPass.TabIndex = 3;
            this.txtPass.Visible = false;
            // 
            // btnEntrar
            // 
            this.btnEntrar.Location = new System.Drawing.Point(109, 148);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(75, 23);
            this.btnEntrar.TabIndex = 4;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Visible = false;
            this.btnEntrar.Click += new System.EventHandler(this.buttonLoginEntrar_Click);
            // 
            // lblOpcao
            // 
            this.lblOpcao.AutoSize = true;
            this.lblOpcao.Location = new System.Drawing.Point(66, 91);
            this.lblOpcao.Name = "lblOpcao";
            this.lblOpcao.Size = new System.Drawing.Size(29, 13);
            this.lblOpcao.TabIndex = 5;
            this.lblOpcao.Text = "Sou:";
            // 
            // cbxOpcaoLogin
            // 
            this.cbxOpcaoLogin.FormattingEnabled = true;
            this.cbxOpcaoLogin.Items.AddRange(new object[] {
            "Cliente",
            "Consultora"});
            this.cbxOpcaoLogin.Location = new System.Drawing.Point(109, 86);
            this.cbxOpcaoLogin.Name = "cbxOpcaoLogin";
            this.cbxOpcaoLogin.Size = new System.Drawing.Size(100, 21);
            this.cbxOpcaoLogin.TabIndex = 6;
            this.cbxOpcaoLogin.SelectedIndexChanged += new System.EventHandler(this.cbxOpcaoLogin_SelectedIndexChanged);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CadastroCliente.Properties.Resources.MKICON;
            this.ClientSize = new System.Drawing.Size(309, 260);
            this.Controls.Add(this.cbxOpcaoLogin);
            this.Controls.Add(this.lblOpcao);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblLogin);
            this.Name = "FormLogin";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Label lblOpcao;
        private System.Windows.Forms.ComboBox cbxOpcaoLogin;
    }
}