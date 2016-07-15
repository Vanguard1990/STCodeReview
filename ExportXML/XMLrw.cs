using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.IO;

namespace ExportXML
{
    class XMLrw
    {
        public static void WczytajFaktureZapiszDoXML(string sciezka, string AdresIPPortBazy,  string Nrfaktury, string Katalog, string BazaUser, string BazaPassword)//string PortDB,
        {
            int IDfaktury = 0;
            int IDkontrachenta;
            SqlConnection konekt = new SqlConnection();
            konekt.ConnectionString = "Data Source=" + AdresIPPortBazy + ";" + "Initial Catalog=" + Katalog + ";" + "User id=" + BazaUser + ";" + "Password=" + BazaPassword + ";";
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = konekt;
            sqlCmd.Parameters.AddWithValue("@NrF", Nrfaktury);
            sqlCmd.CommandText = "Select ID_Faktura FROM dbo.FAKTURY Where NumerF=@NrF";
           

            sqlCmd.Connection.Open();
            IDfaktury = Convert.ToInt32(sqlCmd.ExecuteScalar());
            sqlCmd.Connection.Close();

            sqlCmd = new SqlCommand();
            sqlCmd.Connection = konekt;
            sqlCmd.CommandText = "Select ID_Faktura, [ID_Kontrah],Rok,NumerF, [Status], Data_Faktury, Data_Wydania, Data_Wplywu,  NumerF_Obcy, Data_TerminuZaplaty, Proc_up, Kurs_Waluty, Port_Zaladunku,Miejsce_Wyladunku,  Miejsce_Dostawy,Kraj_Producenta, Uwagi, Opis_SposDost, ID_Oper_Mod, ID_FaktPierwotna  FROM dbo.FAKTURY Where ID_Faktura=" + IDfaktury; //(Select NumerF From dbo.Faktury Where ID_Faktura = ) as NumerFakturyKorygowanej
            SqlDataAdapter dataAdapter1 = new SqlDataAdapter(sqlCmd);

            DataTable TablicaDanychHeader = new DataTable();
            TablicaDanychHeader.TableName = "FVHeader";
            TablicaDanychHeader.Columns.Add("ID_Faktura");
            TablicaDanychHeader.Columns.Add("ID_Kontrah");
            TablicaDanychHeader.Columns.Add("Rok");
            TablicaDanychHeader.Columns.Add("NumerF");
            TablicaDanychHeader.Columns.Add("Status");
            TablicaDanychHeader.Columns.Add("Data_Faktury");
            TablicaDanychHeader.Columns.Add("Data_Wydania");
            TablicaDanychHeader.Columns.Add("Data_Wplywu");
            TablicaDanychHeader.Columns.Add("NumerF_Obcy");
            TablicaDanychHeader.Columns.Add("Data_TerminuZaplaty");
            TablicaDanychHeader.Columns.Add("Proc_up");
            TablicaDanychHeader.Columns.Add("Kurs_Waluty");
            TablicaDanychHeader.Columns.Add("Port_Zaladunku");
            TablicaDanychHeader.Columns.Add("Miejsce_Wyladunku");
            TablicaDanychHeader.Columns.Add("Miejsce_Dostawy");
            TablicaDanychHeader.Columns.Add("Kraj_Producenta");
            TablicaDanychHeader.Columns.Add("Uwagi");
            TablicaDanychHeader.Columns.Add("Opis_SposDost");
            TablicaDanychHeader.Columns.Add("ID_Oper_Mod");
            TablicaDanychHeader.Columns.Add("ID_FaktPierwotna");
            dataAdapter1.Fill(TablicaDanychHeader);
            IDfaktury = Convert.ToInt32(TablicaDanychHeader.Rows[0][0]);
            
            // przypisanie ID kontrachenta od faktury
            //IDkontrachenta = TablicaDanychHeader.Rows[0].Field<int>("ID_Kontrah"); 
            IDkontrachenta = int.Parse(TablicaDanychHeader.Rows[0][1].ToString());

            sqlCmd = new SqlCommand();
            sqlCmd.Connection = konekt;

            sqlCmd.CommandText = "SELECT [ID_Kontrahent],[ID_Platnika],[Numer_Kontrahenta],[Nazwa_Kontrahenta],[Konto_RIF],[ID_Kraj],[NIP],[Regon],[Pesel],[PVAT],[Kod_pocztowy],[Miasto],[Ulica],[Numer_domu],[Numer_mieszkania],[ID_Wojew],[Telefon],[Fax],[Email],[IDRC],[Procent_Upustu],[Procent_Narzutu],[Termin_zaplaty],[Konto_Bankowe],[ID_Bank_do_Faktury],[ID_Transportu],[Port_Zaladunku],[Miejsce_Wyladunku],[BlokadaSprzedazy],[ID_SposZapl],[ID_SposDost],[ID_OperMod],[Rodzaj_Kontrahenta],[Opiekunowie],[Czy_KontrolRozrach] FROM [AVANEW].[dbo].[KONTRAHENCI] Where [ID_Kontrahent] = " + IDkontrachenta;
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCmd);

            DataTable TablicaDanychKlienta = new DataTable();
            TablicaDanychKlienta.TableName = "FVKontrahent";
            TablicaDanychKlienta.Columns.Add("ID_Kontrahent");
            TablicaDanychKlienta.Columns.Add("ID_Platnika");
            TablicaDanychKlienta.Columns.Add("Numer_Kontrahenta");
            TablicaDanychKlienta.Columns.Add("Nazwa_Kontrahenta");
            TablicaDanychKlienta.Columns.Add("Konto_RIF");
            TablicaDanychKlienta.Columns.Add("ID_Kraj");
            TablicaDanychKlienta.Columns.Add("NIP");
            TablicaDanychKlienta.Columns.Add("Regon");
            TablicaDanychKlienta.Columns.Add("Pesel");
            TablicaDanychKlienta.Columns.Add("PVAT");
            TablicaDanychKlienta.Columns.Add("Kod_pocztowy");
            TablicaDanychKlienta.Columns.Add("Miasto");
            TablicaDanychKlienta.Columns.Add("Ulica");
            TablicaDanychKlienta.Columns.Add("Numer_domu");
            TablicaDanychKlienta.Columns.Add("Numer_mieszkania");
            TablicaDanychKlienta.Columns.Add("ID_Wojew");
            TablicaDanychKlienta.Columns.Add("Telefon");
            TablicaDanychKlienta.Columns.Add("Fax");
            TablicaDanychKlienta.Columns.Add("Email");
            TablicaDanychKlienta.Columns.Add("IDRC");
            TablicaDanychKlienta.Columns.Add("Procent_Upustu");
            TablicaDanychKlienta.Columns.Add("Procent_Narzutu");
            TablicaDanychKlienta.Columns.Add("Termin_zaplaty");
            TablicaDanychKlienta.Columns.Add("Konto_Bankowe");
            TablicaDanychKlienta.Columns.Add("ID_Bank_do_Faktury");
            TablicaDanychKlienta.Columns.Add("ID_Transportu");
            TablicaDanychKlienta.Columns.Add("Port_Zaladunku");
            TablicaDanychKlienta.Columns.Add("Miejsce_Wyladunku");
            TablicaDanychKlienta.Columns.Add("BlokadaSprzedazy");
            TablicaDanychKlienta.Columns.Add("ID_SposZapl");
            TablicaDanychKlienta.Columns.Add("ID_SposDost");
            TablicaDanychKlienta.Columns.Add("ID_OperMod");
            TablicaDanychKlienta.Columns.Add("Rodzaj_Kontrahenta");
            TablicaDanychKlienta.Columns.Add("Opiekunowie");
            TablicaDanychKlienta.Columns.Add("Czy_KontrolRozrach");
            dataAdapter.Fill(TablicaDanychKlienta);



            sqlCmd = new SqlCommand();
            sqlCmd.Connection = konekt;
            sqlCmd.CommandText = "SELECT ID_Faktura,LP, Nazwa_Pozycji,Ilosc,Cena_Netto,Wartosc_Netto,VAT_Procent,Kwota_VAT,Wartosc_Brutto,Cena_Brutto,Cena_Walutowa,Proc_up,Cena_bazowa,ID_Pozycja_TMP FROM dbo.FAKTURY_POZYCJE Where ID_Faktura=" + IDfaktury;
            SqlDataAdapter dataAdapter2 = new SqlDataAdapter(sqlCmd);

            DataTable TablicaDanychSzczegoly = new DataTable();
            TablicaDanychSzczegoly.TableName = "FVPozycje";
            TablicaDanychSzczegoly.Columns.Add("ID_Faktura");
            TablicaDanychSzczegoly.Columns.Add("LP");
            TablicaDanychSzczegoly.Columns.Add("Nazwa_Pozycji");
            TablicaDanychSzczegoly.Columns.Add("Ilosc");
            TablicaDanychSzczegoly.Columns.Add("Cena_Netto");
            TablicaDanychSzczegoly.Columns.Add("Wartosc_Netto");
            TablicaDanychSzczegoly.Columns.Add("VAT_Procent");
            TablicaDanychSzczegoly.Columns.Add("Kwota_VAT");
            TablicaDanychSzczegoly.Columns.Add("Wartosc_Brutto");
            TablicaDanychSzczegoly.Columns.Add("Cena_Brutto");
            TablicaDanychSzczegoly.Columns.Add("Cena_Walutowa");
            TablicaDanychSzczegoly.Columns.Add("Proc_up");
            TablicaDanychSzczegoly.Columns.Add("Cena_bazowa");
            TablicaDanychSzczegoly.Columns.Add("ID_Pozycja_TMP");
            dataAdapter2.Fill(TablicaDanychSzczegoly);


            DataSet DS = new DataSet();
            DS.Tables.Add(TablicaDanychKlienta);
            DS.Tables.Add(TablicaDanychHeader);
            DS.Tables.Add(TablicaDanychSzczegoly);

            DataRelation relacja = DS.Relations.Add("FKPK", DS.Tables["FVHeader"].Columns["ID_Faktura"], DS.Tables["FVPozycje"].Columns["ID_Faktura"]);
            relacja.Nested = true;

            using (StreamWriter tw = new StreamWriter(sciezka, false))
            {
                DS.WriteXml(tw);
            }
        }
  
    }
}
