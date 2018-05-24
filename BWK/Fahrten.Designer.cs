namespace BWK
{
    partial class Fahrten
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.comboBoxFahrer = new System.Windows.Forms.ComboBox();
            this.comboBoxMounts = new System.Windows.Forms.ComboBox();
            this.buttonMountAuswähl = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.comboBoxKunde = new System.Windows.Forms.ComboBox();
            this.buttonFahrerInfo = new System.Windows.Forms.Button();
            this.buttonKundeInfo = new System.Windows.Forms.Button();
            this.dataGridViewTable = new System.Windows.Forms.DataGridView();
            this.Nr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kunde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fahrer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fahrzeug = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Typ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PLZ1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Abholung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PLZ2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zustellung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.km = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Betrag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Extras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fahrer_km = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fahrer_Betrag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bemerkung_Typ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bemerkung_Betrag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fahrerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kundenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kundenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonExportFahrten = new System.Windows.Forms.Button();
            this.labelExport = new System.Windows.Forms.Label();
            this.labelAnimation = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxTypBemerkung = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTable)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxFahrer
            // 
            this.comboBoxFahrer.FormattingEnabled = true;
            this.comboBoxFahrer.Location = new System.Drawing.Point(107, 61);
            this.comboBoxFahrer.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxFahrer.Name = "comboBoxFahrer";
            this.comboBoxFahrer.Size = new System.Drawing.Size(92, 21);
            this.comboBoxFahrer.TabIndex = 0;
            // 
            // comboBoxMounts
            // 
            this.comboBoxMounts.FormattingEnabled = true;
            this.comboBoxMounts.Location = new System.Drawing.Point(11, 61);
            this.comboBoxMounts.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxMounts.Name = "comboBoxMounts";
            this.comboBoxMounts.Size = new System.Drawing.Size(92, 21);
            this.comboBoxMounts.TabIndex = 1;
            // 
            // buttonMountAuswähl
            // 
            this.buttonMountAuswähl.Location = new System.Drawing.Point(11, 86);
            this.buttonMountAuswähl.Margin = new System.Windows.Forms.Padding(2);
            this.buttonMountAuswähl.Name = "buttonMountAuswähl";
            this.buttonMountAuswähl.Size = new System.Drawing.Size(92, 21);
            this.buttonMountAuswähl.TabIndex = 2;
            this.buttonMountAuswähl.Text = "Mount";
            this.buttonMountAuswähl.UseVisualStyleBackColor = true;
            this.buttonMountAuswähl.Click += new System.EventHandler(this.buttonMountAuswähl_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(11, 36);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1400, 21);
            this.progressBar1.TabIndex = 3;
            // 
            // comboBoxKunde
            // 
            this.comboBoxKunde.FormattingEnabled = true;
            this.comboBoxKunde.Location = new System.Drawing.Point(1296, 64);
            this.comboBoxKunde.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxKunde.Name = "comboBoxKunde";
            this.comboBoxKunde.Size = new System.Drawing.Size(92, 21);
            this.comboBoxKunde.TabIndex = 4;
            // 
            // buttonFahrerInfo
            // 
            this.buttonFahrerInfo.Location = new System.Drawing.Point(107, 86);
            this.buttonFahrerInfo.Margin = new System.Windows.Forms.Padding(2);
            this.buttonFahrerInfo.Name = "buttonFahrerInfo";
            this.buttonFahrerInfo.Size = new System.Drawing.Size(92, 21);
            this.buttonFahrerInfo.TabIndex = 5;
            this.buttonFahrerInfo.Text = "Fahrer";
            this.buttonFahrerInfo.UseVisualStyleBackColor = true;
            this.buttonFahrerInfo.Click += new System.EventHandler(this.buttonFahrerInfo_Click);
            // 
            // buttonKundeInfo
            // 
            this.buttonKundeInfo.Location = new System.Drawing.Point(1296, 89);
            this.buttonKundeInfo.Margin = new System.Windows.Forms.Padding(2);
            this.buttonKundeInfo.Name = "buttonKundeInfo";
            this.buttonKundeInfo.Size = new System.Drawing.Size(92, 21);
            this.buttonKundeInfo.TabIndex = 6;
            this.buttonKundeInfo.Text = "Kunde";
            this.buttonKundeInfo.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTable
            // 
            this.dataGridViewTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nr,
            this.Kunde,
            this.Fahrer,
            this.Datum,
            this.Fahrzeug,
            this.Typ,
            this.PLZ1,
            this.Abholung,
            this.PLZ2,
            this.Zustellung,
            this.km,
            this.Preis,
            this.Betrag,
            this.Extras,
            this.Fahrer_km,
            this.Fahrer_Betrag,
            this.Bemerkung_Typ,
            this.Bemerkung_Betrag});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTable.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTable.Location = new System.Drawing.Point(4, 140);
            this.dataGridViewTable.Name = "dataGridViewTable";
            this.dataGridViewTable.Size = new System.Drawing.Size(1384, 525);
            this.dataGridViewTable.TabIndex = 7;
            this.dataGridViewTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTable_CellContentClick);
            // 
            // Nr
            // 
            this.Nr.HeaderText = "#";
            this.Nr.Name = "Nr";
            this.Nr.Width = 30;
            // 
            // Kunde
            // 
            this.Kunde.HeaderText = "Kunde";
            this.Kunde.Name = "Kunde";
            this.Kunde.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Kunde.Width = 80;
            // 
            // Fahrer
            // 
            this.Fahrer.HeaderText = "Fahrer";
            this.Fahrer.Name = "Fahrer";
            this.Fahrer.Width = 80;
            // 
            // Datum
            // 
            this.Datum.HeaderText = "Datum";
            this.Datum.Name = "Datum";
            this.Datum.Width = 80;
            // 
            // Fahrzeug
            // 
            this.Fahrzeug.HeaderText = "MZ-";
            this.Fahrzeug.Name = "Fahrzeug";
            this.Fahrzeug.Width = 65;
            // 
            // Typ
            // 
            this.Typ.HeaderText = "Typ";
            this.Typ.Name = "Typ";
            this.Typ.Width = 65;
            // 
            // PLZ1
            // 
            this.PLZ1.HeaderText = "PLZ1";
            this.PLZ1.Name = "PLZ1";
            // 
            // Abholung
            // 
            this.Abholung.HeaderText = "Abholung";
            this.Abholung.Name = "Abholung";
            // 
            // PLZ2
            // 
            this.PLZ2.HeaderText = "PLZ2";
            this.PLZ2.Name = "PLZ2";
            // 
            // Zustellung
            // 
            this.Zustellung.HeaderText = "Zustellung";
            this.Zustellung.Name = "Zustellung";
            // 
            // km
            // 
            this.km.HeaderText = "km";
            this.km.Name = "km";
            this.km.Width = 50;
            // 
            // Preis
            // 
            this.Preis.HeaderText = "Preis";
            this.Preis.Name = "Preis";
            this.Preis.Width = 50;
            // 
            // Betrag
            // 
            this.Betrag.HeaderText = "Betrag";
            this.Betrag.Name = "Betrag";
            this.Betrag.Width = 50;
            // 
            // Extras
            // 
            this.Extras.HeaderText = "Extras";
            this.Extras.Name = "Extras";
            this.Extras.Width = 50;
            // 
            // Fahrer_km
            // 
            this.Fahrer_km.HeaderText = "Fahrer_km";
            this.Fahrer_km.Name = "Fahrer_km";
            this.Fahrer_km.Width = 60;
            // 
            // Fahrer_Betrag
            // 
            this.Fahrer_Betrag.HeaderText = "Fahrer_Betrag";
            this.Fahrer_Betrag.Name = "Fahrer_Betrag";
            this.Fahrer_Betrag.Width = 80;
            // 
            // Bemerkung_Typ
            // 
            this.Bemerkung_Typ.HeaderText = "Bemerkung_Typ";
            this.Bemerkung_Typ.Name = "Bemerkung_Typ";
            this.Bemerkung_Typ.Width = 90;
            // 
            // Bemerkung_Betrag
            // 
            this.Bemerkung_Betrag.HeaderText = "Bemerkung_Betrag";
            this.Bemerkung_Betrag.Name = "Bemerkung_Betrag";
            this.Bemerkung_Betrag.Width = 105;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1400, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fahrerToolStripMenuItem,
            this.kundenToolStripMenuItem,
            this.kundenToolStripMenuItem1});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(117, 20);
            this.toolStripMenuItem1.Text = "Veränderund Table";
            // 
            // fahrerToolStripMenuItem
            // 
            this.fahrerToolStripMenuItem.Name = "fahrerToolStripMenuItem";
            this.fahrerToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.fahrerToolStripMenuItem.Text = "Fahrten";
            this.fahrerToolStripMenuItem.Click += new System.EventHandler(this.fahrerToolStripMenuItem_Click);
            // 
            // kundenToolStripMenuItem
            // 
            this.kundenToolStripMenuItem.Name = "kundenToolStripMenuItem";
            this.kundenToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.kundenToolStripMenuItem.Text = "Fahrer";
            this.kundenToolStripMenuItem.Click += new System.EventHandler(this.kundenToolStripMenuItem_Click);
            // 
            // kundenToolStripMenuItem1
            // 
            this.kundenToolStripMenuItem1.Name = "kundenToolStripMenuItem1";
            this.kundenToolStripMenuItem1.Size = new System.Drawing.Size(115, 22);
            this.kundenToolStripMenuItem1.Text = "Kunden";
            // 
            // buttonExportFahrten
            // 
            this.buttonExportFahrten.Location = new System.Drawing.Point(107, 111);
            this.buttonExportFahrten.Margin = new System.Windows.Forms.Padding(2);
            this.buttonExportFahrten.Name = "buttonExportFahrten";
            this.buttonExportFahrten.Size = new System.Drawing.Size(92, 21);
            this.buttonExportFahrten.TabIndex = 10;
            this.buttonExportFahrten.Text = "Export";
            this.buttonExportFahrten.UseVisualStyleBackColor = true;
            this.buttonExportFahrten.Click += new System.EventHandler(this.buttonExportFahrten_Click);
            // 
            // labelExport
            // 
            this.labelExport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelExport.Location = new System.Drawing.Point(998, 59);
            this.labelExport.Name = "labelExport";
            this.labelExport.Size = new System.Drawing.Size(129, 78);
            this.labelExport.TabIndex = 11;
            this.labelExport.Text = "Einlesen";
            this.labelExport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelExport.Visible = false;
            // 
            // labelAnimation
            // 
            this.labelAnimation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAnimation.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAnimation.Location = new System.Drawing.Point(1118, 59);
            this.labelAnimation.Name = "labelAnimation";
            this.labelAnimation.Size = new System.Drawing.Size(129, 78);
            this.labelAnimation.TabIndex = 12;
            this.labelAnimation.Text = "...";
            this.labelAnimation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelAnimation.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(306, 111);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 21);
            this.button1.TabIndex = 13;
            this.button1.Text = "Add Bemerkung";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBoxTypBemerkung
            // 
            this.textBoxTypBemerkung.Location = new System.Drawing.Point(306, 61);
            this.textBoxTypBemerkung.Name = "textBoxTypBemerkung";
            this.textBoxTypBemerkung.Size = new System.Drawing.Size(100, 20);
            this.textBoxTypBemerkung.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(265, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Typ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Preis";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(306, 86);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            30000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            30000,
            0,
            0,
            -2147483648});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 18;
            // 
            // Fahrten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 668);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxTypBemerkung);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelAnimation);
            this.Controls.Add(this.labelExport);
            this.Controls.Add(this.buttonExportFahrten);
            this.Controls.Add(this.dataGridViewTable);
            this.Controls.Add(this.buttonKundeInfo);
            this.Controls.Add(this.buttonFahrerInfo);
            this.Controls.Add(this.comboBoxKunde);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.buttonMountAuswähl);
            this.Controls.Add(this.comboBoxMounts);
            this.Controls.Add(this.comboBoxFahrer);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Fahrten";
            this.Text = "Fahrten";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Fahrten_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTable)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxFahrer;
        private System.Windows.Forms.ComboBox comboBoxMounts;
        private System.Windows.Forms.Button buttonMountAuswähl;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ComboBox comboBoxKunde;
        private System.Windows.Forms.Button buttonFahrerInfo;
        private System.Windows.Forms.Button buttonKundeInfo;
        private System.Windows.Forms.DataGridView dataGridViewTable;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fahrerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kundenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kundenToolStripMenuItem1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kunde;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fahrer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fahrzeug;
        private System.Windows.Forms.DataGridViewTextBoxColumn Typ;
        private System.Windows.Forms.DataGridViewTextBoxColumn PLZ1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Abholung;
        private System.Windows.Forms.DataGridViewTextBoxColumn PLZ2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zustellung;
        private System.Windows.Forms.DataGridViewTextBoxColumn km;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Betrag;
        private System.Windows.Forms.DataGridViewTextBoxColumn Extras;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fahrer_km;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fahrer_Betrag;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bemerkung_Typ;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bemerkung_Betrag;
        private System.Windows.Forms.Button buttonExportFahrten;
        private System.Windows.Forms.Label labelExport;
        private System.Windows.Forms.Label labelAnimation;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxTypBemerkung;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

