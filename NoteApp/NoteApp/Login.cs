using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace NoteApp
{
    public partial class Login : Form
    {
        //connection to local database
        DBconnection conn = new DBconnection();

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Do_login()
        {
            string email = input_username.Text;
            string password = input_password.Text;

            if (email.Equals(""))
            {
                MessageBox.Show("Insira o email.");
            } else if (password.Equals(""))
            {
                MessageBox.Show("Insira a password.");
            } else
            {
                SqlCommand insertCommanand = new SqlCommand("INSERT INTO users(email,password) VALUES(@email,@password)");
                //secure way to send data to database
                insertCommanand.Parameters.AddWithValue("@email", email);
                insertCommanand.Parameters.AddWithValue("@password", password);

                int row = conn.executeQuery(insertCommanand);

                if(row == 1)
                {
                    MessageBox.Show("Login com sucesso");
                    //Hide form
                    this.Hide();
                    //create form
                    Dashboard dashboard = new Dashboard();
                    //show form
                    dashboard.Show();
                } else
                {
                    MessageBox.Show("Ops.. ocorreu um erro, tenta novamente!");
                }
            }
        }

        //login btn
        private void btn_login_Click(object sender, EventArgs e)
        {
            Do_login();
        }

        //evento de keypress no input password
        private void form_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Do_login();
            }
        }

        //reset btn
        private void btn_reset_Click(object sender, EventArgs e)
        {
            //limpa as credenciais
            input_username.Text = "";
            input_password.Text = "";
        }

        //exit btn
        private void btn_exit_Click(object sender, EventArgs e)
        {
            //displatform
            Application.Exit();
        }


        private void registarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            //create form
            Register register = new Register();
            //show form
            register.Show();
        }

        //menu strip about show box
        private void acercaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //msg, title, tipo de button, tipo de icon
            MessageBox.Show(" 1: Regista-te na aplicação.\n 2: Faz login na aplicação.\n 3: 30 dias para usar as \"Tootls\".\n 4: Faz Donate para continuar a usufruir das \"Tootls\".\n\n DIS NoteAPP - version 1.0.0 (beta)", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }
    }
}
