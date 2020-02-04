using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace NoteApp
{
    public partial class Register : Form
    {
        //connection to local database
        DBconnection conn = new DBconnection();

        public Register()
        {
            InitializeComponent();
        }

        #region ToolStripMenuItem click
        /// <summary>
        /// Click in Login
        /// </summary>
        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }
        /// <summary>
        /// Click in About
        /// </summary>
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" 1: Regista-te na aplicação.\n 2: Faz login na aplicação.\n 3: 30 dias para usar as \"Tootls\".\n 4: Faz Donate para continuar a usufruir das \"Tootls\".\n\n DIS NoteAPP - version 1.0.0 (beta)", "Acerca", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        #region btn clicks
        /// <summary>
        /// btn reset, to reset the inputs 
        /// </summary>
        private void btn_reset_Click(object sender, EventArgs e)
        {
            input_username.Text = "";
            input_password.Text = "";
        }
        /// <summary>
        /// btn to exit aplication
        /// </summary>
        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// click in register
        /// </summary>
        private void btn_register_Click(object sender, EventArgs e)
        {
            Do_registration();
        }
        #endregion

        #region Function do user registration
        /// <summary>
        /// validate, and insert data in DB
        /// </summary>
        private void Do_registration()
        {
            string email = input_username.Text;
            string password = input_password.Text;

            if (email.Equals(""))
            {
                MessageBox.Show("Insira o email.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (password.Equals(""))
            {
                MessageBox.Show("Insira a password.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlCommand insertCommanand = new SqlCommand("INSERT INTO users(email,password) VALUES(@email,@password)");
                //secure way to send data to database
                insertCommanand.Parameters.AddWithValue("@email", email);
                insertCommanand.Parameters.AddWithValue("@password", password);

                int row = conn.executeQuery(insertCommanand);

                if (row == 1)
                {
                    MessageBox.Show("Registo com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Dashboard dashboard = new Dashboard();
                    dashboard.Show();
                }
                else
                {
                    MessageBox.Show("Ops.. ocorreu um erro, tenta novamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        #endregion
    }
}
