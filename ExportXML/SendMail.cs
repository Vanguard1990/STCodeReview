using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;
using Microsoft.Exchange.WebServices.Data;
using GranitControls;

namespace ExportXML
{
    static class SendMail
    {
        public static void SendMail1(string path, string mailSender, string password, string[] MailAdressatWiele, string MailSubject, string MailBody, string SMPTclient, string SSL)
        {
            MailMessage maill = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient(SMPTclient);
            maill.From = new MailAddress(mailSender);
            foreach (string m in MailAdressatWiele)
            {
                maill.To.Add(m);
            }
            SmtpServer.EnableSsl = Convert.ToBoolean(SSL);
            maill.Subject = MailSubject;
            maill.Body = MailBody;

            System.Net.Mail.Attachment attachment;
            attachment = new System.Net.Mail.Attachment(path);
            maill.Attachments.Add(attachment);

            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential(mailSender, password);
            SmtpServer.EnableSsl = true;
            SmtpServer.Send(maill);
        }
        public static void SendMailExange(string path, string mailSender, string password, string[] MailAdressatWiele, string MailSubject, string MailBody, string SMPTclient, string NazwaDokumentu, string PocztaLogin)
        {
            try
            {
                var llWiadomosc = new EmailMessage(StworzObiektExchangeSerivce(PocztaLogin, password, SMPTclient, mailSender))
                {
                    Subject = MailSubject,
                    Body = MailBody,
                    From = mailSender,
                };
                foreach (string m in MailAdressatWiele)
                {
                    llWiadomosc.ToRecipients.Add(m);
                }
                
                EmailMessage lWiadomosc = llWiadomosc;
                if (lWiadomosc != null)
                {
                    lWiadomosc.Attachments.AddFileAttachment(path);
                        lWiadomosc.SendAndSaveCopy();

                }
            }
            catch (Exception ex)
            {
                DialogStatement.ShowError("Wystapił błąd podczas tworzenia wiadomości Exchange.\r\n" + ex.Message + ((ex.InnerException != null) ? " ----> " + ex.InnerException.Message : ""));
            }
        }
        public static ExchangeService StworzObiektExchangeSerivce(string PocztaLogin, string PocztaHaslo, string PocztaDomena, string PocztaEmail)
        {
            try
            {
                var lExchangeService = new ExchangeService();
                switch (Program.gTypPoczty)
                {
                    case "Exchange2007SP1":
                        lExchangeService = new ExchangeService(ExchangeVersion.Exchange2007_SP1);
                        break;
                    case "Exchange2010":
                        lExchangeService = new ExchangeService(ExchangeVersion.Exchange2010);
                        break;
                    case "Exchange2010SP1":
                        lExchangeService = new ExchangeService(ExchangeVersion.Exchange2010_SP1);
                        break;
                    case "Exchange2010SP2":
                        lExchangeService = new ExchangeService(ExchangeVersion.Exchange2010_SP2);
                        break;
                    case "Exchange2013":
                        lExchangeService = new ExchangeService(ExchangeVersion.Exchange2013);
                        break;
                    default:
                        break;
                }
                lExchangeService.Credentials = new WebCredentials(PocztaLogin, PocztaHaslo, PocztaDomena);
                lExchangeService.AutodiscoverUrl(PocztaEmail);
                return lExchangeService;
            }
            catch (Exception ex)
            {
                DialogStatement.ShowError("Wystapił błąd podczas tworzenia obiektu ExchangeService, sprawdź parametry pocztowe programu.\r\n" + ex.Message + ((ex.InnerException != null) ? " ----> " + ex.InnerException.Message : ""));
                return null;
            }
        }



    }
}
