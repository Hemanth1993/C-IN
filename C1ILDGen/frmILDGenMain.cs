using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Collections;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.Interop;
using System.Diagnostics;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.IO;
using System.Threading;
using System.ComponentModel;

namespace C1ILDGen
{
    public partial class frmILDGenMain : Form
    {
        frmWait WaitForm;
        AcadApplication acadApp = null;
        string appName = "AutoCAD.Application.";
        string version = string.Empty;
        string dirPath = string.Empty;
        Hashtable hsMatrixList = new Hashtable();
        List<string> listInsLegends = new List<string>();
        SqlTransaction sqlTransanction = null;
        WatcherSqlClient sqlClient = null;
        List<KeyValuePair<string, string>> hashLineNr = new List<KeyValuePair<string, string>>();
        List<KeyValuePair<string, string>> hashMakeDetails = new List<KeyValuePair<string, string>>();
        List<KeyValuePair<string, string>> hashPIDTagMapList = new List<KeyValuePair<string, string>>();
        Hashtable hashInstFilterList = new Hashtable();
        Hashtable hashPIDTagList = new Hashtable();
        string FileVerNum = string.Empty;
        int TagBlocks = 2;
        bool bReadMultiFiles = false;


        public frmILDGenMain()
        {
            InitializeComponent();
            gbReadPID.Location = new Point(0, 25);
            gbReadPID.Width = 1365;
            gbReadPID.Height = 659;
            CheckACadInstance();
        }

        private void btnProgID_Click(object sender, EventArgs e)
        {
            if (bgWorker.IsBusy != true)
            {
                // create a new instance of the alert form
                WaitForm = new frmWait();
                // event handler for the Cancel button in AlertForm
                WaitForm.Canceled += new EventHandler<EventArgs>(btnCancel_Click);
                WaitForm.Show();
                // Start the asynchronous operation.
                bgWorker.RunWorkerAsync();
            }

            btnProgID.Enabled = false;
            btnCloseInstance.Enabled = true;
            btnReadDWG.Enabled = true;

            //string ProgID = "";
            //Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Autodesk\AutoCAD");
            //StatStripLbl1.Text = "Launching Process..";
            //TagBlocks = Convert.ToInt16(CConf.GetString("Tag_Number_Block_Length"));

            //if (key != null)
            //{
            //    foreach (string keyname in key.GetSubKeyNames())
            //    {
            //        if (keyname.StartsWith("R"))
            //        {
            //            int index = keyname.IndexOf('.');
            //            string name = keyname.Substring(0, index);
            //            version = keyname.Substring(1, name.Length - 1);
            //            ProgID = (appName + keyname.Substring(1, name.Length - 1));

            //            try
            //            {
            //                //Check for instance and create if it is not running
            //                acadApp = (AcadApplication)Marshal.GetActiveObject(ProgID);
            //                StatStripLbl1.Text = "Process is already running.";
            //                btnReadDWG.Enabled = true;
            //                btnCloseInstance.Enabled = true;
            //            }
            //            catch
            //            {
            //                //////frmWait frmShowWait = new frmWait();
            //                //////frmShowWait.StartPosition = FormStartPosition.CenterScreen;
            //                //////frmShowWait.Show();
            //                //////frmShowWait.Refresh();
            //                try
            //                {

            //                    Cursor.Current = Cursors.WaitCursor;
            //                    Type acType = Type.GetTypeFromProgID(ProgID);
            //                    acadApp = (AcadApplication)Activator.CreateInstance(acType, true);
            //                    acadApp.Visible = false;
            //                    acadApp.Width = 1;
            //                    acadApp.Height = 1;
            //                    acadApp.Visible = false;
            //                    StatStripLbl1.Text = "Process Instance Created.";
            //                    btnProgID.Enabled = false;
            //                    btnCloseInstance.Enabled = true;
            //                    btnReadDWG.Enabled = true;

            //                    if (!CheckPIDExist(txtFileName.Text))
            //                    {
            //                        object axDbDocument = acadApp.GetInterfaceObject("ObjectDBX.AxDbDocument." + version);
            //                        if (axDbDocument == null)
            //                            WriteToLog("axDbDocument is null");

            //                        Autodesk.AutoCAD.Interop.Common.AxDbDocument sourceAxDb = axDbDocument as Autodesk.AutoCAD.Interop.Common.AxDbDocument;
            //                        if (sourceAxDb == null)
            //                            WriteToLog("sourceAxDb is null");

            //                        sourceAxDb.Open(txtFileName.Text);
            //                        GetPIDTagMapList();
            //                        StatStripLbl1.Text = "File Opened Successfully.";
            //                        readDWG(sourceAxDb.ModelSpace, txtFileName.Text, 1, 1);
            //                        StatStripLbl1.Text = "Data Read Successfully.";
            //                        sourceAxDb = null;
            //                    }
            //                    else
            //                    {
            //                        StatStripLbl1.Text = "Data already extracted from this file.";
            //                    }
            //                    //////frmShowWait.Hide();
            //                    btnCancel_Click(this, e);
            //                    Cursor.Current = Cursors.Default;
            //                }
            //                catch (System.Exception ex)
            //                {
            //                    WriteToLog(ex.Message);
            //                    //////frmShowWait.Hide();
            //                    btnCancel_Click(this, e);
            //                    Cursor.Current = Cursors.Default;
            //                }
            //            }
            //        }
            //    }
            //}
        }

        void LACAD()
        {
        }

        // This event handler cancels the backgroundworker, fired from Cancel button in AlertForm.
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (bgWorker.WorkerSupportsCancellation == true)
            {
                // Cancel the asynchronous operation.
                bgWorker.CancelAsync();
                // Close the AlertForm
                WaitForm.Close();
            }
        }


        //private void btnProgID_Click(object sender, EventArgs e)
        //{
        //    string ProgID = "";
        //    Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Autodesk\AutoCAD");
        //    StatStripLbl1.Text = "Launching Process..";
        //    TagBlocks = Convert.ToInt16(CConf.GetString("Tag_Number_Block_Length"));

        //    if (key != null)
        //    {
        //        foreach (string keyname in key.GetSubKeyNames())
        //        {
        //            if (keyname.StartsWith("R"))
        //            {
        //                int index = keyname.IndexOf('.');
        //                string name = keyname.Substring(0, index);
        //                version = keyname.Substring(1, name.Length - 1);
        //                ProgID = (appName + keyname.Substring(1, name.Length - 1));

        //                try
        //                {
        //                    //Check for instance and create if it is not running
        //                    acadApp = (AcadApplication)Marshal.GetActiveObject(ProgID);
        //                    StatStripLbl1.Text = "Process is already running.";
        //                    btnReadDWG.Enabled = true;
        //                    btnCloseInstance.Enabled = true;
        //                }
        //                catch
        //                {
        //                    frmWait frmShowWait = new frmWait();
        //                    frmShowWait.StartPosition = FormStartPosition.CenterScreen;
        //                    frmShowWait.Show();
        //                    frmShowWait.Refresh();
        //                    try
        //                    {

        //                        Cursor.Current = Cursors.WaitCursor;
        //                        Type acType = Type.GetTypeFromProgID(ProgID);
        //                        acadApp = (AcadApplication)Activator.CreateInstance(acType, true);
        //                        acadApp.Visible = false;
        //                        acadApp.Width = 1;
        //                        acadApp.Height = 1;
        //                        acadApp.Visible = false;
        //                        StatStripLbl1.Text = "Process Instance Created.";
        //                        btnProgID.Enabled = false;
        //                        btnCloseInstance.Enabled = true;
        //                        btnReadDWG.Enabled = true;

        //                        if (!CheckPIDExist(txtFileName.Text))
        //                        {
        //                            object axDbDocument = acadApp.GetInterfaceObject("ObjectDBX.AxDbDocument." + version);
        //                            if (axDbDocument == null)
        //                                WriteToLog("axDbDocument is null");

        //                            Autodesk.AutoCAD.Interop.Common.AxDbDocument sourceAxDb = axDbDocument as Autodesk.AutoCAD.Interop.Common.AxDbDocument;
        //                            if (sourceAxDb == null)
        //                                WriteToLog("sourceAxDb is null");

        //                            sourceAxDb.Open(txtFileName.Text);
        //                            GetPIDTagMapList();
        //                            StatStripLbl1.Text = "File Opened Successfully.";
        //                            readDWG(sourceAxDb.ModelSpace, txtFileName.Text, 1, 1);
        //                            StatStripLbl1.Text = "Data Read Successfully.";
        //                            sourceAxDb = null;
        //                        }
        //                        else
        //                        {
        //                            StatStripLbl1.Text = "Data already extracted from this file.";
        //                        }
        //                        frmShowWait.Hide();
        //                        Cursor.Current = Cursors.Default;
        //                    }
        //                    catch (System.Exception ex)
        //                    {
        //                        WriteToLog(ex.Message);
        //                        frmShowWait.Hide();
        //                        Cursor.Current = Cursors.Default;
        //                    }
        //                }
        //            }
        //        }
        //    }
        //}

        private bool CheckACadInstance()
        {
            string ProgID = "";
            Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Autodesk\AutoCAD");
            StatStripLbl1.Text = "Checking Process Instance.";

            if (key != null)
            {
                foreach (string keyname in key.GetSubKeyNames())
                {
                    if (keyname.StartsWith("R"))
                    {
                        int index = keyname.IndexOf('.');
                        string name = keyname.Substring(0, index);
                        version = keyname.Substring(1, name.Length - 1);
                        ProgID = (appName + keyname.Substring(1, name.Length - 1));

                        try
                        {
                            //Check for instance and create if it is not running
                            acadApp = (AcadApplication)Marshal.GetActiveObject(ProgID);
                            StatStripLbl1.Text = "Process is already running.";
                            btnProgID.Enabled = false;
                            btnReadDWG.Enabled = true;
                            btnCloseInstance.Enabled = true;
                            return true;
                        }
                        catch
                        {
                            return false;
                        }
                    }
                }
                return false;
            }
            else
            {
                StatStripLbl1.Text = "Ready";
                return false;
            }
        }

        private void WriteToLog(string Log)
        {
            txtLog.Text = txtLog.Text + Log + "\n";
        }

        void readDWG(Autodesk.AutoCAD.Interop.Common.AcadModelSpace modSpace, string fileName, int total, int current)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                Hashtable blocks = new Hashtable();
                List<Autodesk.AutoCAD.Interop.Common.AcadText> stringList = new List<Autodesk.AutoCAD.Interop.Common.AcadText>();
                //WriteToLog("stringList : " + stringList.ToString()); 

                GetInstFilterList();

                int totalBlkKeyCnt = 0;
                int totalBlkNoKeyCnt = 0;
                int totalTxtCnt = 0;
                string lineEquipNr = "";

                sqlClient = new WatcherSqlClient(CConf.GetString("DBHost"), CConf.GetString("DBName"), CConf.GetBoolean("DBTrustedConnection"), CConf.GetString("DBLogin"), CConf.GetString("DBPassword"), CConf.GetString("DBConnectionString"));
                sqlClient.OpenConnection();

                System.Threading.Thread.Sleep(10000);

                GetFileVerNumber(fileName);

                for (int nItem = 0; nItem < modSpace.Count; nItem++)
                {
                    //WriteToLog("modSpaceCount : " + nItem.ToString() + "/" + modSpace.Count.ToString());
                    Autodesk.AutoCAD.Interop.Common.AcadEntity acadEnt = modSpace.Item(nItem);
                    if (acadEnt != null && acadEnt is Autodesk.AutoCAD.Interop.Common.AcadBlockReference)
                    {
                        //WriteToLog("AcadBlockReference : " + nItem.ToString());
                        Autodesk.AutoCAD.Interop.Common.AcadBlockReference acadBR = (Autodesk.AutoCAD.Interop.Common.AcadBlockReference)acadEnt;
                        object[] acadAttributes = acadBR.GetAttributes();

                        //Check if there are attributes in the block and add it to the hash table
                        if (acadBR.HasAttributes && acadAttributes.LongLength > 0)
                        {
                            string blockName = acadBR.Name.ToUpper();
                            if (!blocks.ContainsKey(blockName))
                            {
                                List<Autodesk.AutoCAD.Interop.Common.AcadBlockReference> list = new List<Autodesk.AutoCAD.Interop.Common.AcadBlockReference>();
                                list.Add(acadBR);
                                blocks.Add(blockName, list);
                                totalBlkKeyCnt++;
                            }
                            else
                            {
                                List<Autodesk.AutoCAD.Interop.Common.AcadBlockReference> list = blocks[blockName] as List<Autodesk.AutoCAD.Interop.Common.AcadBlockReference>;
                                list.Add(acadBR);
                                blocks[blockName] = list;
                                totalBlkNoKeyCnt++;
                            }
                        }
                    }
                    else if (acadEnt != null && acadEnt is Autodesk.AutoCAD.Interop.Common.AcadText)
                    {
                        //WriteToLog("acadTeext : " + nItem.ToString());
                        Autodesk.AutoCAD.Interop.Common.AcadText acadTxt = (Autodesk.AutoCAD.Interop.Common.AcadText)acadEnt;
                        double[] d = acadTxt.TextAlignmentPoint;
                        d = acadTxt.InsertionPoint;
                        string t = acadTxt.TextString;
                        Autodesk.AutoCAD.Interop.Common.AcAlignment dd = acadTxt.Alignment;
                        stringList.Add(acadTxt);
                        totalTxtCnt++;
                    }
                }


                int nTagCount = 0;

                foreach (DictionaryEntry newEntry in blocks)
                {
                    List<Autodesk.AutoCAD.Interop.Common.AcadBlockReference> list = ((List<Autodesk.AutoCAD.Interop.Common.AcadBlockReference>)newEntry.Value);
                    for (int nBR = 0; nBR < list.Count; nBR++)
                    {
                        //WriteToLog("AcadBlkName: " + list[nBR].Name + ", BlkCount: " + nBR.ToString() + "/" + list.Count.ToString());
                        //if (list[nBR].Name.StartsWith("ANOT") || list[nBR].Name == "STST Logo" || list[nBR].Name.StartsWith("AMREV"))
                        //    continue;
                        //WriteToLog("1");

                        object[] acadAttributes = list[nBR].GetAttributes();

                        string sqlValue = "", tagName = "", tempTag = "";
                        Hashtable hashTag = new Hashtable();

                        for (long nAtt = 0; nAtt < acadAttributes.LongLength; nAtt++)
                        {
                            Autodesk.AutoCAD.Interop.Common.AcadAttributeReference attRef = (Autodesk.AutoCAD.Interop.Common.AcadAttributeReference)acadAttributes[nAtt];

                            if (attRef == null)
                                continue;
                            //WriteToLog("2");
                            //WriteToLog("Att#: " + (nAtt+1).ToString() + ", Tag: " + attRef.TagString + ", Text: " + attRef.TextString);

                            if (sqlValue.Length > 0)
                                sqlValue += ",";

                            if (attRef.TagString == "UNIT" || attRef.TagString == "CODE" || attRef.TagString == "SERIAL" || attRef.TagString == "CLASS" || attRef.TagString == "SIZE")
                            {
                                hashTag.Add(attRef.TagString, attRef.TextString);
                            }

                            if (attRef.TextString.Length > 0)
                            {
                                sqlValue += "'" + attRef.TextString.Replace("'", "''") + "'";

                                if (tagName.Length > 0)
                                    tagName += "-";
                            }
                            else
                            {
                                sqlValue += "null";
                                //sqlValue += "";
                                continue;
                            }

                            tagName += attRef.TextString;
                        }
                        if (hashTag.Count == 3)
                        {
                            tempTag = hashTag["UNIT"] + "-" + hashTag["CODE"] + "-" + hashTag["SERIAL"];
                            tagName = tempTag;
                        }
                        else if (hashTag.Count == 5)
                        {
                            tempTag = hashTag["SIZE"].ToString() + "-" + hashTag["CODE"] + "-" + hashTag["UNIT"] + "-" + hashTag["SERIAL"] + "-" + hashTag["CLASS"];
                            tagName = tempTag;
                        }
                        //WriteToLog("3");
                        //if(tagName != "") WriteToLog("BlockName: " + list[nBR].Name + ", BlkCount: " + (nBR+1).ToString() + ", Tag: " + tagName);

                        try
                        {
                            string[] moreTags = null;
                            string nullValue = "";
                            for (int i = (int)list[nBR].GetAttributes().LongLength; i < 25; i++)
                            {
                                nullValue += ",null";
                            }

                            string discipline = "OTH";
                            if (tagName.ToUpper().StartsWith("E-") || tagName.ToUpper().StartsWith("P-") ||
                                tagName.ToUpper().StartsWith("T-") || tagName.ToUpper().StartsWith("A-") ||
                                tagName.ToUpper().StartsWith("V-") || tagName.ToUpper().StartsWith("K-") ||
                                tagName.ToUpper().StartsWith("C-") || tagName.ToUpper().StartsWith("S-") || tagName.ToUpper().StartsWith("R-"))
                            {
                                discipline = "EQU";
                                int junk = tagName.IndexOf(" ");
                                if (junk > -1)
                                {
                                    tagName = tagName.Substring(0, junk);
                                }
                                junk = tagName.IndexOf('-', 5);
                                if (junk > -1)
                                {
                                    tagName = tagName.Substring(0, junk);
                                }
                            }
                            //else if (tagName.ToUpper().StartsWith("R-"))
                            //    discipline = "PIP";
                            else
                            {
                                tagName = tagName.Replace("%%U", "");
                                lineEquipNr = tagName;
                                //Find the substring before " start to get the tag
                                int sPos = tagName.IndexOf("''");
                                if (sPos > 0)
                                {
                                    tagName = tagName.Substring(0, sPos - 1);
                                    int sindex = tagName.LastIndexOf('-');
                                    tagName = tagName.Substring(0, sindex);
                                    lineEquipNr = lineEquipNr.Substring(sindex + 1);
                                    lineEquipNr = lineEquipNr.Replace("'", "''");
                                }
                                else
                                {
                                    lineEquipNr = "";
                                }

                                string[] sepList = tagName.Split('-');
                                if (sepList.Length > 2 && sepList.Length < 4)
                                {
                                    int nMoreTags = sepList[2].IndexOf('/');
                                    if (nMoreTags > -1)
                                    {
                                        moreTags = sepList[2].Split('/');
                                        discipline = "INS";
                                    }
                                    else if (Convert.ToInt32(sepList[2].Length) > 0)
                                        discipline = "INS";
                                }
                                else if (sepList.Length > 4 && sepList.Length < 6)
                                {
                                    if (sepList[0].IndexOf('"') > 0)
                                    {
                                        discipline = "PIP";
                                        if (sepList[1].Length == 2 || sepList[1].Length == 0)
                                            continue;
                                    }
                                    else if (sepList[0].IndexOf("''") > 0)
                                    {
                                        discipline = "PIP";
                                        if (sepList[1].Length == 2 || sepList[1].Length == 0)
                                            continue;
                                    }
                                }
                                //else if (!list[nBR].Name.StartsWith("ADNO"))
                                //    continue;
                            }
                            //WriteToLog("4");

                            tagName = tagName.Replace("'", "''");

                            //if (tagName.Length < 6)
                            //    continue;

                            double[] d = list[nBR].InsertionPoint;

                            string strSQL = "";

                            if (moreTags != null && moreTags.Length > 1)
                            {
                                string[] tempTagList = tagName.Split('-');
                                for (int nTag = 0; nTag < moreTags.Length; nTag++)
                                {
                                    tagName = tempTagList[0] + "-" + tempTagList[1] + "-" + moreTags[nTag];

                                    //if (discipline == "INS" && !isValidInsTag(tagName))
                                    //    continue;
                                    if (tempTagList.Length > TagBlocks)
                                    {
                                        int i = 0;
                                        if (TagBlocks >= 1) i = tagName.IndexOf("-", 1);
                                        if (TagBlocks >= 2) i = tagName.IndexOf("-", i + 1);
                                        if (TagBlocks >= 3) i = tagName.IndexOf("-", i + 1);
                                        if (TagBlocks >= 4) i = tagName.IndexOf("-", i + 1);
                                        tagName = tagName.Substring(0, i);
                                    }

                                    strSQL = "INSERT INTO TAG VALUES ('" + fileName + "','" + FileVerNum + "','" + list[nBR].Name.Replace("'", "''") + "','" + d[0] + "','" + d[1] + "','" + "BLK" + "','" + discipline + "','" + tagName + "'," + sqlValue + nullValue + ")";
                                    //strSQL = "INSERT INTO TAG VALUES1 ('" + list[nBR].Name.Replace("'", "''") + "','" + d[0] + "','" + d[1] + "','" + "BLK" + "','" + discipline + "','" + tagName + "'," + sqlValue + nullValue + ")";
                                    executeSQL(sqlClient, strSQL);

                                    WriteToLog("Tag Added : " + tagName);
                                    nTagCount++;
                                }
                            }
                            else
                            {
                                //if (discipline == "INS" && !isValidInsTag(tagName))
                                //    continue;
                                string[] tagBits = tagName.Split('-');
                                if (tagBits.Length > 1 && tagBits.Length < 5)
                                {
                                    string fName = System.IO.Path.GetFileName(fileName);

                                    if (tagBits.Length > TagBlocks)
                                    {
                                        int i=0;
                                        if (TagBlocks >= 1) i = tagName.IndexOf("-", 1);
                                        if (TagBlocks >= 2) i = tagName.IndexOf("-", i + 1);
                                        if (TagBlocks >= 3) i = tagName.IndexOf("-", i + 1);
                                        if (TagBlocks >= 4) i = tagName.IndexOf("-", i + 1);
                                        tagName = tagName.Substring(0, i);
                                    }

                                    //Check for PID - TAG Nr Mapping  -  hashPIDTagMapList
                                    tagName = PIDTagMap(tagName);

                                    strSQL = "INSERT INTO TAG VALUES ('" + fName + "','" + FileVerNum + "','" + list[nBR].Name.Replace("'", "''") + "','" + d[0] + "','" + d[1] + "','" + "BLK" + "','" + discipline + "','" + tagName + "'," + sqlValue + nullValue + ")";
                                    executeSQL(sqlClient, strSQL);
                                    WriteToLog("Tag Added : " + tagName);
                                    //Check for same logic to list inst tags
                                    InsertTagDetails(tagName, fName, lineEquipNr);
                                    if (tagName.Contains("\""))
                                    {
                                        SaveLineNumberDetails(tagName, fName);
                                    }
                                    nTagCount++;
                                }
                            }
                        }
                        catch (System.Exception ex)
                        {
                            WriteToLog("***Err1 : " + ex.Message);
                            Cursor.Current = Cursors.Default;
                        }
                    }
                }

                //WriteToLog("5");
                string nullValue1 = "";
                for (int i = 1; i <= 25; i++)
                {
                    nullValue1 += ",null";
                }

                //string tagstring = "()#:/";
                for (int i = 0; i < stringList.Count; i++)
                {
                    //if (stringList[i].TextString != "") WriteToLog("String " + (i+1).ToString() + ": " + stringList[i].TextString.ToString());
                    //if (stringList[i].TextString == ":" || stringList[i].TextString.Length > 33 || stringList[i].TextString.IndexOfAny(tagstring.ToCharArray()) > -1)
                    //    continue;
                    //WriteToLog("6");

                    try
                    {
                        string strSQL = "";
                        //if (stringList[i].TextString.Contains("-"))
                        //{
                            string tag = stringList[i].TextString.ToUpper();
                            tag = tag.Replace("%%U", "");

                            string discipline = "OTH";
                            if (tag.ToUpper().StartsWith("E-") || tag.ToUpper().StartsWith("P-") ||
                                tag.ToUpper().StartsWith("T-") || tag.ToUpper().StartsWith("A-") ||
                                tag.ToUpper().StartsWith("V-") || tag.ToUpper().StartsWith("K-") ||
                                tag.ToUpper().StartsWith("C-") || tag.ToUpper().StartsWith("S-") || tag.ToUpper().StartsWith("R-"))
                            {
                                discipline = "EQU";
                                int junk = tag.IndexOf(" ");
                                if (junk > -1)
                                {
                                    tag = tag.Substring(0, junk);
                                }
                                junk = tag.IndexOf('-', 5);
                                if (junk > -1)
                                {
                                    tag = tag.Substring(0, junk);
                                }
                            }
                            //else if (tag.StartsWith("R-"))
                            //    discipline = "PIP";
                            else
                            {
                                string[] sepList = tag.Split('-');
                                if (sepList.Length > 2 && sepList.Length < 4)
                                {
                                    int result = 0;
                                    if (int.TryParse(sepList[0], out result))
                                        discipline = "INS";
                                    else if (sepList[0].IndexOf('"') > 0 && sepList.Length > 2)
                                        discipline = "PIP";
                                }
                                else if (sepList.Length > 4 && sepList.Length < 6)
                                {
                                    if (sepList[0].IndexOf('"') > 0)
                                    {
                                        discipline = "PIP";
                                        if (sepList[1].Length == 2 || sepList[1].Length == 0)
                                            continue;
                                    }
                                }
                                else if (sepList[0].IndexOf('"') > 0 && sepList.Length > 2)
                                {
                                    discipline = "PIP";
                                    if (sepList[1].Length == 2 || sepList[1].Length == 0)
                                        continue;
                                }
                                //else
                                //    continue;
                            }

                            //if (tag.Length < 6)
                            //    continue;

                            string otherTags = string.Empty;
                            int nIndex = tag.IndexOf('~');
                            if (nIndex > -1)
                            {
                                string[] tags = tag.Split('~');
                                tag = tags[0];
                                otherTags = tags[0].Substring(0, tags[0].Length - tags[1].Length);
                                otherTags += tags[1];
                            }

                            bool bIsValid = true;
                            //if (discipline == "INS" && !isValidInsTag(tag))
                            //    bIsValid = false;

                            double[] d = stringList[i].TextAlignmentPoint;
                            if (bIsValid)
                            {
                                if (tag.IndexOf('"') > 0 && tag.IndexOf('-') > 0)
                                {
                                    string fName = System.IO.Path.GetFileName(fileName);
                                    strSQL = "INSERT INTO TAG VALUES ('" + fName + "','" + FileVerNum + "','" + "DBT" + "','" + d[0] + "','" + d[1] + "','" + "TXT" + "','" + discipline + "','" + tag.Replace("'", "''") + "'" + nullValue1 + ")";
                                    executeSQL(sqlClient, strSQL);
                                    InsertTagDetails(tag, fName, lineEquipNr);
                                    WriteToLog("Lines Added : " + tag);

                                    if (tag.Contains("\""))
                                        {
                                            SaveLineNumberDetails(tag, fName);
                                        }
                                        nTagCount++;
                                    }
                        }

                            if (otherTags.Length > 0)
                            {
                                //if (discipline == "INS" && !isValidInsTag(tag))
                                //    continue;
                                //strSQL = "INSERT INTO TAG VALUES ('" + fileName + "','" + "DBT" + "','" + d[0] + "','" + d[1] + "','" + "TXT" + "','" + discipline + "','" + otherTags.Replace("'", "''") + "'" + nullValue1 + ")";

                                //strSQL = "INSERT INTO TAG VALUES4 ('" + "DBT" + "','" + d[0] + "','" + d[1] + "','" + "TXT" + "','" + discipline + "','" + otherTags.Replace("'", "''") + "'" + nullValue1 + ")";
                                strSQL = "STRINGS : '" + "DBT" + "','" + "TXT" + "','" + discipline + "','" + otherTags.Replace("'", "''") + "'" + nullValue1 + ")";
                                WriteToLog("Other Tags : " + otherTags);
                                nTagCount++;
                            }
                        //}
                        //else
                        //    continue;
                    }
                    catch (System.Exception ex)
                    {
                        WriteToLog("***Err2 : " + ex.Message);
                        Cursor.Current = Cursors.Default;
                    }
                }
                //string temp = current + "/" + total + " files loaded";
                string status = string.Format("{0:0.00%}", (double)current / total);
                //string status = string.Format("{0},{1},{2},{3}", fileName, temp, nTagCount.ToString(), DateTime.Now.ToLocalTime(), ((current + 1) == total? "Completed" :"Inprogress"));
                WriteToLog(fileName + " File Parsed Successfully " + nTagCount.ToString() + current + "/" + total);
                Cursor.Current = Cursors.Default;
           }
            catch (System.Exception ex)
            {
                WriteToLog("***Err3 : " + ex.Message);
                Cursor.Current = Cursors.Default;
            }
        }

        private void InsertTagDetails(string Tag, string fileName, string lineEquipNr)
        {
            //bool isValid = char.IsLetter(Tag.FirstOrDefault());
            bool isValid = false;

            ICollection key = hashInstFilterList.Keys;

            foreach (string k in key)
            {
                if (hashInstFilterList[k].ToString() == "Contains")
                {
                    if (Tag.Contains(k.ToString()))
                    {
                        isValid = true;
                        break;
                    }
                }
                else if (hashInstFilterList[k].ToString() == "StartsWith")
                {
                    if (Tag.StartsWith(k.ToString()))
                    {
                        isValid = true;
                        break;
                    }
                }
            }

            if (isValid == true)
            {
                string otherTags = string.Empty;
                string iTag = string.Empty;
                string loopName = string.Empty;
                string fName = string.Empty;
                string sTagUnit = string.Empty;
                string sMake = string.Empty;
                string sModel = string.Empty;
                string lineDesc = string.Empty;

                int nIndex = Tag.IndexOf('-');
                if (nIndex > -1)
                {
                    string[] tags = Tag.Split('-');
                    if (tags.Length == 3)
                        loopName = tags[0].Substring(0, 3) + "-" + tags[1] + "-" + tags[2];
                    else
                        loopName = tags[0].Substring(0, 3) + "-" + tags[1];

                    iTag = CConf.GetString(Regex.Replace(tags[0], "\\d", ""));
                    if (iTag == "" || iTag == null)
                        iTag = "To Be Filled";    //tags[0].ToString();

                    sTagUnit = CConf.GetString(Regex.Replace(tags[0], "\\d", "") + "-Unit");
                    if (sTagUnit == null) sTagUnit = "To Be Filled";  //"NA";
                    fName = fileName.Substring(0, fileName.IndexOf("."));
                    //fName = fileName;                    
                }

                if (iTag != "" && iTag != null)
                {
                    if (iTag.IndexOf("\"") < 0)
                    {
                        string sTemp = GetMake(iTag);
                        int iSepPos = sTemp.IndexOf(",");
                        sMake = sTemp.Substring(0, iSepPos).Trim();
                        sModel = sTemp.Substring(iSepPos+1).Trim();

                        int charPos = lineEquipNr.ToList().FindIndex(c => Char.IsLetter(c));
                        if (charPos >=0) lineDesc = GetLineKeyVal(lineEquipNr.Substring(charPos, lineEquipNr.IndexOf("-", charPos) - charPos));

                        string strSQL = string.Empty;
                        strSQL = "INSERT INTO INSTRUMENT_TAG_DETAILS VALUES ('" + Tag + "','" + loopName  + "','" + iTag  + "','" + lineDesc + "','" + lineEquipNr + "','" + sMake + "','" + sModel + "','-','-','-','-','" + sTagUnit + "','-','-','-','-','-','" + fName + "','-','" + FileVerNum  + "','-','-','-','-','-','-','-','-','-','" + FileVerNum + "','No','No','" + Globals.UserID + "','" + Globals.ActiveProjectID + "')";
                        executeSQL(sqlClient, strSQL);

                        strSQL = "INSERT INTO INSTRUMENT_TAG_DETAILS_LOG VALUES ('" + Tag + "','" + loopName + "','" + iTag + "','" + lineDesc + "','" + lineEquipNr + "','" + sMake + "','" + sModel + "','-','-','-','-','" + sTagUnit + "','-','-','-','-','-','" + fName + "','-','" + FileVerNum + "','-','-','-','-','-','-','-','-','-','" + FileVerNum + "','No','No','" + DateTime.Now.ToShortDateString() + "','" + DateTime.Now.ToShortDateString() + "','" + Globals.UserID + "','" + Globals.ActiveProjectID + "')";
                        executeSQL(sqlClient, strSQL);
                    }
                }
            }
        }

        private void SaveLineNumberDetails(string LineNumber, string PID)
        {
            Cursor.Current = Cursors.WaitCursor;
            string strSQL = string.Empty;
            int ID = GetMaxLineNr();
            int charPos = LineNumber.ToList().FindIndex(c => Char.IsLetter(c));
            string KeyVal = GetLineKeyVal(LineNumber.Substring(charPos, LineNumber.IndexOf("-",charPos) - charPos));
            //PID = PID.Substring(0, PID.IndexOf("."));
            //strSQL = "INSERT INTO LINE_SERVICE_DESCRIPTION VALUES (" + ID + ",'" + LineNumber.Trim() + "','" + KeyVal.Trim() + "','" + PID + "')";
            //executeSQL(sqlClient, strSQL);
            Cursor.Current = Cursors.Default;
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

        private int GetMaxJBSchNr()
        {
            int MaxID = 1;
            sqlClient = new WatcherSqlClient(CConf.GetString("DBHost"), CConf.GetString("DBName"), CConf.GetBoolean("DBTrustedConnection"), CConf.GetString("DBLogin"), CConf.GetString("DBPassword"), CConf.GetString("DBConnectionString"));
            sqlClient.OpenConnection();
            DataSet dataSetMaxID = sqlClient.Query("SELECT MAX(ID) FROM JB_LAYOUT_DETAILS", "JBL");
            if (dataSetMaxID != null && dataSetMaxID.Tables.Count > 0 && dataSetMaxID.Tables[0].Rows.Count > 0)
            {
                if (dataSetMaxID.Tables[0].Rows[0][0].ToString() != "")
                    MaxID = Convert.ToInt16(dataSetMaxID.Tables[0].Rows[0][0].ToString()) + 1;
            }
            Cursor.Current = Cursors.Default;

            return MaxID;
        }

        private string GetLineKeyVal(string LineKey)
        {
            sqlClient = new WatcherSqlClient(CConf.GetString("DBHost"), CConf.GetString("DBName"), CConf.GetBoolean("DBTrustedConnection"), CConf.GetString("DBLogin"), CConf.GetString("DBPassword"), CConf.GetString("DBConnectionString"));
            sqlClient.OpenConnection();
            string LineKeyVal = LineKey;
            DataSet dataSetMaxID = sqlClient.Query("SELECT LegendValue FROM Legend WHERE LegendKey='" + LineKey + "'", "LSD");
            if (dataSetMaxID != null && dataSetMaxID.Tables.Count > 0 && dataSetMaxID.Tables[0].Rows.Count > 0)
            {
                if (dataSetMaxID.Tables[0].Rows[0][0].ToString() != "")
                    LineKeyVal = dataSetMaxID.Tables[0].Rows[0][0].ToString();
            }
            Cursor.Current = Cursors.Default;

            return LineKeyVal.Trim();
        }

        private bool CheckPIDExist(string fileName)
        {
            string fName = System.IO.Path.GetFileName(fileName);
            sqlClient = new WatcherSqlClient(CConf.GetString("DBHost"), CConf.GetString("DBName"), CConf.GetBoolean("DBTrustedConnection"), CConf.GetString("DBLogin"), CConf.GetString("DBPassword"), CConf.GetString("DBConnectionString"));
            sqlClient.OpenConnection();
            bool PIDExist = false;
            DataSet dataPID = sqlClient.Query("SELECT FILE_NAME FROM TAG WHERE FILE_NAME='" + fName + "'", "PID");
            if (dataPID != null && dataPID.Tables.Count > 0 && dataPID.Tables[0].Rows.Count > 0)
            {
                if (dataPID.Tables[0].Rows[0][0].ToString() != "")
                    PIDExist = true;
            }
            Cursor.Current = Cursors.Default;

            return PIDExist;
        }

        private void GetFileVerNumber(string fileName)
        {
            FileVerNum = "1";
            //int len = Convert.ToInt16(CConf.GetString("FileVersionNumberLength"));
            //if (len > 0)
            //{
            //    FileVerNum = fileName.Substring((fileName.IndexOf(".") - len), len);
            //}
        }

        bool executeSQL(WatcherSqlClient sqlClient, string strSQL)
        {
            if (sqlClient == null)
                return false;

            sqlClient.Query(strSQL, sqlTransanction);
            return (sqlClient.ErrorMessage == null);
        }

        private void btnCloseInstance_Click(object sender, EventArgs e)
        {
            Process[] aCAD = Process.GetProcessesByName("acad");

            foreach (Process aCADPro in aCAD)
            {
                aCADPro.CloseMainWindow();
                aCADPro.Kill();
                aCADPro.Dispose();
            }
            btnProgID.Enabled = true;
            btnReadDWG.Enabled = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtLog.Text = "";
        }

        private void btnReadDWG_Click(object sender, EventArgs e)
        {
            frmWait frmShowWait = new frmWait();
            frmShowWait.StartPosition = FormStartPosition.CenterScreen;
            try
            {
                frmShowWait.Show();
                frmShowWait.Refresh();
                Cursor.Current = Cursors.WaitCursor;

                GetPIDTagMapList();

                if (bReadMultiFiles == true)
                {
                    string[] dirs = Directory.GetFiles(txtFileName.Text, "*.dwg");
                    foreach (string dir in dirs)
                    {
                        string sFileName = dir;
                        if (!CheckPIDExist(dir))
                        {
                            object axDbDocument = acadApp.GetInterfaceObject("ObjectDBX.AxDbDocument." + version);
                            if (axDbDocument == null)
                                WriteToLog("axDbDocument is null");

                            Autodesk.AutoCAD.Interop.Common.AxDbDocument sourceAxDb = axDbDocument as Autodesk.AutoCAD.Interop.Common.AxDbDocument;
                            if (sourceAxDb == null)
                                WriteToLog("sourceAxDb is null");

                            sourceAxDb.Open(dir);
                            StatStripLbl1.Text = "File Opened Successfully.";
                            if (gbReadPID.Text == "Read P&&ID")
                                readDWG(sourceAxDb.ModelSpace, txtFileName.Text, 1, 1);
                            else if (gbReadPID.Text == "Read JB Schedule")
                                readJBSchedule(sourceAxDb.ModelSpace, txtFileName.Text, 1, 1);
                            StatStripLbl1.Text = "Data Read Successfully.";
                            sourceAxDb = null;
                            StatStripLbl1.Text = "Checking for next file to process.";
                        }
                        else
                        {
                            WriteToLog("Data from this file is already extracted: " + dir);
                        }
                    }
                    StatStripLbl1.Text = "All files processed.";
                }
                else
                {
                    if (!CheckPIDExist(txtFileName.Text))
                    {
                        object axDbDocument = acadApp.GetInterfaceObject("ObjectDBX.AxDbDocument." + version);
                        if (axDbDocument == null)
                            WriteToLog("axDbDocument is null");

                        Autodesk.AutoCAD.Interop.Common.AxDbDocument sourceAxDb = axDbDocument as Autodesk.AutoCAD.Interop.Common.AxDbDocument;
                        if (sourceAxDb == null)
                            WriteToLog("sourceAxDb is null");

                        sourceAxDb.Open(txtFileName.Text);
                        StatStripLbl1.Text = "File Opened Successfully.";
                        if (gbReadPID.Text == "Read P&&ID")
                            readDWG(sourceAxDb.ModelSpace, txtFileName.Text, 1, 1);
                        else if(gbReadPID.Text == "Read JB Schedule")
                            readJBSchedule(sourceAxDb.ModelSpace, txtFileName.Text, 1, 1);


                        StatStripLbl1.Text = "Data Read Successfully.";
                        sourceAxDb = null;
                    }
                    else
                    {
                        MessageBox.Show("Data from this file is already extracted");
                    }
                }

                Cursor.Current = Cursors.Default;
                frmShowWait.Hide();
            }
            catch (System.Exception ex)
            {
                WriteToLog(ex.Message);
                Cursor.Current = Cursors.Default;
                frmShowWait.Hide();
            }
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            if(btnSelectFile.Text == "Select File")
            {
                if (ofdDWG.ShowDialog() == DialogResult.OK)
                {
                    txtFileName.Text = ofdDWG.FileName;
                }
            }
            else
            {
                try
                {
                    if (fdDWG.ShowDialog() == DialogResult.OK)
                    {
                        txtFileName.Text = fdDWG.SelectedPath;
                        Environment.SpecialFolder root = fdDWG.RootFolder;
                    }

                    // Only get files that begin with the letter "c".
                    string[] dirs = Directory.GetFiles(txtFileName.Text, "*.dwg");
                    WriteToLog("The number of files to process: " + dirs.Length.ToString());
                    foreach (string dir in dirs)
                    {
                        WriteToLog(dir);
                    }
                }
                catch (System.Exception es)
                {
                    WriteToLog("The process failed: " + es.ToString());
                }
            }
        }

        private void singleDrawingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gbReadPID.Text = "Read P&&ID";
            chkMultipleFiles.Checked = false;
            bReadMultiFiles = false;
            btnSelectFile.Text = "Select File";
            gbReadPID.BringToFront();
            gbReadPID.Visible = true;
        }

        private void btnClosegbPID_Click(object sender, EventArgs e)
        {
            gbReadPID.Visible = false;
        }

        private string GetMake(string InstrumentType)
        {
            DataSet dataSetMakeList = sqlClient.Query("SELECT Make,DefaultModelNr FROM VENDOR_LIST WHERE InstrumentType='" + InstrumentType + "'", "LSD");
            if (dataSetMakeList != null && dataSetMakeList.Tables.Count > 0 && dataSetMakeList.Tables[0].Rows.Count > 0)
            {
                return dataSetMakeList.Tables[0].Rows[0][0].ToString().Trim() + "," + dataSetMakeList.Tables[0].Rows[0][1].ToString().Trim();
            }
            else
            {
                return "NA,NA";
            }
        }

        private void instrumentIndexToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmViewUpdateInstIndex frmViewII = new frmViewUpdateInstIndex();
            frmViewII.MdiParent = this;
            frmViewII.StartPosition = FormStartPosition.CenterScreen;
            frmViewII.gbInstIndex.Text = "View && Update Instrument Index Details";
            frmViewII.cboExtractList.Text = "Instrument Index";
            frmViewII.Show();
        }

        private void iOListToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmViewUpdateInstIndex frmViewIO = new frmViewUpdateInstIndex();
            frmViewIO.MdiParent = this;
            frmViewIO.StartPosition = FormStartPosition.CenterScreen;
            frmViewIO.gbInstIndex.Text = "View && Update I/O List Details";
            frmViewIO.cboExtractList.Text = "I/O List";
            frmViewIO.Show();
        }

        private void JBScheduleToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmViewUpdateInstIndex frmViewJBS = new frmViewUpdateInstIndex();
            frmViewJBS.MdiParent = this;
            frmViewJBS.StartPosition = FormStartPosition.CenterScreen;
            frmViewJBS.gbInstIndex.Text = "View && Update JB Schedule Details";
            frmViewJBS.cboExtractList.Text = "JB Schedule List";
            frmViewJBS.Show();
        }

        private void instrumentIndexToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmViewUpdateInstIndex frmViewII = new frmViewUpdateInstIndex();
            frmViewII.MdiParent = this;
            frmViewII.StartPosition = FormStartPosition.CenterScreen;
            frmViewII.gbInstIndex.Text = "Instrument Index Details";
            frmViewII.cboExtractList.Text = "Instrument Index";
            frmViewII.Show();
        }

        private void iOListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmViewUpdateInstIndex frmViewII = new frmViewUpdateInstIndex();
            frmViewII.MdiParent = this;
            frmViewII.StartPosition = FormStartPosition.CenterScreen;
            frmViewII.gbInstIndex.Text = "I/O List Details";
            frmViewII.cboExtractList.Text = "I/O List";
            frmViewII.Show();
        }

        private void disciplineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            gbReadPID.Visible = false;
            frmInstFormat frmIF = new frmInstFormat();
            frmIF.MdiParent = this;
            frmIF.StartPosition = FormStartPosition.CenterScreen;
            frmIF.gbInstDiscFormat.Text = "Discipline Filter Forrmat";
            frmIF.Show();
            Cursor.Current = Cursors.Default;
        }

        private void vendorListToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            gbReadPID.Visible = false;
            frmVendorList frmVL = new frmVendorList();
            frmVL.MdiParent = this;
            frmVL.StartPosition = FormStartPosition.Manual;
            frmVL.Show();
            Cursor.Current = Cursors.Default;
        }

        private void legendToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            gbReadPID.Visible = false;
            frmInstFormat frmIF = new frmInstFormat();
            frmIF.MdiParent = this;
            frmIF.StartPosition = FormStartPosition.CenterScreen;
            frmIF.gbInstDiscFormat.Text = "Legends";
            frmIF.Show();
            Cursor.Current = Cursors.Default;
        }

        private void lineNumberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            gbReadPID.Visible = false;
            frmInstLineNumbers frmLNR = new frmInstLineNumbers();
            frmLNR.MdiParent = this;
            frmLNR.StartPosition = FormStartPosition.Manual;
            frmLNR.Show();
            Cursor.Current = Cursors.Default;
        }

        private void appConfigToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            frmAppConfig frmConfig = new frmAppConfig();
            frmConfig.MdiParent = this;
            frmConfig.StartPosition = FormStartPosition.Manual;
            frmConfig.Show();
            Cursor.Current = Cursors.Default;
        }

        public void UpdateStatusBarText(string msg)
        {
            StatStripLbl1.Text = msg;
            this.Refresh();
        }

        private void GetInstFilterList()
        {
            hashInstFilterList.Clear();

            DataSet dataSetInstFilterList = sqlClient.Query("SELECT Filter_Word,Filter_Pattern FROM DISCIPLINE_FILTER WHERE Discipline_Tag='Instrument'", "IDF");
            if (dataSetInstFilterList != null && dataSetInstFilterList.Tables.Count > 0 && dataSetInstFilterList.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < dataSetInstFilterList.Tables[0].Rows.Count; i++)
                {
                    hashInstFilterList.Add(dataSetInstFilterList.Tables[0].Rows[i][0].ToString().Trim(), dataSetInstFilterList.Tables[0].Rows[i][1].ToString().Trim());
                }
            }
        }

        private void GetPIDTagMapList()
        {
            hashPIDTagList.Clear();
            hashPIDTagMapList.Clear();
            sqlClient = new WatcherSqlClient(CConf.GetString("DBHost"), CConf.GetString("DBName"), CConf.GetBoolean("DBTrustedConnection"), CConf.GetString("DBLogin"), CConf.GetString("DBPassword"), CConf.GetString("DBConnectionString"));
            sqlClient.OpenConnection();
            DataSet dataSetPIDTagMapList = sqlClient.Query("SELECT PIDTag,NewTag FROM PID_TAG_MAPPING", "PTL");
            if (dataSetPIDTagMapList != null && dataSetPIDTagMapList.Tables.Count > 0 && dataSetPIDTagMapList.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < dataSetPIDTagMapList.Tables[0].Rows.Count; i++)
                {
                    hashPIDTagList.Add(dataSetPIDTagMapList.Tables[0].Rows[i][0].ToString().Trim(), dataSetPIDTagMapList.Tables[0].Rows[i][1].ToString().Trim());
                    hashPIDTagMapList.Add(new KeyValuePair<string, string>(dataSetPIDTagMapList.Tables[0].Rows[i][0].ToString(), dataSetPIDTagMapList.Tables[0].Rows[i][1].ToString()));
                }
            }
        }

        private string PIDTagMap(string Tag)
        {
            try
            {
                ICollection key = hashPIDTagList.Keys;

                foreach (string k in key)
                {
                    if (Tag.Contains(k.ToString()))
                    {
                        string PIDkey = k.ToString();
                        List<string> values = (from hashPIDTagMapList in hashPIDTagMapList where hashPIDTagMapList.Key.Trim() == PIDkey select hashPIDTagMapList.Value.Trim()).ToList();
                        string NewTag = values[0].ToString();
                        Tag = Tag.Replace(k.ToString(), NewTag);
                        return Tag;
                    }
                }

                //string key = Tag;
                ////List<string> values = (from hashPIDTagMapList in hashPIDTagMapList where hashPIDTagMapList.Key == key select hashPIDTagMapList.Value).ToList();
                //List<string> values = (from hashPIDTagMapList in hashPIDTagMapList where key.Contains(hashPIDTagMapList.Key) select hashPIDTagMapList.Value).ToList();
                //Tag.Replace(hashPIDTagMapList.Key, values[0]);
                return Tag;
            }
            catch
            {
                return "NA";
            }
        }

        private void pIDTagNumberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            gbReadPID.Visible = false;
            frmPIDTagNrMapping frmPIDTagMapping = new frmPIDTagNrMapping();
            frmPIDTagMapping.MdiParent = this;
            frmPIDTagMapping.StartPosition = FormStartPosition.CenterScreen;
            frmPIDTagMapping.Show();
            Cursor.Current = Cursors.Default;
        }

        private void JBScheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gbReadPID.Text = "Read JB Schedule";
            chkMultipleFiles.Checked = false;
            bReadMultiFiles = false;
            btnSelectFile.Text = "Select File";
            gbReadPID.BringToFront();
            gbReadPID.Visible = true;
        }

        void readJBSchedule(Autodesk.AutoCAD.Interop.Common.AcadModelSpace modSpace, string fileName, int total, int current)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                sqlClient = new WatcherSqlClient(CConf.GetString("DBHost"), CConf.GetString("DBName"), CConf.GetBoolean("DBTrustedConnection"), CConf.GetString("DBLogin"), CConf.GetString("DBPassword"), CConf.GetString("DBConnectionString"));
                sqlClient.OpenConnection();

                for (int nItem = 0; nItem < modSpace.Count; nItem++)
                {
                    Autodesk.AutoCAD.Interop.Common.AcadEntity acadEnt = modSpace.Item(nItem);
                    if (acadEnt != null && acadEnt is Autodesk.AutoCAD.Interop.Common.AcadTable)
                    {
                        Autodesk.AutoCAD.Interop.Common.AcadTable acadTbl = (Autodesk.AutoCAD.Interop.Common.AcadTable)acadEnt;
                        for (int i = 0; i < acadTbl.Rows; i++)
                        {
                            if (acadTbl.GetCellValue(i, 0) != null)
                            {
                                string fName = System.IO.Path.GetFileName(fileName);
                                int ID = GetMaxJBSchNr();
                                string strSQL = "INSERT INTO JB_LAYOUT_DETAILS VALUES (" + ID + ",'" + acadTbl.GetCellValue(i, 0) + "','" + fName + "')";
                                executeSQL(sqlClient, strSQL);
                                WriteToLog(acadTbl.GetCellValue(i, 0));
                            }
                        }
                    }
                }
                Cursor.Current = Cursors.Default;
            }
            catch (System.Exception ex)
            {
                WriteToLog("***Error : " + ex.Message);
                Cursor.Current = Cursors.Default;
            }
        }

        private void chkMultipleFiles_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMultipleFiles.Checked == true)
            {
                bReadMultiFiles = true;
                btnSelectFile.Text = "Select Folder";
            }
            else
            {
                bReadMultiFiles = false;
                btnSelectFile.Text = "Select File";
            }
        }

        private void junctionBoxScheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmViewUpdateInstIndex frmViewJBS = new frmViewUpdateInstIndex();
            frmViewJBS.MdiParent = this;
            frmViewJBS.StartPosition = FormStartPosition.CenterScreen;
            frmViewJBS.gbInstIndex.Text = "JB Schedule Details";
            frmViewJBS.cboExtractList.Text = "JB Schedule List";
            frmViewJBS.Show();
        }

        private void bgWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            worker.ReportProgress(10);

            string ProgID = "";
            Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Autodesk\AutoCAD");
            StatStripLbl1.Text = "Launching Process..";
            TagBlocks = Convert.ToInt16(CConf.GetString("Tag_Number_Block_Length"));

            if (key != null)
            {
                foreach (string keyname in key.GetSubKeyNames())
                {
                    if (keyname.StartsWith("R"))
                    {
                        int index = keyname.IndexOf('.');
                        string name = keyname.Substring(0, index);
                        version = keyname.Substring(1, name.Length - 1);
                        ProgID = (appName + keyname.Substring(1, name.Length - 1));
                        worker.ReportProgress(20);

                        try
                        {
                            //Check for instance and create if it is not running
                            acadApp = (AcadApplication)Marshal.GetActiveObject(ProgID);
                            StatStripLbl1.Text = "Process is already running.";
                            btnReadDWG.Enabled = true;
                            btnCloseInstance.Enabled = true;
                        }
                        catch
                        {
                            //////frmWait frmShowWait = new frmWait();
                            //////frmShowWait.StartPosition = FormStartPosition.CenterScreen;
                            //////frmShowWait.Show();
                            //////frmShowWait.Refresh();
                            try
                            {
                                worker.ReportProgress(30);

                                Cursor.Current = Cursors.WaitCursor;
                                Type acType = Type.GetTypeFromProgID(ProgID);
                                acadApp = (AcadApplication)Activator.CreateInstance(acType, true);
                                worker.ReportProgress(40);
                                acadApp.Visible = false;
                                acadApp.Width = 1;
                                acadApp.Height = 1;
                                acadApp.Visible = false;
                                StatStripLbl1.Text = "Process Instance Created.";
                                //btnProgID.Enabled = false;
                                //btnCloseInstance.Enabled = true;
                                //btnReadDWG.Enabled = true;

                                //if (!CheckPIDExist(txtFileName.Text))
                                //{
                                //    object axDbDocument = acadApp.GetInterfaceObject("ObjectDBX.AxDbDocument." + version);
                                //    if (axDbDocument == null)
                                //        StatStripLbl1.Text = "axDbDocument is null";

                                //    Autodesk.AutoCAD.Interop.Common.AxDbDocument sourceAxDb = axDbDocument as Autodesk.AutoCAD.Interop.Common.AxDbDocument;
                                //    if (sourceAxDb == null)
                                //        StatStripLbl1.Text = "sourceAxDb is null";

                                //    sourceAxDb.Open(txtFileName.Text);
                                //    GetPIDTagMapList();
                                //    StatStripLbl1.Text = "File Opened Successfully.";
                                //    readDWG(sourceAxDb.ModelSpace, txtFileName.Text, 1, 1);
                                //    StatStripLbl1.Text = "Data Read Successfully.";
                                //    sourceAxDb = null;
                                //}
                                //else
                                //{
                                //    StatStripLbl1.Text = "Data already extracted from this file.";
                                //}
                                //////frmShowWait.Hide();
                                //btnCancel_Click(this, e);
                                Cursor.Current = Cursors.Default;
                            }
                            catch (System.Exception ex)
                            {
                                StatStripLbl1.Text = ex.Message;
                                //////frmShowWait.Hide();
                                //btnCancel_Click(this, e);
                                Cursor.Current = Cursors.Default;
                            }
                        }
                    }
                }
            }

            for (int i = 5; i <= 10; i++)
            {
                if (worker.CancellationPending == true)
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
                    // Perform a time consuming operation and report progress.
                    worker.ReportProgress(i * 10);
                    System.Threading.Thread.Sleep(200);
                }
            }
        }

        private void bgWorker_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            // Show the progress in main form (GUI)
            //StatStripLbl1.Text = (e.ProgressPercentage.ToString() + "%");
            // Pass the progress to AlertForm label and progressbar
            WaitForm.Message = "Processing, please wait... " + e.ProgressPercentage.ToString() + "%";
            WaitForm.ProgressValue = e.ProgressPercentage;
        }

        private void bgWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled == true)
            {
                StatStripLbl1.Text = "Canceled!";
            }
            else if (e.Error != null)
            {
                StatStripLbl1.Text = "Error: " + e.Error.Message;
            }
            else
            {
                StatStripLbl1.Text = "Done!";
            }
            // Close the AlertForm
            WaitForm.Close();
        }

        private void readPIDToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tAGToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void vendorCatalogToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
