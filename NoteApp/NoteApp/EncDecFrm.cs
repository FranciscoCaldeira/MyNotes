using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;
using CyberCrypt;

namespace NoteApp
{
    public partial class EncDecFrm : MetroFramework.Forms.MetroForm
    {
        #region "DECLARATION"

        bool _FILEencrypt, _FOLDERlock;
        string strFileEncrypt, strFileDecrypt, strFolder, strUnivPassword, strPCName, strFolderOri, strFolderState, strFolderProgramData, strHimbara_p, strHimbara_f;
        string strTSLock = ".takje"; // random name extension
        string strFile_p = "himbara_p.takje"; // save password in random name file
        string strfile_f = "himbara_f.takje"; // save log files lock in random name file
        string strConfig = "NoteApp"; //Program password to encrypt and decrypt the real password 
        public string status;
        string[] arr;
        #endregion

        #region"GLOBAL"
        /// <summary>
        /// set a password if don't find folder with user pass 
        /// </summary>
        public void loadConfig()
        {
            //Load Password
            if (File.Exists(strHimbara_p))
            {
                CyberCrypt._AES256.DecryptFile(strHimbara_p, strConfig);
                using (StreamReader r = File.OpenText(strHimbara_p))
                {
                    string line;
                    while ((line = r.ReadLine()) != null)
                    {
                        strUnivPassword = line;
                    }
                    r.Close();
                }
                CyberCrypt._AES256.EncryptFile(strHimbara_p, strConfig);
            }
            else
            {
                MessageBox.Show("Insira a password para encriptação", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                setpassword();
            }
        }


        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (checkpassword())
            {
                ((Control)this.tabPage2).Enabled = true;
                ((Control)this.tabPage3).Enabled = true;
                toolStripMenuItem1.Enabled = false;
                metroLabel2.Text = strPCName + " sessão iniciada, podes utilizar a ferramenta.";
                //Load Folder LOG DataGridView
                if (File.Exists(strHimbara_f))
                {
                    CyberCrypt._AES256.DecryptFile(strHimbara_f, strConfig);
                    using (StreamReader rb = File.OpenText(strHimbara_f))
                    {
                        string lines;
                        string[] values;
                        while (!rb.EndOfStream)
                        {
                            lines = rb.ReadLine();
                            values = lines.Split('>');
                            if (dataGridView1.RowCount == 0)
                                dataGridView1.Rows.Add(0, values[0], values[1]);
                            else
                                dataGridView1.Rows.Insert(0, values[0], values[1]);
                        }
                        rb.Close();
                    }
                    CyberCrypt._AES256.EncryptFile(strHimbara_f, strConfig);
                }
            }
            else
            {
                ((Control)this.tabPage2).Enabled = false;
                ((Control)this.tabPage3).Enabled = false;
                toolStripMenuItem1.Enabled = true;
                metroLabel2.Text = strPCName + " faz login para utilizar a ferramenta";
            }
        }
        #endregion

        #region"INITLOAD"

        public EncDecFrm()
        {
            InitializeComponent();

            arr = new string[1];
            status = "";
            arr[0] = ".{2559a1f2-21d7-11d4-bdaf-00c04f60b9f0}"; //to put in folder name *******************simplificar passa pa cima********

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            strFolderProgramData = "C:\\ProgramData\\NoteApp\\"; //path to save your key to enc/dec

            //https://www.youtube.com/watch?v=9zQzRAx66aM
            if (!Directory.Exists(strFolderProgramData))
            {
                Directory.CreateDirectory(strFolderProgramData);
            }

            strHimbara_p = strFolderProgramData + strFile_p;
            strHimbara_f = strFolderProgramData + strfile_f;

            _FILEencrypt = false;
            _FOLDERlock = false;
            btnFileEncrypt.Enabled = false;
            btnFolderLock.Enabled = false;

            toolStripStatusLabel1.BackColor = Color.White;
            toolStripStatusLabel1.Text = "";
            toolStripStatusLabel2.BackColor = Color.White;
            toolStripStatusLabel2.Text = "";

            strPCName = Environment.MachineName; // pc MachineName
            metroLabel2.Text = "Olá " + strPCName + " por favor faça login para utilizar a ferramenta";
            metroTabControl1.SelectedIndex = 2;

            loadConfig();

            ((Control)this.tabPage2).Enabled = false;
            ((Control)this.tabPage3).Enabled = false;
            toolStripMenuItem1.Enabled = true;
        }

        private void setPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool chk = checkpassword();
            if (chk)
                setpassword();

        }
        #endregion

        #region "FILELOCK"

        private void txtBrowse_ButtonClick(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "All Files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (!string.IsNullOrEmpty(openFileDialog1.FileName))
                {
                    MessageBox.Show("Ficheiro existe: " + openFileDialog1.FileName, "Info");
                    txtBrowse.Text = openFileDialog1.FileName;

                    string fullPath = openFileDialog1.FileName;
                    string fileNameExt = openFileDialog1.SafeFileName;
                    string dirPath = fullPath.Replace(fileNameExt, "");

                    if (fullPath.Contains(strTSLock))
                    {
                        _FILEencrypt = true;
                        btnFileEncrypt.Text = "Decrypt";
                        string fileTakje = fileNameExt.Substring(0, fileNameExt.Length - 6);
                        strFileEncrypt = openFileDialog1.FileName;
                        strFileDecrypt = fullPath.Replace(fileNameExt, fileTakje);
                    }
                    else
                    {
                        _FILEencrypt = false;
                        btnFileEncrypt.Text = "Encrypt";
                        strFileEncrypt = fullPath.Replace(fileNameExt, fileNameExt + strTSLock);
                        strFileDecrypt = openFileDialog1.FileName;
                    }
                    btnFileEncrypt.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Ficheiro não existe", "Info");
                    _FILEencrypt = false;
                    btnFileEncrypt.Text = "Encrypt";
                    btnFileEncrypt.Enabled = false;
                }
            }
        }

        /// <summary>
        /// Decrypt and Encrypt FILES
        /// </summary>
        private void btnFileEncrypt_Click(object sender, EventArgs e)
        {
            if (_FILEencrypt)
            {
                _FILEencrypt = false;
                System.IO.File.Move(strFileEncrypt, strFileDecrypt);
                CyberCrypt._AES256.DecryptFile(strFileDecrypt, strUnivPassword);
                toolStripStatusLabel1.Text = "[DECRYPT SUCCESS]";
                toolStripStatusLabel1.BackColor = Color.Green;
                //toolStrip msg folder clear and hide
                toolStripStatusLabel2.Text = "";
                toolStripStatusLabel2.BackColor = Color.White;
            }
            else
            {
                _FILEencrypt = true;
                System.IO.File.Move(strFileDecrypt, strFileEncrypt);
                CyberCrypt._AES256.EncryptFile(strFileEncrypt, strUnivPassword);
                toolStripStatusLabel1.Text = "[ENCRYPT SUCCESS]";
                toolStripStatusLabel1.BackColor = Color.Green;
                //toolStrip msg folder clear and hide
                toolStripStatusLabel2.Text = "";
                toolStripStatusLabel2.BackColor = Color.White;
            }
            txtBrowse.Clear();
            btnFileEncrypt.Enabled = false;
            btnFileEncrypt.Text = "Encrypt";
        }

        #endregion

        #region "FOLDERLOCK"

        private void btnFolderLock_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(strFolder))
            {
                DirectoryInfo d = new DirectoryInfo(strFolder);
                string selectedpath = d.Parent.FullName + d.Name;
                if (_FOLDERlock)
                {
                    //Unlock               
                    _FOLDERlock = false;
                    status = getstatus(status);
                    d.MoveTo(strFolder.Substring(0, strFolder.LastIndexOf(".")));
                    strFolder = strFolder.Substring(0, strFolder.LastIndexOf("."));
                    toolStripStatusLabel2.Text = "[UNLOCK SUCCESS]";
                    toolStripStatusLabel2.BackColor = Color.Green;
                    toolStripStatusLabel1.Text = ""; //added
                    toolStripStatusLabel1.BackColor = Color.White; //added
                    strFolderOri = strFolder;
                    strFolderState = "Unlock";
                }
                else
                {
                    //Lock
                    strFolderOri = strFolder;
                    _FOLDERlock = true;
                    if (!d.Root.Equals(d.Parent.FullName))
                        d.MoveTo(d.Parent.FullName + "\\" + d.Name + status);
                    else d.MoveTo(d.Parent.FullName + d.Name + status);
                    toolStripStatusLabel2.Text = "[LOCK SUCCESS]";
                    toolStripStatusLabel2.BackColor = Color.Green;
                    toolStripStatusLabel1.Text = ""; //added
                    toolStripStatusLabel1.BackColor = Color.White; //added
                    strFolderState = "Locked";
                }
                btnFolderLock.Text = "Lock";
                btnFolderLock.Enabled = false;
                datagridUpdate(strFolderOri, strFolderState);
            }
            else
            {
                MessageBox.Show("Pasta não existe", "Info");
            }  
        }

        private void btnAddFolder_Click(object sender, EventArgs e)
        {
            status = arr[0];
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                if (!string.IsNullOrEmpty(folderBrowserDialog1.SelectedPath))
                {
                    strFolder = folderBrowserDialog1.SelectedPath;
                    btnFolderLock.Enabled = true;
                    if (folderBrowserDialog1.SelectedPath.LastIndexOf(".{") == -1)
                    {
                        _FOLDERlock = false;
                        btnFolderLock.Text = "Lock";
                        strFolderState = "Unlock";
                        strFolderOri = strFolder;
                    }
                    else
                    {
                        _FOLDERlock = true;
                        btnFolderLock.Text = "Unlock";
                        strFolderState = "Locked";
                        string pool = strFolder.Substring(0, folderBrowserDialog1.SelectedPath.LastIndexOf("."));
                        strFolderOri = pool.ToString();
                    }
                    MessageBox.Show("Pasta existe: " + strFolderOri, "Information");
                }
                else
                {
                    MessageBox.Show("Pasta não existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _FOLDERlock = false;
                    btnFolderLock.Enabled = false;
                    btnFolderLock.Text = "Lock";
                    strFolderState = "Unlock";
                    strFolderOri = null;
                }
            }
            datagridUpdate(strFolderOri, strFolderState);
            strFolderOri = null;
        }

        public void datagridUpdate(string directory, string state)
        {
            bool containing = false;
            string strDirectory = directory;
            string strState = state;
            if ((dataGridView1.RowCount > 1) && (strDirectory != null))
            {
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
               
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                    try
                    {
                        if (row.Cells[0].Value.ToString().Equals(strDirectory.ToString()))
                        {
                            row.Selected = true;
                            containing = true;
                            row.Cells[1].Value = strState;
                            break;
                        }
                    }
                    catch
                    {
                        continue;
                    }
                }
            }

            if ((!containing) && (strDirectory != null))
            {
                if (dataGridView1.RowCount < 1)
                    dataGridView1.Rows.Add(0, strDirectory, strState);
                else
                    dataGridView1.Rows.Insert(0, strDirectory, strState);
            }

            //Creat LOG
            if (dataGridView1.RowCount > 1)
            {
                StreamWriter wb = new StreamWriter(strHimbara_f);
                string lines;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                    try
                    {
                        lines = "";
                        lines = row.Cells[0].Value.ToString();
                        lines += ">";
                        lines += row.Cells[1].Value.ToString();
                        wb.WriteLine(lines);
                    }
                    catch 
                    {
                        continue;
                    }
                }
                
                wb.Flush();
                wb.Close();
                CyberCrypt._AES256.EncryptFile(strHimbara_f, strConfig);
            }
            if (dataGridView1.RowCount == 0)
            {
                if (File.Exists(strHimbara_f))
                    File.Delete(strHimbara_f);
            }
            return;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (dgv == null)
                return;
            if (dgv.CurrentCell.Value == null)
                return;
            if (dgv.CurrentRow.Selected)
            {
                if (dgv.CurrentRow.Cells[1].Value.ToString() == "Locked")
                {
                    _FOLDERlock = true;
                    btnFolderLock.Text = "Unlock";
                    strFolderState = "Locked";
                    strFolderOri = dgv.CurrentRow.Cells[0].Value.ToString();
                    strFolder = strFolderOri.Replace(strFolderOri, strFolderOri + arr[0]);
                }
                else
                {
                    _FOLDERlock = false;
                    btnFolderLock.Text = "Lock";
                    strFolderState = "Unlock";
                    strFolderOri = dgv.CurrentRow.Cells[0].Value.ToString();
                    strFolder = strFolderOri;
                }
                btnFolderLock.Enabled = true;
            }
        }

        private void btnListClear_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows == null)
                return;
            if (dataGridView1.CurrentCell.Value == null)
                return;
            else
            {
                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                datagridUpdate(null, null);
            }
        }

        void myAdmin()
        {
            if (File.Exists(strHimbara_p))
            {
                CyberCrypt._AES256.DecryptFile(strHimbara_p, strConfig);
                using (StreamReader r = File.OpenText(strHimbara_p))
                {
                    string line;
                    while ((line = r.ReadLine()) != null)
                    {
                        strUnivPassword = line;
                    }
                    r.Close();
                }
                CyberCrypt._AES256.EncryptFile(strHimbara_p, strConfig);
            }
            return;
        }

        private bool checkpassword()
        {
            EncDecCheckpassword c = new EncDecCheckpassword(); //form confirmar password
            c.pass = strUnivPassword;
            if (c.ShowDialog() == DialogResult.OK)
            {
                return c.status;
            }
            if (c._admin)
                myAdmin();
            return c.status;
        }

        /// <summary>
        /// Set a password in a document file in ProgramData directory
        /// </summary>
        /// <returns> boolean true</returns>
        private Boolean setpassword()
        {
            EncDecSetpassword p = new EncDecSetpassword(); //load form to set new password
            p.ShowDialog(); //show the modal form
            using (StreamWriter w = File.CreateText(strHimbara_p)) //puts the password in this file
            {
                w.WriteLine(p.newpass);
                strUnivPassword = p.newpass;
                w.Flush();
                w.Close();//clear and close the buffer
            }
            CyberCrypt._AES256.EncryptFile(strHimbara_p, strConfig); //use path file and program password to Encrypt file
            return true;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="stat"></param>
        /// <returns></returns>
        private string getstatus(string stat)
        {
            if (stat.LastIndexOf(arr[0]) != -1)
                stat = stat.Substring(stat.LastIndexOf("."));
            return stat;
        }
        #endregion

    }

}

