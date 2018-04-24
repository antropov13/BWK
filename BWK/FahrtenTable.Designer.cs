namespace BWK
{
    partial class FahrtenTable
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFahrtenTable = new System.Windows.Forms.TextBox();
            this.buttonAddFahrtenTable = new System.Windows.Forms.Button();
            this.buttonSpeichern = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fahrten Table:";
            // 
            // textBoxFahrtenTable
            // 
            this.textBoxFahrtenTable.Enabled = false;
            this.textBoxFahrtenTable.ForeColor = System.Drawing.Color.OliveDrab;
            this.textBoxFahrtenTable.Location = new System.Drawing.Point(145, 8);
            this.textBoxFahrtenTable.Name = "textBoxFahrtenTable";
            this.textBoxFahrtenTable.ReadOnly = true;
            this.textBoxFahrtenTable.Size = new System.Drawing.Size(127, 20);
            this.textBoxFahrtenTable.TabIndex = 1;
            // 
            // buttonAddFahrtenTable
            // 
            this.buttonAddFahrtenTable.Location = new System.Drawing.Point(12, 48);
            this.buttonAddFahrtenTable.Name = "buttonAddFahrtenTable";
            this.buttonAddFahrtenTable.Size = new System.Drawing.Size(122, 23);
            this.buttonAddFahrtenTable.TabIndex = 2;
            this.buttonAddFahrtenTable.Text = "Hinzufügen Table";
            this.buttonAddFahrtenTable.UseVisualStyleBackColor = true;
            this.buttonAddFahrtenTable.Click += new System.EventHandler(this.buttonAddFahrtenTable_Click);
            // 
            // buttonSpeichern
            // 
            this.buttonSpeichern.Location = new System.Drawing.Point(145, 48);
            this.buttonSpeichern.Name = "buttonSpeichern";
            this.buttonSpeichern.Size = new System.Drawing.Size(127, 23);
            this.buttonSpeichern.TabIndex = 3;
            this.buttonSpeichern.Text = "Speichern";
            this.buttonSpeichern.UseVisualStyleBackColor = true;
            this.buttonSpeichern.Click += new System.EventHandler(this.buttonSpeichern_Click);
            // 
            // FahrtenTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 126);
            this.Controls.Add(this.buttonSpeichern);
            this.Controls.Add(this.buttonAddFahrtenTable);
            this.Controls.Add(this.textBoxFahrtenTable);
            this.Controls.Add(this.label1);
            this.Name = "FahrtenTable";
            this.Text = "Fahrten Table";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxFahrtenTable;
        private System.Windows.Forms.Button buttonAddFahrtenTable;
        private System.Windows.Forms.Button buttonSpeichern;
    }
}