namespace Wii_Interface
{
    partial class frmWiiInterface
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
                speechSynthesiser.Dispose();
                wiimote.Dispose();
                speechRecognition.Dispose();
                b.Dispose();
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
            this.clbWiimote = new System.Windows.Forms.CheckedListBox();
            this.gbWiimote = new System.Windows.Forms.GroupBox();
            this.gbWiimoteAccelerometers = new System.Windows.Forms.GroupBox();
            this.lblWiimoteZ = new System.Windows.Forms.Label();
            this.lblWiimoteY = new System.Windows.Forms.Label();
            this.lblWiimoteX = new System.Windows.Forms.Label();
            this.gbNunchuck = new System.Windows.Forms.GroupBox();
            this.gbJoysticks = new System.Windows.Forms.GroupBox();
            this.lblNunJoyY = new System.Windows.Forms.Label();
            this.lblNunJoyX = new System.Windows.Forms.Label();
            this.gbNunchuckAccelerometers = new System.Windows.Forms.GroupBox();
            this.lblNunchuckZ = new System.Windows.Forms.Label();
            this.lblNunchuckY = new System.Windows.Forms.Label();
            this.lblNunchuckX = new System.Windows.Forms.Label();
            this.clbNunchuck = new System.Windows.Forms.CheckedListBox();
            this.cbEnabled = new System.Windows.Forms.CheckBox();
            this.gbDevicePath = new System.Windows.Forms.GroupBox();
            this.txtDevicePath = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectWiimoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDecimalPlaces = new System.Windows.Forms.ToolStripComboBox();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tblblBattery = new System.Windows.Forms.ToolStripStatusLabel();
            this.tbpbBattery = new System.Windows.Forms.ToolStripProgressBar();
            this.tblblBatteryPercent = new System.Windows.Forms.ToolStripStatusLabel();
            this.gbIRPositioning = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblIR3Raw = new System.Windows.Forms.Label();
            this.lblIR1Raw = new System.Windows.Forms.Label();
            this.lblIR4Raw = new System.Windows.Forms.Label();
            this.lblIR2Raw = new System.Windows.Forms.Label();
            this.lblIR3 = new System.Windows.Forms.Label();
            this.lblIR1 = new System.Windows.Forms.Label();
            this.lblIR4 = new System.Windows.Forms.Label();
            this.lblIR2 = new System.Windows.Forms.Label();
            this.chkFound3 = new System.Windows.Forms.CheckBox();
            this.chkFound4 = new System.Windows.Forms.CheckBox();
            this.chkFound1 = new System.Windows.Forms.CheckBox();
            this.chkFound2 = new System.Windows.Forms.CheckBox();
            this.pbIR = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDemoZ = new System.Windows.Forms.TextBox();
            this.txtDemoY = new System.Windows.Forms.TextBox();
            this.txtDemoX = new System.Windows.Forms.TextBox();
            this.btnInput = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cbDisableSpeech = new System.Windows.Forms.CheckBox();
            this.cbDisableRecognition = new System.Windows.Forms.CheckBox();
            this.gbWiimote.SuspendLayout();
            this.gbWiimoteAccelerometers.SuspendLayout();
            this.gbNunchuck.SuspendLayout();
            this.gbJoysticks.SuspendLayout();
            this.gbNunchuckAccelerometers.SuspendLayout();
            this.gbDevicePath.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.gbIRPositioning.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIR)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // clbWiimote
            // 
            this.clbWiimote.BackColor = System.Drawing.SystemColors.ControlDark;
            this.clbWiimote.FormattingEnabled = true;
            this.clbWiimote.Items.AddRange(new object[] {
            "A",
            "B",
            "-",
            "Home",
            "+",
            "1",
            "2",
            "Up",
            "Down",
            "Left",
            "Right"});
            this.clbWiimote.Location = new System.Drawing.Point(6, 19);
            this.clbWiimote.Name = "clbWiimote";
            this.clbWiimote.Size = new System.Drawing.Size(88, 169);
            this.clbWiimote.TabIndex = 0;
            // 
            // gbWiimote
            // 
            this.gbWiimote.Controls.Add(this.gbWiimoteAccelerometers);
            this.gbWiimote.Controls.Add(this.clbWiimote);
            this.gbWiimote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbWiimote.Location = new System.Drawing.Point(3, 3);
            this.gbWiimote.Name = "gbWiimote";
            this.gbWiimote.Size = new System.Drawing.Size(237, 205);
            this.gbWiimote.TabIndex = 1;
            this.gbWiimote.TabStop = false;
            this.gbWiimote.Text = "Wiimote";
            // 
            // gbWiimoteAccelerometers
            // 
            this.gbWiimoteAccelerometers.Controls.Add(this.lblWiimoteZ);
            this.gbWiimoteAccelerometers.Controls.Add(this.lblWiimoteY);
            this.gbWiimoteAccelerometers.Controls.Add(this.lblWiimoteX);
            this.gbWiimoteAccelerometers.Location = new System.Drawing.Point(100, 14);
            this.gbWiimoteAccelerometers.Name = "gbWiimoteAccelerometers";
            this.gbWiimoteAccelerometers.Size = new System.Drawing.Size(116, 56);
            this.gbWiimoteAccelerometers.TabIndex = 1;
            this.gbWiimoteAccelerometers.TabStop = false;
            this.gbWiimoteAccelerometers.Text = "Accelerometers";
            // 
            // lblWiimoteZ
            // 
            this.lblWiimoteZ.Location = new System.Drawing.Point(6, 42);
            this.lblWiimoteZ.Name = "lblWiimoteZ";
            this.lblWiimoteZ.Size = new System.Drawing.Size(100, 13);
            this.lblWiimoteZ.TabIndex = 2;
            this.lblWiimoteZ.Text = "Z";
            // 
            // lblWiimoteY
            // 
            this.lblWiimoteY.Location = new System.Drawing.Point(6, 29);
            this.lblWiimoteY.Name = "lblWiimoteY";
            this.lblWiimoteY.Size = new System.Drawing.Size(100, 13);
            this.lblWiimoteY.TabIndex = 1;
            this.lblWiimoteY.Text = "Y";
            // 
            // lblWiimoteX
            // 
            this.lblWiimoteX.Location = new System.Drawing.Point(6, 16);
            this.lblWiimoteX.Name = "lblWiimoteX";
            this.lblWiimoteX.Size = new System.Drawing.Size(100, 13);
            this.lblWiimoteX.TabIndex = 0;
            this.lblWiimoteX.Text = "X";
            // 
            // gbNunchuck
            // 
            this.gbNunchuck.Controls.Add(this.gbJoysticks);
            this.gbNunchuck.Controls.Add(this.gbNunchuckAccelerometers);
            this.gbNunchuck.Controls.Add(this.clbNunchuck);
            this.gbNunchuck.Controls.Add(this.cbEnabled);
            this.gbNunchuck.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbNunchuck.Location = new System.Drawing.Point(3, 214);
            this.gbNunchuck.Name = "gbNunchuck";
            this.gbNunchuck.Size = new System.Drawing.Size(237, 145);
            this.gbNunchuck.TabIndex = 2;
            this.gbNunchuck.TabStop = false;
            this.gbNunchuck.Text = "Nunchuck";
            // 
            // gbJoysticks
            // 
            this.gbJoysticks.Controls.Add(this.lblNunJoyY);
            this.gbJoysticks.Controls.Add(this.lblNunJoyX);
            this.gbJoysticks.Location = new System.Drawing.Point(100, 82);
            this.gbJoysticks.Name = "gbJoysticks";
            this.gbJoysticks.Size = new System.Drawing.Size(115, 44);
            this.gbJoysticks.TabIndex = 4;
            this.gbJoysticks.TabStop = false;
            this.gbJoysticks.Text = "Joysticks";
            // 
            // lblNunJoyY
            // 
            this.lblNunJoyY.Location = new System.Drawing.Point(6, 29);
            this.lblNunJoyY.Name = "lblNunJoyY";
            this.lblNunJoyY.Size = new System.Drawing.Size(100, 13);
            this.lblNunJoyY.TabIndex = 6;
            this.lblNunJoyY.Text = "Y";
            // 
            // lblNunJoyX
            // 
            this.lblNunJoyX.Location = new System.Drawing.Point(6, 16);
            this.lblNunJoyX.Name = "lblNunJoyX";
            this.lblNunJoyX.Size = new System.Drawing.Size(100, 13);
            this.lblNunJoyX.TabIndex = 5;
            this.lblNunJoyX.Text = "X";
            // 
            // gbNunchuckAccelerometers
            // 
            this.gbNunchuckAccelerometers.Controls.Add(this.lblNunchuckZ);
            this.gbNunchuckAccelerometers.Controls.Add(this.lblNunchuckY);
            this.gbNunchuckAccelerometers.Controls.Add(this.lblNunchuckX);
            this.gbNunchuckAccelerometers.Location = new System.Drawing.Point(100, 19);
            this.gbNunchuckAccelerometers.Name = "gbNunchuckAccelerometers";
            this.gbNunchuckAccelerometers.Size = new System.Drawing.Size(116, 57);
            this.gbNunchuckAccelerometers.TabIndex = 2;
            this.gbNunchuckAccelerometers.TabStop = false;
            this.gbNunchuckAccelerometers.Text = "Accelerometers";
            // 
            // lblNunchuckZ
            // 
            this.lblNunchuckZ.Location = new System.Drawing.Point(6, 42);
            this.lblNunchuckZ.Name = "lblNunchuckZ";
            this.lblNunchuckZ.Size = new System.Drawing.Size(100, 13);
            this.lblNunchuckZ.TabIndex = 5;
            this.lblNunchuckZ.Text = "Z";
            // 
            // lblNunchuckY
            // 
            this.lblNunchuckY.Location = new System.Drawing.Point(6, 29);
            this.lblNunchuckY.Name = "lblNunchuckY";
            this.lblNunchuckY.Size = new System.Drawing.Size(100, 13);
            this.lblNunchuckY.TabIndex = 4;
            this.lblNunchuckY.Text = "Y";
            // 
            // lblNunchuckX
            // 
            this.lblNunchuckX.Location = new System.Drawing.Point(6, 16);
            this.lblNunchuckX.Name = "lblNunchuckX";
            this.lblNunchuckX.Size = new System.Drawing.Size(100, 13);
            this.lblNunchuckX.TabIndex = 3;
            this.lblNunchuckX.Text = "X";
            // 
            // clbNunchuck
            // 
            this.clbNunchuck.BackColor = System.Drawing.SystemColors.ControlDark;
            this.clbNunchuck.FormattingEnabled = true;
            this.clbNunchuck.Items.AddRange(new object[] {
            "C",
            "Z"});
            this.clbNunchuck.Location = new System.Drawing.Point(6, 42);
            this.clbNunchuck.Name = "clbNunchuck";
            this.clbNunchuck.Size = new System.Drawing.Size(88, 34);
            this.clbNunchuck.TabIndex = 0;
            // 
            // cbEnabled
            // 
            this.cbEnabled.AutoCheck = false;
            this.cbEnabled.AutoSize = true;
            this.cbEnabled.Location = new System.Drawing.Point(6, 19);
            this.cbEnabled.Name = "cbEnabled";
            this.cbEnabled.Size = new System.Drawing.Size(65, 17);
            this.cbEnabled.TabIndex = 3;
            this.cbEnabled.Text = "Enabled";
            this.cbEnabled.UseVisualStyleBackColor = true;
            // 
            // gbDevicePath
            // 
            this.gbDevicePath.Controls.Add(this.txtDevicePath);
            this.gbDevicePath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbDevicePath.Location = new System.Drawing.Point(3, 365);
            this.gbDevicePath.Name = "gbDevicePath";
            this.gbDevicePath.Size = new System.Drawing.Size(237, 47);
            this.gbDevicePath.TabIndex = 9;
            this.gbDevicePath.TabStop = false;
            this.gbDevicePath.Text = "Device Path";
            // 
            // txtDevicePath
            // 
            this.txtDevicePath.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtDevicePath.Location = new System.Drawing.Point(6, 19);
            this.txtDevicePath.Name = "txtDevicePath";
            this.txtDevicePath.ReadOnly = true;
            this.txtDevicePath.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtDevicePath.Size = new System.Drawing.Size(210, 20);
            this.txtDevicePath.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.helpToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1037, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.disconnectWiimoteToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // disconnectWiimoteToolStripMenuItem
            // 
            this.disconnectWiimoteToolStripMenuItem.Name = "disconnectWiimoteToolStripMenuItem";
            this.disconnectWiimoteToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.disconnectWiimoteToolStripMenuItem.Text = "Disconnect Wiimote";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.helpToolStripMenuItem.Text = "Tools";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDecimalPlaces});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // menuDecimalPlaces
            // 
            this.menuDecimalPlaces.AutoToolTip = true;
            this.menuDecimalPlaces.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.menuDecimalPlaces.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.menuDecimalPlaces.Name = "menuDecimalPlaces";
            this.menuDecimalPlaces.Size = new System.Drawing.Size(121, 23);
            this.menuDecimalPlaces.ToolTipText = "Decimal Places";
            this.menuDecimalPlaces.SelectedIndexChanged += new System.EventHandler(this.menuDecimalPlaces_SelectedIndexChanged);
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem1.Text = "Help";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tblblBattery,
            this.tbpbBattery,
            this.tblblBatteryPercent});
            this.statusStrip1.Location = new System.Drawing.Point(0, 445);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1037, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tblblBattery
            // 
            this.tblblBattery.BackColor = System.Drawing.Color.Transparent;
            this.tblblBattery.Name = "tblblBattery";
            this.tblblBattery.Size = new System.Drawing.Size(92, 17);
            this.tblblBattery.Text = "Wiimote Battery";
            // 
            // tbpbBattery
            // 
            this.tbpbBattery.Name = "tbpbBattery";
            this.tbpbBattery.Size = new System.Drawing.Size(100, 16);
            // 
            // tblblBatteryPercent
            // 
            this.tblblBatteryPercent.AutoSize = false;
            this.tblblBatteryPercent.BackColor = System.Drawing.Color.Transparent;
            this.tblblBatteryPercent.Name = "tblblBatteryPercent";
            this.tblblBatteryPercent.Size = new System.Drawing.Size(47, 17);
            this.tblblBatteryPercent.Text = "Percent";
            // 
            // gbIRPositioning
            // 
            this.gbIRPositioning.Controls.Add(this.groupBox5);
            this.gbIRPositioning.Controls.Add(this.pbIR);
            this.gbIRPositioning.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbIRPositioning.Location = new System.Drawing.Point(252, 3);
            this.gbIRPositioning.Name = "gbIRPositioning";
            this.gbIRPositioning.Size = new System.Drawing.Size(313, 415);
            this.gbIRPositioning.TabIndex = 12;
            this.gbIRPositioning.TabStop = false;
            this.gbIRPositioning.Text = "IR Positioning";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblIR3Raw);
            this.groupBox5.Controls.Add(this.lblIR1Raw);
            this.groupBox5.Controls.Add(this.lblIR4Raw);
            this.groupBox5.Controls.Add(this.lblIR2Raw);
            this.groupBox5.Controls.Add(this.lblIR3);
            this.groupBox5.Controls.Add(this.lblIR1);
            this.groupBox5.Controls.Add(this.lblIR4);
            this.groupBox5.Controls.Add(this.lblIR2);
            this.groupBox5.Controls.Add(this.chkFound3);
            this.groupBox5.Controls.Add(this.chkFound4);
            this.groupBox5.Controls.Add(this.chkFound1);
            this.groupBox5.Controls.Add(this.chkFound2);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox5.Location = new System.Drawing.Point(3, 224);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(307, 188);
            this.groupBox5.TabIndex = 35;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "IR Coordinates";
            // 
            // lblIR3Raw
            // 
            this.lblIR3Raw.AutoSize = true;
            this.lblIR3Raw.Location = new System.Drawing.Point(8, 112);
            this.lblIR3Raw.Name = "lblIR3Raw";
            this.lblIR3Raw.Size = new System.Drawing.Size(46, 13);
            this.lblIR3Raw.TabIndex = 10;
            this.lblIR3Raw.Text = "IR3Raw";
            // 
            // lblIR1Raw
            // 
            this.lblIR1Raw.AutoSize = true;
            this.lblIR1Raw.Location = new System.Drawing.Point(8, 80);
            this.lblIR1Raw.Name = "lblIR1Raw";
            this.lblIR1Raw.Size = new System.Drawing.Size(46, 13);
            this.lblIR1Raw.TabIndex = 10;
            this.lblIR1Raw.Text = "IR1Raw";
            // 
            // lblIR4Raw
            // 
            this.lblIR4Raw.AutoSize = true;
            this.lblIR4Raw.Location = new System.Drawing.Point(8, 128);
            this.lblIR4Raw.Name = "lblIR4Raw";
            this.lblIR4Raw.Size = new System.Drawing.Size(46, 13);
            this.lblIR4Raw.TabIndex = 9;
            this.lblIR4Raw.Text = "IR4Raw";
            // 
            // lblIR2Raw
            // 
            this.lblIR2Raw.AutoSize = true;
            this.lblIR2Raw.Location = new System.Drawing.Point(8, 96);
            this.lblIR2Raw.Name = "lblIR2Raw";
            this.lblIR2Raw.Size = new System.Drawing.Size(46, 13);
            this.lblIR2Raw.TabIndex = 9;
            this.lblIR2Raw.Text = "IR2Raw";
            // 
            // lblIR3
            // 
            this.lblIR3.AutoSize = true;
            this.lblIR3.Location = new System.Drawing.Point(8, 48);
            this.lblIR3.Name = "lblIR3";
            this.lblIR3.Size = new System.Drawing.Size(24, 13);
            this.lblIR3.TabIndex = 7;
            this.lblIR3.Text = "IR3";
            // 
            // lblIR1
            // 
            this.lblIR1.AutoSize = true;
            this.lblIR1.Location = new System.Drawing.Point(8, 16);
            this.lblIR1.Name = "lblIR1";
            this.lblIR1.Size = new System.Drawing.Size(24, 13);
            this.lblIR1.TabIndex = 7;
            this.lblIR1.Text = "IR1";
            // 
            // lblIR4
            // 
            this.lblIR4.AutoSize = true;
            this.lblIR4.Location = new System.Drawing.Point(8, 64);
            this.lblIR4.Name = "lblIR4";
            this.lblIR4.Size = new System.Drawing.Size(24, 13);
            this.lblIR4.TabIndex = 7;
            this.lblIR4.Text = "IR4";
            // 
            // lblIR2
            // 
            this.lblIR2.AutoSize = true;
            this.lblIR2.Location = new System.Drawing.Point(8, 32);
            this.lblIR2.Name = "lblIR2";
            this.lblIR2.Size = new System.Drawing.Size(24, 13);
            this.lblIR2.TabIndex = 7;
            this.lblIR2.Text = "IR2";
            // 
            // chkFound3
            // 
            this.chkFound3.AutoSize = true;
            this.chkFound3.Location = new System.Drawing.Point(60, 148);
            this.chkFound3.Name = "chkFound3";
            this.chkFound3.Size = new System.Drawing.Size(46, 17);
            this.chkFound3.TabIndex = 8;
            this.chkFound3.Text = "IR 3";
            this.chkFound3.UseVisualStyleBackColor = true;
            // 
            // chkFound4
            // 
            this.chkFound4.AutoSize = true;
            this.chkFound4.Location = new System.Drawing.Point(60, 164);
            this.chkFound4.Name = "chkFound4";
            this.chkFound4.Size = new System.Drawing.Size(46, 17);
            this.chkFound4.TabIndex = 8;
            this.chkFound4.Text = "IR 4";
            this.chkFound4.UseVisualStyleBackColor = true;
            // 
            // chkFound1
            // 
            this.chkFound1.AutoSize = true;
            this.chkFound1.Location = new System.Drawing.Point(8, 148);
            this.chkFound1.Name = "chkFound1";
            this.chkFound1.Size = new System.Drawing.Size(46, 17);
            this.chkFound1.TabIndex = 8;
            this.chkFound1.Text = "IR 1";
            this.chkFound1.UseVisualStyleBackColor = true;
            // 
            // chkFound2
            // 
            this.chkFound2.AutoSize = true;
            this.chkFound2.Location = new System.Drawing.Point(8, 164);
            this.chkFound2.Name = "chkFound2";
            this.chkFound2.Size = new System.Drawing.Size(46, 17);
            this.chkFound2.TabIndex = 8;
            this.chkFound2.Text = "IR 2";
            this.chkFound2.UseVisualStyleBackColor = true;
            // 
            // pbIR
            // 
            this.pbIR.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbIR.Location = new System.Drawing.Point(3, 16);
            this.pbIR.Name = "pbIR";
            this.pbIR.Size = new System.Drawing.Size(307, 159);
            this.pbIR.TabIndex = 0;
            this.pbIR.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbDisableRecognition);
            this.groupBox1.Controls.Add(this.cbDisableSpeech);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtDemoZ);
            this.groupBox1.Controls.Add(this.txtDemoY);
            this.groupBox1.Controls.Add(this.txtDemoX);
            this.groupBox1.Controls.Add(this.btnInput);
            this.groupBox1.Controls.Add(this.txtInput);
            this.groupBox1.Controls.Add(this.txtOutput);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(571, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(463, 415);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Voice Control";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(286, 354);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Z:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Y:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 354);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "X:";
            // 
            // txtDemoZ
            // 
            this.txtDemoZ.Location = new System.Drawing.Point(309, 351);
            this.txtDemoZ.Name = "txtDemoZ";
            this.txtDemoZ.ReadOnly = true;
            this.txtDemoZ.Size = new System.Drawing.Size(100, 20);
            this.txtDemoZ.TabIndex = 5;
            this.txtDemoZ.Text = "0";
            // 
            // txtDemoY
            // 
            this.txtDemoY.Location = new System.Drawing.Point(170, 351);
            this.txtDemoY.Name = "txtDemoY";
            this.txtDemoY.ReadOnly = true;
            this.txtDemoY.Size = new System.Drawing.Size(100, 20);
            this.txtDemoY.TabIndex = 4;
            this.txtDemoY.Text = "0";
            // 
            // txtDemoX
            // 
            this.txtDemoX.Location = new System.Drawing.Point(29, 350);
            this.txtDemoX.Name = "txtDemoX";
            this.txtDemoX.ReadOnly = true;
            this.txtDemoX.Size = new System.Drawing.Size(100, 20);
            this.txtDemoX.TabIndex = 3;
            this.txtDemoX.Text = "0";
            // 
            // btnInput
            // 
            this.btnInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInput.Location = new System.Drawing.Point(375, 320);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(75, 23);
            this.btnInput.TabIndex = 2;
            this.btnInput.Text = "Input";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // txtInput
            // 
            this.txtInput.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtInput.Location = new System.Drawing.Point(6, 320);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(363, 20);
            this.txtInput.TabIndex = 1;
            // 
            // txtOutput
            // 
            this.txtOutput.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtOutput.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtOutput.Location = new System.Drawing.Point(3, 16);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput.Size = new System.Drawing.Size(457, 297);
            this.txtOutput.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.91144F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.08856F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 468F));
            this.tableLayoutPanel1.Controls.Add(this.gbIRPositioning, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1037, 421);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.gbWiimote, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.gbNunchuck, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.gbDevicePath, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.3815F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.6185F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(243, 415);
            this.tableLayoutPanel2.TabIndex = 14;
            // 
            // cbDisableSpeech
            // 
            this.cbDisableSpeech.AutoSize = true;
            this.cbDisableSpeech.Location = new System.Drawing.Point(6, 386);
            this.cbDisableSpeech.Name = "cbDisableSpeech";
            this.cbDisableSpeech.Size = new System.Drawing.Size(149, 17);
            this.cbDisableSpeech.TabIndex = 9;
            this.cbDisableSpeech.Text = "Disable Speech Synthesis";
            this.cbDisableSpeech.UseVisualStyleBackColor = true;
            this.cbDisableSpeech.CheckedChanged += new System.EventHandler(this.cbDisableSpeech_CheckedChanged);
            // 
            // cbDisableRecognition
            // 
            this.cbDisableRecognition.AutoSize = true;
            this.cbDisableRecognition.Location = new System.Drawing.Point(161, 386);
            this.cbDisableRecognition.Name = "cbDisableRecognition";
            this.cbDisableRecognition.Size = new System.Drawing.Size(161, 17);
            this.cbDisableRecognition.TabIndex = 10;
            this.cbDisableRecognition.Text = "Disable Speech Recognition";
            this.cbDisableRecognition.UseVisualStyleBackColor = true;
            this.cbDisableRecognition.CheckedChanged += new System.EventHandler(this.cbDisableRecognition_CheckedChanged);
            // 
            // frmWiiInterface
            // 
            this.AcceptButton = this.btnInput;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(1037, 467);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmWiiInterface";
            this.Text = "Wii Interface";
            this.Load += new System.EventHandler(this.frmWiiInterface_Load);
            this.gbWiimote.ResumeLayout(false);
            this.gbWiimoteAccelerometers.ResumeLayout(false);
            this.gbNunchuck.ResumeLayout(false);
            this.gbNunchuck.PerformLayout();
            this.gbJoysticks.ResumeLayout(false);
            this.gbNunchuckAccelerometers.ResumeLayout(false);
            this.gbDevicePath.ResumeLayout(false);
            this.gbDevicePath.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.gbIRPositioning.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIR)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clbWiimote;
        private System.Windows.Forms.GroupBox gbWiimote;
        private System.Windows.Forms.GroupBox gbNunchuck;
        private System.Windows.Forms.CheckedListBox clbNunchuck;
        private System.Windows.Forms.CheckBox cbEnabled;
        private System.Windows.Forms.GroupBox gbWiimoteAccelerometers;
        private System.Windows.Forms.GroupBox gbJoysticks;
        private System.Windows.Forms.GroupBox gbNunchuckAccelerometers;
        private System.Windows.Forms.Label lblWiimoteX;
        private System.Windows.Forms.GroupBox gbDevicePath;
        private System.Windows.Forms.TextBox txtDevicePath;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tblblBattery;
        private System.Windows.Forms.ToolStripProgressBar tbpbBattery;
        private System.Windows.Forms.ToolStripStatusLabel tblblBatteryPercent;
        private System.Windows.Forms.Label lblWiimoteZ;
        private System.Windows.Forms.Label lblWiimoteY;
        private System.Windows.Forms.Label lblNunJoyY;
        private System.Windows.Forms.Label lblNunJoyX;
        private System.Windows.Forms.Label lblNunchuckZ;
        private System.Windows.Forms.Label lblNunchuckY;
        private System.Windows.Forms.Label lblNunchuckX;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripComboBox menuDecimalPlaces;
        private System.Windows.Forms.ToolStripMenuItem disconnectWiimoteToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbIRPositioning;
        public System.Windows.Forms.GroupBox groupBox5;
        public System.Windows.Forms.Label lblIR3Raw;
        public System.Windows.Forms.Label lblIR1Raw;
        public System.Windows.Forms.Label lblIR4Raw;
        public System.Windows.Forms.Label lblIR2Raw;
        public System.Windows.Forms.Label lblIR3;
        public System.Windows.Forms.Label lblIR1;
        public System.Windows.Forms.Label lblIR4;
        public System.Windows.Forms.Label lblIR2;
        public System.Windows.Forms.CheckBox chkFound3;
        public System.Windows.Forms.CheckBox chkFound4;
        public System.Windows.Forms.CheckBox chkFound1;
        public System.Windows.Forms.CheckBox chkFound2;
        private System.Windows.Forms.PictureBox pbIR;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnInput;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDemoZ;
        private System.Windows.Forms.TextBox txtDemoY;
        private System.Windows.Forms.TextBox txtDemoX;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.CheckBox cbDisableRecognition;
        private System.Windows.Forms.CheckBox cbDisableSpeech;
    }
}

