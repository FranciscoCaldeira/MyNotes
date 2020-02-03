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
                    MessageBox.Show("Login com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();  //Hide form
                    Dashboard dashboard = new Dashboard(); //create form
                    dashboard.Show(); //show form
                } else
                {
                    MessageBox.Show("Ops.. ocorreu um erro, tenta novamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            //clean credentials
            input_username.Text = "";
            input_password.Text = "";
        }

        //exit btn
        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit(); //DISPLATFORM
        }


        private void registarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register register = new Register();
            register.Show();
        }

        //menu strip about show box
        private void acercaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" 1: Regista-te na aplicação.\n 2: Faz login na aplicação.\n 3: 30 dias para usar as \"Tootls\".\n 4: Faz Donate para continuar a usufruir das \"Tootls\".\n\n DIS NoteAPP - version 1.0.0 (beta)", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }
    }
}
