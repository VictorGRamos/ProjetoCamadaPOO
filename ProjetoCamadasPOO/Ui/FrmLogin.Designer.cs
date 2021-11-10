namespace ProjetoCamadasPOO.Ui
{
    partial class FrmLogin
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
            this.label2 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.btn_Entrar = new System.Windows.Forms.Button();
            this.lnklbl_esqueceu = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(195, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "E-MAIL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "SENHA";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(198, 81);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(149, 20);
            this.txt_email.TabIndex = 2;
            // 
            // txt_senha
            // 
            this.txt_senha.Location = new System.Drawing.Point(198, 127);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.Size = new System.Drawing.Size(149, 20);
            this.txt_senha.TabIndex = 3;
            // 
            // btn_Entrar
            // 
            this.btn_Entrar.Location = new System.Drawing.Point(198, 165);
            this.btn_Entrar.Name = "btn_Entrar";
            this.btn_Entrar.Size = new System.Drawing.Size(149, 31);
            this.btn_Entrar.TabIndex = 4;
            this.btn_Entrar.Text = "ENTRAR";
            this.btn_Entrar.UseVisualStyleBackColor = true;
            this.btn_Entrar.Click += new System.EventHandler(this.btn_Entrar_Click);
            // 
            // lnklbl_esqueceu
            // 
            this.lnklbl_esqueceu.AutoSize = true;
            this.lnklbl_esqueceu.Location = new System.Drawing.Point(216, 218);
            this.lnklbl_esqueceu.Name = "lnklbl_esqueceu";
            this.lnklbl_esqueceu.Size = new System.Drawing.Size(113, 13);
            this.lnklbl_esqueceu.TabIndex = 5;
            this.lnklbl_esqueceu.TabStop = true;
            this.lnklbl_esqueceu.Text = "Esqueceu sua senha?";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 335);
            this.Controls.Add(this.lnklbl_esqueceu);
            this.Controls.Add(this.btn_Entrar);
            this.Controls.Add(this.txt_senha);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmLogin";
            this.Text = "FrmLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.Button btn_Entrar;
        private System.Windows.Forms.LinkLabel lnklbl_esqueceu;
    }
}