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
    public partial class DialogWalutaZapis : GranitControls.MDIform
    {
        private int _IDWALUTY;
        public int gIDWALUTY
        {
            get{return _IDWALUTY;}
        }
        private double _WinWal;
        public double gWinWal
        {
            get { return _WinWal; }
        }
        private double _MaWal;
        public double gMaWal
        {
            get { return _MaWal; }
        }
        private bool CzyMAwal;

        public DialogWalutaZapis(bool WnMa)
        {
            InitializeComponent();
            CzyMAwal = WnMa;
            if (CzyMAwal == false)
            {
                _doubleInputWINwal.Enabled = true;
                _doubleInputMAwal.Enabled = false;
            }
            else if (CzyMAwal == true)
            {
                _doubleInputMAwal.Enabled = true;
                _doubleInputWINwal.Enabled = false;
            }

        }
        public DialogWalutaZapis(bool WnMa, double MaWall, double WinWall, string Waluta, string KOD)
        {
            InitializeComponent();
            CzyMAwal = WnMa;
            _doubleInputWINwal.Value = WinWall;
            _doubleInputMAwal.Value = MaWall;
            reflectionLabel2.Text = "<div align=\"center\"><font color=\"#602826\">Wartość walutowa w "+ Waluta + " KOD "+ KOD + "</font></div>";
            if (CzyMAwal == false)
            {
                _doubleInputWINwal.Enabled = true;
                _doubleInputMAwal.Enabled = false;
            }
            else if (CzyMAwal == true)
            {
                _doubleInputMAwal.Enabled = true;
                _doubleInputWINwal.Enabled = false;
            }

        }

        private void _gbtnZatwierdzZakoncz_Click(object sender, EventArgs e)
        {
            if (CzyMAwal == false)
            {
                _WinWal = Convert.ToDouble(_doubleInputWINwal.Value);
            }
            else if (CzyMAwal == true)
            {
                _MaWal = Convert.ToDouble(_doubleInputMAwal.Value);
            }
            this.Close();
        }






        private void _gbtnAnuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
