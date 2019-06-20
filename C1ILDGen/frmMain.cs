using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace C1ILDGen
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            mnuMain.Renderer = new MyRenderer();
            lblUserName.Text = Globals.UserFirstName + " " + Globals.UserLastName;
        }
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        private void pbSlide_Click(object sender, EventArgs e)
        {
            if(pnlLeftMenu.Width == 250)
            {
                pnlLeftMenu.Width = 55;
                mnuAdministration.DisplayStyle = ToolStripItemDisplayStyle.Image;
                mnuProjects.DisplayStyle = ToolStripItemDisplayStyle.Image;
                mnuProcess.DisplayStyle = ToolStripItemDisplayStyle.Image;
                mnuViewUpdate.DisplayStyle = ToolStripItemDisplayStyle.Image;
                mnuReports.DisplayStyle = ToolStripItemDisplayStyle.Image;
                mnuMain.Width = 55;
                mnuMain.ShowItemToolTips = true;
                pbSmall.Visible = true;
                pbBig.Visible = false;
            }
            else
            {
                pnlLeftMenu.Width = 250;
                mnuAdministration.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
                mnuProjects.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
                mnuProcess.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
                mnuViewUpdate.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
                mnuReports.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
                mnuMain.Width = 250;
                mnuMain.ShowItemToolTips = false;
                pbSmall.Visible = false;
                pbBig.Visible = true;
            }
        }

        private void pbCloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbMaxButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            pbMaxButton.Visible = false;
            pbRestoreButton.Visible = true;
        }

        private void pbRestoreButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            pbMaxButton.Visible = true;
            pbRestoreButton.Visible = false;
        }

        private void pbMinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pnlTopMenu_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void ShowFormInPanel(object formTest)
        {
            if (this.pnlContent.Controls.Count > 0)
                this.pnlContent.Controls.RemoveAt(0);
            Form ft = formTest as Form;
            ft.TopLevel = false;
            ft.Dock = DockStyle.Fill;
            this.pnlContent.Controls.Add(ft);
            this.pnlContent.Tag = ft;
            ft.Show();
        }

        private void mnuProjects_Click(object sender, EventArgs e)
        {
           
        }

        private void mnuProcessPID_Click(object sender, EventArgs e)
        {
            Globals.PFForm = "PID";
            ShowFormInPanel(new frmProcessFile(this));
            mnuAdministration.BackColor = Color.Transparent;
            mnuProjects.BackColor = Color.Transparent;
            mnuProcess.BackColor = Color.Black;
            mnuViewUpdate.BackColor = Color.Transparent;
            mnuReports.BackColor = Color.Transparent;
        }

        private class MyRenderer : ToolStripProfessionalRenderer
        {
            /* protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
             {
                 if (!e.Item.Selected) base.OnRenderMenuItemBackground(e);
                 else
                 {
                     Rectangle rc = new Rectangle(Point.Empty, e.Item.Size);
                     e.Graphics.FillRectangle(Brushes.Black, rc);
                     //e.Graphics.DrawRectangle(Pens.Black, 1, 0, rc.Width - 2, rc.Height - 1);
                 }
             } */
            protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
            {
                if (!e.Item.Selected)
                {
                    base.OnRenderMenuItemBackground(e);
                    e.Item.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204))))); //Color.Black;
                }
                else
                {
                    Rectangle rc = new Rectangle(Point.Empty, e.Item.Size);
                    e.Graphics.FillRectangle(Brushes.Red, rc);
                    e.Graphics.DrawRectangle(Pens.Black, 1, 0, rc.Width - 2, rc.Height - 1);
                    e.Item.BackColor = Color.Red;
                }
            }

            protected override void OnRenderItemText(ToolStripItemTextRenderEventArgs e)
            {
                base.OnRenderItemText(e);
                if (!e.Item.Selected)
                {
                    e.Item.ForeColor = Color.Black;
                    e.Item.ImageTransparentColor = Color.Black;
                }
                else
                {
                    e.Item.ForeColor = Color.Black;
                    e.Item.ImageTransparentColor = Color.Black;
                }
            }
        }

        private void mnuViewUpdate_Click(object sender, EventArgs e)
        {
            mnuAdministration.BackColor = Color.Transparent;
            mnuProjects.BackColor = Color.Transparent;
            mnuProcess.BackColor = Color.Transparent;
            mnuViewUpdate.BackColor = Color.Black;
            mnuReports.BackColor = Color.Transparent;
        }

        private void mnuVUPID_Click(object sender, EventArgs e)
        {
            Globals.VUForm = "IID";
            ShowFormInPanel(new frmVUData());
            mnuAdministration.BackColor = Color.Transparent;
            mnuProjects.BackColor = Color.Transparent;
            mnuProcess.BackColor = Color.Transparent;
            mnuViewUpdate.BackColor = Color.Black;
            mnuReports.BackColor = Color.Transparent;
        }

        private void mnuVUJBSchedule_Click(object sender, EventArgs e)
        {
            Globals.VUForm = "JBS";
            ShowFormInPanel(new frmVUData());
            mnuAdministration.BackColor = Color.Transparent;
            mnuProjects.BackColor = Color.Transparent;
            mnuProcess.BackColor = Color.Transparent;
            mnuViewUpdate.BackColor = Color.Black;
            mnuReports.BackColor = Color.Transparent;
        }

        private void iOListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Globals.VUForm = "IOL";
            ShowFormInPanel(new frmVUData());
            mnuAdministration.BackColor = Color.Transparent;
            mnuProjects.BackColor = Color.Transparent;
            mnuProcess.BackColor = Color.Transparent;
            mnuViewUpdate.BackColor = Color.Black;
            mnuReports.BackColor = Color.Transparent;
        }

        private void instrumentIndexToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Globals.VUForm = "IIDR";
            ShowFormInPanel(new frmVUData());
            mnuAdministration.BackColor = Color.Transparent;
            mnuProjects.BackColor = Color.Transparent;
            mnuProcess.BackColor = Color.Transparent;
            mnuViewUpdate.BackColor = Color.Transparent;
            mnuReports.BackColor = Color.Black;
        }

        private void iOListToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Globals.VUForm = "IOLR";
            ShowFormInPanel(new frmVUData());
            mnuAdministration.BackColor = Color.Transparent;
            mnuProjects.BackColor = Color.Transparent;
            mnuProcess.BackColor = Color.Transparent;
            mnuViewUpdate.BackColor = Color.Transparent;
            mnuReports.BackColor = Color.Black;
        }

        private void jBScheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Globals.VUForm = "JBSR";
            ShowFormInPanel(new frmVUData());
            mnuAdministration.BackColor = Color.Transparent;
            mnuProjects.BackColor = Color.Transparent;
            mnuProcess.BackColor = Color.Transparent;
            mnuViewUpdate.BackColor = Color.Transparent;
            mnuReports.BackColor = Color.Black;
        }

        private void mnuProcessJB_Click(object sender, EventArgs e)
        {
            Globals.PFForm = "JBL";
            ShowFormInPanel(new frmProcessFile(this));
            mnuAdministration.BackColor = Color.Transparent;
            mnuProjects.BackColor = Color.Transparent;
            mnuProcess.BackColor = Color.Black;
            mnuViewUpdate.BackColor = Color.Transparent;
            mnuReports.BackColor = Color.Transparent;
        }

        private void appConfigToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new frmAppConfig());
            mnuAdministration.BackColor = Color.Black;
            mnuProjects.BackColor = Color.Transparent;
            mnuProcess.BackColor = Color.Transparent;
            mnuViewUpdate.BackColor = Color.Transparent;
            mnuReports.BackColor = Color.Transparent;
        }

        private void userManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new frmUsers());
            mnuAdministration.BackColor = Color.Black;
            mnuProjects.BackColor = Color.Transparent;
            mnuProcess.BackColor = Color.Transparent;
            mnuViewUpdate.BackColor = Color.Transparent;
            mnuReports.BackColor = Color.Transparent;
        }

        private void instFormatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Globals.InstDiscipline = "Discipline Filter Forrmat";
            ShowFormInPanel(new frmInstFormat());
            mnuAdministration.BackColor = Color.Black;
            mnuProjects.BackColor = Color.Transparent;
            mnuProcess.BackColor = Color.Transparent;
            mnuViewUpdate.BackColor = Color.Transparent;
            mnuReports.BackColor = Color.Transparent;
        }

        private void mnuAdministration_BackColorChanged(object sender, EventArgs e)
        {
        }

        private void mnuAdministration_Click(object sender, EventArgs e)
        {
        }

        private void legendsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Globals.InstDiscipline = "Legends";
            ShowFormInPanel(new frmInstFormat());
            mnuAdministration.BackColor = Color.Black;
            mnuProjects.BackColor = Color.Transparent;
            mnuProcess.BackColor = Color.Transparent;
            mnuViewUpdate.BackColor = Color.Transparent;
            mnuReports.BackColor = Color.Transparent;
        }

        private void vendorListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new frmVendorList());
            mnuAdministration.BackColor = Color.Black;
            mnuProjects.BackColor = Color.Transparent;
            mnuProcess.BackColor = Color.Transparent;
            mnuViewUpdate.BackColor = Color.Transparent;
            mnuReports.BackColor = Color.Transparent;
        }

        private void mappingPIDTagNumberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new frmPIDTagNrMapping());
            mnuAdministration.BackColor = Color.Black;
            mnuProjects.BackColor = Color.Transparent;
            mnuProcess.BackColor = Color.Transparent;
            mnuViewUpdate.BackColor = Color.Transparent;
            mnuReports.BackColor = Color.Transparent;
        }

        private void mnuReports_Click(object sender, EventArgs e)
        {

        }

        private void ProjectNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new frmProject());
            mnuAdministration.BackColor = Color.Transparent;
            mnuProjects.BackColor = Color.Black;
            mnuProcess.BackColor = Color.Transparent;
            mnuViewUpdate.BackColor = Color.Transparent;
            mnuReports.BackColor = Color.Transparent;
        }
    }
}
