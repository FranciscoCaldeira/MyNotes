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


        //verifica a checkbox do formulário
        private void check_terms_CheckedChanged(object sender, EventArgs e)
        {
            if (check_terms.Checked)
            {

            }
        }

    }
}
