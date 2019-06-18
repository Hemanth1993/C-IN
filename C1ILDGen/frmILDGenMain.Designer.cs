namespace C1ILDGen
{
    partial class frmILDGenMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmILDGenMain));
            this.StatStrip = new System.Windows.Forms.StatusStrip();
            this.StatStripLbl1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ofdDWG = new System.Windows.Forms.OpenFileDialog();
            this.menuILD = new System.Windows.Forms.MenuStrip();
            this.configureProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instrumentIDFormatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lineNumberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tAGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disciplineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pAUCodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inputListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.legendToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendorListToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.vendorCatalogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mappingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pIDTagNumberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readPIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.singleDrawingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.JBLayoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extractDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instrumentIndexToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.iOListToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.instrumentLocationPlanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.junctionBoxLayoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.JBScheduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cableScheduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fieldWiringDrawingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.interconnectionDrawingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iOConfigurationDrawingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instrumentLoopDrawingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cableBlockDiagramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cableRoutingPlanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.primaryPneumaticHookupDrawingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materialTakeOffMTOPneumaticToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.installationsAndElectricalHookupDrawingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materialTakeOffMTOElectricToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instrumentIndexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iOListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mTOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.junctionBoxLayoutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.junctionBoxScheduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cableScheduleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fieldWiringDrawingsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.interconnectionDrawingsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.iOConfigurationDrawingsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.instrumentLoopDrawingsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cableBlockDiagramToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cableRoutingPlanToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.primaryPneumaticHookupDrawingsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.materialTakeOffMTOPneumaticToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.installationsAndElectricalHookupDrawingsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.materialTakeOffMTOElectricToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
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
            this.fdDWG = new System.Windows.Forms.FolderBrowserDialog();
            this.bgWorker = new System.ComponentModel.BackgroundWorker();
            this.StatStrip.SuspendLayout();
            this.menuILD.SuspendLayout();
            this.gbReadPID.SuspendLayout();
            this.SuspendLayout();
            // 
            // StatStrip
            // 
            this.StatStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatStripLbl1});
            this.StatStrip.Location = new System.Drawing.Point(0, 711);
            this.StatStrip.Name = "StatStrip";
            this.StatStrip.Size = new System.Drawing.Size(1354, 22);
            this.StatStrip.TabIndex = 6;
            // 
            // StatStripLbl1
            // 
            this.StatStripLbl1.DoubleClickEnabled = true;
            this.StatStripLbl1.Name = "StatStripLbl1";
            this.StatStripLbl1.Size = new System.Drawing.Size(39, 17);
            this.StatStripLbl1.Text = "Ready";
            this.StatStripLbl1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ofdDWG
            // 
            this.ofdDWG.InitialDirectory = "D:\\";
            // 
            // menuILD
            // 
            this.menuILD.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configureProjectToolStripMenuItem,
            this.readPIDToolStripMenuItem,
            this.extractDataToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.menuILD.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuILD.Location = new System.Drawing.Point(0, 0);
            this.menuILD.Name = "menuILD";
            this.menuILD.Size = new System.Drawing.Size(1354, 24);
            this.menuILD.TabIndex = 14;
            this.menuILD.Text = "menuStrip1";
            // 
            // configureProjectToolStripMenuItem
            // 
            this.configureProjectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.instrumentIDFormatToolStripMenuItem,
            this.inputListToolStripMenuItem,
            this.mappingToolStripMenuItem,
            this.appConfigToolStripMenuItem});
            this.configureProjectToolStripMenuItem.Name = "configureProjectToolStripMenuItem";
            this.configureProjectToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.configureProjectToolStripMenuItem.Text = "Configure Project";
            // 
            // instrumentIDFormatToolStripMenuItem
            // 
            this.instrumentIDFormatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lineNumberToolStripMenuItem,
            this.tAGToolStripMenuItem,
            this.disciplineToolStripMenuItem,
            this.pAUCodeToolStripMenuItem});
            this.instrumentIDFormatToolStripMenuItem.Name = "instrumentIDFormatToolStripMenuItem";
            this.instrumentIDFormatToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.instrumentIDFormatToolStripMenuItem.Text = "Filters";
            // 
            // lineNumberToolStripMenuItem
            // 
            this.lineNumberToolStripMenuItem.Name = "lineNumberToolStripMenuItem";
            this.lineNumberToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.lineNumberToolStripMenuItem.Text = "Line Number";
            this.lineNumberToolStripMenuItem.Click += new System.EventHandler(this.lineNumberToolStripMenuItem_Click);
            // 
            // tAGToolStripMenuItem
            // 
            this.tAGToolStripMenuItem.Name = "tAGToolStripMenuItem";
            this.tAGToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.tAGToolStripMenuItem.Text = "TAG";
            this.tAGToolStripMenuItem.Click += new System.EventHandler(this.tAGToolStripMenuItem_Click);
            // 
            // disciplineToolStripMenuItem
            // 
            this.disciplineToolStripMenuItem.Name = "disciplineToolStripMenuItem";
            this.disciplineToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.disciplineToolStripMenuItem.Text = "Discipline";
            this.disciplineToolStripMenuItem.Click += new System.EventHandler(this.disciplineToolStripMenuItem_Click);
            // 
            // pAUCodeToolStripMenuItem
            // 
            this.pAUCodeToolStripMenuItem.Name = "pAUCodeToolStripMenuItem";
            this.pAUCodeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pAUCodeToolStripMenuItem.Text = "PAU Code";
            // 
            // inputListToolStripMenuItem
            // 
            this.inputListToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.legendToolStripMenuItem,
            this.vendorListToolStripMenuItem1,
            this.vendorCatalogToolStripMenuItem});
            this.inputListToolStripMenuItem.Name = "inputListToolStripMenuItem";
            this.inputListToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.inputListToolStripMenuItem.Text = "Input List";
            // 
            // legendToolStripMenuItem
            // 
            this.legendToolStripMenuItem.Name = "legendToolStripMenuItem";
            this.legendToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.legendToolStripMenuItem.Text = "Legend";
            this.legendToolStripMenuItem.Click += new System.EventHandler(this.legendToolStripMenuItem_Click);
            // 
            // vendorListToolStripMenuItem1
            // 
            this.vendorListToolStripMenuItem1.Name = "vendorListToolStripMenuItem1";
            this.vendorListToolStripMenuItem1.Size = new System.Drawing.Size(156, 22);
            this.vendorListToolStripMenuItem1.Text = "Vendor List";
            this.vendorListToolStripMenuItem1.Click += new System.EventHandler(this.vendorListToolStripMenuItem1_Click);
            // 
            // vendorCatalogToolStripMenuItem
            // 
            this.vendorCatalogToolStripMenuItem.Name = "vendorCatalogToolStripMenuItem";
            this.vendorCatalogToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.vendorCatalogToolStripMenuItem.Text = "Vendor Catalog";
            this.vendorCatalogToolStripMenuItem.Click += new System.EventHandler(this.vendorCatalogToolStripMenuItem_Click);
            // 
            // mappingToolStripMenuItem
            // 
            this.mappingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pIDTagNumberToolStripMenuItem});
            this.mappingToolStripMenuItem.Name = "mappingToolStripMenuItem";
            this.mappingToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.mappingToolStripMenuItem.Text = "Mapping";
            // 
            // pIDTagNumberToolStripMenuItem
            // 
            this.pIDTagNumberToolStripMenuItem.Name = "pIDTagNumberToolStripMenuItem";
            this.pIDTagNumberToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pIDTagNumberToolStripMenuItem.Text = "P&&ID - Tag Number";
            this.pIDTagNumberToolStripMenuItem.Click += new System.EventHandler(this.pIDTagNumberToolStripMenuItem_Click);
            // 
            // appConfigToolStripMenuItem
            // 
            this.appConfigToolStripMenuItem.Name = "appConfigToolStripMenuItem";
            this.appConfigToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.appConfigToolStripMenuItem.Text = "App Config";
            this.appConfigToolStripMenuItem.Click += new System.EventHandler(this.appConfigToolStripMenuItem_Click);
            // 
            // readPIDToolStripMenuItem
            // 
            this.readPIDToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.singleDrawingToolStripMenuItem,
            this.toolStripSeparator1,
            this.JBLayoutToolStripMenuItem});
            this.readPIDToolStripMenuItem.Name = "readPIDToolStripMenuItem";
            this.readPIDToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.readPIDToolStripMenuItem.Text = "Read Inputs";
            this.readPIDToolStripMenuItem.Click += new System.EventHandler(this.readPIDToolStripMenuItem_Click);
            // 
            // singleDrawingToolStripMenuItem
            // 
            this.singleDrawingToolStripMenuItem.Name = "singleDrawingToolStripMenuItem";
            this.singleDrawingToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.singleDrawingToolStripMenuItem.Text = "P&&ID";
            this.singleDrawingToolStripMenuItem.Click += new System.EventHandler(this.singleDrawingToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(121, 6);
            // 
            // JBLayoutToolStripMenuItem
            // 
            this.JBLayoutToolStripMenuItem.Name = "JBLayoutToolStripMenuItem";
            this.JBLayoutToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.JBLayoutToolStripMenuItem.Text = "JB Layout";
            this.JBLayoutToolStripMenuItem.Click += new System.EventHandler(this.JBScheduleToolStripMenuItem_Click);
            // 
            // extractDataToolStripMenuItem
            // 
            this.extractDataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.instrumentIndexToolStripMenuItem1,
            this.iOListToolStripMenuItem1,
            this.instrumentLocationPlanToolStripMenuItem,
            this.junctionBoxLayoutToolStripMenuItem,
            this.JBScheduleToolStripMenuItem,
            this.cableScheduleToolStripMenuItem,
            this.fieldWiringDrawingsToolStripMenuItem,
            this.interconnectionDrawingsToolStripMenuItem,
            this.iOConfigurationDrawingsToolStripMenuItem,
            this.instrumentLoopDrawingsToolStripMenuItem,
            this.cableBlockDiagramToolStripMenuItem,
            this.cableRoutingPlanToolStripMenuItem,
            this.primaryPneumaticHookupDrawingsToolStripMenuItem,
            this.materialTakeOffMTOPneumaticToolStripMenuItem,
            this.installationsAndElectricalHookupDrawingsToolStripMenuItem,
            this.materialTakeOffMTOElectricToolStripMenuItem});
            this.extractDataToolStripMenuItem.Name = "extractDataToolStripMenuItem";
            this.extractDataToolStripMenuItem.Size = new System.Drawing.Size(125, 20);
            this.extractDataToolStripMenuItem.Text = "View && Update Data";
            // 
            // instrumentIndexToolStripMenuItem1
            // 
            this.instrumentIndexToolStripMenuItem1.Name = "instrumentIndexToolStripMenuItem1";
            this.instrumentIndexToolStripMenuItem1.Size = new System.Drawing.Size(313, 22);
            this.instrumentIndexToolStripMenuItem1.Text = "Instrument Index";
            this.instrumentIndexToolStripMenuItem1.Click += new System.EventHandler(this.instrumentIndexToolStripMenuItem1_Click);
            // 
            // iOListToolStripMenuItem1
            // 
            this.iOListToolStripMenuItem1.Name = "iOListToolStripMenuItem1";
            this.iOListToolStripMenuItem1.Size = new System.Drawing.Size(313, 22);
            this.iOListToolStripMenuItem1.Text = "Input Output List";
            this.iOListToolStripMenuItem1.Click += new System.EventHandler(this.iOListToolStripMenuItem1_Click);
            // 
            // instrumentLocationPlanToolStripMenuItem
            // 
            this.instrumentLocationPlanToolStripMenuItem.Enabled = false;
            this.instrumentLocationPlanToolStripMenuItem.Name = "instrumentLocationPlanToolStripMenuItem";
            this.instrumentLocationPlanToolStripMenuItem.Size = new System.Drawing.Size(313, 22);
            this.instrumentLocationPlanToolStripMenuItem.Text = "Instrument Location Plan";
            // 
            // junctionBoxLayoutToolStripMenuItem
            // 
            this.junctionBoxLayoutToolStripMenuItem.Enabled = false;
            this.junctionBoxLayoutToolStripMenuItem.Name = "junctionBoxLayoutToolStripMenuItem";
            this.junctionBoxLayoutToolStripMenuItem.Size = new System.Drawing.Size(313, 22);
            this.junctionBoxLayoutToolStripMenuItem.Text = "Junction Box Layout";
            // 
            // JBScheduleToolStripMenuItem
            // 
            this.JBScheduleToolStripMenuItem.Name = "JBScheduleToolStripMenuItem";
            this.JBScheduleToolStripMenuItem.Size = new System.Drawing.Size(313, 22);
            this.JBScheduleToolStripMenuItem.Text = "Junction Box Schedule";
            this.JBScheduleToolStripMenuItem.Click += new System.EventHandler(this.JBScheduleToolStripMenuItem_Click_1);
            // 
            // cableScheduleToolStripMenuItem
            // 
            this.cableScheduleToolStripMenuItem.Enabled = false;
            this.cableScheduleToolStripMenuItem.Name = "cableScheduleToolStripMenuItem";
            this.cableScheduleToolStripMenuItem.Size = new System.Drawing.Size(313, 22);
            this.cableScheduleToolStripMenuItem.Text = "Cable Schedule";
            // 
            // fieldWiringDrawingsToolStripMenuItem
            // 
            this.fieldWiringDrawingsToolStripMenuItem.Enabled = false;
            this.fieldWiringDrawingsToolStripMenuItem.Name = "fieldWiringDrawingsToolStripMenuItem";
            this.fieldWiringDrawingsToolStripMenuItem.Size = new System.Drawing.Size(313, 22);
            this.fieldWiringDrawingsToolStripMenuItem.Text = "Field Wiring Drawings";
            // 
            // interconnectionDrawingsToolStripMenuItem
            // 
            this.interconnectionDrawingsToolStripMenuItem.Enabled = false;
            this.interconnectionDrawingsToolStripMenuItem.Name = "interconnectionDrawingsToolStripMenuItem";
            this.interconnectionDrawingsToolStripMenuItem.Size = new System.Drawing.Size(313, 22);
            this.interconnectionDrawingsToolStripMenuItem.Text = "Interconnection Drawings";
            // 
            // iOConfigurationDrawingsToolStripMenuItem
            // 
            this.iOConfigurationDrawingsToolStripMenuItem.Enabled = false;
            this.iOConfigurationDrawingsToolStripMenuItem.Name = "iOConfigurationDrawingsToolStripMenuItem";
            this.iOConfigurationDrawingsToolStripMenuItem.Size = new System.Drawing.Size(313, 22);
            this.iOConfigurationDrawingsToolStripMenuItem.Text = "I/O Configuration Drawings";
            // 
            // instrumentLoopDrawingsToolStripMenuItem
            // 
            this.instrumentLoopDrawingsToolStripMenuItem.Enabled = false;
            this.instrumentLoopDrawingsToolStripMenuItem.Name = "instrumentLoopDrawingsToolStripMenuItem";
            this.instrumentLoopDrawingsToolStripMenuItem.Size = new System.Drawing.Size(313, 22);
            this.instrumentLoopDrawingsToolStripMenuItem.Text = "Instrument Loop Drawings";
            // 
            // cableBlockDiagramToolStripMenuItem
            // 
            this.cableBlockDiagramToolStripMenuItem.Enabled = false;
            this.cableBlockDiagramToolStripMenuItem.Name = "cableBlockDiagramToolStripMenuItem";
            this.cableBlockDiagramToolStripMenuItem.Size = new System.Drawing.Size(313, 22);
            this.cableBlockDiagramToolStripMenuItem.Text = "Cable Block Diagram";
            // 
            // cableRoutingPlanToolStripMenuItem
            // 
            this.cableRoutingPlanToolStripMenuItem.Enabled = false;
            this.cableRoutingPlanToolStripMenuItem.Name = "cableRoutingPlanToolStripMenuItem";
            this.cableRoutingPlanToolStripMenuItem.Size = new System.Drawing.Size(313, 22);
            this.cableRoutingPlanToolStripMenuItem.Text = "Cable Routing Plan";
            // 
            // primaryPneumaticHookupDrawingsToolStripMenuItem
            // 
            this.primaryPneumaticHookupDrawingsToolStripMenuItem.Enabled = false;
            this.primaryPneumaticHookupDrawingsToolStripMenuItem.Name = "primaryPneumaticHookupDrawingsToolStripMenuItem";
            this.primaryPneumaticHookupDrawingsToolStripMenuItem.Size = new System.Drawing.Size(313, 22);
            this.primaryPneumaticHookupDrawingsToolStripMenuItem.Text = "Primary && Pneumatic Hook-up Drawings";
            // 
            // materialTakeOffMTOPneumaticToolStripMenuItem
            // 
            this.materialTakeOffMTOPneumaticToolStripMenuItem.Enabled = false;
            this.materialTakeOffMTOPneumaticToolStripMenuItem.Name = "materialTakeOffMTOPneumaticToolStripMenuItem";
            this.materialTakeOffMTOPneumaticToolStripMenuItem.Size = new System.Drawing.Size(313, 22);
            this.materialTakeOffMTOPneumaticToolStripMenuItem.Text = "Material Take-Off – MTO (Pneumatic)";
            // 
            // installationsAndElectricalHookupDrawingsToolStripMenuItem
            // 
            this.installationsAndElectricalHookupDrawingsToolStripMenuItem.Enabled = false;
            this.installationsAndElectricalHookupDrawingsToolStripMenuItem.Name = "installationsAndElectricalHookupDrawingsToolStripMenuItem";
            this.installationsAndElectricalHookupDrawingsToolStripMenuItem.Size = new System.Drawing.Size(313, 22);
            this.installationsAndElectricalHookupDrawingsToolStripMenuItem.Text = "Installations and Electrical Hook-up Drawings";
            // 
            // materialTakeOffMTOElectricToolStripMenuItem
            // 
            this.materialTakeOffMTOElectricToolStripMenuItem.Enabled = false;
            this.materialTakeOffMTOElectricToolStripMenuItem.Name = "materialTakeOffMTOElectricToolStripMenuItem";
            this.materialTakeOffMTOElectricToolStripMenuItem.Size = new System.Drawing.Size(313, 22);
            this.materialTakeOffMTOElectricToolStripMenuItem.Text = "Material Take-Off – MTO (Electric)";
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.instrumentIndexToolStripMenuItem,
            this.iOListToolStripMenuItem,
            this.mTOToolStripMenuItem,
            this.junctionBoxLayoutToolStripMenuItem1,
            this.junctionBoxScheduleToolStripMenuItem,
            this.cableScheduleToolStripMenuItem1,
            this.fieldWiringDrawingsToolStripMenuItem1,
            this.interconnectionDrawingsToolStripMenuItem1,
            this.iOConfigurationDrawingsToolStripMenuItem1,
            this.instrumentLoopDrawingsToolStripMenuItem1,
            this.cableBlockDiagramToolStripMenuItem1,
            this.cableRoutingPlanToolStripMenuItem1,
            this.primaryPneumaticHookupDrawingsToolStripMenuItem1,
            this.materialTakeOffMTOPneumaticToolStripMenuItem1,
            this.installationsAndElectricalHookupDrawingsToolStripMenuItem1,
            this.materialTakeOffMTOElectricToolStripMenuItem1});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // instrumentIndexToolStripMenuItem
            // 
            this.instrumentIndexToolStripMenuItem.Name = "instrumentIndexToolStripMenuItem";
            this.instrumentIndexToolStripMenuItem.Size = new System.Drawing.Size(313, 22);
            this.instrumentIndexToolStripMenuItem.Text = "Instrument Index";
            this.instrumentIndexToolStripMenuItem.Click += new System.EventHandler(this.instrumentIndexToolStripMenuItem_Click);
            // 
            // iOListToolStripMenuItem
            // 
            this.iOListToolStripMenuItem.Name = "iOListToolStripMenuItem";
            this.iOListToolStripMenuItem.Size = new System.Drawing.Size(313, 22);
            this.iOListToolStripMenuItem.Text = "Input Output List";
            this.iOListToolStripMenuItem.Click += new System.EventHandler(this.iOListToolStripMenuItem_Click);
            // 
            // mTOToolStripMenuItem
            // 
            this.mTOToolStripMenuItem.Enabled = false;
            this.mTOToolStripMenuItem.Name = "mTOToolStripMenuItem";
            this.mTOToolStripMenuItem.Size = new System.Drawing.Size(313, 22);
            this.mTOToolStripMenuItem.Text = "Instrument Location Plan";
            // 
            // junctionBoxLayoutToolStripMenuItem1
            // 
            this.junctionBoxLayoutToolStripMenuItem1.Enabled = false;
            this.junctionBoxLayoutToolStripMenuItem1.Name = "junctionBoxLayoutToolStripMenuItem1";
            this.junctionBoxLayoutToolStripMenuItem1.Size = new System.Drawing.Size(313, 22);
            this.junctionBoxLayoutToolStripMenuItem1.Text = "Junction Box Layout";
            // 
            // junctionBoxScheduleToolStripMenuItem
            // 
            this.junctionBoxScheduleToolStripMenuItem.Name = "junctionBoxScheduleToolStripMenuItem";
            this.junctionBoxScheduleToolStripMenuItem.Size = new System.Drawing.Size(313, 22);
            this.junctionBoxScheduleToolStripMenuItem.Text = "Junction Box Schedule";
            this.junctionBoxScheduleToolStripMenuItem.Click += new System.EventHandler(this.junctionBoxScheduleToolStripMenuItem_Click);
            // 
            // cableScheduleToolStripMenuItem1
            // 
            this.cableScheduleToolStripMenuItem1.Enabled = false;
            this.cableScheduleToolStripMenuItem1.Name = "cableScheduleToolStripMenuItem1";
            this.cableScheduleToolStripMenuItem1.Size = new System.Drawing.Size(313, 22);
            this.cableScheduleToolStripMenuItem1.Text = "Cable Schedule";
            // 
            // fieldWiringDrawingsToolStripMenuItem1
            // 
            this.fieldWiringDrawingsToolStripMenuItem1.Enabled = false;
            this.fieldWiringDrawingsToolStripMenuItem1.Name = "fieldWiringDrawingsToolStripMenuItem1";
            this.fieldWiringDrawingsToolStripMenuItem1.Size = new System.Drawing.Size(313, 22);
            this.fieldWiringDrawingsToolStripMenuItem1.Text = "Field Wiring Drawings";
            // 
            // interconnectionDrawingsToolStripMenuItem1
            // 
            this.interconnectionDrawingsToolStripMenuItem1.Enabled = false;
            this.interconnectionDrawingsToolStripMenuItem1.Name = "interconnectionDrawingsToolStripMenuItem1";
            this.interconnectionDrawingsToolStripMenuItem1.Size = new System.Drawing.Size(313, 22);
            this.interconnectionDrawingsToolStripMenuItem1.Text = "Interconnection Drawings";
            // 
            // iOConfigurationDrawingsToolStripMenuItem1
            // 
            this.iOConfigurationDrawingsToolStripMenuItem1.Enabled = false;
            this.iOConfigurationDrawingsToolStripMenuItem1.Name = "iOConfigurationDrawingsToolStripMenuItem1";
            this.iOConfigurationDrawingsToolStripMenuItem1.Size = new System.Drawing.Size(313, 22);
            this.iOConfigurationDrawingsToolStripMenuItem1.Text = "I/O Configuration Drawings";
            // 
            // instrumentLoopDrawingsToolStripMenuItem1
            // 
            this.instrumentLoopDrawingsToolStripMenuItem1.Enabled = false;
            this.instrumentLoopDrawingsToolStripMenuItem1.Name = "instrumentLoopDrawingsToolStripMenuItem1";
            this.instrumentLoopDrawingsToolStripMenuItem1.Size = new System.Drawing.Size(313, 22);
            this.instrumentLoopDrawingsToolStripMenuItem1.Text = "Instrument Loop Drawings";
            // 
            // cableBlockDiagramToolStripMenuItem1
            // 
            this.cableBlockDiagramToolStripMenuItem1.Enabled = false;
            this.cableBlockDiagramToolStripMenuItem1.Name = "cableBlockDiagramToolStripMenuItem1";
            this.cableBlockDiagramToolStripMenuItem1.Size = new System.Drawing.Size(313, 22);
            this.cableBlockDiagramToolStripMenuItem1.Text = "Cable Block Diagram";
            // 
            // cableRoutingPlanToolStripMenuItem1
            // 
            this.cableRoutingPlanToolStripMenuItem1.Enabled = false;
            this.cableRoutingPlanToolStripMenuItem1.Name = "cableRoutingPlanToolStripMenuItem1";
            this.cableRoutingPlanToolStripMenuItem1.Size = new System.Drawing.Size(313, 22);
            this.cableRoutingPlanToolStripMenuItem1.Text = "Cable Routing Plan";
            // 
            // primaryPneumaticHookupDrawingsToolStripMenuItem1
            // 
            this.primaryPneumaticHookupDrawingsToolStripMenuItem1.Enabled = false;
            this.primaryPneumaticHookupDrawingsToolStripMenuItem1.Name = "primaryPneumaticHookupDrawingsToolStripMenuItem1";
            this.primaryPneumaticHookupDrawingsToolStripMenuItem1.Size = new System.Drawing.Size(313, 22);
            this.primaryPneumaticHookupDrawingsToolStripMenuItem1.Text = "Primary && Pneumatic Hook-up Drawings";
            // 
            // materialTakeOffMTOPneumaticToolStripMenuItem1
            // 
            this.materialTakeOffMTOPneumaticToolStripMenuItem1.Enabled = false;
            this.materialTakeOffMTOPneumaticToolStripMenuItem1.Name = "materialTakeOffMTOPneumaticToolStripMenuItem1";
            this.materialTakeOffMTOPneumaticToolStripMenuItem1.Size = new System.Drawing.Size(313, 22);
            this.materialTakeOffMTOPneumaticToolStripMenuItem1.Text = "Material Take-Off – MTO (Pneumatic)";
            // 
            // installationsAndElectricalHookupDrawingsToolStripMenuItem1
            // 
            this.installationsAndElectricalHookupDrawingsToolStripMenuItem1.Enabled = false;
            this.installationsAndElectricalHookupDrawingsToolStripMenuItem1.Name = "installationsAndElectricalHookupDrawingsToolStripMenuItem1";
            this.installationsAndElectricalHookupDrawingsToolStripMenuItem1.Size = new System.Drawing.Size(313, 22);
            this.installationsAndElectricalHookupDrawingsToolStripMenuItem1.Text = "Installations and Electrical Hook-up Drawings";
            // 
            // materialTakeOffMTOElectricToolStripMenuItem1
            // 
            this.materialTakeOffMTOElectricToolStripMenuItem1.Enabled = false;
            this.materialTakeOffMTOElectricToolStripMenuItem1.Name = "materialTakeOffMTOElectricToolStripMenuItem1";
            this.materialTakeOffMTOElectricToolStripMenuItem1.Size = new System.Drawing.Size(313, 22);
            this.materialTakeOffMTOElectricToolStripMenuItem1.Text = "Material Take-Off – MTO (Electric)";
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
            this.gbReadPID.Location = new System.Drawing.Point(0, 27);
            this.gbReadPID.Name = "gbReadPID";
            this.gbReadPID.Size = new System.Drawing.Size(1366, 659);
            this.gbReadPID.TabIndex = 15;
            this.gbReadPID.TabStop = false;
            this.gbReadPID.Text = "Read P&&ID";
            this.gbReadPID.Visible = false;
            // 
            // chkMultipleFiles
            // 
            this.chkMultipleFiles.AutoSize = true;
            this.chkMultipleFiles.Location = new System.Drawing.Point(1160, 22);
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
            this.btnClosegbPID.Location = new System.Drawing.Point(1265, 610);
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
            this.btnReadDWG.Location = new System.Drawing.Point(1022, 610);
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
            this.btnClear.Location = new System.Drawing.Point(1103, 610);
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
            this.btnCloseInstance.Location = new System.Drawing.Point(1184, 610);
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
            this.btnProgID.Location = new System.Drawing.Point(911, 610);
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
            this.btnSelectFile.Location = new System.Drawing.Point(975, 19);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(130, 23);
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
            this.txtFileName.Size = new System.Drawing.Size(963, 21);
            this.txtFileName.TabIndex = 12;
            this.txtFileName.Text = "C:\\CEONE\\C-IN\\TestFiles\\GA&PID_Sample\\PID_5288-BUH-835-30-21.dwg";
            // 
            // txtLog
            // 
            this.txtLog.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLog.Location = new System.Drawing.Point(6, 47);
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(1354, 540);
            this.txtLog.TabIndex = 11;
            this.txtLog.Text = "";
            // 
            // bgWorker
            // 
            this.bgWorker.WorkerReportsProgress = true;
            this.bgWorker.WorkerSupportsCancellation = true;
            this.bgWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorker_DoWork);
            this.bgWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgWorker_ProgressChanged);
            this.bgWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWorker_RunWorkerCompleted);
            // 
            // frmILDGenMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 733);
            this.Controls.Add(this.gbReadPID);
            this.Controls.Add(this.StatStrip);
            this.Controls.Add(this.menuILD);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuILD;
            this.Name = "frmILDGenMain";
            this.Text = "C-IN Automation Suite";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.StatStrip.ResumeLayout(false);
            this.StatStrip.PerformLayout();
            this.menuILD.ResumeLayout(false);
            this.menuILD.PerformLayout();
            this.gbReadPID.ResumeLayout(false);
            this.gbReadPID.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog ofdDWG;
        private System.Windows.Forms.MenuStrip menuILD;
        private System.Windows.Forms.ToolStripMenuItem readPIDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem singleDrawingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extractDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configureProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instrumentIDFormatToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbReadPID;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.RichTextBox txtLog;
        private System.Windows.Forms.Button btnReadDWG;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCloseInstance;
        private System.Windows.Forms.Button btnProgID;
        public System.Windows.Forms.StatusStrip StatStrip;
        public System.Windows.Forms.ToolStripStatusLabel StatStripLbl1;
        private System.Windows.Forms.Button btnClosegbPID;
        private System.Windows.Forms.ToolStripMenuItem lineNumberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tAGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disciplineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inputListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendorListToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem vendorCatalogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pAUCodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instrumentIndexToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem iOListToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem JBScheduleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instrumentIndexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iOListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mTOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem legendToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem appConfigToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mappingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pIDTagNumberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instrumentLocationPlanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem junctionBoxLayoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cableScheduleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fieldWiringDrawingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem interconnectionDrawingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iOConfigurationDrawingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instrumentLoopDrawingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cableBlockDiagramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cableRoutingPlanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem primaryPneumaticHookupDrawingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem materialTakeOffMTOPneumaticToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem installationsAndElectricalHookupDrawingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem materialTakeOffMTOElectricToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem junctionBoxLayoutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem junctionBoxScheduleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cableScheduleToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fieldWiringDrawingsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem interconnectionDrawingsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem iOConfigurationDrawingsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem instrumentLoopDrawingsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cableBlockDiagramToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cableRoutingPlanToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem primaryPneumaticHookupDrawingsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem materialTakeOffMTOPneumaticToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem installationsAndElectricalHookupDrawingsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem materialTakeOffMTOElectricToolStripMenuItem1;
        private System.Windows.Forms.FolderBrowserDialog fdDWG;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem JBLayoutToolStripMenuItem;
        private System.Windows.Forms.CheckBox chkMultipleFiles;
        private System.ComponentModel.BackgroundWorker bgWorker;
    }
}

