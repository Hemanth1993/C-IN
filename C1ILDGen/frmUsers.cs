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
    public partial class frmUsers : Form
    {
        WatcherSqlClient sqlClient = null;
        SqlTransaction sqlTransanction = null;

        public frmUsers()
        {
            InitializeComponent();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private int GetProjectID(string strpName)
        {
            int PID = 1;
            sqlClient = new WatcherSqlClient(CConf.GetString("DBHost"), CConf.GetString("DBName"), CConf.GetBoolean("DBTrustedConnection"), CConf.GetString("DBLogin"), CConf.GetString("DBPassword"), CConf.GetString("DBConnectionString"));
            sqlClient.OpenConnection();
            DataSet dataSetProjectID = sqlClient.Query("SELECT ProjectID from PROJECT where ProjectName ='" + strpName + "'", "DF");
            if (dataSetProjectID != null && dataSetProjectID.Tables.Count > 0 && dataSetProjectID.Tables[0].Rows.Count > 0)
            {
                if (dataSetProjectID.Tables[0].Rows[0][0].ToString() != "")
                    PID = Convert.ToInt16(dataSetProjectID.Tables[0].Rows[0][0].ToString());
            }
            Cursor.Current = Cursors.Default;
            return PID;
        }

        private string GetProjectName(string PID)
        {
            sqlClient = new WatcherSqlClient(CConf.GetString("DBHost"), CConf.GetString("DBName"), CConf.GetBoolean("DBTrustedConnection"), CConf.GetString("DBLogin"), CConf.GetString("DBPassword"), CConf.GetString("DBConnectionString"));
            sqlClient.OpenConnection();
            DataSet dataSetProjectID = sqlClient.Query("SELECT ProjectName from PROJECT where ProjectID ='" + PID + "'", "DF");
            if (dataSetProjectID != null && dataSetProjectID.Tables.Count > 0 && dataSetProjectID.Tables[0].Rows.Count > 0)
            {
                if (dataSetProjectID.Tables[0].Rows[0][0].ToString() != "")
                    return dataSetProjectID.Tables[0].Rows[0][0].ToString();
            }
            Cursor.Current = Cursors.Default;
            return null;
        }

        private bool CheckUserNameExists(string uName)
        {
            sqlClient = new WatcherSqlClient(CConf.GetString("DBHost"), CConf.GetString("DBName"), CConf.GetBoolean("DBTrustedConnection"), CConf.GetString("DBLogin"), CConf.GetString("DBPassword"), CConf.GetString("DBConnectionString"));
            sqlClient.OpenConnection();
            DataSet dataSetUserID = sqlClient.Query("SELECT ID FROM Users where UserName ='" + uName + "'", "DF");
            if (dataSetUserID != null && dataSetUserID.Tables.Count > 0 && dataSetUserID.Tables[0].Rows.Count > 0)
                return true;
            else
                return false;
        }

        bool executeSQL(WatcherSqlClient sqlClient, string strSQL)
        {
            if (sqlClient == null)
                return false;

            sqlClient.Query(strSQL, sqlTransanction);
            return (sqlClient.ErrorMessage == null);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (btnSave.Text == "Save")
            {
                Cursor.Current = Cursors.WaitCursor;
                string strSQL = string.Empty;

                bool UserExists = CheckUserNameExists(txtUserID.Text.Trim());

                if (UserExists == false)
                {
                    int ID = GetMaxID("Users");
                    string Role = "Admin";
                    string Status = "Active";
                    if (optAdmin.Checked == false)
                        Role = "Engineer";
                    if (optActive.Checked == false)
                        Status = "Inactive";


                    strSQL = "INSERT INTO Users VALUES (" + ID + ",'" + txtFirstName.Text + "','" + txtLastName.Text + "','" + txtUserID.Text + "','" + txtPassword.Text + "','" + Role + "','" + Status + "')";
                    executeSQL(sqlClient, strSQL);

                    for (int i = 0; i < lbAssignedProj.Items.Count; i++)
                    {
                        AddUserProjects(txtUserID.Text, (string)lbAssignedProj.Items[i]);
                    }

                    PopulateUsersList(1, txtSearch.Text);
                    btnSave.Visible = false;
                    btnCancel.Visible = false;
                }
                Cursor.Current = Cursors.Default;
            }
            else
            {
                for (int i = 0; i < lbNewProject.Items.Count; i++)
                {
                    UnassignUserProjects(txtUserID.Text, (string)lbNewProject.Items[i]);
                }
                for ( int i=0; i< lbAssignedProj.Items.Count; i++)
                {
                    AddUserProjects(txtUserID.Text, (string)lbAssignedProj.Items[i]);
                }
            }
        }

        private void UnassignUserProjects(string UserId, string pName)
        {
            Cursor.Current = Cursors.WaitCursor;
            string strSQL = string.Empty;
            string PID = GetProjectID(pName).ToString();
            bool UserProjectExists = CheckUserProjectExists(UserId, PID);

            if (UserProjectExists == true)
            {
                String Status = "Inactive";

                strSQL = "Update USER_PROJECTS Set Status='" + Status + "' where UserID ='" + UserId + "'and ProjectID ='" + PID + "')";
                executeSQL(sqlClient, strSQL);
            }
        }

        private void AddUserProjects(string UserId, string pName)
        {
            Cursor.Current = Cursors.WaitCursor;
            string strSQL = string.Empty;
            bool UserProjectExists = CheckUserProjectExists(UserId, GetProjectID(pName).ToString());

            if (UserProjectExists == false)
            {
                int ID = GetMaxID("USER_PROJECTS");
                int PID = GetProjectID(pName);
                String Status = "Active";

                strSQL = "INSERT INTO USER_PROJECTS VALUES (" + ID + ",'" + UserId + "','" + PID + "','" + System.DateTime.Now + "','" + Status + "')";
                executeSQL(sqlClient, strSQL);
            }
        }

        private bool CheckUserProjectExists(string UserId, string pName)
        {
            sqlClient = new WatcherSqlClient(CConf.GetString("DBHost"), CConf.GetString("DBName"), CConf.GetBoolean("DBTrustedConnection"), CConf.GetString("DBLogin"), CConf.GetString("DBPassword"), CConf.GetString("DBConnectionString"));
            sqlClient.OpenConnection();
            DataSet dataSetUserID = sqlClient.Query("SELECT ID FROM USER_PROJECTS where UserID ='" + UserId + "' and ProjectID ='" + pName + "'", "DF");
            if (dataSetUserID != null && dataSetUserID.Tables.Count > 0 && dataSetUserID.Tables[0].Rows.Count > 0)
                return true;
            else
                return false;
        }

        private void PopulateUsersList(int parentId, string pName)
        {
            lvUser.Items.Clear();
            ListViewItem item;

            sqlClient = new WatcherSqlClient(CConf.GetString("DBHost"), CConf.GetString("DBName"), CConf.GetBoolean("DBTrustedConnection"), CConf.GetString("DBLogin"), CConf.GetString("DBPassword"), CConf.GetString("DBConnectionString"));
            sqlClient.OpenConnection();
            DataSet dataSetProj = sqlClient.Query("Select FirstName, LastName, UserName FROM Users where FirstName like '%" + txtSearch.Text + "%' or LastName like '%" + txtSearch.Text + "%' order by ID", "USERS");
            if (dataSetProj != null && dataSetProj.Tables.Count > 0 && dataSetProj.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < dataSetProj.Tables[0].Rows.Count; i++)
                {
                    item = lvUser.Items.Add(dataSetProj.Tables[0].Rows[i][0].ToString() + " " + dataSetProj.Tables[0].Rows[i][1].ToString(), 0);
                    item.ToolTipText = String.Format("UserName: {0}", dataSetProj.Tables[0].Rows[i][2].ToString());
                    item.Tag = dataSetProj.Tables[0].Rows[i][2].ToString();
                }
            }
        }

        private void PopulateUnAssignedProjectList(string UID)
        {
            lbNewProject.Items.Clear();

            sqlClient = new WatcherSqlClient(CConf.GetString("DBHost"), CConf.GetString("DBName"), CConf.GetBoolean("DBTrustedConnection"), CConf.GetString("DBLogin"), CConf.GetString("DBPassword"), CConf.GetString("DBConnectionString"));
            sqlClient.OpenConnection();
            //DataSet dataSetProj = sqlClient.Query("SELECT PROJECT.*FROM((SELECT Projectid FROM PROJECT) EXCEPT(SELECT ProjectID FROM USER_PROJECTS where UserID = '" + UID + "' and Status = 'Inactive')) t1_not_in_t2 JOIN PROJECT ON t1_not_in_t2.ProjectID = PROJECT.ProjectID", "PROJECT");
            DataSet dataSetProj = sqlClient.Query("SELECT PROJECT.*FROM((SELECT Projectid FROM PROJECT) EXCEPT(SELECT ProjectID FROM USER_PROJECTS where UserID = '" + UID + "')) t1_not_in_t2 JOIN PROJECT ON t1_not_in_t2.ProjectID = PROJECT.ProjectID", "PROJECT");

            if (dataSetProj != null && dataSetProj.Tables.Count > 0 && dataSetProj.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < dataSetProj.Tables[0].Rows.Count; i++)
                {
                    lbNewProject.Items.Add(dataSetProj.Tables[0].Rows[i][1].ToString());
                }
            }
        }


        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            ClearTextBoxes(this);
            btnSave.Text = "Save";
            btnSave.Visible = true;
            btnCancel.Visible = true;
        }

        public void ClearTextBoxes(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is TextBox)
                {
                    if (c.Name.ToString() != "txtSearch")
                        ((TextBox)c).Clear();
                }
                if (c.HasChildren)
                {
                    ClearTextBoxes(c);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnSave.Visible = false;
            btnCancel.Visible = false;
        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            PopulateUsersList(1, txtSearch.Text);
            lvUser.Items[0].Focused = true;
            lvUser.Items[0].Selected = true;
        }

        private void GetUserDetails(string uName)
        {
            ClearTextBoxes(this);
            sqlClient = new WatcherSqlClient(CConf.GetString("DBHost"), CConf.GetString("DBName"), CConf.GetBoolean("DBTrustedConnection"), CConf.GetString("DBLogin"), CConf.GetString("DBPassword"), CConf.GetString("DBConnectionString"));
            sqlClient.OpenConnection();
            DataSet dataSetProj = sqlClient.Query("Select * FROM Users where UserName ='" + uName + "'", "USER");
            if (dataSetProj != null && dataSetProj.Tables.Count > 0 && dataSetProj.Tables[0].Rows.Count > 0)
            {
                txtFirstName.Text = dataSetProj.Tables[0].Rows[0][1].ToString().Trim();
                txtLastName.Text = dataSetProj.Tables[0].Rows[0][2].ToString().Trim();
                txtUserID.Text = dataSetProj.Tables[0].Rows[0][3].ToString().Trim();
                txtPassword.Enabled = false;
                if (dataSetProj.Tables[0].Rows[0][5].ToString().Trim() == "Admin")
                    optAdmin.Checked = true;
                else
                    optEngineer.Checked = true;

                if (dataSetProj.Tables[0].Rows[0][6].ToString().Trim() == "Active")
                    optActive.Checked = true;
                else
                    optInactive.Checked = true;
            }
        }

        private void GetUserProjectDetails(string uName)
        {
            lbAssignedProj.Items.Clear();
            sqlClient = new WatcherSqlClient(CConf.GetString("DBHost"), CConf.GetString("DBName"), CConf.GetBoolean("DBTrustedConnection"), CConf.GetString("DBLogin"), CConf.GetString("DBPassword"), CConf.GetString("DBConnectionString"));
            sqlClient.OpenConnection();
            DataSet dataSetProj = sqlClient.Query("Select * FROM  USER_PROJECTS where UserID ='" + uName + "'", "USER");
            if (dataSetProj != null && dataSetProj.Tables.Count > 0 && dataSetProj.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < dataSetProj.Tables[0].Rows.Count; i++)
                {
                    lbAssignedProj.Items.Add(GetProjectName(dataSetProj.Tables[0].Rows[i][2].ToString()));
                }
            }
        }

        private void lvUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvUser.SelectedItems.Count > 0)
            {
                GetUserDetails(lvUser.SelectedItems[0].Tag.ToString());
                GetUserProjectDetails(lvUser.SelectedItems[0].Tag.ToString());
                PopulateUnAssignedProjectList(lvUser.SelectedItems[0].Tag.ToString());
                btnSave.Text = "Update";
                btnSave.Visible = true;
                btnCancel.Visible = true;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            PopulateUsersList(1, txtSearch.Text);
        }

        private void txtLastName_Leave(object sender, EventArgs e)
        {
            if(btnSave.Visible == true && txtUserID.Text == "")
            {
                string fName = txtFirstName.Text;
                string lName = txtLastName.Text;
                if (fName.IndexOf(" ") > 0) fName = fName.Substring(0, fName.IndexOf(" "));
                if (lName.IndexOf(" ") > 0) lName = lName.Substring(0, lName.IndexOf(" "));
                txtUserID.Text = fName + lName;
            }
        }

        // Move selected items from one ListBox to another.
        private void MoveSelectedItems(ListBox lstFrom, ListBox lstTo)
        {
            while (lstFrom.SelectedItems.Count > 0)
            {
                string item = (string)lstFrom.SelectedItems[0];
                lstTo.Items.Add(item);
                lstFrom.Items.Remove(item);
            }
            SetButtonsEditable();
        }

        // Move all items from one ListBox to another.
        private void MoveAllItems(ListBox lstFrom, ListBox lstTo)
        {
            lstTo.Items.AddRange(lstFrom.Items);
            lstFrom.Items.Clear();
            SetButtonsEditable();
        }

        // Enable and disable buttons.
        private void SetButtonsEditable()
        {
            btnOneForward.Enabled = (lbNewProject.Items.Count > 0);
            btnAllForward.Enabled = (lbNewProject.Items.Count > 0);
            btnOneBackward.Enabled = (lbAssignedProj.Items.Count > 0);
            btnAllBackward.Enabled = (lbAssignedProj.Items.Count > 0);
        }

        private void btnOneForward_Click(object sender, EventArgs e)
        {
            MoveSelectedItems(lbNewProject, lbAssignedProj);
        }

        private void btnOneBackward_Click(object sender, EventArgs e)
        {
            MoveSelectedItems(lbAssignedProj, lbNewProject);
        }

        private void btnAllForward_Click(object sender, EventArgs e)
        {
            MoveAllItems(lbNewProject, lbAssignedProj);
        }

        private void btnAllBackward_Click(object sender, EventArgs e)
        {
            MoveAllItems(lbAssignedProj, lbNewProject);
        }

    }
}
