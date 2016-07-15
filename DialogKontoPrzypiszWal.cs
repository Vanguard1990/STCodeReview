using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GranitControls;
using System.Data.SqlClient;
using GranitSettings;

namespace GranitSkarbGUI.OknaDialogowe
{
    public partial class DialogKontoPrzypiszWal : GranitControls.MDIform
    {
        private int _IDWALUTY;
        public int gIDWALUTY
        {
            get{return _IDWALUTY;}
            set{_IDWALUTY = value;}
        }
        private int _IDnadrzednego;
        public int gIDnadrzednego
        {
            get { return _IDnadrzednego; }
            set { _IDnadrzednego = value; }
        }


        public DialogKontoPrzypiszWal()
        {
            InitializeComponent();
            

        }
        private void DialogKontoPrzypiszWal_Load(object sender, EventArgs e)
        {
            CmbxPobierzWaluty();
        }


        /// <summary>
        /// Pobierz waluty z bazy i przypisz do DataSet dla Comboboxa
        /// </summary>
        private void CmbxPobierzWaluty()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT SYMBOL,ID_WALUTY FROM dbo.T_FKD_WALUTY Where SYMBOL <> 'PLN' ", Databases.SkarbDB.ConnectionString);
            adapter.Fill(DataSetWaluty);
            _comboWaluta.DataSource = DataSetWaluty.Tables[0];
            _comboWaluta.ValueMember = "ID_WALUTY";
            _comboWaluta.DisplayMembers = "SYMBOL";
            _comboWaluta.SelectedValue = CmbxPobierzWaluteKontaSentytycznego();
        }
        private int CmbxPobierzWaluteKontaSentytycznego()
        {
            int ID_WALUTYsyn = 0;
            DataTable IDWALUTYdatatable = new DataTable();
            IDWALUTYdatatable.TableName = "Tablica";
            SqlDataAdapter adapter = new SqlDataAdapter(@"SELECT ID_WALUTY
                                                          FROM [SKARB].[dbo].[T_FKD_KONT_PLAN]
                                                          WHERE ID_KONTA =" + _IDnadrzednego, Databases.SkarbDB.ConnectionString);
            adapter.Fill(IDWALUTYdatatable);
            ID_WALUTYsyn = Convert.ToInt32(IDWALUTYdatatable.Rows[0][0].ToString());
            return ID_WALUTYsyn;
        }
        private void _gbtnDodajWalute_Click(object sender, EventArgs e)
        {
            DialogWaluta DlgWaluta = new DialogWaluta();
            DlgWaluta.ShowDialog();
            CmbxPobierzWaluty();
        }
        private void _gbtnZatwierdzZakoncz_Click(object sender, EventArgs e)
        {
            _IDWALUTY = Convert.ToInt32(_comboWaluta.SelectedValue);
            this.Close();
        }



    }
}
