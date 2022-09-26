using SistemaVendas.DAO;
using System;
using System.Net.Mail;
using System.Runtime.InteropServices;

namespace SistemaVendas.Model
{
    public class Email_emitente
    {
        // senha gmail apps terceiros = hcgbxrlvncwlhyup
        public string ServidorSMTP { get; private set; }
        public string Email { get; private set; }
        public string SenhaEmail { get; private set; }
        public int Porta { get; private set; }
        public bool EnableSSL { get; private set; }
        private readonly Email_emitenteDAO _emitenteDAO = new Email_emitenteDAO();

        public Email_emitente ()
        {
        }

        public Email_emitente (string servidorSMTP, string email, string senhaEmail, int porta, bool enableSSL)
        {
            ServidorSMTP = servidorSMTP;
            Email = email;
            SenhaEmail = senhaEmail;
            Porta = porta;
            EnableSSL = enableSSL;
        }

        public void EnviarEmail (Email_emitente email_emitente, string assunto, string corpoEmail, string destinatario, [Optional] string anexo, bool isHTML = false)
        {
            try
            {
                using (SmtpClient smtp = new SmtpClient())
                {
                    using (MailMessage email = new MailMessage())
                    {
                        // Servidor SMTP
                        smtp.Host = email_emitente.ServidorSMTP;
                        smtp.UseDefaultCredentials = false;
                        smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                        smtp.Credentials = new System.Net.NetworkCredential(email_emitente.Email, email_emitente.SenhaEmail);//"uuotwnwzihdmgfek");
                        smtp.Port = email_emitente.Porta;
                        smtp.EnableSsl = email_emitente.EnableSSL;

                        // Email
                        email.From = new MailAddress(email_emitente.Email);
                        email.To.Add(destinatario);

                        email.Subject = assunto;
                        email.IsBodyHtml = isHTML;
                        email.Body = corpoEmail;
                        if (anexo != null)
                            email.Attachments.Add(new Attachment(anexo));

                        // Envia o email
                        smtp.Send(email);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void InsertEmail (Email_emitente emitente)
        {
            _emitenteDAO.InsertEmail(emitente);
        }

        public Email_emitente SelectEmail ()
        {
            return _emitenteDAO.SelectEmail();
        }
    }
}
