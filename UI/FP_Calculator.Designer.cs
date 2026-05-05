namespace Function_Point_Calculator
{
    partial class FP_Calculator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            txtEIF_Complex = new TextBox();
            txtEQ_Complex = new TextBox();
            txtILF_Complex = new TextBox();
            txtEO_Complex = new TextBox();
            txtEI_Complex = new TextBox();
            txtEIF_Avg = new TextBox();
            txtEQ_Avg = new TextBox();
            txtILF_Avg = new TextBox();
            txtEO_Avg = new TextBox();
            txtEI_Avg = new TextBox();
            txtEIF_Simple = new TextBox();
            txtEQ_Simple = new TextBox();
            txtILF_Simple = new TextBox();
            txtEO_Simple = new TextBox();
            txtEI_Simple = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            label12 = new Label();
            cmbLanguage = new ComboBox();
            label7 = new Label();
            btnManualDI = new Button();
            txtDI = new TextBox();
            label6 = new Label();
            panel1 = new Panel();
            btnCalcFP = new Button();
            lblLOCResult = new Label();
            lblFPResult = new Label();
            lblTCFResult = new Label();
            lblUFPResult = new Label();
            btnCalcLOC = new Button();
            btnCalcTCF = new Button();
            btnCalcUFP = new Button();
            panel2 = new Panel();
            btnClose = new Button();
            btnReset = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtEIF_Complex);
            groupBox1.Controls.Add(txtEQ_Complex);
            groupBox1.Controls.Add(txtILF_Complex);
            groupBox1.Controls.Add(txtEO_Complex);
            groupBox1.Controls.Add(txtEI_Complex);
            groupBox1.Controls.Add(txtEIF_Avg);
            groupBox1.Controls.Add(txtEQ_Avg);
            groupBox1.Controls.Add(txtILF_Avg);
            groupBox1.Controls.Add(txtEO_Avg);
            groupBox1.Controls.Add(txtEI_Avg);
            groupBox1.Controls.Add(txtEIF_Simple);
            groupBox1.Controls.Add(txtEQ_Simple);
            groupBox1.Controls.Add(txtILF_Simple);
            groupBox1.Controls.Add(txtEO_Simple);
            groupBox1.Controls.Add(txtEI_Simple);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1074, 375);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.FromArgb(45, 45, 48);
            label11.Location = new Point(6, -3);
            label11.Name = "label11";
            label11.Size = new Size(264, 23);
            label11.TabIndex = 24;
            label11.Text = "Unadjusted Function Points (UFP)";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Location = new Point(848, 54);
            label10.Name = "label10";
            label10.Size = new Size(129, 23);
            label10.TabIndex = 23;
            label10.Text = "Complex Count";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Location = new Point(589, 54);
            label9.Name = "label9";
            label9.Size = new Size(124, 23);
            label9.TabIndex = 22;
            label9.Text = "Average Count";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Location = new Point(327, 54);
            label8.Name = "label8";
            label8.Size = new Size(113, 23);
            label8.TabIndex = 21;
            label8.Text = "Simple Count";
            // 
            // txtEIF_Complex
            // 
            txtEIF_Complex.BackColor = Color.FromArgb(51, 51, 55);
            txtEIF_Complex.BorderStyle = BorderStyle.FixedSingle;
            txtEIF_Complex.ForeColor = Color.White;
            txtEIF_Complex.Location = new Point(830, 297);
            txtEIF_Complex.Name = "txtEIF_Complex";
            txtEIF_Complex.Size = new Size(208, 30);
            txtEIF_Complex.TabIndex = 20;
            txtEIF_Complex.Text = "0";
            // 
            // txtEQ_Complex
            // 
            txtEQ_Complex.BackColor = Color.FromArgb(51, 51, 55);
            txtEQ_Complex.BorderStyle = BorderStyle.FixedSingle;
            txtEQ_Complex.ForeColor = Color.White;
            txtEQ_Complex.Location = new Point(830, 201);
            txtEQ_Complex.Name = "txtEQ_Complex";
            txtEQ_Complex.Size = new Size(208, 30);
            txtEQ_Complex.TabIndex = 19;
            txtEQ_Complex.Text = "0";
            // 
            // txtILF_Complex
            // 
            txtILF_Complex.BackColor = Color.FromArgb(51, 51, 55);
            txtILF_Complex.BorderStyle = BorderStyle.FixedSingle;
            txtILF_Complex.ForeColor = Color.White;
            txtILF_Complex.Location = new Point(830, 250);
            txtILF_Complex.Name = "txtILF_Complex";
            txtILF_Complex.Size = new Size(208, 30);
            txtILF_Complex.TabIndex = 18;
            txtILF_Complex.Text = "0";
            // 
            // txtEO_Complex
            // 
            txtEO_Complex.BackColor = Color.FromArgb(51, 51, 55);
            txtEO_Complex.BorderStyle = BorderStyle.FixedSingle;
            txtEO_Complex.ForeColor = Color.White;
            txtEO_Complex.Location = new Point(830, 149);
            txtEO_Complex.Name = "txtEO_Complex";
            txtEO_Complex.Size = new Size(208, 30);
            txtEO_Complex.TabIndex = 17;
            txtEO_Complex.Text = "0";
            // 
            // txtEI_Complex
            // 
            txtEI_Complex.BackColor = Color.FromArgb(51, 51, 55);
            txtEI_Complex.BorderStyle = BorderStyle.FixedSingle;
            txtEI_Complex.ForeColor = Color.White;
            txtEI_Complex.Location = new Point(830, 103);
            txtEI_Complex.Name = "txtEI_Complex";
            txtEI_Complex.Size = new Size(208, 30);
            txtEI_Complex.TabIndex = 16;
            txtEI_Complex.Text = "0";
            // 
            // txtEIF_Avg
            // 
            txtEIF_Avg.BackColor = Color.FromArgb(51, 51, 55);
            txtEIF_Avg.BorderStyle = BorderStyle.FixedSingle;
            txtEIF_Avg.ForeColor = Color.White;
            txtEIF_Avg.Location = new Point(564, 297);
            txtEIF_Avg.Name = "txtEIF_Avg";
            txtEIF_Avg.Size = new Size(208, 30);
            txtEIF_Avg.TabIndex = 15;
            txtEIF_Avg.Text = "0";
            // 
            // txtEQ_Avg
            // 
            txtEQ_Avg.BackColor = Color.FromArgb(51, 51, 55);
            txtEQ_Avg.BorderStyle = BorderStyle.FixedSingle;
            txtEQ_Avg.ForeColor = Color.White;
            txtEQ_Avg.Location = new Point(564, 201);
            txtEQ_Avg.Name = "txtEQ_Avg";
            txtEQ_Avg.Size = new Size(208, 30);
            txtEQ_Avg.TabIndex = 14;
            txtEQ_Avg.Text = "0";
            // 
            // txtILF_Avg
            // 
            txtILF_Avg.BackColor = Color.FromArgb(51, 51, 55);
            txtILF_Avg.BorderStyle = BorderStyle.FixedSingle;
            txtILF_Avg.ForeColor = Color.White;
            txtILF_Avg.Location = new Point(564, 250);
            txtILF_Avg.Name = "txtILF_Avg";
            txtILF_Avg.Size = new Size(208, 30);
            txtILF_Avg.TabIndex = 13;
            txtILF_Avg.Text = "0";
            // 
            // txtEO_Avg
            // 
            txtEO_Avg.BackColor = Color.FromArgb(51, 51, 55);
            txtEO_Avg.BorderStyle = BorderStyle.FixedSingle;
            txtEO_Avg.ForeColor = Color.White;
            txtEO_Avg.Location = new Point(564, 149);
            txtEO_Avg.Name = "txtEO_Avg";
            txtEO_Avg.Size = new Size(208, 30);
            txtEO_Avg.TabIndex = 12;
            txtEO_Avg.Text = "0";
            // 
            // txtEI_Avg
            // 
            txtEI_Avg.BackColor = Color.FromArgb(51, 51, 55);
            txtEI_Avg.BorderStyle = BorderStyle.FixedSingle;
            txtEI_Avg.ForeColor = Color.White;
            txtEI_Avg.Location = new Point(564, 103);
            txtEI_Avg.Name = "txtEI_Avg";
            txtEI_Avg.Size = new Size(208, 30);
            txtEI_Avg.TabIndex = 11;
            txtEI_Avg.Text = "0";
            // 
            // txtEIF_Simple
            // 
            txtEIF_Simple.BackColor = Color.FromArgb(51, 51, 55);
            txtEIF_Simple.BorderStyle = BorderStyle.FixedSingle;
            txtEIF_Simple.ForeColor = Color.White;
            txtEIF_Simple.Location = new Point(298, 296);
            txtEIF_Simple.Name = "txtEIF_Simple";
            txtEIF_Simple.Size = new Size(208, 30);
            txtEIF_Simple.TabIndex = 10;
            txtEIF_Simple.Text = "0";
            // 
            // txtEQ_Simple
            // 
            txtEQ_Simple.BackColor = Color.FromArgb(51, 51, 55);
            txtEQ_Simple.BorderStyle = BorderStyle.FixedSingle;
            txtEQ_Simple.ForeColor = Color.White;
            txtEQ_Simple.Location = new Point(298, 196);
            txtEQ_Simple.Name = "txtEQ_Simple";
            txtEQ_Simple.Size = new Size(208, 30);
            txtEQ_Simple.TabIndex = 9;
            txtEQ_Simple.Text = "0";
            // 
            // txtILF_Simple
            // 
            txtILF_Simple.BackColor = Color.FromArgb(51, 51, 55);
            txtILF_Simple.BorderStyle = BorderStyle.FixedSingle;
            txtILF_Simple.ForeColor = Color.White;
            txtILF_Simple.Location = new Point(298, 245);
            txtILF_Simple.Name = "txtILF_Simple";
            txtILF_Simple.Size = new Size(208, 30);
            txtILF_Simple.TabIndex = 8;
            txtILF_Simple.Text = "0";
            // 
            // txtEO_Simple
            // 
            txtEO_Simple.BackColor = Color.FromArgb(51, 51, 55);
            txtEO_Simple.BorderStyle = BorderStyle.FixedSingle;
            txtEO_Simple.ForeColor = Color.White;
            txtEO_Simple.Location = new Point(298, 148);
            txtEO_Simple.Name = "txtEO_Simple";
            txtEO_Simple.Size = new Size(208, 30);
            txtEO_Simple.TabIndex = 7;
            txtEO_Simple.Text = "0";
            // 
            // txtEI_Simple
            // 
            txtEI_Simple.BackColor = Color.FromArgb(51, 51, 55);
            txtEI_Simple.BorderStyle = BorderStyle.FixedSingle;
            txtEI_Simple.ForeColor = Color.White;
            txtEI_Simple.Location = new Point(298, 102);
            txtEI_Simple.Name = "txtEI_Simple";
            txtEI_Simple.Size = new Size(208, 30);
            txtEI_Simple.TabIndex = 6;
            txtEI_Simple.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Location = new Point(29, 203);
            label5.Name = "label5";
            label5.Size = new Size(129, 23);
            label5.TabIndex = 5;
            label5.Text = "External Inquiry";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(29, 302);
            label4.Name = "label4";
            label4.Size = new Size(180, 23);
            label4.TabIndex = 4;
            label4.Text = "External Interface Files";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(29, 252);
            label3.Name = "label3";
            label3.Size = new Size(164, 23);
            label3.TabIndex = 3;
            label3.Text = "Internal Logical Files";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(29, 154);
            label2.Name = "label2";
            label2.Size = new Size(131, 23);
            label2.TabIndex = 2;
            label2.Text = "External Output";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(29, 103);
            label1.Name = "label1";
            label1.Size = new Size(117, 23);
            label1.TabIndex = 1;
            label1.Text = "External Input";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(cmbLanguage);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(btnManualDI);
            groupBox2.Controls.Add(txtDI);
            groupBox2.Controls.Add(label6);
            groupBox2.Location = new Point(12, 393);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1074, 204);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.FromArgb(45, 45, 48);
            label12.Location = new Point(6, -2);
            label12.Name = "label12";
            label12.Size = new Size(209, 23);
            label12.TabIndex = 25;
            label12.Text = "Complexity and Language";
            // 
            // cmbLanguage
            // 
            cmbLanguage.BackColor = Color.FromArgb(51, 51, 55);
            cmbLanguage.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbLanguage.FlatStyle = FlatStyle.Flat;
            cmbLanguage.ForeColor = Color.White;
            cmbLanguage.FormattingEnabled = true;
            cmbLanguage.Location = new Point(403, 135);
            cmbLanguage.Name = "cmbLanguage";
            cmbLanguage.Size = new Size(208, 31);
            cmbLanguage.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Location = new Point(111, 135);
            label7.Name = "label7";
            label7.Size = new Size(137, 23);
            label7.TabIndex = 13;
            label7.Text = "Target Language";
            // 
            // btnManualDI
            // 
            btnManualDI.BackColor = Color.FromArgb(62, 62, 66);
            btnManualDI.Cursor = Cursors.Hand;
            btnManualDI.FlatAppearance.BorderSize = 0;
            btnManualDI.FlatStyle = FlatStyle.Flat;
            btnManualDI.ForeColor = Color.White;
            btnManualDI.Location = new Point(728, 50);
            btnManualDI.Name = "btnManualDI";
            btnManualDI.Size = new Size(224, 121);
            btnManualDI.TabIndex = 12;
            btnManualDI.Text = "Calculate DI Manually";
            btnManualDI.UseVisualStyleBackColor = false;
            btnManualDI.Click += btnManualDI_Click;
            // 
            // txtDI
            // 
            txtDI.BackColor = Color.FromArgb(51, 51, 55);
            txtDI.BorderStyle = BorderStyle.FixedSingle;
            txtDI.ForeColor = Color.White;
            txtDI.Location = new Point(403, 50);
            txtDI.Name = "txtDI";
            txtDI.Size = new Size(208, 30);
            txtDI.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Location = new Point(111, 50);
            label6.Name = "label6";
            label6.Size = new Size(160, 23);
            label6.TabIndex = 11;
            label6.Text = "Degree of Influence";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(btnCalcFP);
            panel1.Controls.Add(lblLOCResult);
            panel1.Controls.Add(lblFPResult);
            panel1.Controls.Add(lblTCFResult);
            panel1.Controls.Add(lblUFPResult);
            panel1.Controls.Add(btnCalcLOC);
            panel1.Controls.Add(btnCalcTCF);
            panel1.Controls.Add(btnCalcUFP);
            panel1.Location = new Point(1150, 26);
            panel1.Name = "panel1";
            panel1.Size = new Size(348, 507);
            panel1.TabIndex = 2;
            // 
            // btnCalcFP
            // 
            btnCalcFP.BackColor = Color.FromArgb(0, 122, 204);
            btnCalcFP.Cursor = Cursors.Hand;
            btnCalcFP.FlatAppearance.BorderSize = 0;
            btnCalcFP.FlatStyle = FlatStyle.Flat;
            btnCalcFP.ForeColor = Color.White;
            btnCalcFP.Location = new Point(62, 250);
            btnCalcFP.Name = "btnCalcFP";
            btnCalcFP.Size = new Size(224, 40);
            btnCalcFP.TabIndex = 22;
            btnCalcFP.Text = "Calculate Final FP";
            btnCalcFP.UseVisualStyleBackColor = false;
            btnCalcFP.Click += button1_Click;
            // 
            // lblLOCResult
            // 
            lblLOCResult.AutoSize = true;
            lblLOCResult.BackColor = Color.Transparent;
            lblLOCResult.Location = new Point(99, 457);
            lblLOCResult.Name = "lblLOCResult";
            lblLOCResult.Size = new Size(162, 23);
            lblLOCResult.TabIndex = 21;
            lblLOCResult.Text = "Est. Lines of Code: 0";
            // 
            // lblFPResult
            // 
            lblFPResult.AutoSize = true;
            lblFPResult.BackColor = Color.Transparent;
            lblFPResult.Location = new Point(99, 327);
            lblFPResult.Name = "lblFPResult";
            lblFPResult.Size = new Size(145, 23);
            lblFPResult.TabIndex = 20;
            lblFPResult.Text = "Function Points: 0";
            // 
            // lblTCFResult
            // 
            lblTCFResult.AutoSize = true;
            lblTCFResult.BackColor = Color.Transparent;
            lblTCFResult.Location = new Point(124, 201);
            lblTCFResult.Name = "lblTCFResult";
            lblTCFResult.Size = new Size(77, 23);
            lblTCFResult.TabIndex = 19;
            lblTCFResult.Text = "TCF: 0.00";
            // 
            // lblUFPResult
            // 
            lblUFPResult.AutoSize = true;
            lblUFPResult.BackColor = Color.Transparent;
            lblUFPResult.Location = new Point(111, 92);
            lblUFPResult.Name = "lblUFPResult";
            lblUFPResult.Size = new Size(99, 23);
            lblUFPResult.TabIndex = 18;
            lblUFPResult.Text = "Total UFP: 0";
            // 
            // btnCalcLOC
            // 
            btnCalcLOC.BackColor = Color.FromArgb(0, 122, 204);
            btnCalcLOC.Cursor = Cursors.Hand;
            btnCalcLOC.FlatAppearance.BorderSize = 0;
            btnCalcLOC.FlatStyle = FlatStyle.Flat;
            btnCalcLOC.ForeColor = Color.White;
            btnCalcLOC.Location = new Point(62, 378);
            btnCalcLOC.Name = "btnCalcLOC";
            btnCalcLOC.Size = new Size(224, 40);
            btnCalcLOC.TabIndex = 17;
            btnCalcLOC.Text = "Calculate Est. LOC";
            btnCalcLOC.UseVisualStyleBackColor = false;
            btnCalcLOC.Click += btnCalcFP_Click;
            // 
            // btnCalcTCF
            // 
            btnCalcTCF.BackColor = Color.FromArgb(0, 122, 204);
            btnCalcTCF.Cursor = Cursors.Hand;
            btnCalcTCF.FlatAppearance.BorderSize = 0;
            btnCalcTCF.FlatStyle = FlatStyle.Flat;
            btnCalcTCF.ForeColor = Color.White;
            btnCalcTCF.Location = new Point(62, 140);
            btnCalcTCF.Name = "btnCalcTCF";
            btnCalcTCF.Size = new Size(224, 40);
            btnCalcTCF.TabIndex = 16;
            btnCalcTCF.Text = "Calculate TCF";
            btnCalcTCF.UseVisualStyleBackColor = false;
            btnCalcTCF.Click += btnCalcTCF_Click;
            // 
            // btnCalcUFP
            // 
            btnCalcUFP.BackColor = Color.FromArgb(0, 122, 204);
            btnCalcUFP.Cursor = Cursors.Hand;
            btnCalcUFP.FlatAppearance.BorderSize = 0;
            btnCalcUFP.FlatStyle = FlatStyle.Flat;
            btnCalcUFP.ForeColor = Color.White;
            btnCalcUFP.Location = new Point(62, 28);
            btnCalcUFP.Name = "btnCalcUFP";
            btnCalcUFP.Size = new Size(224, 40);
            btnCalcUFP.TabIndex = 15;
            btnCalcUFP.Text = "Calculate UFP";
            btnCalcUFP.UseVisualStyleBackColor = false;
            btnCalcUFP.Click += btnCalcUFP_Click;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(btnClose);
            panel2.Controls.Add(btnReset);
            panel2.ForeColor = Color.White;
            panel2.Location = new Point(1150, 539);
            panel2.Name = "panel2";
            panel2.Size = new Size(348, 58);
            panel2.TabIndex = 3;
            // 
            // btnClose
            // 
            btnClose.AccessibleName = "";
            btnClose.BackColor = Color.FromArgb(0, 122, 204);
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(183, 13);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(103, 31);
            btnClose.TabIndex = 0;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnReset
            // 
            btnReset.AccessibleName = "";
            btnReset.BackColor = Color.FromArgb(0, 122, 204);
            btnReset.Cursor = Cursors.Hand;
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.ForeColor = Color.White;
            btnReset.Location = new Point(62, 13);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(103, 31);
            btnReset.TabIndex = 0;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // FP_Calculator
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 45, 48);
            ClientSize = new Size(1543, 609);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 10F);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FP_Calculator";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FP Calculator";
            Load += FP_Calculator_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private TextBox txtEI_Simple;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtEIF_Simple;
        private TextBox txtEQ_Simple;
        private TextBox txtILF_Simple;
        private TextBox txtEO_Simple;
        private GroupBox groupBox2;
        private Label label7;
        private Button btnManualDI;
        private TextBox txtDI;
        private Label label6;
        private ComboBox cmbLanguage;
        private Panel panel1;
        private Button btnCalcLOC;
        private Button btnCalcTCF;
        private Button btnCalcUFP;
        private Label lblLOCResult;
        private Label lblFPResult;
        private Label lblTCFResult;
        private Label lblUFPResult;
        private TextBox txtEIF_Complex;
        private TextBox txtEQ_Complex;
        private TextBox txtILF_Complex;
        private TextBox txtEO_Complex;
        private TextBox txtEI_Complex;
        private TextBox txtEIF_Avg;
        private TextBox txtEQ_Avg;
        private TextBox txtILF_Avg;
        private TextBox txtEO_Avg;
        private TextBox txtEI_Avg;
        private Label label10;
        private Label label9;
        private Label label8;
        private Button btnCalcFP;
        private Label label11;
        private Label label12;
        private Panel panel2;
        private Button btnReset;
        private Button btnClose;
    }
}
