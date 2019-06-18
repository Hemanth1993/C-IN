using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;
using Excel = Microsoft.Office.Interop.Excel;

namespace C1ILDGen
{
    public partial class frmInstLineNumbers : Form
    {
        WatcherSqlClient sqlClient = null;
        SqlTransaction sqlTransanction = null;
        frmILDGenMain frmMain = new frmILDGenMain();
        
        public frmInstLineNumbers()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void optViewLNR_CheckedChanged(object sender, EventArgs e)
        {
            if (optViewLNR.Checked == true)
            {
                pnlImport.Visible = false;
                dgViewLNR.Visible = true;
                dgExcelData.Visible = false;
                GetLineNrData();
            }
        }

        private void optImportLNR_CheckedChanged(object sender, EventArgs e)
        {
            if (optImportLNR.Checked == true)
            {
                dgViewLNR.Visible = false;
                dgExcelData.Visible = true;
                pnlImport.Visible = true;
            }
        }

        private void GetLineNrData()
        {
            Cursor.Current = Cursors.WaitCursor;
            sqlClient = new WatcherSqlClient(CConf.GetString("DBHost"), CConf.GetString("DBName"), CConf.GetBoolean("DBTrustedConnection"), CConf.GetString("DBLogin"), CConf.GetString("DBPassword"), CConf.GetString("DBConnectionString"));
            sqlClient.OpenConnection();
            DataSet dataSetLineNr = sqlClient.Query("SELECT * FROM LINE_SERVICE_DESCRIPTION", "LSD");
            if (dataSetLineNr != null && dataSetLineNr.Tables.Count > 0 && dataSetLineNr.Tables[0].Rows.Count > 0)
            {
                dgViewLNR.DataSource = dataSetLineNr.Tables[0];
            }
            Cursor.Current = Cursors.Default;
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            if (ofdImportExcel.ShowDialog() == DialogResult.OK)
            {
                txtFilePath.Text = ofdImportExcel.FileName;
            }
        }

        private void btnRetreiveData_Click(object sender, EventArgs e)
        {
            Excel2Grid(txtFilePath.Text);
        }

        private void Excel2Grid(string sFile)
        {
            try
            {
                Excel.Application xlApp = new Excel.Application();
                Excel.Workbook xlWorkBook;
                Excel.Worksheet xlWorkSheet;

                xlApp = new Excel.Application();
                xlWorkBook = xlApp.Workbooks.Open(sFile);               // WORKBOOK TO OPEN THE EXCEL FILE.
                xlWorkSheet = xlWorkBook.Worksheets["Sheet1"];          // THE SHEET WITH THE DATA.

                dgExcelData.Rows.Clear();
                dgExcelData.Columns.Clear();

                int iRow, iCol;

                // FIRST, CREATE THE DataGridView COLUMN HEADERS.
                for (iCol = 1; iCol <= xlWorkSheet.Columns.Count; iCol++)
                {
                    if (xlWorkSheet.Cells[1, iCol].value == null)
                    {
                        break;      // BREAK LOOP.
                    }
                    else
                    {
                        DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
                        col.HeaderText = xlWorkSheet.Cells[1, iCol].value;
                        int colIndex = dgExcelData.Columns.Add(col);        // ADD A NEW COLUMN.
                    }
                }

                // ADD A BUTTON AT THE LAST COLUMN IN EVERY ROW.
                //DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                //btn.HeaderText = "";
                //btn.Text = "Save Data";
                //btn.Name = "btSave";
                //btn.UseColumnTextForButtonValue = true;
                //dgExcelData.Columns.Add(btn);

                // ADD ROWS TO THE GRID USING EXCEL DATA.
                for (iRow = 2; iCol <= xlWorkSheet.Rows.Count; iRow++)
                {
                    if (xlWorkSheet.Cells[iRow, 1].value == null)
                    {
                        break;      // BREAK LOOP.
                    }
                    else
                    {
                        // CREATE A STRING ARRAY USING THE VALUES IN EACH ROW OF THE SHEET.
                        string[] row = new string[] { xlWorkSheet.Cells[iRow, 1].value,
                    xlWorkSheet.Cells[iRow, 2].value.ToString(),
                    xlWorkSheet.Cells[iRow, 3].value };

                        // ADD A NEW ROW TO THE GRID USING THE ARRAY DATA.
                        dgExcelData.Rows.Add(row);
                    }
                }

                xlWorkBook.Close();
                xlApp.Quit();

                // CLEAN UP.
                System.Runtime.InteropServices.Marshal.ReleaseComObject(xlApp);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorkBook);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorkSheet);
                btnSaveToDB.Enabled = true;

            }
            catch
            {
                btnSaveToDB.Enabled = false;
                MessageBox.Show("Please make sure the sheet name is \"Sheet1\"");
            }
        }

        private void btnSaveToDB_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            string strSQL = string.Empty;
            int ID = GetMaxLineNr();
            for (int i = 0; i < dgExcelData.Rows.Count-1; i++)
            {
                strSQL = "INSERT INTO LINE_SERVICE_DESCRIPTION VALUES (" + ID + ",'" + dgExcelData.Rows[i].Cells[0].Value + "','" + dgExcelData.Rows[i].Cells[1].Value + "','" + dgExcelData.Rows[i].Cells[2].Value + "')";
                executeSQL(sqlClient, strSQL);
                ID++;
            }
            Cursor.Current = Cursors.Default;
            frmMain.StatStripLbl1.Text = "Saved to Database Succesfully";
            btnSaveToDB.Enabled = false;
            frmMain.Refresh();
        }

        bool executeSQL(WatcherSqlClient sqlClient, string strSQL)
        {
            if (sqlClient == null)
                return false;

            sqlClient.Query(strSQL, sqlTransanction);
            return (sqlClient.ErrorMessage == null);
        }

        private int GetMaxLineNr()
        {
            int MaxID = 1;
            sqlClient = new WatcherSqlClient(CConf.GetString("DBHost"), CConf.GetString("DBName"), CConf.GetBoolean("DBTrustedConnection"), CConf.GetString("DBLogin"), CConf.GetString("DBPassword"), CConf.GetString("DBConnectionString"));
            sqlClient.OpenConnection();
            DataSet dataSetMaxID = sqlClient.Query("SELECT MAX(ID) FROM LINE_SERVICE_DESCRIPTION", "LSD");
            if (dataSetMaxID != null && dataSetMaxID.Tables.Count > 0 && dataSetMaxID.Tables[0].Rows.Count > 0)
            {
                if (dataSetMaxID.Tables[0].Rows[0][0].ToString() != "")
                    MaxID = Convert.ToInt16(dataSetMaxID.Tables[0].Rows[0][0].ToString()) + 1;
            }
            Cursor.Current = Cursors.Default;

            return MaxID;
        }
    }
}
