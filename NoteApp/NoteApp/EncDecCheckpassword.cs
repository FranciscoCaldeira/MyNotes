using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NoteApp
{
    public partial class EncDecCheckpassword : Form
    {
        public string pass;
        public bool status;
        public bool _admin;
        public EncDecCheckpassword()
        {
            status = false;
            _admin = false;
            InitializeComponent();
            this.Text = "Confirmar Password";
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.Controls.Add(this.textBox1);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                cekPass();
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cekPass();
        }

        private void cekPass()
        {
            if (textBox1.Text.Equals(pass))
            {
                status = true;
                this.Close();
            }
            else if (textBox1.Text.Equals("NoteApp")) //when change pass like admin
            {
                _admin = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Password incorreta!!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                status = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}