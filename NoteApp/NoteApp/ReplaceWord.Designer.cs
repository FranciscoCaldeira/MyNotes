namespace NoteApp
{
    partial class ReplaceWord
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
            this.find = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.findText = new System.Windows.Forms.TextBox();
            this.replaceText = new System.Windows.Forms.TextBox();
            this.replaceBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // find
            // 
            this.find.AutoSize = true;
            this.find.Location = new System.Drawing.Point(17, 16);
            this.find.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.find.Name = "find";
            this.find.Size = new System.Drawing.Size(60, 17);
            this.find.TabIndex = 0;
            this.find.Text = "Palavra:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Substituida por:";
            // 
            // findText
            // 
            this.findText.Location = new System.Drawing.Point(207, 16);
            this.findText.Margin = new System.Windows.Forms.Padding(4);
            this.findText.Name = "findText";
            this.findText.Size = new System.Drawing.Size(155, 22);
            this.findText.TabIndex = 2;
            // 
            // replaceText
            // 
            this.replaceText.Location = new System.Drawing.Point(207, 54);
            this.replaceText.Margin = new System.Windows.Forms.Padding(4);
            this.replaceText.Name = "replaceText";
            this.replaceText.Size = new System.Drawing.Size(155, 22);
            this.replaceText.TabIndex = 3;
            // 
            // replaceBtn
            // 
            this.replaceBtn.Location = new System.Drawing.Point(131, 86);
            this.replaceBtn.Margin = new System.Windows.Forms.Padding(4);
            this.replaceBtn.Name = "replaceBtn";
            this.replaceBtn.Size = new System.Drawing.Size(100, 28);
            this.replaceBtn.TabIndex = 4;
            this.replaceBtn.Text = "Substitui";
            this.replaceBtn.UseVisualStyleBackColor = true;
            this.replaceBtn.Click += new System.EventHandler(this.replaceBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(263, 85);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(4);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(100, 28);
            this.cancelBtn.TabIndex = 5;
            this.cancelBtn.Text = "Cancelar";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // ReplaceWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 128);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.replaceBtn);
            this.Controls.Add(this.replaceText);
            this.Controls.Add(this.findText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.find);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ReplaceWord";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Substitui a palavra";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label find;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox findText;
        private System.Windows.Forms.TextBox replaceText;
        private System.Windows.Forms.Button replaceBtn;
        private System.Windows.Forms.Button cancelBtn;
    }
}