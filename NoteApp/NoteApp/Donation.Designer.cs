namespace NoteApp
{
    partial class Donation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Donation));
            this.btn_reset = new System.Windows.Forms.Button();
            this.input_name = new System.Windows.Forms.TextBox();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_title = new System.Windows.Forms.Label();
            this.input_nif = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.input_country = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.input_address = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.check_terms = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(325, 281);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(86, 41);
            this.btn_reset.TabIndex = 12;
            this.btn_reset.Text = "Pagar";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_pay_Click);
            // 
            // input_name
            // 
            this.input_name.Location = new System.Drawing.Point(106, 51);
            this.input_name.Name = "input_name";
            this.input_name.Size = new System.Drawing.Size(305, 22);
            this.input_name.TabIndex = 10;
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Location = new System.Drawing.Point(27, 56);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(49, 17);
            this.lbl_username.TabIndex = 8;
            this.lbl_username.Text = "Nome:";
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Location = new System.Drawing.Point(27, 14);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(137, 17);
            this.lbl_title.TabIndex = 13;
            this.lbl_title.Text = "Dados de Faturação";
            // 
            // input_nif
            // 
            this.input_nif.Location = new System.Drawing.Point(106, 90);
            this.input_nif.Name = "input_nif";
            this.input_nif.Size = new System.Drawing.Size(305, 22);
            this.input_nif.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "NIF:";
            // 
            // input_country
            // 
            this.input_country.Location = new System.Drawing.Point(106, 134);
            this.input_country.Name = "input_country";
            this.input_country.Size = new System.Drawing.Size(305, 22);
            this.input_country.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "País:";
            // 
            // input_address
            // 
            this.input_address.Location = new System.Drawing.Point(106, 174);
            this.input_address.Name = "input_address";
            this.input_address.Size = new System.Drawing.Size(305, 22);
            this.input_address.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Morada:";
            // 
            // check_terms
            // 
            this.check_terms.AutoSize = true;
            this.check_terms.Location = new System.Drawing.Point(106, 226);
            this.check_terms.Name = "check_terms";
            this.check_terms.Size = new System.Drawing.Size(294, 21);
            this.check_terms.TabIndex = 20;
            this.check_terms.Text = "Aceito os termos e condições do NoteApp";
            this.check_terms.UseVisualStyleBackColor = true;
            // 
            // Donation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 333);
            this.Controls.Add(this.check_terms);
            this.Controls.Add(this.input_address);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.input_country);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.input_nif);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.input_name);
            this.Controls.Add(this.lbl_username);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(442, 380);
            this.Name = "Donation";
            this.Text = "Pagar Tool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.TextBox input_name;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.TextBox input_nif;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox input_country;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox input_address;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox check_terms;
    }
}