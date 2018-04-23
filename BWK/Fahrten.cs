using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace BWK
{
    public partial class Fahrten : Form
    {
        List<Fahrt> fahrten = new List<Fahrt>();
        List<Fahrer> fahrerList = new List<Fahrer>();
        List<Kunde> kundenList = new List<Kunde>();
        List<String> sheetName = new List<String>();
        Excel.Application ObjWorkExcel;
        Excel.Workbook ObjWorkBook;

        public Fahrten()
        {
            InitializeComponent();
            String path = Environment.CurrentDirectory + "\\Table\\Fahrten_2018_2.xlsx";
            ObjWorkExcel = new Excel.Application(); //открыть эксель
            ObjWorkBook = ObjWorkExcel.Workbooks.Open(path, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing); //открыть файл
            foreach (Excel.Worksheet worksheet in ObjWorkBook.Worksheets)
            {
                sheetName.Add(worksheet.Name);
            }
            FuellungMouts();
            
        }

        public void FuellungMouts()
        {
            int mount = DateTime.Now.Month - 2;

            foreach (String m in sheetName)
            {
                comboBoxMounts.Items.Add(m);
            }
            comboBoxMounts.Items.Remove("Vorlage");
            comboBoxMounts.SelectedIndex = mount;
        }

        public void Fuellung()
        {
            comboBoxFahrer.Items.Clear();
            
            foreach (Fahrer f in fahrerList)
            {
                comboBoxFahrer.Items.Add(f);
            }

            comboBoxFahrer.SelectedIndex = 0;
            comboBoxFahrer.DisplayMember = "NameFahrer";

            comboBoxKunde.Items.Clear();

            foreach (Kunde k in kundenList)
            {
                comboBoxKunde.Items.Add(k);
            }
            
            comboBoxKunde.SelectedIndex = 0;
            comboBoxKunde.DisplayMember = "NameKunde";
        }

        
        private Fahrer returnFahrer(string nameFahrer)
        {

            foreach(Fahrer f in fahrerList)
            {
                if (f.NameFahrer.Equals(nameFahrer))
                    return f;
            }
            return null;
        }

        private Kunde returnKunde(string nameKunde)
        {

            foreach (Kunde k in kundenList)
            {
                if (k.NameKunde.Equals(nameKunde))
                    return k;
            }
            return null;
        }

        public void ParseTable(string mount, Excel.Workbook ObjWorkBook)
        {

            //Debug.WriteLine(ObjWorkSheet.Name);
            Excel.Worksheet ObjWorkSheet = (Excel.Worksheet)ObjWorkBook.Sheets[mount];
            var lastCell = ObjWorkSheet.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell);
            
            progressBar1.Value = 0;
            
            int ii = 7;
            while (true)
            {
                string kunde = ObjWorkSheet.Cells[ii, 2].Text.ToString();
                if (kunde.Equals("")) break;
                else ii++;
            }

            int countFahrt = ii - 7;
            progressBar1.Maximum = countFahrt;
            Debug.WriteLine(countFahrt);

            Regex rgx = new Regex("[^0-9,]");
            ArrayList arrFahrt = new ArrayList();

            for (int i = 7, k=1; i<(int)lastCell.Row; i++, k++)
            {
                arrFahrt.Add(k);

                //Kunde
                string nameKunde = ObjWorkSheet.Cells[i, 2].Text.ToString();
                if (nameKunde.Equals("")) { break; }

                Kunde einKunde = returnKunde(nameKunde);
                if (einKunde == null)
                {
                    einKunde = new Kunde(nameKunde);
                    kundenList.Add(einKunde);
                }
                arrFahrt.Add(einKunde.NameKunde);

                //Fahrer
                string nameFahrer = ObjWorkSheet.Cells[i, 3].Text.ToString();
                Fahrer einFahrer = returnFahrer(nameFahrer);
                if (einFahrer == null)
                {
                    einFahrer = new Fahrer(nameFahrer);
                    fahrerList.Add(einFahrer);
                }
                arrFahrt.Add(einFahrer.NameFahrer);

                DateTime date = DateTime.Parse(ObjWorkSheet.Cells[i, 4].Text.ToString());
                arrFahrt.Add(date.ToString("d"));

                string referenz = "123";//ObjWorkSheet.Cells[i, 5].Text.ToString();

                string fahrzeug = "MZ-" + ObjWorkSheet.Cells[i, 6].Text.ToString() + " <" + ObjWorkSheet.Cells[i, 7].Text.ToString() +">";
                arrFahrt.Add(fahrzeug);

                string abholung = ObjWorkSheet.Cells[i, 9].Text.ToString();
                arrFahrt.Add(abholung);

                string zustellung = ObjWorkSheet.Cells[i, 11].Text.ToString();
                arrFahrt.Add(zustellung);

                int kmFahrt = Convert.ToInt32(ObjWorkSheet.Cells[i, 12].Text.ToString());
                arrFahrt.Add(kmFahrt);

                float preisKmFahrt = 0;
                string preisKmFahrtStr = rgx.Replace(ObjWorkSheet.Cells[i, 13].Text.ToString(), "");
                if (!preisKmFahrtStr.Equals(""))
                {
                    preisKmFahrt = float.Parse(preisKmFahrtStr);
                    arrFahrt.Add(preisKmFahrt);
                }
                else arrFahrt.Add("-");


                float betragFahrt = float.Parse(rgx.Replace(ObjWorkSheet.Cells[i, 14].Text.ToString(), ""));
                arrFahrt.Add(betragFahrt);

                string maut = rgx.Replace(ObjWorkSheet.Cells[i, 15].Text.ToString(), "");
                float mautFahrt = 0;
                if (!maut.Equals(""))
                {
                    mautFahrt = float.Parse(maut);
                }
                arrFahrt.Add(mautFahrt);


                int kmFahrer = 0;
                float betragFahrer = 0;
                for (int jj = 16; jj<= 27; jj += 2)
                {
                    string kmF = ObjWorkSheet.Cells[i, jj].Text.ToString();
                    if (!kmF.Equals(""))
                    {
                        kmFahrer = Convert.ToInt32(kmF);
                        betragFahrer = float.Parse(rgx.Replace(ObjWorkSheet.Cells[i, jj + 1].Text.ToString(), ""));            
                        break;

                    }
                }
                arrFahrt.Add(kmFahrer);
                arrFahrt.Add(betragFahrer);

                string bemerkungText = ObjWorkSheet.Cells[i, 28].Text.ToString();
                arrFahrt.Add(bemerkungText);

                string bemerkungPreis = rgx.Replace(ObjWorkSheet.Cells[i, 29].Text.ToString(), "");
                float bemerkungPreisF = 0;
                if (!bemerkungPreis.Equals(""))
                {
                    bemerkungPreisF = float.Parse(bemerkungPreis);
                }
                arrFahrt.Add(bemerkungPreisF);

                Fahrt fahrt = new Fahrt(einKunde, einFahrer, date, referenz, fahrzeug, abholung, zustellung, kmFahrt, preisKmFahrt, betragFahrt, mautFahrt, kmFahrer, betragFahrer, bemerkungText, bemerkungPreisF, mount);
                fahrten.Add(fahrt);
                einFahrer.AddFahrt(fahrt);

                DataGridViewTable(arrFahrt);
                arrFahrt.Clear();

                progressBar1.Value += 1;

            }
            Fuellung();
            Application.DoEvents();

        }

        private void DataGridViewTable(ArrayList arrayList)
        {
            DataGridViewRow row = (DataGridViewRow)dataGridViewTable.Rows[0].Clone();
            int y = 0;
            foreach (Object o in arrayList)
            {
                row.Cells[y].Value = o;
                y++;
            }
            dataGridViewTable.Rows.Add(row);
        }

        private void buttonMountAuswähl_Click(object sender, EventArgs e)
        {
            string mount = comboBoxMounts.SelectedItem.ToString();
            Debug.WriteLine(mount);
            fahrerList.Clear();
            kundenList.Clear();
            dataGridViewTable.Rows.Clear();
            ParseTable(mount, ObjWorkBook);
        }

        private void Fahrten_FormClosed(object sender, FormClosedEventArgs e)
        {
            ObjWorkBook.Close(0);
            ObjWorkExcel.Quit();
        }

        private void buttonFahrerInfo_Click(object sender, EventArgs e)
        {
            Fahrer fahrer = (Fahrer)comboBoxFahrer.SelectedItem;
            Debug.WriteLine(fahrer.NameFahrer);

            dataGridViewTable.Rows.Clear();
            ArrayList arrFahrerFahrt = new ArrayList();
            List<Fahrt> fahrtList = fahrer.Fahrten;
            int i = 1;
            foreach(Fahrt f in fahrtList)
            {
                arrFahrerFahrt.Clear();
                arrFahrerFahrt.Add(i);
                arrFahrerFahrt.Add(f.Kunde.NameKunde);
                arrFahrerFahrt.Add(f.Fahrer.NameFahrer);
                arrFahrerFahrt.Add(f.Date);
                arrFahrerFahrt.Add(f.Fahrzeug);
                arrFahrerFahrt.Add(f.Abholung);
                arrFahrerFahrt.Add(f.Zustellung);
                arrFahrerFahrt.Add(f.KmFahrt);
                arrFahrerFahrt.Add(f.PreisKmFahrt);
                arrFahrerFahrt.Add(f.BetragFahrt);
                arrFahrerFahrt.Add(f.MautFahrt);
                arrFahrerFahrt.Add(f.KmFahrer);
                arrFahrerFahrt.Add(f.BetragFahrer);
                arrFahrerFahrt.Add(f.BemerkungText);
                arrFahrerFahrt.Add(f.BemerkungPreis);
                DataGridViewTable(arrFahrerFahrt);
                i++;
                //Debug.WriteLine(f.Kunde.NameKunde);
            }
        }

        private void dataGridViewTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
