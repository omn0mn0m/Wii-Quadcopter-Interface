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
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDecimalPlaces = new System.Windows.Forms.ToolStripComboBox();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tblblBattery = new System.Windows.Forms.ToolStripStatusLabel();
            this.tbpbBattery = new System.Windows.Forms.ToolStripProgressBar();
            this.tblblBatteryPercent = new System.Windows.Forms.ToolStripStatusLabel();
            this.gbIRPositioning = new System.Windows.Forms.GroupBox();
            this.pbIR = new System.Windows.Forms.PictureBox();
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
            this.disconnectWiimoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbWiimote.SuspendLayout();
            this.gbWiimoteAccelerometers.SuspendLayout();
            this.gbNunchuck.SuspendLayout();
            this.gbJoysticks.SuspendLayout();
            this.gbNunchuckAccelerometers.SuspendLayout();
            this.gbDevicePath.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.gbIRPositioning.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIR)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // clbWiimote
            // 
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
            this.gbWiimote.Location = new System.Drawing.Point(14, 27);
            this.gbWiimote.Name = "gbWiimote";
            this.gbWiimote.Size = new System.Drawing.Size(225, 194);
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
            this.gbNunchuck.Location = new System.Drawing.Point(14, 227);
            this.gbNunchuck.Name = "gbNunchuck";
            this.gbNunchuck.Size = new System.Drawing.Size(225, 136);
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
            this.gbDevicePath.Location = new System.Drawing.Point(14, 369);
            this.gbDevicePath.Name = "gbDevicePath";
            this.gbDevicePath.Size = new System.Drawing.Size(225, 47);
            this.gbDevicePath.TabIndex = 9;
            this.gbDevicePath.TabStop = false;
            this.gbDevicePath.Text = "Device Path";
            // 
            // txtDevicePath
            // 
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
            this.menuStrip1.Size = new System.Drawing.Size(565, 24);
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 431);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(565, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tblblBattery
            // 
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
            this.tblblBatteryPercent.Name = "tblblBatteryPercent";
            this.tblblBatteryPercent.Size = new System.Drawing.Size(47, 17);
            this.tblblBatteryPercent.Text = "Percent";
            // 
            // gbIRPositioning
            // 
            this.gbIRPositioning.Controls.Add(this.groupBox5);
            this.gbIRPositioning.Controls.Add(this.pbIR);
            this.gbIRPositioning.Location = new System.Drawing.Point(258, 37);
            this.gbIRPositioning.Name = "gbIRPositioning";
            this.gbIRPositioning.Size = new System.Drawing.Size(295, 379);
            this.gbIRPositioning.TabIndex = 12;
            this.gbIRPositioning.TabStop = false;
            this.gbIRPositioning.Text = "IR Positioning";
            // 
            // pbIR
            // 
            this.pbIR.Location = new System.Drawing.Point(6, 19);
            this.pbIR.Name = "pbIR";
            this.pbIR.Size = new System.Drawing.Size(283, 159);
            this.pbIR.TabIndex = 0;
            this.pbIR.TabStop = false;
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
            this.groupBox5.Location = new System.Drawing.Point(6, 184);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(283, 188);
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
            // disconnectWiimoteToolStripMenuItem
            // 
            this.disconnectWiimoteToolStripMenuItem.Name = "disconnectWiimoteToolStripMenuItem";
            this.disconnectWiimoteToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.disconnectWiimoteToolStripMenuItem.Text = "Disconnect Wiimote";
            // 
            // frmWiiInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 453);
            this.Controls.Add(this.gbIRPositioning);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.gbDevicePath);
            this.Controls.Add(this.gbNunchuck);
            this.Controls.Add(this.gbWiimote);
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
            ((System.ComponentModel.ISupportInitialize)(this.pbIR)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
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
    }
}

