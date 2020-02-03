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
    public partial class password : Form
    {
        public string newpass;

        public password()
        {
            InitializeComponent();
            this.Text = "Set New Password";
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
                MessageBox.Show("Password doesn't match", "Error");
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
            }
        }

    }
}