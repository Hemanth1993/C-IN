namespace C1ILDGen
{
    partial class frmProcessFile
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
            this.pnlProjectList = new System.Windows.Forms.Panel();
            this.tviewProjects = new System.Windows.Forms.TreeView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblProj = new System.Windows.Forms.Label();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.gbReadPID = new System.Windows.Forms.GroupBox();
            this.chkMultipleFiles = new System.Windows.Forms.CheckBox();
            this.btnClosegbPID = new System.Windows.Forms.Button();
            this.btnReadDWG = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCloseInstance = new System.Windows.Forms.Button();
            this.btnProgID = new System.Windows.Forms.Button();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.lblClose = new System.Windows.Forms.Label();
            this.bgWorker = new System.ComponentModel.BackgroundWorker();
            this.ofdDWG = new System.Windows.Forms.OpenFileDialog();
            this.fdDWG = new System.Windows.Forms.FolderBrowserDialog();
            this.pnlProjectList.SuspendLayout();
            this.pnlContainer.SuspendLayout();
            this.gbReadPID.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlProjectList
            // 
            this.pnlProjectList.Controls.Add(this.tviewProjects);
            this.pnlProjectList.Controls.Add(this.btnSearch);
            this.pnlProjectList.Controls.Add(this.txtSearch);
            this.pnlProjectList.Controls.Add(this.lblProj);
            this.pnlProjectList.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlProjectList.Location = new System.Drawing.Point(0, 0);
            this.pnlProjectList.Name = "pnlProjectList";
            this.pnlProjectList.Size = new System.Drawing.Size(225, 650);
            this.pnlProjectList.TabIndex = 2;
            // 
            // tviewProjects
            // 
            this.tviewProjects.Location = new System.Drawing.Point(12, 79);
            this.tviewProjects.Name = "tviewProjects";
            this.tviewProjects.Size = new System.Drawing.Size(201, 473);
            this.tviewProjects.TabIndex = 5;
            this.tviewProjects.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tviewProjects_AfterSelect);
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
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(12, 52);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(169, 20);
            this.txtSearch.TabIndex = 3;
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
            // pnlContainer
            // 
            this.pnlContainer.Controls.Add(this.gbReadPID);
            this.pnlContainer.Location = new System.Drawing.Point(231, 28);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(817, 596);
            this.pnlContainer.TabIndex = 4;
            // 
            // gbReadPID
            // 
            this.gbReadPID.BackColor = System.Drawing.SystemColors.Control;
            this.gbReadPID.Controls.Add(this.chkMultipleFiles);
            this.gbReadPID.Controls.Add(this.btnClosegbPID);
            this.gbReadPID.Controls.Add(this.btnReadDWG);
            this.gbReadPID.Controls.Add(this.btnClear);
            this.gbReadPID.Controls.Add(this.btnCloseInstance);
            this.gbReadPID.Controls.Add(this.btnProgID);
            this.gbReadPID.Controls.Add(this.btnSelectFile);
            this.gbReadPID.Controls.Add(this.txtFileName);
            this.gbReadPID.Controls.Add(this.txtLog);
            this.gbReadPID.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbReadPID.Location = new System.Drawing.Point(12, 12);
            this.gbReadPID.Name = "gbReadPID";
            this.gbReadPID.Size = new System.Drawing.Size(793, 512);
            this.gbReadPID.TabIndex = 16;
            this.gbReadPID.TabStop = false;
            this.gbReadPID.Text = "Read P&&ID";
            // 
            // chkMultipleFiles
            // 
            this.chkMultipleFiles.AutoSize = true;
            this.chkMultipleFiles.Location = new System.Drawing.Point(653, 22);
            this.chkMultipleFiles.Name = "chkMultipleFiles";
            this.chkMultipleFiles.Size = new System.Drawing.Size(99, 17);
            this.chkMultipleFiles.TabIndex = 19;
            this.chkMultipleFiles.Text = "Multiple Files";
            this.chkMultipleFiles.UseVisualStyleBackColor = true;
            this.chkMultipleFiles.CheckedChanged += new System.EventHandler(this.chkMultipleFiles_CheckedChanged);
            // 
            // btnClosegbPID
            // 
            this.btnClosegbPID.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClosegbPID.Location = new System.Drawing.Point(700, 466);
            this.btnClosegbPID.Name = "btnClosegbPID";
            this.btnClosegbPID.Size = new System.Drawing.Size(75, 23);
            this.btnClosegbPID.TabIndex = 18;
            this.btnClosegbPID.Text = "Close";
            this.btnClosegbPID.UseVisualStyleBackColor = true;
            this.btnClosegbPID.Click += new System.EventHandler(this.btnClosegbPID_Click);
            // 
            // btnReadDWG
            // 
            this.btnReadDWG.Enabled = false;
            this.btnReadDWG.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReadDWG.Location = new System.Drawing.Point(619, 466);
            this.btnReadDWG.Name = "btnReadDWG";
            this.btnReadDWG.Size = new System.Drawing.Size(75, 23);
            this.btnReadDWG.TabIndex = 17;
            this.btnReadDWG.Text = "Read DWG";
            this.btnReadDWG.UseVisualStyleBackColor = true;
            this.btnReadDWG.Click += new System.EventHandler(this.btnReadDWG_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(538, 466);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCloseInstance
            // 
            this.btnCloseInstance.Enabled = false;
            this.btnCloseInstance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseInstance.Location = new System.Drawing.Point(457, 466);
            this.btnCloseInstance.Name = "btnCloseInstance";
            this.btnCloseInstance.Size = new System.Drawing.Size(75, 23);
            this.btnCloseInstance.TabIndex = 15;
            this.btnCloseInstance.Text = "Close Insta";
            this.btnCloseInstance.UseVisualStyleBackColor = true;
            this.btnCloseInstance.Click += new System.EventHandler(this.btnCloseInstance_Click);
            // 
            // btnProgID
            // 
            this.btnProgID.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProgID.Location = new System.Drawing.Point(346, 466);
            this.btnProgID.Name = "btnProgID";
            this.btnProgID.Size = new System.Drawing.Size(105, 23);
            this.btnProgID.TabIndex = 14;
            this.btnProgID.Text = "Launch Process";
            this.btnProgID.UseVisualStyleBackColor = true;
            this.btnProgID.Click += new System.EventHandler(this.btnProgID_Click);
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectFile.Location = new System.Drawing.Point(548, 18);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(99, 23);
            this.btnSelectFile.TabIndex = 13;
            this.btnSelectFile.Text = "Select File";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // txtFileName
            // 
            this.txtFileName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFileName.Location = new System.Drawing.Point(6, 20);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(536, 21);
            this.txtFileName.TabIndex = 12;
            this.txtFileName.Text = "C:\\CEONE\\C-IN\\TestFiles\\GA&PID_Sample\\PID_5288-BUH-835-30-21.dwg";
            // 
            // txtLog
            // 
            this.txtLog.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLog.Location = new System.Drawing.Point(6, 47);
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(770, 401);
            this.txtLog.TabIndex = 11;
            this.txtLog.Text = "";
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblClose.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.Location = new System.Drawing.Point(1072, 0);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(17, 18);
            this.lblClose.TabIndex = 3;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // bgWorker
            // 
            this.bgWorker.WorkerReportsProgress = true;
            this.bgWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorker_DoWork);
            this.bgWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgWorker_ProgressChanged);
            this.bgWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWorker_RunWorkerCompleted);
            // 
            // ofdDWG
            // 
            this.ofdDWG.FileName = "openFileDialog1";
            // 
            // frmProcessFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 650);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.pnlProjectList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProcessFile";
            this.Text = "frmProcessFile";
            this.Load += new System.EventHandler(this.frmProcessFile_Load);
            this.pnlProjectList.ResumeLayout(false);
            this.pnlProjectList.PerformLayout();
            this.pnlContainer.ResumeLayout(false);
            this.gbReadPID.ResumeLayout(false);
            this.gbReadPID.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlProjectList;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblProj;
        private System.Windows.Forms.TreeView tviewProjects;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.GroupBox gbReadPID;
        private System.Windows.Forms.CheckBox chkMultipleFiles;
        private System.Windows.Forms.Button btnClosegbPID;
        private System.Windows.Forms.Button btnReadDWG;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCloseInstance;
        private System.Windows.Forms.Button btnProgID;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.RichTextBox txtLog;
        private System.ComponentModel.BackgroundWorker bgWorker;
        private System.Windows.Forms.OpenFileDialog ofdDWG;
        private System.Windows.Forms.FolderBrowserDialog fdDWG;
    }
}