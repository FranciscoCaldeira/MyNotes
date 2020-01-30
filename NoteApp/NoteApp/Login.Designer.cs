namespace NoteApp
{
    partial class Login
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.username = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.input_username = new System.Windows.Forms.TextBox();
            this.input_password = new System.Windows.Forms.TextBox();
            this.btn_reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(234, 153);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(86, 41);
            this.btn_login.TabIndex = 0;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(338, 153);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(86, 41);
            this.btn_exit.TabIndex = 1;
            this.btn_exit.Text = "Sair";
            this.btn_exit.UseVisualStyleBackColor = true;
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Location = new System.Drawing.Point(40, 66);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(77, 17);
            this.username.TabIndex = 2;
            this.username.Text = "Username:";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(40, 111);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(73, 17);
            this.password.TabIndex = 3;
            this.password.Text = "Password:";
            // 
            // input_username
            // 
            this.input_username.Location = new System.Drawing.Point(119, 61);
            this.input_username.Name = "input_username";
            this.input_username.Size = new System.Drawing.Size(305, 22);
            this.input_username.TabIndex = 4;
            // 
            // input_password
            // 
            this.input_password.Location = new System.Drawing.Point(119, 106);
            this.input_password.Name = "input_password";
            this.input_password.PasswordChar = '*';
            this.input_password.Size = new System.Drawing.Size(305, 22);
            this.input_password.TabIndex = 5;
            this.input_password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.form_KeyPress);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(142, 153);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(86, 41);
            this.btn_reset.TabIndex = 7;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.input_password);
            this.Controls.Add(this.input_username);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_login);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox input_username;
        private System.Windows.Forms.TextBox input_password;
        private System.Windows.Forms.Button btn_reset;
    }
}

