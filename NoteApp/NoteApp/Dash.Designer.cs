namespace NoteApp
{
    partial class Dash
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
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_donate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_logout
            // 
            this.btn_logout.Location = new System.Drawing.Point(699, 12);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(98, 42);
            this.btn_logout.TabIndex = 0;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_donate
            // 
            this.btn_donate.Location = new System.Drawing.Point(584, 12);
            this.btn_donate.Name = "btn_donate";
            this.btn_donate.Size = new System.Drawing.Size(98, 42);
            this.btn_donate.TabIndex = 1;
            this.btn_donate.Text = "Doar";
            this.btn_donate.UseVisualStyleBackColor = true;
            this.btn_donate.Click += new System.EventHandler(this.btn_donate_Click);
            // 
            // Dash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_donate);
            this.Controls.Add(this.btn_logout);
            this.Name = "Dash";
            this.ShowIcon = false;
            this.Text = "NotasApp";
            this.Load += new System.EventHandler(this.Dash_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Button btn_donate;
    }
}