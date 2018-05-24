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
        String path = Environment.CurrentDirectory + "\\";
        String einstellung = Environment.CurrentDirectory + "\\Einstellung.xlsx";
        String fahrtenTabellePath = "";
        Excel.Application ObjWorkExcel;
        Excel.Workbook ObjWorkBook;

        public Fahrten()
        {
            InitializeComponent();
            ErstellungPathFahrenTabelle();
            //PruefungTable();
            //path += "Table\\Fahrten_2018_2.xlsx";
            //PruefungTable();


            //ObjWorkExcel = new Excel.Application(); //открыть эксель
            //ObjWorkBook = ObjWorkExcel.Workbooks.Open(path, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing); //открыть файл
            //foreach (Excel.Worksheet worksheet in ObjWorkBook.Worksheets)
            //{
            //    sheetName.Add(worksheet.Name);
            //}
            //FuellungMouts();
            
        }

        public void NeuFahrtenTable(string _path)
        {
            //this.path = _path;
            //Debug.WriteLine(this.path);
            ObjWorkExcel = new Excel.Application(); //открыть эксель
            ObjWorkBook = ObjWorkExcel.Workbooks.Open(_path, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing); //открыть файл
            foreach (Excel.Worksheet worksheet in ObjWorkBook.Worksheets)
            {
                sheetName.Add(worksheet.Name);
            }
            ObjWorkBook.Close(0);
            ObjWorkExcel.Quit();
            FuellungMouts();
            //ErstellungPathFahrenTabelle();
        }

        public void ErstellungPathFahrenTabelle()
        {
            //String einstellung = this.path + "Einstellung.xlsx";
            //Debug.WriteLine(einstellung);
            ObjWorkExcel = new Excel.Application(); //открыть эксель
            ObjWorkBook = ObjWorkExcel.Workbooks.Open(this.einstellung, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing); //открыть файл
            Excel.Worksheet worksheet = ObjWorkBook.Worksheets["Fahrten"];
            this.fahrtenTabellePath = this.path + worksheet.Cells[2, 2].Text.ToString();
            ObjWorkBook.Close(0);
            ObjWorkExcel.Quit();
            Debug.WriteLine(fahrtenTabellePath);
            NeuFahrtenTable(this.fahrtenTabellePath);

            //if (path.Equals(""))
            //{
            //buttonMountAuswähl.Enabled = false;
            buttonFahrerInfo.Enabled = false;
            buttonKundeInfo.Enabled = false;
            //buttonLadungFahrtenTable.Enabled = false;
            // }
            // else
            // {
            //    buttonMountAuswähl.Enabled = true;
            //buttonFahrerInfo.Enabled = true;
            //buttonKundeInfo.Enabled = true;
            //buttonLadungFahrtenTable.Enabled = true;
            //    }
        }

        public void PruefungTable()
        {
            if (path.IndexOf(".xlsx") < 0)
            {
                Debug.WriteLine(path);
                FahrtenTable fahrtenTable = new FahrtenTable(this, path);
                fahrtenTable.Show();

            }
            //else Debug.WriteLine("123");
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

            if (fahrerList.Count>0) buttonFahrerInfo.Enabled = true;
            else buttonFahrerInfo.Enabled = false;

            foreach (Fahrer f in fahrerList)
            {
                comboBoxFahrer.Items.Add(f);
            }

            comboBoxFahrer.SelectedIndex = 0;
            comboBoxFahrer.DisplayMember = "NameFahrer";

            comboBoxKunde.Items.Clear();

            if (kundenList.Count>0) buttonKundeInfo.Enabled = true;
            else buttonKundeInfo.Enabled = false;

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

        public void ParseTable(string mount)
        {

            //Debug.WriteLine(ObjWorkSheet.Name);
            ObjWorkExcel = new Excel.Application(); //открыть эксель
            ObjWorkBook = ObjWorkExcel.Workbooks.Open(this.fahrtenTabellePath, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing); //открыть файл

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

            int i = 7;
            int k = 1;

            for (; i<(int)lastCell.Row; i++, k++)
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

                string fahrzeug_mz = ObjWorkSheet.Cells[i, 6].Text.ToString();
                arrFahrt.Add(fahrzeug_mz);

                string fahrzeug_typ = ObjWorkSheet.Cells[i, 7].Text.ToString();
                arrFahrt.Add(fahrzeug_typ);

                string abholungPLZ = ObjWorkSheet.Cells[i, 8].Text.ToString();
                arrFahrt.Add(abholungPLZ);

                string abholung = ObjWorkSheet.Cells[i, 9].Text.ToString();
                arrFahrt.Add(abholung);

                string zustellungPLZ = ObjWorkSheet.Cells[i, 10].Text.ToString();
                arrFahrt.Add(zustellungPLZ);

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

                Fahrt fahrt = new Fahrt(einKunde, einFahrer, date, referenz, fahrzeug_mz, fahrzeug_typ, abholungPLZ, abholung, zustellungPLZ, zustellung, kmFahrt, preisKmFahrt, betragFahrt, mautFahrt, kmFahrer, betragFahrer, bemerkungText, bemerkungPreisF, mount);
                fahrten.Add(fahrt);
                einFahrer.AddFahrt(fahrt);

                DataGridViewTable(arrFahrt);
                arrFahrt.Clear();

                progressBar1.Value += 1;

            }

            //Bemerkung für Fahrer
            string beginn = "";
            string end = "";
            Debug.WriteLine("i = " + i);
            while (!beginn.Equals("Km-Preis"))
            {
                i++;
                beginn = ObjWorkSheet.Cells[i, 28].Text.ToString();
            }
            int iii = i;
            Debug.WriteLine("iii = " + iii);
            while (!beginn.Equals("END"))
            {
                iii++;
                beginn = ObjWorkSheet.Cells[iii, 28].Text.ToString();
            }
            /*
            int g = 1;
            while(g<40)
            {

                String f = ObjWorkSheet.Cells[93, g].Text.ToString();
                Debug.WriteLine("f = " + f);
                g++;
            }
            Debug.WriteLine("iii = " + iii);
            */
            Regex rgx_preis = new Regex("[^0-9,-]");
            while (!end.Equals("END"))
            {
                i++;
                k = 17;
                string bemerkungText = ObjWorkSheet.Cells[i, 28].Text.ToString();
                //string bemerkungPreis = rgx.Replace(ObjWorkSheet.Cells[i, 29].Text.ToString(), "");
                end = bemerkungText;
                if (end.Equals("END")) break;
                if (!end.Equals("")) {
                    //Debug.WriteLine(i + " - " + bemerkungText);
                    while(k<28)
                    {
                        string preis_str = rgx_preis.Replace(ObjWorkSheet.Cells[i, k].Text.ToString(), "");
                        if (!preis_str.Equals(""))
                        {
                            float preis = float.Parse(preis_str);
                            string fahrer = ObjWorkSheet.Cells[5, k-1].Text.ToString();
                            Debug.WriteLine(i + "," + k + " - " + bemerkungText + " = " + preis + " : " + fahrer);
                            Bemerkung bemerkung = new Bemerkung(bemerkungText, preis);
                            foreach (Fahrer f in fahrerList)
                            {
                                if (f.NameFahrer.Equals(fahrer))
                                {
                                    f.AddBemerkung(bemerkung);
                                    break;
                                }
                            }
                            break;
                        }
                        k += 2;
                    }
                }
                

            }

            Fuellung();
            ObjWorkBook.Close(0);
            ObjWorkExcel.Quit();
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

        private void DataGridViewTableFazit(ArrayList arrayList)
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
            ParseTable(mount);
        }

        private void Fahrten_FormClosed(object sender, FormClosedEventArgs e)
        {
            //ObjWorkBook.Close(0);
            //ObjWorkExcel.Quit();
        }

        private void buttonFahrerInfo_Click(object sender, EventArgs e)
        {
            Fahrer fahrer = (Fahrer)comboBoxFahrer.SelectedItem;
            Debug.WriteLine(fahrer.NameFahrer);

            dataGridViewTable.Rows.Clear();
            ArrayList arrFahrerFahrt = new ArrayList();
            ArrayList arrFahrerFahrtFazit = new ArrayList();
            List<Fahrt> fahrtList = fahrer.Fahrten;
            int i = 1;
            int kmFazit = 0;
            float betragFahrtFazit = 0;
            float exstrasFahrtFazit = 0;
            int kmFahrerFazit = 0;
            float betragFahrerFazit = 0;
            float bemergungFazit = 0;

            foreach(Fahrt f in fahrtList)
            {
                arrFahrerFahrt.Clear();
                arrFahrerFahrt.Add(i);
                arrFahrerFahrt.Add(f.Kunde.NameKunde);
                arrFahrerFahrt.Add(f.Fahrer.NameFahrer);
                arrFahrerFahrt.Add(f.Date.ToString("d"));
                arrFahrerFahrt.Add(f.Fahrzeug_mz);
                arrFahrerFahrt.Add(f.Fahrzeug_typ);
                arrFahrerFahrt.Add(f.AbholungPLZ);
                arrFahrerFahrt.Add(f.Abholung);
                arrFahrerFahrt.Add(f.ZustellungPLZ);
                arrFahrerFahrt.Add(f.Zustellung);
                arrFahrerFahrt.Add(f.KmFahrt);
                kmFazit += f.KmFahrt;
                arrFahrerFahrt.Add(f.PreisKmFahrt);
                arrFahrerFahrt.Add(f.BetragFahrt);
                betragFahrtFazit += f.BetragFahrt;
                arrFahrerFahrt.Add(f.MautFahrt);
                exstrasFahrtFazit += f.MautFahrt;
                arrFahrerFahrt.Add(f.KmFahrer);
                kmFahrerFazit += f.KmFahrer;
                arrFahrerFahrt.Add(f.BetragFahrer);
                betragFahrerFazit += f.BetragFahrer;
                arrFahrerFahrt.Add(f.BemerkungText);
                arrFahrerFahrt.Add(f.BemerkungPreis);
                bemergungFazit += f.BemerkungPreis;
                DataGridViewTable(arrFahrerFahrt);
                i++;
                //Debug.WriteLine(f.Kunde.NameKunde);
            }
            DataGridViewRow row = (DataGridViewRow)dataGridViewTable.Rows[0].Clone();
            dataGridViewTable.Rows.Add(row);
            
            row = (DataGridViewRow)dataGridViewTable.Rows[0].Clone();
            row.Cells[9].Value = "Gesamt";
            row.Cells[10].Value = kmFazit;
            row.Cells[12].Value = betragFahrtFazit;
            row.Cells[13].Value = exstrasFahrtFazit;
            row.Cells[14].Value = kmFahrerFazit;
            //row.Cells[15].Value = betragFahrerFazit;
            //row.Cells[16].Value = "Km-Preis";
            //row.Cells[17].Value = bemergungFazit;

            dataGridViewTable.Rows.Add(row);
            //arrFahrerFahrtFazit.Add(kmFazit);
            //arrFahrerFahrtFazit.Add(kmFazit);
            //arrFahrerFahrtFazit.Add(kmFazit);
            //arrFahrerFahrtFazit.Add(betragFahrtFazit);
            Bemerkung bemerkungExtras = new Bemerkung("Extras", bemergungFazit);
            fahrer.BemerkungList.Insert(0, bemerkungExtras);

            Bemerkung bemerkungBetrag = new Bemerkung("Km-Preis", betragFahrerFazit);
            fahrer.BemerkungList.Insert(0, bemerkungBetrag);

            //row = (DataGridViewRow)dataGridViewTable.Rows[0].Clone();
            //dataGridViewTable.Rows.Add(row);

            foreach (Bemerkung b in fahrer.BemerkungList)
            {
                row = (DataGridViewRow)dataGridViewTable.Rows[0].Clone();
                row.Cells[15].Value = b.Preis;
                row.Cells[16].Value = b.Typ;
                dataGridViewTable.Rows.Add(row);
            }

        }

        private void dataGridViewTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void kundenToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fahrerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FahrtenTable fahrtenTable = new FahrtenTable(this, path);
            fahrtenTable.Show();
        }

        private void buttonLadungFahrtenTable_Click(object sender, EventArgs e)
        {/*
            ObjWorkExcel = new Excel.Application(); //открыть эксель
            ObjWorkBook = ObjWorkExcel.Workbooks.Open(path, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing); //открыть файл
            foreach (Excel.Worksheet worksheet in ObjWorkBook.Worksheets)
            {
                sheetName.Add(worksheet.Name);
            }
            FuellungMouts();
            */
        }

        private void buttonExportFahrten_Click(object sender, EventArgs e)
        {
            Fahrer fahrer = (Fahrer)comboBoxFahrer.SelectedItem;
            String mount = (String)comboBoxMounts.SelectedItem;
            //String einstellung = this.path + "Einstellung.xlsx";
            Debug.WriteLine(einstellung);
            ObjWorkExcel = new Excel.Application(); //открыть эксель
            ObjWorkBook = ObjWorkExcel.Workbooks.Open(this.einstellung, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing); //открыть файл
            Excel.Worksheet worksheet = ObjWorkBook.Worksheets["Fahrten"];
            String fahrerTabelleExport = "";
            String fahrerName = "1";
            int i = 3;
            while (!fahrerName.Equals(""))
            {
                fahrerName = worksheet.Cells[i, 1].Text.ToString();
                if (fahrer.NameFahrer.Equals(fahrerName))
                {
                    fahrerTabelleExport = this.path + worksheet.Cells[i, 2].Text.ToString();
                    Debug.WriteLine(fahrerTabelleExport);
                    ObjWorkBook.Close(0);
                    ObjWorkExcel.Quit();
                    break;
                }
                i++;
            }
            if (fahrerTabelleExport.Equals(""))
            {
                Debug.WriteLine("Es gibt keine Tabelle für " + fahrer.NameFahrer);
                ObjWorkBook.Close(0);
                ObjWorkExcel.Quit();
            }
            else
            {
                ExportFahrerTabelle(fahrerTabelleExport, fahrer, mount);
            }
            
            //this.fahrtenTabellePath = this.path + worksheet.Cells[2, 2].Text.ToString();
            //Debug.WriteLine(fahrtenTabellePath);
        }

        private void ExportFahrerTabelle(String _path, Fahrer fahrer, String mount)
        {
            Fahrten.ActiveForm.Enabled = false;
            labelExport.Visible = true;
            labelAnimation.Visible = true;
            progressBar1.Value = 0;
            progressBar1.Maximum = fahrer.Fahrten.Count;
            ObjWorkExcel = new Excel.Application(); //открыть эксель
            ObjWorkBook = ObjWorkExcel.Workbooks.Open(_path, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing); //открыть файл
            Excel.Worksheet worksheet;
            try
            {
                worksheet = ObjWorkBook.Worksheets[mount];
            }
            catch
            {
                Debug.WriteLine("Es gibt keine");
                Excel.Worksheet worksheetVorlage = ObjWorkBook.Worksheets["Vorlage"];
                worksheetVorlage.Copy(worksheetVorlage);
                Excel.Worksheet worksheetNew = ObjWorkBook.Worksheets["Vorlage (2)"];
                //worksheet = ObjWorkBook.Worksheets[mount];
                worksheetNew.Name = mount;
                worksheet = worksheetNew;
                worksheet.Cells[2, "C"] = mount;
            }

            //Excel.Worksheet worksheet1 = ((Excel.Worksheet)Application.ActiveWorkbook.Worksheets[1]);
            //Excel.Worksheet worksheet3 = ((Excel.Worksheet)Application.ActiveWorkbook.Worksheets[3]);
            //worksheet1.Copy(worksheet3);

            int i = 6;
            int k = 1;
            foreach (Fahrt fahrt in fahrer.Fahrten)
            {
                labelAnimation.Text = "";
                worksheet.Cells[i, "A"] = k;
                worksheet.Cells[i, "B"] = fahrt.Date;
                worksheet.Cells[i, "C"] = fahrt.Fahrzeug_mz;
                labelAnimation.Text = ".";
                worksheet.Cells[i, "D"] = fahrt.Fahrzeug_typ;
                worksheet.Cells[i, "E"] = fahrt.AbholungPLZ;
                worksheet.Cells[i, "F"] = fahrt.Abholung;
                labelAnimation.Text = "..";
                worksheet.Cells[i, "G"] = fahrt.ZustellungPLZ;
                worksheet.Cells[i, "H"] = fahrt.Zustellung;
                worksheet.Cells[i, "I"] = fahrt.KmFahrer;
                labelAnimation.Text = "...";
                worksheet.Cells[i, "J"] = fahrt.BetragFahrer;
                worksheet.Cells[i, "K"] = fahrt.BemerkungText;
                worksheet.Cells[i, "L"] = fahrt.BemerkungPreis;
                i++;
                k++;
                progressBar1.Value++;
            }

            foreach (Bemerkung bemerkung in fahrer.BemerkungList)
            {
                worksheet.Cells[i, "J"] = bemerkung.Preis;
                worksheet.Cells[i, "K"] = bemerkung.Typ;
                i++;
            }

            ObjWorkBook.Save();
            ObjWorkBook.Close(0);
            ObjWorkExcel.Quit();
            labelAnimation.Visible = false;
            labelExport.Visible = false;
            Fahrten.ActiveForm.Enabled = true;
            
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
                // ввод в texBox только цифр и кнопки Backspace
                char ch = e.KeyChar;
                if (!Char.IsDigit(ch) && ch != 8 && ch !=44 && ch != 45)
                {
                    e.Handled = true;
                }
        }
    }
}
