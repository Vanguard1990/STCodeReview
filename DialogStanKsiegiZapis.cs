using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Windows.Forms;
using GranitControls;
using GranitSettings;
using System.Data.SqlClient;
using DevComponents.DotNetBar;
using DevComponents.AdvTree;
using GranitExceptions;
using System.Text.RegularExpressions;

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
        private string RokKonta;
        private string IDzapisu;
        private string IDkonta;
        private string TrescZapisu;
        private string DataDokumentu;
        private string MiesiacPaczki;
        private double PerSaldoWnMa;
        private int IndeksWiersza;
        private bool CzyZapisKsiegowy;
        DataGridView _dataGridZapisy;
        private bool PerSaldo;


        #endregion

        #region Konstruktory
        #region PrzeciazenieDla_ADV_Tree
        //private bool CzyADVTree;
        //
        //GranitControls.GranitTreeView Konto;
        //DevComponents.AdvTree.Node NodeKonto;

        
        //public DialogStanKsiegiZapis(GranitControls.GranitTreeView Konta, string Rok)
        //{
        //    InitializeComponent();

        //    Konto = Konta;
        //    NodeKonto = Konta.SelectedNode;
        //    RokKonta = Rok;
        //    //string xyz = NodeWybraneKonto.Cells[0].Text;
        //    CzyZapisKsiegowy = true;
        //    CzyADVTree = true;
        //    PobierzWinnMaWalADVtree();
        //    //PobierzKonto();
        //    //DevComponents.AdvTree.Node;

        //}
        #endregion
        
        public DialogStanKsiegiZapis(DataGridView _dataGridZapisyF)
        {
            InitializeComponent();
            _dataGridZapisy = _dataGridZapisyF;
            IndeksWiersza = _dataGridZapisyF.CurrentRow.Index;
            IDzapisu = _dataGridZapisy.CurrentRow.Cells["ID_ZAPISU"].Value.ToString();
            PerSaldo = false;
            CzyZapisKsiegowy = true;
            PobierzWinnMaWalZapisyDokumentyKsiegowe(IndeksWiersza);

            granitButton6.Visible = true;
            granitButton5.Visible = true;
        }
        /// <summary>
        /// Konstruktor uzywany w MDI  Zapisy
        /// </summary>
        /// <param name="_dataGridZapisyF"></param>
        /// <param name="CzyZapisCzyKonto"></param>
        public DialogStanKsiegiZapis(DataGridView _dataGridZapisyF, bool CzyZapisCzyKonto)
        {
            InitializeComponent();
            _dataGridZapisy = _dataGridZapisyF;
            IndeksWiersza = _dataGridZapisyF.CurrentRow.Index;
            IDzapisu = _dataGridZapisy.CurrentRow.Cells["ID_ZAPISU"].Value.ToString();
            PerSaldo = false;
            if (CzyZapisCzyKonto == true) // 0 -zapis 
            {
                CzyZapisKsiegowy = true;
                PobierzWinnMaWalZapisy(IndeksWiersza);
            }
            else if (CzyZapisCzyKonto == false) // 1 -konto
            {
                CzyZapisKsiegowy = false;
                PobierzWinnMaWal(IndeksWiersza);
            }
            granitButton6.Visible = true;
            granitButton5.Visible = true;
        }
        /// <summary>
        /// Konstruktor używany w MDI Dokumenty
        /// </summary>
        /// <param name="_dataGridZapisyDlaPerSaldo"></param>
        /// <param name="CzyZapisCzyKonto"></param>
        /// <param name="PerSaldo"></param>
        public DialogStanKsiegiZapis(DataGridView _dataGridZapisyDlaPerSaldo, bool CzyZapisCzyKonto,bool PerSaldoo)
        {
            InitializeComponent();
            _dataGridZapisy = _dataGridZapisyDlaPerSaldo;
            IndeksWiersza = _dataGridZapisyDlaPerSaldo.CurrentRow.Index;
            IDzapisu = _dataGridZapisy.CurrentRow.Cells["ID_ZAPISU"].Value.ToString();
            PerSaldo = PerSaldoo;
            CzyZapisKsiegowy = true;
            PobierzWinMaPerSaldoZapisyDokumentyKsiegowe(IndeksWiersza);

            granitButton6.Visible = true;
            granitButton5.Visible = true;
        }
        #endregion

        
        #region Metody
        // Każda metoda ma przystosowane nazwy kolumn do DataGridView w danym MDI. TO DO: Ujednolicić nazwy dla DGV_Zapisy we wszystkich MDI. Prawdopodobnie nazwy kolumn nadane automatycznie typu "pELNEKONTODataGridViewTextBoxColumn" nie są nigdzie indziej używane po za tym plikiem. Zachować szczególną ostrożnośc.
        
        // Tresc Zapisu  i Data Dokumentu
        private void PobierzWinnMaWalZapisy(int IndWier)
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
                "<font color=\"#602826\">Konto " + KontoNR + "</font><br/>" +
                "<font color=\"#602826\">" + NazwaKonta + "</font><br/>" +
                "<font color=\"#602826\">Treść: " + TrescZapisu + "</font><br/>" +
                "<font color=\"#602826\">Waluta " + Waluta + "    KOD " + KOD + "</font>" +
                "</div>";
            panelEx3.Text = "Zapis w walucie " + Waluta;
        }
        private void PobierzWinnMaWalZapisyDokumentyKsiegowe(int IndWier)
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
                "<font color=\"#602826\">Konto " + KontoNR + "</font><br/>" +
                "<font color=\"#602826\">" + NazwaKonta + "</font><br/>" +
                "<font color=\"#602826\">Treść: " + TrescZapisu + "</font><br/>" +
                //"<font color=\"#602826\">Data " + DataDokumentu + "</font><br/>" +
                "<font color=\"#602826\">Waluta " + Waluta + "    KOD " + KOD + "</font>" +
                "</div>";
            panelEx3.Text = "Zapis w walucie " + Waluta;
        }
        private void PobierzWinnMaWal(int IndWier)
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
                "<font color=\"#602826\">Konto " + KontoNR + "</font><br/>" +
                "<font color=\"#602826\">" + NazwaKonta + "</font><br/>" +
                "<font color=\"#602826\">Treść" + TrescZapisu +"</font><br/>" +
                "<font color=\"#602826\">Waluta " + Waluta + "    KOD " + KOD + "</font>" +
                "</div>";
            panelEx3.Text = "Zapis w walucie " + Waluta;
        }
        /// <summary>
        /// Funkcja przystosowana do MDI Dokumenty
        /// </summary>
        /// <param name="IndWier"></param>
        private void PobierzWinMaPerSaldoZapisyDokumentyKsiegowe(int IndWier)
        {
            _dataGridZapisy.Rows[IndeksWiersza].Selected = true;
            KontoNR = _dataGridZapisy.Rows[IndeksWiersza].Cells["KONTO"].Value.ToString();
            NazwaKonta = _dataGridZapisy.Rows[IndeksWiersza].Cells["pELNANAZWAKONTADataGridViewTextBoxColumn"].Value.ToString();
            TrescZapisu = _dataGridZapisy.Rows[IndeksWiersza].Cells["TRESC"].Value.ToString();

            
            using (SqlConnection sqlConnection = new SqlConnection(Databases.SkarbDB.ConnectionString))
            {
                DataTable TablicaKonta = new DataTable();
                sqlConnection.Open();
                using (SqlCommand sqlSelect = new SqlCommand())
                {
                    sqlSelect.Connection = sqlConnection;
                    sqlSelect.CommandText = @"SELECT PA.MIESIAC,ZK.ID_KONTA
                                                FROM [T_FKD_ZAPIS_KSIEG] ZK
                                                JOIN [T_FKD_DOKUMENTY] DOK ON DOK.ID_DOKUMENTU = ZK.ID_DOKUMENTU
                                                JOIN [T_FKD_PACZKA] PA ON PA.ID_PACZKI = DOK.ID_PACZKI
                                                WHERE ZK.ID_ZAPISU = @IDzapisu";
                    sqlSelect.Parameters.AddWithValue("@IDzapisu", IDzapisu);
                    TablicaKonta.Load(sqlSelect.ExecuteReader());

                    MiesiacPaczki = TablicaKonta.Rows[0][0].ToString();
                    IDkonta = TablicaKonta.Rows[0][1].ToString();
                }
                TablicaKonta = new DataTable();
                using (SqlCommand sqlSelect = new SqlCommand())
                {
                    sqlSelect.Connection = sqlConnection;
                    sqlSelect.CommandText = @"SELECT (KP.WN_BO - KP.MA_BO) + SUM(KOM.WN - KOM.MA) + SUM(ZK.WINIEN - ZK.MA) as PerSaldo
                                                FROM [T_FKD_ZAPIS_KSIEG] ZK
                                                JOIN [T_FKD_KONT_PLAN] KP ON KP.ID_KONTA = ZK.ID_KONTA
                                                JOIN [T_FKD_KONT_OBROTY_MIES] KOM ON KOM.ID_KONTA = ZK.ID_KONTA
                                                JOIN [T_FKD_DOKUMENTY] DOK ON DOK.ID_DOKUMENTU = ZK.ID_DOKUMENTU
                                                JOIN [T_FKD_PACZKA] PA ON PA.ID_PACZKI = DOK.ID_PACZKI
                                                WHERE KP.ID_KONTA = @IDkonta and KOM.MIESIAC between 1 and @MiesiacDO
                                                Group by KP.WN_BO,KP.MA_BO";
                    sqlSelect.Parameters.AddWithValue("@IDkonta", IDkonta);
                    sqlSelect.Parameters.AddWithValue("@MiesiacDO", MiesiacPaczki);
                    TablicaKonta.Load(sqlSelect.ExecuteReader());
                }
                sqlConnection.Close();
                string sss = TablicaKonta.Rows[0][0].ToString();
                PerSaldoWnMa = Convert.ToDouble(TablicaKonta.Rows[0][0]);
            }

            
            if (PerSaldoWnMa > 0)
            {
                _LabelStanWn.Text = String.Format("{0:c}", PerSaldoWnMa.ToString());
                _LabelStanMa.Text = "0";
            }
            else if (PerSaldoWnMa < 0)
            {
                PerSaldoWnMa = Math.Abs(PerSaldoWnMa);
                _LabelStanWn.Text = "0";
                _LabelStanMa.Text = String.Format("{0:c}", PerSaldoWnMa.ToString());
                
            }
            else
            {
                _LabelStanWn.Text = "0";
                _LabelStanMa.Text = "0";
            }

            _LabelHeader.Text =
                "<div align=\"center\">" +
                "<font color=\"#602826\">Konto " + KontoNR + "</font><br/>" +
                "<font color=\"#602826\">" + NazwaKonta + "</font><br/>" +
                "<font color=\"#602826\">Treść: " + TrescZapisu + "</font><br/>" +
                "<font color=\"#602826\">Paczka miesiąc nr:" + MiesiacPaczki + "</font><br/>" +
                "</div>";
            panelEx3.Text = "PerSaldo ";
        }

        #endregion



        #region Eventy

        #region Przyciski-Eventy

        private void granitButton6_Click(object sender, EventArgs e) // w przód
        {
            if (IndeksWiersza != _dataGridZapisy.Rows.Count - 1)
            {
                _dataGridZapisy.Rows[IndeksWiersza].Selected = false;
                IndeksWiersza += 1;
                IDzapisu = _dataGridZapisy.Rows[IndeksWiersza].Cells["ID_ZAPISU"].Value.ToString();
                if (CzyZapisKsiegowy == true)//&& CzyADVTree == false
                {
                    if (PerSaldo == false)
                    {
                        PobierzWinnMaWalZapisy(IndeksWiersza);
                    }
                    else if (PerSaldo == true)
                    {
                        PobierzWinMaPerSaldoZapisyDokumentyKsiegowe(IndeksWiersza);
                    }
                }
                else if (CzyZapisKsiegowy == false)//&& CzyADVTree == false
                {
                    if (PerSaldo == false)
                    {
                        PobierzWinnMaWalZapisy(IndeksWiersza);
                    }
                    else if (PerSaldo == true)
                    {
                        PobierzWinMaPerSaldoZapisyDokumentyKsiegowe(IndeksWiersza);
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
            if (IndeksWiersza != 0)
            {
                _dataGridZapisy.Rows[IndeksWiersza].Selected = false;
                IndeksWiersza -= 1;
                IDzapisu = _dataGridZapisy.Rows[IndeksWiersza].Cells["ID_ZAPISU"].Value.ToString();
                if (CzyZapisKsiegowy == true)//&& CzyADVTree == false
                {
                    if (PerSaldo == false)
                    {
                        PobierzWinnMaWalZapisy(IndeksWiersza);
                    }
                    else if (PerSaldo == true)
                    {
                        PobierzWinMaPerSaldoZapisyDokumentyKsiegowe(IndeksWiersza);
                    }
                }
                else if (CzyZapisKsiegowy == false)//&& CzyADVTree == false
                {
                    if (PerSaldo == false)
                    {
                        PobierzWinnMaWalZapisy(IndeksWiersza);
                    }
                    else if (PerSaldo == true)
                    {
                        PobierzWinMaPerSaldoZapisyDokumentyKsiegowe(IndeksWiersza);
                    }
                }
                if (IndeksWiersza > _dataGridZapisy.DisplayedRowCount(false)) //&& IndeksWiersza < (_dataGridZapisy.Rows.Count - _dataGridZapisy.DisplayedRowCount(false) + 1)
                {
                    int IndeksScroolWiersza = IndeksWiersza - _dataGridZapisy.DisplayedRowCount(false);
                    _dataGridZapisy.FirstDisplayedScrollingRowIndex = IndeksScroolWiersza;
                }
                _dataGridZapisy.ClearSelection();
                _dataGridZapisy.CurrentCell = _dataGridZapisy.Rows[IndeksWiersza].Cells[0];
                _dataGridZapisy.Rows[IndeksWiersza].Selected = true;
            }
            #region DlaADVTree
            //else if (NodeKonto.PrevNode != null && CzyZapisKsiegowy == false && CzyADVTree == false)
            //{
            //    NodeKonto = NodeKonto.PrevNode;
            //    PobierzWinnMaWalADVtree();
            //}
            #endregion
        }   

        private void granitButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        private void tableLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }
        #endregion

        private void DialogStanKsiegiZapis_FormClosing(object sender, FormClosingEventArgs e)
        {
            _dataGridZapisy.ClearSelection();
            _dataGridZapisy.CurrentCell = _dataGridZapisy.Rows[IndeksWiersza].Cells[0];
            _dataGridZapisy.Rows[IndeksWiersza].Selected = true;
        }

        


        #region ToSamoAleDla_ADV_Tree_W_Ksiedze_Glownej_Prawie_Działa
        //        private void PobierzWinnMaWalADVtree()
//        {
//            KontoNR = Konto.SelectedNode.Cells["PELNE KONTO"].Text;
//            ZapisNR = _dataGridZapisy.Rows[IndeksWiersza].Cells[2].Value.ToString();
            
//            DataTable TablicaKonta = new DataTable();
//            using (SqlConnection sqlConnection = new SqlConnection(Databases.SkarbDB.ConnectionString))
//            {
//                SqlDataAdapter adapter = new SqlDataAdapter("", sqlConnection);
//                adapter.SelectCommand.CommandText = @"SELECT W.SYMBOL, W.[ID_WALUTY], ZK.WINIEN_WAL, ZK.MA_WAL   
//                                                                FROM [T_FKD_WALUTY] W
//                                                                JOIN [T_FKD_ZAPIS_KSIEG] ZK ON ZK.ID_WALUTY = W.[ID_WALUTY]
//                                                                JOIN [T_FKD_KONT_PLAN] KP ON KP.ID_KONTA = ZK.ID_KONTA
//                                                                WHERE KP.PELNE_KONTO = '" + KontoNR + "' and KP.NAZWA ='" + NazwaKonta + "'";
//                adapter.Fill(TablicaKonta);
//            }
//            Waluta = TablicaKonta.Rows[0][0].ToString() ?? "BRAK";
//            KOD = TablicaKonta.Rows[0][1].ToString() ?? "BRAK";
//            WinienWaluta = TablicaKonta.Rows[0][2].ToString() ?? "BRAK";
//            MaWaluta = TablicaKonta.Rows[0][3].ToString() ?? "BRAK";

//            _LabelStanWn.Text = WinienWaluta;
//            _LabelStanMa.Text = MaWaluta;
//            _LabelHeader.Text =
//                "<div align=\"center\">" +
//                "<font color=\"#602826\">Konto " + KontoNR + "</font><br/>" +
//                "<font color=\"#602826\">" + NazwaKonta + "</font><br/>" +
//                "<font color=\"#602826\">Waluta " + Waluta + "    KOD " + KOD + "</font>" +
//                "</div>";
//        }
        #endregion
        #region ADVstanKsiegi_WG_Poprzednikow
        //private void PoprzednieKonto()
        //{
        //    try
        //    {
        //        if (NodeKonto.PrevNode == null) throw new GranitWarningException();
        //        NodeKonto = NodeKonto.PrevNode;

        //        PobierzKonto();

        //        //OdswiezDane();
        //    }
        //    catch (GranitWarningException)
        //    {
        //        DialogStatement.Show("Brak poprzedniego konta na tym poziomie", DialogStatement.DialogType.Info);
        //    }
        //    catch (Exception ex)
        //    {
        //        DialogStatement.ShowError(ex);
        //    }
        //}
        //private void NastepneKonto()
        //{
        //    try
        //    {
        //        if (NodeKonto.NextNode == null) throw new GranitWarningException();
        //        NodeKonto = NodeKonto.NextNode;

        //        PobierzKonto();

        //        //OdswiezDane();
        //    }
        //    catch (GranitWarningException)
        //    {
        //        DialogStatement.Show("Brak kolejnego konta na tym poziomie", DialogStatement.DialogType.Info);
        //    }
        //    catch (Exception ex)
        //    {
        //        DialogStatement.ShowError(ex);
        //    }
        //}
        //private void PobierzKonto()
        //{

        //    try
        //    {
        //        //Pobranie konta
        //        Konto = new Konto(getIdKonta());

        //        //Ustawienie Nagłówka
        //        _LabelHeader.Text = "<div align=\"center\">" +
        //            "<font color=\"#602826\">Stan Księgi na " + Miesiac.ToString().PadLeft(2, '0') + "/" + Konto["ROK"].ToString() + "<br/>" +
        //            Konto["PELNE_KONTO"].ToString() + " " + Konto["PELNA_NAZWA"].ToString() +
        //            "</font></div>";

        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
        //public int getIdKonta()
        //{
        //    try
        //    {
        //        int Idkonta = -1;

        //        //Pobieramy id konta
        //        foreach (DevComponents.AdvTree.ColumnHeader column in NodeKonto.TreeControl.Columns)
        //        {
        //            if (column.Text.ToUpper() == "ID KONTA")
        //            {
        //                Idkonta = Convert.ToInt32(NodeKonto.Cells[NodeKonto.TreeControl.Columns.IndexOf(column)].Text);
        //            }

        //        }

        //        if (Idkonta == -1) throw new GranitWarningException("Nie znaleziono konta");

        //        return Idkonta;

        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
        #endregion

    }
}


