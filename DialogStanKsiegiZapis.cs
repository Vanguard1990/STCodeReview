using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using DevComponents.AdvTree;
using DevComponents.DotNetBar;
using GranitControls;
using GranitExceptions;
using GranitSettings;
using GranitControls;


namespace GranitSkarbGUI
{
    public partial class DialogStanKsiegiZapis : GranitControls.DialogGranit
    {
        #region Zmienne
        private string KontoNR;
        private string NazwaKonta;
        private string Waluta;
        private string KOD;
        private string WinienWaluta;
        private string MaWaluta;
        private string NrPaczki;
        //private string RokKonta;
        private string IDzapisu;
        private string IDdokumentu;
        private string IDkonta;
        private string IDpaczki;
        private string TrescZapisu;
        //private string DataDokumentu;
        private string MiesiacPaczki;
        private double PerSaldoWnMa;
        private int IndeksWiersza;
        private bool CzyPaczka;
        DataGridView _dataGridZapisy;
        DataGridView _dataGridPerSaldoDokumenty;
        private bool PerSaldo;
        #endregion


        #region Zapis w Walucie
        #region Konstruktory
        /// <summary>
        /// Pobierz WinWal MaWal Konstruktor uzywany w MDI  Zapisy 
        /// </summary>
        /// <param name="_dataGridZapisyF"></param>
        /// <param name="WalutyCzyZapisCzyKonto"></param>
        public DialogStanKsiegiZapis(DataGridView _dataGridZapisyF)
        {
            InitializeComponent();
            try
            {
                _dataGridZapisy = _dataGridZapisyF;
                IndeksWiersza = _dataGridZapisyF.CurrentRow.Index;
                IDzapisu = _dataGridZapisy.CurrentRow.Cells["ID_ZAPISU"].Value.ToString();
                PerSaldo = false;
                PobierzWinnMaWalZapisy();
                granitButton6.Visible = true;
                granitButton5.Visible = true;
            }
            catch (Exception ex)
            {
                DialogStatement.ShowError(ex.Message);
            }
        }


        #endregion
        #region Metody
        // Każda metoda ma przystosowane nazwy kolumn do DataGridView zapisy. W MDI Dokumenty i MDI zapisy  DGV.Zapisy nazyw kolumn mogą się różnić. TO DO: Ujednolicić nazwy dla DGV_Zapisy we wszystkich MDI. Prawdopodobnie nazwy kolumn nadane automatycznie typu "pELNEKONTODataGridViewTextBoxColumn" nie są nigdzie indziej używane po za tym plikiem. Zachować szczególną ostrożnośc.

        // Tresc Zapisu  i Data Dokumentu
        private void PobierzWinnMaWalZapisy()
        {
            try
            {
                _dataGridZapisy.Rows[IndeksWiersza].Selected = true;
                KontoNR = _dataGridZapisy.Rows[IndeksWiersza].Cells["KONTO"].Value.ToString();
                NazwaKonta = _dataGridZapisy.Rows[IndeksWiersza].Cells["pELNANAZWAKONTADataGridViewTextBoxColumn"].Value.ToString();
                TrescZapisu = _dataGridZapisy.Rows[IndeksWiersza].Cells["TRESC"].Value.ToString();

                DataTable TablicaKonta = new DataTable();
                using (SqlConnection sqlConnection = new SqlConnection(Databases.SkarbDB.ConnectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter("", sqlConnection);
                    adapter.SelectCommand.CommandText = @"SELECT W.SYMBOL, W.[ID_WALUTY], ZK.WINIEN_WAL, ZK.MA_WAL   
                                                                FROM [T_FKD_WALUTY] W
                                                                JOIN [T_FKD_ZAPIS_KSIEG] ZK ON ZK.ID_WALUTY = W.ID_WALUTY
                                                                WHERE ZK.ID_ZAPISU =" + IDzapisu;
                    adapter.Fill(TablicaKonta);
                }

                Waluta = TablicaKonta.Rows[0][0].ToString();
                KOD = TablicaKonta.Rows[0][1].ToString();
                WinienWaluta = TablicaKonta.Rows[0][2].ToString();
                MaWaluta = TablicaKonta.Rows[0][3].ToString();


                _LabelStanWn.Text = WinienWaluta;
                _LabelStanMa.Text = MaWaluta;
                _LabelHeader.Text =
                    "<div align=\"center\">" +
                    "<font color=\"#602826\">Konto: " + KontoNR + "</font><br/>" +
                    "<font color=\"#602826\">" + NazwaKonta + "</font><br/>" +
                    "<font color=\"#602826\">Treść: " + TrescZapisu + "</font><br/>" +
                    "<font color=\"#602826\">Waluta " + Waluta + "    KOD " + KOD + "</font>" +
                    "</div>";
                panelEx3.Text = "Zapis w walucie " + Waluta;
            }
            catch (Exception ex)
            {
                DialogStatement.ShowError(ex.Message);
            }
        }
        private void PobierzWinnMaWalZapisyDokumentyKsiegowe()
        {
            try
            {
                _dataGridZapisy.Rows[IndeksWiersza].Selected = true;
                KontoNR = _dataGridZapisy.Rows[IndeksWiersza].Cells["KONTO"].Value.ToString();
                NazwaKonta = _dataGridZapisy.Rows[IndeksWiersza].Cells["pELNANAZWAKONTADataGridViewTextBoxColumn"].Value.ToString();
                TrescZapisu = _dataGridZapisy.Rows[IndeksWiersza].Cells["TRESC"].Value.ToString();


                using (SqlConnection sqlConnection = new SqlConnection(Databases.SkarbDB.ConnectionString))
                {
                    DataTable TablicaKonta = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter("", sqlConnection);
                    adapter.SelectCommand.CommandText = @"SELECT W.SYMBOL, W.[ID_WALUTY], ZK.WINIEN_WAL, ZK.MA_WAL   
                                                                FROM [T_FKD_WALUTY] W
                                                                JOIN [T_FKD_ZAPIS_KSIEG] ZK ON ZK.ID_WALUTY = W.ID_WALUTY
                                                                WHERE ZK.ID_ZAPISU =" + IDzapisu;
                    adapter.Fill(TablicaKonta);

                    Waluta = TablicaKonta.Rows[0][0].ToString();
                    KOD = TablicaKonta.Rows[0][1].ToString();
                    WinienWaluta = TablicaKonta.Rows[0][2].ToString();
                    MaWaluta = TablicaKonta.Rows[0][3].ToString();
                }

                if (WinienWaluta == "")
                {
                    WinienWaluta = "0";
                }
                if (MaWaluta == "")
                {
                    MaWaluta = "0";
                }



                _LabelStanWn.Text = WinienWaluta;
                _LabelStanMa.Text = MaWaluta;
                _LabelHeader.Text =
                    "<div align=\"center\">" +
                    "<font color=\"#602826\">Konto: " + KontoNR + "</font><br/>" +
                    "<font color=\"#602826\">" + NazwaKonta + "</font><br/>" +
                    "<font color=\"#602826\">Treść: " + TrescZapisu + "</font><br/>" +
                    //"<font color=\"#602826\">Data " + DataDokumentu + "</font><br/>" +
                    "<font color=\"#602826\">Waluta " + Waluta + "    KOD " + KOD + "</font>" +
                    "</div>";
                panelEx3.Text = "Zapis w walucie " + Waluta;
            }
            catch (Exception ex)
            {
                DialogStatement.ShowError(ex.Message);
            }
        }
        /// <summary>
        /// Dla konta - Dokumenty Księgowe :ADVtree
        /// </summary>
        /// <param name="IndWier"></param>
        private void PobierzWinnMaWal()
        {
            try
            {
                _dataGridZapisy.Rows[IndeksWiersza].Selected = true;
                KontoNR = _dataGridZapisy.Rows[IndeksWiersza].Cells["KONTO"].Value.ToString();
                NazwaKonta = _dataGridZapisy.Rows[IndeksWiersza].Cells["pELNANAZWAKONTADataGridViewTextBoxColumn"].Value.ToString();
                TrescZapisu = _dataGridZapisy.Rows[IndeksWiersza].Cells["TRESC"].Value.ToString();

                DataTable TablicaKonta = new DataTable();
                using (SqlConnection sqlConnection = new SqlConnection(Databases.SkarbDB.ConnectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter("", sqlConnection);
                    adapter.SelectCommand.CommandText = @"SELECT W.SYMBOL, W.[ID_WALUTY], ZK.WINIEN_WAL, ZK.MA_WAL   
                                                                FROM [T_FKD_WALUTY] W
                                                                JOIN [T_FKD_ZAPIS_KSIEG] ZK ON ZK.ID_WALUTY = W.ID_WALUTY
                                                                WHERE ZK.ID_ZAPISU =" + IDzapisu;
                    adapter.Fill(TablicaKonta);
                }
                Waluta = TablicaKonta.Rows[0][0].ToString();
                KOD = TablicaKonta.Rows[0][1].ToString();
                WinienWaluta = TablicaKonta.Rows[0][2].ToString();
                MaWaluta = TablicaKonta.Rows[0][3].ToString();

                _LabelStanWn.Text = WinienWaluta;
                _LabelStanMa.Text = MaWaluta;
                _LabelHeader.Text =
                    "<div align=\"center\">" +
                    "<font color=\"#602826\">Konto: " + KontoNR + "</font><br/>" +
                    "<font color=\"#602826\">" + NazwaKonta + "</font><br/>" +
                    "<font color=\"#602826\">Treść:" + TrescZapisu + "</font><br/>" +
                    "<font color=\"#602826\">Waluta " + Waluta + "    KOD " + KOD + "</font>" +
                    "</div>";
                panelEx3.Text = "Zapis w walucie " + Waluta;
            }
            catch (Exception ex)
            {
                DialogStatement.ShowError(ex.Message);
            }
        }


        #endregion

        #endregion

        #region PerSaldo
        #region Konstruktory


        /// <summary>
        /// Konstruktor używany w MDI Dokumenty
        /// </summary>
        /// <param name="_dataGridZapisyPerSaldo"></param>
        /// <param name="CzyZapisCzyKonto"></param>
        /// <param name="PerSaldo"></param>
        public DialogStanKsiegiZapis(DataGridView _dataGridZapisyPerSaldo, bool PerSaldoo)
        {
            InitializeComponent();
            try
            {
                _dataGridZapisy = _dataGridZapisyPerSaldo;
                IndeksWiersza = _dataGridZapisyPerSaldo.CurrentRow.Index;
                IDzapisu = _dataGridZapisy.CurrentRow.Cells["ID_ZAPISU"].Value.ToString();
                PerSaldo = PerSaldoo;
                granitButton6.Visible = true;
                granitButton5.Visible = true;
                CzyPaczka = false;
                PobierzPerSaldoZapisyDokumentyKsiegowe();
            }
            catch (Exception ex)
            {
                DialogStatement.ShowError(ex.Message);
            }
        }
        /// <summary>
        /// Z Paczki. Konstruktor używany w MDI Dokumenty
        /// </summary>
        /// <param name="_dataGridDlaPerSaldo"></param>
        /// <param name="CzyZapisCzyKonto"></param>
        /// <param name="PerSaldo"></param>
        public DialogStanKsiegiZapis(DataGridView _dataGridZapisyPerSaldo, DataGridView _dataGridDokumentyPerSaldo, bool PerSaldoo)
        {
            InitializeComponent();
            try
            {
                this._dataGridZapisy = _dataGridZapisyPerSaldo;
                this.IndeksWiersza = _dataGridDokumentyPerSaldo.CurrentRow.Index;
                this._dataGridPerSaldoDokumenty = _dataGridDokumentyPerSaldo;
                this.IDzapisu = _dataGridZapisy.CurrentRow.Cells["ID_ZAPISU"].Value.ToString();
                this.IDdokumentu = _dataGridDokumentyPerSaldo.CurrentRow.Cells["ID_DOKUMENTU"].Value.ToString();
                PerSaldo = PerSaldoo;
                this.granitButton6.Visible = true;
                this.granitButton5.Visible = true;
                CzyPaczka = true;
                PobierzPerSaldoDokumentyPaczkaKsiegowe();

            }
            catch (Exception ex)
            {
                DialogStatement.ShowError(ex.Message);
            }
        }


        #endregion

        #region Metody
        /// <summary>
        /// Funkcja przystosowana do MDI Dokumenty
        /// </summary>
        /// <param name="IndWier"></param>
        private void PobierzPerSaldoZapisyDokumentyKsiegowe()
        {
            try
            {
                _dataGridZapisy.Rows[IndeksWiersza].Selected = true;
                KontoNR = _dataGridZapisy.Rows[IndeksWiersza].Cells["KONTO"].Value.ToString();
                NazwaKonta = _dataGridZapisy.Rows[IndeksWiersza].Cells["pELNANAZWAKONTADataGridViewTextBoxColumn"].Value.ToString();
                TrescZapisu = _dataGridZapisy.Rows[IndeksWiersza].Cells["TRESC"].Value.ToString();


                ObliczPerSaldoDokument();


                if (PerSaldoWnMa > 0)
                {
                    _LabelStanWn.Text = String.Format("{0:c}", PerSaldoWnMa);
                    _LabelStanMa.Text = "0";
                }
                else if (PerSaldoWnMa < 0)
                {
                    PerSaldoWnMa = Math.Abs(PerSaldoWnMa);
                    _LabelStanWn.Text = "0";
                    _LabelStanMa.Text = String.Format("{0:c}", PerSaldoWnMa);

                }
                else
                {
                    _LabelStanWn.Text = "0";
                    _LabelStanMa.Text = "0";
                }

                _LabelHeader.Text =
                    "<div align=\"center\">" +
                    "<font color=\"#602826\">Konto: " + KontoNR + "</font><br/>" +
                    "<font color=\"#602826\">" + NazwaKonta + "</font><br/>" +
                    "<font color=\"#602826\">Treść: " + TrescZapisu + "</font><br/>" +
                    "<font color=\"#602826\">Paczka miesiąc nr:" + MiesiacPaczki + "</font><br/>" +
                    "</div>";
                panelEx3.Text = "PerSaldo ";
            }
            catch (Exception ex)
            {
                DialogStatement.ShowError(ex.Message);
            }
        }
        private void ObliczPerSaldoDokument()
        {
            using (SqlConnection sqlConnection = new SqlConnection(Databases.SkarbDB.ConnectionString))
            {
                DataTable TablicaKonta = new DataTable();
                sqlConnection.Open();
                using (SqlCommand sqlSelect = new SqlCommand())
                {
                    sqlSelect.Connection = sqlConnection;
                    sqlSelect.CommandText = @"SELECT PA.MIESIAC, ZK.ID_KONTA, ZK.ID_DOKUMENTU
                                                FROM [T_FKD_ZAPIS_KSIEG] ZK
                                                JOIN [T_FKD_DOKUMENTY] DOK ON DOK.ID_DOKUMENTU = ZK.ID_DOKUMENTU
                                                JOIN [T_FKD_PACZKA] PA ON PA.ID_PACZKI = DOK.ID_PACZKI
                                                WHERE ZK.ID_ZAPISU = @IDzapisu";
                    sqlSelect.Parameters.AddWithValue("@IDzapisu", IDzapisu);
                    TablicaKonta.Load(sqlSelect.ExecuteReader());

                    MiesiacPaczki = TablicaKonta.Rows[0][0].ToString();
                    IDkonta = TablicaKonta.Rows[0][1].ToString();
                    IDdokumentu = TablicaKonta.Rows[0][2].ToString();
                }
                TablicaKonta = new DataTable();
                using (SqlCommand sqlSelect = new SqlCommand())
                {
                    sqlSelect.Connection = sqlConnection;
                    sqlSelect.CommandText = @"SELECT (SELECT (KP.WN_BO - KP.MA_BO) as BO
                                                FROM [T_FKD_KONT_PLAN] KP 
                                                WHERE KP.ID_KONTA = @IDkonta 
                                                Group by KP.WN_BO,KP.MA_BO) 
                                                + 
                                                (SELECT SUM(KOM.WN - KOM.MA) as ObrotyMiesiaca
                                                FROM [T_FKD_KONT_OBROTY_MIES] KOM
                                                WHERE KOM.ID_KONTA = @IDkonta and KOM.MIESIAC between 1 and @MiesiacDO) 
                                                + 
                                                (SELECT SUM(ZK.WINIEN - ZK.MA) as ZapisyK
                                                FROM [T_FKD_ZAPIS_KSIEG] ZK
                                                JOIN [T_FKD_DOKUMENTY] DOK ON DOK.ID_DOKUMENTU = ZK.ID_DOKUMENTU
                                                WHERE ZK.ID_DOKUMENTU = @IDdokumentu and ZK.ID_KONTA = @IDkonta)";
                    sqlSelect.Parameters.AddWithValue("@IDkonta", IDkonta);
                    sqlSelect.Parameters.AddWithValue("@IDdokumentu", IDdokumentu);
                    sqlSelect.Parameters.AddWithValue("@MiesiacDO", MiesiacPaczki);
                    TablicaKonta.Load(sqlSelect.ExecuteReader());
                }
                sqlConnection.Close();
                string sss = TablicaKonta.Rows[0][0].ToString();
                PerSaldoWnMa = Convert.ToDouble(TablicaKonta.Rows[0][0]);
            }
        }

        private void PobierzPerSaldoDokumentyPaczkaKsiegowe()
        {
            try
            {
                _dataGridPerSaldoDokumenty.Rows[IndeksWiersza].Selected = true;

                ObliczPerSaldoPaczka();

                if (PerSaldoWnMa > 0)
                {
                    _LabelStanWn.Text = String.Format("{0:c}", PerSaldoWnMa);
                    _LabelStanMa.Text = "0";
                }
                else if (PerSaldoWnMa < 0)
                {
                    PerSaldoWnMa = Math.Abs(PerSaldoWnMa);
                    _LabelStanWn.Text = "0";
                    _LabelStanMa.Text = String.Format("{0:c}", PerSaldoWnMa);

                }
                else
                {
                    _LabelStanWn.Text = "0";
                    _LabelStanMa.Text = "0";
                }

                _LabelHeader.Text =
                    "<div align=\"center\">" +
                    "<font color=\"#602826\">Konto: " + KontoNR + "</font><br/>" +
                    "<font color=\"#602826\">" + NazwaKonta + "</font><br/>" +
                    "<font color=\"#602826\">Paczka nr: " + NrPaczki + "</font><br/>" +
                    "<font color=\"#602826\">Paczka miesiąc:" + MiesiacPaczki + "</font><br/>" +
                    "</div>";
                panelEx3.Text = "PerSaldo ";
            }
            catch (Exception ex)
            {
                DialogStatement.ShowError(ex.Message);
            }
        }
        private void ObliczPerSaldoPaczka()
        {
            using (SqlConnection sqlConnection = new SqlConnection(Databases.SkarbDB.ConnectionString))
            {
                DataTable TablicaKonta = new DataTable();
                sqlConnection.Open();
                using (SqlCommand sqlSelect = new SqlCommand())
                {
                    sqlSelect.Connection = sqlConnection;
                    sqlSelect.CommandText = @"SELECT PA.MIESIAC, ZK.ID_KONTA, ZK.ID_DOKUMENTU,PA.ID_PACZKI, PA.NUMER, KP.PELNE_KONTO, KP.NAZWA
                                                FROM [T_FKD_ZAPIS_KSIEG] ZK
                                                JOIN [T_FKD_KONT_PLAN] KP ON KP.ID_KONTA = ZK.ID_KONTA
                                                JOIN [T_FKD_DOKUMENTY] DOK ON DOK.ID_DOKUMENTU = ZK.ID_DOKUMENTU
                                                JOIN [T_FKD_PACZKA] PA ON PA.ID_PACZKI = DOK.ID_PACZKI
                                                WHERE DOK.ID_DOKUMENTU = @IDdokumentu";
                    sqlSelect.Parameters.AddWithValue("@IDdokumentu", IDdokumentu);
                    TablicaKonta.Load(sqlSelect.ExecuteReader());

                    MiesiacPaczki = TablicaKonta.Rows[0][0].ToString();
                    IDkonta = TablicaKonta.Rows[0][1].ToString();
                    IDdokumentu = TablicaKonta.Rows[0][2].ToString();
                    IDpaczki = TablicaKonta.Rows[0][3].ToString();
                    NrPaczki = TablicaKonta.Rows[0][4].ToString();
                    KontoNR = TablicaKonta.Rows[0][5].ToString();
                    NazwaKonta = TablicaKonta.Rows[0][6].ToString();
                }
                TablicaKonta = new DataTable();
                using (SqlCommand sqlSelect = new SqlCommand())
                {
                    sqlSelect.Connection = sqlConnection;
                    sqlSelect.CommandText = @"SELECT (SELECT (KP.WN_BO - KP.MA_BO) as BO
                                                FROM [T_FKD_KONT_PLAN] KP 
                                                WHERE KP.ID_KONTA = @IDkonta
                                                Group by KP.WN_BO,KP.MA_BO) 
                                                + 
                                                (SELECT SUM(KOM.WN - KOM.MA) as ObrotyMiesiaca
                                                FROM [T_FKD_KONT_OBROTY_MIES] KOM
                                                WHERE KOM.ID_KONTA = @IDkonta and KOM.MIESIAC between 1 and @MiesiacDO) 
                                                + 
                                                (SELECT SUM(ZK.WINIEN - ZK.MA) as ZapisyK
                                                FROM [T_FKD_ZAPIS_KSIEG] ZK
                                                JOIN [T_FKD_DOKUMENTY] DOK ON DOK.ID_DOKUMENTU = ZK.ID_DOKUMENTU
                                                WHERE DOK.ID_PACZKI = @IDpaczki and ZK.ID_KONTA = @IDkonta)";
                    sqlSelect.Parameters.AddWithValue("@IDkonta", IDkonta);
                    sqlSelect.Parameters.AddWithValue("@IDdokumentu", IDdokumentu);
                    sqlSelect.Parameters.AddWithValue("@IDpaczki", IDpaczki);
                    sqlSelect.Parameters.AddWithValue("@MiesiacDO", MiesiacPaczki);
                    TablicaKonta.Load(sqlSelect.ExecuteReader());
                }
                sqlConnection.Close();
                string sss = TablicaKonta.Rows[0][0].ToString();
                PerSaldoWnMa = Convert.ToDouble(TablicaKonta.Rows[0][0]);
            }
        }
        #endregion
        #endregion


        #region Metody
        private void Zapisy_z_Dokumentu(bool PrzodTyl_TF)
        {
            if (IndeksWiersza != _dataGridZapisy.Rows.Count - 1 && PrzodTyl_TF == true)
            {
                IndeksWiersza += 1;
            }
            else if (IndeksWiersza != 0 && PrzodTyl_TF == false)
            {
                IndeksWiersza -= 1;
            }
            if (_dataGridZapisy.Rows.Count != 0)
            {
                IDzapisu = _dataGridZapisy.Rows[IndeksWiersza].Cells["ID_ZAPISU"].Value.ToString();
                _dataGridZapisy.Rows[IndeksWiersza].Selected = false;

                if (PerSaldo == false)
                {
                    PobierzWinnMaWalZapisy();
                }
                else if (PerSaldo == true)
                {
                    PobierzPerSaldoZapisyDokumentyKsiegowe();
                }
            }

            if (IndeksWiersza > _dataGridZapisy.DisplayedRowCount(false))
            {
                int IndeksScroolWiersza = IndeksWiersza - _dataGridZapisy.DisplayedRowCount(false);
                _dataGridZapisy.FirstDisplayedScrollingRowIndex = IndeksScroolWiersza;
            }
            _dataGridZapisy.ClearSelection();
            _dataGridZapisy.CurrentCell = _dataGridZapisy.Rows[IndeksWiersza].Cells[0];
            _dataGridZapisy.Rows[IndeksWiersza].Selected = true;
            
        }
        private void Zapisy_z_Paczki(bool PrzodTyl_TF)
        {
            if (IndeksWiersza != _dataGridPerSaldoDokumenty.Rows.Count - 1 && PrzodTyl_TF == true)
            {
                IndeksWiersza += 1;
            }
            else if (IndeksWiersza != 0 && PrzodTyl_TF == false)
            {
                IndeksWiersza -= 1;
            }

            if (_dataGridZapisy.Rows.Count != 0)
            {
                IDzapisu = _dataGridZapisy.Rows[0].Cells["ID_ZAPISU"].Value.ToString();
                _dataGridPerSaldoDokumenty.Rows[IndeksWiersza].Selected = false;

                PobierzPerSaldoDokumentyPaczkaKsiegowe();
            }

            if (IndeksWiersza > _dataGridPerSaldoDokumenty.DisplayedRowCount(false))
            {
                int IndeksScroolWiersza = IndeksWiersza - _dataGridPerSaldoDokumenty.DisplayedRowCount(false);
                _dataGridPerSaldoDokumenty.FirstDisplayedScrollingRowIndex = IndeksScroolWiersza;
            }
            _dataGridPerSaldoDokumenty.ClearSelection();
            _dataGridPerSaldoDokumenty.CurrentCell = _dataGridPerSaldoDokumenty.Rows[IndeksWiersza].Cells[0];
            _dataGridPerSaldoDokumenty.Rows[IndeksWiersza].Selected = true;
            
        }
        #endregion

        #region Eventy

        #region Przyciski-Eventy
        private void granitButton6_Click(object sender, EventArgs e) // w przód
        {
            try
            {
                if (CzyPaczka == false)
                {
                    Zapisy_z_Dokumentu(true);
                }
                else if (CzyPaczka == true)
                {
                    Zapisy_z_Paczki(true);
                }
            }
            catch (Exception ex)
            {
                DialogStatement.ShowError(ex.Message);
            }
            #region DlaADVTree
            //else if (NodeKonto.NextNode != null && CzyZapisKsiegowy == false && CzyADVTree == false)
            //{
            //    NodeKonto = NodeKonto.NextNode;
            //    PobierzWinnMaWalADVtree();
            //    //Konto.SelectedNode.NextNode;
            //}
            #endregion
        }
        private void granitButton5_Click(object sender, EventArgs e) // w tył
        {
            try
            {
                if (CzyPaczka == false)
                {
                    Zapisy_z_Dokumentu(false);
                }
                else if (CzyPaczka == true)
                {
                    Zapisy_z_Paczki(false);
                }
            }
            catch (Exception ex)
            {
                DialogStatement.ShowError(ex.Message);
            }
        }
        private void granitButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        private void tableLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }
        private void DialogStanKsiegiZapis_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
        #endregion



    }
}


