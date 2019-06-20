namespace C1ILDGen
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlLeftMenu = new System.Windows.Forms.Panel();
            this.pbSmall = new System.Windows.Forms.PictureBox();
            this.pbBig = new System.Windows.Forms.PictureBox();
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mnuAdministration = new System.Windows.Forms.ToolStripMenuItem();
            this.userManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProjects = new System.Windows.Forms.ToolStripMenuItem();
            this.projectNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instFormatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.legendsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendorListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mappingPIDTagNumberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProcess = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProcessPID = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProcessJB = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuViewUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVUPID = new System.Windows.Forms.ToolStripMenuItem();
            this.iOListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVUJBSchedule = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReports = new System.Windows.Forms.ToolStripMenuItem();
            this.instrumentIndexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iOListToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.jBScheduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlTopMenu = new System.Windows.Forms.Panel();
            this.lblUserName = new System.Windows.Forms.Label();
            this.pbUser = new System.Windows.Forms.PictureBox();
            this.pbMinimizeButton = new System.Windows.Forms.PictureBox();
            this.pbMaxButton = new System.Windows.Forms.PictureBox();
            this.pbCloseButton = new System.Windows.Forms.PictureBox();
            this.pbSlide = new System.Windows.Forms.PictureBox();
            this.pbRestoreButton = new System.Windows.Forms.PictureBox();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.ssMain = new System.Windows.Forms.StatusStrip();
            this.StatStripLbl1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlLeftMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSmall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBig)).BeginInit();
            this.mnuMain.SuspendLayout();
            this.pnlTopMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimizeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMaxButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCloseButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRestoreButton)).BeginInit();
            this.ssMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLeftMenu
            // 
            this.pnlLeftMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.pnlLeftMenu.Controls.Add(this.pbSmall);
            this.pnlLeftMenu.Controls.Add(this.pbBig);
            this.pnlLeftMenu.Controls.Add(this.mnuMain);
            this.pnlLeftMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeftMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlLeftMenu.Name = "pnlLeftMenu";
            this.pnlLeftMenu.Size = new System.Drawing.Size(250, 650);
            this.pnlLeftMenu.TabIndex = 0;
            // 
            // pbSmall
            // 
            this.pbSmall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbSmall.Image = global::C1ILDGen.Properties.Resources.CIN_Small;
            this.pbSmall.Location = new System.Drawing.Point(2, 3);
            this.pbSmall.Name = "pbSmall";
            this.pbSmall.Size = new System.Drawing.Size(47, 64);
            this.pbSmall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSmall.TabIndex = 8;
            this.pbSmall.TabStop = false;
            this.pbSmall.Visible = false;
            // 
            // pbBig
            // 
            this.pbBig.Image = global::C1ILDGen.Properties.Resources.CIN_3;
            this.pbBig.Location = new System.Drawing.Point(12, 3);
            this.pbBig.Name = "pbBig";
            this.pbBig.Size = new System.Drawing.Size(219, 64);
            this.pbBig.TabIndex = 0;
            this.pbBig.TabStop = false;
            // 
            // mnuMain
            // 
            this.mnuMain.AutoSize = false;
            this.mnuMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.mnuMain.Dock = System.Windows.Forms.DockStyle.None;
            this.mnuMain.GripMargin = new System.Windows.Forms.Padding(2);
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAdministration,
            this.mnuProjects,
            this.mnuProcess,
            this.mnuViewUpdate,
            this.mnuReports});
            this.mnuMain.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.mnuMain.Location = new System.Drawing.Point(0, 94);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.mnuMain.Size = new System.Drawing.Size(250, 221);
            this.mnuMain.TabIndex = 7;
            this.mnuMain.Text = "mnuMain";
            // 
            // mnuAdministration
            // 
            this.mnuAdministration.AutoToolTip = true;
            this.mnuAdministration.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userManagementToolStripMenuItem});
            this.mnuAdministration.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuAdministration.ForeColor = System.Drawing.Color.White;
            this.mnuAdministration.Image = global::C1ILDGen.Properties.Resources.user_W_32;
            this.mnuAdministration.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnuAdministration.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuAdministration.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.mnuAdministration.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.mnuAdministration.Name = "mnuAdministration";
            this.mnuAdministration.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mnuAdministration.Size = new System.Drawing.Size(244, 36);
            this.mnuAdministration.Text = "   Administrartion";
            this.mnuAdministration.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnuAdministration.ToolTipText = "Administration";
            this.mnuAdministration.BackColorChanged += new System.EventHandler(this.mnuAdministration_BackColorChanged);
            this.mnuAdministration.Click += new System.EventHandler(this.mnuAdministration_Click);
            // 
            // userManagementToolStripMenuItem
            // 
            this.userManagementToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.userManagementToolStripMenuItem.Name = "userManagementToolStripMenuItem";
            this.userManagementToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.userManagementToolStripMenuItem.Text = "User Management";
            this.userManagementToolStripMenuItem.Click += new System.EventHandler(this.userManagementToolStripMenuItem_Click);
            // 
            // mnuProjects
            // 
            this.mnuProjects.AutoToolTip = true;
            this.mnuProjects.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projectNameToolStripMenuItem,
            this.appConfigToolStripMenuItem,
            this.instFormatToolStripMenuItem,
            this.legendsToolStripMenuItem,
            this.vendorListToolStripMenuItem,
            this.mappingPIDTagNumberToolStripMenuItem});
            this.mnuProjects.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuProjects.ForeColor = System.Drawing.Color.White;
            this.mnuProjects.Image = global::C1ILDGen.Properties.Resources.folder_W_32;
            this.mnuProjects.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnuProjects.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuProjects.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.mnuProjects.Name = "mnuProjects";
            this.mnuProjects.Size = new System.Drawing.Size(244, 36);
            this.mnuProjects.Text = "   Projects";
            this.mnuProjects.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnuProjects.ToolTipText = "Projects";
            this.mnuProjects.Click += new System.EventHandler(this.mnuProjects_Click);
            // 
            // projectNameToolStripMenuItem
            // 
            this.projectNameToolStripMenuItem.Name = "projectNameToolStripMenuItem";
            this.projectNameToolStripMenuItem.Size = new System.Drawing.Size(268, 26);
            this.projectNameToolStripMenuItem.Text = "Project Name";
            this.projectNameToolStripMenuItem.Click += new System.EventHandler(this.ProjectNameToolStripMenuItem_Click);
            // 
            // appConfigToolStripMenuItem
            // 
            this.appConfigToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.appConfigToolStripMenuItem.Name = "appConfigToolStripMenuItem";
            this.appConfigToolStripMenuItem.Size = new System.Drawing.Size(268, 26);
            this.appConfigToolStripMenuItem.Text = "App Config";
            this.appConfigToolStripMenuItem.Click += new System.EventHandler(this.appConfigToolStripMenuItem_Click);
            // 
            // instFormatToolStripMenuItem
            // 
            this.instFormatToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.instFormatToolStripMenuItem.Name = "instFormatToolStripMenuItem";
            this.instFormatToolStripMenuItem.Size = new System.Drawing.Size(268, 26);
            this.instFormatToolStripMenuItem.Text = "Discipline Filter";
            this.instFormatToolStripMenuItem.Click += new System.EventHandler(this.instFormatToolStripMenuItem_Click);
            // 
            // legendsToolStripMenuItem
            // 
            this.legendsToolStripMenuItem.Name = "legendsToolStripMenuItem";
            this.legendsToolStripMenuItem.Size = new System.Drawing.Size(268, 26);
            this.legendsToolStripMenuItem.Text = "Legends";
            this.legendsToolStripMenuItem.Click += new System.EventHandler(this.legendsToolStripMenuItem_Click);
            // 
            // vendorListToolStripMenuItem
            // 
            this.vendorListToolStripMenuItem.Name = "vendorListToolStripMenuItem";
            this.vendorListToolStripMenuItem.Size = new System.Drawing.Size(268, 26);
            this.vendorListToolStripMenuItem.Text = "Vendor List";
            this.vendorListToolStripMenuItem.Click += new System.EventHandler(this.vendorListToolStripMenuItem_Click);
            // 
            // mappingPIDTagNumberToolStripMenuItem
            // 
            this.mappingPIDTagNumberToolStripMenuItem.Name = "mappingPIDTagNumberToolStripMenuItem";
            this.mappingPIDTagNumberToolStripMenuItem.Size = new System.Drawing.Size(268, 26);
            this.mappingPIDTagNumberToolStripMenuItem.Text = "Mapping PID Tag Number";
            this.mappingPIDTagNumberToolStripMenuItem.Click += new System.EventHandler(this.mappingPIDTagNumberToolStripMenuItem_Click);
            // 
            // mnuProcess
            // 
            this.mnuProcess.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuProcessPID,
            this.mnuProcessJB});
            this.mnuProcess.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuProcess.ForeColor = System.Drawing.Color.White;
            this.mnuProcess.Image = global::C1ILDGen.Properties.Resources.folder_W_32;
            this.mnuProcess.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnuProcess.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuProcess.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.mnuProcess.Name = "mnuProcess";
            this.mnuProcess.Size = new System.Drawing.Size(244, 36);
            this.mnuProcess.Text = "   Process";
            this.mnuProcess.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnuProcess.ToolTipText = "Process";
            // 
            // mnuProcessPID
            // 
            this.mnuProcessPID.Name = "mnuProcessPID";
            this.mnuProcessPID.Size = new System.Drawing.Size(149, 26);
            this.mnuProcessPID.Text = "P&&ID";
            this.mnuProcessPID.Click += new System.EventHandler(this.mnuProcessPID_Click);
            // 
            // mnuProcessJB
            // 
            this.mnuProcessJB.Name = "mnuProcessJB";
            this.mnuProcessJB.Size = new System.Drawing.Size(149, 26);
            this.mnuProcessJB.Text = "JB Layout";
            this.mnuProcessJB.Click += new System.EventHandler(this.mnuProcessJB_Click);
            // 
            // mnuViewUpdate
            // 
            this.mnuViewUpdate.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuVUPID,
            this.iOListToolStripMenuItem,
            this.mnuVUJBSchedule});
            this.mnuViewUpdate.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuViewUpdate.ForeColor = System.Drawing.Color.White;
            this.mnuViewUpdate.Image = global::C1ILDGen.Properties.Resources.folder_W_32;
            this.mnuViewUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnuViewUpdate.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuViewUpdate.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.mnuViewUpdate.Name = "mnuViewUpdate";
            this.mnuViewUpdate.Size = new System.Drawing.Size(244, 36);
            this.mnuViewUpdate.Text = "   View && Update";
            this.mnuViewUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnuViewUpdate.ToolTipText = "View && Update";
            this.mnuViewUpdate.Click += new System.EventHandler(this.mnuViewUpdate_Click);
            // 
            // mnuVUPID
            // 
            this.mnuVUPID.Name = "mnuVUPID";
            this.mnuVUPID.Size = new System.Drawing.Size(205, 26);
            this.mnuVUPID.Text = "Instrument Index";
            this.mnuVUPID.Click += new System.EventHandler(this.mnuVUPID_Click);
            // 
            // iOListToolStripMenuItem
            // 
            this.iOListToolStripMenuItem.Name = "iOListToolStripMenuItem";
            this.iOListToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.iOListToolStripMenuItem.Text = "IO List";
            this.iOListToolStripMenuItem.Click += new System.EventHandler(this.iOListToolStripMenuItem_Click);
            // 
            // mnuVUJBSchedule
            // 
            this.mnuVUJBSchedule.Name = "mnuVUJBSchedule";
            this.mnuVUJBSchedule.Size = new System.Drawing.Size(205, 26);
            this.mnuVUJBSchedule.Text = "JB Schedule";
            this.mnuVUJBSchedule.Click += new System.EventHandler(this.mnuVUJBSchedule_Click);
            // 
            // mnuReports
            // 
            this.mnuReports.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.instrumentIndexToolStripMenuItem,
            this.iOListToolStripMenuItem1,
            this.jBScheduleToolStripMenuItem});
            this.mnuReports.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuReports.ForeColor = System.Drawing.Color.White;
            this.mnuReports.Image = global::C1ILDGen.Properties.Resources.chart_W_32;
            this.mnuReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnuReports.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuReports.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.mnuReports.Name = "mnuReports";
            this.mnuReports.Size = new System.Drawing.Size(244, 36);
            this.mnuReports.Text = "   Reports";
            this.mnuReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnuReports.ToolTipText = "Reports";
            this.mnuReports.Click += new System.EventHandler(this.mnuReports_Click);
            // 
            // instrumentIndexToolStripMenuItem
            // 
            this.instrumentIndexToolStripMenuItem.Name = "instrumentIndexToolStripMenuItem";
            this.instrumentIndexToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.instrumentIndexToolStripMenuItem.Text = "Instrument Index";
            this.instrumentIndexToolStripMenuItem.Click += new System.EventHandler(this.instrumentIndexToolStripMenuItem_Click);
            // 
            // iOListToolStripMenuItem1
            // 
            this.iOListToolStripMenuItem1.Name = "iOListToolStripMenuItem1";
            this.iOListToolStripMenuItem1.Size = new System.Drawing.Size(205, 26);
            this.iOListToolStripMenuItem1.Text = "IO List";
            this.iOListToolStripMenuItem1.Click += new System.EventHandler(this.iOListToolStripMenuItem1_Click);
            // 
            // jBScheduleToolStripMenuItem
            // 
            this.jBScheduleToolStripMenuItem.Name = "jBScheduleToolStripMenuItem";
            this.jBScheduleToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.jBScheduleToolStripMenuItem.Text = "JB Schedule";
            this.jBScheduleToolStripMenuItem.Click += new System.EventHandler(this.jBScheduleToolStripMenuItem_Click);
            // 
            // pnlTopMenu
            // 
            this.pnlTopMenu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlTopMenu.Controls.Add(this.lblUserName);
            this.pnlTopMenu.Controls.Add(this.pbUser);
            this.pnlTopMenu.Controls.Add(this.pbMinimizeButton);
            this.pnlTopMenu.Controls.Add(this.pbMaxButton);
            this.pnlTopMenu.Controls.Add(this.pbCloseButton);
            this.pnlTopMenu.Controls.Add(this.pbSlide);
            this.pnlTopMenu.Controls.Add(this.pbRestoreButton);
            this.pnlTopMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopMenu.Location = new System.Drawing.Point(250, 0);
            this.pnlTopMenu.Name = "pnlTopMenu";
            this.pnlTopMenu.Size = new System.Drawing.Size(1050, 50);
            this.pnlTopMenu.TabIndex = 1;
            this.pnlTopMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTopMenu_MouseDown);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(799, 16);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(43, 21);
            this.lblUserName.TabIndex = 6;
            this.lblUserName.Text = "User";
            // 
            // pbUser
            // 
            this.pbUser.Cursor = System.Windows.Forms.Cursors.Default;
            this.pbUser.Image = global::C1ILDGen.Properties.Resources.icon_user_32;
            this.pbUser.Location = new System.Drawing.Point(767, 12);
            this.pbUser.Name = "pbUser";
            this.pbUser.Size = new System.Drawing.Size(29, 28);
            this.pbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUser.TabIndex = 5;
            this.pbUser.TabStop = false;
            // 
            // pbMinimizeButton
            // 
            this.pbMinimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbMinimizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbMinimizeButton.Image = global::C1ILDGen.Properties.Resources.icon_Minimize;
            this.pbMinimizeButton.Location = new System.Drawing.Point(966, 12);
            this.pbMinimizeButton.Name = "pbMinimizeButton";
            this.pbMinimizeButton.Size = new System.Drawing.Size(20, 20);
            this.pbMinimizeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMinimizeButton.TabIndex = 4;
            this.pbMinimizeButton.TabStop = false;
            this.pbMinimizeButton.Click += new System.EventHandler(this.pbMinimizeButton_Click);
            // 
            // pbMaxButton
            // 
            this.pbMaxButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbMaxButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbMaxButton.Image = global::C1ILDGen.Properties.Resources.icon_Maximize;
            this.pbMaxButton.Location = new System.Drawing.Point(992, 12);
            this.pbMaxButton.Name = "pbMaxButton";
            this.pbMaxButton.Size = new System.Drawing.Size(20, 20);
            this.pbMaxButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMaxButton.TabIndex = 2;
            this.pbMaxButton.TabStop = false;
            this.pbMaxButton.Click += new System.EventHandler(this.pbMaxButton_Click);
            // 
            // pbCloseButton
            // 
            this.pbCloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbCloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCloseButton.Image = global::C1ILDGen.Properties.Resources.icon_close;
            this.pbCloseButton.Location = new System.Drawing.Point(1018, 12);
            this.pbCloseButton.Name = "pbCloseButton";
            this.pbCloseButton.Size = new System.Drawing.Size(20, 20);
            this.pbCloseButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCloseButton.TabIndex = 1;
            this.pbCloseButton.TabStop = false;
            this.pbCloseButton.Click += new System.EventHandler(this.pbCloseButton_Click);
            // 
            // pbSlide
            // 
            this.pbSlide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbSlide.Image = global::C1ILDGen.Properties.Resources.icon_Menu;
            this.pbSlide.Location = new System.Drawing.Point(6, 12);
            this.pbSlide.Name = "pbSlide";
            this.pbSlide.Size = new System.Drawing.Size(29, 28);
            this.pbSlide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSlide.TabIndex = 0;
            this.pbSlide.TabStop = false;
            this.pbSlide.Click += new System.EventHandler(this.pbSlide_Click);
            // 
            // pbRestoreButton
            // 
            this.pbRestoreButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbRestoreButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbRestoreButton.Image = global::C1ILDGen.Properties.Resources.icon_Restore;
            this.pbRestoreButton.Location = new System.Drawing.Point(992, 12);
            this.pbRestoreButton.Name = "pbRestoreButton";
            this.pbRestoreButton.Size = new System.Drawing.Size(20, 20);
            this.pbRestoreButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRestoreButton.TabIndex = 3;
            this.pbRestoreButton.TabStop = false;
            this.pbRestoreButton.Visible = false;
            this.pbRestoreButton.Click += new System.EventHandler(this.pbRestoreButton_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(250, 50);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1050, 600);
            this.pnlContent.TabIndex = 2;
            // 
            // ssMain
            // 
            this.ssMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatStripLbl1});
            this.ssMain.Location = new System.Drawing.Point(250, 628);
            this.ssMain.Name = "ssMain";
            this.ssMain.Size = new System.Drawing.Size(1050, 22);
            this.ssMain.TabIndex = 3;
            this.ssMain.Text = "statusStrip1";
            // 
            // StatStripLbl1
            // 
            this.StatStripLbl1.Name = "StatStripLbl1";
            this.StatStripLbl1.Size = new System.Drawing.Size(39, 17);
            this.StatStripLbl1.Text = "Ready";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.ssMain);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlTopMenu);
            this.Controls.Add(this.pnlLeftMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.mnuMain;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.pnlLeftMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbSmall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBig)).EndInit();
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.pnlTopMenu.ResumeLayout(false);
            this.pnlTopMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimizeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMaxButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCloseButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRestoreButton)).EndInit();
            this.ssMain.ResumeLayout(false);
            this.ssMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlLeftMenu;
        private System.Windows.Forms.Panel pnlTopMenu;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.PictureBox pbSlide;
        private System.Windows.Forms.PictureBox pbCloseButton;
        private System.Windows.Forms.PictureBox pbMinimizeButton;
        private System.Windows.Forms.PictureBox pbRestoreButton;
        private System.Windows.Forms.PictureBox pbMaxButton;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.PictureBox pbUser;
        public System.Windows.Forms.StatusStrip ssMain;
        public System.Windows.Forms.ToolStripStatusLabel StatStripLbl1;
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuAdministration;
        private System.Windows.Forms.ToolStripMenuItem mnuProcess;
        private System.Windows.Forms.ToolStripMenuItem mnuProcessPID;
        private System.Windows.Forms.ToolStripMenuItem mnuProcessJB;
        private System.Windows.Forms.ToolStripMenuItem mnuProjects;
        private System.Windows.Forms.ToolStripMenuItem mnuViewUpdate;
        private System.Windows.Forms.ToolStripMenuItem mnuVUPID;
        private System.Windows.Forms.ToolStripMenuItem mnuVUJBSchedule;
        private System.Windows.Forms.ToolStripMenuItem mnuReports;
        private System.Windows.Forms.PictureBox pbSmall;
        private System.Windows.Forms.PictureBox pbBig;
        private System.Windows.Forms.ToolStripMenuItem iOListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instrumentIndexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iOListToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem jBScheduleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem appConfigToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instFormatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem legendsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendorListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mappingPIDTagNumberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectNameToolStripMenuItem;
    }
}