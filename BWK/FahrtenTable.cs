using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BWK
{
    public partial class FahrtenTable : Form
    {
        string pathTable;
        Fahrten fahrten;

        public FahrtenTable(Fahrten fahrten, string pathFahrtenTable)
        {
            InitializeComponent();
            this.fahrten = fahrten;
            this.pathTable = pathFahrtenTable;
            fuellung();
        }

        public void fuellung()
        {
            if (!pathTable.Equals("")) textBoxFahrtenTable.Text = Path.GetFileName(pathTable);
            else textBoxFahrtenTable.Text = "null";
        }

        private void buttonAddFahrtenTable_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            openFileDialog1.Filter = "xlsx files (*.xlsx)|*.xlsx";
            openFileDialog1.FilterIndex = 0;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            pathTable = openFileDialog1.FileName;
                            fuellung();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void buttonSpeichern_Click(object sender, EventArgs e)
        {
            fahrten.NeuFahrtenTable(pathTable);
            this.Close();
        }
    }
}
