using System;
using System.Windows.Forms;

namespace NoteApp
{
    public partial class Dash : Form
    {
        public Dash()
        {
            InitializeComponent();
        }

        private void Dash_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            //esconde o Login
            this.Hide();
        }

        private void btn_donate_Click(object sender, EventArgs e)
        {
            Donation donation = new Donation();
            donation.Show();
        }
    }
}
