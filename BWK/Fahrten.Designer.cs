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
            this.Abholung = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.buttonLadungFahrtenTable = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTable)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxFahrer
            // 
            this.comboBoxFahrer.FormattingEnabled = true;
            this.comboBoxFahrer.Location = new System.Drawing.Point(11, 137);
            this.comboBoxFahrer.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxFahrer.Name = "comboBoxFahrer";
            this.comboBoxFahrer.Size = new System.Drawing.Size(92, 21);
            this.comboBoxFahrer.TabIndex = 0;
            // 
            // comboBoxMounts
            // 
            this.comboBoxMounts.FormattingEnabled = true;
            this.comboBoxMounts.Location = new System.Drawing.Point(11, 102);
            this.comboBoxMounts.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxMounts.Name = "comboBoxMounts";
            this.comboBoxMounts.Size = new System.Drawing.Size(92, 21);
            this.comboBoxMounts.TabIndex = 1;
            // 
            // buttonMountAuswähl
            // 
            this.buttonMountAuswähl.Location = new System.Drawing.Point(107, 102);
            this.buttonMountAuswähl.Margin = new System.Windows.Forms.Padding(2);
            this.buttonMountAuswähl.Name = "buttonMountAuswähl";
            this.buttonMountAuswähl.Size = new System.Drawing.Size(117, 21);
            this.buttonMountAuswähl.TabIndex = 2;
            this.buttonMountAuswähl.Text = "Mount";
            this.buttonMountAuswähl.UseVisualStyleBackColor = true;
            this.buttonMountAuswähl.Click += new System.EventHandler(this.buttonMountAuswähl_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(7, 213);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(217, 19);
            this.progressBar1.TabIndex = 3;
            // 
            // comboBoxKunde
            // 
            this.comboBoxKunde.FormattingEnabled = true;
            this.comboBoxKunde.Location = new System.Drawing.Point(11, 175);
            this.comboBoxKunde.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxKunde.Name = "comboBoxKunde";
            this.comboBoxKunde.Size = new System.Drawing.Size(92, 21);
            this.comboBoxKunde.TabIndex = 4;
            // 
            // buttonFahrerInfo
            // 
            this.buttonFahrerInfo.Location = new System.Drawing.Point(107, 137);
            this.buttonFahrerInfo.Margin = new System.Windows.Forms.Padding(2);
            this.buttonFahrerInfo.Name = "buttonFahrerInfo";
            this.buttonFahrerInfo.Size = new System.Drawing.Size(117, 21);
            this.buttonFahrerInfo.TabIndex = 5;
            this.buttonFahrerInfo.Text = "Fahrer";
            this.buttonFahrerInfo.UseVisualStyleBackColor = true;
            this.buttonFahrerInfo.Click += new System.EventHandler(this.buttonFahrerInfo_Click);
            // 
            // buttonKundeInfo
            // 
            this.buttonKundeInfo.Location = new System.Drawing.Point(107, 175);
            this.buttonKundeInfo.Margin = new System.Windows.Forms.Padding(2);
            this.buttonKundeInfo.Name = "buttonKundeInfo";
            this.buttonKundeInfo.Size = new System.Drawing.Size(117, 21);
            this.buttonKundeInfo.TabIndex = 6;
            this.buttonKundeInfo.Text = "Kunde";
            this.buttonKundeInfo.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTable
            // 
            this.dataGridViewTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nr,
            this.Kunde,
            this.Fahrer,
            this.Datum,
            this.Fahrzeug,
            this.Abholung,
            this.Zustellung,
            this.km,
            this.Preis,
            this.Betrag,
            this.Extras,
            this.Fahrer_km,
            this.Fahrer_Betrag,
            this.Bemerkung_Typ,
            this.Bemerkung_Betrag});
            this.dataGridViewTable.Location = new System.Drawing.Point(229, 12);
            this.dataGridViewTable.Name = "dataGridViewTable";
            this.dataGridViewTable.Size = new System.Drawing.Size(1183, 537);
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
            this.Fahrzeug.HeaderText = "Fahrzeug";
            this.Fahrzeug.Name = "Fahrzeug";
            this.Fahrzeug.Width = 130;
            // 
            // Abholung
            // 
            this.Abholung.HeaderText = "Abholung";
            this.Abholung.Name = "Abholung";
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
            this.menuStrip1.Size = new System.Drawing.Size(1429, 24);
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
            this.fahrerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.fahrerToolStripMenuItem.Text = "Fahrten";
            this.fahrerToolStripMenuItem.Click += new System.EventHandler(this.fahrerToolStripMenuItem_Click);
            // 
            // kundenToolStripMenuItem
            // 
            this.kundenToolStripMenuItem.Name = "kundenToolStripMenuItem";
            this.kundenToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.kundenToolStripMenuItem.Text = "Fahrer";
            this.kundenToolStripMenuItem.Click += new System.EventHandler(this.kundenToolStripMenuItem_Click);
            // 
            // kundenToolStripMenuItem1
            // 
            this.kundenToolStripMenuItem1.Name = "kundenToolStripMenuItem1";
            this.kundenToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.kundenToolStripMenuItem1.Text = "Kunden";
            // 
            // buttonLadungFahrtenTable
            // 
            this.buttonLadungFahrtenTable.Location = new System.Drawing.Point(11, 59);
            this.buttonLadungFahrtenTable.Name = "buttonLadungFahrtenTable";
            this.buttonLadungFahrtenTable.Size = new System.Drawing.Size(212, 23);
            this.buttonLadungFahrtenTable.TabIndex = 9;
            this.buttonLadungFahrtenTable.Text = "Laden Fahrten Table";
            this.buttonLadungFahrtenTable.UseVisualStyleBackColor = true;
            this.buttonLadungFahrtenTable.Click += new System.EventHandler(this.buttonLadungFahrtenTable_Click);
            // 
            // Fahrten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1429, 561);
            this.Controls.Add(this.buttonLadungFahrtenTable);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Nr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kunde;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fahrer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fahrzeug;
        private System.Windows.Forms.DataGridViewTextBoxColumn Abholung;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zustellung;
        private System.Windows.Forms.DataGridViewTextBoxColumn km;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Betrag;
        private System.Windows.Forms.DataGridViewTextBoxColumn Extras;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fahrer_km;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fahrer_Betrag;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bemerkung_Typ;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bemerkung_Betrag;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fahrerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kundenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kundenToolStripMenuItem1;
        private System.Windows.Forms.Button buttonLadungFahrtenTable;
    }
}

