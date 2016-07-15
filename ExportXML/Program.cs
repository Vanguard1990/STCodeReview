using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ExportXML
{
    static class Program
    {

        private static string _AdresIPPortDB;
        public static string gAdresIPPortDB
        {
            get
            {
                return _AdresIPPortDB;
            }
        }

        private static string _PortDB;
        public static string gPortDB
        {
            get
            {
                return _PortDB;
            }
        }

        private static string _AdresMailNadawcy;
        public static string gAdresMailNadawcy
        {
            get
            {
                return _AdresMailNadawcy;
            }
        }

        private static string _SciezkaDoPliku;
        public static string gSciezkaDoPliku
        {
            get
            {
                return _SciezkaDoPliku;
            }
        }

        private static string _HasloMailNadawcy;
        public static string gHasloMailNadawcy
        {
            get
            {
                return _HasloMailNadawcy;
            }
        }

        private static string _AdresMailAdresata;
        public static string gAdresMailAdresata
        {
            get
            {
                return _AdresMailAdresata;
            }
        }

        private static string _AdresSMPTNadawcy;
        public static string gAdresSMPTNadawcy
        {
            get
            {
                return _AdresSMPTNadawcy;
            }
        }

        private static string _PortNadawcy;
        public static string gPortNadawcy
        {
            get
            {
                return _PortNadawcy;
            }
        }

        private static string _NrFaktury;
        public static string gNrFaktury
        {
            get
            {
                return _NrFaktury;
            }
        }

        private static string _TypPoczty;
        public static string gTypPoczty
        {
            get
            {
                return _TypPoczty;
            }
        }

        private static string _PocztaLogin;
        public static string gPocztaLogin
        {
            get
            {
                return _PocztaLogin;
            }
        }

        private static string _Imie;
        public static string gImie
        {
            get
            {
                return _Imie;
            }
        }

        private static string _Nazwisko;
        public static string gNazwisko
        {
            get
            {
                return _Nazwisko;
            }
        }

        private static string _SSL;
        public static string gSSL
        {
            get
            {
                return _SSL;
            }
        }
        private static string _BazaKatalog;
        public static string gBazaKatalog
        {
            get
            {
                return _BazaKatalog;
            }
        }
        private static string _BazaUser;
        public static string gBazaUser
        {
            get
            {
                return _BazaUser;
            }
        }

        private static string _BazaPassword;
        public static string gBazaPassword
        {
            get
            {
                return _BazaPassword;
            }
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            _AdresIPPortDB = args[0]; //??????
            //_PortDB = args[1];
            _AdresMailNadawcy = args[1];
            _HasloMailNadawcy = args[2];
            _AdresMailAdresata = args[3];
            _PortNadawcy = args[4];
            _AdresSMPTNadawcy = args[5];
            _NrFaktury = args[6];
            _SciezkaDoPliku = args[7];
            _TypPoczty = args[8];
            _PocztaLogin = args[9];
            _Imie = args[10];
            _Nazwisko = args[11];
            _SSL = args[12];
            _BazaKatalog = args[13];
            _BazaUser = args[14];
            _BazaPassword = args[15];
                //            IP,//_AdresIPPortDB = args[0]; //??????
                ////Portbaza,//_AdresMailNadawcy = args[?];
                //Adres,//_AdresMailNadawcy = args[1];
                //Haslo,//_HasloMailNadawcy = args[2];
                //Mail,//_AdresMailAdresata = args[3];
                //PortPoczta,//_PortNadawcy = args[4];
                //Domena,//_AdresSMPTNadawcy = args[5];
                //Nrfaktury,//_NrFaktury = args[6];
                //sciezka,//_SciezkaDoPliku = args[7];
                //TypPoczty,//_TypPoczty = args[8];
                //PocztaLogin,// _PocztaLogin = args[9];
                //Imie,//_Imie = args[10];
                //Nazwisko,// _Nazwisko = args[11];
                //SSL, // _SSL = args[12];
                //KatalogBaza,// _KatalogBaza = args[13];
                //LoginBaza,      // _LoginBaza = args[14];
                //HasloBaza));     // _HasloBaza = args[15];







            //_AdresIPPortDB = "192.168.251.232, 1444";
            //_AdresMailNadawcy = "damian.kozlowski@hotmail.com";
            //_HasloMailNadawcy = "Harpaganto0n";
            //_AdresMailAdresata = "";
            //_PortNadawcy = "587";
            //_AdresSMPTNadawcy = "smtp.live.com";
            //_NrFaktury = "1306";
            //_SciezkaDoPliku = "C:\\_wydruk\\ExportXML1306.xml";
            //_TypPoczty = "InnyDostawca";
            //_PocztaLogin = "Damian";
            //_Imie = "Damian";
            //_Nazwisko = "Kozlowski";
            // _SSL = true;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new WaitForm());

        }
    }
}
