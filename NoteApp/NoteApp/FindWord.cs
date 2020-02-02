using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteApp
{
    public partial class FindWord : Form
    {
        private String findWord;//store word to find 
        public FindWord()
        {
            InitializeComponent();
        }

        #region btn logic 
        private void btn_next_Click(object sender, EventArgs e)
        {
            findWord = input_find.Text;
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            findWord = "";
            this.Close();
        }
        #endregion

        #region function word to find 
        public String getFindWord()
        {
            return findWord;
        }
        #endregion
    }
}
