using System;
using System.Windows.Forms;

namespace NoteApp
{
    public partial class Donation : Form
    {

        public static Boolean checkbox_terms;
        public Donation()
        {
            InitializeComponent();
        }

        private void btn_pay_Click(object sender, EventArgs e)
        {
            string name = input_name.Text;
            string nif = input_nif.Text;
            string country = input_country.Text;
            string address = input_country.Text;
            //check_terms.Checked


            if (name.Equals(""))
            {
                MessageBox.Show("Insira o nome.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (nif.Equals(""))
            {
                MessageBox.Show("Insira o nif.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (country.Equals(""))
            {
                MessageBox.Show("Insira o país.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (address.Equals(""))
            {
                MessageBox.Show("Insira a morada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }else if (check_terms.Checked)
            {
                //save
            } else
            {
                MessageBox.Show("Aceite os termos e condições.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
