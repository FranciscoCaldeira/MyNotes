using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace NoteApp
{
    public partial class EncDecSetpassword : Form
    {
        public string newpass;

        public EncDecSetpassword()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals(textBox2.Text))
            {
                newpass = textBox1.Text;
                this.Close();
            }
            else
            {
                MessageBox.Show("Password não coincidem.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
            }
        }

    }
}