using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing; //for the font
using System.Drawing.Printing; //for printing the document
using System.IO; //for file save
using System.Windows.Forms;

namespace NoteApp
{
    public partial class Dashboard : Form
    {
        DBconnection conn = new DBconnection();
        public SaveFileDialog sfd; //instance of savefiledialog to save files
        public OpenFileDialog ofd; //instance of openfiledialog to open files
        public int index; //index in text
        public static string email = Login.email; // user email from login
        DataTable DtNotesUser = new DataTable(); // user notes saved in remote


        public Dashboard()
        {
            InitializeComponent();
            sfd = new SaveFileDialog();
            ofd = new OpenFileDialog();
            richTextBox.Focus(); //focus textarea
        }

        private void Dash_Load(object sender, EventArgs e)
        {

        }

        #region menustrip "Ficheiro"
        /// <summary>
        /// Click on "New", to save the file
        /// </summary>
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Pretende salvar este ficheiro?", "Salvar", MessageBoxButtons.YesNo, MessageBoxIcon.Question); //msg, title of box, btn type, icon type
            if (dr.Equals(DialogResult.Yes))//user click on yes button           
            {
                SaveFile();
            }
        }

        /// <summary>
        ///  Click on "Abrir local" to open a file locally
        /// </summary>
        private void openLocalToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        /// <summary>
        /// click on "Guardar Local" to save file locally
        /// </summary>
        private void saveLocalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        /// <summary>
        /// Click on "Imprimir", to print the text 
        /// </summary>
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDialog printDlg = new PrintDialog();
            PrintDocument printDoc = new PrintDocument();

            printDoc.DocumentName = ofd.FileName;
            printDlg.Document = printDoc;
            printDlg.AllowSelection = true;
            printDlg.AllowSomePages = true;

            if (printDlg.ShowDialog() == DialogResult.OK) // user press ok
            {
                printDoc.Print();
            }
        }

        /// <summary>
        ///  Click on "Sair" to leave the app
        /// </summary>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Save the notes in DB
        /// </summary>
        private void saveRemoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string text = richTextBox.Text;

            if (text.Equals(""))
            {
                MessageBox.Show("Insira algo para guardar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlCommand insertCommanand = new SqlCommand("INSERT INTO notes(email,notes) VALUES(@email,@note)");
                //secure way to send data to database
                insertCommanand.Parameters.AddWithValue("@email", email);
                insertCommanand.Parameters.AddWithValue("@note", text);

                int row = conn.executeQuery(insertCommanand);

                if (row == 1)
                {
                    MessageBox.Show("Registado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ops.. ocorreu um erro, tenta novamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        /// <summary>
        /// Get the notes from DB
        /// </summary>
        private void openRemoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM notes WHERE email='" + email + "'";
            conn.readDatathroughAdapter(query, DtNotesUser);

            if (DtNotesUser.Rows.Count >= 1)
            {
                richTextBox.Text = DtNotesUser.Rows[DtNotesUser.Rows.Count - 1]["notes"].ToString();
            }
            else
            {
                MessageBox.Show("Ops.. ocorreu um erro, tenta novamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region menustrip "Editar"
        /// <summary>
        ///  Click "Anular" to undo the changes
        /// </summary>
        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Undo();
        }
        /// <summary>
        /// click "Refazer" to redo the changes
        /// </summary>
        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Redo();
        }
        /// <summary>
        /// click "Cortar" to cut the text
        /// </summary>
        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Cut();
        }
        /// <summary>
        ///  click "Copiar" to copy the text
        /// </summary>
        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Copy();
        }
        /// <summary>
        /// click "Past" to paste the copy text
        /// </summary>
        private void pastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Paste();
        }
        /// <summary>
        /// click "Selecionar tudo" to select all in the richTextBox
        /// </summary>
        private void selectAllToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            richTextBox.SelectAll();
        }
        /// <summary>
        /// click "Localizar" to find a word in the richTextBox
        /// </summary>
        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Find();
        }
        /// <summary>
        ///  click "Substituir" to replace a word in the richTextBox
        /// </summary>
        private void replaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Replace();
        }
        /// <summary>
        /// Click "data e hora" to add date time to the richTextBox
        /// </summary>
        private void dateTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.SelectedText = DateTime.Now.ToShortTimeString() + " " + DateTime.Now.ToShortDateString();
        }
        #endregion

        #region menustrip "Ferramentas"
        /// <summary>
        /// Click in "Tipo de Letra", and changes the font and text size
        /// </summary>
        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = fontDialog1.ShowDialog();
            if (result == DialogResult.OK) // see if user press ok 
            {
                Font font = fontDialog1.Font; // Get font
                this.richTextBox.Font = font; // set richTextBox properties.
            }
        }
        /// <summary>
        /// click in "Encriptação" to open the EncDecForm 
        /// </summary>
        private void encriptdecriptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EncDecFrm features = new EncDecFrm();
            features.Show();
        }
        #endregion

        #region menustrip "Ajuda"
        /// <summary>
        /// click in "Subscrição de seriço" to open payment modal
        /// </summary>
        private void donateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Donation donation = new Donation();
            donation.Show();
        }
        /// <summary>
        /// click in "Enviar comentário" to send a message to owner of program, by loading Nofitification Form
        /// </summary>
        private void sendCommentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Notification notification = new Notification();
            notification.Show();
        }
        /// <summary>
        ///  click in "Acerca" show more info about the app
        /// </summary>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" 1: Regista-te na aplicação.\n 2: Faz login na aplicação.\n 3: 30 dias para usar as \"Tootls\".\n 4: Faz Donate para continuar a usufruir das \"Tootls\".\n\n DIS NoteAPP - version 1.0.0 (beta)", "Acerca", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        #region menustrip "Logout"
        /// <summary>
        /// Click on "Logout" and closes the dashboard and open Login
        /// </summary>
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
        #endregion

        #region Function to Save File
        /// <summary>
        /// open SaveFileDialog and save the text in a txt
        /// </summary>
        private void SaveFile()
        {
            sfd.Title = "Guardar"; // set title of savefiledialog
            sfd.Filter = "Text Document|*.txt"; // applied filter
            sfd.DefaultExt = "txt"; // applied default extension
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                richTextBox.SaveFile(sfd.FileName, RichTextBoxStreamType.PlainText);
                this.Text = sfd.FileName;
            }
        }
        #endregion

        #region Function to Open File localy
        /// <summary>
        /// this open a OpenFileDialog and let user select a file
        /// </summary>
        private void OpenFile()
        {
            ofd.Title = "Abrir"; // set title of openfiledialog
            ofd.Filter = "Text Files|*.txt"; // appliing filter
            ofd.FileName = string.Empty; // setting filename box to blank
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
                    this.Text = "NotesApp - " + ofd.FileName; // set modal text name
                }
            }
        }
        #endregion

        #region Function to Find a word in richTextBox
        /// <summary>
        /// this function open a form and perform a find in the text
        /// </summary>
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

        #region Function to Replace a word in richTextBox
        /// <summary>
        /// this function opens a form and perform the replace in the text
        /// </summary>
        private void Replace()
        {
            ReplaceWord replaceform = new ReplaceWord();
            replaceform.ShowDialog();
            String findWord = replaceform.findWord; //get the word
            String replaceWord = replaceform.replaceWord; // get value to replace
            if (findWord != "")
            {
                richTextBox.Text = richTextBox.Text.Replace(findWord, replaceWord);
            }
            else
            {
                MessageBox.Show("Nada para substituir", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion


    }
}
