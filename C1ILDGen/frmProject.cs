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
    public partial class frmProject : Form
    {
        WatcherSqlClient sqlClient = null;
        SqlTransaction sqlTransanction = null;

        public frmProject()
        {
            InitializeComponent();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            string strSQL = string.Empty;
            bool ProjNameExists = CheckProjectNameExists(txtPName.Text.Trim());

            if (ProjNameExists == false)
            {
                int ID = GetMaxID("PROJECT");

                strSQL = "INSERT INTO PROJECT VALUES (" + ID + ",'" + txtPName.Text + "','" + txtPDetails.Text + "','" + txtSDetails.Text + "','" + Globals.UserID + "','" + System.DateTime.Now + "')";
                executeSQL(sqlClient, strSQL);

                PopulateProjectList();
                btnSave.Visible = false;
                btnCancel.Visible = false;
            }
            else
                MessageBox.Show("Project already exists. Please use a different project name.");

            Cursor.Current = Cursors.Default;
        }

        private bool CheckProjectNameExists(string uName)
        {
            sqlClient = new WatcherSqlClient(CConf.GetString("DBHost"), CConf.GetString("DBName"), CConf.GetBoolean("DBTrustedConnection"), CConf.GetString("DBLogin"), CConf.GetString("DBPassword"), CConf.GetString("DBConnectionString"));
            sqlClient.OpenConnection();
            DataSet dataSetProjectID = sqlClient.Query("SELECT ProjectID FROM PROJECT where ProjectName ='" + uName + "'", "PID");
            if (dataSetProjectID != null && dataSetProjectID.Tables.Count > 0 && dataSetProjectID.Tables[0].Rows.Count > 0)
                return true;
            else
                return false;
        }

        private int GetMaxID(string strTableName)
        {
            int MaxID = 1;
            sqlClient = new WatcherSqlClient(CConf.GetString("DBHost"), CConf.GetString("DBName"), CConf.GetBoolean("DBTrustedConnection"), CConf.GetString("DBLogin"), CConf.GetString("DBPassword"), CConf.GetString("DBConnectionString"));
            sqlClient.OpenConnection();
            DataSet dataSetMaxID = sqlClient.Query("SELECT MAX(ProjectID) FROM " + strTableName + "", "DF");
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

        private void frmProject_Load(object sender, EventArgs e)
        {
            PopulateProjectList();
            lvProj.Items[0].Focused = true;
            lvProj.Items[0].Selected = true;
        }

        private void PopulateProjectList()
        {
            lvProj.Items.Clear();

            sqlClient = new WatcherSqlClient(CConf.GetString("DBHost"), CConf.GetString("DBName"), CConf.GetBoolean("DBTrustedConnection"), CConf.GetString("DBLogin"), CConf.GetString("DBPassword"), CConf.GetString("DBConnectionString"));
            sqlClient.OpenConnection();
            DataSet dataSetProj = sqlClient.Query("Select ProjectName FROM Project where ProjectName like '%" + txtSearch.Text + "%' order by ProjectID" , "PROJECT");
            if (dataSetProj != null && dataSetProj.Tables.Count > 0 && dataSetProj.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < dataSetProj.Tables[0].Rows.Count; i++)
                {
                    lvProj.Items.Add(dataSetProj.Tables[0].Rows[i][0].ToString(),0);
                }
            }
            //var colored = false;
            //foreach (ListViewItem item in lvProj.Items)
            //{
            //    item.BackColor = colored ? Color.LightBlue : Color.White;
            //    colored = !colored;
            //}
        }

        private void GetProjectDetails(string pName)
        {
            ClearTextBoxes(this);
            sqlClient = new WatcherSqlClient(CConf.GetString("DBHost"), CConf.GetString("DBName"), CConf.GetBoolean("DBTrustedConnection"), CConf.GetString("DBLogin"), CConf.GetString("DBPassword"), CConf.GetString("DBConnectionString"));
            sqlClient.OpenConnection();
            DataSet dataSetProj = sqlClient.Query("Select * FROM Project where ProjectName ='" + pName + "'", "PROJECT");
            if (dataSetProj != null && dataSetProj.Tables.Count > 0 && dataSetProj.Tables[0].Rows.Count > 0)
            {
                txtPID.Text = dataSetProj.Tables[0].Rows[0][0].ToString().Trim();
                txtPName.Text = dataSetProj.Tables[0].Rows[0][1].ToString().Trim();
                txtPDetails.Text = dataSetProj.Tables[0].Rows[0][2].ToString().Trim();
                txtSDetails.Text = dataSetProj.Tables[0].Rows[0][3].ToString().Trim();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            PopulateProjectList();
        }

        private void btnAddNewProj_Click(object sender, EventArgs e)
        {
            ClearTextBoxes(this);
            btnSave.Visible = true;
            btnCancel.Visible = true;
        }

        public void ClearTextBoxes(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is TextBox)
                {
                    if(c.Name.ToString() != "txtSearch")
                        ((TextBox)c).Clear();
                }
                if (c is RichTextBox)
                {
                        ((RichTextBox)c).Clear();
                }
                if (c.HasChildren)
                {
                    ClearTextBoxes(c);
                }
            }
        }

        private void lvProj_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lvProj.SelectedItems.Count > 0)
                GetProjectDetails(lvProj.SelectedItems[0].Text);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnSave.Visible = false;
            btnCancel.Visible = false;
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
