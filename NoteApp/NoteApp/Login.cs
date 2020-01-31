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

        //evento de keypress no input password
        private void form_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Do_login();
            }
        }

        //menu strip about show box
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //msg, title, tipo de button, tipo de icon
            MessageBox.Show(" 1: Regista-te na aplicação.\n 2: Faz login na aplicação.\n 3: 30 dias para usar as \"Tootls\".\n 4: Faz Donate para continuar a usufruir das \"Tootls\".\n\n DIS NoteAPP - version 1.0.0 (beta)", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


    }
}
