using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Net.Mail;
using GranitControls;
using DevComponents.DotNetBar;
using AvaDDB.BazaDanych;


namespace ExportXML
{
    public partial class WaitForm : Form
    {
        public WaitForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tbxAdresEmail.Text = Program.gAdresMailAdresata.ToString()+";";
            tbxTemat.Text = "Faktura VAT nr " + Program.gNrFaktury + " jako XML";
            tbxTrescWiadomosci.Text = String.Format("Szanowni Państwo \r\n   Przesyłam fakturę numer {0} w formie pliku XML. \r\n \r\n Pozdrawiam \r\n {1} {2}",Program.gNrFaktury, Program.gImie ,Program.gNazwisko);
            try
            {
                XMLrw.WczytajFaktureZapiszDoXML(Program.gSciezkaDoPliku, Program.gAdresIPPortDB,Program.gNrFaktury,Program.gBazaKatalog,Program.gBazaUser,Program.gBazaPassword );
            }
            catch (Exception ex)
            {
                DialogStatement.ShowError(string.Format("Wystąpił błąd podczas odczytywania danych z bazy lub zapisywania pliku XML na dysku \n{0} {1}", ex.Message, ((ex.InnerException != null) ? " ----> " + ex.InnerException.Message : "")));
            }
        }

        private void btniWyslij_Click(object sender, EventArgs e)
        {
            //using System.Net.Mail; Nie nadaje się dla Exchange
            try
            {
                string MailSubject = tbxTemat.Text.ToString();
                string MailBody = tbxTrescWiadomosci.Text.ToString();
                string MailAdresata = tbxAdresEmail.Text.ToString();
                MailAdresata = MailAdresata.Replace(" ", "");
                char[] dzielnik = { ';' };
                string[] MailAdresataWiele = MailAdresata.Split(dzielnik);

                if (Program.gTypPoczty == "InnyDostawca")
                {
                    if (Program.gAdresMailNadawcy == null || Program.gHasloMailNadawcy == null || Program.gAdresSMPTNadawcy == null)
                    {
                        MessageBox.Show("Brak wszystkich ustawień do wysłania maila");
                    }
                    else
                    {
                        SendMail.SendMail1(Program.gSciezkaDoPliku, Program.gAdresMailNadawcy, Program.gHasloMailNadawcy, MailAdresataWiele, MailSubject, MailBody, Program.gAdresSMPTNadawcy, Program.gSSL);
                    }
                }
                else
                {
                    if (Program.gAdresMailNadawcy == null || Program.gHasloMailNadawcy == null || Program.gAdresMailAdresata == null || Program.gAdresSMPTNadawcy == null || Program.gNrFaktury == null || Program.gPocztaLogin == null || Program.gAdresMailAdresata == null)
                    {
                        MessageBox.Show("Brak wszystkich ustawień do wysłania maila");
                    }
                    else
                    {
                        SendMail.SendMailExange(Program.gSciezkaDoPliku, Program.gAdresMailNadawcy, Program.gHasloMailNadawcy, MailAdresataWiele, MailSubject, MailBody, Program.gAdresSMPTNadawcy, Program.gNrFaktury, Program.gPocztaLogin);
                    }
                }
                DialogStatement.ShowInfo("Wiadomość została wysłana poprawnie");
                DialogResult = DialogResult.OK;

            }
            catch (Exception ex)
            {
                DialogStatement.ShowError(string.Format("Wystąpił błąd podczas wysyłania maila z załącznikiem XML. Upewnij się, że podany e-mail adresata jest prawidłowy. Kolejne adresy powinne być oddzielone średnikiem ';'. \n{0} {1}", ex.Message, ((ex.InnerException != null) ? " ----> " + ex.InnerException.Message : "")));
            }
            Close();
        }

        private void btniAnuluj_Click(object sender, EventArgs e)
        {
            Close();
        }

   }

}




