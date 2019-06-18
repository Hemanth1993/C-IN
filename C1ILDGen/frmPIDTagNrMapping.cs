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
    public partial class frmPIDTagNrMapping : Form
    {
        WatcherSqlClient sqlClient = null;
        SqlTransaction sqlTransanction = null;
        frmILDGenMain frmMain = new frmILDGenMain();

        public frmPIDTagNrMapping()
        {
            InitializeComponent();
            pnlPIDTag.Visible = false;
            this.Width = 692;
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

        private void GetPIDTagMappingData()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                dgTagMappingList.Columns.Clear();

                sqlClient = new WatcherSqlClient(CConf.GetString("DBHost"), CConf.GetString("DBName"), CConf.GetBoolean("DBTrustedConnection"), CConf.GetString("DBLogin"), CConf.GetString("DBPassword"), CConf.GetString("DBConnectionString"));
                sqlClient.OpenConnection();
                DataSet dataSetLineNr = sqlClient.Query("SELECT * FROM PID_TAG_MAPPING ORDER BY ID", "DF");
                if (dataSetLineNr != null && dataSetLineNr.Tables.Count > 0 && dataSetLineNr.Tables[0].Rows.Count > 0)
                {
                    dgTagMappingList.DataSource = dataSetLineNr.Tables[0];
                }
                dgTagMappingList.Columns[0].Width = 100;
                dgTagMappingList.Columns[1].Width = 250;
                dgTagMappingList.Columns[2].Width = 250;
                Cursor.Current = Cursors.Default;
            }
            catch
            {
                Cursor.Current = Cursors.Default;
            }
        }

         private void btnSaveNewTag_Click(object sender, EventArgs e)
        {
            if(txtPIDTag.Text!= "")
            {
                Cursor.Current = Cursors.WaitCursor;
                string strSQL = string.Empty;
                int ID = GetMaxID("PID_TAG_MAPPING");

                strSQL = "INSERT INTO PID_TAG_MAPPING VALUES (" + ID + ",'" + txtPIDTag.Text.Trim() + "','" + txtNewTag.Text.Trim() + "')";
                executeSQL(sqlClient, strSQL);

                GetPIDTagMappingData();
                txtNewTag.Text = "";
                txtPIDTag.Text = "";

                Cursor.Current = Cursors.Default;
                frmMain.StatStripLbl1.Text = "Saved to Database Succesfully";
                frmMain.Refresh();
            }
        }

        private void dgTagMappingList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgTagMappingList.SelectedRows.Count > 0)
            {
                btnDeleteTag.Enabled = true;
            }
            else
            {
                btnDeleteTag.Enabled = false;
            }
        }

        private void frmPIDTagNrMapping_Load(object sender, EventArgs e)
        {
            GetPIDTagMappingData();
        }

        private void btnDeleteTag_Click(object sender, EventArgs e)
        {
            if (dgTagMappingList.SelectedCells.Count > 0)
            {
                int selRow = dgTagMappingList.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgTagMappingList.Rows[selRow];

                string strSQL = "DELETE FROM PID_TAG_MAPPING WHERE PIDTag='" + selectedRow.Cells[1].Value + "' and NewTag='" + selectedRow.Cells[2].Value + "'";
                executeSQL(sqlClient, strSQL);
                GetPIDTagMappingData();
            }
        }

        private void btnAddNewDisc_Click(object sender, EventArgs e)
        {
            pnlPIDTag.Visible = true;
            this.Width = 1013;
            this.Left = this.Left - 150;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlPIDTag.Visible = false;
            this.Width = 692;
            this.Left = this.Left + 150;
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
