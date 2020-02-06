using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace NoteApp
{
    public partial class Notification : Form
    {
        ArrayList aAnexosEmail;

        SendMail sendMail = new SendMail();
        
        public Notification()
        {
            InitializeComponent();
            txtEnviadoPor.Text = Dashboard.email;
            txtEnviadoPor.Enabled = false;
        }
        /// <summary>
        /// Incluir arquivos a serem anexaso na mensagem
        /// </summary>
        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (ofd1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string[] arr = ofd1.FileNames;
                    aAnexosEmail = new ArrayList();
                    txtAnexos.Text = string.Empty;
                    aAnexosEmail.AddRange(arr);

                    foreach (string s in aAnexosEmail)
                    {
                        txtAnexos.Text += s + "; ";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }
        }
        /// <summary>
        /// Sai da aplicação
        /// </summary>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// Envia uma mensagem de mail com ou sem anexos
        /// </summary>
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtEnviadoPor.Text))
            {
                MessageBox.Show("Endereço de email do remetente é inválido.", "Erro ");
                return;
            }
            if (String.IsNullOrEmpty(txtAssuntoTitulo.Text))
            {
                MessageBox.Show("Definição do assunto inválida.", "Erro ");
                return;
            }
            if (String.IsNullOrEmpty(txtMensagem.Text))
            {
                MessageBox.Show("Mensagem inválida.", "Erro ");
                return;
            }

            //separa os anexos em um array de string
            string[] arr = txtAnexos.Text.Split(';');
            //cria um novo arraylist
            aAnexosEmail = new ArrayList();
            //percorre o array de string e inclui os anexos
            for (int i = 0; i < arr.Length; i++)
            {
                if (!String.IsNullOrEmpty(arr[i].ToString().Trim()))
                {
                    aAnexosEmail.Add(arr[i].ToString().Trim());
                }
            }

            string remetente = txtEnviadoPor.Text;
            string ass = txtAssuntoTitulo.Text;
            string msg = txtMensagem.Text;
            ArrayList anexo = aAnexosEmail;
            sendMail.send_mail(remetente, ass, msg, anexo);
        }
    }
}
