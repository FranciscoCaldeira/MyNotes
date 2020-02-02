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

        //exit btn
        private void btn_exit_Click(object sender, EventArgs e)
        {
            //displatform
            Application.Exit();
            
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string email = input_username.Text;
            string password = input_password.Text;

            if (email.Equals(""))
            {
                MessageBox.Show("Insira o email.");
            }
            else if (password.Equals(""))
            {
                MessageBox.Show("Insira a password.");
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
                    MessageBox.Show("Login com sucesso");
                    //Hide form
                    this.Hide();
                    //create form
                    Dashboard dashboard = new Dashboard();
                    //show form
                    dashboard.Show();
                }
                else
                {
                    MessageBox.Show("Ops.. ocorreu um erro, tenta novamente!");
                }
            }
        }

        private void registarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            //create form
            Login login = new Login();
            //show form
            login.Show();
        }
    }
}
