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
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_title = new System.Windows.Forms.Label();
            this.input_nif = new System.Windows.Forms.TextBox();
            this.lbl_nif = new System.Windows.Forms.Label();
            this.input_country = new System.Windows.Forms.TextBox();
            this.lbl_coutry = new System.Windows.Forms.Label();
            this.input_address = new System.Windows.Forms.TextBox();
            this.lbl_adress = new System.Windows.Forms.Label();
            this.check_terms = new System.Windows.Forms.CheckBox();
            this.lbl_price = new System.Windows.Forms.Label();
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
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(27, 56);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(49, 17);
            this.lbl_name.TabIndex = 8;
            this.lbl_name.Text = "Nome:";
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
            // lbl_nif
            // 
            this.lbl_nif.AutoSize = true;
            this.lbl_nif.Location = new System.Drawing.Point(27, 95);
            this.lbl_nif.Name = "lbl_nif";
            this.lbl_nif.Size = new System.Drawing.Size(33, 17);
            this.lbl_nif.TabIndex = 14;
            this.lbl_nif.Text = "NIF:";
            // 
            // input_country
            // 
            this.input_country.Location = new System.Drawing.Point(106, 134);
            this.input_country.Name = "input_country";
            this.input_country.Size = new System.Drawing.Size(305, 22);
            this.input_country.TabIndex = 17;
            // 
            // lbl_coutry
            // 
            this.lbl_coutry.AutoSize = true;
            this.lbl_coutry.Location = new System.Drawing.Point(27, 139);
            this.lbl_coutry.Name = "lbl_coutry";
            this.lbl_coutry.Size = new System.Drawing.Size(39, 17);
            this.lbl_coutry.TabIndex = 16;
            this.lbl_coutry.Text = "País:";
            // 
            // input_address
            // 
            this.input_address.Location = new System.Drawing.Point(106, 174);
            this.input_address.Name = "input_address";
            this.input_address.Size = new System.Drawing.Size(305, 22);
            this.input_address.TabIndex = 19;
            // 
            // lbl_adress
            // 
            this.lbl_adress.AutoSize = true;
            this.lbl_adress.Location = new System.Drawing.Point(27, 179);
            this.lbl_adress.Name = "lbl_adress";
            this.lbl_adress.Size = new System.Drawing.Size(60, 17);
            this.lbl_adress.TabIndex = 18;
            this.lbl_adress.Text = "Morada:";
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
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_price.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_price.Location = new System.Drawing.Point(159, 283);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(109, 29);
            this.lbl_price.TabIndex = 21;
            this.lbl_price.Text = "1€ + IVA";
            // 
            // Donation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 333);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.check_terms);
            this.Controls.Add(this.input_address);
            this.Controls.Add(this.lbl_adress);
            this.Controls.Add(this.input_country);
            this.Controls.Add(this.lbl_coutry);
            this.Controls.Add(this.input_nif);
            this.Controls.Add(this.lbl_nif);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.input_name);
            this.Controls.Add(this.lbl_name);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(442, 380);
            this.Name = "Donation";
            this.Text = "Pagamento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.TextBox input_name;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.TextBox input_nif;
        private System.Windows.Forms.Label lbl_nif;
        private System.Windows.Forms.TextBox input_country;
        private System.Windows.Forms.Label lbl_coutry;
        private System.Windows.Forms.TextBox input_address;
        private System.Windows.Forms.Label lbl_adress;
        private System.Windows.Forms.CheckBox check_terms;
        private System.Windows.Forms.Label lbl_price;
    }
}