using ClosedXML.Excel;
using Compare_Service.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Compare_Service
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();


            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;

            backgroundWorker2.WorkerReportsProgress = true;
            backgroundWorker2.WorkerSupportsCancellation = true;
            Txt_Print.Text = Compare_Service.Properties.Settings.Default.Print_Address;
            VCB1 = 0;
            VCB2 = 0;
            Dt_ComBox.Columns.Add("NAME");
            Dt_ComBox.Columns.Add("CODE");
            Dt_ComBox2.Columns.Add("NAME");
            Dt_ComBox2.Columns.Add("CODE");

            Dt_Result.Columns.Add("Dt1");
            Dt_Result.Columns.Add("Dt2");

            Dt_Grid.Columns.Add("F1");
            Dt_Grid.Columns.Add("F2");
            Dt_Grid.Columns.Add("F3");
            Dt_Grid.Columns.Add("F4");
            Dt_Grid.Columns.Add("F5");
            Dt_Grid.Columns.Add("F6");
            Dt_Grid.Columns.Add("F7");
            Dt_Grid.Columns.Add("F8");
            Dt_Grid.Columns.Add("F9");
            Dt_Grid.Columns.Add("F10");
            Dt_Grid.Columns.Add("F11");
            Dt_Grid.Columns.Add("F12");
            Dt_Grid.Columns.Add("F13");
            Dt_Grid.Columns.Add("F14");
            Dt_Grid.Columns.Add("F15");
            Dt_Grid.Columns.Add("F16");
            Dt_Grid.Columns.Add("F17");
            Dt_Grid.Columns.Add("F18");
            Dt_Grid.Columns.Add("F19");
            Dt_Grid.Columns.Add("F20");
        }
        DataTable Dt_ComBox = new DataTable();
        DataTable Dt_ComBox2 = new DataTable();
        DataTable Dt_Result = new DataTable();
        DataTable Dt_Grid = new DataTable();
        DataTable Dt_1 = new DataTable();
        DataTable Dt_2 = new DataTable();
        DataTable Dt_1_Copy = new DataTable();
        DataTable Dt_2_Copy = new DataTable();
        Settings setting = new Settings();
        String FileName = "";
        public Int32 VCB1 { get; set; }
        public Int32 VCB2 { get; set; }
        public Int32 LBC { get; set; }

        private void Btn_FilesPath_shaskam_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Excel Files|*.xlsx";
                //"Excel Files|*.xls;*.xlsx";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txt_FolderPath_Src.Text = openFileDialog.FileName;
                    Dt_1 = ReadExcel(txt_FolderPath_Src.Text, Path.GetExtension(txt_FolderPath_Src.Text));
                    dataGridView1.DataSource = Dt_1;
                    dataGridView1.Refresh();
                    lb_1.Text = Dt_1.Rows.Count.ToString();
                    LBC = Convert.ToInt32(Dt_1.Rows.Count.ToString());
                    Dt_ComBox.Clear();
                    for (int i = 0; i < Dt_1.Columns.Count; i++)
                    {
                        Dt_ComBox.Rows.Add(new object[] { Dt_1.Rows[0][i].ToString(), i });
                    }
                    CB1.DataSource = Dt_ComBox;
                    CB1.DisplayMember = "NAME";
                    CB1.ValueMember = "CODE";
                    Dt_1.Columns.Add("MapCode", typeof(System.Int32));
                    Dt_1_Copy = Dt_1.Copy();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("The input file has a problem and cannot be loaded");
            }
        }

        private void Btn_FilesPath_Second_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Excel Files|*.xls;*.xlsx";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txt_FolderPath_Dest.Text = openFileDialog.FileName;
                    // DataTable Dt = new DataTable();
                    Dt_2 = ReadExcel(txt_FolderPath_Dest.Text, Path.GetExtension(txt_FolderPath_Dest.Text));

                    dataGridView1.DataSource = Dt_2;
                    dataGridView1.Refresh();
                    Dt_ComBox2.Clear();
                    lb_2.Text = Dt_2.Rows.Count.ToString();
                    for (int i = 0; i < Dt_2.Columns.Count; i++)
                    {
                        Dt_ComBox2.Rows.Add(new object[] { Dt_2.Rows[0][i].ToString(), i });
                    }
                    CB2.DataSource = Dt_ComBox2;
                    CB2.DisplayMember = "NAME";
                    CB2.ValueMember = "CODE";
                    Dt_2.Columns.Add("MapCode", typeof(System.Int32));
                    Dt_2_Copy = Dt_2.Copy();
                }
            }
            catch (Exception)
            {
            }
        }

        private void Btn_LoadFile_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy != true)
            {
                Dt_1.Clear();
                Dt_1 = Dt_1_Copy.Copy();
                Dt_2.Clear();
                Dt_2 = Dt_2_Copy.Copy();
                Dt_Grid.Clear();
                Dt_Result.Clear();
                Empty_Grid();
                backgroundWorker1.RunWorkerAsync();
            }
        }

        public static string Clean_String(string Value)
        {
            Value = Value.Trim();
            Value = Value.Replace(",", "");
            Value = Value.Replace("ي", "ی");
            Value = Value.Replace("ك", "ک");
            Value = Value.Replace("í", "í");
            Value = Value.Replace("ß", "˜");
            return Value;
        }
        public DataTable ReadExcel(string fileName, string fileExt)
        {
            try
            {
                DataSet ds = new DataSet();
                string conn;
                if (fileExt.CompareTo(".xls") == 0)
                    conn = @"provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + fileName + ";Extended Properties='Excel 8.0;HRD=Yes;IMEX=1';"; //for below excel 2007  
                else
                    conn = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + fileName + ";Extended Properties='Excel 12.0;HDR=NO';"; //for above excel 2007  
                var connExcel = new OleDbConnection(conn);
                var cmdExcel = new OleDbCommand();
                var oda = new OleDbDataAdapter();
                cmdExcel.Connection = connExcel;
                connExcel.Open();
                DataTable dtExcelSchema;
                dtExcelSchema = connExcel.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, default);
                string SheetName = dtExcelSchema.Rows[0]["TABLE_NAME"].ToString();
                connExcel.Close();
                connExcel.Open();
                cmdExcel.CommandText = "SELECT * From [" + SheetName + "] ";
                oda.SelectCommand = cmdExcel;
                oda.Fill(ds);
                connExcel.Close();
                return ds.Tables[0];
            }
            catch
            {
                MessageBox.Show("The input file has a problem and cannot be loaded");
                return null;
            }

        }

        private void Btn_cancel_Click(object sender, EventArgs e)
        {

            if (backgroundWorker1.WorkerSupportsCancellation == true)
            {
                backgroundWorker1.CancelAsync();
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            Int16 reportProg = 0;
            Dt_Result.Clear();
            LB_S.Text = "";


            for (int i = 0; i <= Convert.ToInt64(lb_1.Text) - 1; i++)
            {
                if (worker.CancellationPending == true)
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
                    for (int j = 0; j < Dt_2.Rows.Count - 1; j++)
                    {
                        if (Clean_String(Dt_1.Rows[i][VCB1].ToString()) == Clean_String(Dt_2.Rows[j][VCB2].ToString()) && string.IsNullOrEmpty(Dt_2.Rows[j]["MapCode"].ToString()) || (CB_H1.Checked && i == 0 && j == 0))
                        {
                            Dt_Result.Rows.Add(i, j);
                            Dt_1.Rows[i]["MapCode"] = j;
                            Dt_2.Rows[j]["MapCode"] = i;
                        }
                    }
                    reportProg = Convert.ToInt16((i * 100) / LBC);
                    worker.ReportProgress(reportProg);
                }
            }
        }
        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            resultLabel.Text = (e.ProgressPercentage.ToString() + "%");
            this.progressBar1.Value = e.ProgressPercentage;
        }
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled == true)
            {
                LB_S.Text = "Canceled!";

            }
            else if (e.Error != null)
            {
                LB_S.Text = "Error: " + e.Error.Message;
            }
            else
            {
                LB_S.Text = "";
                resultLabel.Text = "100 %";
                this.progressBar1.Value = 100;
                btn_print.Enabled = true;
            }
            Fill_Final_Grid();
        }
        private void Empty_Grid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
        }
        private void Fill_Final_Grid()
        {
            DataTable temp_Dt_1 = Dt_1.Copy();
            dataGridView1.DataSource = Proccess_ON_Data(temp_Dt_1, false).Copy();
            dataGridView1.Refresh();
            lb_G.Text = dataGridView1.Rows.Count.ToString();
        }
        private DataTable Final_Grid()
        {

            Dt_Grid.Clear();
            Int64 y = 0;
  
            for (int x = 0; x < Dt_Result.Rows.Count; x++)
            {
                y = 0;
                foreach (DataRow dr in Dt_1.Rows)
                {
                    if (Convert.ToInt64(Dt_Result.Rows[x][0]) == y)
                        Dt_Grid.Rows.Add(dr.ItemArray);

                    y++;
                }
            }
            while (Dt_Grid.Columns.Count > Dt_1.Columns.Count)
            {
                Dt_Grid.Columns.RemoveAt(Dt_1.Columns.Count);
            }
            return Dt_Grid;
        }
        private void CB1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            VCB1 = Convert.ToInt32(CB1.SelectedValue);
            Dt_1.Clear();
            Dt_1 = Dt_1_Copy.Copy();
            btn_print.Enabled = false;
        }

        private void CB2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            VCB2 = Convert.ToInt32(CB2.SelectedValue);
            Dt_2.Clear();
            Dt_2 = Dt_2_Copy.Copy();
            btn_print.Enabled = false;
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Fill_Final_Grid();
        }

        private void Btn_print_Click(object sender, EventArgs e)
        {

            if (Txt_Print.Text == "")
            {
                MessageBox.Show("Specify the file path");
            }
            else
            {
                if (backgroundWorker2.IsBusy != true)
                {
                    backgroundWorker2.RunWorkerAsync();
                }
            }
        }
        private DataTable Proccess_ON_Data(DataTable Dtt, Boolean Flag_map)
        {

            Int32 i = 0, j = 0;
            foreach (DataRow dr in Dtt.Rows)
            {
                if (!(CB_H1.Checked && i == 0))
                {
                    if (Flag_map)
                    {
                        if (!string.IsNullOrEmpty(Dtt.Rows[i]["mapcode"].ToString()))
                            dr.Delete();
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(Dtt.Rows[i]["mapcode"].ToString()))
                            dr.Delete();
                    }
                }
                i++;
            }
            Dtt.AcceptChanges();
            if (CB_H1.Checked)
            {
                foreach (DataColumn column in Dtt.Columns)
                {
                    if (column.ColumnName == "MapCode")
                        column.ColumnName = "Peer record";
                    else
                    column.ColumnName = (Dtt.Rows[0][j].ToString() != "" ? Dtt.Rows[0][j].ToString() : column.ColumnName);
                    j++;
                }
                Dtt.Rows[0].Delete();
                Dtt.AcceptChanges();
            }


            return Dtt;
        }

        private void Btn_FilesPath_print_Click(object sender, EventArgs e)
        {
            try
            {
                string folderPath;
                FolderBrowserDialog Folderbrow = new FolderBrowserDialog();
                Folderbrow.ShowDialog();
                folderPath = Folderbrow.SelectedPath;
                Txt_Print.Text = Folderbrow.SelectedPath;

                Properties.Settings.Default.Print_Address = Txt_Print.Text.Trim();
                Properties.Settings.Default.Save();
            }
            catch (Exception)
            {
            }
        }

        private void BackgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            DataSet set = new DataSet();
            DataTable temp_Dt_1 = Dt_1.Copy();
            DataTable temp_Dt_2 = Dt_2.Copy();
            DataTable temp_Dt_3 = Dt_1.Copy();
            DataTable temp_Dt_4 = Dt_2.Copy();
            worker.ReportProgress(20);
            DataTable dtCopy = Proccess_ON_Data(temp_Dt_1, false).Copy();
            DataTable dtCopy2 = Proccess_ON_Data(temp_Dt_2, false).Copy();
            DataTable dtCopy3 = Proccess_ON_Data(temp_Dt_3, true).Copy();
            DataTable dtCopy4 = Proccess_ON_Data(temp_Dt_4, true).Copy();
           worker.ReportProgress(30);

            dtCopy.TableName = "Excel1 With Records similar";
            dtCopy2.TableName = "Excel2 With Records similar";
            dtCopy3.TableName = "Excel1 without same record";
            dtCopy4.TableName = "Excel2 without same record";


            set.Tables.Add(dtCopy4);
            set.Tables.Add(dtCopy3);
            set.Tables.Add(dtCopy2);
            set.Tables.Add(dtCopy);
            worker.ReportProgress(50);
            FileName = "\\Comparator_" + DateTime.Now.ToShortDateString().Replace("/", "_") + ".xlsx";
            Excel.ExcelUtlity obj = new Excel.ExcelUtlity();
            obj.WriteDataTableToExcel(set, "Shaskam Excel Comparator", Txt_Print.Text.Trim() + FileName, "Details");
            worker.ReportProgress(100);
        }

        private void BackgroundWorker2_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar2.Value = Convert.ToInt16(e.ProgressPercentage);
        }

        private void BackgroundWorker2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled == true)
            {
                MessageBox.Show("Cancel request");
            }
            else if (e.Error != null)
            {
                MessageBox.Show("The output file encountered an error");
            }
            else
            {
                MessageBox.Show("The file was created in the specified path  " + Environment.NewLine + Environment.NewLine + Txt_Print.Text.Trim() + FileName);
            }
        }
    }
}
