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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Springs", System.Windows.Forms.HorizontalAlignment.Center);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Damping", System.Windows.Forms.HorizontalAlignment.Center);
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("Anti Roll Bars", System.Windows.Forms.HorizontalAlignment.Center);
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Spring Rates");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Ride Height");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("Rebound");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("Bump");
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("ARB");
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
            this.gbFineTuning = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.ftoExitStage = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.ftoMidHsStage = new System.Windows.Forms.Label();
            this.ftoMidHs = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.ftoMidBottomOutStage = new System.Windows.Forms.Label();
            this.ftoMidMinRollStage = new System.Windows.Forms.Label();
            this.ftoMidPlusRollStage = new System.Windows.Forms.Label();
            this.ftoMidMinRoll = new System.Windows.Forms.Button();
            this.ftoMidPlusRoll = new System.Windows.Forms.Button();
            this.ftoMidBottomOut = new System.Windows.Forms.Button();
            this.ftoExit = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ftuExitStage = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ftuMidMinRollStage = new System.Windows.Forms.Label();
            this.ftuMidPlusRollStage = new System.Windows.Forms.Label();
            this.ftuMidMinRoll = new System.Windows.Forms.Button();
            this.ftuMidPlusRoll = new System.Windows.Forms.Button();
            this.ftuExit = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ftuEntryMidStage = new System.Windows.Forms.Label();
            this.ftuEntryHsStage = new System.Windows.Forms.Label();
            this.ftuEntryMid = new System.Windows.Forms.Button();
            this.ftuEntryHs = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ftOvrStiffStage = new System.Windows.Forms.Label();
            this.ftOvrSoftStage = new System.Windows.Forms.Label();
            this.ftOvrSoft = new System.Windows.Forms.Button();
            this.ftOvrStiff = new System.Windows.Forms.Button();
            this.resultsList = new System.Windows.Forms.ListView();
            this.settingHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.frontValueHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rearValueHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbDamping.SuspendLayout();
            this.gbSprings.SuspendLayout();
            this.gbInputs.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.gbArbs.SuspendLayout();
            this.gbResults.SuspendLayout();
            this.gbFineTuning.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.btnTune.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTune.Location = new System.Drawing.Point(317, 22);
            this.btnTune.Name = "btnTune";
            this.btnTune.Size = new System.Drawing.Size(75, 23);
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
            this.gbResults.Location = new System.Drawing.Point(510, 12);
            this.gbResults.Name = "gbResults";
            this.gbResults.Size = new System.Drawing.Size(383, 379);
            this.gbResults.TabIndex = 14;
            this.gbResults.TabStop = false;
            this.gbResults.Text = "Results";
            // 
            // gbFineTuning
            // 
            this.gbFineTuning.Controls.Add(this.groupBox5);
            this.gbFineTuning.Controls.Add(this.groupBox2);
            this.gbFineTuning.Controls.Add(this.groupBox1);
            this.gbFineTuning.Location = new System.Drawing.Point(12, 416);
            this.gbFineTuning.Name = "gbFineTuning";
            this.gbFineTuning.Size = new System.Drawing.Size(881, 282);
            this.gbFineTuning.TabIndex = 15;
            this.gbFineTuning.TabStop = false;
            this.gbFineTuning.Text = "Fine Tuning: Characteristics";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.ftoExitStage);
            this.groupBox5.Controls.Add(this.groupBox6);
            this.groupBox5.Controls.Add(this.ftoExit);
            this.groupBox5.Location = new System.Drawing.Point(196, 20);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(313, 233);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Oversteer";
            // 
            // ftoExitStage
            // 
            this.ftoExitStage.AutoSize = true;
            this.ftoExitStage.Location = new System.Drawing.Point(99, 199);
            this.ftoExitStage.Name = "ftoExitStage";
            this.ftoExitStage.Size = new System.Drawing.Size(41, 13);
            this.ftoExitStage.TabIndex = 15;
            this.ftoExitStage.Text = "label24";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.ftoMidHsStage);
            this.groupBox6.Controls.Add(this.ftoMidHs);
            this.groupBox6.Controls.Add(this.groupBox7);
            this.groupBox6.Location = new System.Drawing.Point(6, 19);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(301, 171);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Mid Corner";
            // 
            // ftoMidHsStage
            // 
            this.ftoMidHsStage.AutoSize = true;
            this.ftoMidHsStage.Location = new System.Drawing.Point(253, 25);
            this.ftoMidHsStage.Name = "ftoMidHsStage";
            this.ftoMidHsStage.Size = new System.Drawing.Size(41, 13);
            this.ftoMidHsStage.TabIndex = 16;
            this.ftoMidHsStage.Text = "label25";
            // 
            // ftoMidHs
            // 
            this.ftoMidHs.Location = new System.Drawing.Point(173, 25);
            this.ftoMidHs.Name = "ftoMidHs";
            this.ftoMidHs.Size = new System.Drawing.Size(74, 23);
            this.ftoMidHs.TabIndex = 7;
            this.ftoMidHs.Text = "High Speed";
            this.ftoMidHs.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.ftoMidBottomOutStage);
            this.groupBox7.Controls.Add(this.ftoMidMinRollStage);
            this.groupBox7.Controls.Add(this.ftoMidPlusRollStage);
            this.groupBox7.Controls.Add(this.ftoMidMinRoll);
            this.groupBox7.Controls.Add(this.ftoMidPlusRoll);
            this.groupBox7.Controls.Add(this.ftoMidBottomOut);
            this.groupBox7.Location = new System.Drawing.Point(7, 19);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(160, 146);
            this.groupBox7.TabIndex = 0;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Mid-Low Speed";
            // 
            // ftoMidBottomOutStage
            // 
            this.ftoMidBottomOutStage.AutoSize = true;
            this.ftoMidBottomOutStage.Location = new System.Drawing.Point(112, 117);
            this.ftoMidBottomOutStage.Name = "ftoMidBottomOutStage";
            this.ftoMidBottomOutStage.Size = new System.Drawing.Size(41, 13);
            this.ftoMidBottomOutStage.TabIndex = 14;
            this.ftoMidBottomOutStage.Text = "label23";
            // 
            // ftoMidMinRollStage
            // 
            this.ftoMidMinRollStage.AutoSize = true;
            this.ftoMidMinRollStage.Location = new System.Drawing.Point(114, 48);
            this.ftoMidMinRollStage.Name = "ftoMidMinRollStage";
            this.ftoMidMinRollStage.Size = new System.Drawing.Size(41, 13);
            this.ftoMidMinRollStage.TabIndex = 13;
            this.ftoMidMinRollStage.Text = "label22";
            // 
            // ftoMidPlusRollStage
            // 
            this.ftoMidPlusRollStage.AutoSize = true;
            this.ftoMidPlusRollStage.Location = new System.Drawing.Point(114, 19);
            this.ftoMidPlusRollStage.Name = "ftoMidPlusRollStage";
            this.ftoMidPlusRollStage.Size = new System.Drawing.Size(41, 13);
            this.ftoMidPlusRollStage.TabIndex = 12;
            this.ftoMidPlusRollStage.Text = "label21";
            this.ftoMidPlusRollStage.Click += new System.EventHandler(this.label21_Click);
            // 
            // ftoMidMinRoll
            // 
            this.ftoMidMinRoll.Location = new System.Drawing.Point(6, 48);
            this.ftoMidMinRoll.Name = "ftoMidMinRoll";
            this.ftoMidMinRoll.Size = new System.Drawing.Size(102, 23);
            this.ftoMidMinRoll.TabIndex = 9;
            this.ftoMidMinRoll.Text = "No rear roll";
            this.ftoMidMinRoll.UseVisualStyleBackColor = true;
            // 
            // ftoMidPlusRoll
            // 
            this.ftoMidPlusRoll.Location = new System.Drawing.Point(6, 19);
            this.ftoMidPlusRoll.Name = "ftoMidPlusRoll";
            this.ftoMidPlusRoll.Size = new System.Drawing.Size(102, 23);
            this.ftoMidPlusRoll.TabIndex = 8;
            this.ftoMidPlusRoll.Text = "Rear rolls";
            this.ftoMidPlusRoll.UseVisualStyleBackColor = true;
            // 
            // ftoMidBottomOut
            // 
            this.ftoMidBottomOut.Location = new System.Drawing.Point(6, 117);
            this.ftoMidBottomOut.Name = "ftoMidBottomOut";
            this.ftoMidBottomOut.Size = new System.Drawing.Size(100, 23);
            this.ftoMidBottomOut.TabIndex = 8;
            this.ftoMidBottomOut.Text = "Bottoming Out";
            this.ftoMidBottomOut.UseVisualStyleBackColor = true;
            // 
            // ftoExit
            // 
            this.ftoExit.Location = new System.Drawing.Point(19, 199);
            this.ftoExit.Name = "ftoExit";
            this.ftoExit.Size = new System.Drawing.Size(74, 23);
            this.ftoExit.TabIndex = 4;
            this.ftoExit.Text = "Corner Exit";
            this.ftoExit.UseVisualStyleBackColor = true;
            this.ftoExit.Click += new System.EventHandler(this.ftoExit_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ftuExitStage);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.ftuExit);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(6, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(184, 234);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Understeer";
            // 
            // ftuExitStage
            // 
            this.ftuExitStage.AutoSize = true;
            this.ftuExitStage.Location = new System.Drawing.Point(92, 200);
            this.ftuExitStage.Name = "ftuExitStage";
            this.ftuExitStage.Size = new System.Drawing.Size(41, 13);
            this.ftuExitStage.TabIndex = 9;
            this.ftuExitStage.Text = "label18";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ftuMidMinRollStage);
            this.groupBox4.Controls.Add(this.ftuMidPlusRollStage);
            this.groupBox4.Controls.Add(this.ftuMidMinRoll);
            this.groupBox4.Controls.Add(this.ftuMidPlusRoll);
            this.groupBox4.Location = new System.Drawing.Point(6, 101);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(172, 84);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Mid Corner";
            // 
            // ftuMidMinRollStage
            // 
            this.ftuMidMinRollStage.AutoSize = true;
            this.ftuMidMinRollStage.Location = new System.Drawing.Point(114, 48);
            this.ftuMidMinRollStage.Name = "ftuMidMinRollStage";
            this.ftuMidMinRollStage.Size = new System.Drawing.Size(41, 13);
            this.ftuMidMinRollStage.TabIndex = 8;
            this.ftuMidMinRollStage.Text = "label17";
            // 
            // ftuMidPlusRollStage
            // 
            this.ftuMidPlusRollStage.AutoSize = true;
            this.ftuMidPlusRollStage.Location = new System.Drawing.Point(114, 19);
            this.ftuMidPlusRollStage.Name = "ftuMidPlusRollStage";
            this.ftuMidPlusRollStage.Size = new System.Drawing.Size(41, 13);
            this.ftuMidPlusRollStage.TabIndex = 6;
            this.ftuMidPlusRollStage.Text = "label16";
            // 
            // ftuMidMinRoll
            // 
            this.ftuMidMinRoll.Location = new System.Drawing.Point(6, 48);
            this.ftuMidMinRoll.Name = "ftuMidMinRoll";
            this.ftuMidMinRoll.Size = new System.Drawing.Size(102, 23);
            this.ftuMidMinRoll.TabIndex = 7;
            this.ftuMidMinRoll.Text = "No front roll";
            this.ftuMidMinRoll.UseVisualStyleBackColor = true;
            // 
            // ftuMidPlusRoll
            // 
            this.ftuMidPlusRoll.Location = new System.Drawing.Point(6, 19);
            this.ftuMidPlusRoll.Name = "ftuMidPlusRoll";
            this.ftuMidPlusRoll.Size = new System.Drawing.Size(102, 23);
            this.ftuMidPlusRoll.TabIndex = 6;
            this.ftuMidPlusRoll.Text = "Front Rolls";
            this.ftuMidPlusRoll.UseVisualStyleBackColor = true;
            // 
            // ftuExit
            // 
            this.ftuExit.Location = new System.Drawing.Point(13, 200);
            this.ftuExit.Name = "ftuExit";
            this.ftuExit.Size = new System.Drawing.Size(74, 23);
            this.ftuExit.TabIndex = 4;
            this.ftuExit.Text = "Corner Exit";
            this.ftuExit.UseVisualStyleBackColor = true;
            this.ftuExit.Click += new System.EventHandler(this.ftuExit_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ftuEntryMidStage);
            this.groupBox3.Controls.Add(this.ftuEntryHsStage);
            this.groupBox3.Controls.Add(this.ftuEntryMid);
            this.groupBox3.Controls.Add(this.ftuEntryHs);
            this.groupBox3.Location = new System.Drawing.Point(6, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(172, 80);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Corner Entry";
            // 
            // ftuEntryMidStage
            // 
            this.ftuEntryMidStage.AutoSize = true;
            this.ftuEntryMidStage.Location = new System.Drawing.Point(86, 49);
            this.ftuEntryMidStage.Name = "ftuEntryMidStage";
            this.ftuEntryMidStage.Size = new System.Drawing.Size(41, 13);
            this.ftuEntryMidStage.TabIndex = 5;
            this.ftuEntryMidStage.Text = "label13";
            // 
            // ftuEntryHsStage
            // 
            this.ftuEntryHsStage.AutoSize = true;
            this.ftuEntryHsStage.Location = new System.Drawing.Point(87, 20);
            this.ftuEntryHsStage.Name = "ftuEntryHsStage";
            this.ftuEntryHsStage.Size = new System.Drawing.Size(41, 13);
            this.ftuEntryHsStage.TabIndex = 4;
            this.ftuEntryHsStage.Text = "label10";
            // 
            // ftuEntryMid
            // 
            this.ftuEntryMid.Location = new System.Drawing.Point(6, 49);
            this.ftuEntryMid.Name = "ftuEntryMid";
            this.ftuEntryMid.Size = new System.Drawing.Size(74, 23);
            this.ftuEntryMid.TabIndex = 3;
            this.ftuEntryMid.Text = "Mid-Low";
            this.ftuEntryMid.UseVisualStyleBackColor = true;
            this.ftuEntryMid.Click += new System.EventHandler(this.ftuEntryMid_Click);
            // 
            // ftuEntryHs
            // 
            this.ftuEntryHs.Location = new System.Drawing.Point(6, 20);
            this.ftuEntryHs.Name = "ftuEntryHs";
            this.ftuEntryHs.Size = new System.Drawing.Size(74, 23);
            this.ftuEntryHs.TabIndex = 2;
            this.ftuEntryHs.Text = "High Speed";
            this.ftuEntryHs.UseVisualStyleBackColor = true;
            this.ftuEntryHs.Click += new System.EventHandler(this.ftuEntryHs_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ftOvrStiffStage);
            this.groupBox1.Controls.Add(this.ftOvrSoftStage);
            this.groupBox1.Controls.Add(this.ftOvrSoft);
            this.groupBox1.Controls.Add(this.ftOvrStiff);
            this.groupBox1.Location = new System.Drawing.Point(515, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(178, 81);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Overall";
            // 
            // ftOvrStiffStage
            // 
            this.ftOvrStiffStage.AutoSize = true;
            this.ftOvrStiffStage.Location = new System.Drawing.Point(120, 48);
            this.ftOvrStiffStage.Name = "ftOvrStiffStage";
            this.ftOvrStiffStage.Size = new System.Drawing.Size(41, 13);
            this.ftOvrStiffStage.TabIndex = 11;
            this.ftOvrStiffStage.Text = "label20";
            // 
            // ftOvrSoftStage
            // 
            this.ftOvrSoftStage.AutoSize = true;
            this.ftOvrSoftStage.Location = new System.Drawing.Point(120, 19);
            this.ftOvrSoftStage.Name = "ftOvrSoftStage";
            this.ftOvrSoftStage.Size = new System.Drawing.Size(41, 13);
            this.ftOvrSoftStage.TabIndex = 10;
            this.ftOvrSoftStage.Text = "label19";
            // 
            // ftOvrSoft
            // 
            this.ftOvrSoft.Location = new System.Drawing.Point(11, 19);
            this.ftOvrSoft.Name = "ftOvrSoft";
            this.ftOvrSoft.Size = new System.Drawing.Size(105, 23);
            this.ftOvrSoft.TabIndex = 0;
            this.ftOvrSoft.Text = "Softer (general)";
            this.ftOvrSoft.UseVisualStyleBackColor = true;
            this.ftOvrSoft.Click += new System.EventHandler(this.ftuOvrSoft_Click);
            // 
            // ftOvrStiff
            // 
            this.ftOvrStiff.Location = new System.Drawing.Point(11, 48);
            this.ftOvrStiff.Name = "ftOvrStiff";
            this.ftOvrStiff.Size = new System.Drawing.Size(105, 23);
            this.ftOvrStiff.TabIndex = 1;
            this.ftOvrStiff.Text = "Stiffer (general)";
            this.ftOvrStiff.UseVisualStyleBackColor = true;
            this.ftOvrStiff.Click += new System.EventHandler(this.ftuOvrStiff_Click);
            // 
            // resultsList
            // 
            this.resultsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.settingHeader,
            this.frontValueHeader,
            this.rearValueHeader});
            listViewGroup1.Header = "Springs";
            listViewGroup1.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            listViewGroup1.Name = "Springs";
            listViewGroup1.Tag = "Springs";
            listViewGroup2.Header = "Damping";
            listViewGroup2.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            listViewGroup2.Name = "Damping";
            listViewGroup2.Tag = "Damping";
            listViewGroup3.Header = "Anti Roll Bars";
            listViewGroup3.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            listViewGroup3.Name = "Anti Roll Bars";
            this.resultsList.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2,
            listViewGroup3});
            listViewItem1.Group = listViewGroup1;
            listViewItem1.IndentCount = 1;
            listViewItem1.Tag = "SpringRates";
            listViewItem2.Group = listViewGroup1;
            listViewItem3.Group = listViewGroup2;
            listViewItem4.Group = listViewGroup2;
            listViewItem5.Group = listViewGroup3;
            this.resultsList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5});
            this.resultsList.Location = new System.Drawing.Point(6, 19);
            this.resultsList.Name = "resultsList";
            this.resultsList.Size = new System.Drawing.Size(367, 329);
            this.resultsList.TabIndex = 14;
            this.resultsList.UseCompatibleStateImageBehavior = false;
            this.resultsList.View = System.Windows.Forms.View.Details;
            this.resultsList.SelectedIndexChanged += new System.EventHandler(this.resultsList_SelectedIndexChanged);
            // 
            // settingHeader
            // 
            this.settingHeader.Text = "Setting";
            this.settingHeader.Width = 122;
            // 
            // frontValueHeader
            // 
            this.frontValueHeader.Text = "Front / Default";
            this.frontValueHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.frontValueHeader.Width = 85;
            // 
            // rearValueHeader
            // 
            this.rearValueHeader.Text = "Rear";
            this.rearValueHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.rearValueHeader.Width = 50;
            // 
            // ForzaTuningCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 710);
            this.Controls.Add(this.gbFineTuning);
            this.Controls.Add(this.gbResults);
            this.Controls.Add(this.btnTune);
            this.Controls.Add(this.gbInputs);
            this.MinimumSize = new System.Drawing.Size(906, 403);
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
            this.gbFineTuning.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.GroupBox gbFineTuning;
        private System.Windows.Forms.Button ftOvrStiff;
        private System.Windows.Forms.Button ftOvrSoft;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button ftuEntryHs;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button ftoExit;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button ftuMidMinRoll;
        private System.Windows.Forms.Button ftuMidPlusRoll;
        private System.Windows.Forms.Button ftuExit;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button ftuEntryMid;
        private System.Windows.Forms.Button ftoMidHs;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label ftoMidPlusRollStage;
        private System.Windows.Forms.Button ftoMidMinRoll;
        private System.Windows.Forms.Button ftoMidPlusRoll;
        private System.Windows.Forms.Button ftoMidBottomOut;
        private System.Windows.Forms.Label ftuExitStage;
        private System.Windows.Forms.Label ftuMidMinRollStage;
        private System.Windows.Forms.Label ftuMidPlusRollStage;
        private System.Windows.Forms.Label ftuEntryMidStage;
        private System.Windows.Forms.Label ftuEntryHsStage;
        private System.Windows.Forms.Label ftOvrStiffStage;
        private System.Windows.Forms.Label ftOvrSoftStage;
        private System.Windows.Forms.Label ftoExitStage;
        private System.Windows.Forms.Label ftoMidHsStage;
        private System.Windows.Forms.Label ftoMidBottomOutStage;
        private System.Windows.Forms.Label ftoMidMinRollStage;
        private System.Windows.Forms.CheckBox chkWeightBased;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox inputWeight;
        private System.Windows.Forms.ComboBox cmbDrivetrain;
        private System.Windows.Forms.ListView resultsList;
        private System.Windows.Forms.ColumnHeader settingHeader;
        private System.Windows.Forms.ColumnHeader frontValueHeader;
        private System.Windows.Forms.ColumnHeader rearValueHeader;
    }
}

