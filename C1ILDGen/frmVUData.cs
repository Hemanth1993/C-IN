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
    public partial class frmVUData : Form
    {
        SqlTransaction sqlTransanction = null;
        WatcherSqlClient sqlClient = null;
        List<KeyValuePair<string, string>> hashLineNr = new List<KeyValuePair<string, string>>();
        List<KeyValuePair<string, string>> hashMakeDetails = new List<KeyValuePair<string, string>>();
        HashSet<DataGridViewCell> changedCells = new HashSet<DataGridViewCell>();
        private TreeViewCancelEventHandler checkForCheckedChildren;

        public frmVUData()
        {
            InitializeComponent();
            checkForCheckedChildren = new TreeViewCancelEventHandler(CheckForCheckedChildrenHandler);
        }

        private void btnGetTagData_Click(object sender, EventArgs e)
        {
            frmWait frmShowWait = new frmWait();
            frmShowWait.StartPosition = FormStartPosition.CenterScreen;
            frmShowWait.Show();
            frmShowWait.Refresh();

            btnClearDG_Click(this, e);
            changedCells.Clear();

            if (cboExtractList.Text == "Instrument Index")
            {
                GenerateInstIndexData();
            }
            else if (cboExtractList.Text == "I/O List")
            {
                GenerateIOListData();
            }
            else if (cboExtractList.Text == "JB Schedule List")
            {
                GenerateJBSchtData();
            }
            frmShowWait.Hide();
        }

        private void btnClearDG_Click(object sender, EventArgs e)
        {
            dgTags.Rows.Clear();
            dgTags.Columns.Clear();
            cboLineNr.Visible = false;
            cboMake.Visible = false;
            cboLineNr.Items.Clear();
            btnExpToExcel.Enabled = false;
        }

        private void GenerateTViewInstIndexData(string PIDList)
        {
            string strQueryTag = string.Empty;
            string strQueryLinrNr = string.Empty;
            sqlClient = new WatcherSqlClient(CConf.GetString("DBHost"), CConf.GetString("DBName"), CConf.GetBoolean("DBTrustedConnection"), CConf.GetString("DBLogin"), CConf.GetString("DBPassword"), CConf.GetString("DBConnectionString"));
            sqlClient.OpenConnection();
            if (PIDList == "All")
            {
                strQueryTag = "SELECT * FROM INSTRUMENT_TAG_DETAILS";
            }
            else
            {
                strQueryTag = "SELECT * FROM INSTRUMENT_TAG_DETAILS WHERE " + PIDList;
            }
            DataSet dataSet = sqlClient.Query(strQueryTag, "TAG");

            cboLineNr.Items.Clear();
            cboLineNr.Text = "";
            btnExpToExcel.Enabled = true;

            dgTags.ColumnCount = 25;
            dgTags.Columns[0].Name = "Tag Number";
            dgTags.Columns[1].Name = "Loop Name";
            dgTags.Columns[2].Name = "Instrument Description";
            dgTags.Columns[3].Name = "Service Description";
            dgTags.Columns[4].Name = "Line / Equipment Number";
            dgTags.Columns[5].Name = "Make";
            dgTags.Columns[6].Name = "Model Number";
            dgTags.Columns[7].Name = "Inst Range Min";
            dgTags.Columns[8].Name = "Inst Range Max";
            dgTags.Columns[9].Name = "Calibration Min";
            dgTags.Columns[10].Name = "Calibration Max";
            dgTags.Columns[11].Name = "Unit";
            dgTags.Columns[12].Name = "Alarm LL";
            dgTags.Columns[13].Name = "Alarm L";
            dgTags.Columns[14].Name = "Alarm H";
            dgTags.Columns[15].Name = "Alarm HH";
            dgTags.Columns[16].Name = "Setpoint";
            dgTags.Columns[17].Name = "P & ID Number";
            dgTags.Columns[18].Name = "Remarks";
            dgTags.Columns[19].Name = "Rev. Number";
            dgTags.Columns[20].Name = "P&&P Hookup Number";
            dgTags.Columns[21].Name = "Wiring Drawing Number";
            dgTags.Columns[22].Name = "Installation Drawing Number";
            dgTags.Columns[23].Name = "Functional Scheme Number";
            dgTags.Columns[24].Name = "Logic Diagram Number";


            if (dataSet != null && dataSet.Tables.Count > 0 && dataSet.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
                {
                    dgTags.Rows.Add(dataSet.Tables[0].Rows[i][0].ToString().Trim(), dataSet.Tables[0].Rows[i][1].ToString().Trim(),
                        dataSet.Tables[0].Rows[i][2].ToString().Trim(), dataSet.Tables[0].Rows[i][3].ToString().Trim(), dataSet.Tables[0].Rows[i][4].ToString().Trim(),
                        dataSet.Tables[0].Rows[i][5].ToString().Trim(), dataSet.Tables[0].Rows[i][6].ToString().Trim(), dataSet.Tables[0].Rows[i][7].ToString().Trim(),
                        dataSet.Tables[0].Rows[i][8].ToString().Trim(), dataSet.Tables[0].Rows[i][9].ToString().Trim(), dataSet.Tables[0].Rows[i][10].ToString().Trim(),
                        dataSet.Tables[0].Rows[i][11].ToString().Trim(), dataSet.Tables[0].Rows[i][12].ToString().Trim(), dataSet.Tables[0].Rows[i][13].ToString().Trim(),
                        dataSet.Tables[0].Rows[i][14].ToString().Trim(), dataSet.Tables[0].Rows[i][15].ToString().Trim(), dataSet.Tables[0].Rows[i][16].ToString().Trim(),
                        dataSet.Tables[0].Rows[i][17].ToString().Trim(), dataSet.Tables[0].Rows[i][18].ToString().Trim(), dataSet.Tables[0].Rows[i][19].ToString().Trim(),
                        dataSet.Tables[0].Rows[i][20].ToString().Trim(), dataSet.Tables[0].Rows[i][21].ToString().Trim(), dataSet.Tables[0].Rows[i][22].ToString().Trim(),
                        dataSet.Tables[0].Rows[i][23].ToString().Trim(), dataSet.Tables[0].Rows[i][24].ToString().Trim());
                }
            }
        }


        private void GenerateInstIndexData()
        {
            string strQueryTag = string.Empty;
            string strQueryLinrNr = string.Empty;
            sqlClient = new WatcherSqlClient(CConf.GetString("DBHost"), CConf.GetString("DBName"), CConf.GetBoolean("DBTrustedConnection"), CConf.GetString("DBLogin"), CConf.GetString("DBPassword"), CConf.GetString("DBConnectionString"));
            sqlClient.OpenConnection();
            if (cboPIDList.Text == "All")
            {
                strQueryTag = "SELECT * FROM INSTRUMENT_TAG_DETAILS";
            }
            else
            {
                strQueryTag = "SELECT * FROM INSTRUMENT_TAG_DETAILS WHERE PIDNumber='" + cboPIDList.Text + "'";
            }
            DataSet dataSet = sqlClient.Query(strQueryTag, "TAG");

            cboLineNr.Items.Clear();
            cboLineNr.Text = "";
            btnExpToExcel.Enabled = true;

            dgTags.ColumnCount = 25;
            dgTags.Columns[0].Name = "Tag Number";
            dgTags.Columns[1].Name = "Loop Name";
            dgTags.Columns[2].Name = "Instrument Description";
            dgTags.Columns[3].Name = "Service Description";
            dgTags.Columns[4].Name = "Line / Equipment Number";
            dgTags.Columns[5].Name = "Make";
            dgTags.Columns[6].Name = "Model Number";
            dgTags.Columns[7].Name = "Inst Range Min";
            dgTags.Columns[8].Name = "Inst Range Max";
            dgTags.Columns[9].Name = "Calibration Min";
            dgTags.Columns[10].Name = "Calibration Max";
            dgTags.Columns[11].Name = "Unit";
            dgTags.Columns[12].Name = "Alarm LL";
            dgTags.Columns[13].Name = "Alarm L";
            dgTags.Columns[14].Name = "Alarm H";
            dgTags.Columns[15].Name = "Alarm HH";
            dgTags.Columns[16].Name = "Setpoint";
            dgTags.Columns[17].Name = "P & ID Number";
            dgTags.Columns[18].Name = "Remarks";
            dgTags.Columns[19].Name = "Rev. Number";
            dgTags.Columns[20].Name = "P&&P Hookup Number";
            dgTags.Columns[21].Name = "Wiring Drawing Number";
            dgTags.Columns[22].Name = "Installation Drawing Number";
            dgTags.Columns[23].Name = "Functional Scheme Number";
            dgTags.Columns[24].Name = "Logic Diagram Number";


            if (dataSet != null && dataSet.Tables.Count > 0 && dataSet.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
                {
                    dgTags.Rows.Add(dataSet.Tables[0].Rows[i][0].ToString().Trim(), dataSet.Tables[0].Rows[i][1].ToString().Trim(),
                        dataSet.Tables[0].Rows[i][2].ToString().Trim(), dataSet.Tables[0].Rows[i][3].ToString().Trim(), dataSet.Tables[0].Rows[i][4].ToString().Trim(),
                        dataSet.Tables[0].Rows[i][5].ToString().Trim(), dataSet.Tables[0].Rows[i][6].ToString().Trim(), dataSet.Tables[0].Rows[i][7].ToString().Trim(),
                        dataSet.Tables[0].Rows[i][8].ToString().Trim(), dataSet.Tables[0].Rows[i][9].ToString().Trim(), dataSet.Tables[0].Rows[i][10].ToString().Trim(),
                        dataSet.Tables[0].Rows[i][11].ToString().Trim(), dataSet.Tables[0].Rows[i][12].ToString().Trim(), dataSet.Tables[0].Rows[i][13].ToString().Trim(),
                        dataSet.Tables[0].Rows[i][14].ToString().Trim(), dataSet.Tables[0].Rows[i][15].ToString().Trim(), dataSet.Tables[0].Rows[i][16].ToString().Trim(),
                        dataSet.Tables[0].Rows[i][17].ToString().Trim(), dataSet.Tables[0].Rows[i][18].ToString().Trim(), dataSet.Tables[0].Rows[i][19].ToString().Trim(),
                        dataSet.Tables[0].Rows[i][20].ToString().Trim(), dataSet.Tables[0].Rows[i][21].ToString().Trim(), dataSet.Tables[0].Rows[i][22].ToString().Trim(),
                        dataSet.Tables[0].Rows[i][23].ToString().Trim(), dataSet.Tables[0].Rows[i][24].ToString().Trim());
                }
            }
        }

        private void GenerateIOListData()
        {
            string strQueryTag = string.Empty;
            string strQueryLinrNr = string.Empty;
            sqlClient = new WatcherSqlClient(CConf.GetString("DBHost"), CConf.GetString("DBName"), CConf.GetBoolean("DBTrustedConnection"), CConf.GetString("DBLogin"), CConf.GetString("DBPassword"), CConf.GetString("DBConnectionString"));
            sqlClient.OpenConnection();
            if (cboPIDList.Text == "All")
            {
                strQueryTag = "SELECT * FROM INSTRUMENT_TAG_DETAILS";
            }
            else
            {
                strQueryTag = "SELECT * FROM INSTRUMENT_TAG_DETAILS WHERE PIDNumber='" + cboPIDList.Text + "'";
            }
            DataSet dataSet = sqlClient.Query(strQueryTag, "TAG");

            DataSet dataSetLineNr;
            if (cboPIDList.Text == "All")
            {
                dataSetLineNr = sqlClient.Query("SELECT * FROM LINE_SERVICE_DESCRIPTION", "LSD");
            }
            else
            {
                dataSetLineNr = sqlClient.Query("SELECT * FROM LINE_SERVICE_DESCRIPTION WHERE PID='" + cboPIDList.Text.Substring(0, cboPIDList.Text.Length - 4) + "'", "LSD");
            }

            cboLineNr.Items.Clear();
            cboLineNr.Text = "";
            btnExpToExcel.Enabled = true;

            dgTags.ColumnCount = 14;
            dgTags.Columns[0].Name = "Tag Number";  //Colum Sequence in DB 0,1,2,3,17,9,10,11,16,25,26,27,28,19
            dgTags.Columns[1].Name = "Loop Name";
            dgTags.Columns[2].Name = "Instrument Description";
            dgTags.Columns[3].Name = "Service Description";
            dgTags.Columns[4].Name = "P&ID Number";
            dgTags.Columns[5].Name = "Calibration Min";
            dgTags.Columns[6].Name = "Calibration Max";
            dgTags.Columns[7].Name = "Unit";
            dgTags.Columns[8].Name = "Set Point";
            dgTags.Columns[9].Name = "I/O Type";
            dgTags.Columns[10].Name = "Signal";
            dgTags.Columns[11].Name = "System";
            dgTags.Columns[12].Name = "Remarks";
            dgTags.Columns[13].Name = "Rev. Number";

            if (dataSet != null && dataSet.Tables.Count > 0 && dataSet.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
                {
                    dgTags.Rows.Add(dataSet.Tables[0].Rows[i][0].ToString().Trim(), dataSet.Tables[0].Rows[i][1].ToString().Trim(),
                        dataSet.Tables[0].Rows[i][2].ToString().Trim(), dataSet.Tables[0].Rows[i][3].ToString().Trim(), dataSet.Tables[0].Rows[i][17].ToString().Trim(),
                        dataSet.Tables[0].Rows[i][9].ToString().Trim(), dataSet.Tables[0].Rows[i][10].ToString().Trim(), dataSet.Tables[0].Rows[i][11].ToString().Trim(),
                        dataSet.Tables[0].Rows[i][16].ToString().Trim(), dataSet.Tables[0].Rows[i][25].ToString().Trim(), dataSet.Tables[0].Rows[i][26].ToString().Trim(),
                        dataSet.Tables[0].Rows[i][27].ToString().Trim(), dataSet.Tables[0].Rows[i][28].ToString().Trim(), dataSet.Tables[0].Rows[i][29].ToString().Trim());
                }

                if (dataSetLineNr != null && dataSetLineNr.Tables.Count > 0 && dataSetLineNr.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < dataSetLineNr.Tables[0].Rows.Count; i++)
                    {
                        hashLineNr.Add(new KeyValuePair<string, string>(dataSetLineNr.Tables[0].Rows[i][1].ToString(), dataSetLineNr.Tables[0].Rows[i][2].ToString()));
                        cboLineNr.Items.Add(dataSetLineNr.Tables[0].Rows[i][1].ToString());
                    }
                }
            }
        }

        private void GenerateJBSchtData()
        {
            string strQueryTag = string.Empty;
            string strQueryLinrNr = string.Empty;
            sqlClient = new WatcherSqlClient(CConf.GetString("DBHost"), CConf.GetString("DBName"), CConf.GetBoolean("DBTrustedConnection"), CConf.GetString("DBLogin"), CConf.GetString("DBPassword"), CConf.GetString("DBConnectionString"));
            sqlClient.OpenConnection();
            if (cboPIDList.Text == "All")
            {
                strQueryTag = "SELECT * FROM JB_LAYOUT_DETAILS";
            }
            else
            {
                strQueryTag = "SELECT * FROM JB_LAYOUT_DETAILS WHERE JBLayoutNumber='" + cboPIDList.Text + "'";
            }
            DataSet dataSet = sqlClient.Query(strQueryTag, "JBS");

            //DataSet dataSetLineNr;
            //if (cboPIDList.Text == "All")
            //{
            //    dataSetLineNr = sqlClient.Query("SELECT * FROM LINE_SERVICE_DESCRIPTION", "LSD");
            //}
            //else
            //{
            //    dataSetLineNr = sqlClient.Query("SELECT * FROM LINE_SERVICE_DESCRIPTION WHERE PID='" + cboPIDList.Text.Substring(0, cboPIDList.Text.Length - 4) + "'", "LSD");
            //}

            cboLineNr.Items.Clear();
            cboLineNr.Text = "";
            btnExpToExcel.Enabled = true;

            dgTags.ColumnCount = 3;
            dgTags.Columns[0].Name = "ID";  //Colum Sequence in DB 0,1,2,3,17,9,10,11,16,25,26,27,28,19
            dgTags.Columns[1].Name = "JB Detail";
            dgTags.Columns[2].Name = "JB Layout Detail";

            if (dataSet != null && dataSet.Tables.Count > 0 && dataSet.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
                {
                    dgTags.Rows.Add(dataSet.Tables[0].Rows[i][0].ToString().Trim(), dataSet.Tables[0].Rows[i][1].ToString().Trim(),
                        dataSet.Tables[0].Rows[i][2].ToString().Trim());
                }

                //if (dataSetLineNr != null && dataSetLineNr.Tables.Count > 0 && dataSetLineNr.Tables[0].Rows.Count > 0)
                //{
                //    for (int i = 0; i < dataSetLineNr.Tables[0].Rows.Count; i++)
                //    {
                //        hashLineNr.Add(new KeyValuePair<string, string>(dataSetLineNr.Tables[0].Rows[i][1].ToString(), dataSetLineNr.Tables[0].Rows[i][2].ToString()));
                //        cboLineNr.Items.Add(dataSetLineNr.Tables[0].Rows[i][1].ToString());
                //    }
                //}
            }
        }

        private void FillPID()
        {
            cboPIDList.Items.Clear();
            cboPIDList.Items.Add("All");
            sqlClient = new WatcherSqlClient(CConf.GetString("DBHost"), CConf.GetString("DBName"), CConf.GetBoolean("DBTrustedConnection"), CConf.GetString("DBLogin"), CConf.GetString("DBPassword"), CConf.GetString("DBConnectionString"));
            sqlClient.OpenConnection();
            DataSet dataSetPID = sqlClient.Query("Select distinct(FILE_NAME) FROM TAG", "TAG");
            if (dataSetPID != null && dataSetPID.Tables.Count > 0 && dataSetPID.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < dataSetPID.Tables[0].Rows.Count; i++)
                {
                    cboPIDList.Items.Add(dataSetPID.Tables[0].Rows[i][0].ToString().Substring(0, dataSetPID.Tables[0].Rows[i][0].ToString().IndexOf(".")));
                }
            }
            cboPIDList.SelectedIndex = 0;
            TreeNode parentNode = null;
            parentNode = tviewList.Nodes.Add("PID");
            PopulateTreeView(1, parentNode);
        }

        private void PopulateTreeView(int parentId, TreeNode parentNode)
        {
            sqlClient = new WatcherSqlClient(CConf.GetString("DBHost"), CConf.GetString("DBName"), CConf.GetBoolean("DBTrustedConnection"), CConf.GetString("DBLogin"), CConf.GetString("DBPassword"), CConf.GetString("DBConnectionString"));
            sqlClient.OpenConnection();
            DataSet dataSetPID = sqlClient.Query("Select distinct(FILE_NAME) FROM TAG", "TAG");
            TreeNode childNode;
            if (dataSetPID != null && dataSetPID.Tables.Count > 0 && dataSetPID.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < dataSetPID.Tables[0].Rows.Count; i++)
                {
                    if (parentNode == null)
                        childNode = tviewList.Nodes.Add(dataSetPID.Tables[0].Rows[i][0].ToString().Substring(0, dataSetPID.Tables[0].Rows[i][0].ToString().IndexOf(".")));
                    else
                        childNode = parentNode.Nodes.Add(dataSetPID.Tables[0].Rows[i][0].ToString().Substring(0, dataSetPID.Tables[0].Rows[i][0].ToString().IndexOf(".")));
                    //PopulateTreeView(Convert.ToInt32(dr["MNUSUBMENU"].ToString()), childNode);

                    //cboPIDList.Items.Add(dataSetPID.Tables[0].Rows[i][0].ToString().Substring(0, dataSetPID.Tables[0].Rows[i][0].ToString().IndexOf(".")));
                }
            }


            //foreach (DataRow dr in dtchildc.Rows)
            //{
            //    if (parentNode == null)
            //        childNode = treeView1.Nodes.Add(dr["FRM_NAME"].ToString());
            //    else
            //        childNode = parentNode.Nodes.Add(dr["FRM_NAME"].ToString());
            //    PopulateTreeView(Convert.ToInt32(dr["MNUSUBMENU"].ToString()), childNode);
            //}
        }

        private void frmVUData_Load(object sender, EventArgs e)
        {
            switch(Globals.VUForm)
            {
                case "IID":
                    gbInstIndex.Text = "View && Update Instrument Index Details";
                    cboExtractList.Text = "Instrument Index";
                    break;
                case "IOL":
                    gbInstIndex.Text = "View && Update I/O List Details";
                    cboExtractList.Text = "I/O List";
                    break;
                case "JBS":
                    gbInstIndex.Text = "View && Update JB Schedule Details";
                    cboExtractList.Text = "JB Schedule List";
                    break;
                case "IIDR":
                    gbInstIndex.Text = "Instrument Index Details";
                    cboExtractList.Text = "Instrument Index";
                    break;
                case "IOLR":
                    gbInstIndex.Text = "I/O List Details";
                    cboExtractList.Text = "I/O List";
                    break;
                case "JBSR":
                    gbInstIndex.Text = "JB Schedule Details";
                    cboExtractList.Text = "JB Schedule List";
                    break;
            }

            FillPID();
            if (gbInstIndex.Text.Contains("Update"))
                btnExpToExcel.Visible = false;
        }

        bool executeSQL(WatcherSqlClient sqlClient, string strSQL)
        {
            if (sqlClient == null)
                return false;

            sqlClient.Query(strSQL, sqlTransanction);
            return (sqlClient.ErrorMessage == null);
        }

        private void btnCloseInstIdx_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void cboLineNr_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgTags[dgTags.CurrentCell.ColumnIndex,
                    dgTags.CurrentRow.Index].Value = cboLineNr.Text.Trim();
                dgTags[dgTags.CurrentCell.ColumnIndex - 1,
                    dgTags.CurrentRow.Index].Value = cboLineNr.ValueMember.Trim();

                string key = cboLineNr.Text;
                List<string> values = (from hashLineNr in hashLineNr where hashLineNr.Key == key select hashLineNr.Value).ToList();
                dgTags[dgTags.CurrentCell.ColumnIndex - 1, dgTags.CurrentRow.Index].Value = values[0].ToString().Trim();
                SendKeys.Send("{TAB}");
            }
            catch
            {

            }
        }

        private void cboMake_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgTags[dgTags.CurrentCell.ColumnIndex,
                dgTags.CurrentRow.Index].Value = cboMake.Text.Trim();
                //dgTags[dgTags.CurrentCell.ColumnIndex - 1,
                //    dgTags.CurrentRow.Index].Value = cboLineNr.ValueMember;

                string key = cboMake.Text;
                List<string> values = (from hashMakeDetails in hashMakeDetails where hashMakeDetails.Key == key.Trim() select hashMakeDetails.Value).ToList();
                dgTags[dgTags.CurrentCell.ColumnIndex + 1, dgTags.CurrentRow.Index].Value = values[0].ToString().Trim();
                SendKeys.Send("{TAB}");
            }
            catch
            {

            }
        }

        private void GetMakeDetails(string InstrumentType)
        {
            cboMake.Items.Clear();
            cboMake.Text = "";
            DataSet dataSetMakeList = sqlClient.Query("SELECT Make,DefaultModelNr FROM VENDOR_LIST WHERE InstrumentType='" + InstrumentType + "'", "LSD");
            if (dataSetMakeList != null && dataSetMakeList.Tables.Count > 0 && dataSetMakeList.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < dataSetMakeList.Tables[0].Rows.Count; i++)
                {
                    hashMakeDetails.Add(new KeyValuePair<string, string>(dataSetMakeList.Tables[0].Rows[i][0].ToString().Trim(), dataSetMakeList.Tables[0].Rows[i][1].ToString().Trim()));
                    cboMake.Items.Add(dataSetMakeList.Tables[0].Rows[i][0].ToString());
                }
            }
        }

        private void GetLineNrDetails(string PID)
        {
            cboLineNr.Items.Clear();
            cboLineNr.Text = "";

            DataSet dataSetLineNr = sqlClient.Query("SELECT * FROM LINE_SERVICE_DESCRIPTION WHERE PID='" + PID + "'", "LSD");

            if (dataSetLineNr != null && dataSetLineNr.Tables.Count > 0 && dataSetLineNr.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < dataSetLineNr.Tables[0].Rows.Count; i++)
                {
                    hashLineNr.Add(new KeyValuePair<string, string>(dataSetLineNr.Tables[0].Rows[i][1].ToString(), dataSetLineNr.Tables[0].Rows[i][2].ToString()));
                    cboLineNr.Items.Add(dataSetLineNr.Tables[0].Rows[i][1].ToString());
                }
            }
        }

        private void dgTags_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ActiveControl.Name == "dgTags")
            {
                // SHOW THE COMBOBOX WHEN FOCUS IS ON A CELL CORRESPONDING TO THE "QUALIFICATION" COLUMN.
                if (dgTags.Columns
                    [dgTags.CurrentCell.ColumnIndex].Name == "Line / Equipment Number")
                {
                    cboMake.Visible = false;
                    GetLineNrDetails(dgTags[17, dgTags.CurrentRow.Index].Value.ToString());

                    dgTags.CurrentCell =
                        dgTags.Rows[dgTags.CurrentRow.Index]
                            .Cells[dgTags.CurrentCell.ColumnIndex];

                    // SHOW COMBOBOX.
                    Show_Combobox(dgTags.CurrentRow.Index,
                        dgTags.CurrentCell.ColumnIndex);

                    SendKeys.Send("{F4}");      // DROP DOWN THE LIST.
                }
                else if (dgTags.Columns
                    [dgTags.CurrentCell.ColumnIndex].Name == "Make")
                {
                    cboLineNr.Visible = false;
                    GetMakeDetails(dgTags[2, dgTags.CurrentRow.Index].Value.ToString());

                    dgTags.CurrentCell =
                        dgTags.Rows[dgTags.CurrentRow.Index]
                            .Cells[dgTags.CurrentCell.ColumnIndex];

                    // SHOW COMBOBOX.
                    Show_MakeCombobox(dgTags.CurrentRow.Index,
                        dgTags.CurrentCell.ColumnIndex);


                    SendKeys.Send("{F4}");      // DROP DOWN THE LIST.
                }
                else
                {
                    cboLineNr.Visible = false;
                    cboMake.Visible = false;
                }
            }
            else
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void Show_Combobox(int iRowIndex, int iColumnIndex)
        {
            // DESCRIPTION: SHOW THE COMBO BOX IN THE SELECTED CELL OF THE GRID.
            // PARAMETERS: iRowIndex - THE ROW ID OF THE GRID.
            //             iColumnIndex - THE COLUMN ID OF THE GRID.

            int x = 0;
            int y = 0;
            int Width = 0;
            int height = 0;

            // GET THE ACTIVE CELL'S DIMENTIONS TO BIND THE COMBOBOX WITH IT.
            Rectangle rect = default(Rectangle);
            rect = dgTags.GetCellDisplayRectangle(iColumnIndex, iRowIndex, false);
            x = rect.X + dgTags.Left;
            y = rect.Y + dgTags.Top;

            Width = rect.Width;
            height = rect.Height;

            cboLineNr.SetBounds(x, y, Width, height);
            cboLineNr.Visible = true;
            cboLineNr.Focus();
        }

        private void Show_MakeCombobox(int iRowIndex, int iColumnIndex)
        {
            // DESCRIPTION: SHOW THE COMBO BOX IN THE SELECTED CELL OF THE GRID.
            // PARAMETERS: iRowIndex - THE ROW ID OF THE GRID.
            //             iColumnIndex - THE COLUMN ID OF THE GRID.

            int x = 0;
            int y = 0;
            int Width = 0;
            int height = 0;

            // GET THE ACTIVE CELL'S DIMENTIONS TO BIND THE COMBOBOX WITH IT.
            Rectangle rect = default(Rectangle);
            rect = dgTags.GetCellDisplayRectangle(iColumnIndex, iRowIndex, false);
            x = rect.X + dgTags.Left;
            y = rect.Y + dgTags.Top;

            Width = rect.Width;
            height = rect.Height;

            cboMake.SetBounds(x, y, Width, height);
            cboMake.Visible = true;
            cboMake.Focus();
        }

        protected override bool ProcessCmdKey(ref System.Windows.Forms.Message msg, System.Windows.Forms.Keys keyData)
        {
            if (keyData == Keys.Enter || keyData == Keys.Tab)
            {
                // ON ENTER KEY, GO TO THE NEXT CELL. 
                // WHEN THE CURSOR REACHES THE LAST COLUMN, CARRY IT ON TO THE NEXT ROW.

                if (ActiveControl.Name == "dgTags")
                {
                    // SHOW THE COMBOBOX WHEN FOCUS IS ON A CELL CORRESPONDING TO THE "QUALIFICATION" COLUMN.
                    if (dgTags.Columns
                        [dgTags.CurrentCell.ColumnIndex].Name == "Service Description")
                    {
                        dgTags.CurrentCell =
                            dgTags.Rows[dgTags.CurrentRow.Index]
                                .Cells[dgTags.CurrentCell.ColumnIndex + 1];

                        // SHOW COMBOBOX.
                        Show_Combobox(dgTags.CurrentRow.Index,
                            dgTags.CurrentCell.ColumnIndex);

                        SendKeys.Send("{F4}");      // DROP DOWN THE LIST.
                        return true;
                    }
                    else if (dgTags.Columns
                        [dgTags.CurrentCell.ColumnIndex].Name == "Line / Equipment Number")
                    {
                        GetMakeDetails(dgTags[2, dgTags.CurrentRow.Index].Value.ToString());

                        dgTags.CurrentCell =
                            dgTags.Rows[dgTags.CurrentRow.Index]
                                .Cells[dgTags.CurrentCell.ColumnIndex + 1];

                        // SHOW COMBOBOX.
                        Show_MakeCombobox(dgTags.CurrentRow.Index,
                            dgTags.CurrentCell.ColumnIndex);


                        SendKeys.Send("{F4}");      // DROP DOWN THE LIST.
                        return true;
                    }
                    else
                    {
                        // CHECK IF ITS THE LAST COLUMN.
                        if (dgTags.CurrentCell.ColumnIndex ==
                            dgTags.ColumnCount - 1)
                        {
                            // GO TO THE FIRST COLUMN, NEXT ROW.
                            dgTags.CurrentCell =
                                dgTags.Rows[dgTags.CurrentCell.RowIndex + 1]
                                    .Cells[0];
                        }
                        else
                        {
                            // NEXT COLUMN.
                            dgTags.CurrentCell =
                                dgTags.Rows[dgTags.CurrentRow.Index]
                                    .Cells[dgTags.CurrentCell.ColumnIndex + 1];
                        }
                        return true;
                    }
                }
                else if (ActiveControl.Name == "cboLineNr")
                {
                    // HIDE THE COMBOBOX AND ASSIGN COMBO'S VALUE TO THE CELL.
                    cboLineNr.Visible = false;

                    dgTags.Focus();

                    // ONCE THE COMBO IS SET AS INVISIBLE, SET FOCUS BACK TO THE GRID. (IMPORTANT)
                    dgTags[dgTags.CurrentCell.ColumnIndex,
                    dgTags.CurrentRow.Index].Value = cboLineNr.Text;

                    dgTags.CurrentCell =
                        dgTags.Rows[dgTags.CurrentRow.Index]
                            .Cells[dgTags.CurrentCell.ColumnIndex + 1];
                }
                else if (ActiveControl.Name == "cboMake")
                {
                    // HIDE THE COMBOBOX AND ASSIGN COMBO'S VALUE TO THE CELL.
                    cboMake.Visible = false;

                    dgTags.Focus();

                    // ONCE THE COMBO IS SET AS INVISIBLE, SET FOCUS BACK TO THE GRID. (IMPORTANT)
                    dgTags[dgTags.CurrentCell.ColumnIndex,
                    dgTags.CurrentRow.Index].Value = cboMake.Text;

                    dgTags.CurrentCell =
                        dgTags.Rows[dgTags.CurrentRow.Index]
                            .Cells[dgTags.CurrentCell.ColumnIndex + 1];
                }
                else
                {
                    SendKeys.Send("{TAB}");
                }
                return true;
            }
            else if (keyData == Keys.Escape)            // PRESS ESCAPE TO HIDE THE COMBOBOX.
            {
                if (ActiveControl.Name == "cboLineNr")
                {
                    cboLineNr.Text = "";
                    cboLineNr.Visible = false;

                    dgTags.CurrentCell =
                        dgTags.Rows[dgTags.CurrentCell.RowIndex]
                            .Cells[dgTags.CurrentCell.ColumnIndex];

                    dgTags.Focus();
                }
                if (ActiveControl.Name == "cboMake")
                {
                    cboMake.Text = "";
                    cboMake.Visible = false;

                    dgTags.CurrentCell =
                        dgTags.Rows[dgTags.CurrentCell.RowIndex]
                            .Cells[dgTags.CurrentCell.ColumnIndex];

                    dgTags.Focus();
                }
                return true;
            }
            else
            {
                return base.ProcessCmdKey(ref msg, keyData);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmILDGenMain frmMain = new frmILDGenMain();
            if (cboExtractList.Text == "Instrument Index")
            {
                UpdateInstrumentIndex();
                frmMain.UpdateStatusBarText("Instrument Index Data Updated Successfully.");
                //frmMain.StatStripLbl1.Text = "Instrument Index Data Updated Successfully.";
            }
            else if (cboExtractList.Text == "I/O List")
            {
                UpdateIOList();
                frmMain.StatStripLbl1.Text = "I/O List Data Updated Successfully.";
            }
            frmMain.Refresh();
        }


        private void UpdateInstrumentIndex()
        {
            try
            {
                int rNum = -1;
                foreach (DataGridViewCell cell in changedCells)
                {
                    if (rNum != cell.RowIndex)
                    {
                        rNum = cell.RowIndex;
                        //dgTags.Rows[rNum].Cells[19].Value = Convert.ToInt16(dgTags.Rows[rNum].Cells[19].Value) + 1;

                        string strSQL = string.Empty;
                        strSQL = "UPDATE INSTRUMENT_TAG_DETAILS SET LoopName='" + dgTags.Rows[rNum].Cells[1].Value
                            + "',InstrumentDescription='" + dgTags.Rows[rNum].Cells[2].Value
                            + "',ServiceDescription='" + dgTags.Rows[rNum].Cells[3].Value
                            + "',LineEquipmentNumber='" + dgTags.Rows[rNum].Cells[4].Value.ToString().Replace("'", "''")
                            + "',Make='" + dgTags.Rows[rNum].Cells[5].Value
                            + "',ModelNumber='" + dgTags.Rows[rNum].Cells[6].Value
                            + "',InstRangeMin='" + dgTags.Rows[rNum].Cells[7].Value
                            + "',InstRangeMax='" + dgTags.Rows[rNum].Cells[8].Value
                            + "',CalibrationMin='" + dgTags.Rows[rNum].Cells[9].Value
                            + "',CalibrationMax='" + dgTags.Rows[rNum].Cells[10].Value
                            + "',Unit='" + dgTags.Rows[rNum].Cells[11].Value
                            + "',AlarmLL='" + dgTags.Rows[rNum].Cells[12].Value
                            + "',AlarmL='" + dgTags.Rows[rNum].Cells[13].Value
                            + "',AlarmH='" + dgTags.Rows[rNum].Cells[14].Value
                            + "',AlarmHH='" + dgTags.Rows[rNum].Cells[15].Value
                            + "',Setpoint='" + dgTags.Rows[rNum].Cells[16].Value
                            + "',PIDNumber='" + dgTags.Rows[rNum].Cells[17].Value
                            + "',IndexRemarks='" + dgTags.Rows[rNum].Cells[18].Value
                            + "',IIRevNumber='" + dgTags.Rows[rNum].Cells[19].Value
                            + "',PPHookupNumber='" + dgTags.Rows[rNum].Cells[20].Value
                            + "',WiringDrawingNumber='" + dgTags.Rows[rNum].Cells[21].Value
                            + "',InstallationDrawingNumber='" + dgTags.Rows[rNum].Cells[22].Value
                            + "',FunctionalSchemeNumber='" + dgTags.Rows[rNum].Cells[23].Value
                            + "',LogicDiagramNumber='" + dgTags.Rows[rNum].Cells[24].Value
                            + "',IIRowModified='Yes' WHERE TagNumber ='" + dgTags.Rows[rNum].Cells[0].Value + "'";
                        executeSQL(sqlClient, strSQL);
                    }
                }
            }
            catch
            {

            }

        }

        private void UpdateIOList()
        {
            try
            {
                int rNum = -1;
                foreach (DataGridViewCell cell in changedCells)
                {
                    if (rNum != cell.RowIndex)
                    {
                        rNum = cell.RowIndex;
                        string strSQL = string.Empty;
                        strSQL = "UPDATE INSTRUMENT_TAG_DETAILS SET LoopName='" + dgTags.Rows[rNum].Cells[1].Value
                            + "',InstrumentDescription='" + dgTags.Rows[rNum].Cells[2].Value
                            + "',ServiceDescription='" + dgTags.Rows[rNum].Cells[3].Value
                            + "',PIDNumber='" + dgTags.Rows[rNum].Cells[4].Value
                            + "',CalibrationMin='" + dgTags.Rows[rNum].Cells[5].Value
                            + "',CalibrationMax='" + dgTags.Rows[rNum].Cells[6].Value
                            + "',Unit='" + dgTags.Rows[rNum].Cells[7].Value
                            + "',Setpoint='" + dgTags.Rows[rNum].Cells[8].Value
                            + "',IOType='" + dgTags.Rows[rNum].Cells[9].Value
                            + "',Signal='" + dgTags.Rows[rNum].Cells[10].Value
                            + "',System='" + dgTags.Rows[rNum].Cells[11].Value
                            + "',IORemarks='" + dgTags.Rows[rNum].Cells[12].Value
                            + "',IORevNumber='" + dgTags.Rows[rNum].Cells[13].Value
                            + "',IORowModified='Yes' WHERE TagNumber ='" + dgTags.Rows[rNum].Cells[0].Value + "'";
                        executeSQL(sqlClient, strSQL);
                    }
                }
            }
            catch
            {

            }
        }

        private void btnExpToExcel_Click(object sender, EventArgs e)
        {
            frmWait frmShowWait = new frmWait();
            frmShowWait.StartPosition = FormStartPosition.CenterScreen;
            frmShowWait.Show();
            frmShowWait.Refresh();

            string datestr = DateTime.Now.ToShortDateString() + "_" + DateTime.Now.ToLongTimeString();
            datestr = datestr.Replace('/', '_');
            datestr = datestr.Replace(':', '_');
            string sourcePath = "";
            string destinationPath = "";


            if (cboExtractList.Text == "Instrument Index")
            {
                sourcePath = @"D:\C1_IIndex_Template_New.xls";
                destinationPath = @"D:\C1IDG_Reports\C1_IIndex_" + datestr + ".xls";
                UpdateInstrumentTagDetailsLog();
            }
            else if (cboExtractList.Text == "I/O List")
            {
                sourcePath = @"D:\C1_IIndex_Template_New.xls";
                destinationPath = @"D:\C1IDG_Reports\C1_IIndex_" + datestr + ".xls";
                UpdateInstrumentTagDetailsLog();
            }
            else if (cboExtractList.Text == "JB Schedule List")
            {
                sourcePath = @"C:\CEONE\C-IN\TestFiles\JB Schedule Template.xlsx";
                destinationPath = @"D:\C1IDG_Reports\CIN_JBS_" + datestr + ".xls";
            }



            frmILDGenMain frmMain = new frmILDGenMain();

            try
            {
                if (dgTags.Rows.Count > 0)
                {
                    Microsoft.Office.Interop.Excel.Application xlApp;
                    Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
                    Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
                    object misValue = System.Reflection.Missing.Value;

                    xlApp = new Microsoft.Office.Interop.Excel.Application();
                    xlWorkBook = xlApp.Workbooks.Add(sourcePath);

                    System.IO.Directory.CreateDirectory("D:\\C1IDG_Reports");

                    int currentSheet = 1;
                    int totSheets = dgTags.Rows.Count / 5;
                    for (int i = 1; i <= totSheets; i++)
                    {
                        xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(currentSheet);

                        xlWorkSheet.Copy(Type.Missing, xlWorkBook.Sheets[i]); // copy
                        if (cboExtractList.Text == "Instrument Index")
                        {
                            xlWorkBook.Sheets[i + 1].Name = "Instrument Index " + i.ToString();   //rename
                        }
                        else if (cboExtractList.Text == "I/O List")
                        {
                            xlWorkBook.Sheets[i + 1].Name = "I/O List " + i.ToString();
                        }
                        else if (cboExtractList.Text == "JB Schedule List")
                        {
                            xlWorkBook.Sheets[i + 1].Name = "JBS List " + i.ToString();
                        }
                    }

                    int rowNo = 0;
                    int sCounter = 5;
                    for (int sNo = 1; sNo <= totSheets; sNo++)
                    {
                        int RowMax = rowNo + sCounter;
                        xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(sNo);
                        for (int i = 1; i < dgTags.Columns.Count + 1; i++)
                        {
                            xlWorkSheet.Cells[1, i] = dgTags.Columns[i - 1].HeaderText;
                        }
                        for (int i = 0; i < sCounter; i++)
                        {
                            for (int j = 0; j < dgTags.Columns.Count - 1; j++)
                            {
                                xlWorkSheet.Cells[i + 2, j + 1] = dgTags.Rows[rowNo].Cells[j].Value.ToString();
                            }
                            rowNo++;
                            if (rowNo == dgTags.Rows.Count - 1) break;
                        }
                    }

                    if (System.IO.File.Exists(destinationPath))
                    {
                        System.IO.File.Create(destinationPath);
                    }

                    xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
                    xlWorkBook.SaveAs(destinationPath, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                    xlWorkBook.Close(true, misValue, misValue);
                    xlApp.Quit();
                    frmMain.StatStripLbl1.Text = "Writing Data to Excel Completed.";
                }
                else
                {
                    frmMain.StatStripLbl1.Text = "Data not available for export.";
                }
                frmShowWait.Hide();
            }
            catch
            {
                frmShowWait.Hide();
                frmMain.StatStripLbl1.Text = "Error occured in writing to the file. Please check the file on D drive.";
            }
        }

        private void UpdateInstrumentTagDetailsLog()
        {
            try
            {
                string strSQL = string.Empty;
                //First insert modified rows into Log table with updated rev number and timestamp
                if (cboExtractList.Text == "Instrument Index")
                {
                    strSQL = "INSERT INTO INSTRUMENT_TAG_DETAILS_LOG (TagNumber,LoopName,InstrumentDescription,ServiceDescription,LineEquipmentNumber,"
                    + "Make,ModelNumber,InstRangeMin,InstRangeMax,CalibrationMin,CalibrationMax,Unit,AlarmLL,AlarmL,AlarmH,AlarmHH,Setpoint,PIDNumber,"
                    + "IndexRemarks,IIRevNumber,PPHookupNumber,WiringDrawingNumber,InstallationDrawingNumber,FunctionalSchemeNumber,LogicDiagramNumber,IIRowModified,IIRevTimeStamp,UserID,ProjectID) "
                    + "SELECT TagNumber, LoopName, InstrumentDescription, ServiceDescription, LineEquipmentNumber, "
                    + "Make,ModelNumber,InstRangeMin,InstRangeMax,CalibrationMin,CalibrationMax,Unit,AlarmLL,AlarmL,AlarmH,AlarmHH,Setpoint,PIDNumber,"
                    + "IndexRemarks,[IIRevNumber] + 1 as IIRevNumber,PPHookupNumber,WiringDrawingNumber,InstallationDrawingNumber,FunctionalSchemeNumber,LogicDiagramNumber,IIRowModified,'" + DateTime.Now.ToShortDateString() + "' as IIRevTimeStamp,UserID,ProjectID "
                    + "FROM INSTRUMENT_TAG_DETAILS WHERE IIRowModified = 'Yes'";
                    executeSQL(sqlClient, strSQL);


                    strSQL = "UPDATE INSTRUMENT_TAG_DETAILS SET IIRevNumber=ISNULL(IIRevNumber, 0) + 1, IIRowModified='No' WHERE IIRowModified='Yes'";
                    executeSQL(sqlClient, strSQL);
                }
                else
                {
                    strSQL = "INSERT INTO INSTRUMENT_TAG_DETAILS_LOG (TagNumber,LoopName,InstrumentDescription,ServiceDescription,LineEquipmentNumber,"
                    + "Make,ModelNumber,InstRangeMin,InstRangeMax,CalibrationMin,CalibrationMax,Unit,AlarmLL,AlarmL,AlarmH,AlarmHH,Setpoint,PIDNumber,"
                    + "IndexRemarks,IIRevNumber,PPHookupNumber,WiringDrawingNumber,InstallationDrawingNumber,FunctionalSchemeNumber,LogicDiagramNumber,IOType,Signal,System,IORemarks,IORevNumber,IORowModified,IORevTimeStamp,UserID,ProjectID) "
                    + "SELECT TagNumber, LoopName, InstrumentDescription, ServiceDescription, LineEquipmentNumber, "
                    + "Make,ModelNumber,InstRangeMin,InstRangeMax,CalibrationMin,CalibrationMax,Unit,AlarmLL,AlarmL,AlarmH,AlarmHH,Setpoint,PIDNumber,"
                    + "IndexRemarks,IIRevNumber,PPHookupNumber,WiringDrawingNumber,InstallationDrawingNumber,FunctionalSchemeNumber,LogicDiagramNumber,IOType,Signal,System,IORemarks,[IORevNumber] + 1 as IIRevNumber,IORowModified,'" + DateTime.Now.ToShortDateString() + "' as IIRevTimeStamp,UserID,ProjectID "
                    + "FROM INSTRUMENT_TAG_DETAILS WHERE IORowModified = 'Yes'";
                    executeSQL(sqlClient, strSQL);


                    strSQL = "UPDATE INSTRUMENT_TAG_DETAILS SET IORevNumber=ISNULL(IORevNumber, 0) + 1, IORowModified='No' WHERE IORowModified='Yes'";
                    executeSQL(sqlClient, strSQL);
                }
            }

            catch
            {

            }
        }

        private void dgTags_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (!changedCells.Contains(dgv[e.ColumnIndex, e.RowIndex]))
            {
                changedCells.Add(dgv[e.ColumnIndex, e.RowIndex]);
            }
        }

        private void CheckForChildren(TreeNode node)
        {

            // check whether each parent node has child nodes 
            if (node.Nodes.Count > 0)
            {

                // iterate through child nodes in the collection
                foreach (TreeNode node1 in node.Nodes)
                {
                    if (node1.IsSelected)
                    {
                        MessageBox.Show(node1.Text + "is selected CheckForChildren");
                    }

                    // Do recursive call
                    CheckForChildren(node1);
                }
            }
        }

        private void tviewList_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (e.Action != TreeViewAction.Unknown)
            {
                CheckAllChildNodes(e.Node, e.Node.Checked);
                //if (e.Node.Nodes.Count > 0)
                //{
                //    /* Calls the CheckAllChildNodes method, passing in the current 
                //    Checked value of the TreeNode whose checked state changed. */
                //    this.CheckAllChildNodes(e.Node, e.Node.Checked);
                //}
            }

            // Disable redrawing of treeView1 to prevent flickering 
            // while changes are made.
            tviewList.BeginUpdate();

            // Collapse all nodes of treeView1.
            tviewList.CollapseAll();

            // Add the checkForCheckedChildren event handler to the BeforeExpand event.
            tviewList.BeforeExpand += checkForCheckedChildren;

            // Expand all nodes of treeView1. Nodes without checked children are 
            // prevented from expanding by the checkForCheckedChildren event handler.
            tviewList.ExpandAll();

            // Remove the checkForCheckedChildren event handler from the BeforeExpand 
            // event so manual node expansion will work correctly.
            tviewList.BeforeExpand -= checkForCheckedChildren;

            // Enable redrawing of treeView1.
            tviewList.EndUpdate();
        }

        // Updates all child tree nodes recursively.
        private void CheckAllChildNodes(TreeNode treeNode, bool nodeChecked)
        {
            foreach (TreeNode node in treeNode.Nodes)
            {
                node.Checked = nodeChecked;
                if (node.Nodes.Count > 0)
                {
                    // If the current node has child nodes, call the CheckAllChildsNodes method recursively.
                    this.CheckAllChildNodes(node, nodeChecked);
                }
            }
            GetCheckedNodesText(tviewList.Nodes);
        }

        // Prevent expansion of a node that does not have any checked child nodes.
        private void CheckForCheckedChildrenHandler(object sender, TreeViewCancelEventArgs e)
        {
            if (!HasCheckedChildNodes(e.Node)) e.Cancel = true;
        }

        // Returns a value indicating whether the specified 
        // TreeNode has checked child nodes.
        private bool HasCheckedChildNodes(TreeNode node)
        {
            if (node.Nodes.Count == 0) return false;
            foreach (TreeNode childNode in node.Nodes)
            {
                if (childNode.Checked) return true;
                // Recursively check the children of the current child node.
                if (HasCheckedChildNodes(childNode)) return true;
            }
            return false;
        }

        public void GetCheckedNodesText(TreeNodeCollection nodes)
        {
            string PIDListQuery = null;
            bool bNodesSelected = false;
            foreach (System.Windows.Forms.TreeNode aNode in nodes)
            {
                //edit
                if (aNode.Checked)
                {
                    if (aNode.Text == "PID")
                    {
                        bNodesSelected = true;
                    }
                    else
                    {
                        //WHERE PIDNumber='5288-BUH-39-00-30-021' or PIDNumber='PID_5288-BUH-835-30-21'
                        if (PIDListQuery == null)
                            PIDListQuery = " PIDNumber='" + aNode.Text + "'";
                        else
                            PIDListQuery = PIDListQuery + " or PIDNumber='" + aNode.Text + "'";

                        bNodesSelected = true;
                    }
                }


                //MessageBox.Show(aNode.Text);

                if (aNode.Nodes.Count != 0)
                    GetCheckedNodesText(aNode.Nodes);
            }

            if (bNodesSelected == true && PIDListQuery != null)
            {
                dgTags.Rows.Clear();
                dgTags.Columns.Clear();
                cboLineNr.Visible = false;
                cboMake.Visible = false;
                cboLineNr.Items.Clear();
                btnExpToExcel.Enabled = false;
                changedCells.Clear();
                GenerateTViewInstIndexData(PIDListQuery);
                bNodesSelected = false;
            }
            else if (bNodesSelected == false)
            {
                dgTags.Rows.Clear();
                dgTags.Columns.Clear();
                cboLineNr.Visible = false;
                cboMake.Visible = false;
                cboLineNr.Items.Clear();
                btnExpToExcel.Enabled = false;
                changedCells.Clear();
            }
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
