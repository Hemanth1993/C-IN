namespace C1ILDGen
{
    partial class frmAppConfig
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
            this.dgAppConfig = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.gbConfig = new System.Windows.Forms.GroupBox();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.lblValue = new System.Windows.Forms.Label();
            this.lblKey = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblClose = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgAppConfig)).BeginInit();
            this.gbConfig.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgAppConfig
            // 
            this.dgAppConfig.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAppConfig.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgAppConfig.Location = new System.Drawing.Point(27, 36);
            this.dgAppConfig.Name = "dgAppConfig";
            this.dgAppConfig.RowTemplate.Height = 23;
            this.dgAppConfig.Size = new System.Drawing.Size(639, 461);
            this.dgAppConfig.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Key";
            this.Column1.Name = "Column1";
            this.Column1.Width = 200;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Value";
            this.Column2.Name = "Column2";
            this.Column2.Width = 500;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Current Application Configuration List:";
            // 
            // gbConfig
            // 
            this.gbConfig.Controls.Add(this.btnAddNew);
            this.gbConfig.Controls.Add(this.txtValue);
            this.gbConfig.Controls.Add(this.txtKey);
            this.gbConfig.Controls.Add(this.lblValue);
            this.gbConfig.Controls.Add(this.lblKey);
            this.gbConfig.Location = new System.Drawing.Point(672, 36);
            this.gbConfig.Name = "gbConfig";
            this.gbConfig.Size = new System.Drawing.Size(336, 159);
            this.gbConfig.TabIndex = 5;
            this.gbConfig.TabStop = false;
            this.gbConfig.Text = "Key Value Details";
            // 
            // btnAddNew
            // 
            this.btnAddNew.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew.Location = new System.Drawing.Point(212, 113);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(102, 23);
            this.btnAddNew.TabIndex = 6;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(62, 70);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(252, 20);
            this.txtValue.TabIndex = 5;
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(62, 29);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(252, 20);
            this.txtKey.TabIndex = 4;
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(16, 73);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(40, 13);
            this.lblValue.TabIndex = 2;
            this.lblValue.Text = "Value: ";
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.Location = new System.Drawing.Point(16, 32);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(31, 13);
            this.lblKey.TabIndex = 1;
            this.lblKey.Text = "Key: ";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(564, 503);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(102, 23);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblClose.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.Location = new System.Drawing.Point(1010, 0);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(17, 18);
            this.lblClose.TabIndex = 9;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // frmAppConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 554);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.gbConfig);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgAppConfig);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAppConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmAppConfig";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmAppConfig_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgAppConfig)).EndInit();
            this.gbConfig.ResumeLayout(false);
            this.gbConfig.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgAppConfig;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbConfig;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblClose;
    }
}