using System;
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
        List<Kunde> kunden = new List<Kunde>();
        List<String> sheetName = new List<String>();
        Excel.Application ObjWorkExcel;
        Excel.Workbook ObjWorkBook;

        public Fahrten()
        {
            InitializeComponent();
            String path = Environment.CurrentDirectory + "\\Table\\Fahrten_2018_2.xlsx";
            //String path = "C:\\OneDrive\\BWK\\BWK\\BWK\\bin\\Debug\\Table\\Fahrten_2018_2.xlsx";
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
            
            foreach (Fahrer f in fahrerList)
            {
                comboBoxFahrer.Items.Add(f);
            }
            
            comboBoxFahrer.SelectedIndex = 0;
            comboBoxFahrer.DisplayMember = "NameFahrer";
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

        public void ParseTable(string mount, Excel.Workbook ObjWorkBook)
        {

            //Debug.WriteLine(ObjWorkSheet.Name);
            Excel.Worksheet ObjWorkSheet = (Excel.Worksheet)ObjWorkBook.Sheets[mount]; //получить 1 лист
            var lastCell = ObjWorkSheet.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell);//1 ячейку
            //int i = 7
            //float p = 100 / (int)lastCell.Row;
            
            progressBar1.Value = 0;
            Regex rgx = new Regex("[^0-9,]");
            int ii = 7;
            while (true)
            {
                string kunde = ObjWorkSheet.Cells[ii, 2].Text.ToString();
                if (kunde.Equals("")) break;
                else ii++;
            }

            int countFahrt = ii - 7;
            Debug.WriteLine(countFahrt);

            for (int i = 7, k=1; i<(int)lastCell.Row; i++, k++)
            {
                string nameKunde = ObjWorkSheet.Cells[i, 2].Text.ToString();
                if (nameKunde.Equals("")) { break; }
                Kunde kunde = new Kunde(nameKunde);
                //Fahrer
                string nameFahrer = ObjWorkSheet.Cells[i, 3].Text.ToString();

                Fahrer einFahrer = returnFahrer(nameFahrer);
                if (einFahrer == null)
                {
                    einFahrer = new Fahrer(nameFahrer);
                    fahrerList.Add(einFahrer);
                }
                
                //Fahrer fahrer = new Fahrer(nameFahrer);
                DateTime date = DateTime.Parse(ObjWorkSheet.Cells[i, 4].Text.ToString());
                string referenz = ObjWorkSheet.Cells[i, 5].Text.ToString();
                Dictionary<string, string> fahrzeug = new Dictionary<string, string>();
                fahrzeug.Add("MZ-" + ObjWorkSheet.Cells[i, 6].Text.ToString(), ObjWorkSheet.Cells[i, 7].Text.ToString());
                Dictionary<string, string> abholung = new Dictionary<string, string>();
                abholung.Add(ObjWorkSheet.Cells[i, 8].Text.ToString(), ObjWorkSheet.Cells[i, 9].Text.ToString());
                Dictionary<string, string> zustellung = new Dictionary<string, string>();
                zustellung.Add(ObjWorkSheet.Cells[i, 10].Text.ToString(), ObjWorkSheet.Cells[i, 11].Text.ToString());
                int kmFahrt = Convert.ToInt32(ObjWorkSheet.Cells[i, 12].Text.ToString());
                float preisKmFahrt = 0;
                string preisKmFahrtStr = rgx.Replace(ObjWorkSheet.Cells[i, 13].Text.ToString(), "");
                if (!preisKmFahrtStr.Equals(""))
                {
                    preisKmFahrt = float.Parse(preisKmFahrtStr);
                }


                float betragFahrt = float.Parse(rgx.Replace(ObjWorkSheet.Cells[i, 14].Text.ToString(), ""));
                string maut = rgx.Replace(ObjWorkSheet.Cells[i, 15].Text.ToString(), "");
                float mautFahrt = 0;
                if (!maut.Equals(""))
                {
                    mautFahrt = float.Parse(maut);
                }
                int kmFahrer = 0;
                float betragFahrer = 0;
                for (int jj = 16; jj<= 27; jj += 2)
                {
                    string kmF = ObjWorkSheet.Cells[i, jj].Text.ToString();
                    if (!kmF.Equals(""))
                    {
                        kmFahrer = Convert.ToInt32(kmF);
                        betragFahrer = float.Parse(rgx.Replace(ObjWorkSheet.Cells[i, jj + 1].Text.ToString(), ""));
                    }

                }
                Dictionary<string, float> bemerkung = new Dictionary<string, float>();
                string bemerkungType = ObjWorkSheet.Cells[i, 28].Text.ToString();
                string bemerkungPreis = rgx.Replace(ObjWorkSheet.Cells[i, 29].Text.ToString(), "");
                
                if (!bemerkungPreis.Equals("")) {
                    bemerkung.Add(bemerkungType, float.Parse(bemerkungPreis));
                }
                else{
                    bemerkung.Add(bemerkungType, 0);
                }
                //Debug.WriteLine(kunde.NameKunde);
                Fahrt fahrt = new Fahrt(kunde, einFahrer, date, referenz, fahrzeug, abholung, zustellung, kmFahrt, preisKmFahrt, betragFahrt, mautFahrt, kmFahrer, betragFahrer, bemerkung);
                fahrten.Add(fahrt);
                progressBar1.Value += 1;
            }

            Application.DoEvents();
            Debug.WriteLine(fahrten.Count);
            for (int i = 0; i<fahrten.Count; i++)
            {
                Debug.WriteLine(fahrten[i].Kunde.NameKunde);
            }



        }

        private void buttonMountAuswähl_Click(object sender, EventArgs e)
        {
            string mount = comboBoxMounts.SelectedItem.ToString();
            Debug.WriteLine(mount);
            ParseTable(mount, ObjWorkBook);
        }

        private void Fahrten_FormClosed(object sender, FormClosedEventArgs e)
        {
            ObjWorkBook.Close(0);
            ObjWorkExcel.Quit();
        }
    }
}
