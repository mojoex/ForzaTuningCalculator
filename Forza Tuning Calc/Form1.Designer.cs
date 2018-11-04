namespace Forza_Tuning_Calculator
{
    partial class ForzaTuningCalc
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Tyres", System.Windows.Forms.HorizontalAlignment.Center);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Alignment", System.Windows.Forms.HorizontalAlignment.Center);
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("Anti Roll Bars", System.Windows.Forms.HorizontalAlignment.Center);
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("Springs", System.Windows.Forms.HorizontalAlignment.Center);
            System.Windows.Forms.ListViewGroup listViewGroup5 = new System.Windows.Forms.ListViewGroup("Damping", System.Windows.Forms.HorizontalAlignment.Center);
            System.Windows.Forms.ListViewGroup listViewGroup6 = new System.Windows.Forms.ListViewGroup("Aero", System.Windows.Forms.HorizontalAlignment.Center);
            System.Windows.Forms.ListViewGroup listViewGroup7 = new System.Windows.Forms.ListViewGroup("Differential", System.Windows.Forms.HorizontalAlignment.Center);
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Spring Rates");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Ride Height");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("Rebound");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("Bump");
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("ARB");
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("Tyre Pressure");
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem("Camber");
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem("Castor");
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem("Acceleration");
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem("Deceleration");
            System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem("Bias");
            System.Windows.Forms.ListViewItem listViewItem12 = new System.Windows.Forms.ListViewItem("Downforce");
            System.Windows.Forms.ListViewItem listViewItem13 = new System.Windows.Forms.ListViewItem("Toe");
            this.lblFrontWeight = new System.Windows.Forms.Label();
            this.inputFrontWeight = new System.Windows.Forms.TextBox();
            this.gbDamping = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.inputReboundMax = new System.Windows.Forms.TextBox();
            this.lblRebound = new System.Windows.Forms.Label();
            this.inputReboundMin = new System.Windows.Forms.TextBox();
            this.gbSprings = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.inputSpringMax = new System.Windows.Forms.TextBox();
            this.lblFrontSpring = new System.Windows.Forms.Label();
            this.inputSpringMin = new System.Windows.Forms.TextBox();
            this.btnTune = new System.Windows.Forms.Button();
            this.gbInputs = new System.Windows.Forms.GroupBox();
            this.cmbDrivetrain = new System.Windows.Forms.ComboBox();
            this.chkWeightBased = new System.Windows.Forms.CheckBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.inputWeight = new System.Windows.Forms.TextBox();
            this.gbArbs = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.inputArbMax = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.inputArbMin = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.gbResults = new System.Windows.Forms.GroupBox();
            this.resultsList = new System.Windows.Forms.ListView();
            this.settingHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.frontValueHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rearValueHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbOverallStiffness = new System.Windows.Forms.GroupBox();
            this.cmbStiffness = new System.Windows.Forms.ComboBox();
            this.lnkFineTuning = new System.Windows.Forms.LinkLabel();
            this.gbDamping.SuspendLayout();
            this.gbSprings.SuspendLayout();
            this.gbInputs.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.gbArbs.SuspendLayout();
            this.gbResults.SuspendLayout();
            this.gbOverallStiffness.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFrontWeight
            // 
            this.lblFrontWeight.AutoSize = true;
            this.lblFrontWeight.Location = new System.Drawing.Point(6, 52);
            this.lblFrontWeight.Name = "lblFrontWeight";
            this.lblFrontWeight.Size = new System.Drawing.Size(79, 13);
            this.lblFrontWeight.TabIndex = 0;
            this.lblFrontWeight.Text = "Front Weight %";
            this.lblFrontWeight.Click += new System.EventHandler(this.label1_Click);
            // 
            // inputFrontWeight
            // 
            this.inputFrontWeight.Location = new System.Drawing.Point(112, 49);
            this.inputFrontWeight.Name = "inputFrontWeight";
            this.inputFrontWeight.Size = new System.Drawing.Size(58, 20);
            this.inputFrontWeight.TabIndex = 1;
            this.inputFrontWeight.TextChanged += new System.EventHandler(this.txtFrontWeight_TextChanged);
            // 
            // gbDamping
            // 
            this.gbDamping.Controls.Add(this.label4);
            this.gbDamping.Controls.Add(this.inputReboundMax);
            this.gbDamping.Controls.Add(this.lblRebound);
            this.gbDamping.Controls.Add(this.inputReboundMin);
            this.gbDamping.Location = new System.Drawing.Point(6, 204);
            this.gbDamping.Name = "gbDamping";
            this.gbDamping.Size = new System.Drawing.Size(278, 57);
            this.gbDamping.TabIndex = 5;
            this.gbDamping.TabStop = false;
            this.gbDamping.Text = "Damping";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(242, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "*";
            // 
            // inputReboundMax
            // 
            this.inputReboundMax.Location = new System.Drawing.Point(176, 26);
            this.inputReboundMax.Name = "inputReboundMax";
            this.inputReboundMax.Size = new System.Drawing.Size(60, 20);
            this.inputReboundMax.TabIndex = 4;
            this.inputReboundMax.Text = "20";
            this.inputReboundMax.TextChanged += new System.EventHandler(this.txtRebMax_TextChanged);
            // 
            // lblRebound
            // 
            this.lblRebound.AutoSize = true;
            this.lblRebound.Location = new System.Drawing.Point(6, 29);
            this.lblRebound.Name = "lblRebound";
            this.lblRebound.Size = new System.Drawing.Size(100, 13);
            this.lblRebound.TabIndex = 2;
            this.lblRebound.Text = "Rebound (min/max)";
            this.lblRebound.Click += new System.EventHandler(this.lblRebound_Click);
            // 
            // inputReboundMin
            // 
            this.inputReboundMin.Location = new System.Drawing.Point(112, 26);
            this.inputReboundMin.Name = "inputReboundMin";
            this.inputReboundMin.Size = new System.Drawing.Size(58, 20);
            this.inputReboundMin.TabIndex = 3;
            this.inputReboundMin.Text = "3";
            this.inputReboundMin.TextChanged += new System.EventHandler(this.txtRebMin_TextChanged);
            // 
            // gbSprings
            // 
            this.gbSprings.Controls.Add(this.label2);
            this.gbSprings.Controls.Add(this.inputSpringMax);
            this.gbSprings.Controls.Add(this.lblFrontSpring);
            this.gbSprings.Controls.Add(this.inputSpringMin);
            this.gbSprings.Location = new System.Drawing.Point(6, 140);
            this.gbSprings.Name = "gbSprings";
            this.gbSprings.Size = new System.Drawing.Size(278, 58);
            this.gbSprings.TabIndex = 6;
            this.gbSprings.TabStop = false;
            this.gbSprings.Text = "Springs";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(242, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "*";
            // 
            // inputSpringMax
            // 
            this.inputSpringMax.Location = new System.Drawing.Point(176, 26);
            this.inputSpringMax.Name = "inputSpringMax";
            this.inputSpringMax.Size = new System.Drawing.Size(60, 20);
            this.inputSpringMax.TabIndex = 4;
            this.inputSpringMax.TextChanged += new System.EventHandler(this.txtFrontSpringMax_TextChanged);
            // 
            // lblFrontSpring
            // 
            this.lblFrontSpring.AutoSize = true;
            this.lblFrontSpring.Location = new System.Drawing.Point(6, 29);
            this.lblFrontSpring.Name = "lblFrontSpring";
            this.lblFrontSpring.Size = new System.Drawing.Size(80, 13);
            this.lblFrontSpring.TabIndex = 2;
            this.lblFrontSpring.Text = "Front (min/max)";
            this.lblFrontSpring.Click += new System.EventHandler(this.lblFrontSpring_Click);
            // 
            // inputSpringMin
            // 
            this.inputSpringMin.Location = new System.Drawing.Point(112, 26);
            this.inputSpringMin.Name = "inputSpringMin";
            this.inputSpringMin.Size = new System.Drawing.Size(58, 20);
            this.inputSpringMin.TabIndex = 3;
            this.inputSpringMin.TextChanged += new System.EventHandler(this.txtFrontSpringMin_TextChanged);
            // 
            // btnTune
            // 
            this.btnTune.Location = new System.Drawing.Point(12, 471);
            this.btnTune.Name = "btnTune";
            this.btnTune.Size = new System.Drawing.Size(299, 23);
            this.btnTune.TabIndex = 7;
            this.btnTune.Text = "Tune";
            this.btnTune.UseVisualStyleBackColor = true;
            this.btnTune.Click += new System.EventHandler(this.btnTune_Click);
            // 
            // gbInputs
            // 
            this.gbInputs.Controls.Add(this.cmbDrivetrain);
            this.gbInputs.Controls.Add(this.gbSprings);
            this.gbInputs.Controls.Add(this.chkWeightBased);
            this.gbInputs.Controls.Add(this.groupBox9);
            this.gbInputs.Controls.Add(this.gbArbs);
            this.gbInputs.Controls.Add(this.linkLabel1);
            this.gbInputs.Controls.Add(this.gbDamping);
            this.gbInputs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInputs.Location = new System.Drawing.Point(12, 12);
            this.gbInputs.Name = "gbInputs";
            this.gbInputs.Size = new System.Drawing.Size(299, 342);
            this.gbInputs.TabIndex = 13;
            this.gbInputs.TabStop = false;
            this.gbInputs.Text = "Input Values";
            // 
            // cmbDrivetrain
            // 
            this.cmbDrivetrain.FormattingEnabled = true;
            this.cmbDrivetrain.Location = new System.Drawing.Point(15, 29);
            this.cmbDrivetrain.Name = "cmbDrivetrain";
            this.cmbDrivetrain.Size = new System.Drawing.Size(67, 21);
            this.cmbDrivetrain.TabIndex = 11;
            this.cmbDrivetrain.SelectedIndexChanged += new System.EventHandler(this.cmbDrivetrain_SelectedIndexChanged);
            // 
            // chkWeightBased
            // 
            this.chkWeightBased.AutoSize = true;
            this.chkWeightBased.Location = new System.Drawing.Point(118, 31);
            this.chkWeightBased.Name = "chkWeightBased";
            this.chkWeightBased.Size = new System.Drawing.Size(166, 17);
            this.chkWeightBased.TabIndex = 10;
            this.chkWeightBased.Text = "Weight Based Tuning (BETA)";
            this.chkWeightBased.UseVisualStyleBackColor = true;
            this.chkWeightBased.CheckedChanged += new System.EventHandler(this.chkWeightBased_CheckedChanged);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.label10);
            this.groupBox9.Controls.Add(this.inputFrontWeight);
            this.groupBox9.Controls.Add(this.lblFrontWeight);
            this.groupBox9.Controls.Add(this.inputWeight);
            this.groupBox9.Location = new System.Drawing.Point(6, 56);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(278, 78);
            this.groupBox9.TabIndex = 6;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Weight";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Weight (kg)";
            // 
            // inputWeight
            // 
            this.inputWeight.Location = new System.Drawing.Point(112, 18);
            this.inputWeight.Name = "inputWeight";
            this.inputWeight.ReadOnly = true;
            this.inputWeight.Size = new System.Drawing.Size(58, 20);
            this.inputWeight.TabIndex = 1;
            this.inputWeight.TextChanged += new System.EventHandler(this.txtWeight_TextChanged_1);
            // 
            // gbArbs
            // 
            this.gbArbs.Controls.Add(this.label11);
            this.gbArbs.Controls.Add(this.inputArbMax);
            this.gbArbs.Controls.Add(this.label12);
            this.gbArbs.Controls.Add(this.inputArbMin);
            this.gbArbs.Location = new System.Drawing.Point(6, 267);
            this.gbArbs.Name = "gbArbs";
            this.gbArbs.Size = new System.Drawing.Size(278, 63);
            this.gbArbs.TabIndex = 9;
            this.gbArbs.TabStop = false;
            this.gbArbs.Text = "ARBs";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(242, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(11, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "*";
            // 
            // inputArbMax
            // 
            this.inputArbMax.Location = new System.Drawing.Point(176, 26);
            this.inputArbMax.Name = "inputArbMax";
            this.inputArbMax.Size = new System.Drawing.Size(60, 20);
            this.inputArbMax.TabIndex = 4;
            this.inputArbMax.Text = "65";
            this.inputArbMax.TextChanged += new System.EventHandler(this.txtFrontArbMax_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Front (min/max)";
            // 
            // inputArbMin
            // 
            this.inputArbMin.Location = new System.Drawing.Point(112, 26);
            this.inputArbMin.Name = "inputArbMin";
            this.inputArbMin.Size = new System.Drawing.Size(58, 20);
            this.inputArbMin.TabIndex = 3;
            this.inputArbMin.Text = "1";
            this.inputArbMin.TextChanged += new System.EventHandler(this.txtFrontArbMin_TextChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(15, 20);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(0, 13);
            this.linkLabel1.TabIndex = 7;
            // 
            // gbResults
            // 
            this.gbResults.Controls.Add(this.resultsList);
            this.gbResults.Location = new System.Drawing.Point(317, 12);
            this.gbResults.Name = "gbResults";
            this.gbResults.Size = new System.Drawing.Size(383, 488);
            this.gbResults.TabIndex = 14;
            this.gbResults.TabStop = false;
            this.gbResults.Text = "Results";
            // 
            // resultsList
            // 
            this.resultsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.settingHeader,
            this.frontValueHeader,
            this.rearValueHeader});
            listViewGroup1.Header = "Tyres";
            listViewGroup1.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            listViewGroup1.Name = "Tyres";
            listViewGroup2.Header = "Alignment";
            listViewGroup2.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            listViewGroup2.Name = "Alignment";
            listViewGroup3.Header = "Anti Roll Bars";
            listViewGroup3.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            listViewGroup3.Name = "Anti Roll Bars";
            listViewGroup4.Header = "Springs";
            listViewGroup4.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            listViewGroup4.Name = "Springs";
            listViewGroup4.Tag = "Springs";
            listViewGroup5.Header = "Damping";
            listViewGroup5.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            listViewGroup5.Name = "Damping";
            listViewGroup5.Tag = "Damping";
            listViewGroup6.Header = "Aero";
            listViewGroup6.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            listViewGroup6.Name = "Aero";
            listViewGroup7.Header = "Differential";
            listViewGroup7.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            listViewGroup7.Name = "Differential";
            this.resultsList.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2,
            listViewGroup3,
            listViewGroup4,
            listViewGroup5,
            listViewGroup6,
            listViewGroup7});
            listViewItem1.Group = listViewGroup4;
            listViewItem1.IndentCount = 1;
            listViewItem1.Tag = "SpringRates";
            listViewItem2.Group = listViewGroup4;
            listViewItem3.Group = listViewGroup5;
            listViewItem4.Group = listViewGroup5;
            listViewItem5.Group = listViewGroup3;
            listViewItem6.Group = listViewGroup1;
            listViewItem7.Group = listViewGroup2;
            listViewItem8.Group = listViewGroup2;
            listViewItem9.Group = listViewGroup7;
            listViewItem10.Group = listViewGroup7;
            listViewItem11.Group = listViewGroup7;
            listViewItem12.Group = listViewGroup6;
            listViewItem13.Group = listViewGroup2;
            this.resultsList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6,
            listViewItem7,
            listViewItem8,
            listViewItem9,
            listViewItem10,
            listViewItem11,
            listViewItem12,
            listViewItem13});
            this.resultsList.Location = new System.Drawing.Point(6, 19);
            this.resultsList.Name = "resultsList";
            this.resultsList.Size = new System.Drawing.Size(367, 463);
            this.resultsList.TabIndex = 14;
            this.resultsList.UseCompatibleStateImageBehavior = false;
            this.resultsList.View = System.Windows.Forms.View.Details;
            this.resultsList.SelectedIndexChanged += new System.EventHandler(this.resultsList_SelectedIndexChanged);
            // 
            // settingHeader
            // 
            this.settingHeader.Text = "Setting";
            this.settingHeader.Width = 83;
            // 
            // frontValueHeader
            // 
            this.frontValueHeader.Text = "Front / Default";
            this.frontValueHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.frontValueHeader.Width = 141;
            // 
            // rearValueHeader
            // 
            this.rearValueHeader.Text = "Rear";
            this.rearValueHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.rearValueHeader.Width = 129;
            // 
            // gbOverallStiffness
            // 
            this.gbOverallStiffness.Controls.Add(this.cmbStiffness);
            this.gbOverallStiffness.Location = new System.Drawing.Point(12, 360);
            this.gbOverallStiffness.Name = "gbOverallStiffness";
            this.gbOverallStiffness.Size = new System.Drawing.Size(299, 47);
            this.gbOverallStiffness.TabIndex = 3;
            this.gbOverallStiffness.TabStop = false;
            this.gbOverallStiffness.Text = "Adjust Stiffness";
            // 
            // cmbStiffness
            // 
            this.cmbStiffness.FormattingEnabled = true;
            this.cmbStiffness.Items.AddRange(new object[] {
            "Average",
            "Soft",
            "Softest",
            "Stiff"});
            this.cmbStiffness.Location = new System.Drawing.Point(12, 20);
            this.cmbStiffness.Name = "cmbStiffness";
            this.cmbStiffness.Size = new System.Drawing.Size(121, 21);
            this.cmbStiffness.TabIndex = 0;
            this.cmbStiffness.SelectedIndexChanged += new System.EventHandler(this.cmbStiffness_SelectedIndexChanged);
            // 
            // lnkFineTuning
            // 
            this.lnkFineTuning.AutoSize = true;
            this.lnkFineTuning.Location = new System.Drawing.Point(13, 429);
            this.lnkFineTuning.Name = "lnkFineTuning";
            this.lnkFineTuning.Size = new System.Drawing.Size(113, 13);
            this.lnkFineTuning.TabIndex = 15;
            this.lnkFineTuning.TabStop = true;
            this.lnkFineTuning.Text = "Fine tuning information";
            this.lnkFineTuning.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkFineTuning_LinkClicked);
            // 
            // ForzaTuningCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 511);
            this.Controls.Add(this.lnkFineTuning);
            this.Controls.Add(this.gbOverallStiffness);
            this.Controls.Add(this.gbResults);
            this.Controls.Add(this.btnTune);
            this.Controls.Add(this.gbInputs);
            this.MaximumSize = new System.Drawing.Size(730, 550);
            this.MinimumSize = new System.Drawing.Size(730, 550);
            this.Name = "ForzaTuningCalc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forza Tuning Calculator";
            this.gbDamping.ResumeLayout(false);
            this.gbDamping.PerformLayout();
            this.gbSprings.ResumeLayout(false);
            this.gbSprings.PerformLayout();
            this.gbInputs.ResumeLayout(false);
            this.gbInputs.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.gbArbs.ResumeLayout(false);
            this.gbArbs.PerformLayout();
            this.gbResults.ResumeLayout(false);
            this.gbOverallStiffness.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFrontWeight;
        private System.Windows.Forms.TextBox inputFrontWeight;
        private System.Windows.Forms.GroupBox gbDamping;
        private System.Windows.Forms.TextBox inputReboundMax;
        private System.Windows.Forms.Label lblRebound;
        private System.Windows.Forms.TextBox inputReboundMin;
        private System.Windows.Forms.GroupBox gbSprings;
        private System.Windows.Forms.TextBox inputSpringMax;
        private System.Windows.Forms.Label lblFrontSpring;
        private System.Windows.Forms.TextBox inputSpringMin;
        private System.Windows.Forms.Button btnTune;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbInputs;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.GroupBox gbResults;
        private System.Windows.Forms.GroupBox gbArbs;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox inputArbMax;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox inputArbMin;
        private System.Windows.Forms.CheckBox chkWeightBased;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox inputWeight;
        private System.Windows.Forms.ComboBox cmbDrivetrain;
        private System.Windows.Forms.ListView resultsList;
        private System.Windows.Forms.ColumnHeader settingHeader;
        private System.Windows.Forms.ColumnHeader frontValueHeader;
        private System.Windows.Forms.ColumnHeader rearValueHeader;
        private System.Windows.Forms.GroupBox gbOverallStiffness;
        private System.Windows.Forms.ComboBox cmbStiffness;
        private System.Windows.Forms.LinkLabel lnkFineTuning;
    }
}

