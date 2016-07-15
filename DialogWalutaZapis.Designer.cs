namespace GranitSkarbGUI.OknaDialogowe
{
    partial class DialogWalutaZapis
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DialogWalutaZapis));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.reflectionLabel2 = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this._gbtnZatwierdzZakoncz = new GranitControls.GranitButton();
            this._gbtnAnuluj = new GranitControls.GranitButton();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this._doubleInputWINwal = new DevComponents.Editors.DoubleInput();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this._doubleInputMAwal = new DevComponents.Editors.DoubleInput();
            this.DataSetWaluty = new System.Data.DataSet();
            this.BindingSourceWalutyCombobox = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._doubleInputWINwal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._doubleInputMAwal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetWaluty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSourceWalutyCombobox)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.reflectionLabel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel6, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(462, 152);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // reflectionLabel2
            // 
            // 
            // 
            // 
            this.reflectionLabel2.BackgroundStyle.Class = "";
            this.reflectionLabel2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.reflectionLabel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reflectionLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.reflectionLabel2.Location = new System.Drawing.Point(3, 3);
            this.reflectionLabel2.Name = "reflectionLabel2";
            this.reflectionLabel2.Size = new System.Drawing.Size(456, 64);
            this.reflectionLabel2.TabIndex = 8;
            this.reflectionLabel2.TabStop = false;
            this.reflectionLabel2.Text = "<div align=\"center\"><font color=\"#602826\">Podaj WinWal i MaWal</font></div>";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Controls.Add(this._gbtnZatwierdzZakoncz, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this._gbtnAnuluj, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 108);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(462, 44);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // _gbtnZatwierdzZakoncz
            // 
            this._gbtnZatwierdzZakoncz.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this._gbtnZatwierdzZakoncz.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._gbtnZatwierdzZakoncz.ButtonType = GranitControls.GranitButton.BType.Accept;
            this._gbtnZatwierdzZakoncz.CallBasePaintBackground = true;
            this._gbtnZatwierdzZakoncz.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this._gbtnZatwierdzZakoncz.Image = ((System.Drawing.Image)(resources.GetObject("_gbtnZatwierdzZakoncz.Image")));
            this._gbtnZatwierdzZakoncz.Location = new System.Drawing.Point(17, 3);
            this._gbtnZatwierdzZakoncz.Name = "_gbtnZatwierdzZakoncz";
            this._gbtnZatwierdzZakoncz.Size = new System.Drawing.Size(120, 38);
            this._gbtnZatwierdzZakoncz.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this._gbtnZatwierdzZakoncz.TabIndex = 2;
            this._gbtnZatwierdzZakoncz.Text = "Zatwierdź i przypisz";
            this._gbtnZatwierdzZakoncz.Click += new System.EventHandler(this._gbtnZatwierdzZakoncz_Click);
            // 
            // _gbtnAnuluj
            // 
            this._gbtnAnuluj.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this._gbtnAnuluj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._gbtnAnuluj.ButtonType = GranitControls.GranitButton.BType.Cancel;
            this._gbtnAnuluj.CallBasePaintBackground = true;
            this._gbtnAnuluj.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this._gbtnAnuluj.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._gbtnAnuluj.Image = ((System.Drawing.Image)(resources.GetObject("_gbtnAnuluj.Image")));
            this._gbtnAnuluj.Location = new System.Drawing.Point(325, 3);
            this._gbtnAnuluj.Name = "_gbtnAnuluj";
            this._gbtnAnuluj.Size = new System.Drawing.Size(120, 38);
            this._gbtnAnuluj.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this._gbtnAnuluj.TabIndex = 1;
            this._gbtnAnuluj.Text = "Anuluj";
            this._gbtnAnuluj.Click += new System.EventHandler(this._gbtnAnuluj_Click);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 4;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 511F));
            this.tableLayoutPanel6.Controls.Add(this._doubleInputWINwal, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.labelX5, 2, 0);
            this.tableLayoutPanel6.Controls.Add(this.labelX4, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this._doubleInputMAwal, 3, 0);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 70);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(462, 29);
            this.tableLayoutPanel6.TabIndex = 3;
            // 
            // _doubleInputWINwal
            // 
            this._doubleInputWINwal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this._doubleInputWINwal.BackgroundStyle.Class = "DateTimeInputBackground";
            this._doubleInputWINwal.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this._doubleInputWINwal.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this._doubleInputWINwal.Increment = 1D;
            this._doubleInputWINwal.Location = new System.Drawing.Point(55, 4);
            this._doubleInputWINwal.MinValue = 0D;
            this._doubleInputWINwal.Name = "_doubleInputWINwal";
            this._doubleInputWINwal.Size = new System.Drawing.Size(164, 20);
            this._doubleInputWINwal.TabIndex = 7;
            // 
            // labelX5
            // 
            this.labelX5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelX5.AutoSize = true;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.Class = "";
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(243, 7);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(44, 15);
            this.labelX5.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.labelX5.TabIndex = 6;
            this.labelX5.Text = "MA Wal:";
            // 
            // labelX4
            // 
            this.labelX4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelX4.AutoSize = true;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.Class = "";
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(3, 7);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(49, 15);
            this.labelX4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.labelX4.TabIndex = 5;
            this.labelX4.Text = "WIN Wal:";
            // 
            // _doubleInputMAwal
            // 
            // 
            // 
            // 
            this._doubleInputMAwal.BackgroundStyle.Class = "DateTimeInputBackground";
            this._doubleInputMAwal.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this._doubleInputMAwal.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this._doubleInputMAwal.Increment = 1D;
            this._doubleInputMAwal.Location = new System.Drawing.Point(293, 3);
            this._doubleInputMAwal.MinValue = 0D;
            this._doubleInputMAwal.Name = "_doubleInputMAwal";
            this._doubleInputMAwal.Size = new System.Drawing.Size(165, 20);
            this._doubleInputMAwal.TabIndex = 8;
            // 
            // DataSetWaluty
            // 
            this.DataSetWaluty.DataSetName = "DataSetWaluty";
            // 
            // BindingSourceWalutyCombobox
            // 
            this.BindingSourceWalutyCombobox.DataSource = this.DataSetWaluty;
            this.BindingSourceWalutyCombobox.Position = 0;
            // 
            // DialogWalutaZapis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(462, 152);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(468, 178);
            this.MinimumSize = new System.Drawing.Size(468, 178);
            this.Name = "DialogWalutaZapis";
            this.Text = " ";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._doubleInputWINwal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._doubleInputMAwal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetWaluty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSourceWalutyCombobox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevComponents.DotNetBar.Controls.ReflectionLabel reflectionLabel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private GranitControls.GranitButton _gbtnZatwierdzZakoncz;
        private GranitControls.GranitButton _gbtnAnuluj;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.Editors.DoubleInput _doubleInputWINwal;
        private DevComponents.Editors.DoubleInput _doubleInputMAwal;
        private System.Data.DataSet DataSetWaluty;
        private System.Windows.Forms.BindingSource BindingSourceWalutyCombobox;
    }
}