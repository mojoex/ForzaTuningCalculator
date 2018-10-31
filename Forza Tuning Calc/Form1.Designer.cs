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
            this.lblFrontWeight = new System.Windows.Forms.Label();
            this.txtFrontWeight = new System.Windows.Forms.TextBox();
            this.gbWeight = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gbDamping = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRebMax = new System.Windows.Forms.TextBox();
            this.lblRebound = new System.Windows.Forms.Label();
            this.txtRebMin = new System.Windows.Forms.TextBox();
            this.gbSprings = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFrontSpringMax = new System.Windows.Forms.TextBox();
            this.lblFrontSpring = new System.Windows.Forms.Label();
            this.txtFrontSpringMin = new System.Windows.Forms.TextBox();
            this.btnTune = new System.Windows.Forms.Button();
            this.resRebFront = new System.Windows.Forms.Label();
            this.resRebRear = new System.Windows.Forms.Label();
            this.resBumpRear50 = new System.Windows.Forms.Label();
            this.resBumpFront50 = new System.Windows.Forms.Label();
            this.resSpringRear = new System.Windows.Forms.Label();
            this.resSpringFront = new System.Windows.Forms.Label();
            this.gbInputs = new System.Windows.Forms.GroupBox();
            this.gbArbs = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtFrontArbMax = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtFrontArbMin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.gbResults = new System.Windows.Forms.GroupBox();
            this.gbCalculated = new System.Windows.Forms.GroupBox();
            this.gbResArb = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.resRearArb = new System.Windows.Forms.Label();
            this.resFrontArb = new System.Windows.Forms.Label();
            this.gbDampingRes = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblRebFrontRes = new System.Windows.Forms.Label();
            this.lblRebFront = new System.Windows.Forms.Label();
            this.gbSpringsRes = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.rearArbVar = new System.Windows.Forms.Label();
            this.frontArbVar = new System.Windows.Forms.Label();
            this.rearSpringVar = new System.Windows.Forms.Label();
            this.frontSpringVar = new System.Windows.Forms.Label();
            this.resBumpRear63 = new System.Windows.Forms.Label();
            this.resBumpFront63 = new System.Windows.Forms.Label();
            this.resBumpFront75 = new System.Windows.Forms.Label();
            this.resBumpRear75 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gbWeight.SuspendLayout();
            this.gbDamping.SuspendLayout();
            this.gbSprings.SuspendLayout();
            this.gbInputs.SuspendLayout();
            this.gbArbs.SuspendLayout();
            this.gbResults.SuspendLayout();
            this.gbCalculated.SuspendLayout();
            this.gbResArb.SuspendLayout();
            this.gbDampingRes.SuspendLayout();
            this.gbSpringsRes.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFrontWeight
            // 
            this.lblFrontWeight.AutoSize = true;
            this.lblFrontWeight.Location = new System.Drawing.Point(6, 21);
            this.lblFrontWeight.Name = "lblFrontWeight";
            this.lblFrontWeight.Size = new System.Drawing.Size(79, 13);
            this.lblFrontWeight.TabIndex = 0;
            this.lblFrontWeight.Text = "Front Weight %";
            this.lblFrontWeight.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtFrontWeight
            // 
            this.txtFrontWeight.Location = new System.Drawing.Point(112, 21);
            this.txtFrontWeight.Name = "txtFrontWeight";
            this.txtFrontWeight.Size = new System.Drawing.Size(100, 20);
            this.txtFrontWeight.TabIndex = 1;
            this.txtFrontWeight.TextChanged += new System.EventHandler(this.txtFrontWeight_TextChanged);
            // 
            // gbWeight
            // 
            this.gbWeight.Controls.Add(this.label3);
            this.gbWeight.Controls.Add(this.lblFrontWeight);
            this.gbWeight.Controls.Add(this.txtFrontWeight);
            this.gbWeight.Location = new System.Drawing.Point(6, 52);
            this.gbWeight.Name = "gbWeight";
            this.gbWeight.Size = new System.Drawing.Size(278, 50);
            this.gbWeight.TabIndex = 4;
            this.gbWeight.TabStop = false;
            this.gbWeight.Text = "Weight";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(218, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "*";
            // 
            // gbDamping
            // 
            this.gbDamping.Controls.Add(this.label4);
            this.gbDamping.Controls.Add(this.txtRebMax);
            this.gbDamping.Controls.Add(this.lblRebound);
            this.gbDamping.Controls.Add(this.txtRebMin);
            this.gbDamping.Location = new System.Drawing.Point(6, 108);
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
            // txtRebMax
            // 
            this.txtRebMax.Location = new System.Drawing.Point(176, 26);
            this.txtRebMax.Name = "txtRebMax";
            this.txtRebMax.Size = new System.Drawing.Size(60, 20);
            this.txtRebMax.TabIndex = 4;
            this.txtRebMax.Text = "20";
            this.txtRebMax.TextChanged += new System.EventHandler(this.txtRebMax_TextChanged);
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
            // txtRebMin
            // 
            this.txtRebMin.Location = new System.Drawing.Point(112, 26);
            this.txtRebMin.Name = "txtRebMin";
            this.txtRebMin.Size = new System.Drawing.Size(58, 20);
            this.txtRebMin.TabIndex = 3;
            this.txtRebMin.Text = "3";
            this.txtRebMin.TextChanged += new System.EventHandler(this.txtRebMin_TextChanged);
            // 
            // gbSprings
            // 
            this.gbSprings.Controls.Add(this.label2);
            this.gbSprings.Controls.Add(this.txtFrontSpringMax);
            this.gbSprings.Controls.Add(this.lblFrontSpring);
            this.gbSprings.Controls.Add(this.txtFrontSpringMin);
            this.gbSprings.Location = new System.Drawing.Point(6, 171);
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
            // txtFrontSpringMax
            // 
            this.txtFrontSpringMax.Location = new System.Drawing.Point(176, 26);
            this.txtFrontSpringMax.Name = "txtFrontSpringMax";
            this.txtFrontSpringMax.Size = new System.Drawing.Size(60, 20);
            this.txtFrontSpringMax.TabIndex = 4;
            this.txtFrontSpringMax.TextChanged += new System.EventHandler(this.txtFrontSpringMax_TextChanged);
            // 
            // lblFrontSpring
            // 
            this.lblFrontSpring.AutoSize = true;
            this.lblFrontSpring.Location = new System.Drawing.Point(6, 29);
            this.lblFrontSpring.Name = "lblFrontSpring";
            this.lblFrontSpring.Size = new System.Drawing.Size(80, 13);
            this.lblFrontSpring.TabIndex = 2;
            this.lblFrontSpring.Text = "Front (min/max)";
            // 
            // txtFrontSpringMin
            // 
            this.txtFrontSpringMin.Location = new System.Drawing.Point(112, 26);
            this.txtFrontSpringMin.Name = "txtFrontSpringMin";
            this.txtFrontSpringMin.Size = new System.Drawing.Size(58, 20);
            this.txtFrontSpringMin.TabIndex = 3;
            this.txtFrontSpringMin.TextChanged += new System.EventHandler(this.txtFrontSpringMin_TextChanged);
            // 
            // btnTune
            // 
            this.btnTune.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTune.Location = new System.Drawing.Point(209, 317);
            this.btnTune.Name = "btnTune";
            this.btnTune.Size = new System.Drawing.Size(75, 23);
            this.btnTune.TabIndex = 7;
            this.btnTune.Text = "Tune";
            this.btnTune.UseVisualStyleBackColor = true;
            this.btnTune.Click += new System.EventHandler(this.btnTune_Click);
            // 
            // resRebFront
            // 
            this.resRebFront.AutoSize = true;
            this.resRebFront.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resRebFront.ForeColor = System.Drawing.Color.SeaGreen;
            this.resRebFront.Location = new System.Drawing.Point(90, 15);
            this.resRebFront.Name = "resRebFront";
            this.resRebFront.Size = new System.Drawing.Size(52, 18);
            this.resRebFront.TabIndex = 0;
            this.resRebFront.Text = "label1";
            this.resRebFront.Visible = false;
            this.resRebFront.Click += new System.EventHandler(this.resRebFront_Click);
            // 
            // resRebRear
            // 
            this.resRebRear.AutoSize = true;
            this.resRebRear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resRebRear.ForeColor = System.Drawing.Color.SeaGreen;
            this.resRebRear.Location = new System.Drawing.Point(90, 36);
            this.resRebRear.Name = "resRebRear";
            this.resRebRear.Size = new System.Drawing.Size(52, 18);
            this.resRebRear.TabIndex = 8;
            this.resRebRear.Text = "label1";
            this.resRebRear.Visible = false;
            this.resRebRear.Click += new System.EventHandler(this.resRebRear_Click);
            // 
            // resBumpRear50
            // 
            this.resBumpRear50.AutoSize = true;
            this.resBumpRear50.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resBumpRear50.ForeColor = System.Drawing.Color.SeaGreen;
            this.resBumpRear50.Location = new System.Drawing.Point(90, 89);
            this.resBumpRear50.Name = "resBumpRear50";
            this.resBumpRear50.Size = new System.Drawing.Size(52, 17);
            this.resBumpRear50.TabIndex = 9;
            this.resBumpRear50.Text = "label1";
            this.resBumpRear50.Visible = false;
            this.resBumpRear50.Click += new System.EventHandler(this.resBumpRear_Click);
            // 
            // resBumpFront50
            // 
            this.resBumpFront50.AutoSize = true;
            this.resBumpFront50.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resBumpFront50.ForeColor = System.Drawing.Color.SeaGreen;
            this.resBumpFront50.Location = new System.Drawing.Point(90, 58);
            this.resBumpFront50.Name = "resBumpFront50";
            this.resBumpFront50.Size = new System.Drawing.Size(52, 17);
            this.resBumpFront50.TabIndex = 10;
            this.resBumpFront50.Text = "label1";
            this.resBumpFront50.Visible = false;
            this.resBumpFront50.Click += new System.EventHandler(this.resBumpFront_Click);
            // 
            // resSpringRear
            // 
            this.resSpringRear.AutoSize = true;
            this.resSpringRear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resSpringRear.ForeColor = System.Drawing.Color.SeaGreen;
            this.resSpringRear.Location = new System.Drawing.Point(90, 36);
            this.resSpringRear.Name = "resSpringRear";
            this.resSpringRear.Size = new System.Drawing.Size(52, 18);
            this.resSpringRear.TabIndex = 11;
            this.resSpringRear.Text = "label1";
            this.resSpringRear.Visible = false;
            this.resSpringRear.Click += new System.EventHandler(this.resSpringRear_Click);
            // 
            // resSpringFront
            // 
            this.resSpringFront.AutoSize = true;
            this.resSpringFront.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resSpringFront.ForeColor = System.Drawing.Color.SeaGreen;
            this.resSpringFront.Location = new System.Drawing.Point(90, 11);
            this.resSpringFront.Name = "resSpringFront";
            this.resSpringFront.Size = new System.Drawing.Size(52, 18);
            this.resSpringFront.TabIndex = 12;
            this.resSpringFront.Text = "label1";
            this.resSpringFront.Visible = false;
            this.resSpringFront.Click += new System.EventHandler(this.resSpringFront_Click);
            // 
            // gbInputs
            // 
            this.gbInputs.Controls.Add(this.gbArbs);
            this.gbInputs.Controls.Add(this.label1);
            this.gbInputs.Controls.Add(this.btnTune);
            this.gbInputs.Controls.Add(this.linkLabel1);
            this.gbInputs.Controls.Add(this.gbWeight);
            this.gbInputs.Controls.Add(this.gbDamping);
            this.gbInputs.Controls.Add(this.gbSprings);
            this.gbInputs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInputs.Location = new System.Drawing.Point(12, 12);
            this.gbInputs.Name = "gbInputs";
            this.gbInputs.Size = new System.Drawing.Size(299, 348);
            this.gbInputs.TabIndex = 13;
            this.gbInputs.TabStop = false;
            this.gbInputs.Text = "Input Values";
            // 
            // gbArbs
            // 
            this.gbArbs.Controls.Add(this.label11);
            this.gbArbs.Controls.Add(this.txtFrontArbMax);
            this.gbArbs.Controls.Add(this.label12);
            this.gbArbs.Controls.Add(this.txtFrontArbMin);
            this.gbArbs.Location = new System.Drawing.Point(6, 235);
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
            // txtFrontArbMax
            // 
            this.txtFrontArbMax.Location = new System.Drawing.Point(176, 26);
            this.txtFrontArbMax.Name = "txtFrontArbMax";
            this.txtFrontArbMax.Size = new System.Drawing.Size(60, 20);
            this.txtFrontArbMax.TabIndex = 4;
            this.txtFrontArbMax.Text = "65";
            this.txtFrontArbMax.TextChanged += new System.EventHandler(this.txtFrontArbMax_TextChanged);
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
            // txtFrontArbMin
            // 
            this.txtFrontArbMin.Location = new System.Drawing.Point(112, 26);
            this.txtFrontArbMin.Name = "txtFrontArbMin";
            this.txtFrontArbMin.Size = new System.Drawing.Size(58, 20);
            this.txtFrontArbMin.TabIndex = 3;
            this.txtFrontArbMin.Text = "1";
            this.txtFrontArbMin.TextChanged += new System.EventHandler(this.txtFrontArbMin_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 26);
            this.label1.TabIndex = 8;
            this.label1.Text = "Min/Max are the min and max values available in tuning\r\nbar.";
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
            this.gbResults.Controls.Add(this.gbCalculated);
            this.gbResults.Location = new System.Drawing.Point(317, 12);
            this.gbResults.Name = "gbResults";
            this.gbResults.Size = new System.Drawing.Size(568, 348);
            this.gbResults.TabIndex = 14;
            this.gbResults.TabStop = false;
            this.gbResults.Text = "Results";
            // 
            // gbCalculated
            // 
            this.gbCalculated.Controls.Add(this.label5);
            this.gbCalculated.Controls.Add(this.gbResArb);
            this.gbCalculated.Controls.Add(this.gbDampingRes);
            this.gbCalculated.Controls.Add(this.gbSpringsRes);
            this.gbCalculated.Location = new System.Drawing.Point(8, 19);
            this.gbCalculated.Name = "gbCalculated";
            this.gbCalculated.Size = new System.Drawing.Size(508, 318);
            this.gbCalculated.TabIndex = 14;
            this.gbCalculated.TabStop = false;
            this.gbCalculated.Text = "Calculated";
            // 
            // gbResArb
            // 
            this.gbResArb.Controls.Add(this.label14);
            this.gbResArb.Controls.Add(this.label15);
            this.gbResArb.Controls.Add(this.rearArbVar);
            this.gbResArb.Controls.Add(this.frontArbVar);
            this.gbResArb.Controls.Add(this.resRearArb);
            this.gbResArb.Controls.Add(this.resFrontArb);
            this.gbResArb.Location = new System.Drawing.Point(6, 252);
            this.gbResArb.Name = "gbResArb";
            this.gbResArb.Size = new System.Drawing.Size(271, 60);
            this.gbResArb.TabIndex = 13;
            this.gbResArb.TabStop = false;
            this.gbResArb.Text = "ARBs";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 13);
            this.label14.TabIndex = 4;
            this.label14.Text = "Front Stiffness";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 37);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(73, 13);
            this.label15.TabIndex = 3;
            this.label15.Text = "Rear Stiffness";
            // 
            // resRearArb
            // 
            this.resRearArb.AutoSize = true;
            this.resRearArb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resRearArb.ForeColor = System.Drawing.Color.SeaGreen;
            this.resRearArb.Location = new System.Drawing.Point(90, 35);
            this.resRearArb.Name = "resRearArb";
            this.resRearArb.Size = new System.Drawing.Size(52, 18);
            this.resRearArb.TabIndex = 11;
            this.resRearArb.Text = "label1";
            this.resRearArb.Visible = false;
            this.resRearArb.Click += new System.EventHandler(this.label16_Click);
            // 
            // resFrontArb
            // 
            this.resFrontArb.AutoSize = true;
            this.resFrontArb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resFrontArb.ForeColor = System.Drawing.Color.SeaGreen;
            this.resFrontArb.Location = new System.Drawing.Point(90, 11);
            this.resFrontArb.Name = "resFrontArb";
            this.resFrontArb.Size = new System.Drawing.Size(52, 18);
            this.resFrontArb.TabIndex = 12;
            this.resFrontArb.Text = "label1";
            this.resFrontArb.Visible = false;
            this.resFrontArb.Click += new System.EventHandler(this.label17_Click);
            // 
            // gbDampingRes
            // 
            this.gbDampingRes.Controls.Add(this.resBumpRear75);
            this.gbDampingRes.Controls.Add(this.resBumpFront75);
            this.gbDampingRes.Controls.Add(this.resBumpFront63);
            this.gbDampingRes.Controls.Add(this.resBumpRear63);
            this.gbDampingRes.Controls.Add(this.label9);
            this.gbDampingRes.Controls.Add(this.label7);
            this.gbDampingRes.Controls.Add(this.lblRebFrontRes);
            this.gbDampingRes.Controls.Add(this.lblRebFront);
            this.gbDampingRes.Controls.Add(this.resBumpRear50);
            this.gbDampingRes.Controls.Add(this.resBumpFront50);
            this.gbDampingRes.Controls.Add(this.resRebFront);
            this.gbDampingRes.Controls.Add(this.resRebRear);
            this.gbDampingRes.Location = new System.Drawing.Point(6, 59);
            this.gbDampingRes.Name = "gbDampingRes";
            this.gbDampingRes.Size = new System.Drawing.Size(483, 118);
            this.gbDampingRes.TabIndex = 5;
            this.gbDampingRes.TabStop = false;
            this.gbDampingRes.Text = "Damping";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Front Bump";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Rear Bump";
            // 
            // lblRebFrontRes
            // 
            this.lblRebFrontRes.AutoSize = true;
            this.lblRebFrontRes.Location = new System.Drawing.Point(6, 16);
            this.lblRebFrontRes.Name = "lblRebFrontRes";
            this.lblRebFrontRes.Size = new System.Drawing.Size(78, 13);
            this.lblRebFrontRes.TabIndex = 4;
            this.lblRebFrontRes.Text = "Front Rebound";
            // 
            // lblRebFront
            // 
            this.lblRebFront.AutoSize = true;
            this.lblRebFront.Location = new System.Drawing.Point(6, 37);
            this.lblRebFront.Name = "lblRebFront";
            this.lblRebFront.Size = new System.Drawing.Size(77, 13);
            this.lblRebFront.TabIndex = 3;
            this.lblRebFront.Text = "Rear Rebound";
            // 
            // gbSpringsRes
            // 
            this.gbSpringsRes.Controls.Add(this.label6);
            this.gbSpringsRes.Controls.Add(this.label8);
            this.gbSpringsRes.Controls.Add(this.rearSpringVar);
            this.gbSpringsRes.Controls.Add(this.frontSpringVar);
            this.gbSpringsRes.Controls.Add(this.resSpringRear);
            this.gbSpringsRes.Controls.Add(this.resSpringFront);
            this.gbSpringsRes.Location = new System.Drawing.Point(6, 183);
            this.gbSpringsRes.Name = "gbSpringsRes";
            this.gbSpringsRes.Size = new System.Drawing.Size(271, 63);
            this.gbSpringsRes.TabIndex = 6;
            this.gbSpringsRes.TabStop = false;
            this.gbSpringsRes.Text = "Springs";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Front Stiffness";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Rear Stiffness";
            // 
            // rearArbVar
            // 
            this.rearArbVar.AutoSize = true;
            this.rearArbVar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rearArbVar.ForeColor = System.Drawing.Color.Orange;
            this.rearArbVar.Location = new System.Drawing.Point(189, 33);
            this.rearArbVar.Name = "rearArbVar";
            this.rearArbVar.Size = new System.Drawing.Size(52, 18);
            this.rearArbVar.TabIndex = 11;
            this.rearArbVar.Text = "label1";
            this.rearArbVar.Visible = false;
            this.rearArbVar.Click += new System.EventHandler(this.rearArbVar_Click);
            // 
            // frontArbVar
            // 
            this.frontArbVar.AutoSize = true;
            this.frontArbVar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frontArbVar.ForeColor = System.Drawing.Color.Orange;
            this.frontArbVar.Location = new System.Drawing.Point(189, 11);
            this.frontArbVar.Name = "frontArbVar";
            this.frontArbVar.Size = new System.Drawing.Size(52, 18);
            this.frontArbVar.TabIndex = 12;
            this.frontArbVar.Text = "label1";
            this.frontArbVar.Visible = false;
            this.frontArbVar.Click += new System.EventHandler(this.frontArbVar_Click);
            // 
            // rearSpringVar
            // 
            this.rearSpringVar.AutoSize = true;
            this.rearSpringVar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rearSpringVar.ForeColor = System.Drawing.Color.Orange;
            this.rearSpringVar.Location = new System.Drawing.Point(189, 36);
            this.rearSpringVar.Name = "rearSpringVar";
            this.rearSpringVar.Size = new System.Drawing.Size(52, 18);
            this.rearSpringVar.TabIndex = 13;
            this.rearSpringVar.Text = "label1";
            this.rearSpringVar.Visible = false;
            this.rearSpringVar.Click += new System.EventHandler(this.rearSpringVar_Click);
            // 
            // frontSpringVar
            // 
            this.frontSpringVar.AutoSize = true;
            this.frontSpringVar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frontSpringVar.ForeColor = System.Drawing.Color.Orange;
            this.frontSpringVar.Location = new System.Drawing.Point(189, 12);
            this.frontSpringVar.Name = "frontSpringVar";
            this.frontSpringVar.Size = new System.Drawing.Size(52, 18);
            this.frontSpringVar.TabIndex = 14;
            this.frontSpringVar.Text = "label1";
            this.frontSpringVar.Visible = false;
            this.frontSpringVar.Click += new System.EventHandler(this.frontSpringVar_Click);
            // 
            // resBumpRear63
            // 
            this.resBumpRear63.AutoSize = true;
            this.resBumpRear63.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resBumpRear63.ForeColor = System.Drawing.Color.SeaGreen;
            this.resBumpRear63.Location = new System.Drawing.Point(217, 89);
            this.resBumpRear63.Name = "resBumpRear63";
            this.resBumpRear63.Size = new System.Drawing.Size(52, 17);
            this.resBumpRear63.TabIndex = 15;
            this.resBumpRear63.Text = "label1";
            this.resBumpRear63.Visible = false;
            this.resBumpRear63.Click += new System.EventHandler(this.resBumpRear63_Click);
            // 
            // resBumpFront63
            // 
            this.resBumpFront63.AutoSize = true;
            this.resBumpFront63.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resBumpFront63.ForeColor = System.Drawing.Color.SeaGreen;
            this.resBumpFront63.Location = new System.Drawing.Point(217, 58);
            this.resBumpFront63.Name = "resBumpFront63";
            this.resBumpFront63.Size = new System.Drawing.Size(52, 17);
            this.resBumpFront63.TabIndex = 16;
            this.resBumpFront63.Text = "label1";
            this.resBumpFront63.Visible = false;
            this.resBumpFront63.Click += new System.EventHandler(this.resBumpFront63_Click);
            // 
            // resBumpFront75
            // 
            this.resBumpFront75.AutoSize = true;
            this.resBumpFront75.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resBumpFront75.ForeColor = System.Drawing.Color.SeaGreen;
            this.resBumpFront75.Location = new System.Drawing.Point(346, 58);
            this.resBumpFront75.Name = "resBumpFront75";
            this.resBumpFront75.Size = new System.Drawing.Size(52, 17);
            this.resBumpFront75.TabIndex = 17;
            this.resBumpFront75.Text = "label1";
            this.resBumpFront75.Visible = false;
            this.resBumpFront75.Click += new System.EventHandler(this.resBumpFront75_Click);
            // 
            // resBumpRear75
            // 
            this.resBumpRear75.AutoSize = true;
            this.resBumpRear75.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resBumpRear75.ForeColor = System.Drawing.Color.SeaGreen;
            this.resBumpRear75.Location = new System.Drawing.Point(346, 89);
            this.resBumpRear75.Name = "resBumpRear75";
            this.resBumpRear75.Size = new System.Drawing.Size(52, 17);
            this.resBumpRear75.TabIndex = 18;
            this.resBumpRear75.Text = "label1";
            this.resBumpRear75.Visible = false;
            this.resBumpRear75.Click += new System.EventHandler(this.resBumpRear75_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(360, 26);
            this.label5.TabIndex = 14;
            this.label5.Text = "Starting points for base tune. Orange values are minimum change values to\r\nnotice" +
    " a difference.";
            // 
            // ForzaTuningCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 364);
            this.Controls.Add(this.gbResults);
            this.Controls.Add(this.gbInputs);
            this.MinimumSize = new System.Drawing.Size(906, 403);
            this.Name = "ForzaTuningCalc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forza Tuning Calculator";
            this.gbWeight.ResumeLayout(false);
            this.gbWeight.PerformLayout();
            this.gbDamping.ResumeLayout(false);
            this.gbDamping.PerformLayout();
            this.gbSprings.ResumeLayout(false);
            this.gbSprings.PerformLayout();
            this.gbInputs.ResumeLayout(false);
            this.gbInputs.PerformLayout();
            this.gbArbs.ResumeLayout(false);
            this.gbArbs.PerformLayout();
            this.gbResults.ResumeLayout(false);
            this.gbCalculated.ResumeLayout(false);
            this.gbCalculated.PerformLayout();
            this.gbResArb.ResumeLayout(false);
            this.gbResArb.PerformLayout();
            this.gbDampingRes.ResumeLayout(false);
            this.gbDampingRes.PerformLayout();
            this.gbSpringsRes.ResumeLayout(false);
            this.gbSpringsRes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblFrontWeight;
        private System.Windows.Forms.TextBox txtFrontWeight;
        private System.Windows.Forms.GroupBox gbWeight;
        private System.Windows.Forms.GroupBox gbDamping;
        private System.Windows.Forms.TextBox txtRebMax;
        private System.Windows.Forms.Label lblRebound;
        private System.Windows.Forms.TextBox txtRebMin;
        private System.Windows.Forms.GroupBox gbSprings;
        private System.Windows.Forms.TextBox txtFrontSpringMax;
        private System.Windows.Forms.Label lblFrontSpring;
        private System.Windows.Forms.TextBox txtFrontSpringMin;
        private System.Windows.Forms.Button btnTune;
        private System.Windows.Forms.Label resRebFront;
        private System.Windows.Forms.Label resRebRear;
        private System.Windows.Forms.Label resBumpRear50;
        private System.Windows.Forms.Label resBumpFront50;
        private System.Windows.Forms.Label resSpringRear;
        private System.Windows.Forms.Label resSpringFront;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbInputs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.GroupBox gbResults;
        private System.Windows.Forms.GroupBox gbSpringsRes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox gbDampingRes;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblRebFrontRes;
        private System.Windows.Forms.Label lblRebFront;
        private System.Windows.Forms.GroupBox gbArbs;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtFrontArbMax;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtFrontArbMin;
        private System.Windows.Forms.GroupBox gbResArb;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label resRearArb;
        private System.Windows.Forms.Label resFrontArb;
        private System.Windows.Forms.GroupBox gbCalculated;
        private System.Windows.Forms.Label rearArbVar;
        private System.Windows.Forms.Label frontArbVar;
        private System.Windows.Forms.Label resBumpRear75;
        private System.Windows.Forms.Label resBumpFront75;
        private System.Windows.Forms.Label resBumpFront63;
        private System.Windows.Forms.Label resBumpRear63;
        private System.Windows.Forms.Label rearSpringVar;
        private System.Windows.Forms.Label frontSpringVar;
        private System.Windows.Forms.Label label5;
    }
}

