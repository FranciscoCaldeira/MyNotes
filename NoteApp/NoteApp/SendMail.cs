using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail; // email send
using System.Net.Mime; // attach
using System.Collections;
using System.Windows.Forms;

namespace NoteApp
{
    class SendMail
    {
        /// <summary>
        /// Helper to send email. PS: this helper send email back to smtp server for seeing the mesage sent
        /// </summary>
        /// <param name="Remetente"></param>
        /// <param name="Assunto"></param>
        /// <param name="enviaMensagem"></param>
        /// <param name="anexos"></param>
        public void send_mail(string Remetente, string Assunto, string enviaMensagem, ArrayList anexos)
         {
             try
             {
                MailMessage mail = new MailMessage(); // create msg
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                //define address
                mail.From = new MailAddress("bibliotecaonline2004019@gmail.com");
                mail.To.Add("bibliotecaonline2004019@gmail.com");
                mail.Subject = Assunto;

                //define content
                string htmlBody;

                htmlBody = enviaMensagem;

                mail.Body = htmlBody + "\r\n\r\n Enviada por: "+ Remetente;
                // if exist anexos
                if (anexos.Count > 0)
                {
                    // The anexos arraylist should point to a file location where  the attachment resides - add the anexos to the message
                    foreach (string anexo in anexos)
                    {
                        Attachment anexado = new Attachment(anexo, MediaTypeNames.Application.Octet);
                        mail.Attachments.Add(anexado);
                    }
                }
                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("bibliotecaonline2004019@gmail.com", "2004019Aa123456789"); //your mail password, this was an SMTP created this year for UC ACR
                SmtpServer.EnableSsl = true;
                //Send mail
                SmtpServer.Send(mail);
                MessageBox.Show("Email enviado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
             catch (Exception ex)
             {
                 Console.WriteLine(ex.ToString());
             }
         }
    }
}
