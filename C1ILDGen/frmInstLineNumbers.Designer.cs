namespace C1ILDGen
{
    partial class frmInstLineNumbers
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
            this.btnClose = new System.Windows.Forms.Button();
            this.dgViewLNR = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlImport = new System.Windows.Forms.Panel();
            this.btnSaveToDB = new System.Windows.Forms.Button();
            this.btnRetreiveData = new System.Windows.Forms.Button();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.lblSelectFile = new System.Windows.Forms.Label();
            this.optImportLNR = new System.Windows.Forms.RadioButton();
            this.optViewLNR = new System.Windows.Forms.RadioButton();
            this.ofdImportExcel = new System.Windows.Forms.OpenFileDialog();
            this.dgExcelData = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewLNR)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlImport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgExcelData)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1267, 607);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgViewLNR
            // 
            this.dgViewLNR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgViewLNR.Location = new System.Drawing.Point(12, 71);
            this.dgViewLNR.Name = "dgViewLNR";
            this.dgViewLNR.RowTemplate.Height = 23;
            this.dgViewLNR.Size = new System.Drawing.Size(1330, 494);
            this.dgViewLNR.TabIndex = 1;
            this.dgViewLNR.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pnlImport);
            this.panel1.Controls.Add(this.optImportLNR);
            this.panel1.Controls.Add(this.optViewLNR);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1330, 43);
            this.panel1.TabIndex = 3;
            // 
            // pnlImport
            // 
            this.pnlImport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlImport.Controls.Add(this.btnSaveToDB);
            this.pnlImport.Controls.Add(this.btnRetreiveData);
            this.pnlImport.Controls.Add(this.btnSelectFile);
            this.pnlImport.Controls.Add(this.txtFilePath);
            this.pnlImport.Controls.Add(this.lblSelectFile);
            this.pnlImport.Location = new System.Drawing.Point(521, 3);
            this.pnlImport.Name = "pnlImport";
            this.pnlImport.Size = new System.Drawing.Size(793, 34);
            this.pnlImport.TabIndex = 6;
            this.pnlImport.Visible = false;
            // 
            // btnSaveToDB
            // 
            this.btnSaveToDB.Enabled = false;
            this.btnSaveToDB.Location = new System.Drawing.Point(708, 5);
            this.btnSaveToDB.Name = "btnSaveToDB";
            this.btnSaveToDB.Size = new System.Drawing.Size(75, 23);
            this.btnSaveToDB.TabIndex = 10;
            this.btnSaveToDB.Text = "Save To DB";
            this.btnSaveToDB.UseVisualStyleBackColor = true;
            this.btnSaveToDB.Click += new System.EventHandler(this.btnSaveToDB_Click);
            // 
            // btnRetreiveData
            // 
            this.btnRetreiveData.Location = new System.Drawing.Point(608, 5);
            this.btnRetreiveData.Name = "btnRetreiveData";
            this.btnRetreiveData.Size = new System.Drawing.Size(88, 23);
            this.btnRetreiveData.TabIndex = 9;
            this.btnRetreiveData.Text = "Retreive Data";
            this.btnRetreiveData.UseVisualStyleBackColor = true;
            this.btnRetreiveData.Click += new System.EventHandler(this.btnRetreiveData_Click);
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(521, 5);
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
            this.txtFilePath.Size = new System.Drawing.Size(440, 21);
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
            // optImportLNR
            // 
            this.optImportLNR.AutoSize = true;
            this.optImportLNR.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optImportLNR.Location = new System.Drawing.Point(336, 11);
            this.optImportLNR.Name = "optImportLNR";
            this.optImportLNR.Size = new System.Drawing.Size(170, 17);
            this.optImportLNR.TabIndex = 4;
            this.optImportLNR.TabStop = true;
            this.optImportLNR.Text = "Import New Line Numbers";
            this.optImportLNR.UseVisualStyleBackColor = true;
            this.optImportLNR.CheckedChanged += new System.EventHandler(this.optImportLNR_CheckedChanged);
            // 
            // optViewLNR
            // 
            this.optViewLNR.AutoSize = true;
            this.optViewLNR.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optViewLNR.Location = new System.Drawing.Point(18, 11);
            this.optViewLNR.Name = "optViewLNR";
            this.optViewLNR.Size = new System.Drawing.Size(194, 17);
            this.optViewLNR.TabIndex = 3;
            this.optViewLNR.TabStop = true;
            this.optViewLNR.Text = "View Existing Line Number List";
            this.optViewLNR.UseVisualStyleBackColor = true;
            this.optViewLNR.CheckedChanged += new System.EventHandler(this.optViewLNR_CheckedChanged);
            // 
            // ofdImportExcel
            // 
            this.ofdImportExcel.FileName = "Select File to Import";
            this.ofdImportExcel.Filter = "\"Excel Sheet(*.xls)|*.xls|Excel File(*.xlsx)|*.xlsx|All Files(*.*)|*.*\"";
            this.ofdImportExcel.FilterIndex = 2;
            this.ofdImportExcel.InitialDirectory = "D:\\";
            // 
            // dgExcelData
            // 
            this.dgExcelData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgExcelData.Location = new System.Drawing.Point(12, 71);
            this.dgExcelData.Name = "dgExcelData";
            this.dgExcelData.RowTemplate.Height = 23;
            this.dgExcelData.Size = new System.Drawing.Size(1330, 516);
            this.dgExcelData.TabIndex = 4;
            this.dgExcelData.Visible = false;
            // 
            // frmInstLineNumbers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 733);
            this.Controls.Add(this.dgExcelData);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgViewLNR);
            this.Controls.Add(this.btnClose);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInstLineNumbers";
            this.Text = "Instrument Line Numbers";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgViewLNR)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlImport.ResumeLayout(false);
            this.pnlImport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgExcelData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgViewLNR;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton optImportLNR;
        private System.Windows.Forms.RadioButton optViewLNR;
        private System.Windows.Forms.Panel pnlImport;
        private System.Windows.Forms.Label lblSelectFile;
        private System.Windows.Forms.Button btnSaveToDB;
        private System.Windows.Forms.Button btnRetreiveData;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.OpenFileDialog ofdImportExcel;
        private System.Windows.Forms.DataGridView dgExcelData;
    }
}