namespace C1ILDGen
{
    partial class frmPIDTagNrMapping
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
            this.gbPIDTagGroup = new System.Windows.Forms.GroupBox();
            this.pnlPIDTag = new System.Windows.Forms.Panel();
            this.txtNewTag = new System.Windows.Forms.TextBox();
            this.lblNewTag = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSaveNewTag = new System.Windows.Forms.Button();
            this.txtPIDTag = new System.Windows.Forms.TextBox();
            this.lblPIDTag = new System.Windows.Forms.Label();
            this.btnDeleteTag = new System.Windows.Forms.Button();
            this.btnAddNewTag = new System.Windows.Forms.Button();
            this.dgTagMappingList = new System.Windows.Forms.DataGridView();
            this.lblClose = new System.Windows.Forms.Label();
            this.gbPIDTagGroup.SuspendLayout();
            this.pnlPIDTag.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTagMappingList)).BeginInit();
            this.SuspendLayout();
            // 
            // gbPIDTagGroup
            // 
            this.gbPIDTagGroup.Controls.Add(this.pnlPIDTag);
            this.gbPIDTagGroup.Controls.Add(this.btnDeleteTag);
            this.gbPIDTagGroup.Controls.Add(this.btnAddNewTag);
            this.gbPIDTagGroup.Controls.Add(this.dgTagMappingList);
            this.gbPIDTagGroup.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPIDTagGroup.Location = new System.Drawing.Point(12, 38);
            this.gbPIDTagGroup.Name = "gbPIDTagGroup";
            this.gbPIDTagGroup.Size = new System.Drawing.Size(971, 314);
            this.gbPIDTagGroup.TabIndex = 0;
            this.gbPIDTagGroup.TabStop = false;
            this.gbPIDTagGroup.Text = "P&&ID Tag Number Mappings";
            // 
            // pnlPIDTag
            // 
            this.pnlPIDTag.Controls.Add(this.txtNewTag);
            this.pnlPIDTag.Controls.Add(this.lblNewTag);
            this.pnlPIDTag.Controls.Add(this.btnCancel);
            this.pnlPIDTag.Controls.Add(this.btnSaveNewTag);
            this.pnlPIDTag.Controls.Add(this.txtPIDTag);
            this.pnlPIDTag.Controls.Add(this.lblPIDTag);
            this.pnlPIDTag.Location = new System.Drawing.Point(665, 85);
            this.pnlPIDTag.Name = "pnlPIDTag";
            this.pnlPIDTag.Size = new System.Drawing.Size(306, 135);
            this.pnlPIDTag.TabIndex = 8;
            this.pnlPIDTag.Visible = false;
            // 
            // txtNewTag
            // 
            this.txtNewTag.Location = new System.Drawing.Point(80, 48);
            this.txtNewTag.Name = "txtNewTag";
            this.txtNewTag.Size = new System.Drawing.Size(205, 21);
            this.txtNewTag.TabIndex = 5;
            // 
            // lblNewTag
            // 
            this.lblNewTag.AutoSize = true;
            this.lblNewTag.Location = new System.Drawing.Point(15, 51);
            this.lblNewTag.Name = "lblNewTag";
            this.lblNewTag.Size = new System.Drawing.Size(60, 13);
            this.lblNewTag.TabIndex = 4;
            this.lblNewTag.Text = "New Tag: ";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(208, 100);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSaveNewTag
            // 
            this.btnSaveNewTag.Location = new System.Drawing.Point(127, 100);
            this.btnSaveNewTag.Name = "btnSaveNewTag";
            this.btnSaveNewTag.Size = new System.Drawing.Size(75, 23);
            this.btnSaveNewTag.TabIndex = 2;
            this.btnSaveNewTag.Text = "Save";
            this.btnSaveNewTag.UseVisualStyleBackColor = true;
            this.btnSaveNewTag.Click += new System.EventHandler(this.btnSaveNewTag_Click);
            // 
            // txtPIDTag
            // 
            this.txtPIDTag.Location = new System.Drawing.Point(80, 18);
            this.txtPIDTag.Name = "txtPIDTag";
            this.txtPIDTag.Size = new System.Drawing.Size(205, 21);
            this.txtPIDTag.TabIndex = 1;
            // 
            // lblPIDTag
            // 
            this.lblPIDTag.AutoSize = true;
            this.lblPIDTag.Location = new System.Drawing.Point(15, 21);
            this.lblPIDTag.Name = "lblPIDTag";
            this.lblPIDTag.Size = new System.Drawing.Size(66, 13);
            this.lblPIDTag.TabIndex = 0;
            this.lblPIDTag.Text = "P&&ID Tag: ";
            // 
            // btnDeleteTag
            // 
            this.btnDeleteTag.Enabled = false;
            this.btnDeleteTag.Location = new System.Drawing.Point(578, 275);
            this.btnDeleteTag.Name = "btnDeleteTag";
            this.btnDeleteTag.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteTag.TabIndex = 7;
            this.btnDeleteTag.Text = "Delete";
            this.btnDeleteTag.UseVisualStyleBackColor = true;
            this.btnDeleteTag.Click += new System.EventHandler(this.btnDeleteTag_Click);
            // 
            // btnAddNewTag
            // 
            this.btnAddNewTag.Location = new System.Drawing.Point(497, 275);
            this.btnAddNewTag.Name = "btnAddNewTag";
            this.btnAddNewTag.Size = new System.Drawing.Size(75, 23);
            this.btnAddNewTag.TabIndex = 5;
            this.btnAddNewTag.Text = "Add New";
            this.btnAddNewTag.UseVisualStyleBackColor = true;
            this.btnAddNewTag.Click += new System.EventHandler(this.btnAddNewDisc_Click);
            // 
            // dgTagMappingList
            // 
            this.dgTagMappingList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTagMappingList.Location = new System.Drawing.Point(10, 20);
            this.dgTagMappingList.Name = "dgTagMappingList";
            this.dgTagMappingList.RowTemplate.Height = 23;
            this.dgTagMappingList.Size = new System.Drawing.Size(643, 249);
            this.dgTagMappingList.TabIndex = 0;
            this.dgTagMappingList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgTagMappingList_CellClick);
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblClose.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.Location = new System.Drawing.Point(977, 0);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(17, 18);
            this.lblClose.TabIndex = 5;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // frmPIDTagNrMapping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 405);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.gbPIDTagGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPIDTagNrMapping";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.frmPIDTagNrMapping_Load);
            this.gbPIDTagGroup.ResumeLayout(false);
            this.pnlPIDTag.ResumeLayout(false);
            this.pnlPIDTag.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTagMappingList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgTagMappingList;
        private System.Windows.Forms.Button btnAddNewTag;
        private System.Windows.Forms.Button btnDeleteTag;
        public System.Windows.Forms.GroupBox gbPIDTagGroup;
        private System.Windows.Forms.Panel pnlPIDTag;
        private System.Windows.Forms.TextBox txtNewTag;
        private System.Windows.Forms.Label lblNewTag;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSaveNewTag;
        private System.Windows.Forms.TextBox txtPIDTag;
        private System.Windows.Forms.Label lblPIDTag;
        private System.Windows.Forms.Label lblClose;
    }
}