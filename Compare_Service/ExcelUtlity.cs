using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace Excel
{
    public class ExcelUtlity
    {
        /// <summary>
        /// FUNCTION FOR EXPORT TO EXCEL
        /// </summary>
        /// <param name="dataTable"></param>
        /// <param name="worksheetName"></param>
        /// <param name="saveAsLocation"></param>
        /// <returns></returns>
        /// 

        public bool WriteDataTableToExcel(System.Data.DataSet ds, string worksheetName, string saveAsLocation, string ReporType)
        {
            Microsoft.Office.Interop.Excel.Application excel;
            Microsoft.Office.Interop.Excel.Workbook excelworkBook;
            Microsoft.Office.Interop.Excel.Worksheet excelSheet;
            Microsoft.Office.Interop.Excel.Range excelCellrange;

            try
            {
                //Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
                //Microsoft.Office.Interop.Excel.Workbook excelWorkBook = excelApp.Workbooks.Add(Type.Missing);
                //int count = 1;
                //foreach (System.Data.DataTable table in ds.Tables)
                //{
                //    Microsoft.Office.Interop.Excel.Worksheet excelWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)excelWorkBook.ActiveSheet;
                //    excelWorkSheet.Name = table.TableName;
                //    for (int i = 1; i < table.Columns.Count + 1; i++)
                //    {
                //        excelWorkSheet.Cells[1, i] = table.Columns[i - 1].ColumnName;
                //    }
                //    for (int j = 0; j < table.Rows.Count; j++)
                //    {
                //        for (int k = 0; k < table.Columns.Count; k++)
                //        {
                //            excelWorkSheet.Cells[j + 2, k + 1] = table.Rows[j].ItemArray[k].ToString();
                //        }
                //    }
                //    if (count < ds.Tables.Count)
                //    {
                //        excelWorkBook.Sheets.Add(excelWorkSheet);
                //    }
                //    count++;
                //}

                //excelWorkBook.SaveAs(saveAsLocation);
                //excelWorkBook.Close();
                //excelApp.Quit();

                /**************************************************/
                excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = false;
                excel.DisplayAlerts = false;
                excelworkBook = excel.Workbooks.Add(Type.Missing);
                int count = 1;
                foreach (System.Data.DataTable table in ds.Tables)
                {
                    excelSheet = (Microsoft.Office.Interop.Excel.Worksheet)excelworkBook.ActiveSheet;
                    excelSheet.Name = table.TableName;
                    //excelSheet.Cells[1, 1] = ReporType;
                    //excelSheet.Cells[1, 2] = "Date : " + DateTime.Now.ToShortDateString();
                    int rowcount = 1;
                    foreach (DataRow datarow in table.Rows)
                    {
                        rowcount += 1;
                        for (int i = 1; i <= table.Columns.Count; i++)
                        {
                            if (rowcount == 2)
                            {
                                excelCellrange = excelSheet.Range[excelSheet.Cells[rowcount, 1], excelSheet.Cells[rowcount, table.Columns.Count]];
                                FormattingExcelCells(excelCellrange, "#CCCCFF", System.Drawing.Color.Black, false);
                                excelSheet.Cells[1, i] = table.Columns[i - 1].ColumnName;
                                excelSheet.Cells.Font.Color = System.Drawing.Color.Black;
                            }
                            excelSheet.Cells[rowcount, i] = datarow[i - 1].ToString();
                            if (rowcount > 3)
                            {
                                if (i == table.Columns.Count)
                                {
                                    if (rowcount % 2 == 0)
                                    {
                                        excelCellrange = excelSheet.Range[excelSheet.Cells[rowcount, 1], excelSheet.Cells[rowcount, table.Columns.Count]];
                                        FormattingExcelCells(excelCellrange, "#CCCCFF", System.Drawing.Color.Black, false);
                                    }
                                }
                            }
                        }
                    }
                    excelCellrange = excelSheet.Range[excelSheet.Cells[1, 1], excelSheet.Cells[rowcount, table.Columns.Count]];
                    excelCellrange.EntireColumn.AutoFit();
                    Microsoft.Office.Interop.Excel.Borders border = excelCellrange.Borders;
                    border.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                    border.Weight = 2d;
                    excelCellrange = excelSheet.Range[excelSheet.Cells[1, 1], excelSheet.Cells[1, table.Columns.Count]];
                    FormattingExcelCells(excelCellrange, "#000099", System.Drawing.Color.White, true);
                    if (count < ds.Tables.Count)
                    {
                        excelworkBook.Sheets.Add(excelSheet);
                    }
                    count++;
                }
                excelworkBook.SaveAs(saveAsLocation); ;
                excelworkBook.Close();
                excel.Quit();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                excelSheet = null;
                excelCellrange = null;
                excelworkBook = null;
            }

        }


        public bool WriteDataTableToExcel(System.Data.DataTable dataTable, string worksheetName, string saveAsLocation, string ReporType)
        {
            Microsoft.Office.Interop.Excel.Application excel;
            Microsoft.Office.Interop.Excel.Workbook excelworkBook;
            Microsoft.Office.Interop.Excel.Worksheet excelSheet;
            Microsoft.Office.Interop.Excel.Range excelCellrange;

            try
            {
                // Start Excel and get Application object.
                excel = new Microsoft.Office.Interop.Excel.Application();

                // for making Excel visible
                excel.Visible = false;
                excel.DisplayAlerts = false;

                // Creation a new Workbook
                excelworkBook = excel.Workbooks.Add(Type.Missing);

                // Workk sheet
                excelSheet = (Microsoft.Office.Interop.Excel.Worksheet)excelworkBook.ActiveSheet;
                excelSheet.Name = worksheetName;


                excelSheet.Cells[1, 1] = ReporType;
                excelSheet.Cells[1, 2] = "Date : " + DateTime.Now.ToShortDateString();

                // loop through each row and add values to our sheet
                int rowcount = 2;

                foreach (DataRow datarow in dataTable.Rows)
                {
                    rowcount += 1;
                    for (int i = 1; i <= dataTable.Columns.Count; i++)
                    {
                        // on the first iteration we add the column headers
                        if (rowcount == 3)
                        {
                            excelSheet.Cells[2, i] = dataTable.Columns[i - 1].ColumnName;
                            excelSheet.Cells.Font.Color = System.Drawing.Color.Black;

                        }

                        excelSheet.Cells[rowcount, i] = datarow[i - 1].ToString();

                        //for alternate rows
                        if (rowcount > 3)
                        {
                            if (i == dataTable.Columns.Count)
                            {
                                if (rowcount % 2 == 0)
                                {
                                    excelCellrange = excelSheet.Range[excelSheet.Cells[rowcount, 1], excelSheet.Cells[rowcount, dataTable.Columns.Count]];
                                    FormattingExcelCells(excelCellrange, "#CCCCFF", System.Drawing.Color.Black, false);
                                }

                            }
                        }

                    }

                }

                // now we resize the columns
                excelCellrange = excelSheet.Range[excelSheet.Cells[1, 1], excelSheet.Cells[rowcount, dataTable.Columns.Count]];
                excelCellrange.EntireColumn.AutoFit();
                Microsoft.Office.Interop.Excel.Borders border = excelCellrange.Borders;
                border.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                border.Weight = 2d;


                excelCellrange = excelSheet.Range[excelSheet.Cells[1, 1], excelSheet.Cells[2, dataTable.Columns.Count]];
                FormattingExcelCells(excelCellrange, "#000099", System.Drawing.Color.White, true);


                //now save the workbook and exit Excel


                excelworkBook.SaveAs(saveAsLocation); ;
                excelworkBook.Close();
                excel.Quit();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                excelSheet = null;
                excelCellrange = null;
                excelworkBook = null;
            }

        }

        /// <summary>
        /// FUNCTION FOR FORMATTING EXCEL CELLS
        /// </summary>
        /// <param name="range"></param>
        /// <param name="HTMLcolorCode"></param>
        /// <param name="fontColor"></param>
        /// <param name="IsFontbool"></param>
        public void FormattingExcelCells(Microsoft.Office.Interop.Excel.Range range, string HTMLcolorCode, System.Drawing.Color fontColor, bool IsFontbool)
        {
            range.Interior.Color = System.Drawing.ColorTranslator.FromHtml(HTMLcolorCode);
            range.Font.Color = System.Drawing.ColorTranslator.ToOle(fontColor);
            if (IsFontbool == true)
            {
                range.Font.Bold = IsFontbool;
            }
        }

    }
}
