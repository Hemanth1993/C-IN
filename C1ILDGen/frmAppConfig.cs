using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Xml;

namespace C1ILDGen
{
    public partial class frmAppConfig : Form
    {
        public frmAppConfig()
        {
            InitializeComponent();
        }
            
        private void frmAppConfig_Load(object sender, EventArgs e)
        {
            LoadConfigData();
        }

        private void LoadConfigData()
        {
            dgAppConfig.Rows.Clear();
            foreach (string key in ConfigurationManager.AppSettings)
            {
                string value = ConfigurationManager.AppSettings[key];
                dgAppConfig.Rows.Add(key, value);
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            try
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.AppSettings.Settings.Add(txtKey.Text, txtValue.Text);
                config.Save();
                ConfigurationManager.RefreshSection("appSettings");
                LoadConfigData();
                MessageBox.Show("New Config Entry Added Succesfully.", "Config");
                txtKey.Text = "";
                txtValue.Text = "";
            }
            catch
            {
                MessageBox.Show("Failed To Add New Config Entry.", "Config");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
            int RowNr = 0;

            foreach (XmlElement element in xmlDoc.DocumentElement)
            {
                if (element.Name.Equals("appSettings"))
                {
                    foreach (XmlNode node in element.ChildNodes)
                    {
                        if(node.NodeType != XmlNodeType.Comment)
                        {
                            if (node.Attributes[0].Value.Equals(dgAppConfig.Rows[RowNr].Cells[0].Value.ToString()))
                            {
                                if (dgAppConfig.Rows[RowNr].Cells[1].Value != null)
                                    node.Attributes[1].Value = dgAppConfig.Rows[RowNr].Cells[1].Value.ToString();
                                else
                                    node.Attributes[1].Value = "";
                            }
                            RowNr++;
                        }
                    }
                }
            }
            xmlDoc.Save(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
            ConfigurationManager.RefreshSection("appSettings");
            MessageBox.Show("Config Data Updated Succesfully.", "Config");
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
