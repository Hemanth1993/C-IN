namespace C1ILDGen
{
    partial class frmInstFormat
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
            this.gbInstDiscFormat = new System.Windows.Forms.GroupBox();
            this.pnlLegend = new System.Windows.Forms.Panel();
            this.txtLegendVal = new System.Windows.Forms.TextBox();
            this.lblLegendVal = new System.Windows.Forms.Label();
            this.btnLegendCancel = new System.Windows.Forms.Button();
            this.btnLegendSave = new System.Windows.Forms.Button();
            this.txtLegendKey = new System.Windows.Forms.TextBox();
            this.lblLegendKey = new System.Windows.Forms.Label();
            this.btnDelSelDiscFilter = new System.Windows.Forms.Button();
            this.pnlAddDisc = new System.Windows.Forms.Panel();
            this.optContains = new System.Windows.Forms.RadioButton();
            this.optStartsWith = new System.Windows.Forms.RadioButton();
            this.btnNewDiscFilterCancel = new System.Windows.Forms.Button();
            this.btnSaveNewDiscFilter = new System.Windows.Forms.Button();
            this.txtNewDisc = new System.Windows.Forms.TextBox();
            this.lblNewDisc = new System.Windows.Forms.Label();
            this.btnAddNewDiscFilter = new System.Windows.Forms.Button();
            this.cboDiscipline = new System.Windows.Forms.ComboBox();
            this.lblSelectDisc = new System.Windows.Forms.Label();
            this.dgDiscFilterList = new System.Windows.Forms.DataGridView();
            this.lblClose = new System.Windows.Forms.Label();
            this.gbInstDiscFormat.SuspendLayout();
            this.pnlLegend.SuspendLayout();
            this.pnlAddDisc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDiscFilterList)).BeginInit();
            this.SuspendLayout();
            // 
            // gbInstDiscFormat
            // 
            this.gbInstDiscFormat.Controls.Add(this.pnlLegend);
            this.gbInstDiscFormat.Controls.Add(this.btnDelSelDiscFilter);
            this.gbInstDiscFormat.Controls.Add(this.pnlAddDisc);
            this.gbInstDiscFormat.Controls.Add(this.btnAddNewDiscFilter);
            this.gbInstDiscFormat.Controls.Add(this.cboDiscipline);
            this.gbInstDiscFormat.Controls.Add(this.lblSelectDisc);
            this.gbInstDiscFormat.Controls.Add(this.dgDiscFilterList);
            this.gbInstDiscFormat.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInstDiscFormat.Location = new System.Drawing.Point(12, 28);
            this.gbInstDiscFormat.Name = "gbInstDiscFormat";
            this.gbInstDiscFormat.Size = new System.Drawing.Size(971, 314);
            this.gbInstDiscFormat.TabIndex = 0;
            this.gbInstDiscFormat.TabStop = false;
            this.gbInstDiscFormat.Text = "Discipline Filter Format";
            // 
            // pnlLegend
            // 
            this.pnlLegend.Controls.Add(this.txtLegendVal);
            this.pnlLegend.Controls.Add(this.lblLegendVal);
            this.pnlLegend.Controls.Add(this.btnLegendCancel);
            this.pnlLegend.Controls.Add(this.btnLegendSave);
            this.pnlLegend.Controls.Add(this.txtLegendKey);
            this.pnlLegend.Controls.Add(this.lblLegendKey);
            this.pnlLegend.Location = new System.Drawing.Point(659, 73);
            this.pnlLegend.Name = "pnlLegend";
            this.pnlLegend.Size = new System.Drawing.Size(306, 135);
            this.pnlLegend.TabIndex = 8;
            this.pnlLegend.Visible = false;
            // 
            // txtLegendVal
            // 
            this.txtLegendVal.Location = new System.Drawing.Point(57, 48);
            this.txtLegendVal.Name = "txtLegendVal";
            this.txtLegendVal.Size = new System.Drawing.Size(228, 21);
            this.txtLegendVal.TabIndex = 5;
            // 
            // lblLegendVal
            // 
            this.lblLegendVal.AutoSize = true;
            this.lblLegendVal.Location = new System.Drawing.Point(15, 51);
            this.lblLegendVal.Name = "lblLegendVal";
            this.lblLegendVal.Size = new System.Drawing.Size(44, 13);
            this.lblLegendVal.TabIndex = 4;
            this.lblLegendVal.Text = "Value: ";
            // 
            // btnLegendCancel
            // 
            this.btnLegendCancel.Location = new System.Drawing.Point(208, 100);
            this.btnLegendCancel.Name = "btnLegendCancel";
            this.btnLegendCancel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnLegendCancel.Size = new System.Drawing.Size(75, 23);
            this.btnLegendCancel.TabIndex = 3;
            this.btnLegendCancel.Text = "Cancel";
            this.btnLegendCancel.UseVisualStyleBackColor = true;
            // 
            // btnLegendSave
            // 
            this.btnLegendSave.Location = new System.Drawing.Point(127, 100);
            this.btnLegendSave.Name = "btnLegendSave";
            this.btnLegendSave.Size = new System.Drawing.Size(75, 23);
            this.btnLegendSave.TabIndex = 2;
            this.btnLegendSave.Text = "Save";
            this.btnLegendSave.UseVisualStyleBackColor = true;
            this.btnLegendSave.Click += new System.EventHandler(this.btnLegendSave_Click);
            // 
            // txtLegendKey
            // 
            this.txtLegendKey.Location = new System.Drawing.Point(57, 18);
            this.txtLegendKey.Name = "txtLegendKey";
            this.txtLegendKey.Size = new System.Drawing.Size(228, 21);
            this.txtLegendKey.TabIndex = 1;
            // 
            // lblLegendKey
            // 
            this.lblLegendKey.AutoSize = true;
            this.lblLegendKey.Location = new System.Drawing.Point(15, 21);
            this.lblLegendKey.Name = "lblLegendKey";
            this.lblLegendKey.Size = new System.Drawing.Size(34, 13);
            this.lblLegendKey.TabIndex = 0;
            this.lblLegendKey.Text = "Key: ";
            // 
            // btnDelSelDiscFilter
            // 
            this.btnDelSelDiscFilter.Enabled = false;
            this.btnDelSelDiscFilter.Location = new System.Drawing.Point(578, 275);
            this.btnDelSelDiscFilter.Name = "btnDelSelDiscFilter";
            this.btnDelSelDiscFilter.Size = new System.Drawing.Size(75, 23);
            this.btnDelSelDiscFilter.TabIndex = 7;
            this.btnDelSelDiscFilter.Text = "Delete";
            this.btnDelSelDiscFilter.UseVisualStyleBackColor = true;
            this.btnDelSelDiscFilter.Click += new System.EventHandler(this.btnDelSelDiscFilter_Click);
            // 
            // pnlAddDisc
            // 
            this.pnlAddDisc.Controls.Add(this.optContains);
            this.pnlAddDisc.Controls.Add(this.optStartsWith);
            this.pnlAddDisc.Controls.Add(this.btnNewDiscFilterCancel);
            this.pnlAddDisc.Controls.Add(this.btnSaveNewDiscFilter);
            this.pnlAddDisc.Controls.Add(this.txtNewDisc);
            this.pnlAddDisc.Controls.Add(this.lblNewDisc);
            this.pnlAddDisc.Location = new System.Drawing.Point(659, 73);
            this.pnlAddDisc.Name = "pnlAddDisc";
            this.pnlAddDisc.Size = new System.Drawing.Size(306, 135);
            this.pnlAddDisc.TabIndex = 6;
            this.pnlAddDisc.Visible = false;
            // 
            // optContains
            // 
            this.optContains.AutoSize = true;
            this.optContains.Location = new System.Drawing.Point(184, 44);
            this.optContains.Name = "optContains";
            this.optContains.Size = new System.Drawing.Size(74, 17);
            this.optContains.TabIndex = 5;
            this.optContains.TabStop = true;
            this.optContains.Text = "Contains";
            this.optContains.UseVisualStyleBackColor = true;
            // 
            // optStartsWith
            // 
            this.optStartsWith.AutoSize = true;
            this.optStartsWith.Checked = true;
            this.optStartsWith.Location = new System.Drawing.Point(25, 44);
            this.optStartsWith.Name = "optStartsWith";
            this.optStartsWith.Size = new System.Drawing.Size(89, 17);
            this.optStartsWith.TabIndex = 4;
            this.optStartsWith.TabStop = true;
            this.optStartsWith.Text = "Starts With";
            this.optStartsWith.UseVisualStyleBackColor = true;
            // 
            // btnNewDiscFilterCancel
            // 
            this.btnNewDiscFilterCancel.Location = new System.Drawing.Point(208, 100);
            this.btnNewDiscFilterCancel.Name = "btnNewDiscFilterCancel";
            this.btnNewDiscFilterCancel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnNewDiscFilterCancel.Size = new System.Drawing.Size(75, 23);
            this.btnNewDiscFilterCancel.TabIndex = 3;
            this.btnNewDiscFilterCancel.Text = "Cancel";
            this.btnNewDiscFilterCancel.UseVisualStyleBackColor = true;
            this.btnNewDiscFilterCancel.Click += new System.EventHandler(this.btnNewDiscCancel_Click);
            // 
            // btnSaveNewDiscFilter
            // 
            this.btnSaveNewDiscFilter.Location = new System.Drawing.Point(127, 100);
            this.btnSaveNewDiscFilter.Name = "btnSaveNewDiscFilter";
            this.btnSaveNewDiscFilter.Size = new System.Drawing.Size(75, 23);
            this.btnSaveNewDiscFilter.TabIndex = 2;
            this.btnSaveNewDiscFilter.Text = "Save";
            this.btnSaveNewDiscFilter.UseVisualStyleBackColor = true;
            this.btnSaveNewDiscFilter.Click += new System.EventHandler(this.btnSaveNewDiscFilter_Click);
            // 
            // txtNewDisc
            // 
            this.txtNewDisc.Location = new System.Drawing.Point(20, 73);
            this.txtNewDisc.Name = "txtNewDisc";
            this.txtNewDisc.Size = new System.Drawing.Size(263, 21);
            this.txtNewDisc.TabIndex = 1;
            // 
            // lblNewDisc
            // 
            this.lblNewDisc.AutoSize = true;
            this.lblNewDisc.Location = new System.Drawing.Point(15, 15);
            this.lblNewDisc.Name = "lblNewDisc";
            this.lblNewDisc.Size = new System.Drawing.Size(160, 13);
            this.lblNewDisc.TabIndex = 0;
            this.lblNewDisc.Text = "Enter the new filter syntax ";
            // 
            // btnAddNewDiscFilter
            // 
            this.btnAddNewDiscFilter.Location = new System.Drawing.Point(497, 275);
            this.btnAddNewDiscFilter.Name = "btnAddNewDiscFilter";
            this.btnAddNewDiscFilter.Size = new System.Drawing.Size(75, 23);
            this.btnAddNewDiscFilter.TabIndex = 5;
            this.btnAddNewDiscFilter.Text = "Add New";
            this.btnAddNewDiscFilter.UseVisualStyleBackColor = true;
            this.btnAddNewDiscFilter.Click += new System.EventHandler(this.btnAddNewDisc_Click);
            // 
            // cboDiscipline
            // 
            this.cboDiscipline.FormattingEnabled = true;
            this.cboDiscipline.Items.AddRange(new object[] {
            "Instrument",
            "Pipe",
            "Other"});
            this.cboDiscipline.Location = new System.Drawing.Point(117, 35);
            this.cboDiscipline.Name = "cboDiscipline";
            this.cboDiscipline.Size = new System.Drawing.Size(238, 21);
            this.cboDiscipline.TabIndex = 4;
            this.cboDiscipline.SelectedIndexChanged += new System.EventHandler(this.cboDiscipline_SelectedIndexChanged);
            // 
            // lblSelectDisc
            // 
            this.lblSelectDisc.AutoSize = true;
            this.lblSelectDisc.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectDisc.Location = new System.Drawing.Point(7, 38);
            this.lblSelectDisc.Name = "lblSelectDisc";
            this.lblSelectDisc.Size = new System.Drawing.Size(104, 13);
            this.lblSelectDisc.TabIndex = 3;
            this.lblSelectDisc.Text = "Select Discipline: ";
            // 
            // dgDiscFilterList
            // 
            this.dgDiscFilterList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDiscFilterList.Location = new System.Drawing.Point(10, 73);
            this.dgDiscFilterList.Name = "dgDiscFilterList";
            this.dgDiscFilterList.RowTemplate.Height = 23;
            this.dgDiscFilterList.Size = new System.Drawing.Size(643, 196);
            this.dgDiscFilterList.TabIndex = 0;
            this.dgDiscFilterList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDiscFilterList_CellClick);
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblClose.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.Location = new System.Drawing.Point(976, 0);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(17, 18);
            this.lblClose.TabIndex = 4;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // frmInstFormat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 360);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.gbInstDiscFormat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInstFormat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.frmInstFormat_Load);
            this.gbInstDiscFormat.ResumeLayout(false);
            this.gbInstDiscFormat.PerformLayout();
            this.pnlLegend.ResumeLayout(false);
            this.pnlLegend.PerformLayout();
            this.pnlAddDisc.ResumeLayout(false);
            this.pnlAddDisc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDiscFilterList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgDiscFilterList;
        private System.Windows.Forms.Panel pnlAddDisc;
        private System.Windows.Forms.Button btnNewDiscFilterCancel;
        private System.Windows.Forms.Button btnSaveNewDiscFilter;
        private System.Windows.Forms.TextBox txtNewDisc;
        private System.Windows.Forms.Label lblNewDisc;
        private System.Windows.Forms.Button btnAddNewDiscFilter;
        private System.Windows.Forms.ComboBox cboDiscipline;
        private System.Windows.Forms.Label lblSelectDisc;
        private System.Windows.Forms.Button btnDelSelDiscFilter;
        private System.Windows.Forms.RadioButton optContains;
        private System.Windows.Forms.RadioButton optStartsWith;
        public System.Windows.Forms.GroupBox gbInstDiscFormat;
        private System.Windows.Forms.Panel pnlLegend;
        private System.Windows.Forms.TextBox txtLegendVal;
        private System.Windows.Forms.Label lblLegendVal;
        private System.Windows.Forms.Button btnLegendCancel;
        private System.Windows.Forms.Button btnLegendSave;
        private System.Windows.Forms.TextBox txtLegendKey;
        private System.Windows.Forms.Label lblLegendKey;
        private System.Windows.Forms.Label lblClose;
    }
}