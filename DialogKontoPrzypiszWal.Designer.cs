namespace GranitSkarbGUI.OknaDialogowe
{
    partial class DialogKontoPrzypiszWal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DialogKontoPrzypiszWal));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.reflectionLabel2 = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this._gbtnDodajWalute = new GranitControls.GranitButton();
            this._gbtnZatwierdzZakoncz = new GranitControls.GranitButton();
            this.tableLayoutPanel12 = new System.Windows.Forms.TableLayoutPanel();
            this._comboWaluta = new GranitControls.ComboTreeSearch();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.DataSetWaluty = new System.Data.DataSet();
            this.BindingSourceWalutyCombobox = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel12.SuspendLayout();
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
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel12, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
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
            this.reflectionLabel2.Size = new System.Drawing.Size(456, 44);
            this.reflectionLabel2.TabIndex = 8;
            this.reflectionLabel2.TabStop = false;
            this.reflectionLabel2.Text = "<div align=\"center\"><font color=\"#602826\">Przypisz walutę</font></div>";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Controls.Add(this._gbtnDodajWalute, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this._gbtnZatwierdzZakoncz, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 108);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(462, 44);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // _gbtnDodajWalute
            // 
            this._gbtnDodajWalute.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this._gbtnDodajWalute.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._gbtnDodajWalute.ButtonType = GranitControls.GranitButton.BType.Accept;
            this._gbtnDodajWalute.CallBasePaintBackground = true;
            this._gbtnDodajWalute.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this._gbtnDodajWalute.Image = global::GranitSkarbGUI.Properties.Resources.AddNext;
            this._gbtnDodajWalute.Location = new System.Drawing.Point(17, 3);
            this._gbtnDodajWalute.Name = "_gbtnDodajWalute";
            this._gbtnDodajWalute.Size = new System.Drawing.Size(120, 38);
            this._gbtnDodajWalute.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this._gbtnDodajWalute.TabIndex = 0;
            this._gbtnDodajWalute.Text = "Dodaj nową walute";
            this._gbtnDodajWalute.Click += new System.EventHandler(this._gbtnDodajWalute_Click);
            // 
            // _gbtnZatwierdzZakoncz
            // 
            this._gbtnZatwierdzZakoncz.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this._gbtnZatwierdzZakoncz.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._gbtnZatwierdzZakoncz.ButtonType = GranitControls.GranitButton.BType.Accept;
            this._gbtnZatwierdzZakoncz.CallBasePaintBackground = true;
            this._gbtnZatwierdzZakoncz.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this._gbtnZatwierdzZakoncz.Image = ((System.Drawing.Image)(resources.GetObject("_gbtnZatwierdzZakoncz.Image")));
            this._gbtnZatwierdzZakoncz.Location = new System.Drawing.Point(325, 3);
            this._gbtnZatwierdzZakoncz.Name = "_gbtnZatwierdzZakoncz";
            this._gbtnZatwierdzZakoncz.Size = new System.Drawing.Size(120, 38);
            this._gbtnZatwierdzZakoncz.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this._gbtnZatwierdzZakoncz.TabIndex = 2;
            this._gbtnZatwierdzZakoncz.Text = "Zatwierdź i przypisz";
            this._gbtnZatwierdzZakoncz.Click += new System.EventHandler(this._gbtnZatwierdzZakoncz_Click);
            // 
            // tableLayoutPanel12
            // 
            this.tableLayoutPanel12.ColumnCount = 2;
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.46132F));
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 88.53868F));
            this.tableLayoutPanel12.Controls.Add(this._comboWaluta, 1, 0);
            this.tableLayoutPanel12.Controls.Add(this.labelX10, 0, 0);
            this.tableLayoutPanel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel12.Location = new System.Drawing.Point(0, 50);
            this.tableLayoutPanel12.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel12.Name = "tableLayoutPanel12";
            this.tableLayoutPanel12.RowCount = 1;
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel12.Size = new System.Drawing.Size(462, 58);
            this.tableLayoutPanel12.TabIndex = 0;
            // 
            // _comboWaluta
            // 
            this._comboWaluta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._comboWaluta.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this._comboWaluta.BackgroundStyle.Class = "";
            this._comboWaluta.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this._comboWaluta.ButtonClear.DisplayPosition = 2;
            this._comboWaluta.ButtonClear.Image = global::GranitSkarbGUI.Properties.Resources.zapisy16;
            this._comboWaluta.ButtonCustom.Image = global::GranitSkarbGUI.Properties.Resources.Dodawanie16;
            this._comboWaluta.ButtonCustom.Visible = true;
            this._comboWaluta.ButtonCustom2.DisplayPosition = 1;
            this._comboWaluta.ButtonCustom2.Image = global::GranitSkarbGUI.Properties.Resources.filtr16;
            this._comboWaluta.ButtonCustom2.Visible = true;
            this._comboWaluta.ButtonDropDown.Visible = true;
            this._comboWaluta.DisplayMembers = "ID_DOKUMENTU";
            this._comboWaluta.DropDownHeight = 400;
            this._comboWaluta.DropDownWidth = 612;
            this._comboWaluta.KeyboardSearchEnabled = false;
            this._comboWaluta.KeyboardSearchNoSelectionAllowed = false;
            this._comboWaluta.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this._comboWaluta.Location = new System.Drawing.Point(55, 17);
            this._comboWaluta.Name = "_comboWaluta";
            this._comboWaluta.Size = new System.Drawing.Size(404, 23);
            this._comboWaluta.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this._comboWaluta.TabIndex = 1;
            this._comboWaluta.ValueMember = "ID_DOKUMENTU";
            // 
            // labelX10
            // 
            this.labelX10.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelX10.AutoSize = true;
            // 
            // 
            // 
            this.labelX10.BackgroundStyle.Class = "";
            this.labelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX10.Location = new System.Drawing.Point(9, 21);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(40, 15);
            this.labelX10.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.labelX10.TabIndex = 4;
            this.labelX10.Text = "Waluta:";
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
            // DialogKontoPrzypiszWal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(462, 152);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(468, 178);
            this.MinimumSize = new System.Drawing.Size(468, 178);
            this.Name = "DialogKontoPrzypiszWal";
            this.Text = " ";
            this.Load += new System.EventHandler(this.DialogKontoPrzypiszWal_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel12.ResumeLayout(false);
            this.tableLayoutPanel12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetWaluty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSourceWalutyCombobox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevComponents.DotNetBar.Controls.ReflectionLabel reflectionLabel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private GranitControls.GranitButton _gbtnZatwierdzZakoncz;
        private GranitControls.GranitButton _gbtnDodajWalute;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel12;
        private GranitControls.ComboTreeSearch _comboWaluta;
        private DevComponents.DotNetBar.LabelX labelX10;
        private System.Data.DataSet DataSetWaluty;
        private System.Windows.Forms.BindingSource BindingSourceWalutyCombobox;
    }
}