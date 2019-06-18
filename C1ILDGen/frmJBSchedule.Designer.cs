namespace C1ILDGen
{
    partial class frmJBSchedule
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
            this.btnGetJBData = new System.Windows.Forms.Button();
            this.txtData = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(518, 319);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnGetJBData
            // 
            this.btnGetJBData.Location = new System.Drawing.Point(437, 318);
            this.btnGetJBData.Name = "btnGetJBData";
            this.btnGetJBData.Size = new System.Drawing.Size(75, 23);
            this.btnGetJBData.TabIndex = 1;
            this.btnGetJBData.Text = "Get Data";
            this.btnGetJBData.UseVisualStyleBackColor = true;
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(12, 26);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(609, 276);
            this.txtData.TabIndex = 2;
            this.txtData.Text = "";
            // 
            // frmJBSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 353);
            this.ControlBox = false;
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.btnGetJBData);
            this.Controls.Add(this.btnClose);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmJBSchedule";
            this.ShowInTaskbar = false;
            this.Text = "frmJBSchedule";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnGetJBData;
        private System.Windows.Forms.RichTextBox txtData;
    }
}