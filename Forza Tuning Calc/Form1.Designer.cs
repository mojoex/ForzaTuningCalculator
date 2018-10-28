﻿namespace Forza_Tuning_Calc
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
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.lblWeight = new System.Windows.Forms.Label();
            this.gbWeight = new System.Windows.Forms.GroupBox();
            this.gbDamping = new System.Windows.Forms.GroupBox();
            this.txtRebMax = new System.Windows.Forms.TextBox();
            this.lblRebound = new System.Windows.Forms.Label();
            this.txtRebMin = new System.Windows.Forms.TextBox();
            this.gbSprings = new System.Windows.Forms.GroupBox();
            this.txtRearSpringMax = new System.Windows.Forms.TextBox();
            this.txtFrontSpringMax = new System.Windows.Forms.TextBox();
            this.lblFrontSpring = new System.Windows.Forms.Label();
            this.txtFrontSpringMin = new System.Windows.Forms.TextBox();
            this.lblRearSpring = new System.Windows.Forms.Label();
            this.txtRearSpringMin = new System.Windows.Forms.TextBox();
            this.btnTune = new System.Windows.Forms.Button();
            this.resRebFront = new System.Windows.Forms.Label();
            this.resRebRear = new System.Windows.Forms.Label();
            this.resBumpRear = new System.Windows.Forms.Label();
            this.resBumpFront = new System.Windows.Forms.Label();
            this.resSpringRear = new System.Windows.Forms.Label();
            this.resSpringFront = new System.Windows.Forms.Label();
            this.gbInputs = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gbResults = new System.Windows.Forms.GroupBox();
            this.lblRebFront = new System.Windows.Forms.Label();
            this.lblRebFrontRes = new System.Windows.Forms.Label();
            this.gbDampingRes = new System.Windows.Forms.GroupBox();
            this.gbSpringsRes = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.gbArbs = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtRearArbMax = new System.Windows.Forms.TextBox();
            this.txtFrontArbMax = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtFrontArbMin = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtRearArbMin = new System.Windows.Forms.TextBox();
            this.gbResArb = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.resRearArb = new System.Windows.Forms.Label();
            this.resFrontArb = new System.Windows.Forms.Label();
            this.gbWeight.SuspendLayout();
            this.gbDamping.SuspendLayout();
            this.gbSprings.SuspendLayout();
            this.gbInputs.SuspendLayout();
            this.gbResults.SuspendLayout();
            this.gbDampingRes.SuspendLayout();
            this.gbSpringsRes.SuspendLayout();
            this.gbArbs.SuspendLayout();
            this.gbResArb.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFrontWeight
            // 
            this.lblFrontWeight.AutoSize = true;
            this.lblFrontWeight.Location = new System.Drawing.Point(6, 55);
            this.lblFrontWeight.Name = "lblFrontWeight";
            this.lblFrontWeight.Size = new System.Drawing.Size(79, 13);
            this.lblFrontWeight.TabIndex = 0;
            this.lblFrontWeight.Text = "Front Weight %";
            this.lblFrontWeight.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtFrontWeight
            // 
            this.txtFrontWeight.Location = new System.Drawing.Point(136, 55);
            this.txtFrontWeight.Name = "txtFrontWeight";
            this.txtFrontWeight.Size = new System.Drawing.Size(100, 20);
            this.txtFrontWeight.TabIndex = 1;
            this.txtFrontWeight.TextChanged += new System.EventHandler(this.txtFrontWeight_TextChanged);
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(136, 29);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(100, 20);
            this.txtWeight.TabIndex = 3;
            this.txtWeight.Text = "N/A in BETA";
            this.txtWeight.TextChanged += new System.EventHandler(this.txtWeight_TextChanged);
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(6, 29);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(62, 13);
            this.lblWeight.TabIndex = 2;
            this.lblWeight.Text = "Weight (kg)";
            // 
            // gbWeight
            // 
            this.gbWeight.Controls.Add(this.label3);
            this.gbWeight.Controls.Add(this.lblWeight);
            this.gbWeight.Controls.Add(this.txtWeight);
            this.gbWeight.Controls.Add(this.lblFrontWeight);
            this.gbWeight.Controls.Add(this.txtFrontWeight);
            this.gbWeight.Location = new System.Drawing.Point(6, 52);
            this.gbWeight.Name = "gbWeight";
            this.gbWeight.Size = new System.Drawing.Size(354, 100);
            this.gbWeight.TabIndex = 4;
            this.gbWeight.TabStop = false;
            this.gbWeight.Text = "Weight";
            // 
            // gbDamping
            // 
            this.gbDamping.Controls.Add(this.label4);
            this.gbDamping.Controls.Add(this.txtRebMax);
            this.gbDamping.Controls.Add(this.lblRebound);
            this.gbDamping.Controls.Add(this.txtRebMin);
            this.gbDamping.Location = new System.Drawing.Point(6, 158);
            this.gbDamping.Name = "gbDamping";
            this.gbDamping.Size = new System.Drawing.Size(354, 57);
            this.gbDamping.TabIndex = 5;
            this.gbDamping.TabStop = false;
            this.gbDamping.Text = "Damping";
            // 
            // txtRebMax
            // 
            this.txtRebMax.Location = new System.Drawing.Point(176, 26);
            this.txtRebMax.Name = "txtRebMax";
            this.txtRebMax.Size = new System.Drawing.Size(60, 20);
            this.txtRebMax.TabIndex = 4;
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
            this.txtRebMin.TextChanged += new System.EventHandler(this.txtRebMin_TextChanged);
            // 
            // gbSprings
            // 
            this.gbSprings.Controls.Add(this.label5);
            this.gbSprings.Controls.Add(this.label2);
            this.gbSprings.Controls.Add(this.txtRearSpringMax);
            this.gbSprings.Controls.Add(this.txtFrontSpringMax);
            this.gbSprings.Controls.Add(this.lblFrontSpring);
            this.gbSprings.Controls.Add(this.txtFrontSpringMin);
            this.gbSprings.Controls.Add(this.lblRearSpring);
            this.gbSprings.Controls.Add(this.txtRearSpringMin);
            this.gbSprings.Location = new System.Drawing.Point(6, 221);
            this.gbSprings.Name = "gbSprings";
            this.gbSprings.Size = new System.Drawing.Size(354, 100);
            this.gbSprings.TabIndex = 6;
            this.gbSprings.TabStop = false;
            this.gbSprings.Text = "Springs";
            // 
            // txtRearSpringMax
            // 
            this.txtRearSpringMax.Location = new System.Drawing.Point(176, 55);
            this.txtRearSpringMax.Name = "txtRearSpringMax";
            this.txtRearSpringMax.Size = new System.Drawing.Size(60, 20);
            this.txtRearSpringMax.TabIndex = 5;
            this.txtRearSpringMax.TextChanged += new System.EventHandler(this.txtRearMax_TextChanged);
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
            // lblRearSpring
            // 
            this.lblRearSpring.AutoSize = true;
            this.lblRearSpring.Location = new System.Drawing.Point(6, 55);
            this.lblRearSpring.Name = "lblRearSpring";
            this.lblRearSpring.Size = new System.Drawing.Size(79, 13);
            this.lblRearSpring.TabIndex = 0;
            this.lblRearSpring.Text = "Rear (min/max)";
            // 
            // txtRearSpringMin
            // 
            this.txtRearSpringMin.Location = new System.Drawing.Point(112, 55);
            this.txtRearSpringMin.Name = "txtRearSpringMin";
            this.txtRearSpringMin.Size = new System.Drawing.Size(58, 20);
            this.txtRearSpringMin.TabIndex = 1;
            this.txtRearSpringMin.TextChanged += new System.EventHandler(this.txtRearMin_TextChanged);
            // 
            // btnTune
            // 
            this.btnTune.Location = new System.Drawing.Point(720, 415);
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
            this.resRebFront.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resRebFront.ForeColor = System.Drawing.Color.SeaGreen;
            this.resRebFront.Location = new System.Drawing.Point(90, 11);
            this.resRebFront.Name = "resRebFront";
            this.resRebFront.Size = new System.Drawing.Size(57, 20);
            this.resRebFront.TabIndex = 0;
            this.resRebFront.Text = "label1";
            this.resRebFront.Visible = false;
            this.resRebFront.Click += new System.EventHandler(this.resRebFront_Click);
            // 
            // resRebRear
            // 
            this.resRebRear.AutoSize = true;
            this.resRebRear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resRebRear.ForeColor = System.Drawing.Color.SeaGreen;
            this.resRebRear.Location = new System.Drawing.Point(90, 33);
            this.resRebRear.Name = "resRebRear";
            this.resRebRear.Size = new System.Drawing.Size(57, 20);
            this.resRebRear.TabIndex = 8;
            this.resRebRear.Text = "label1";
            this.resRebRear.Visible = false;
            this.resRebRear.Click += new System.EventHandler(this.resRebRear_Click);
            // 
            // resBumpRear
            // 
            this.resBumpRear.AutoSize = true;
            this.resBumpRear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resBumpRear.ForeColor = System.Drawing.Color.SeaGreen;
            this.resBumpRear.Location = new System.Drawing.Point(90, 82);
            this.resBumpRear.Name = "resBumpRear";
            this.resBumpRear.Size = new System.Drawing.Size(57, 20);
            this.resBumpRear.TabIndex = 9;
            this.resBumpRear.Text = "label1";
            this.resBumpRear.Visible = false;
            this.resBumpRear.Click += new System.EventHandler(this.resBumpRear_Click);
            // 
            // resBumpFront
            // 
            this.resBumpFront.AutoSize = true;
            this.resBumpFront.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resBumpFront.ForeColor = System.Drawing.Color.SeaGreen;
            this.resBumpFront.Location = new System.Drawing.Point(90, 61);
            this.resBumpFront.Name = "resBumpFront";
            this.resBumpFront.Size = new System.Drawing.Size(57, 20);
            this.resBumpFront.TabIndex = 10;
            this.resBumpFront.Text = "label1";
            this.resBumpFront.Visible = false;
            this.resBumpFront.Click += new System.EventHandler(this.resBumpFront_Click);
            // 
            // resSpringRear
            // 
            this.resSpringRear.AutoSize = true;
            this.resSpringRear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resSpringRear.ForeColor = System.Drawing.Color.SeaGreen;
            this.resSpringRear.Location = new System.Drawing.Point(90, 50);
            this.resSpringRear.Name = "resSpringRear";
            this.resSpringRear.Size = new System.Drawing.Size(57, 20);
            this.resSpringRear.TabIndex = 11;
            this.resSpringRear.Text = "label1";
            this.resSpringRear.Visible = false;
            this.resSpringRear.Click += new System.EventHandler(this.resSpringRear_Click);
            // 
            // resSpringFront
            // 
            this.resSpringFront.AutoSize = true;
            this.resSpringFront.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resSpringFront.ForeColor = System.Drawing.Color.SeaGreen;
            this.resSpringFront.Location = new System.Drawing.Point(90, 11);
            this.resSpringFront.Name = "resSpringFront";
            this.resSpringFront.Size = new System.Drawing.Size(57, 20);
            this.resSpringFront.TabIndex = 12;
            this.resSpringFront.Text = "label1";
            this.resSpringFront.Visible = false;
            this.resSpringFront.Click += new System.EventHandler(this.resSpringFront_Click);
            // 
            // gbInputs
            // 
            this.gbInputs.Controls.Add(this.gbArbs);
            this.gbInputs.Controls.Add(this.label1);
            this.gbInputs.Controls.Add(this.linkLabel1);
            this.gbInputs.Controls.Add(this.gbWeight);
            this.gbInputs.Controls.Add(this.gbDamping);
            this.gbInputs.Controls.Add(this.gbSprings);
            this.gbInputs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInputs.Location = new System.Drawing.Point(12, 12);
            this.gbInputs.Name = "gbInputs";
            this.gbInputs.Size = new System.Drawing.Size(375, 426);
            this.gbInputs.TabIndex = 13;
            this.gbInputs.TabStop = false;
            this.gbInputs.Text = "Input Values";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(15, 20);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(0, 13);
            this.linkLabel1.TabIndex = 7;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(242, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "*";
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(242, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(11, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "*";
            // 
            // gbResults
            // 
            this.gbResults.Controls.Add(this.gbResArb);
            this.gbResults.Controls.Add(this.gbSpringsRes);
            this.gbResults.Controls.Add(this.gbDampingRes);
            this.gbResults.Location = new System.Drawing.Point(394, 12);
            this.gbResults.Name = "gbResults";
            this.gbResults.Size = new System.Drawing.Size(320, 426);
            this.gbResults.TabIndex = 14;
            this.gbResults.TabStop = false;
            this.gbResults.Text = "Results";
            // 
            // lblRebFront
            // 
            this.lblRebFront.AutoSize = true;
            this.lblRebFront.Location = new System.Drawing.Point(6, 38);
            this.lblRebFront.Name = "lblRebFront";
            this.lblRebFront.Size = new System.Drawing.Size(77, 13);
            this.lblRebFront.TabIndex = 3;
            this.lblRebFront.Text = "Rear Rebound";
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
            // gbDampingRes
            // 
            this.gbDampingRes.Controls.Add(this.label9);
            this.gbDampingRes.Controls.Add(this.label7);
            this.gbDampingRes.Controls.Add(this.lblRebFrontRes);
            this.gbDampingRes.Controls.Add(this.lblRebFront);
            this.gbDampingRes.Controls.Add(this.resBumpRear);
            this.gbDampingRes.Controls.Add(this.resBumpFront);
            this.gbDampingRes.Controls.Add(this.resRebFront);
            this.gbDampingRes.Controls.Add(this.resRebRear);
            this.gbDampingRes.Location = new System.Drawing.Point(6, 19);
            this.gbDampingRes.Name = "gbDampingRes";
            this.gbDampingRes.Size = new System.Drawing.Size(308, 126);
            this.gbDampingRes.TabIndex = 5;
            this.gbDampingRes.TabStop = false;
            this.gbDampingRes.Text = "Damping";
            // 
            // gbSpringsRes
            // 
            this.gbSpringsRes.Controls.Add(this.label6);
            this.gbSpringsRes.Controls.Add(this.label8);
            this.gbSpringsRes.Controls.Add(this.resSpringRear);
            this.gbSpringsRes.Controls.Add(this.resSpringFront);
            this.gbSpringsRes.Location = new System.Drawing.Point(6, 151);
            this.gbSpringsRes.Name = "gbSpringsRes";
            this.gbSpringsRes.Size = new System.Drawing.Size(308, 100);
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
            this.label8.Location = new System.Drawing.Point(6, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Rear Stiffness";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Rear Bump";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Front Bump";
            // 
            // gbArbs
            // 
            this.gbArbs.Controls.Add(this.label10);
            this.gbArbs.Controls.Add(this.label11);
            this.gbArbs.Controls.Add(this.txtRearArbMax);
            this.gbArbs.Controls.Add(this.txtFrontArbMax);
            this.gbArbs.Controls.Add(this.label12);
            this.gbArbs.Controls.Add(this.txtFrontArbMin);
            this.gbArbs.Controls.Add(this.label13);
            this.gbArbs.Controls.Add(this.txtRearArbMin);
            this.gbArbs.Location = new System.Drawing.Point(6, 327);
            this.gbArbs.Name = "gbArbs";
            this.gbArbs.Size = new System.Drawing.Size(354, 100);
            this.gbArbs.TabIndex = 9;
            this.gbArbs.TabStop = false;
            this.gbArbs.Text = "ARBs";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(242, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(11, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "*";
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
            // txtRearArbMax
            // 
            this.txtRearArbMax.Location = new System.Drawing.Point(176, 55);
            this.txtRearArbMax.Name = "txtRearArbMax";
            this.txtRearArbMax.Size = new System.Drawing.Size(60, 20);
            this.txtRearArbMax.TabIndex = 5;
            this.txtRearArbMax.TextChanged += new System.EventHandler(this.txtRearArbMax_TextChanged);
            // 
            // txtFrontArbMax
            // 
            this.txtFrontArbMax.Location = new System.Drawing.Point(176, 26);
            this.txtFrontArbMax.Name = "txtFrontArbMax";
            this.txtFrontArbMax.Size = new System.Drawing.Size(60, 20);
            this.txtFrontArbMax.TabIndex = 4;
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
            this.txtFrontArbMin.TextChanged += new System.EventHandler(this.txtFrontArbMin_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 55);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Rear (min/max)";
            // 
            // txtRearArbMin
            // 
            this.txtRearArbMin.Location = new System.Drawing.Point(112, 55);
            this.txtRearArbMin.Name = "txtRearArbMin";
            this.txtRearArbMin.Size = new System.Drawing.Size(58, 20);
            this.txtRearArbMin.TabIndex = 1;
            this.txtRearArbMin.TextChanged += new System.EventHandler(this.txtRearArbMin_TextChanged);
            // 
            // gbResArb
            // 
            this.gbResArb.Controls.Add(this.label14);
            this.gbResArb.Controls.Add(this.label15);
            this.gbResArb.Controls.Add(this.resRearArb);
            this.gbResArb.Controls.Add(this.resFrontArb);
            this.gbResArb.Location = new System.Drawing.Point(6, 257);
            this.gbResArb.Name = "gbResArb";
            this.gbResArb.Size = new System.Drawing.Size(308, 100);
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
            this.label15.Location = new System.Drawing.Point(6, 55);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(73, 13);
            this.label15.TabIndex = 3;
            this.label15.Text = "Rear Stiffness";
            // 
            // resRearArb
            // 
            this.resRearArb.AutoSize = true;
            this.resRearArb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resRearArb.ForeColor = System.Drawing.Color.SeaGreen;
            this.resRearArb.Location = new System.Drawing.Point(90, 50);
            this.resRearArb.Name = "resRearArb";
            this.resRearArb.Size = new System.Drawing.Size(57, 20);
            this.resRearArb.TabIndex = 11;
            this.resRearArb.Text = "label1";
            this.resRearArb.Visible = false;
            this.resRearArb.Click += new System.EventHandler(this.label16_Click);
            // 
            // resFrontArb
            // 
            this.resFrontArb.AutoSize = true;
            this.resFrontArb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resFrontArb.ForeColor = System.Drawing.Color.SeaGreen;
            this.resFrontArb.Location = new System.Drawing.Point(90, 11);
            this.resFrontArb.Name = "resFrontArb";
            this.resFrontArb.Size = new System.Drawing.Size(57, 20);
            this.resFrontArb.TabIndex = 12;
            this.resFrontArb.Text = "label1";
            this.resFrontArb.Visible = false;
            this.resFrontArb.Click += new System.EventHandler(this.label17_Click);
            // 
            // ForzaTuningCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbResults);
            this.Controls.Add(this.gbInputs);
            this.Controls.Add(this.btnTune);
            this.Name = "ForzaTuningCalc";
            this.Text = "Forza Tuning Calculator";
            this.gbWeight.ResumeLayout(false);
            this.gbWeight.PerformLayout();
            this.gbDamping.ResumeLayout(false);
            this.gbDamping.PerformLayout();
            this.gbSprings.ResumeLayout(false);
            this.gbSprings.PerformLayout();
            this.gbInputs.ResumeLayout(false);
            this.gbInputs.PerformLayout();
            this.gbResults.ResumeLayout(false);
            this.gbDampingRes.ResumeLayout(false);
            this.gbDampingRes.PerformLayout();
            this.gbSpringsRes.ResumeLayout(false);
            this.gbSpringsRes.PerformLayout();
            this.gbArbs.ResumeLayout(false);
            this.gbArbs.PerformLayout();
            this.gbResArb.ResumeLayout(false);
            this.gbResArb.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblFrontWeight;
        private System.Windows.Forms.TextBox txtFrontWeight;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.GroupBox gbWeight;
        private System.Windows.Forms.GroupBox gbDamping;
        private System.Windows.Forms.TextBox txtRebMax;
        private System.Windows.Forms.Label lblRebound;
        private System.Windows.Forms.TextBox txtRebMin;
        private System.Windows.Forms.GroupBox gbSprings;
        private System.Windows.Forms.TextBox txtRearSpringMax;
        private System.Windows.Forms.TextBox txtFrontSpringMax;
        private System.Windows.Forms.Label lblFrontSpring;
        private System.Windows.Forms.TextBox txtFrontSpringMin;
        private System.Windows.Forms.Label lblRearSpring;
        private System.Windows.Forms.TextBox txtRearSpringMin;
        private System.Windows.Forms.Button btnTune;
        private System.Windows.Forms.Label resRebFront;
        private System.Windows.Forms.Label resRebRear;
        private System.Windows.Forms.Label resBumpRear;
        private System.Windows.Forms.Label resBumpFront;
        private System.Windows.Forms.Label resSpringRear;
        private System.Windows.Forms.Label resSpringFront;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
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
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtRearArbMax;
        private System.Windows.Forms.TextBox txtFrontArbMax;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtFrontArbMin;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtRearArbMin;
        private System.Windows.Forms.GroupBox gbResArb;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label resRearArb;
        private System.Windows.Forms.Label resFrontArb;
    }
}

