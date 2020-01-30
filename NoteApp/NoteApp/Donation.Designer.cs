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
            this.btn_reset = new System.Windows.Forms.Button();
            this.input_name = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.input_nif = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.input_country = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.input_adress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.check_terms = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(352, 295);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(86, 41);
            this.btn_reset.TabIndex = 12;
            this.btn_reset.Text = "Doar";
            this.btn_reset.UseVisualStyleBackColor = true;
            // 
            // input_name
            // 
            this.input_name.Location = new System.Drawing.Point(133, 65);
            this.input_name.Name = "input_name";
            this.input_name.Size = new System.Drawing.Size(305, 22);
            this.input_name.TabIndex = 10;
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Location = new System.Drawing.Point(54, 70);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(49, 17);
            this.username.TabIndex = 8;
            this.username.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Dados de Faturação";
            // 
            // input_nif
            // 
            this.input_nif.Location = new System.Drawing.Point(133, 104);
            this.input_nif.Name = "input_nif";
            this.input_nif.Size = new System.Drawing.Size(305, 22);
            this.input_nif.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "NIF:";
            // 
            // input_country
            // 
            this.input_country.Location = new System.Drawing.Point(133, 148);
            this.input_country.Name = "input_country";
            this.input_country.Size = new System.Drawing.Size(305, 22);
            this.input_country.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "País:";
            // 
            // input_adress
            // 
            this.input_adress.Location = new System.Drawing.Point(133, 188);
            this.input_adress.Name = "input_adress";
            this.input_adress.Size = new System.Drawing.Size(305, 22);
            this.input_adress.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Morada:";
            // 
            // check_terms
            // 
            this.check_terms.AutoSize = true;
            this.check_terms.Location = new System.Drawing.Point(133, 240);
            this.check_terms.Name = "check_terms";
            this.check_terms.Size = new System.Drawing.Size(294, 21);
            this.check_terms.TabIndex = 20;
            this.check_terms.Text = "Aceito os termos e condições do NoteApp";
            this.check_terms.UseVisualStyleBackColor = true;
            this.check_terms.CheckedChanged += new System.EventHandler(this.check_terms_CheckedChanged);
            // 
            // Donation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 383);
            this.Controls.Add(this.check_terms);
            this.Controls.Add(this.input_adress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.input_country);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.input_nif);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.input_name);
            this.Controls.Add(this.username);
            this.Name = "Donation";
            this.Text = "Donation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.TextBox input_name;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox input_nif;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox input_country;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox input_adress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox check_terms;
    }
}