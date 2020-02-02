﻿using System;
using System.Drawing; //for the font
using System.Drawing.Printing; //for printing
using System.IO; //for file save
using System.Windows.Forms;

namespace NoteApp
{
    public partial class Dashboard : Form
    {
        public SaveFileDialog sfd;//instance of savefiledialog to save files
        public OpenFileDialog ofd;//instance of openfiledialog to open files
        public int index; //???

        public Dashboard()
        {
            InitializeComponent();
            sfd = new SaveFileDialog();
            ofd = new OpenFileDialog();

            this.Text = "NotesApp - Sem título";
            richTextBox.TabIndex = 5;
            undoToolStripMenuItem.Enabled = false;
            richTextBox.Focus();
        }

        private void Dash_Load(object sender, EventArgs e)
        {

        }

        #region menustrip "Ficheiro"
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sfd.Title = "Save";
            //msg, title, btn type, icon type
            DialogResult dr = MessageBox.Show("Pretende salvar este ficheiro?", "Salvar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr.Equals(DialogResult.Yes))//user click on yes button           
            {
                SaveFile();//calling user defined function SaveFile function
                //richTextBox1.Clear();
                //this.Text = "Untitled-Digital Diary";
            }
            else if (dr.Equals(DialogResult.No))//user click on no button
            {
                //richTextBox.Clear();
                //this.Text = "NotesApp - Sem título";
            }
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDialog printDlg = new PrintDialog();
            PrintDocument printDoc = new PrintDocument();

            printDoc.DocumentName = ofd.FileName;
            printDlg.Document = printDoc;
            printDlg.AllowSelection = true;
            printDlg.AllowSomePages = true;
            //user press ok
            if (printDlg.ShowDialog() == DialogResult.OK)
                printDoc.Print();
        }

        //sair
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveLocalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string fileName = saveFileDialog1.FileName;
            string textNote = richTextBox.Text;

            if (textNote.Equals(""))
            {
                MessageBox.Show("Erro, precisa inserir notas para guardar ficheiro.");
            }
            else
            {
                File.WriteAllText(fileName, textNote);
            }
        }

        #endregion

        #region menustrip "Editar"
        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Undo();
        }
        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Redo();
        }
        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Cut();
        }
        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Copy();
        }
        private void pastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Paste();
        }
        private void selectAllToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }
        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Find();
        }
        #endregion

        #region menustrip "Tools"
        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //show dialog
            DialogResult result = fontDialog1.ShowDialog();
            //see if ok press
            if (result == DialogResult.OK)
            {
                //Get font
                Font font = fontDialog1.Font;
                //set richTextBox properties.
                this.richTextBox.Text = string.Format("Font is: {0}", font.Name);
                this.richTextBox.Font = font;
            }
        }
        #endregion

        #region menustrip "Help"
        //open donation modal
        private void donateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Donation donation = new Donation();
            donation.Show();
        }
        #endregion

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        #region "Function Save File"
        private void SaveFile()
        {
            sfd.Title = "Guardar como"; //set title of savefiledialog
            sfd.Filter = "Text Document|*.txt";//applied filter
            sfd.DefaultExt = "txt";//applied default extension
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                // if (this.Text!= "Untitled-Digital Diary") {
                //    richTextBox1.SaveFile(this.Text, RichTextBoxStreamType.PlainText);
                //}
                //  else if(this.Text=="Untitled-Digital Diary")
                //{
                richTextBox.SaveFile(sfd.FileName, RichTextBoxStreamType.PlainText);
                this.Text = sfd.FileName;
                // } }
            }
        }
        #endregion

        #region "Function to Open File to review"
        private void OpenFile()
        {
            ofd.Title = "Abrir";//set title of openfiledialog
            //ofd.DefaultExt = "txt";
            ofd.Filter = "Text Files|*.txt";//appliing filter
            ofd.FileName = string.Empty;//setting filename box to blank
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (ofd.FileName == String.Empty)
                {
                    return;
                }
                else
                {
                    string str = ofd.FileName; //loading selected file into richtextbox
                    richTextBox.LoadFile(str, RichTextBoxStreamType.PlainText);
                    this.Text = ofd.FileName;
                }
            }
        }
        #endregion

        #region function find
        private void Find()
        {
            FindWord fw = new FindWord();
            fw.ShowDialog();
            if (fw.getFindWord() != "")
            {
                int index = 0;
                while (index != -1 && index < richTextBox.Text.Length)
                {
                    // Searches the text in a RichTextBox control for a string within a range of text withing the control and with specific options applied to the search.
                    index = richTextBox.Text.IndexOf(fw.getFindWord(), index);
                    if (index != -1)
                    {
                        richTextBox.Select(index, fw.getFindWord().Length);
                        // After a match is found the index is increased so the search won't stop at the same match again. This makes possible to highlight same words at the same time.
                        index++;
                        fw.ShowDialog();
                    }
                }
            }
            MessageBox.Show("Fim do ficheiro");
        }
        #endregion

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        
    }
}