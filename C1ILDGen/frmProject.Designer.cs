namespace C1ILDGen
{
    partial class frmProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProject));
            this.lblClose = new System.Windows.Forms.Label();
            this.pnlProjectList = new System.Windows.Forms.Panel();
            this.lvProj = new System.Windows.Forms.ListView();
            this.Projects = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imgListProj = new System.Windows.Forms.ImageList(this.components);
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnAddNewProj = new System.Windows.Forms.Button();
            this.lblProj = new System.Windows.Forms.Label();
            this.lblPID = new System.Windows.Forms.Label();
            this.lblPName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPID = new System.Windows.Forms.TextBox();
            this.txtPName = new System.Windows.Forms.TextBox();
            this.txtPDetails = new System.Windows.Forms.RichTextBox();
            this.txtSDetails = new System.Windows.Forms.RichTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlProjectList.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.lblClose.TabIndex = 0;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // pnlProjectList
            // 
            this.pnlProjectList.Controls.Add(this.lvProj);
            this.pnlProjectList.Controls.Add(this.btnSearch);
            this.pnlProjectList.Controls.Add(this.txtSearch);
            this.pnlProjectList.Controls.Add(this.btnAddNewProj);
            this.pnlProjectList.Controls.Add(this.lblProj);
            this.pnlProjectList.Location = new System.Drawing.Point(1, 0);
            this.pnlProjectList.Name = "pnlProjectList";
            this.pnlProjectList.Size = new System.Drawing.Size(225, 638);
            this.pnlProjectList.TabIndex = 1;
            // 
            // lvProj
            // 
            this.lvProj.BackColor = System.Drawing.Color.White;
            this.lvProj.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Projects});
            this.lvProj.FullRowSelect = true;
            this.lvProj.GridLines = true;
            this.lvProj.HideSelection = false;
            this.lvProj.Location = new System.Drawing.Point(12, 76);
            this.lvProj.MultiSelect = false;
            this.lvProj.Name = "lvProj";
            this.lvProj.Size = new System.Drawing.Size(201, 438);
            this.lvProj.SmallImageList = this.imgListProj;
            this.lvProj.TabIndex = 5;
            this.lvProj.UseCompatibleStateImageBehavior = false;
            this.lvProj.View = System.Windows.Forms.View.List;
            this.lvProj.SelectedIndexChanged += new System.EventHandler(this.lvProj_SelectedIndexChanged);
            // 
            // Projects
            // 
            this.Projects.Width = 150;
            // 
            // imgListProj
            // 
            this.imgListProj.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListProj.ImageStream")));
            this.imgListProj.TransparentColor = System.Drawing.Color.Transparent;
            this.imgListProj.Images.SetKeyName(0, "icon_pid1.png");
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
            this.txtSearch.Size = new System.Drawing.Size(169, 23);
            this.txtSearch.TabIndex = 3;
            // 
            // btnAddNewProj
            // 
            this.btnAddNewProj.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewProj.Location = new System.Drawing.Point(11, 520);
            this.btnAddNewProj.Name = "btnAddNewProj";
            this.btnAddNewProj.Size = new System.Drawing.Size(202, 26);
            this.btnAddNewProj.TabIndex = 2;
            this.btnAddNewProj.Text = "Add New Project";
            this.btnAddNewProj.UseVisualStyleBackColor = true;
            this.btnAddNewProj.Click += new System.EventHandler(this.btnAddNewProj_Click);
            // 
            // lblProj
            // 
            this.lblProj.AutoSize = true;
            this.lblProj.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProj.Location = new System.Drawing.Point(12, 28);
            this.lblProj.Name = "lblProj";
            this.lblProj.Size = new System.Drawing.Size(82, 16);
            this.lblProj.TabIndex = 0;
            this.lblProj.Text = "Project List";
            // 
            // lblPID
            // 
            this.lblPID.AutoSize = true;
            this.lblPID.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPID.Location = new System.Drawing.Point(42, 67);
            this.lblPID.Name = "lblPID";
            this.lblPID.Size = new System.Drawing.Size(69, 16);
            this.lblPID.TabIndex = 0;
            this.lblPID.Text = "Project ID:";
            // 
            // lblPName
            // 
            this.lblPName.AutoSize = true;
            this.lblPName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPName.Location = new System.Drawing.Point(42, 104);
            this.lblPName.Name = "lblPName";
            this.lblPName.Size = new System.Drawing.Size(90, 16);
            this.lblPName.TabIndex = 1;
            this.lblPName.Text = "Project Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Project Details:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Site Details:";
            // 
            // txtPID
            // 
            this.txtPID.Enabled = false;
            this.txtPID.Location = new System.Drawing.Point(154, 64);
            this.txtPID.Name = "txtPID";
            this.txtPID.Size = new System.Drawing.Size(156, 23);
            this.txtPID.TabIndex = 4;
            // 
            // txtPName
            // 
            this.txtPName.Location = new System.Drawing.Point(154, 101);
            this.txtPName.Name = "txtPName";
            this.txtPName.Size = new System.Drawing.Size(442, 23);
            this.txtPName.TabIndex = 5;
            // 
            // txtPDetails
            // 
            this.txtPDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPDetails.Location = new System.Drawing.Point(155, 139);
            this.txtPDetails.Name = "txtPDetails";
            this.txtPDetails.Size = new System.Drawing.Size(441, 53);
            this.txtPDetails.TabIndex = 6;
            this.txtPDetails.Text = "";
            // 
            // txtSDetails
            // 
            this.txtSDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSDetails.Location = new System.Drawing.Point(155, 207);
            this.txtSDetails.Name = "txtSDetails";
            this.txtSDetails.Size = new System.Drawing.Size(441, 53);
            this.txtSDetails.TabIndex = 7;
            this.txtSDetails.Text = "";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(521, 278);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(440, 278);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.txtSDetails);
            this.panel1.Controls.Add(this.txtPDetails);
            this.panel1.Controls.Add(this.txtPName);
            this.panel1.Controls.Add(this.txtPID);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblPName);
            this.panel1.Controls.Add(this.lblPID);
            this.panel1.Location = new System.Drawing.Point(231, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(957, 610);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // frmProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1200, 650);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlProjectList);
            this.Controls.Add(this.lblClose);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmProject";
            this.Text = "frmTest";
            this.Load += new System.EventHandler(this.frmProject_Load);
            this.pnlProjectList.ResumeLayout(false);
            this.pnlProjectList.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Panel pnlProjectList;
        private System.Windows.Forms.Label lblProj;
        private System.Windows.Forms.Button btnAddNewProj;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ListView lvProj;
        private System.Windows.Forms.ColumnHeader Projects;
        private System.Windows.Forms.ImageList imgListProj;
        private System.Windows.Forms.Label lblPID;
        private System.Windows.Forms.Label lblPName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPID;
        private System.Windows.Forms.TextBox txtPName;
        private System.Windows.Forms.RichTextBox txtPDetails;
        private System.Windows.Forms.RichTextBox txtSDetails;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panel1;
    }
}