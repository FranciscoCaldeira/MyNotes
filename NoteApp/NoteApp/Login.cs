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
        DataTable DtUsers = new DataTable();
        Validator validator = new Validator();
        public static string email;

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        #region ToolStripMenuItem click
        /// <summary>
        /// menu strip Registar show other form
        /// </summary>
        private void registarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register register = new Register();
            register.Show();
        }

        /// <summary>
        /// menu strip about show box
        /// </summary>
        private void acercaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" 1: Regista-te na aplicação.\n 2: Faz login na aplicação.\n 3: 30 dias para usar as \"Tootls\".\n 4: Faz Donate para continuar a usufruir das \"Tootls\".\n\n DIS NoteAPP - version 1.0.0 (beta)", "Acerca", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        #region keyPress on form
        /// <summary>
        /// event de keypress enter on the form
        /// </summary>
        private void form_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Do_login();
            }
        }
        #endregion

        #region btn clicks
        /// <summary>
        /// Click in the login btn
        /// </summary>
        private void btn_login_Click(object sender, EventArgs e)
        {
            Do_login();
        }
        /// <summary>
        /// btn reset, to reset the inputs 
        /// </summary>
        private void btn_reset_Click(object sender, EventArgs e)
        {
            //clean credentials
            input_username.Text = "";
            input_password.Text = "";
        }
        /// <summary>
        /// click exit btn to exit aplication
        /// </summary>
        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region Function do the login
        private void Do_login()
        {
            email = input_username.Text; // this email is going to the next page
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
                string query = "SELECT * FROM users WHERE email='" + email + "' AND password='" + password + "'";
                conn.readDatathroughAdapter(query, DtUsers);

                if(DtUsers.Rows.Count == 1)
                {
                    MessageBox.Show("Login com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.closeConn();
                    this.Hide();  //Hide form
                    Dashboard dashboard = new Dashboard(); //create form
                    dashboard.Show(); //show form
                }
                else
                {
                    MessageBox.Show("Ops.. ocorreu um erro, tenta novamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion
    }
}
