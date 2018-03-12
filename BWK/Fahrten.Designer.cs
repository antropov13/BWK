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
            this.SuspendLayout();
            // 
            // comboBoxFahrer
            // 
            this.comboBoxFahrer.FormattingEnabled = true;
            this.comboBoxFahrer.Location = new System.Drawing.Point(120, 224);
            this.comboBoxFahrer.Name = "comboBoxFahrer";
            this.comboBoxFahrer.Size = new System.Drawing.Size(126, 24);
            this.comboBoxFahrer.TabIndex = 0;
            // 
            // comboBoxMounts
            // 
            this.comboBoxMounts.FormattingEnabled = true;
            this.comboBoxMounts.Location = new System.Drawing.Point(55, 52);
            this.comboBoxMounts.Name = "comboBoxMounts";
            this.comboBoxMounts.Size = new System.Drawing.Size(121, 24);
            this.comboBoxMounts.TabIndex = 1;
            // 
            // buttonMountAuswähl
            // 
            this.buttonMountAuswähl.Location = new System.Drawing.Point(211, 38);
            this.buttonMountAuswähl.Name = "buttonMountAuswähl";
            this.buttonMountAuswähl.Size = new System.Drawing.Size(109, 50);
            this.buttonMountAuswähl.TabIndex = 2;
            this.buttonMountAuswähl.Text = "Mount auszuwählen";
            this.buttonMountAuswähl.UseVisualStyleBackColor = true;
            this.buttonMountAuswähl.Click += new System.EventHandler(this.buttonMountAuswähl_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 286);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(355, 23);
            this.progressBar1.TabIndex = 3;
            // 
            // Fahrten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 321);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.buttonMountAuswähl);
            this.Controls.Add(this.comboBoxMounts);
            this.Controls.Add(this.comboBoxFahrer);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Fahrten";
            this.Text = "Fahrten";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Fahrten_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxFahrer;
        private System.Windows.Forms.ComboBox comboBoxMounts;
        private System.Windows.Forms.Button buttonMountAuswähl;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

