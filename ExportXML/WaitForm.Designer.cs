namespace ExportXML
{
    partial class WaitForm
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
            this.tlpNaglowek = new System.Windows.Forms.TableLayoutPanel();
            this.lbxTemat = new DevComponents.DotNetBar.LabelX();
            this.tbxTemat = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tlpWyslijDokMailem = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.tbxAdresEmail = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbxTrescWiadomosci = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.ipWyborFormatow = new DevComponents.DotNetBar.ItemPanel();
            this.cbiXML = new DevComponents.DotNetBar.CheckBoxItem();
            this.btniWyslij = new DevComponents.DotNetBar.ButtonX();
            this.btniAnuluj = new DevComponents.DotNetBar.ButtonX();
            this.tlpNaglowek.SuspendLayout();
            this.tlpWyslijDokMailem.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpNaglowek
            // 
            this.tlpNaglowek.ColumnCount = 2;
            this.tlpWyslijDokMailem.SetColumnSpan(this.tlpNaglowek, 5);
            this.tlpNaglowek.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpNaglowek.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpNaglowek.Controls.Add(this.lbxTemat, 0, 0);
            this.tlpNaglowek.Controls.Add(this.tbxTemat, 1, 0);
            this.tlpNaglowek.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpNaglowek.Location = new System.Drawing.Point(3, 33);
            this.tlpNaglowek.Name = "tlpNaglowek";
            this.tlpNaglowek.RowCount = 1;
            this.tlpNaglowek.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.7037F));
            this.tlpNaglowek.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tlpNaglowek.Size = new System.Drawing.Size(559, 24);
            this.tlpNaglowek.TabIndex = 6;
            // 
            // lbxTemat
            // 
            // 
            // 
            // 
            this.lbxTemat.BackgroundStyle.Class = "";
            this.lbxTemat.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbxTemat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbxTemat.Location = new System.Drawing.Point(3, 3);
            this.lbxTemat.Name = "lbxTemat";
            this.lbxTemat.Size = new System.Drawing.Size(54, 18);
            this.lbxTemat.TabIndex = 1;
            this.lbxTemat.Text = "Temat:";
            this.lbxTemat.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // tbxTemat
            // 
            // 
            // 
            // 
            this.tbxTemat.Border.Class = "TextBoxBorder";
            this.tbxTemat.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbxTemat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxTemat.Location = new System.Drawing.Point(60, 0);
            this.tbxTemat.Margin = new System.Windows.Forms.Padding(0);
            this.tbxTemat.Multiline = true;
            this.tbxTemat.Name = "tbxTemat";
            this.tbxTemat.Size = new System.Drawing.Size(499, 24);
            this.tbxTemat.TabIndex = 1;
            // 
            // tlpWyslijDokMailem
            // 
            this.tlpWyslijDokMailem.ColumnCount = 5;
            this.tlpWyslijDokMailem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.tlpWyslijDokMailem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpWyslijDokMailem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tlpWyslijDokMailem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tlpWyslijDokMailem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.tlpWyslijDokMailem.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tlpWyslijDokMailem.Controls.Add(this.tbxTrescWiadomosci, 1, 2);
            this.tlpWyslijDokMailem.Controls.Add(this.ipWyborFormatow, 0, 2);
            this.tlpWyslijDokMailem.Controls.Add(this.tlpNaglowek, 0, 1);
            this.tlpWyslijDokMailem.Controls.Add(this.btniWyslij, 2, 3);
            this.tlpWyslijDokMailem.Controls.Add(this.btniAnuluj, 3, 3);
            this.tlpWyslijDokMailem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpWyslijDokMailem.Location = new System.Drawing.Point(0, 0);
            this.tlpWyslijDokMailem.Name = "tlpWyslijDokMailem";
            this.tlpWyslijDokMailem.RowCount = 4;
            this.tlpWyslijDokMailem.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpWyslijDokMailem.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpWyslijDokMailem.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 229F));
            this.tlpWyslijDokMailem.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.65306F));
            this.tlpWyslijDokMailem.Size = new System.Drawing.Size(565, 321);
            this.tlpWyslijDokMailem.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tlpWyslijDokMailem.SetColumnSpan(this.tableLayoutPanel1, 5);
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.labelX1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbxAdresEmail, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.7037F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(559, 24);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelX1.Location = new System.Drawing.Point(3, 3);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(54, 18);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "E-mail:";
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // tbxAdresEmail
            // 
            // 
            // 
            // 
            this.tbxAdresEmail.Border.Class = "TextBoxBorder";
            this.tbxAdresEmail.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbxAdresEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxAdresEmail.Location = new System.Drawing.Point(60, 0);
            this.tbxAdresEmail.Margin = new System.Windows.Forms.Padding(0);
            this.tbxAdresEmail.Multiline = true;
            this.tbxAdresEmail.Name = "tbxAdresEmail";
            this.tbxAdresEmail.Size = new System.Drawing.Size(499, 24);
            this.tbxAdresEmail.TabIndex = 1;
            // 
            // tbxTrescWiadomosci
            // 
            // 
            // 
            // 
            this.tbxTrescWiadomosci.Border.Class = "TextBoxBorder";
            this.tbxTrescWiadomosci.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tlpWyslijDokMailem.SetColumnSpan(this.tbxTrescWiadomosci, 4);
            this.tbxTrescWiadomosci.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxTrescWiadomosci.Location = new System.Drawing.Point(64, 60);
            this.tbxTrescWiadomosci.Margin = new System.Windows.Forms.Padding(1, 0, 3, 0);
            this.tbxTrescWiadomosci.Multiline = true;
            this.tbxTrescWiadomosci.Name = "tbxTrescWiadomosci";
            this.tbxTrescWiadomosci.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxTrescWiadomosci.Size = new System.Drawing.Size(498, 229);
            this.tbxTrescWiadomosci.TabIndex = 0;
            // 
            // ipWyborFormatow
            // 
            // 
            // 
            // 
            this.ipWyborFormatow.BackgroundStyle.Class = "ItemPanel";
            this.ipWyborFormatow.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ipWyborFormatow.ContainerControlProcessDialogKey = true;
            this.ipWyborFormatow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ipWyborFormatow.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.cbiXML});
            this.ipWyborFormatow.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.ipWyborFormatow.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.ipWyborFormatow.Location = new System.Drawing.Point(3, 60);
            this.ipWyborFormatow.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.ipWyborFormatow.Name = "ipWyborFormatow";
            this.ipWyborFormatow.Size = new System.Drawing.Size(60, 229);
            this.ipWyborFormatow.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ipWyborFormatow.TabIndex = 1;
            this.ipWyborFormatow.Text = "itemPanel2";
            // 
            // cbiXML
            // 
            this.cbiXML.Checked = true;
            this.cbiXML.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbiXML.Enabled = false;
            this.cbiXML.Name = "cbiXML";
            this.cbiXML.Text = "XML";
            this.cbiXML.TextColor = System.Drawing.Color.DodgerBlue;
            // 
            // btniWyslij
            // 
            this.btniWyslij.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btniWyslij.CallBasePaintBackground = true;
            this.btniWyslij.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btniWyslij.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btniWyslij.Location = new System.Drawing.Point(265, 292);
            this.btniWyslij.Name = "btniWyslij";
            this.btniWyslij.Size = new System.Drawing.Size(114, 26);
            this.btniWyslij.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btniWyslij.TabIndex = 2;
            this.btniWyslij.Text = "Wyślij";
            this.btniWyslij.Click += new System.EventHandler(this.btniWyslij_Click);
            // 
            // btniAnuluj
            // 
            this.btniAnuluj.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btniAnuluj.CallBasePaintBackground = true;
            this.btniAnuluj.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btniAnuluj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btniAnuluj.Location = new System.Drawing.Point(385, 292);
            this.btniAnuluj.Name = "btniAnuluj";
            this.btniAnuluj.Size = new System.Drawing.Size(114, 26);
            this.btniAnuluj.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btniAnuluj.TabIndex = 3;
            this.btniAnuluj.Text = "Anuluj";
            this.btniAnuluj.Click += new System.EventHandler(this.btniAnuluj_Click);
            // 
            // WaitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(565, 321);
            this.Controls.Add(this.tlpWyslijDokMailem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "WaitForm";
            this.Text = "Wyślij fakturę mailem jako XML";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tlpNaglowek.ResumeLayout(false);
            this.tlpWyslijDokMailem.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpNaglowek;
        private System.Windows.Forms.TableLayoutPanel tlpWyslijDokMailem;
        private DevComponents.DotNetBar.ItemPanel ipWyborFormatow;
        private DevComponents.DotNetBar.CheckBoxItem cbiXML;
        private DevComponents.DotNetBar.ButtonX btniWyslij;
        private DevComponents.DotNetBar.ButtonX btniAnuluj;
        private DevComponents.DotNetBar.LabelX lbxTemat;
        private DevComponents.DotNetBar.Controls.TextBoxX tbxTemat;
        public DevComponents.DotNetBar.Controls.TextBoxX tbxTrescWiadomosci;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX tbxAdresEmail;



    }
}

