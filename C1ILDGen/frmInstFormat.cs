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

namespace C1ILDGen
{
    public partial class frmInstFormat : Form
    {
        WatcherSqlClient sqlClient = null;
        SqlTransaction sqlTransanction = null;
        frmILDGenMain frmMain = new frmILDGenMain();

        public frmInstFormat()
        {
            InitializeComponent();
        }

        private void btnNewDiscCancel_Click(object sender, EventArgs e)
        {
            if (gbInstDiscFormat.Text == "Discipline Filter Forrmat")
            {
                pnlAddDisc.Visible = false;
            }
            else if (gbInstDiscFormat.Text == "Legends")
            {
                pnlLegend.Visible = false;
            }
        }

        private void btnAddNewDisc_Click(object sender, EventArgs e)
        {
            if (gbInstDiscFormat.Text == "Discipline Filter Forrmat")
            {
                pnlAddDisc.Visible = true;
            }
            else if (gbInstDiscFormat.Text == "Legends")
            {
                pnlLegend.Visible = true;
            }
        }

        private void dgDiscFilterList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgDiscFilterList.SelectedRows.Count>0)
            {
                btnDelSelDiscFilter.Enabled = true;
            }
            else
            {
                btnDelSelDiscFilter.Enabled = false;
            }
        }

        private void btnSaveNewDiscFilter_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            string strSQL = string.Empty;
            int ID = GetMaxID("DISCIPLINE_FILTER");
            string strFilterPattern = string.Empty;
            if (optStartsWith.Checked == true)
                strFilterPattern = "StartsWith";
            else
                strFilterPattern = "Contains";

            strSQL = "INSERT INTO DISCIPLINE_FILTER VALUES (" + ID + ",'" + cboDiscipline.Text + "','','" + txtNewDisc.Text + "','" + strFilterPattern + "')";
            executeSQL(sqlClient, strSQL);

            GetDiscFilterData();
            Cursor.Current = Cursors.Default;
            frmMain.StatStripLbl1.Text = "Saved to Database Succesfully";
            frmMain.Refresh();
        }

        private int GetMaxID(string strTableName)
        {
            int MaxID = 1;
            sqlClient = new WatcherSqlClient(CConf.GetString("DBHost"), CConf.GetString("DBName"), CConf.GetBoolean("DBTrustedConnection"), CConf.GetString("DBLogin"), CConf.GetString("DBPassword"), CConf.GetString("DBConnectionString"));
            sqlClient.OpenConnection();
            DataSet dataSetMaxID = sqlClient.Query("SELECT MAX(ID) FROM " + strTableName + "", "DF");
            if (dataSetMaxID != null && dataSetMaxID.Tables.Count > 0 && dataSetMaxID.Tables[0].Rows.Count > 0)
            {
                if (dataSetMaxID.Tables[0].Rows[0][0].ToString() != "")
                    MaxID = Convert.ToInt16(dataSetMaxID.Tables[0].Rows[0][0].ToString()) + 1;
            }
            Cursor.Current = Cursors.Default;

            return MaxID;
        }

        bool executeSQL(WatcherSqlClient sqlClient, string strSQL)
        {
            if (sqlClient == null)
                return false;

            sqlClient.Query(strSQL, sqlTransanction);
            return (sqlClient.ErrorMessage == null);
        }

        private void GetDiscFilterData()
        {
            Cursor.Current = Cursors.WaitCursor;

            dgDiscFilterList.Columns.Clear();

            sqlClient = new WatcherSqlClient(CConf.GetString("DBHost"), CConf.GetString("DBName"), CConf.GetBoolean("DBTrustedConnection"), CConf.GetString("DBLogin"), CConf.GetString("DBPassword"), CConf.GetString("DBConnectionString"));
            sqlClient.OpenConnection();
            DataSet dataSetLineNr = sqlClient.Query("SELECT * FROM DISCIPLINE_FILTER WHERE Discipline_Tag ='" + cboDiscipline.Text + "'", "DF");
            if (dataSetLineNr != null && dataSetLineNr.Tables.Count > 0 && dataSetLineNr.Tables[0].Rows.Count > 0)
            {
                dgDiscFilterList.DataSource = dataSetLineNr.Tables[0];
            }
            Cursor.Current = Cursors.Default;
        }

        private void GetLegendData()
        {
            Cursor.Current = Cursors.WaitCursor;

            dgDiscFilterList.Columns.Clear();

            sqlClient = new WatcherSqlClient(CConf.GetString("DBHost"), CConf.GetString("DBName"), CConf.GetBoolean("DBTrustedConnection"), CConf.GetString("DBLogin"), CConf.GetString("DBPassword"), CConf.GetString("DBConnectionString"));
            sqlClient.OpenConnection();
            DataSet dataSetLineNr = sqlClient.Query("SELECT * FROM LEGEND WHERE LegendType ='" + cboDiscipline.Text + "'", "DF");
            if (dataSetLineNr != null && dataSetLineNr.Tables.Count > 0 && dataSetLineNr.Tables[0].Rows.Count > 0)
            {
                dgDiscFilterList.DataSource = dataSetLineNr.Tables[0];
            }
            Cursor.Current = Cursors.Default;
        }

        private void cboDiscipline_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (gbInstDiscFormat.Text == "Discipline Filter Forrmat")
            {
                GetDiscFilterData();
            }
            else if (gbInstDiscFormat.Text == "Legends")
            {
                GetLegendData();
            }
        }

        private void frmInstFormat_Load(object sender, EventArgs e)
        {
            cboDiscipline.Items.Clear();
            gbInstDiscFormat.Text = Globals.InstDiscipline;
            if (gbInstDiscFormat.Text == "Discipline Filter Forrmat")
            {
                cboDiscipline.Items.Add("Instrument");
                cboDiscipline.Items.Add("Pipe");
                cboDiscipline.Items.Add("Others");
                cboDiscipline.SelectedIndex = 0;
                GetDiscFilterData();
            }
            else if (gbInstDiscFormat.Text == "Legends")
            {
                cboDiscipline.Items.Add("Line Numbers");
                cboDiscipline.SelectedIndex = 0;
                GetLegendData();
            }
        }

        private void btnLegendSave_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            string strSQL = string.Empty;
            int ID = GetMaxID("LEGEND");

            strSQL = "INSERT INTO LEGEND VALUES (" + ID + ",'" + cboDiscipline.Text + "','" + txtLegendKey.Text + "','" + txtLegendVal.Text + "')";
            executeSQL(sqlClient, strSQL);

            GetLegendData();
            Cursor.Current = Cursors.Default;
            frmMain.StatStripLbl1.Text = "Saved to Database Succesfully";
            frmMain.Refresh();
        }

        private void btnDelSelDiscFilter_Click(object sender, EventArgs e)
        {
            if (dgDiscFilterList.SelectedCells.Count > 0)
            {
                int selRow = dgDiscFilterList.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgDiscFilterList.Rows[selRow];

                string strSQL = "DELETE FROM DISCIPLINE_FILTER WHERE Discipline_Tag='" + selectedRow.Cells[1].Value + "' and Filter_Word='" + selectedRow.Cells[3].Value + "' and Filter_Pattern='" + selectedRow.Cells[4].Value + "'";
                executeSQL(sqlClient, strSQL);
                GetDiscFilterData();
            }
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
