namespace C1ILDGen
{
    partial class frmViewUpdateInstIndex
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
            this.gbInstIndex = new System.Windows.Forms.GroupBox();
            this.dgTags = new System.Windows.Forms.DataGridView();
            this.tviewList = new System.Windows.Forms.TreeView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboExtractList = new System.Windows.Forms.ComboBox();
            this.cboMake = new System.Windows.Forms.ComboBox();
            this.btnCloseInstIdx = new System.Windows.Forms.Button();
            this.btnClearDG = new System.Windows.Forms.Button();
            this.cboPIDList = new System.Windows.Forms.ComboBox();
            this.lblPIDList = new System.Windows.Forms.Label();
            this.btnExpToExcel = new System.Windows.Forms.Button();
            this.btnGetTagData = new System.Windows.Forms.Button();
            this.cboLineNr = new System.Windows.Forms.ComboBox();
            this.gbInstIndex.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTags)).BeginInit();
            this.SuspendLayout();
            // 
            // gbInstIndex
            // 
            this.gbInstIndex.Controls.Add(this.dgTags);
            this.gbInstIndex.Controls.Add(this.tviewList);
            this.gbInstIndex.Controls.Add(this.btnUpdate);
            this.gbInstIndex.Controls.Add(this.label1);
            this.gbInstIndex.Controls.Add(this.cboExtractList);
            this.gbInstIndex.Controls.Add(this.cboMake);
            this.gbInstIndex.Controls.Add(this.btnCloseInstIdx);
            this.gbInstIndex.Controls.Add(this.btnClearDG);
            this.gbInstIndex.Controls.Add(this.cboPIDList);
            this.gbInstIndex.Controls.Add(this.lblPIDList);
            this.gbInstIndex.Controls.Add(this.btnExpToExcel);
            this.gbInstIndex.Controls.Add(this.btnGetTagData);
            this.gbInstIndex.Controls.Add(this.cboLineNr);
            this.gbInstIndex.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInstIndex.Location = new System.Drawing.Point(12, 12);
            this.gbInstIndex.Name = "gbInstIndex";
            this.gbInstIndex.Size = new System.Drawing.Size(787, 401);
            this.gbInstIndex.TabIndex = 17;
            this.gbInstIndex.TabStop = false;
            this.gbInstIndex.Text = "View Instrument Index";
            this.gbInstIndex.Enter += new System.EventHandler(this.gbInstIndex_Enter);
            // 
            // dgTags
            // 
            this.dgTags.BackgroundColor = System.Drawing.Color.Silver;
            this.dgTags.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTags.GridColor = System.Drawing.Color.White;
            this.dgTags.Location = new System.Drawing.Point(220, 97);
            this.dgTags.Name = "dgTags";
            this.dgTags.RowTemplate.Height = 23;
            this.dgTags.Size = new System.Drawing.Size(537, 243);
            this.dgTags.TabIndex = 14;
            this.dgTags.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgTags_CellClick);
            this.dgTags.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgTags_CellValueChanged);
            // 
            // tviewList
            // 
            this.tviewList.CheckBoxes = true;
            this.tviewList.HideSelection = false;
            this.tviewList.Location = new System.Drawing.Point(6, 97);
            this.tviewList.Name = "tviewList";
            this.tviewList.Size = new System.Drawing.Size(208, 243);
            this.tviewList.TabIndex = 26;
            this.tviewList.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.tviewList_AfterCheck);
            this.tviewList.DrawNode += new System.Windows.Forms.DrawTreeNodeEventHandler(this.tviewList_DrawNode);
            this.tviewList.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tviewList_AfterSelect);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(494, 358);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 25;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Extract Data For:";
            // 
            // cboExtractList
            // 
            this.cboExtractList.Enabled = false;
            this.cboExtractList.FormattingEnabled = true;
            this.cboExtractList.Items.AddRange(new object[] {
            "Instrument Index",
            "IO List"});
            this.cboExtractList.Location = new System.Drawing.Point(118, 24);
            this.cboExtractList.Name = "cboExtractList";
            this.cboExtractList.Size = new System.Drawing.Size(282, 21);
            this.cboExtractList.TabIndex = 23;
            // 
            // cboMake
            // 
            this.cboMake.FormattingEnabled = true;
            this.cboMake.Location = new System.Drawing.Point(600, 108);
            this.cboMake.Name = "cboMake";
            this.cboMake.Size = new System.Drawing.Size(121, 21);
            this.cboMake.TabIndex = 22;
            this.cboMake.Visible = false;
            this.cboMake.SelectedIndexChanged += new System.EventHandler(this.cboMake_SelectedIndexChanged);
            // 
            // btnCloseInstIdx
            // 
            this.btnCloseInstIdx.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseInstIdx.Location = new System.Drawing.Point(680, 358);
            this.btnCloseInstIdx.Name = "btnCloseInstIdx";
            this.btnCloseInstIdx.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnCloseInstIdx.Size = new System.Drawing.Size(75, 23);
            this.btnCloseInstIdx.TabIndex = 21;
            this.btnCloseInstIdx.Text = "Close";
            this.btnCloseInstIdx.UseVisualStyleBackColor = true;
            this.btnCloseInstIdx.Click += new System.EventHandler(this.btnCloseInstIdx_Click);
            // 
            // btnClearDG
            // 
            this.btnClearDG.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearDG.Location = new System.Drawing.Point(589, 358);
            this.btnClearDG.Name = "btnClearDG";
            this.btnClearDG.Size = new System.Drawing.Size(75, 23);
            this.btnClearDG.TabIndex = 20;
            this.btnClearDG.Text = "Clear Data";
            this.btnClearDG.UseVisualStyleBackColor = true;
            this.btnClearDG.Click += new System.EventHandler(this.btnClearDG_Click);
            // 
            // cboPIDList
            // 
            this.cboPIDList.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPIDList.FormattingEnabled = true;
            this.cboPIDList.Location = new System.Drawing.Point(70, 59);
            this.cboPIDList.Name = "cboPIDList";
            this.cboPIDList.Size = new System.Drawing.Size(476, 21);
            this.cboPIDList.TabIndex = 19;
            // 
            // lblPIDList
            // 
            this.lblPIDList.AutoSize = true;
            this.lblPIDList.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPIDList.Location = new System.Drawing.Point(10, 62);
            this.lblPIDList.Name = "lblPIDList";
            this.lblPIDList.Size = new System.Drawing.Size(54, 13);
            this.lblPIDList.TabIndex = 18;
            this.lblPIDList.Text = "P&&ID List:";
            // 
            // btnExpToExcel
            // 
            this.btnExpToExcel.Enabled = false;
            this.btnExpToExcel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpToExcel.Location = new System.Drawing.Point(646, 57);
            this.btnExpToExcel.Name = "btnExpToExcel";
            this.btnExpToExcel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnExpToExcel.Size = new System.Drawing.Size(111, 23);
            this.btnExpToExcel.TabIndex = 17;
            this.btnExpToExcel.Text = "Generate File";
            this.btnExpToExcel.UseVisualStyleBackColor = true;
            this.btnExpToExcel.Click += new System.EventHandler(this.btnExpToExcel_Click);
            // 
            // btnGetTagData
            // 
            this.btnGetTagData.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetTagData.Location = new System.Drawing.Point(552, 57);
            this.btnGetTagData.Name = "btnGetTagData";
            this.btnGetTagData.Size = new System.Drawing.Size(88, 23);
            this.btnGetTagData.TabIndex = 16;
            this.btnGetTagData.Text = "Get Tag Data";
            this.btnGetTagData.UseVisualStyleBackColor = true;
            this.btnGetTagData.Click += new System.EventHandler(this.btnGetTagData_Click);
            // 
            // cboLineNr
            // 
            this.cboLineNr.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLineNr.FormattingEnabled = true;
            this.cboLineNr.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cboLineNr.Location = new System.Drawing.Point(448, 108);
            this.cboLineNr.Name = "cboLineNr";
            this.cboLineNr.Size = new System.Drawing.Size(121, 21);
            this.cboLineNr.TabIndex = 15;
            this.cboLineNr.Visible = false;
            this.cboLineNr.SelectedIndexChanged += new System.EventHandler(this.cboLineNr_SelectedIndexChanged);
            // 
            // frmViewUpdateInstIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 733);
            this.Controls.Add(this.gbInstIndex);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmViewUpdateInstIndex";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmViewUpdateInstIndex_Load);
            this.gbInstIndex.ResumeLayout(false);
            this.gbInstIndex.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTags)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboMake;
        private System.Windows.Forms.Button btnCloseInstIdx;
        private System.Windows.Forms.Button btnClearDG;
        private System.Windows.Forms.ComboBox cboPIDList;
        private System.Windows.Forms.Label lblPIDList;
        private System.Windows.Forms.Button btnExpToExcel;
        private System.Windows.Forms.Button btnGetTagData;
        private System.Windows.Forms.ComboBox cboLineNr;
        private System.Windows.Forms.DataGridView dgTags;
        public System.Windows.Forms.GroupBox gbInstIndex;
        public System.Windows.Forms.ComboBox cboExtractList;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TreeView tviewList;
    }
}