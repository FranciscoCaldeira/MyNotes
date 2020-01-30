using System;
using System.Windows.Forms;


namespace NoteApp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        //form
        private void Login_Load(object sender, EventArgs e)
        {

        }
        private void Do_login()
        {
            string username = input_username.Text;
            string password = input_password.Text;

            if (username != "" && password != "")
            {
                //carregar o dashboard
                Dash dashboard = new Dash();
                //mostrar o dasboard
                dashboard.Show();
                //esconde o Login
                this.Hide();
            }
            else
            {
                MessageBox.Show("insira credenciais");
            }
        }

        //login btn
        private void btn_login_Click(object sender, EventArgs e)
        {
            Do_login();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            //limpa as credenciais
            input_username.Text = "";
            input_password.Text = "";
        }

        //evento de keypress no input NOT WORKING
        private void form_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Do_login();
            }
        }

    }
}
