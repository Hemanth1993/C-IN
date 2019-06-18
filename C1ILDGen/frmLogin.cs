using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C1ILDGen
{
    public partial class frmLogin : Form
    {
        frmMain MainForm;
        WatcherSqlClient sqlClient = null;

        public frmLogin()
        {
            InitializeComponent();
            lblWrongCred.Visible = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool LoginSuccess = ValidateLogin(txtUserName.Text.Trim(), txtPassword.Text.Trim());
            

            if (LoginSuccess == true)
            {   
                lblWrongCred.Visible = false;
                this.Hide();
                MainForm = new frmMain();
                MainForm.Show();
            }
            else
                lblWrongCred.Visible = true;
        }

        private bool ValidateLogin(string uName, string pwd)
        {
            string test = CConf.GetString("DBConnectionString");

            sqlClient = new WatcherSqlClient(CConf.GetString("DBHost"), CConf.GetString("DBName"), CConf.GetBoolean("DBTrustedConnection"), CConf.GetString("DBLogin"), CConf.GetString("DBPassword"), CConf.GetString("DBConnectionString"));
            sqlClient.OpenConnection();
            DataSet dataSetUserID = sqlClient.Query("SELECT FirstName,LastName FROM Users where UserName ='" + uName + "' and Password ='" + txtPassword.Text + "'", "DF");
            if (dataSetUserID != null && dataSetUserID.Tables.Count > 0 && dataSetUserID.Tables[0].Rows.Count > 0)
            {
                Globals.UserFirstName = dataSetUserID.Tables[0].Rows[0][0].ToString();
                Globals.UserLastName = dataSetUserID.Tables[0].Rows[0][1].ToString();
                Globals.UserID = uName;
                return true;
            }
            else
                return false;
        }
    }
}
