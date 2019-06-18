namespace C1ILDGen
{
    partial class frmUsers
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsers));
            this.pnlData = new System.Windows.Forms.Panel();
            this.lblAProjs = new System.Windows.Forms.Label();
            this.lblUAProjs = new System.Windows.Forms.Label();
            this.btnOneBackward = new System.Windows.Forms.Button();
            this.btnAllBackward = new System.Windows.Forms.Button();
            this.btnAllForward = new System.Windows.Forms.Button();
            this.btnOneForward = new System.Windows.Forms.Button();
            this.lblNewProj = new System.Windows.Forms.Label();
            this.lbAssignedProj = new System.Windows.Forms.ListBox();
            this.lbNewProject = new System.Windows.Forms.ListBox();
            this.pnlStatus = new System.Windows.Forms.Panel();
            this.optInactive = new System.Windows.Forms.RadioButton();
            this.optActive = new System.Windows.Forms.RadioButton();
            this.pnlRole = new System.Windows.Forms.Panel();
            this.optEngineer = new System.Windows.Forms.RadioButton();
            this.optAdmin = new System.Windows.Forms.RadioButton();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPWD = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLName = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblFName = new System.Windows.Forms.Label();
            this.lblUID = new System.Windows.Forms.Label();
            this.pnlProjectList = new System.Windows.Forms.Panel();
            this.lvUser = new System.Windows.Forms.ListView();
            this.Projects = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imgListUser = new System.Windows.Forms.ImageList(this.components);
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnAddNewUser = new System.Windows.Forms.Button();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.pnlData.SuspendLayout();
            this.pnlStatus.SuspendLayout();
            this.pnlRole.SuspendLayout();
            this.pnlProjectList.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlData
            // 
            this.pnlData.Controls.Add(this.lblAProjs);
            this.pnlData.Controls.Add(this.lblUAProjs);
            this.pnlData.Controls.Add(this.btnOneBackward);
            this.pnlData.Controls.Add(this.btnAllBackward);
            this.pnlData.Controls.Add(this.btnAllForward);
            this.pnlData.Controls.Add(this.btnOneForward);
            this.pnlData.Controls.Add(this.lblNewProj);
            this.pnlData.Controls.Add(this.lbAssignedProj);
            this.pnlData.Controls.Add(this.lbNewProject);
            this.pnlData.Controls.Add(this.pnlStatus);
            this.pnlData.Controls.Add(this.pnlRole);
            this.pnlData.Controls.Add(this.txtPassword);
            this.pnlData.Controls.Add(this.lblPWD);
            this.pnlData.Controls.Add(this.txtLastName);
            this.pnlData.Controls.Add(this.lblLName);
            this.pnlData.Controls.Add(this.btnCancel);
            this.pnlData.Controls.Add(this.btnSave);
            this.pnlData.Controls.Add(this.txtFirstName);
            this.pnlData.Controls.Add(this.txtUserID);
            this.pnlData.Controls.Add(this.lblStatus);
            this.pnlData.Controls.Add(this.lblRole);
            this.pnlData.Controls.Add(this.lblFName);
            this.pnlData.Controls.Add(this.lblUID);
            this.pnlData.Location = new System.Drawing.Point(237, 34);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(957, 610);
            this.pnlData.TabIndex = 4;
            // 
            // lblAProjs
            // 
            this.lblAProjs.AutoSize = true;
            this.lblAProjs.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAProjs.Location = new System.Drawing.Point(409, 251);
            this.lblAProjs.Name = "lblAProjs";
            this.lblAProjs.Size = new System.Drawing.Size(109, 16);
            this.lblAProjs.TabIndex = 24;
            this.lblAProjs.Text = "Assigned Projects";
            // 
            // lblUAProjs
            // 
            this.lblUAProjs.AutoSize = true;
            this.lblUAProjs.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUAProjs.Location = new System.Drawing.Point(154, 251);
            this.lblUAProjs.Name = "lblUAProjs";
            this.lblUAProjs.Size = new System.Drawing.Size(129, 16);
            this.lblUAProjs.TabIndex = 23;
            this.lblUAProjs.Text = "Un-Assigned Projects";
            // 
            // btnOneBackward
            // 
            this.btnOneBackward.Location = new System.Drawing.Point(357, 402);
            this.btnOneBackward.Name = "btnOneBackward";
            this.btnOneBackward.Size = new System.Drawing.Size(41, 26);
            this.btnOneBackward.TabIndex = 22;
            this.btnOneBackward.Text = "<";
            this.btnOneBackward.UseVisualStyleBackColor = true;
            this.btnOneBackward.Click += new System.EventHandler(this.btnOneBackward_Click);
            // 
            // btnAllBackward
            // 
            this.btnAllBackward.Location = new System.Drawing.Point(357, 370);
            this.btnAllBackward.Name = "btnAllBackward";
            this.btnAllBackward.Size = new System.Drawing.Size(41, 26);
            this.btnAllBackward.TabIndex = 21;
            this.btnAllBackward.Text = "<<";
            this.btnAllBackward.UseVisualStyleBackColor = true;
            this.btnAllBackward.Click += new System.EventHandler(this.btnAllBackward_Click);
            // 
            // btnAllForward
            // 
            this.btnAllForward.Location = new System.Drawing.Point(357, 338);
            this.btnAllForward.Name = "btnAllForward";
            this.btnAllForward.Size = new System.Drawing.Size(41, 26);
            this.btnAllForward.TabIndex = 20;
            this.btnAllForward.Text = ">>";
            this.btnAllForward.UseVisualStyleBackColor = true;
            this.btnAllForward.Click += new System.EventHandler(this.btnAllForward_Click);
            // 
            // btnOneForward
            // 
            this.btnOneForward.Location = new System.Drawing.Point(357, 306);
            this.btnOneForward.Name = "btnOneForward";
            this.btnOneForward.Size = new System.Drawing.Size(41, 26);
            this.btnOneForward.TabIndex = 19;
            this.btnOneForward.Text = ">";
            this.btnOneForward.UseVisualStyleBackColor = true;
            this.btnOneForward.Click += new System.EventHandler(this.btnOneForward_Click);
            // 
            // lblNewProj
            // 
            this.lblNewProj.AutoSize = true;
            this.lblNewProj.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewProj.Location = new System.Drawing.Point(44, 251);
            this.lblNewProj.Name = "lblNewProj";
            this.lblNewProj.Size = new System.Drawing.Size(76, 16);
            this.lblNewProj.TabIndex = 18;
            this.lblNewProj.Text = "Project List:";
            // 
            // lbAssignedProj
            // 
            this.lbAssignedProj.FormattingEnabled = true;
            this.lbAssignedProj.Location = new System.Drawing.Point(412, 272);
            this.lbAssignedProj.Name = "lbAssignedProj";
            this.lbAssignedProj.Size = new System.Drawing.Size(185, 199);
            this.lbAssignedProj.TabIndex = 17;
            // 
            // lbNewProject
            // 
            this.lbNewProject.FormattingEnabled = true;
            this.lbNewProject.Location = new System.Drawing.Point(157, 272);
            this.lbNewProject.Name = "lbNewProject";
            this.lbNewProject.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbNewProject.Size = new System.Drawing.Size(185, 199);
            this.lbNewProject.TabIndex = 16;
            // 
            // pnlStatus
            // 
            this.pnlStatus.Controls.Add(this.optInactive);
            this.pnlStatus.Controls.Add(this.optActive);
            this.pnlStatus.Location = new System.Drawing.Point(157, 211);
            this.pnlStatus.Name = "pnlStatus";
            this.pnlStatus.Size = new System.Drawing.Size(440, 26);
            this.pnlStatus.TabIndex = 15;
            // 
            // optInactive
            // 
            this.optInactive.AutoSize = true;
            this.optInactive.Location = new System.Drawing.Point(121, 4);
            this.optInactive.Name = "optInactive";
            this.optInactive.Size = new System.Drawing.Size(64, 17);
            this.optInactive.TabIndex = 1;
            this.optInactive.Text = "Inactive";
            this.optInactive.UseVisualStyleBackColor = true;
            // 
            // optActive
            // 
            this.optActive.AutoSize = true;
            this.optActive.Checked = true;
            this.optActive.Location = new System.Drawing.Point(12, 4);
            this.optActive.Name = "optActive";
            this.optActive.Size = new System.Drawing.Size(55, 17);
            this.optActive.TabIndex = 0;
            this.optActive.TabStop = true;
            this.optActive.Text = "Active";
            this.optActive.UseVisualStyleBackColor = true;
            // 
            // pnlRole
            // 
            this.pnlRole.Controls.Add(this.optEngineer);
            this.pnlRole.Controls.Add(this.optAdmin);
            this.pnlRole.Location = new System.Drawing.Point(157, 175);
            this.pnlRole.Name = "pnlRole";
            this.pnlRole.Size = new System.Drawing.Size(440, 26);
            this.pnlRole.TabIndex = 14;
            // 
            // optEngineer
            // 
            this.optEngineer.AutoSize = true;
            this.optEngineer.Location = new System.Drawing.Point(121, 4);
            this.optEngineer.Name = "optEngineer";
            this.optEngineer.Size = new System.Drawing.Size(67, 17);
            this.optEngineer.TabIndex = 1;
            this.optEngineer.Text = "Engineer";
            this.optEngineer.UseVisualStyleBackColor = true;
            // 
            // optAdmin
            // 
            this.optAdmin.AutoSize = true;
            this.optAdmin.Checked = true;
            this.optAdmin.Location = new System.Drawing.Point(12, 4);
            this.optAdmin.Name = "optAdmin";
            this.optAdmin.Size = new System.Drawing.Size(89, 17);
            this.optAdmin.TabIndex = 0;
            this.optAdmin.TabStop = true;
            this.optAdmin.Text = "Administrator";
            this.optAdmin.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(155, 142);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(442, 21);
            this.txtPassword.TabIndex = 4;
            // 
            // lblPWD
            // 
            this.lblPWD.AutoSize = true;
            this.lblPWD.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPWD.Location = new System.Drawing.Point(44, 147);
            this.lblPWD.Name = "lblPWD";
            this.lblPWD.Size = new System.Drawing.Size(68, 16);
            this.lblPWD.TabIndex = 12;
            this.lblPWD.Text = "Password:";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(155, 78);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(442, 21);
            this.txtLastName.TabIndex = 2;
            this.txtLastName.Leave += new System.EventHandler(this.txtLastName_Leave);
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLName.Location = new System.Drawing.Point(43, 83);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(73, 16);
            this.lblLName.TabIndex = 10;
            this.lblLName.Text = "Last Name:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(441, 492);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(522, 492);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(155, 48);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(442, 21);
            this.txtFirstName.TabIndex = 1;
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(155, 110);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(442, 21);
            this.txtUserID.TabIndex = 3;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(43, 211);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(49, 16);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "Status:";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.Location = new System.Drawing.Point(44, 179);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(38, 16);
            this.lblRole.TabIndex = 2;
            this.lblRole.Text = "Role:";
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFName.Location = new System.Drawing.Point(43, 51);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(75, 16);
            this.lblFName.TabIndex = 1;
            this.lblFName.Text = "First Name:";
            // 
            // lblUID
            // 
            this.lblUID.AutoSize = true;
            this.lblUID.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUID.Location = new System.Drawing.Point(44, 115);
            this.lblUID.Name = "lblUID";
            this.lblUID.Size = new System.Drawing.Size(55, 16);
            this.lblUID.TabIndex = 0;
            this.lblUID.Text = "User ID:";
            // 
            // pnlProjectList
            // 
            this.pnlProjectList.Controls.Add(this.lvUser);
            this.pnlProjectList.Controls.Add(this.btnSearch);
            this.pnlProjectList.Controls.Add(this.txtSearch);
            this.pnlProjectList.Controls.Add(this.btnAddNewUser);
            this.pnlProjectList.Controls.Add(this.lblUser);
            this.pnlProjectList.Location = new System.Drawing.Point(7, 6);
            this.pnlProjectList.Name = "pnlProjectList";
            this.pnlProjectList.Size = new System.Drawing.Size(225, 638);
            this.pnlProjectList.TabIndex = 3;
            // 
            // lvUser
            // 
            this.lvUser.BackColor = System.Drawing.Color.White;
            this.lvUser.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Projects});
            this.lvUser.FullRowSelect = true;
            this.lvUser.GridLines = true;
            this.lvUser.Location = new System.Drawing.Point(12, 76);
            this.lvUser.MultiSelect = false;
            this.lvUser.Name = "lvUser";
            this.lvUser.ShowItemToolTips = true;
            this.lvUser.Size = new System.Drawing.Size(201, 438);
            this.lvUser.SmallImageList = this.imgListUser;
            this.lvUser.TabIndex = 5;
            this.lvUser.UseCompatibleStateImageBehavior = false;
            this.lvUser.View = System.Windows.Forms.View.List;
            this.lvUser.SelectedIndexChanged += new System.EventHandler(this.lvUser_SelectedIndexChanged);
            // 
            // Projects
            // 
            this.Projects.Width = 150;
            // 
            // imgListUser
            // 
            this.imgListUser.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListUser.ImageStream")));
            this.imgListUser.TransparentColor = System.Drawing.Color.Transparent;
            this.imgListUser.Images.SetKeyName(0, "icon_user.png");
            // 
            // btnSearch
            // 
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Image = global::C1ILDGen.Properties.Resources.icon_Search;
            this.btnSearch.Location = new System.Drawing.Point(181, 51);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(32, 25);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(12, 52);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(169, 21);
            this.txtSearch.TabIndex = 3;
            // 
            // btnAddNewUser
            // 
            this.btnAddNewUser.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewUser.Location = new System.Drawing.Point(11, 520);
            this.btnAddNewUser.Name = "btnAddNewUser";
            this.btnAddNewUser.Size = new System.Drawing.Size(202, 26);
            this.btnAddNewUser.TabIndex = 2;
            this.btnAddNewUser.Text = "Add User";
            this.btnAddNewUser.UseVisualStyleBackColor = true;
            this.btnAddNewUser.Click += new System.EventHandler(this.btnAddNewUser_Click);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(12, 28);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(64, 16);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "User List";
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblClose.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.Location = new System.Drawing.Point(1183, 0);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(17, 18);
            this.lblClose.TabIndex = 5;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // frmUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 650);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.pnlData);
            this.Controls.Add(this.pnlProjectList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUsers";
            this.Text = "frmUsers";
            this.Load += new System.EventHandler(this.frmUsers_Load);
            this.pnlData.ResumeLayout(false);
            this.pnlData.PerformLayout();
            this.pnlStatus.ResumeLayout(false);
            this.pnlStatus.PerformLayout();
            this.pnlRole.ResumeLayout(false);
            this.pnlRole.PerformLayout();
            this.pnlProjectList.ResumeLayout(false);
            this.pnlProjectList.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlData;
        private System.Windows.Forms.Panel pnlRole;
        private System.Windows.Forms.RadioButton optAdmin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPWD;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.Label lblUID;
        private System.Windows.Forms.Panel pnlProjectList;
        private System.Windows.Forms.ListView lvUser;
        private System.Windows.Forms.ColumnHeader Projects;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnAddNewUser;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Panel pnlStatus;
        private System.Windows.Forms.RadioButton optInactive;
        private System.Windows.Forms.RadioButton optActive;
        private System.Windows.Forms.RadioButton optEngineer;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.ImageList imgListUser;
        private System.Windows.Forms.ListBox lbNewProject;
        private System.Windows.Forms.Label lblNewProj;
        private System.Windows.Forms.ListBox lbAssignedProj;
        private System.Windows.Forms.Button btnOneBackward;
        private System.Windows.Forms.Button btnAllBackward;
        private System.Windows.Forms.Button btnAllForward;
        private System.Windows.Forms.Button btnOneForward;
        private System.Windows.Forms.Label lblUAProjs;
        private System.Windows.Forms.Label lblAProjs;
    }
}