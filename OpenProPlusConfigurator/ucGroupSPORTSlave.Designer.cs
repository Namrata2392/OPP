﻿namespace OpenProPlusConfigurator
{
    partial class ucGroupSPORTSlave
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblISC = new System.Windows.Forms.Label();
            this.lvSPORTSlave = new System.Windows.Forms.ListView();
            this.grpSPORT = new System.Windows.Forms.GroupBox();
            this.chkbxEvent = new System.Windows.Forms.CheckBox();
            this.cmbSportType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkRun = new System.Windows.Forms.CheckBox();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.cmbDebug = new System.Windows.Forms.ComboBox();
            this.cmbIOASize = new System.Windows.Forms.ComboBox();
            this.cmbPortNo = new System.Windows.Forms.ComboBox();
            this.txtSlaveNum = new System.Windows.Forms.TextBox();
            this.lblSN = new System.Windows.Forms.Label();
            this.lblDebug = new System.Windows.Forms.Label();
            this.txtFirmwareVersion = new System.Windows.Forms.TextBox();
            this.lblAFV = new System.Windows.Forms.Label();
            this.txtEventQSize = new System.Windows.Forms.TextBox();
            this.lblEQS = new System.Windows.Forms.Label();
            this.lblIOA = new System.Windows.Forms.Label();
            this.txtASDUaddress = new System.Windows.Forms.TextBox();
            this.lblASDU = new System.Windows.Forms.Label();
            this.lblLIP = new System.Windows.Forms.Label();
            this.lblHdrText = new System.Windows.Forms.Label();
            this.pbHdr = new System.Windows.Forms.PictureBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnexportSPORTINI = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.grpSPORT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHdr)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblISC
            // 
            this.lblISC.AutoSize = true;
            this.lblISC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblISC.Location = new System.Drawing.Point(2, 0);
            this.lblISC.Name = "lblISC";
            this.lblISC.Size = new System.Drawing.Size(186, 15);
            this.lblISC.TabIndex = 5;
            this.lblISC.Text = "SPORT Slave Configuration:";
            // 
            // lvSPORTSlave
            // 
            this.lvSPORTSlave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvSPORTSlave.CheckBoxes = true;
            this.lvSPORTSlave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvSPORTSlave.FullRowSelect = true;
            this.lvSPORTSlave.Location = new System.Drawing.Point(0, 30);
            this.lvSPORTSlave.MultiSelect = false;
            this.lvSPORTSlave.Name = "lvSPORTSlave";
            this.lvSPORTSlave.Size = new System.Drawing.Size(1050, 624);
            this.lvSPORTSlave.TabIndex = 6;
            this.lvSPORTSlave.UseCompatibleStateImageBehavior = false;
            this.lvSPORTSlave.View = System.Windows.Forms.View.Details;
            this.lvSPORTSlave.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.lvIEC101Slave_ItemCheck);
            this.lvSPORTSlave.SelectedIndexChanged += new System.EventHandler(this.lvIEC101Slave_SelectedIndexChanged);
            this.lvSPORTSlave.DoubleClick += new System.EventHandler(this.lvSPORTSlave_DoubleClick);
            // 
            // grpSPORT
            // 
            this.grpSPORT.BackColor = System.Drawing.SystemColors.Control;
            this.grpSPORT.Controls.Add(this.chkbxEvent);
            this.grpSPORT.Controls.Add(this.cmbSportType);
            this.grpSPORT.Controls.Add(this.label1);
            this.grpSPORT.Controls.Add(this.chkRun);
            this.grpSPORT.Controls.Add(this.btnLast);
            this.grpSPORT.Controls.Add(this.btnNext);
            this.grpSPORT.Controls.Add(this.btnPrev);
            this.grpSPORT.Controls.Add(this.btnFirst);
            this.grpSPORT.Controls.Add(this.cmbDebug);
            this.grpSPORT.Controls.Add(this.cmbIOASize);
            this.grpSPORT.Controls.Add(this.cmbPortNo);
            this.grpSPORT.Controls.Add(this.txtSlaveNum);
            this.grpSPORT.Controls.Add(this.lblSN);
            this.grpSPORT.Controls.Add(this.lblDebug);
            this.grpSPORT.Controls.Add(this.txtFirmwareVersion);
            this.grpSPORT.Controls.Add(this.lblAFV);
            this.grpSPORT.Controls.Add(this.txtEventQSize);
            this.grpSPORT.Controls.Add(this.lblEQS);
            this.grpSPORT.Controls.Add(this.lblIOA);
            this.grpSPORT.Controls.Add(this.txtASDUaddress);
            this.grpSPORT.Controls.Add(this.lblASDU);
            this.grpSPORT.Controls.Add(this.lblLIP);
            this.grpSPORT.Controls.Add(this.lblHdrText);
            this.grpSPORT.Controls.Add(this.pbHdr);
            this.grpSPORT.Controls.Add(this.btnCancel);
            this.grpSPORT.Controls.Add(this.btnDone);
            this.grpSPORT.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grpSPORT.Location = new System.Drawing.Point(352, 94);
            this.grpSPORT.Name = "grpSPORT";
            this.grpSPORT.Size = new System.Drawing.Size(321, 296);
            this.grpSPORT.TabIndex = 18;
            this.grpSPORT.TabStop = false;
            this.grpSPORT.Visible = false;
            this.grpSPORT.Enter += new System.EventHandler(this.grpIEC104_Enter);
            // 
            // chkbxEvent
            // 
            this.chkbxEvent.AutoSize = true;
            this.chkbxEvent.Location = new System.Drawing.Point(8, 257);
            this.chkbxEvent.Name = "chkbxEvent";
            this.chkbxEvent.Size = new System.Drawing.Size(54, 17);
            this.chkbxEvent.TabIndex = 134;
            this.chkbxEvent.Tag = "Event_YES_NO";
            this.chkbxEvent.Text = "Event";
            this.chkbxEvent.UseVisualStyleBackColor = true;
            this.chkbxEvent.Visible = false;
            // 
            // cmbSportType
            // 
            this.cmbSportType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSportType.FormattingEnabled = true;
            this.cmbSportType.Location = new System.Drawing.Point(121, 103);
            this.cmbSportType.Name = "cmbSportType";
            this.cmbSportType.Size = new System.Drawing.Size(182, 21);
            this.cmbSportType.TabIndex = 123;
            this.cmbSportType.Tag = "SportType";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 121;
            this.label1.Text = "SPORT Type";
            // 
            // chkRun
            // 
            this.chkRun.AutoSize = true;
            this.chkRun.Location = new System.Drawing.Point(13, 234);
            this.chkRun.Name = "chkRun";
            this.chkRun.Size = new System.Drawing.Size(46, 17);
            this.chkRun.TabIndex = 120;
            this.chkRun.Tag = "Run_YES_NO";
            this.chkRun.Text = "Run";
            this.chkRun.UseVisualStyleBackColor = true;
            // 
            // btnLast
            // 
            this.btnLast.FlatAppearance.BorderSize = 0;
            this.btnLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLast.Location = new System.Drawing.Point(243, 268);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(59, 22);
            this.btnLast.TabIndex = 119;
            this.btnLast.Text = "Last>>";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnNext
            // 
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(165, 268);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(59, 22);
            this.btnNext.TabIndex = 118;
            this.btnNext.Text = "Next>";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.FlatAppearance.BorderSize = 0;
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrev.Location = new System.Drawing.Point(87, 268);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(59, 22);
            this.btnPrev.TabIndex = 117;
            this.btnPrev.Text = "<Prev";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.FlatAppearance.BorderSize = 0;
            this.btnFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirst.Location = new System.Drawing.Point(9, 268);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(59, 22);
            this.btnFirst.TabIndex = 116;
            this.btnFirst.Text = "<<First";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // cmbDebug
            // 
            this.cmbDebug.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDebug.FormattingEnabled = true;
            this.cmbDebug.Location = new System.Drawing.Point(121, 201);
            this.cmbDebug.Name = "cmbDebug";
            this.cmbDebug.Size = new System.Drawing.Size(182, 21);
            this.cmbDebug.TabIndex = 91;
            this.cmbDebug.Tag = "DEBUG";
            // 
            // cmbIOASize
            // 
            this.cmbIOASize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIOASize.FormattingEnabled = true;
            this.cmbIOASize.Location = new System.Drawing.Point(121, 128);
            this.cmbIOASize.Name = "cmbIOASize";
            this.cmbIOASize.Size = new System.Drawing.Size(182, 21);
            this.cmbIOASize.TabIndex = 69;
            this.cmbIOASize.Tag = "IOASize";
            // 
            // cmbPortNo
            // 
            this.cmbPortNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPortNo.FormattingEnabled = true;
            this.cmbPortNo.Location = new System.Drawing.Point(121, 54);
            this.cmbPortNo.Name = "cmbPortNo";
            this.cmbPortNo.Size = new System.Drawing.Size(182, 21);
            this.cmbPortNo.TabIndex = 115;
            this.cmbPortNo.Tag = "PortNum";
            // 
            // txtSlaveNum
            // 
            this.txtSlaveNum.Enabled = false;
            this.txtSlaveNum.Location = new System.Drawing.Point(121, 30);
            this.txtSlaveNum.Name = "txtSlaveNum";
            this.txtSlaveNum.Size = new System.Drawing.Size(182, 20);
            this.txtSlaveNum.TabIndex = 57;
            this.txtSlaveNum.Tag = "SlaveNum";
            // 
            // lblSN
            // 
            this.lblSN.AutoSize = true;
            this.lblSN.Location = new System.Drawing.Point(7, 33);
            this.lblSN.Name = "lblSN";
            this.lblSN.Size = new System.Drawing.Size(54, 13);
            this.lblSN.TabIndex = 56;
            this.lblSN.Text = "Slave No.";
            // 
            // lblDebug
            // 
            this.lblDebug.AutoSize = true;
            this.lblDebug.Location = new System.Drawing.Point(7, 204);
            this.lblDebug.Name = "lblDebug";
            this.lblDebug.Size = new System.Drawing.Size(68, 13);
            this.lblDebug.TabIndex = 90;
            this.lblDebug.Text = "Debug Level";
            // 
            // txtFirmwareVersion
            // 
            this.txtFirmwareVersion.Enabled = false;
            this.txtFirmwareVersion.Location = new System.Drawing.Point(121, 177);
            this.txtFirmwareVersion.Name = "txtFirmwareVersion";
            this.txtFirmwareVersion.Size = new System.Drawing.Size(182, 20);
            this.txtFirmwareVersion.TabIndex = 89;
            this.txtFirmwareVersion.Tag = "AppFirmwareVersion";
            // 
            // lblAFV
            // 
            this.lblAFV.AutoSize = true;
            this.lblAFV.Location = new System.Drawing.Point(7, 180);
            this.lblAFV.Name = "lblAFV";
            this.lblAFV.Size = new System.Drawing.Size(87, 13);
            this.lblAFV.TabIndex = 88;
            this.lblAFV.Text = "Firmware Version";
            // 
            // txtEventQSize
            // 
            this.txtEventQSize.Enabled = false;
            this.txtEventQSize.Location = new System.Drawing.Point(121, 153);
            this.txtEventQSize.Name = "txtEventQSize";
            this.txtEventQSize.Size = new System.Drawing.Size(182, 20);
            this.txtEventQSize.TabIndex = 87;
            this.txtEventQSize.Tag = "EventQSize";
            // 
            // lblEQS
            // 
            this.lblEQS.AutoSize = true;
            this.lblEQS.Location = new System.Drawing.Point(7, 156);
            this.lblEQS.Name = "lblEQS";
            this.lblEQS.Size = new System.Drawing.Size(93, 13);
            this.lblEQS.TabIndex = 86;
            this.lblEQS.Text = "Event Queue Size";
            // 
            // lblIOA
            // 
            this.lblIOA.AutoSize = true;
            this.lblIOA.Location = new System.Drawing.Point(7, 131);
            this.lblIOA.Name = "lblIOA";
            this.lblIOA.Size = new System.Drawing.Size(48, 13);
            this.lblIOA.TabIndex = 68;
            this.lblIOA.Text = "IOA Size";
            // 
            // txtASDUaddress
            // 
            this.txtASDUaddress.Location = new System.Drawing.Point(121, 79);
            this.txtASDUaddress.Name = "txtASDUaddress";
            this.txtASDUaddress.Size = new System.Drawing.Size(182, 20);
            this.txtASDUaddress.TabIndex = 65;
            this.txtASDUaddress.Tag = "ASDUAddress";
            // 
            // lblASDU
            // 
            this.lblASDU.AutoSize = true;
            this.lblASDU.Location = new System.Drawing.Point(7, 82);
            this.lblASDU.Name = "lblASDU";
            this.lblASDU.Size = new System.Drawing.Size(78, 13);
            this.lblASDU.TabIndex = 64;
            this.lblASDU.Text = "ASDU Address";
            // 
            // lblLIP
            // 
            this.lblLIP.AutoSize = true;
            this.lblLIP.Location = new System.Drawing.Point(7, 57);
            this.lblLIP.Name = "lblLIP";
            this.lblLIP.Size = new System.Drawing.Size(46, 13);
            this.lblLIP.TabIndex = 58;
            this.lblLIP.Text = "Port No.";
            // 
            // lblHdrText
            // 
            this.lblHdrText.AutoSize = true;
            this.lblHdrText.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lblHdrText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHdrText.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblHdrText.Location = new System.Drawing.Point(10, 4);
            this.lblHdrText.Name = "lblHdrText";
            this.lblHdrText.Size = new System.Drawing.Size(85, 13);
            this.lblHdrText.TabIndex = 40;
            this.lblHdrText.Text = "SPORT Slave";
            this.lblHdrText.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblHdrText_MouseDown);
            this.lblHdrText.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblHdrText_MouseMove);
            // 
            // pbHdr
            // 
            this.pbHdr.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pbHdr.Location = new System.Drawing.Point(0, 0);
            this.pbHdr.Name = "pbHdr";
            this.pbHdr.Size = new System.Drawing.Size(321, 22);
            this.pbHdr.TabIndex = 39;
            this.pbHdr.TabStop = false;
            this.pbHdr.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbHdr_MouseDown);
            this.pbHdr.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbHdr_MouseMove);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Location = new System.Drawing.Point(235, 234);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(68, 28);
            this.btnCancel.TabIndex = 94;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDone
            // 
            this.btnDone.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDone.Location = new System.Drawing.Point(121, 234);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(68, 28);
            this.btnDone.TabIndex = 93;
            this.btnDone.Text = "&Update";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Location = new System.Drawing.Point(80, 9);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(68, 28);
            this.btnDelete.TabIndex = 24;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Location = new System.Drawing.Point(3, 9);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(68, 28);
            this.btnAdd.TabIndex = 23;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnexportSPORTINI
            // 
            this.btnexportSPORTINI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnexportSPORTINI.FlatAppearance.BorderSize = 0;
            this.btnexportSPORTINI.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnexportSPORTINI.Location = new System.Drawing.Point(160, 9);
            this.btnexportSPORTINI.Name = "btnexportSPORTINI";
            this.btnexportSPORTINI.Size = new System.Drawing.Size(68, 28);
            this.btnexportSPORTINI.TabIndex = 25;
            this.btnexportSPORTINI.Text = "&Export INI";
            this.btnexportSPORTINI.UseVisualStyleBackColor = true;
            this.btnexportSPORTINI.Click += new System.EventHandler(this.btnexportSPORTINI_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblISC);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1050, 30);
            this.panel1.TabIndex = 26;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnexportSPORTINI);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 654);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1050, 46);
            this.panel2.TabIndex = 27;
            // 
            // ucGroupSPORTSlave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpSPORT);
            this.Controls.Add(this.lvSPORTSlave);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ucGroupSPORTSlave";
            this.Size = new System.Drawing.Size(1050, 700);
            this.grpSPORT.ResumeLayout(false);
            this.grpSPORT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHdr)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblISC;
        public System.Windows.Forms.ListView lvSPORTSlave;
        public System.Windows.Forms.GroupBox grpSPORT;
        public System.Windows.Forms.ComboBox cmbDebug;
        public System.Windows.Forms.ComboBox cmbIOASize;
        public System.Windows.Forms.ComboBox cmbPortNo;
        public System.Windows.Forms.TextBox txtSlaveNum;
        private System.Windows.Forms.Label lblSN;
        private System.Windows.Forms.Label lblDebug;
        public System.Windows.Forms.TextBox txtFirmwareVersion;
        private System.Windows.Forms.Label lblAFV;
        public System.Windows.Forms.TextBox txtEventQSize;
        private System.Windows.Forms.Label lblEQS;
        private System.Windows.Forms.Label lblIOA;
        public System.Windows.Forms.TextBox txtASDUaddress;
        private System.Windows.Forms.Label lblASDU;
        private System.Windows.Forms.Label lblLIP;
        private System.Windows.Forms.Label lblHdrText;
        private System.Windows.Forms.PictureBox pbHdr;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDone;
        public System.Windows.Forms.Button btnDelete;
        public System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.Button btnexportSPORTINI;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnFirst;
        public System.Windows.Forms.CheckBox chkRun;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cmbSportType;
        public System.Windows.Forms.CheckBox chkbxEvent;
    }
}
