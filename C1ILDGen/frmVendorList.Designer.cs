namespace C1ILDGen
{
    partial class frmVendorList
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
            this.dgExcelData = new System.Windows.Forms.DataGridView();
            this.pnlOptions = new System.Windows.Forms.Panel();
            this.pnlImport = new System.Windows.Forms.Panel();
            this.btnSaveToDB = new System.Windows.Forms.Button();
            this.btnRetreiveData = new System.Windows.Forms.Button();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.lblSelectFile = new System.Windows.Forms.Label();
            this.optImportVL = new System.Windows.Forms.RadioButton();
            this.optViewVL = new System.Windows.Forms.RadioButton();
            this.dgViewVL = new System.Windows.Forms.DataGridView();
            this.ofdImportExcel = new System.Windows.Forms.OpenFileDialog();
            this.lblClose = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgExcelData)).BeginInit();
            this.pnlOptions.SuspendLayout();
            this.pnlImport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewVL)).BeginInit();
            this.SuspendLayout();
            // 
            // dgExcelData
            // 
            this.dgExcelData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgExcelData.Location = new System.Drawing.Point(12, 95);
            this.dgExcelData.Name = "dgExcelData";
            this.dgExcelData.RowTemplate.Height = 23;
            this.dgExcelData.Size = new System.Drawing.Size(1006, 382);
            this.dgExcelData.TabIndex = 7;
            this.dgExcelData.Visible = false;
            // 
            // pnlOptions
            // 
            this.pnlOptions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlOptions.Controls.Add(this.pnlImport);
            this.pnlOptions.Controls.Add(this.optImportVL);
            this.pnlOptions.Controls.Add(this.optViewVL);
            this.pnlOptions.Location = new System.Drawing.Point(12, 36);
            this.pnlOptions.Name = "pnlOptions";
            this.pnlOptions.Size = new System.Drawing.Size(1006, 43);
            this.pnlOptions.TabIndex = 6;
            // 
            // pnlImport
            // 
            this.pnlImport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlImport.Controls.Add(this.btnSaveToDB);
            this.pnlImport.Controls.Add(this.btnRetreiveData);
            this.pnlImport.Controls.Add(this.btnSelectFile);
            this.pnlImport.Controls.Add(this.txtFilePath);
            this.pnlImport.Controls.Add(this.lblSelectFile);
            this.pnlImport.Location = new System.Drawing.Point(332, 3);
            this.pnlImport.Name = "pnlImport";
            this.pnlImport.Size = new System.Drawing.Size(668, 34);
            this.pnlImport.TabIndex = 6;
            this.pnlImport.Visible = false;
            // 
            // btnSaveToDB
            // 
            this.btnSaveToDB.Enabled = false;
            this.btnSaveToDB.Location = new System.Drawing.Point(581, 5);
            this.btnSaveToDB.Name = "btnSaveToDB";
            this.btnSaveToDB.Size = new System.Drawing.Size(75, 23);
            this.btnSaveToDB.TabIndex = 10;
            this.btnSaveToDB.Text = "Save To DB";
            this.btnSaveToDB.UseVisualStyleBackColor = true;
            this.btnSaveToDB.Click += new System.EventHandler(this.btnSaveToDB_Click);
            // 
            // btnRetreiveData
            // 
            this.btnRetreiveData.Location = new System.Drawing.Point(487, 5);
            this.btnRetreiveData.Name = "btnRetreiveData";
            this.btnRetreiveData.Size = new System.Drawing.Size(88, 23);
            this.btnRetreiveData.TabIndex = 9;
            this.btnRetreiveData.Text = "Retreive Data";
            this.btnRetreiveData.UseVisualStyleBackColor = true;
            this.btnRetreiveData.Click += new System.EventHandler(this.btnRetreiveData_Click);
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(408, 5);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(75, 23);
            this.btnSelectFile.TabIndex = 8;
            this.btnSelectFile.Text = "Select File";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(81, 6);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(321, 21);
            this.txtFilePath.TabIndex = 7;
            // 
            // lblSelectFile
            // 
            this.lblSelectFile.AutoSize = true;
            this.lblSelectFile.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectFile.Location = new System.Drawing.Point(8, 10);
            this.lblSelectFile.Name = "lblSelectFile";
            this.lblSelectFile.Size = new System.Drawing.Size(67, 13);
            this.lblSelectFile.TabIndex = 6;
            this.lblSelectFile.Text = "Select File:";
            // 
            // optImportVL
            // 
            this.optImportVL.AutoSize = true;
            this.optImportVL.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optImportVL.Location = new System.Drawing.Point(195, 11);
            this.optImportVL.Name = "optImportVL";
            this.optImportVL.Size = new System.Drawing.Size(131, 17);
            this.optImportVL.TabIndex = 4;
            this.optImportVL.TabStop = true;
            this.optImportVL.Text = "Import Vendor List";
            this.optImportVL.UseVisualStyleBackColor = true;
            this.optImportVL.CheckedChanged += new System.EventHandler(this.optImportVL_CheckedChanged);
            // 
            // optViewVL
            // 
            this.optViewVL.AutoSize = true;
            this.optViewVL.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optViewVL.Location = new System.Drawing.Point(18, 11);
            this.optViewVL.Name = "optViewVL";
            this.optViewVL.Size = new System.Drawing.Size(164, 17);
            this.optViewVL.TabIndex = 3;
            this.optViewVL.TabStop = true;
            this.optViewVL.Text = "View Existing Vendor List";
            this.optViewVL.UseVisualStyleBackColor = true;
            this.optViewVL.CheckedChanged += new System.EventHandler(this.optViewVL_CheckedChanged);
            // 
            // dgViewVL
            // 
            this.dgViewVL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgViewVL.Location = new System.Drawing.Point(12, 95);
            this.dgViewVL.Name = "dgViewVL";
            this.dgViewVL.RowTemplate.Height = 23;
            this.dgViewVL.Size = new System.Drawing.Size(1006, 382);
            this.dgViewVL.TabIndex = 8;
            this.dgViewVL.Visible = false;
            // 
            // ofdImportExcel
            // 
            this.ofdImportExcel.FileName = "Select File to Import";
            this.ofdImportExcel.Filter = "\"Excel Sheet(*.xls)|*.xls|Excel File(*.xlsx)|*.xlsx|All Files(*.*)|*.*\"";
            this.ofdImportExcel.FilterIndex = 2;
            this.ofdImportExcel.InitialDirectory = "D:\\";
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblClose.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.Location = new System.Drawing.Point(1063, 0);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(17, 18);
            this.lblClose.TabIndex = 9;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // frmVendorList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 521);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.dgViewVL);
            this.Controls.Add(this.dgExcelData);
            this.Controls.Add(this.pnlOptions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmVendorList";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgExcelData)).EndInit();
            this.pnlOptions.ResumeLayout(false);
            this.pnlOptions.PerformLayout();
            this.pnlImport.ResumeLayout(false);
            this.pnlImport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewVL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgExcelData;
        private System.Windows.Forms.Panel pnlOptions;
        private System.Windows.Forms.Panel pnlImport;
        private System.Windows.Forms.Button btnSaveToDB;
        private System.Windows.Forms.Button btnRetreiveData;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Label lblSelectFile;
        private System.Windows.Forms.RadioButton optImportVL;
        private System.Windows.Forms.RadioButton optViewVL;
        private System.Windows.Forms.DataGridView dgViewVL;
        private System.Windows.Forms.OpenFileDialog ofdImportExcel;
        private System.Windows.Forms.Label lblClose;
    }
}